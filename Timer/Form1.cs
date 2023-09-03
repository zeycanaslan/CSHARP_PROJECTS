namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int second = 0;
        int minute = 0;
        int hour = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int milisecond = Convert.ToInt32(label8.Text);
            milisecond++;
            label8.Text = milisecond.ToString();

            if (milisecond == 99)
            {
                milisecond = 0;
                label8.Text = milisecond.ToString();
                second++;
                label5.Text = second.ToString();
            }

            if (second == 59)
            {
                second = 0;
                label5.Text = second.ToString();
                minute++;
                label6.Text = minute.ToString();
            } 

            if(minute == 59)
            {
                minute = 0;
                label6.Text = minute.ToString();
                hour++;
                label7.Text = hour.ToString();
            }

        }
    }
}