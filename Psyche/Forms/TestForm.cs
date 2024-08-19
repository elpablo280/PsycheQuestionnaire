using Microsoft.Data.Sqlite;
using Psyche.Forms;
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
        private readonly List<bool?> Answers = new();
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

        private void NextQuestionButton_Click(object sender, EventArgs e, bool? value)
        {
            Answers.Add(value);
            currentQuestionIndex++;
            if (currentQuestionIndex >= Test.Questions.Length)
            {
                EndTime = DateTime.Now;

                // собираем строки для автогенерации и автозаполнения таблицы
                string createTableString1 = "";
                string createTableString2 = "";
                string insertTableString = "";
                for (int i = 0; i < Answers.Count; i++)
                {
                    createTableString1 += $"Question{i + 1} TEXT NOT NULL, ";
                    createTableString2 += $"Question{i + 1}, ";
                    insertTableString += $"{Answers[i].Value.ToString()}, ";
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
                        CommandText = $"CREATE TABLE IF NOT EXISTS {Test.NameDB}(ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, UserName TEXT NOT NULL, UserPlatoon TEXT NOT NULL, StartTime TEXT NOT NULL, EndTime TEXT NOT NULL, {createTableString1})",
                    };
                    commandCreate.ExecuteNonQuery();
                    MessageBox.Show($"Таблица {Test.NameDB} создана");

                    // добавляем запись о прохождении теста в базу
                    SqliteCommand commandInsert = new()
                    {
                        Connection = connection,
                        CommandText = $"INSERT INTO {Test.NameDB} (UserName, UserPlatoon, StartTime, EndTime, {createTableString2}) VALUES ('{FIO}', '{CurrentUser.Platoon}', '{StartTime.ToString()}', '{EndTime.ToString()}', {insertTableString})"
                    };
                    commandInsert.ExecuteNonQuery();
                    MessageBox.Show($"Результат сохранён в таблицу {Test.NameDB}");
                }

                SetNextTest();
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
                    Location = new Point(10 + 100 * i, 50),
                    Text = variant.Text
                };
                button.Click += (sender, EventArgs) =>
                {
                    NextQuestionButton_Click(sender, EventArgs, variant.Value);
                };
                Controls.Add(button);

                i++;
            }
        }

        private void SetNextTest()
        {
            // если больше нет тестов в очереди, переходим на завершающую форму
            if (!TestsMenuForm.SelectNextTest(CurrentUser))
            {
                TestEndForm testEndForm = new(CurrentUser, Answers, Config);
                testEndForm.Show();
            }

            Close();
            return;
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
