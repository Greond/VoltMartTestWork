namespace VoltMartTestWork.UI
{
    partial class Main
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
            dataGridView1 = new DataGridView();
            SaveButton = new Button();
            DeleteButton = new Button();
            AddButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(888, 480);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.UserAddedRow += dataGridView1_UserAddedRow;
            dataGridView1.UserDeletedRow += dataGridView1_UserDeletedRow;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SaveButton.BackColor = Color.FromArgb(128, 255, 128);
            SaveButton.Location = new Point(12, 498);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(113, 51);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DeleteButton.BackColor = Color.FromArgb(255, 128, 128);
            DeleteButton.Location = new Point(782, 498);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(113, 51);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = false;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.BackColor = Color.FromArgb(255, 255, 128);
            AddButton.Location = new Point(663, 498);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(113, 51);
            AddButton.TabIndex = 3;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += this.AddButton_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 561);
            Controls.Add(AddButton);
            Controls.Add(DeleteButton);
            Controls.Add(SaveButton);
            Controls.Add(dataGridView1);
            MinimumSize = new Size(928, 600);
            Name = "Main";
            Text = "Главная";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button SaveButton;
        private Button DeleteButton;
        private Button AddButton;
    }
}
