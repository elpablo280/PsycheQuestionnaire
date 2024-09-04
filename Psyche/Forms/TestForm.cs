using Microsoft.Data.Sqlite;
using Psyche.Forms;
using Psyche.Handlers;
using Psyche.Models;
using Psyche.Workers;

namespace Psyche
{
    public partial class TestForm : Form
    {
        private int currentQuestionIndex = 0;
        private readonly Test Test;
        private int TimeLeft;
        private DateTime StartTime;
        private DateTime EndTime;
        private readonly List<int> Answers = new();
        private readonly User CurrentUser;
        private readonly Config Config;
        readonly TestsMenuForm TestsMenuForm;

        public TestForm(string testFilepath, User currentUser, Config config, TestsMenuForm testsMenuForm)
        {
            InitializeComponent();
            CurrentUser = currentUser;
            Config = config;
            TestsMenuForm = testsMenuForm;

            // парсим тест из файла
            TestParser tp = new();
            Test = tp.ParseTest(testFilepath);

            Text = Test.Name;
            TimeLeft = Test.TimeLimit;

            UpdateForm(Test.Questions[currentQuestionIndex]);
            timer1.Start();

            timerLable.Visible = TestsMenuForm.MainMenu.ShowTimer;

            StartTime = DateTime.Now;
        }

        private void NextQuestionButton_Click(object sender, EventArgs e, int value)
        {
            Answers.Add(value);
            currentQuestionIndex++;
            // создаём таблицу, высчитываем и записываем результат в конце теста
            if (currentQuestionIndex >= Test.Questions.Length)
            {
                EndTime = DateTime.Now;

                // собираем строки для автогенерации и автозаполнения таблицы
                string createTableString1 = "";
                string createTableString2 = "";
                string insertTableString = "";
                string resultString = "";

                switch (Test.Name)
                {
                    case "Тест СР-45":
                        resultString = $"{new SR45Handler(Answers).GetResult()}{Environment.NewLine}";
                        break;
                    case "Тест КОС-2":
                        resultString = $"{new KOS2Handler(Answers).GetResult()}{Environment.NewLine}";
                        break;
                    case "Шкала тревоги Спилберга":
                        resultString = $"{new STAIHandler(Answers).GetResult()}{Environment.NewLine}";
                        break;
                    case "Тест Прогноз-2-02":
                        resultString = $"{new Prognoz202Handler(Answers).GetResult()}{Environment.NewLine}";
                        break;
                    case "Типы поведения в конфликте (К. Томас)":
                        resultString = $"{new ConflictTomasHandler(Answers).GetResult()}{Environment.NewLine}";
                        break;
                    case "Методика диагностики соц.-псих. установок личности":
                        resultString = $"{new PotemkinaHandler(Answers).GetResult()}{Environment.NewLine}";
                        break;
                    case "Методика Айзенка по определению темперамента":
                        resultString = $"{new IsenkTemperamentHandler(Answers).GetResult()}{Environment.NewLine}";
                        break;
                    case "Опросник Леонгарда-Шмишека":
                        resultString = $"{new LeongardShmishekHandler(Answers).GetResult()}{Environment.NewLine}";
                        break;
                    case "Опросник Адаптивность-02":
                        resultString = $"{new Adaptivnost02Handler(Answers).GetResult()}{Environment.NewLine}";
                        break;
                    case "Личностная шкала проявления тревоги (Дж. Тейлор)":
                        resultString = $"{new TrevogaTaylorHandler(Answers).GetResult()}{Environment.NewLine}";
                        break;
                    case "Стратегии преодоления стрессовых ситуаций":
                        resultString = $"{new SACSHandler(Answers).GetResult()}{Environment.NewLine}";
                        break;
                    case "Индекс жизненного стиля":
                        resultString = $"{new LSIHandler(Answers).GetResult()}{Environment.NewLine}";
                        break;
                    case "Методика диагностики уровня профессионального выгорания Бойко":
                        resultString = $"{new BurnoutBoykoHandler(Answers).GetResult()}{Environment.NewLine}";
                        break;
                    case "Опросник уровня агрессивности Басса-Дарки":
                        resultString = $"{new BDHIHandler(Answers).GetResult()}{Environment.NewLine}";
                        break;
                    default:
                        resultString = "Ошибка! Надо внести тест в TestForm";
                        break;        // todo добавлять тесты сюда тоже
                }

                for (int i = 0; i < Answers.Count; i++)
                {
                    createTableString1 += $"Question{i + 1} INTEGER NOT NULL, ";
                    createTableString2 += $"Question{i + 1}, ";
                    insertTableString += $"{Answers[i]}, ";
                }
                // убираем "хвост" из строк (который ", ")
                createTableString1 = createTableString1.Remove(createTableString1.Length - 2);
                createTableString2 = createTableString2.Remove(createTableString2.Length - 2);
                insertTableString = insertTableString.Remove(insertTableString.Length - 2);

                string FIO = $"{CurrentUser.Name}";

                // todo создаём таблицу по текущему тесту (если её нет) и добавляем туда запись с результатом
                using (var connection = new SqliteConnection(Config.ConnectionStrings.UsersDB))
                {
                    connection.Open();

                    // создаём таблицу (если она не создана) с тестом
                    SqliteCommand commandCreate = new()
                    {
                        Connection = connection,
                        CommandText = $"CREATE TABLE IF NOT EXISTS {Test.NameDB}(ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, UserName TEXT NOT NULL, UserPlatoon TEXT NOT NULL, Result TEXT NOT NULL, StartTime TEXT NOT NULL, EndTime TEXT NOT NULL, {createTableString1})",
                    };
                    
                    commandCreate.ExecuteNonQuery();
                    //MessageBox.Show($"Таблица {Test.NameDB} создана");

                    // добавляем запись о прохождении теста в базу
                    SqliteCommand commandInsert = new()
                    {
                        Connection = connection,
                        CommandText = $"INSERT INTO {Test.NameDB} (UserName, UserPlatoon, Result, StartTime, EndTime, {createTableString2}) VALUES ('{FIO}', '{CurrentUser.Platoon}', '{resultString}', '{StartTime}', '{EndTime}', {insertTableString})"
                    };
                    commandInsert.ExecuteNonQuery();
                    //MessageBox.Show($"Результат сохранён в таблицу {Test.NameDB}");
                }

                SetNextTest();
                return;
            }

            UpdateForm(Test.Questions[currentQuestionIndex]);
        }

