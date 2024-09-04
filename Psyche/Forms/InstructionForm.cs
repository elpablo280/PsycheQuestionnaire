namespace Psyche.Forms
{
    public partial class InstructionForm : Form
    {
        private string Text;
        private readonly TestForm TestForm;

        public InstructionForm(string text, TestForm testForm)
        {
            InitializeComponent();

            Text = text;
            TestForm = testForm;

            textBox1.Text = Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TestForm.BeginWork();
            Close();
        }
    }
}
