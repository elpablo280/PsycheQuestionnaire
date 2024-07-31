namespace Psyche
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
            listBox1 = new ListBox();
            beginWorkButton = new Button();
            clearQueueButton = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(797, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(245, 439);
            listBox1.TabIndex = 2;
            // 
            // beginWorkButton
            // 
            beginWorkButton.Location = new Point(798, 537);
            beginWorkButton.Name = "beginWorkButton";
            beginWorkButton.Size = new Size(244, 68);
            beginWorkButton.TabIndex = 3;
            beginWorkButton.Text = "Начать работу";
            beginWorkButton.UseVisualStyleBackColor = true;
            beginWorkButton.Click += BeginWorkButton_Click;
            // 
            // clearQueueButton
            // 
            clearQueueButton.Location = new Point(798, 463);
            clearQueueButton.Name = "clearQueueButton";
            clearQueueButton.Size = new Size(244, 68);
            clearQueueButton.TabIndex = 4;
            clearQueueButton.Text = "Очистить очередь";
            clearQueueButton.UseVisualStyleBackColor = true;
            clearQueueButton.Click += ClearQueueButton_Click;
            // 
            // TestsMenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 617);
            Controls.Add(clearQueueButton);
            Controls.Add(beginWorkButton);
            Controls.Add(listBox1);
            Name = "TestsMenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tests Tab";
            ResumeLayout(false);
        }

        #endregion
        private ListBox listBox1;
        private Button beginWorkButton;
        private Button clearQueueButton;
    }
}