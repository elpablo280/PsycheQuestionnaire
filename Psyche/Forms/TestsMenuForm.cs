using Psyche.Models;

namespace Psyche
{
    public partial class TestsMenuForm : Form
    {
        private readonly Queue<string> TestsQueue = new();
        private readonly Config Config;
        public readonly MainMenu MainMenu;

        public TestsMenuForm(Config config, MainMenu mainMenu)
        {
            InitializeComponent();
            Config = config;
            MainMenu = mainMenu;

            string[] tests = Directory.GetFiles(Config.TestsFilepath);

            int i = 1;
            foreach (string test in tests)
            {
                FileInfo fileInfo = new(test);
                string testName = fileInfo.Name.Replace(".json", string.Empty);        // todo

                Button Button = new()
                {
                    Location = new Point(10, 30 * i),
                    Text = testName,
                    Width = 200,
                    //AutoSize = true,
                    //AutoSizeMode = AutoSizeMode.GrowOnly
                };
                Button.Click += (sender, EventArgs) =>
                {
                    //addTestButton_Click(sender, EventArgs, fileInfo.FullName);
                    listBox1.Items.Add(testName);
                    TestsQueue.Enqueue(fileInfo.FullName);
                };
                Controls.Add(Button);
                i++;
            }
        }

        private void AddTestButton_Click(object sender, EventArgs e, string text)
        {
            listBox1.Items.Add(text);
            TestsQueue.Enqueue(text);
        }

        public void BeginWorkButton_Click(object sender, EventArgs e)
        {
            string? currentTest = DequeueTest();
            if (currentTest is null)
            {
                return;
            }

            DataEntryForm dataEntryForm = new(currentTest, Config, this);
            dataEntryForm.Show();
        }

        public bool SelectNextTest(User currentUser)
        {
            string? currentTest = DequeueTest();
            if (currentTest is null)
            {
                return false;
            }

            TestForm currentTestForm = new(currentTest, currentUser, Config, this);
            currentTestForm.Show();

            return true;
        }

        public string? DequeueTest()
        {
            if (!TestsQueue.TryDequeue(out string currentTest))
            {
                MessageBox.Show("Очередь тестов пуста!");
                return null;
            }
            listBox1.Items.RemoveAt(0);

            return currentTest;
        }

        private void ClearQueueButton_Click(object sender, EventArgs e)
        {
            TestsQueue.Clear();
            listBox1.Items.Clear();
        }
    }
}
