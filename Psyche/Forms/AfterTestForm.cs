using Psyche.Models;

namespace Psyche.Forms
{
    public partial class AfterTestForm : Form
    {
        private readonly User CurrentUser;
        private readonly Config Config;

        public AfterTestForm(User currentUser, Config config)
        {
            InitializeComponent();

            CurrentUser = currentUser;
            Config = config;
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
            ResultForm resultForm = new(CurrentUser, Config);
            resultForm.Show();
        }

        private void NextRespondentButton_Click(object sender, EventArgs e)
        {

        }
    }
}
