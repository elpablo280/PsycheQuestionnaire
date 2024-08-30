namespace Psyche.Forms
{
    partial class AreYouSureForm
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
            ClearDBButton = new Button();
            NoButton = new Button();
            SuspendLayout();
            // 
            // ClearDBButton
            // 
            ClearDBButton.Anchor = AnchorStyles.None;
            ClearDBButton.Location = new Point(100, 121);
            ClearDBButton.Name = "ClearDBButton";
            ClearDBButton.Size = new Size(155, 23);
            ClearDBButton.TabIndex = 0;
            ClearDBButton.Text = "Очистить базу данных";
            ClearDBButton.UseVisualStyleBackColor = true;
            ClearDBButton.Click += ClearDBButton_Click;
            // 
            // NoButton
            // 
            NoButton.Anchor = AnchorStyles.None;
            NoButton.Location = new Point(291, 121);
            NoButton.Name = "NoButton";
            NoButton.Size = new Size(75, 23);
            NoButton.TabIndex = 1;
            NoButton.Text = "Нет";
            NoButton.UseVisualStyleBackColor = true;
            NoButton.Click += NoButton_Click;
            // 
            // AreYouSureForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 270);
            Controls.Add(NoButton);
            Controls.Add(ClearDBButton);
            Name = "AreYouSureForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вы уверены?";
            ResumeLayout(false);
        }

        #endregion

        private Button ClearDBButton;
        private Button NoButton;
    }
}