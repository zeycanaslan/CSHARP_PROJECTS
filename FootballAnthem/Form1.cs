using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballAnthem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int second = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            second = Convert.ToInt32(label1.Text);
            second++;
            label1.Text = second.ToString();

            void renksec(string ilk, string ikinci) {
                if (second % 10 == 0)
                {
                    button1.BackColor = Color.FromName(ilk);
                    button2.BackColor = Color.FromName(ikinci);
                    button3.BackColor = Color.FromName(ilk);
                    button4.BackColor = Color.FromName(ikinci);
                    button5.BackColor = Color.FromName(ilk);
                    button6.BackColor = Color.FromName(ikinci);
                }

                if (second % 10 == 5)
                {
                    button1.BackColor = Color.FromName(ikinci);
                    button2.BackColor = Color.FromName(ilk);
                    button3.BackColor = Color.FromName(ikinci);
                    button4.BackColor = Color.FromName(ilk);
                    button5.BackColor = Color.FromName(ikinci);
                    button6.BackColor = Color.FromName(ilk);
                }
            }
            if (checkBox1.Checked == true)
            {
                renksec("Yellow", "Blue");
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }

            if (checkBox2.Checked == true)
            {
                renksec("Black", "White");
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }

            if (checkBox3.Checked == true)
            {
                renksec("Yellow", "Red");
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox4.Checked = false;
            }

            if (checkBox4.Checked == true)
            {
                renksec("Red", "Blue");
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL = "C:\\Users\\USER\\Desktop\\GUTHUBDESKTOP\\C# PROJECTS\\FootballAnthem\\ANTHEM\\100-yil-sarkisi-official-video.mp3";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL = "C:\\Users\\USER\\Desktop\\GUTHUBDESKTOP\\C# PROJECTS\\FootballAnthem\\ANTHEM\\gucune-guc-katmaya-geldik-besiktas-official-video.mp3";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL = "C:\\Users\\USER\\Desktop\\GUTHUBDESKTOP\\C# PROJECTS\\FootballAnthem\\ANTHEM\\galatasaray-marsi.mp3";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL = "C:\\Users\\USER\\Desktop\\GUTHUBDESKTOP\\C# PROJECTS\\FootballAnthem\\ANTHEM\\Biz Dar Sokaklarında.mp3";
        }
    }
}
