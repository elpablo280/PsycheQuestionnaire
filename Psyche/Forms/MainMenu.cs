namespace Psyche
{
    public partial class MainMenu : Form
    {
        public TestsMenuForm testsMenuForm;

        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void beginWorkButton_Click(object sender, EventArgs e)
        {
            testsMenuForm = new();
            testsMenuForm.Show();
        }
    }
}