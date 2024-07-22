using Psyche.Models;

namespace Psyche.Forms
{
    public partial class AfterTestForm : Form
    {
        private User CurrentUser;

        public AfterTestForm(User currentUser)
        {
            InitializeComponent();

            CurrentUser = currentUser;
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EndAndExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReadResultButton_Click(object sender, EventArgs e)
        {
            ResultForm resultForm = new ResultForm(CurrentUser);
            resultForm.Show();
        }
    }
}
