namespace Psyche
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void beginWorkButton_Click(object sender, EventArgs e)
        {
            TestsMenuForm testsMenuForm = new();
            testsMenuForm.Show();
        }
    }
}