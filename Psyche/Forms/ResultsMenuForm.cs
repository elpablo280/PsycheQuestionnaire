using Psyche.Forms;
using Psyche.Models;

namespace Psyche
{
    public partial class ResultsMenuForm : Form
    {
        private readonly Config Config;

        public ResultsMenuForm(Config config)
        {
            InitializeComponent();

            Config = config;

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
                    //Width = 350
                    MinimumSize = new(500, 30),
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowOnly,
                };
                Button.Click += (sender, EventArgs) =>
                {
                    // вывод окна с таблицей результатов прохождения теста
                    ResultTabForm resultTabForm = new(Config, fileInfo.FullName);
                };
                Controls.Add(Button);
                i++;
            }
        }
    }
}
