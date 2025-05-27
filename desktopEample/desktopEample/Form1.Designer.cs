namespace desktopEample
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            deleteBtn = new Button();
            DvgUserList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DvgUserList).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(36, 412);
            button1.Name = "button1";
            button1.Size = new Size(166, 44);
            button1.TabIndex = 0;
            button1.Text = "Add User";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom;
            button2.Location = new Point(308, 412);
            button2.Name = "button2";
            button2.Size = new Size(166, 44);
            button2.TabIndex = 1;
            button2.Text = "Edit User";
            button2.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteBtn.Location = new Point(599, 412);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(166, 44);
            deleteBtn.TabIndex = 2;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // DvgUserList
            // 
            DvgUserList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DvgUserList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            DvgUserList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DvgUserList.Location = new Point(36, 21);
            DvgUserList.Name = "DvgUserList";
            DvgUserList.RowHeadersWidth = 51;
            DvgUserList.Size = new Size(729, 378);
            DvgUserList.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 470);
            Controls.Add(DvgUserList);
            Controls.Add(deleteBtn);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(800, 347);
            Name = "Form1";
            Text = "User List";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DvgUserList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button deleteBtn;
        private DataGridView DvgUserList;
    }
}
