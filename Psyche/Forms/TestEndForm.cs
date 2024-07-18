namespace Psyche.Forms
{
    public partial class TestEndForm : Form
    {
        private string Password = "1111";

        public TestEndForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == Password)
            {
                // добавить переход в меню действий после завершения теста
                MessageBox.Show("Здесь должен быть переход в меню действий после завершения теста");

                //beginWorkButton_Click(sender, e);

                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный пароль");

                textBox1.Text = string.Empty;
            }
        }
    }
}
