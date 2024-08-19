namespace Psyche.Forms
{
    partial class SettingsForm
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
            ShowTimerCheckBox = new CheckBox();
            GoToNextTestWhenTimerIsOverCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // ShowTimerCheckBox
            // 
            ShowTimerCheckBox.AutoSize = true;
            ShowTimerCheckBox.Checked = true;
            ShowTimerCheckBox.CheckState = CheckState.Checked;
            ShowTimerCheckBox.Location = new Point(21, 17);
            ShowTimerCheckBox.Name = "ShowTimerCheckBox";
            ShowTimerCheckBox.Size = new Size(134, 19);
            ShowTimerCheckBox.TabIndex = 0;
            ShowTimerCheckBox.Text = "Показывать таймер";
            ShowTimerCheckBox.UseVisualStyleBackColor = true;
            ShowTimerCheckBox.CheckedChanged += ShowTimerCheckBox_CheckedChanged;
            // 
            // GoToNextTestWhenTimerIsOverCheckBox
            // 
            GoToNextTestWhenTimerIsOverCheckBox.AutoSize = true;
            GoToNextTestWhenTimerIsOverCheckBox.Checked = true;
            GoToNextTestWhenTimerIsOverCheckBox.CheckState = CheckState.Checked;
            GoToNextTestWhenTimerIsOverCheckBox.Location = new Point(21, 51);
            GoToNextTestWhenTimerIsOverCheckBox.Name = "GoToNextTestWhenTimerIsOverCheckBox";
            GoToNextTestWhenTimerIsOverCheckBox.Size = new Size(399, 19);
            GoToNextTestWhenTimerIsOverCheckBox.TabIndex = 1;
            GoToNextTestWhenTimerIsOverCheckBox.Text = "Переходить на следующий тест из очереди при истечении таймера";
            GoToNextTestWhenTimerIsOverCheckBox.UseVisualStyleBackColor = true;
            GoToNextTestWhenTimerIsOverCheckBox.CheckedChanged += GoToNextTestWhenTimerIsOverCheckBox_CheckedChanged;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1098, 586);
            Controls.Add(GoToNextTestWhenTimerIsOverCheckBox);
            Controls.Add(ShowTimerCheckBox);
            Name = "SettingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Настройки";
            FormClosing += SettingsForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ShowTimerCheckBox;
        private CheckBox GoToNextTestWhenTimerIsOverCheckBox;
    }
}