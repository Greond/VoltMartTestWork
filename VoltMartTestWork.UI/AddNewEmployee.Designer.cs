namespace VoltMartTestWork.UI
{
    partial class AddNewEmployee
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
            SaveButton = new Button();
            PropertiesPanel = new Panel();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            groupBox3 = new GroupBox();
            textBox3 = new TextBox();
            groupBox4 = new GroupBox();
            textBox4 = new TextBox();
            groupBox5 = new GroupBox();
            textBox5 = new TextBox();
            groupBox6 = new GroupBox();
            textBox6 = new TextBox();
            groupBox7 = new GroupBox();
            groupBox8 = new GroupBox();
            textBox8 = new TextBox();
            checkBoxWork = new CheckBox();
            checkBoxNotWork = new CheckBox();
            PropertiesPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveButton.BackColor = Color.FromArgb(128, 255, 128);
            SaveButton.Location = new Point(401, 592);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(83, 41);
            SaveButton.TabIndex = 0;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = false;
            // 
            // PropertiesPanel
            // 
            PropertiesPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PropertiesPanel.Controls.Add(groupBox8);
            PropertiesPanel.Controls.Add(groupBox7);
            PropertiesPanel.Controls.Add(groupBox6);
            PropertiesPanel.Controls.Add(groupBox5);
            PropertiesPanel.Controls.Add(groupBox4);
            PropertiesPanel.Controls.Add(groupBox3);
            PropertiesPanel.Controls.Add(groupBox2);
            PropertiesPanel.Controls.Add(groupBox1);
            PropertiesPanel.Location = new Point(12, 12);
            PropertiesPanel.Name = "PropertiesPanel";
            PropertiesPanel.Size = new Size(383, 621);
            PropertiesPanel.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 55);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "FirstName";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(6, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(356, 23);
            textBox1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(3, 64);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(368, 55);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "LastName";
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(6, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(356, 23);
            textBox2.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(textBox3);
            groupBox3.Location = new Point(3, 125);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(368, 55);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "MidleName";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.Location = new Point(6, 22);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(356, 23);
            textBox3.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(textBox4);
            groupBox4.Location = new Point(3, 186);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(368, 55);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Phone";
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.Location = new Point(6, 22);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(356, 23);
            textBox4.TabIndex = 1;
            // 
            // groupBox5
            // 
            groupBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox5.Controls.Add(textBox5);
            groupBox5.Location = new Point(6, 247);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(368, 55);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "Email";
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox5.Location = new Point(6, 22);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(356, 23);
            textBox5.TabIndex = 1;
            // 
            // groupBox6
            // 
            groupBox6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox6.Controls.Add(textBox6);
            groupBox6.Location = new Point(3, 308);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(368, 55);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "Birthday";
            // 
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox6.Location = new Point(6, 22);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(356, 23);
            textBox6.TabIndex = 1;
            // 
            // groupBox7
            // 
            groupBox7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox7.Controls.Add(checkBoxNotWork);
            groupBox7.Controls.Add(checkBoxWork);
            groupBox7.Location = new Point(3, 369);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(368, 55);
            groupBox7.TabIndex = 3;
            groupBox7.TabStop = false;
            groupBox7.Text = "Work";
            // 
            // groupBox8
            // 
            groupBox8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox8.Controls.Add(textBox8);
            groupBox8.Location = new Point(6, 430);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(368, 55);
            groupBox8.TabIndex = 3;
            groupBox8.TabStop = false;
            groupBox8.Text = "FirstName";
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox8.Location = new Point(6, 22);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(356, 23);
            textBox8.TabIndex = 1;
            // 
            // checkBoxWork
            // 
            checkBoxWork.AutoSize = true;
            checkBoxWork.Location = new Point(9, 22);
            checkBoxWork.Name = "checkBoxWork";
            checkBoxWork.Size = new Size(71, 19);
            checkBoxWork.TabIndex = 0;
            checkBoxWork.Text = "Working";
            checkBoxWork.UseVisualStyleBackColor = true;
            // 
            // checkBoxNotWork
            // 
            checkBoxNotWork.AutoSize = true;
            checkBoxNotWork.Location = new Point(86, 22);
            checkBoxNotWork.Name = "checkBoxNotWork";
            checkBoxNotWork.Size = new Size(94, 19);
            checkBoxNotWork.TabIndex = 1;
            checkBoxNotWork.Text = "Not Working";
            checkBoxNotWork.UseVisualStyleBackColor = true;
            // 
            // AddNewEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 645);
            Controls.Add(PropertiesPanel);
            Controls.Add(SaveButton);
            MinimumSize = new Size(512, 684);
            Name = "AddNewEmployee";
            Text = "Form1";
            PropertiesPanel.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button SaveButton;
        private Panel PropertiesPanel;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private GroupBox groupBox8;
        private TextBox textBox8;
        private GroupBox groupBox7;
        private GroupBox groupBox6;
        private TextBox textBox6;
        private GroupBox groupBox5;
        private TextBox textBox5;
        private GroupBox groupBox4;
        private TextBox textBox4;
        private GroupBox groupBox3;
        private TextBox textBox3;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private CheckBox checkBoxNotWork;
        private CheckBox checkBoxWork;
    }
}