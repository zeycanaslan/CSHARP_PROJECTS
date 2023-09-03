namespace MenuStripExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void o–LAKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "You may not be able to achieve what you want to live by keeping your feelings secret." +
                " You have a feeling, your career has taught you that when you have a dream, you have to go after it.";
            listBox1.Items.Add("CAPRICORN");
            listBox2.Items.Add(toolStripComboBox2.Text);
        }

        private void bO–AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "The impermanence of everything can bother you." +
                " However, instead of changing this fact, strengthening the presence of everyone and" +
                " every subject in your life and making the moment beautiful can erase all negative emotions.";
            listBox1.Items.Add("TAURUS");
            listBox2.Items.Add(toolStripComboBox2.Text);
        }

        private void aKREPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "You may be afraid of causing injustice for yourself and those around you." +
                " This urge can greatly prevent some of the problems you may experience.";
            listBox1.Items.Add("SCORPIO");
            listBox2.Items.Add(toolStripComboBox2.Text);
        }

        private void bAﬁAKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "You may want to give back for everything that is offered to you" +
                ". Keeping this alive will solidify the foundation of many opportunities and gains you have achieved.";
            listBox1.Items.Add("VIRGO");
            listBox2.Items.Add(toolStripComboBox2.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}