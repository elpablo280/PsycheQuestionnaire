namespace Psykheya
{
    public partial class TestsMenuForm : Form
    {
        Queue<string> TestsQueue = new Queue<string>();

        public TestsMenuForm()
        {
            InitializeComponent();


        }

        private void addTestButton_Click(object sender, EventArgs e, string text)
        {
            listBox1.Items.Add(text);
            TestsQueue.Append(text);
        }

        private void beginWorkButton_Click(object sender, EventArgs e)
        {
            DataEntryForm dataEntryForm = new();
            dataEntryForm.Show();
            this.Close();
        }

    }
}
