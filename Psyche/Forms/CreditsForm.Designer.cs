namespace Psyche.Forms
{
    partial class CreditsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(9, 11);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(779, 427);
            textBox1.TabIndex = 0;
            textBox1.Text = $"Добро пожаловать в Психею!{Environment.NewLine}" +
                $"Данное десктоп-приложение представляет собой опросник с возможностью проходить тесты и смотреть их результаты, а также сохранять информацию в базе данных.{Environment.NewLine}{Environment.NewLine}" +
                $"Над программой работали:{Environment.NewLine}{Environment.NewLine}" +
                $"Wermute{Environment.NewLine}" +
                $"Noker006{Environment.NewLine}{Environment.NewLine}";
            // 
            // CreditsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Name = "CreditsForm";
            Text = "CreditsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
    }
}