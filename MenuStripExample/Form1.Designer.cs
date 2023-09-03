namespace MenuStripExample
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
            menuStrip1 = new MenuStrip();
            oĞLAKToolStripMenuItem = new ToolStripMenuItem();
            bOĞAToolStripMenuItem = new ToolStripMenuItem();
            aKREPToolStripMenuItem = new ToolStripMenuItem();
            bAŞAKToolStripMenuItem = new ToolStripMenuItem();
            gIVEPOINTSToolStripMenuItem = new ToolStripMenuItem();
            toolStripComboBox2 = new ToolStripComboBox();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Info;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { oĞLAKToolStripMenuItem, bOĞAToolStripMenuItem, aKREPToolStripMenuItem, bAŞAKToolStripMenuItem, gIVEPOINTSToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 2, 0, 2);
            menuStrip1.Size = new Size(808, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // oĞLAKToolStripMenuItem
            // 
            oĞLAKToolStripMenuItem.Name = "oĞLAKToolStripMenuItem";
            oĞLAKToolStripMenuItem.Size = new Size(103, 24);
            oĞLAKToolStripMenuItem.Text = "CAPRICORN";
            oĞLAKToolStripMenuItem.Click += oĞLAKToolStripMenuItem_Click;
            // 
            // bOĞAToolStripMenuItem
            // 
            bOĞAToolStripMenuItem.Name = "bOĞAToolStripMenuItem";
            bOĞAToolStripMenuItem.Size = new Size(77, 24);
            bOĞAToolStripMenuItem.Text = "TAURUS";
            bOĞAToolStripMenuItem.Click += bOĞAToolStripMenuItem_Click;
            // 
            // aKREPToolStripMenuItem
            // 
            aKREPToolStripMenuItem.Name = "aKREPToolStripMenuItem";
            aKREPToolStripMenuItem.Size = new Size(83, 24);
            aKREPToolStripMenuItem.Text = "SCORPIO";
            aKREPToolStripMenuItem.Click += aKREPToolStripMenuItem_Click;
            // 
            // bAŞAKToolStripMenuItem
            // 
            bAŞAKToolStripMenuItem.Name = "bAŞAKToolStripMenuItem";
            bAŞAKToolStripMenuItem.Size = new Size(66, 24);
            bAŞAKToolStripMenuItem.Text = "VIRGO";
            bAŞAKToolStripMenuItem.Click += bAŞAKToolStripMenuItem_Click;
            // 
            // gIVEPOINTSToolStripMenuItem
            // 
            gIVEPOINTSToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripComboBox2 });
            gIVEPOINTSToolStripMenuItem.Name = "gIVEPOINTSToolStripMenuItem";
            gIVEPOINTSToolStripMenuItem.Size = new Size(108, 24);
            gIVEPOINTSToolStripMenuItem.Text = "GIVE POINTS";
            // 
            // toolStripComboBox2
            // 
            toolStripComboBox2.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            toolStripComboBox2.Name = "toolStripComboBox2";
            toolStripComboBox2.Size = new Size(121, 28);
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(13, 177);
            richTextBox1.Margin = new Padding(4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(270, 273);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 123);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(198, 50);
            label1.TabIndex = 2;
            label1.Text = "Horoscope Of The Day\r\nSeptember 3 ,  2023\r\n";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(342, 177);
            label2.Name = "label2";
            label2.Size = new Size(175, 25);
            label2.TabIndex = 5;
            label2.Text = "Chosen Zodiac Sign";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(628, 180);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 6;
            label3.Text = "Puan";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(342, 242);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(183, 129);
            listBox1.TabIndex = 7;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Location = new Point(584, 242);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(183, 129);
            listBox2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 56);
            label4.Name = "label4";
            label4.Size = new Size(336, 25);
            label4.TabIndex = 9;
            label4.Text = "First rate, then choose your zodiac sign\r\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(808, 562);
            Controls.Add(label4);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem oĞLAKToolStripMenuItem;
        private ToolStripMenuItem bOĞAToolStripMenuItem;
        private ToolStripMenuItem aKREPToolStripMenuItem;
        private ToolStripMenuItem bAŞAKToolStripMenuItem;
        private ToolStripMenuItem gIVEPOINTSToolStripMenuItem;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBox1;
        private ListBox listBox2;
        private ToolStripComboBox toolStripComboBox2;
        private Label label4;
    }
}