namespace Psyche
{
    partial class TestForm
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            timerLable = new Label();
            questionLabel = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            timerLable.AutoSize = true;
            timerLable.Location = new Point(641, 9);
            timerLable.Name = "label1";
            timerLable.Size = new Size(100, 30);
            timerLable.TabIndex = 0;
            timerLable.Text = "Таймер: " + TimeLeft;
            // 
            // label2
            // 
            questionLabel.AutoSize = true;
            questionLabel.Location = new Point(9, 10);
            questionLabel.Name = "label2";
            questionLabel.Size = new Size(0, 15);
            questionLabel.TabIndex = 1;
            questionLabel.Text = "Текст вопроса";
            // 
            // TestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(questionLabel);
            Controls.Add(timerLable);
            Name = "TestForm";
            Text = "TestForm";
            Size = new(816, 489);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label timerLable;
        private Label questionLabel;
    }
}