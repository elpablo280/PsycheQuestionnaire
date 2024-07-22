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
            beginWorkButton = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // beginWorkButton
            // 
            beginWorkButton.Anchor = AnchorStyles.None;
            beginWorkButton.Location = new Point(455, 123);
            beginWorkButton.Name = "beginWorkButton";
            beginWorkButton.Size = new Size(159, 46);
            beginWorkButton.TabIndex = 0;
            beginWorkButton.Text = "Начать работу";
            beginWorkButton.UseVisualStyleBackColor = true;
            beginWorkButton.Click += beginWorkButton_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(455, 201);
            button1.Name = "button1";
            button1.Size = new Size(159, 46);
            button1.TabIndex = 1;
            button1.Text = "Настройки";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(455, 279);
            button2.Name = "button2";
            button2.Size = new Size(159, 46);
            button2.TabIndex = 2;
            button2.Text = "Профотбор";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Location = new Point(455, 357);
            button3.Name = "button3";
            button3.Size = new Size(159, 46);
            button3.TabIndex = 3;
            button3.Text = "Очистить данные";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Location = new Point(455, 435);
            button4.Name = "button4";
            button4.Size = new Size(159, 46);
            button4.TabIndex = 4;
            button4.Text = "О программе";
            button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(873, 533);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 5;
            label1.Text = "Психея pre-alpha v0.0.1";
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
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(beginWorkButton);
            Name = "MainMenu";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            WindowState = FormWindowState.Maximized;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button beginWorkButton;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
    }
}