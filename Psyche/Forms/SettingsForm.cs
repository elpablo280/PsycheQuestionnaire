namespace Psyche.Forms
{
    public partial class SettingsForm : Form
    {
        readonly private MainMenu MainMenu;

        private bool ShowTimer;
        private bool GoToNextTestWhenTimerIsOver;

        public SettingsForm(MainMenu mainMenu)
        {
            InitializeComponent();

            MainMenu = mainMenu;

            ShowTimer = ShowTimerCheckBox.Checked;
            GoToNextTestWhenTimerIsOver = GoToNextTestWhenTimerIsOverCheckBox.Checked;
        }

        private void ShowTimerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            ShowTimer = checkBox.Checked;
        }

        private void GoToNextTestWhenTimerIsOverCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            GoToNextTestWhenTimerIsOver = checkBox.Checked;
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainMenu.SetSettings(ShowTimer, GoToNextTestWhenTimerIsOver);
        }
    }
}
