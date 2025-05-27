namespace desktopEample
{
    partial class UserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            label1 = new Label();
            userName = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            login = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 24);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // userName
            // 
            userName.Location = new Point(118, 22);
            userName.Name = "userName";
            userName.Size = new Size(276, 27);
            userName.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(118, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(276, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(118, 144);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(275, 27);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // login
            // 
            login.Location = new Point(299, 199);
            login.Name = "login";
            login.Size = new Size(94, 29);
            login.TabIndex = 4;
            login.Text = "Login";
            login.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(118, 199);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 147);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.ForeColor = SystemColors.ControlLight;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.Location = new Point(30, 85);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 7;
            label3.Text = "Login Id";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(420, 250);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(login);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(userName);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            MaximumSize = new Size(438, 297);
            MinimumSize = new Size(438, 297);
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "User Registration";
            Load += UserForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userName;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button login;
        private Button button2;
        private Label label2;
        private Label label3;
    }
}