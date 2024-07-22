namespace Psyche.Forms
{
    partial class ResultForm
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
            EscapeButton = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(8, 9);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(780, 389);
            textBox1.TabIndex = 0;
            // 
            // EscapeButton
            // 
            EscapeButton.Location = new Point(616, 404);
            EscapeButton.Name = "EscapeButton";
            EscapeButton.Size = new Size(172, 34);
            EscapeButton.TabIndex = 1;
            EscapeButton.Text = "Закрыть";
            EscapeButton.UseVisualStyleBackColor = true;
            EscapeButton.Click += EscapeButton_Click;
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(EscapeButton);
            Controls.Add(textBox1);
            Name = "ResultForm";
            Text = "Характеристика";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button EscapeButton;
    }
}