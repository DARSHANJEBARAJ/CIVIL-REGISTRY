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
    public partial class Login : Form
    {
        public SqlCommand com;
        public SqlConnection con;
        public SqlDataAdapter da;
        public Login()
        {
            InitializeComponent();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register r = new Register();
            r.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {  
            con=new SqlConnection();
            com=new SqlCommand();
            con.ConnectionString="Data Source=ANNA\\SQLEXPRESS; Initial Catalog=civil; Integrated Security=True";
            con.Open();
            com.Connection=con;
            if(textBox1.Text==""|| textBox2.Text=="")
                MessageBox.Show("Please fill all the details");
            else
            {
                com.CommandText = "Select * from Account where UserName = '"+textBox1.Text+"'";
                com.ExecuteNonQuery();
                this.Hide();
                Main l = new Main();
                l.Show();
                
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        

        }
    }

