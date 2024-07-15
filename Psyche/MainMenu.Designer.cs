namespace Psykheya
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            beginWorkButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            beginWorkButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            beginWorkButton.Location = new Point(460, 264);
            beginWorkButton.Name = "button1";
            beginWorkButton.Size = new Size(159, 46);
            beginWorkButton.TabIndex = 0;
            beginWorkButton.Text = "Начать работу";
            beginWorkButton.UseVisualStyleBackColor = true;
            beginWorkButton.Click += beginWorkButton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 610);
            Controls.Add(beginWorkButton);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            WindowState = FormWindowState.Maximized;
            Load += MainMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button beginWorkButton;
    }
}