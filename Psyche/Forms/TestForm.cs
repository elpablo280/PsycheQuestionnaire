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

        public TestForm(string testFilepath, User currentUser)
        {
            InitializeComponent();
            CurrentUser = currentUser;

            // парсим тест из файла
            TestParser tp = new();
            Test = tp.ParseTest(testFilepath);

            Text = Test.Name;
            TimeLeft = Test.TimeLimit;

            UpdateForm(Test.Questions[currentQuestionIndex]);
            timer1.Start();
            StartTime = DateTime.Now;
        }

        private void nextQuestionButton_Click(object sender, EventArgs e, bool? value)
        {
            Answers.Add(value);
            currentQuestionIndex++;
            if (currentQuestionIndex >= Test.Questions.Length)
            {
                EndTime = DateTime.Now;
                TestEndForm testEndForm = new(CurrentUser, Answers);
                testEndForm.Show();

                Close();
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
                    Location = new Point(10 + 100 * i, 50),
                    Text = variant.Text
                };
                button.Click += (sender, EventArgs) =>
                {
                    nextQuestionButton_Click(sender, EventArgs, variant.Value);
                };
                Controls.Add(button);

                i++;
            }
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
                timerLable.Text = "Время вышло!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
            }
        }
    }
}