        private void UpdateForm(Question question)
        {
            questionLabel.Text = question.Text;

            int i = 0;
            foreach (var variant in question.Variants)
            {
                string buttonKey = "btn" + i;
                if (Controls.ContainsKey(buttonKey))
                {
                    Controls.RemoveByKey(buttonKey);
                }
                Button button = new()
                {
                    Name = buttonKey,
                    Location = new Point(10 + i, 50),
                    //Location = new Point(10 + 100 * i, 50),
                    Text = variant.Text,
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowOnly
                };
                button.Click += (sender, EventArgs) =>
                {
                    NextQuestionButton_Click(sender, EventArgs, variant.Value);
                };
                Controls.Add(button);

                i += button.Width + 10;            // задаём сдвиг для следующей кнопки
            }
        }

        private void SetNextTest()
        {
            // если больше нет тестов в очереди, переходим на завершающую форму
            if (!TestsMenuForm.SelectNextTest(CurrentUser))
            {
                TestEndForm testEndForm = new(CurrentUser, Config);
                testEndForm.Show();
            }

            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TimeLeft > 0)
            {
                timerLable.Text = "Таймер: " + TimeLeft;
                TimeLeft--;
            }
            else
            {
                timer1.Stop();
                if (TestsMenuForm.MainMenu.GoToNextTestWhenTimerIsOver)
                {
                    SetNextTest();
                }
                else
                {
                    timerLable.Text = "Время вышло!";
                    MessageBox.Show("You didn't finish in time.", "Sorry!");
                }
            }
        }
    }
}
