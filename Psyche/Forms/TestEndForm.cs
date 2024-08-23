using Psyche.Models;

namespace Psyche.Forms
{
    public partial class TestEndForm : Form
    {
        private readonly string Password = "1111";            // todo
        private readonly User CurrentUser;
        private readonly List<int> Answers = new();
        private readonly Config Config;

        public TestEndForm(User currentUser, List<int> answers, Config config)
        {
            InitializeComponent();
            CurrentUser = currentUser;
            Answers = answers;
            Config = config;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Password)
            {
                AfterTestForm afterTestForm = new(CurrentUser, Config);
                afterTestForm.Show();

                Close();
            }
            else
            {
                MessageBox.Show("Неверный пароль");
                textBox1.Text = string.Empty;
            }
        }
    }
}
