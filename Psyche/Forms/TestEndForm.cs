using Psyche.Models;

namespace Psyche.Forms
{
    public partial class TestEndForm : Form
    {
        private readonly string Password = "1111";
        private readonly User CurrentUser;
        private readonly List<bool?> Answers = new();

        public TestEndForm(User currentUser, List<bool?> answers)
        {
            InitializeComponent();
            CurrentUser = currentUser;
            Answers = answers;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Password)
            {
                AfterTestForm afterTestForm = new AfterTestForm(CurrentUser);
                afterTestForm.Show();

                //beginWorkButton_Click(sender, e);

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
