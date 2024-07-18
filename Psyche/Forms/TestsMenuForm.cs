using Psyche.Models;
using Psyche.Workers;

namespace Psyche
{
    public partial class TestsMenuForm : Form
    {
        readonly Queue<string> TestsQueue = new();

        public TestsMenuForm()
        {
            InitializeComponent();

            Config? config = new ConfigWorker().GetConfig();
            string[] tests = Directory.GetFiles(config.TestsFilepath);

            int i = 1;
            foreach (string test in tests)
            {
                FileInfo fileInfo = new(test);
                string testName = fileInfo.Name.Replace(".json", string.Empty);        // todo

                Button Button = new();
                Button.Location = new Point(10, 30 * i);
                Button.Text = testName;
                Button.Click += (sender, EventArgs) =>
                {
                    //addTestButton_Click(sender, EventArgs, fileInfo.FullName);
                    listBox1.Items.Add(testName);
                    TestsQueue.Enqueue(fileInfo.FullName);
                };
                this.Controls.Add(Button);
                i++;
            }
        }

        private void addTestButton_Click(object sender, EventArgs e, string text)
        {
            listBox1.Items.Add(text);
            TestsQueue.Enqueue(text);
        }

        public void beginWorkButton_Click(object sender, EventArgs e)
        {
            if (!TestsQueue.TryDequeue(out string currentTest))
            {
                MessageBox.Show("Очередь тестов пуста!");
                return;
            }
            listBox1.Items.RemoveAt(0);

            // todo

            DataEntryForm dataEntryForm = new(currentTest);
            dataEntryForm.Show();
        }

        private void clearQueueButton_Click(object sender, EventArgs e)
        {
            TestsQueue.Clear();
            listBox1.Items.Clear();
        }
    }
}
