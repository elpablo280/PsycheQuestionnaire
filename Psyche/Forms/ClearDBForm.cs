using Psyche.Models;

namespace Psyche.Forms
{
    public partial class ClearDBForm : Form
    {
        private readonly string Password = "1111";            // todo
        private readonly Config Config;

        public ClearDBForm(Config config)
        {
            InitializeComponent();
            Config = config;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Password)
            {
                AreYouSureForm areYouSureForm = new(Config);
                areYouSureForm.Show();

                Close();
            }
            else
            {
                MessageBox.Show("Неверный пароль");
                textBox1.Text = string.Empty;
            }
        }

    }
}
