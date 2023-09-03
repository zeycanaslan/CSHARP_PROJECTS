using Microsoft.VisualBasic.Devices;

namespace HorseRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int first_horse_left_distance,
            second_horse_left_distance,
            left_distance_of_the_third_horse;

        Random random = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            int degree = Convert.ToInt32(label7.Text);
            degree++;
            label7.Text = degree.ToString();


            int width_of_first_horse = pictureBox1.Width;
            int width_of_second_horse = pictureBox4.Width;
            int width_of_the_third_horse = pictureBox2.Width;

            int finish_distance = label5.Left;


            pictureBox1.Left = pictureBox1.Left + random.Next(5, 15);
            pictureBox4.Left = pictureBox4.Left + random.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + random.Next(5, 15);

            if (pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox4.Left + 5)
            {
                label6.Text = "The first horse took the lead";
            }

            if (pictureBox4.Left > pictureBox1.Left + 5 && pictureBox4.Left > pictureBox2.Left + 5)
            {
                label6.Text = "Second horse took the lead";
            }

            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox4.Left + 5)
            {
                label6.Text = "Third horse took the lead";
            }


            if (width_of_first_horse + pictureBox1.Left >= finish_distance)
            {
                timer1.Enabled = false;
                label6.Text = "First horse won";
            }

            if (width_of_second_horse + pictureBox4.Left >= finish_distance)
            {
                timer1.Enabled = false;
                label6.Text = "Second horse won";
            }

            if (width_of_the_third_horse + pictureBox2.Left >= finish_distance)
            {
                timer1.Enabled = false;
                label6.Text = "Thrid horse won";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            first_horse_left_distance = pictureBox1.Left;
            second_horse_left_distance = pictureBox4.Left;
            left_distance_of_the_third_horse = pictureBox2.Left;
        }
    }
}