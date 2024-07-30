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

            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.WordWrap = true;

            textBox1.Text = $"Психологическая характеристика{Environment.NewLine}" +
                $"ФИО:{Environment.NewLine}" +
                $"{currentUser.LastName} {currentUser.FirstName} {currentUser.MiddleName}{Environment.NewLine}" +
                $"Группа:{Environment.NewLine}" +
                $"{currentUser.Group}{Environment.NewLine}" +
                $"Результаты тестовых методик:{Environment.NewLine}" +
                sr45Handler.GetResult();
        }

        private void EscapeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
