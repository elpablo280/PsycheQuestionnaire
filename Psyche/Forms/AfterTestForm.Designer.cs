namespace Psyche.Forms
{
    partial class AfterTestForm
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
            label1 = new Label();
            EndButton = new Button();
            EndAndExitButton = new Button();
            ReadResultButton = new Button();
            GetPresetResultsButton = new Button();
            NextRespondentButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(92, 9);
            label1.Name = "label1";
            label1.Size = new Size(613, 54);
            label1.TabIndex = 0;
            label1.Text = "Выберите дальнейшее действие";
            // 
            // EndButton
            // 
            EndButton.Location = new Point(590, 314);
            EndButton.Name = "EndButton";
            EndButton.Size = new Size(198, 48);
            EndButton.TabIndex = 1;
            EndButton.Text = "Завершить работу";
            EndButton.UseVisualStyleBackColor = true;
            EndButton.Click += EndButton_Click;
            // 
            // EndAndExitButton
            // 
            EndAndExitButton.Location = new Point(590, 383);
            EndAndExitButton.Name = "EndAndExitButton";
            EndAndExitButton.Size = new Size(198, 52);
            EndAndExitButton.TabIndex = 2;
            EndAndExitButton.Text = "Завершить и выйти";
            EndAndExitButton.UseVisualStyleBackColor = true;
            EndAndExitButton.Click += EndAndExitButton_Click;
            // 
            // ReadResultButton
            // 
            ReadResultButton.Location = new Point(37, 86);
            ReadResultButton.Name = "ReadResultButton";
            ReadResultButton.Size = new Size(287, 48);
            ReadResultButton.TabIndex = 3;
            ReadResultButton.Text = "Прочесть характеристику последнего респондента";
            ReadResultButton.UseVisualStyleBackColor = true;
            ReadResultButton.Click += ReadResultButton_Click;
            // 
            // GetPresetResultsButton
            // 
            GetPresetResultsButton.Location = new Point(37, 157);
            GetPresetResultsButton.Name = "GetPresetResultsButton";
            GetPresetResultsButton.Size = new Size(287, 48);
            GetPresetResultsButton.TabIndex = 4;
            GetPresetResultsButton.Text = "Получить результаты профотбора";
            GetPresetResultsButton.UseVisualStyleBackColor = true;
            // 
            // NextRespondentButton
            // 
            NextRespondentButton.Location = new Point(37, 228);
            NextRespondentButton.Name = "NextRespondentButton";
            NextRespondentButton.Size = new Size(287, 48);
            NextRespondentButton.TabIndex = 5;
            NextRespondentButton.Text = "Следующий респондент";
            NextRespondentButton.UseVisualStyleBackColor = true;
            NextRespondentButton.Click += NextRespondentButton_Click;
            // 
            // AfterTestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NextRespondentButton);
            Controls.Add(GetPresetResultsButton);
            Controls.Add(ReadResultButton);
            Controls.Add(EndAndExitButton);
            Controls.Add(EndButton);
            Controls.Add(label1);
            Name = "AfterTestForm";
            Text = "Выберите дальнейшее действие";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button EndButton;
        private Button EndAndExitButton;
        private Button ReadResultButton;
        private Button GetPresetResultsButton;
        private Button NextRespondentButton;
    }
}