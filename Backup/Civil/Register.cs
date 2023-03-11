using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Civil
{
    public partial class Register : Form
    {
        public SqlCommand com;
        public SqlConnection con;
        public SqlDataAdapter da;
       
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            com = new SqlCommand();
            con.ConnectionString = "Data Source=ANNA\\SQLEXPRESS; Initial Catalog=civil; Integrated Security=True";
            con.Open();
            com.Connection = con;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
                MessageBox.Show("Please fill all the details");
            else
            {
                com.CommandText = "insert into Account values('"+textBox1.Text+"','"+ textBox2.Text+"','"+textBox3.Text+"','"+textBox4.Text+"')";
                com.ExecuteNonQuery();
                this.Hide();
                Login l = new Login();
                l.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.Show();
        }
    }
}
