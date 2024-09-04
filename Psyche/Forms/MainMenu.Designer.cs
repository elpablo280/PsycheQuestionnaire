namespace Psyche
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
            BeginWorkButton = new Button();
            ResultsButton = new Button();
            SettingsButton = new Button();
            PresetsButton = new Button();
            ClearDBButton = new Button();
            CreditsButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // BeginWorkButton
            // 
            BeginWorkButton.Anchor = AnchorStyles.None;
            BeginWorkButton.Location = new Point(454, 90);
            BeginWorkButton.Name = "BeginWorkButton";
            BeginWorkButton.Size = new Size(159, 46);
            BeginWorkButton.TabIndex = 0;
            BeginWorkButton.Text = "Начать работу";
            BeginWorkButton.UseVisualStyleBackColor = true;
            BeginWorkButton.Click += BeginWorkButton_Click;
            // 
            // ResultsButton
            // 
            ResultsButton.Anchor = AnchorStyles.None;
            ResultsButton.Location = new Point(454, 166);
            ResultsButton.Margin = new Padding(3, 2, 3, 2);
            ResultsButton.Name = "ResultsButton";
            ResultsButton.Size = new Size(159, 45);
            ResultsButton.TabIndex = 7;
            ResultsButton.Text = "Результаты";
            ResultsButton.UseVisualStyleBackColor = true;
            ResultsButton.Click += ResultsButton_Click;
            // 
            // SettingsButton
            // 
            SettingsButton.Anchor = AnchorStyles.None;
            SettingsButton.Location = new Point(454, 241);
            SettingsButton.Name = "SettingsButton";
            SettingsButton.Size = new Size(159, 46);
            SettingsButton.TabIndex = 1;
            SettingsButton.Text = "Настройки";
            SettingsButton.UseVisualStyleBackColor = true;
            SettingsButton.Click += SettingsButton_Click;
            // 
            // PresetsButton
            // 
            PresetsButton.Anchor = AnchorStyles.None;
            PresetsButton.Location = new Point(454, 317);
            PresetsButton.Name = "PresetsButton";
            PresetsButton.Size = new Size(159, 46);
            PresetsButton.TabIndex = 2;
            PresetsButton.Text = "Профотбор";
            PresetsButton.UseVisualStyleBackColor = true;
            PresetsButton.Click += PresetsButton_Click;
            // 
            // ClearDBButton
            // 
            ClearDBButton.Anchor = AnchorStyles.None;
            ClearDBButton.Location = new Point(454, 393);
            ClearDBButton.Name = "ClearDBButton";
            ClearDBButton.Size = new Size(159, 46);
            ClearDBButton.TabIndex = 3;
            ClearDBButton.Text = "Очистить данные";
            ClearDBButton.UseVisualStyleBackColor = true;
            ClearDBButton.Click += ClearDBButton_Click;
            // 
            // CreditsButton
            // 
            CreditsButton.Anchor = AnchorStyles.None;
            CreditsButton.Location = new Point(454, 469);
            CreditsButton.Name = "CreditsButton";
            CreditsButton.Size = new Size(159, 46);
            CreditsButton.TabIndex = 4;
            CreditsButton.Text = "О программе";
            CreditsButton.UseVisualStyleBackColor = true;
            CreditsButton.Click += CreditsButton_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(873, 533);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 5;
            label1.Text = "Психея alpha v0.0.5";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(873, 561);
            label2.Name = "label2";
            label2.Size = new Size(154, 15);
            label2.TabIndex = 6;
            label2.Text = "Developed by PavlostanSoft";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 610);
            Controls.Add(ResultsButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(CreditsButton);
            Controls.Add(ClearDBButton);
            Controls.Add(PresetsButton);
            Controls.Add(SettingsButton);
            Controls.Add(BeginWorkButton);
            Name = "MainMenu";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главное меню";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BeginWorkButton;
        private Button SettingsButton;
        private Button PresetsButton;
        private Button ClearDBButton;
        private Button CreditsButton;
        private Label label1;
        private Label label2;
        private Button ResultsButton;
    }
}