namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number1, number2;
            double sum, difference, multiplication, division;

            number1 = Convert.ToDouble(textBox1.Text);
            number2 = Convert.ToDouble(textBox2.Text);

            sum = number1 + number2;
            label7.Text = sum.ToString();

            difference = number1 - number2;
            label8.Text = difference.ToString();

            multiplication = number1 * number2;
            label9.Text = multiplication.ToString();

            division = number1 / number2;
            label10.Text = division.ToString();
        }
    }
}