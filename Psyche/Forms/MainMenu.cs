using Psyche.Forms;
using Psyche.Models;
using Psyche.Workers;

namespace Psyche
{
    public partial class MainMenu : Form
    {
        private Config Config { get; set; }

        // settings
        public bool ShowTimer = true;
        public bool GoToNextTestWhenTimerIsOver = true;

        private DBContext DBContext { get; set; }

        public MainMenu()
        {
            InitializeComponent();
            Config = new ConfigWorker().GetConfig();
            DBContext = new DBContext();
        }

        private void BeginWorkButton_Click(object sender, EventArgs e)
        {
            TestsMenuForm testsMenuForm = new(Config, this);
            testsMenuForm.Show();
        }

        private void ResultsButton_Click(object sender, EventArgs e)
        {
            ResultsMenuForm resultsMenuForm = new(Config);
            resultsMenuForm.Show();
        }

        private void CreditsButton_Click(object sender, EventArgs e)
        {
            CreditsForm creditsForm = new();
            creditsForm.Show();
        }

        private void PresetsButton_Click(object sender, EventArgs e)
        {
            PresetsForm presetsForm = new();
            presetsForm.Show();
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new(this);
            settingsForm.Show();
        }

        public void SetSettings(bool showTimer, bool goToNextTestWhenTimerIsOver)
        {
            ShowTimer = showTimer;
            GoToNextTestWhenTimerIsOver = goToNextTestWhenTimerIsOver;
        }
    }
}