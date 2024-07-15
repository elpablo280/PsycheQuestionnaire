namespace Psykheya
{
    partial class TestsMenuForm
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
            test1Button = new Button();
            test2Button = new Button();
            listBox1 = new ListBox();
            beginWorkButton = new Button();
            SuspendLayout();
            // 
            // test1Button
            // 
            test1Button.Location = new Point(102, 92);
            test1Button.Name = "test1Button";
            test1Button.Size = new Size(149, 65);
            test1Button.TabIndex = 0;
            test1Button.Text = "Тестовый тест 1";
            test1Button.UseVisualStyleBackColor = true;
            test1Button.Click += (sender, EventArgs) => { addTestButton_Click(sender, EventArgs, test1Button.Text); };
            // 
            // test2Button
            // 
            test2Button.Location = new Point(102, 183);
            test2Button.Name = "test2Button";
            test2Button.Size = new Size(149, 62);
            test2Button.TabIndex = 1;
            test2Button.Text = "Тестовый тест 2";
            test2Button.UseVisualStyleBackColor = true;
            test2Button.Click += (sender, EventArgs) => { addTestButton_Click(sender, EventArgs, test2Button.Text); };
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(765, 43);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(245, 439);
            listBox1.TabIndex = 2;
            // 
            // beginWorkButton
            // 
            beginWorkButton.Location = new Point(766, 516);
            beginWorkButton.Name = "beginWorkButton";
            beginWorkButton.Size = new Size(244, 74);
            beginWorkButton.TabIndex = 3;
            beginWorkButton.Text = "Начать работу";
            beginWorkButton.UseVisualStyleBackColor = true;
            beginWorkButton.Click += beginWorkButton_Click;
            // 
            // TestsMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 617);
            Controls.Add(beginWorkButton);
            Controls.Add(listBox1);
            Controls.Add(test2Button);
            Controls.Add(test1Button);
            Name = "TestsMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TestsForm";
            ResumeLayout(false);
        }

        #endregion

        private Button test1Button;
        private Button test2Button;
        private ListBox listBox1;
        private Button beginWorkButton;
    }
}