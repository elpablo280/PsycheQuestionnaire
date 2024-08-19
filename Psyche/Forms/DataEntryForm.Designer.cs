namespace Psyche
{
    partial class DataEntryForm
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
            lastNameTextBox = new TextBox();
            firstNameTextBox = new TextBox();
            middleNameTextBox = new TextBox();
            groupTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            beginTestButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(334, 17);
            label1.Name = "label1";
            label1.Size = new Size(163, 28);
            label1.TabIndex = 0;
            label1.Text = "Введите данные:";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(36, 105);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(245, 23);
            lastNameTextBox.TabIndex = 1;
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(36, 180);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(245, 23);
            firstNameTextBox.TabIndex = 2;
            // 
            // middleNameTextBox
            // 
            middleNameTextBox.Location = new Point(36, 252);
            middleNameTextBox.Name = "middleNameTextBox";
            middleNameTextBox.Size = new Size(245, 23);
            middleNameTextBox.TabIndex = 3;
            // 
            // groupTextBox
            // 
            groupTextBox.Location = new Point(36, 326);
            groupTextBox.Name = "groupTextBox";
            groupTextBox.Size = new Size(245, 23);
            groupTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 87);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 5;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 162);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 6;
            label3.Text = "Имя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 234);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 7;
            label4.Text = "Отчество";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 308);
            label5.Name = "label5";
            label5.Size = new Size(46, 15);
            label5.TabIndex = 8;
            label5.Text = "Группа";
            // 
            // beginTestButton
            // 
            beginTestButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            beginTestButton.Location = new Point(645, 360);
            beginTestButton.Name = "beginTestButton";
            beginTestButton.Size = new Size(116, 46);
            beginTestButton.TabIndex = 9;
            beginTestButton.Text = "Начать тест";
            beginTestButton.UseVisualStyleBackColor = true;
            beginTestButton.Click += BeginTestButton_Click;
            // 
            // DataEntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(beginTestButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupTextBox);
            Controls.Add(middleNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(label1);
            Name = "DataEntryForm";
            Text = "Введите данные";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox lastNameTextBox;
        private TextBox firstNameTextBox;
        private TextBox middleNameTextBox;
        private TextBox groupTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button beginTestButton;
    }
}