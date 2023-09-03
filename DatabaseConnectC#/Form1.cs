using System.Data;
using System.Data.SqlClient;



namespace muratYucedag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-L29GB0I\\SQLEXPRESS;Initial Catalog=CUSTOMERS;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from TABLE_CUSTOMERS", baglanti);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kayitekle = new SqlCommand("insert into TABLE_CUSTOMERS(CUSTOMERNAME,CITY,DISTRICT,GENDER) VALUES (@C1,@C2,@C3,@C4 )", baglanti);
            kayitekle.Parameters.AddWithValue("@C1", textBox1.Text);
            kayitekle.Parameters.AddWithValue("@C2", textBox2.Text);
            kayitekle.Parameters.AddWithValue("@C3", textBox3.Text);
            kayitekle.Parameters.AddWithValue("@C4", textBox4.Text);

            kayitekle.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kayitsil = new SqlCommand("delete from TABLE_CUSTOMERS WHERE CITY=@CITY", baglanti);
            kayitsil.Parameters.AddWithValue("@CITY", textBox2.Text);
            kayitsil.ExecuteNonQuery();
            baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand kayitguncelleme = new SqlCommand("update TABLE_CUSTOMERS SET CUSTOMERNAME=@C1,CITY=@C2,DISTRICT=@C3,GENDER=@C4 WHERE CUSTOMERNAME=@C1", baglanti);
            kayitguncelleme.Parameters.AddWithValue("@C1", textBox1.Text);
            kayitguncelleme.Parameters.AddWithValue("@C2", textBox2.Text);
            kayitguncelleme.Parameters.AddWithValue("@C3", textBox3.Text);
            kayitguncelleme.Parameters.AddWithValue("@C4", textBox4.Text);
            kayitguncelleme.ExecuteNonQuery();
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string ad = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            string city = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            string ilce = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            string cinsiyet = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            textBox1.Text = ad;
            textBox2.Text = city;
            textBox3.Text = ilce;
            textBox4.Text = cinsiyet;
        }
    }
}