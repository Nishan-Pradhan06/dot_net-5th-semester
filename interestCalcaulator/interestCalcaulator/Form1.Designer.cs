namespace interestCalcaulator
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            txtTime = new Label();
            txtRate = new Label();
            txtPrincipal = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            imageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 13);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "Prinicpal Amount:";
            label1.Click += label1_Click;
            // 
            // txtTime
            // 
            txtTime.AutoSize = true;
            txtTime.Location = new Point(31, 72);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(93, 20);
            txtTime.TabIndex = 1;
            txtTime.Text = "Time in year:";
            // 
            // txtRate
            // 
            txtRate.AutoSize = true;
            txtRate.Location = new Point(31, 128);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(95, 20);
            txtRate.TabIndex = 2;
            txtRate.Text = "Interest Rate:";
            // 
            // txtPrincipal
            // 
            txtPrincipal.Location = new Point(163, 10);
            txtPrincipal.Name = "txtPrincipal";
            txtPrincipal.Size = new Size(297, 27);
            txtPrincipal.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(163, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(297, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(163, 125);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(297, 27);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(163, 195);
            button1.Name = "button1";
            button1.Size = new Size(149, 46);
            button1.TabIndex = 6;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(318, 195);
            button2.Name = "button2";
            button2.Size = new Size(142, 46);
            button2.TabIndex = 7;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 259);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(txtPrincipal);
            Controls.Add(txtRate);
            Controls.Add(txtTime);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(508, 306);
            MinimumSize = new Size(508, 306);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label txtTime;
        private Label txtRate;
        private TextBox txtPrincipal;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button button2;
        private ImageList imageList1;
    }
}
