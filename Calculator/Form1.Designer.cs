namespace Calculator
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 52);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 0;
            label1.Text = "NUMBER 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 126);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 1;
            label2.Text = "NUMBER 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 337);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 2;
            label3.Text = "Sum";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(127, 401);
            label4.Name = "label4";
            label4.Size = new Size(101, 25);
            label4.TabIndex = 3;
            label4.Text = "Difference";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(127, 465);
            label5.Name = "label5";
            label5.Size = new Size(136, 25);
            label5.TabIndex = 4;
            label5.Text = "Multiplication ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(127, 533);
            label6.Name = "label6";
            label6.Size = new Size(80, 25);
            label6.TabIndex = 5;
            label6.Text = "Division";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(433, 337);
            label7.Name = "label7";
            label7.Size = new Size(32, 25);
            label7.TabIndex = 6;
            label7.Text = "00";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(433, 401);
            label8.Name = "label8";
            label8.Size = new Size(32, 25);
            label8.TabIndex = 7;
            label8.Text = "00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(433, 465);
            label9.Name = "label9";
            label9.Size = new Size(32, 25);
            label9.TabIndex = 8;
            label9.Text = "00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(433, 533);
            label10.Name = "label10";
            label10.Size = new Size(32, 25);
            label10.TabIndex = 9;
            label10.Text = "00";
            // 
            // button1
            // 
            button1.Location = new Point(210, 228);
            button1.Name = "button1";
            button1.Size = new Size(202, 47);
            button1.TabIndex = 10;
            button1.Text = "CALCULATE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(263, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 31);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(263, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(264, 31);
            textBox2.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(653, 603);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}