using Psyche.Models;
using Psyche.Workers;

namespace Psyche
{
    public partial class TestForm : Form
    {
        public TestForm(string testFilepath)
        {
            //InitializeComponent();
            //this.Text = new FileInfo(testFilepath).Name.Replace(".json", string.Empty);

            TestParser tp = new();
            Test? Test = tp.ParseTest(testFilepath);

            foreach (var question in Test.Questions)
            {
                Form form = new();
                form.Text = new FileInfo(testFilepath).Name.Replace(".json", string.Empty);

                Label label = new();
                label.Location = new Point(10, 10);
                label.Size = new(200, 30);
                label.Text = question.Text;
                form.Controls.Add(label);

                int i = 0;
                foreach (var variant in question.Variants)
                {
                    Button button = new();
                    button.Location = new Point(10 + 100 * i, 50);
                    button.Text = variant.Text;
                    form.Controls.Add(button);

                    i++;
                }

                form.Close();
            }

        }
    }
}
