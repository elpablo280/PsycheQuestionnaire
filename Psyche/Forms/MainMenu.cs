using Psyche.Models;
using Psyche.Workers;

namespace Psyche
{
    public partial class MainMenu : Form
    {
        private Config Config { get; set; }

        public MainMenu()
        {
            InitializeComponent();
            Config = new ConfigWorker().GetConfig();
        }

        private void beginWorkButton_Click(object sender, EventArgs e)
        {
            TestsMenuForm testsMenuForm = new(Config);
            testsMenuForm.Show();
        }
    }
}