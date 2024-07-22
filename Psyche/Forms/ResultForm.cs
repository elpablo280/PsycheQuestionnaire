using Psyche.Models;

namespace Psyche.Forms
{
    public partial class ResultForm : Form
    {

        public ResultForm(User currentUser)
        {
            InitializeComponent();

            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.WordWrap = true;

            textBox1.Text = $"Психологическая характеристика{Environment.NewLine}" +
                $"ФИО:{Environment.NewLine}" +
                $"{currentUser.LastName} {currentUser.FirstName} {currentUser.MiddleName}{Environment.NewLine}" +
                $"Группа:{Environment.NewLine}" +
                $"{currentUser.Group}{Environment.NewLine}" +
                $"Результаты тестовых методик:{Environment.NewLine}";
        }

        private void EscapeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
