using Psyche.Handlers;
using Psyche.Models;

namespace Psyche.Forms
{
    public partial class ResultForm : Form
    {
        private readonly Config Config;
        private readonly User CurrentUser;

        public ResultForm(User currentUser, Config config)
        {
            InitializeComponent();
            Config = config;
            CurrentUser = currentUser;

            SR45Handler sr45Handler = new(Config, CurrentUser);
            Test1Handler test1Handler = new(Config, CurrentUser);
            Test2Handler test2Handler = new(Config, CurrentUser);
            string results = $"{sr45Handler.GetResult()}{Environment.NewLine}" +
                            $"{test1Handler.GetResult()}{Environment.NewLine}" +
                            $"{test2Handler.GetResult()}{Environment.NewLine}";

            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.WordWrap = true;

            textBox1.Text = $"Психологическая характеристика{Environment.NewLine}" +
                $"ФИО:{Environment.NewLine}" +
                $"{currentUser.LastName} {currentUser.FirstName} {currentUser.MiddleName}{Environment.NewLine}" +
                $"Группа:{Environment.NewLine}" +
                $"{currentUser.Group}{Environment.NewLine}" +
                $"Результаты тестовых методик:{Environment.NewLine}" +
                results;
        }

        private void EscapeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
