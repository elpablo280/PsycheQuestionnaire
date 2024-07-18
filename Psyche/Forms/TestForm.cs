using Psyche.Forms;
using Psyche.Models;
using Psyche.Workers;

namespace Psyche
{
    public partial class TestForm : Form
    {
        private int currentQuestionIndex = 0;
        private Test Test;
        private int TimeLeft = 30;
        private DateTime TestStartDateTime;
        private DateTime TestEndDateTime;
        private List<bool?> Answers = new();

        public TestForm(string testFilepath)
        {
            InitializeComponent();
            this.Text = new FileInfo(testFilepath).Name.Replace(".json", string.Empty);

            TestStartDateTime = DateTime.Now;

            timer1.Start();

            // парсим тест из файла
            TestParser tp = new();
            Test = tp.ParseTest(testFilepath);

            UpdateForm(Test.Questions[currentQuestionIndex]);
        }

        private void nextQuestionButton_Click(object sender, EventArgs e, bool? value)
        {
            Answers.Add(value);
            currentQuestionIndex++;
            if (currentQuestionIndex >= Test.Questions.Length)
            {
                // завершить тест и открыть форму проверки уровня доступа

                TestEndDateTime = DateTime.Now;

                TestEndForm testEndForm = new();
                testEndForm.Show();

                this.Close();
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
                if (this.Controls.ContainsKey(buttonKey))
                {
                    this.Controls.RemoveByKey(buttonKey);
                }
                Button button = new()
                {   
                    Name = buttonKey,
                    Location = new Point(10 + 100 * i, 50),
                    Text = variant.Text
                };
                button.Click += (sender, EventArgs) =>
                {
                    nextQuestionButton_Click(sender, EventArgs, variant.Value);
                };
                this.Controls.Add(button);

                i++;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (TimeLeft > 0)
            {
                TimeLeft--;
                timerLable.Text = "Таймер: " + TimeLeft;
            }
            else
            {
                timer1.Stop();
                timerLable.Text = "Время вышло!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
            }
        }
    }
}
