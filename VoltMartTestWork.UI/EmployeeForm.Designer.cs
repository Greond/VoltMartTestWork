namespace VoltMartTestWork.UI
{
    partial class EmployeeForm
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
            groupBox10 = new GroupBox();
            dateTimePickerHireDate = new DateTimePicker();
            groupBox9 = new GroupBox();
            textBoxPlaceLiving = new TextBox();
            groupBox8 = new GroupBox();
            checkBoxMarried = new CheckBox();
            groupBox7 = new GroupBox();
            checkBoxWork = new CheckBox();
            groupBox6 = new GroupBox();
            dateTimePickerBirthday = new DateTimePicker();
            groupBox5 = new GroupBox();
            textBoxEmail = new TextBox();
            groupBox4 = new GroupBox();
            textBoxPhone = new TextBox();
            groupBox3 = new GroupBox();
            textBoxMidleName = new TextBox();
            groupBox2 = new GroupBox();
            textBoxLastName = new TextBox();
            groupBox1 = new GroupBox();
            textBoxFirstName = new TextBox();
            PropertiesPanel.SuspendLayout();
            groupBox10.SuspendLayout();
            groupBox9.SuspendLayout();
            groupBox8.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveButton.BackColor = Color.FromArgb(128, 255, 128);
            SaveButton.Location = new Point(12, 645);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(468, 52);
            SaveButton.TabIndex = 0;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // PropertiesPanel
            // 
            PropertiesPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PropertiesPanel.Controls.Add(groupBox10);
            PropertiesPanel.Controls.Add(groupBox9);
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
            PropertiesPanel.Size = new Size(468, 627);
            PropertiesPanel.TabIndex = 1;
            // 
            // groupBox10
            // 
            groupBox10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox10.Controls.Add(dateTimePickerHireDate);
            groupBox10.Location = new Point(6, 552);
            groupBox10.Name = "groupBox10";
            groupBox10.Size = new Size(453, 61);
            groupBox10.TabIndex = 4;
            groupBox10.TabStop = false;
            groupBox10.Text = "Hiredate";
            // 
            // dateTimePickerHireDate
            // 
            dateTimePickerHireDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerHireDate.Location = new Point(6, 22);
            dateTimePickerHireDate.Name = "dateTimePickerHireDate";
            dateTimePickerHireDate.Size = new Size(285, 23);
            dateTimePickerHireDate.TabIndex = 0;
            dateTimePickerHireDate.ShowCheckBox = true;
            // 
            // groupBox9
            // 
            groupBox9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox9.Controls.Add(textBoxPlaceLiving);
            groupBox9.Location = new Point(6, 491);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(453, 61);
            groupBox9.TabIndex = 4;
            groupBox9.TabStop = false;
            groupBox9.Text = "PlaceLiving";
            // 
            // textBoxPlaceLiving
            // 
            textBoxPlaceLiving.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPlaceLiving.Location = new Point(6, 22);
            textBoxPlaceLiving.Name = "textBoxPlaceLiving";
            textBoxPlaceLiving.Size = new Size(438, 23);
            textBoxPlaceLiving.TabIndex = 1;
            // 
            // groupBox8
            // 
            groupBox8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox8.Controls.Add(checkBoxMarried);
            groupBox8.Location = new Point(6, 430);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(453, 61);
            groupBox8.TabIndex = 3;
            groupBox8.TabStop = false;
            groupBox8.Text = "Married";
            // 
            // checkBoxMarried
            // 
            checkBoxMarried.AutoSize = true;
            checkBoxMarried.Location = new Point(6, 22);
            checkBoxMarried.Name = "checkBoxMarried";
            checkBoxMarried.Size = new Size(67, 19);
            checkBoxMarried.TabIndex = 2;
            checkBoxMarried.Text = "Married";
            checkBoxMarried.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            groupBox7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox7.Controls.Add(checkBoxWork);
            groupBox7.Location = new Point(3, 369);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(453, 61);
            groupBox7.TabIndex = 3;
            groupBox7.TabStop = false;
            groupBox7.Text = "Work";
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
            // groupBox6
            // 
            groupBox6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox6.Controls.Add(dateTimePickerBirthday);
            groupBox6.Location = new Point(3, 308);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(453, 61);
            groupBox6.TabIndex = 3;
            groupBox6.TabStop = false;
            groupBox6.Text = "Birthday";
            // 
            // dateTimePickerBirthday
            // 
            dateTimePickerBirthday.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePickerBirthday.Location = new Point(3, 22);
            dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            dateTimePickerBirthday.Size = new Size(285, 23);
            dateTimePickerBirthday.TabIndex = 0;
            dateTimePickerBirthday.ShowCheckBox = true;
            // 
            // groupBox5
            // 
            groupBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox5.Controls.Add(textBoxEmail);
            groupBox5.Location = new Point(6, 247);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(453, 61);
            groupBox5.TabIndex = 3;
            groupBox5.TabStop = false;
            groupBox5.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxEmail.Location = new Point(6, 22);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(441, 23);
            textBoxEmail.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox4.Controls.Add(textBoxPhone);
            groupBox4.Location = new Point(3, 186);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(453, 61);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Phone";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPhone.Location = new Point(6, 22);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(441, 23);
            textBoxPhone.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox3.Controls.Add(textBoxMidleName);
            groupBox3.Location = new Point(3, 125);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(453, 61);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "MidleName";
            // 
            // textBoxMidleName
            // 
            textBoxMidleName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxMidleName.Location = new Point(6, 22);
            textBoxMidleName.Name = "textBoxMidleName";
            textBoxMidleName.Size = new Size(441, 23);
            textBoxMidleName.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(textBoxLastName);
            groupBox2.Location = new Point(3, 64);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(453, 61);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "LastName";
            // 
            // textBoxLastName
            // 
            textBoxLastName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxLastName.Location = new Point(6, 22);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(441, 23);
            textBoxLastName.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(textBoxFirstName);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(453, 61);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "FirstName";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFirstName.Location = new Point(6, 22);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(441, 23);
            textBoxFirstName.TabIndex = 1;
            // 
            // AddNewEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 709);
            Controls.Add(PropertiesPanel);
            Controls.Add(SaveButton);
            MinimumSize = new Size(508, 748);
            Name = "AddNewEmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавить";
            PropertiesPanel.ResumeLayout(false);
            groupBox10.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button SaveButton;
        private Panel PropertiesPanel;
        private GroupBox groupBox1;
        private TextBox textBoxFirstName;
        private GroupBox groupBox8;
        private GroupBox groupBox7;
        private GroupBox groupBox6;
        private GroupBox groupBox5;
        private TextBox textBoxEmail;
        private GroupBox groupBox4;
        private TextBox textBoxPhone;
        private GroupBox groupBox3;
        private TextBox textBoxMidleName;
        private GroupBox groupBox2;
        private TextBox textBoxLastName;
        private CheckBox checkBoxNotWork;
        private CheckBox checkBoxWork;
        private GroupBox groupBox10;
        private DateTimePicker dateTimePickerHireDate;
        private GroupBox groupBox9;
        private TextBox textBoxPlaceLiving;
        private CheckBox checkBoxMarried;
        private CheckBox checkBoxNotMarried;
        private DateTimePicker dateTimePickerBirthday;
    }
}