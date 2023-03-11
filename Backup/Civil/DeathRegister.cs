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
    public partial class DeathRegister : Form
    {
        public SqlCommand com;
        public SqlConnection con;
        public SqlDataAdapter da;
        public DeathRegister()
        {
            InitializeComponent();
        }
        public void GetSerialNumber()
        {
            string id;
            string q = "select SerialNumber from DeathRegister order by SerialNumber Desc";
            con = new SqlConnection();

            con.ConnectionString = "Data Source=ANNA\\SQLEXPRESS; Initial Catalog=civil; Integrated Security=True";
            con.Open();
            com = new SqlCommand(q, con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                int i = int.Parse(dr[0].ToString()) + 1;
                id = i.ToString("11000");

            }
            else if (Convert.IsDBNull(dr))
            {
                id = ("00001");
            }
            else
            {
                id = ("00001");
            }
            con.Close();
            textBox8.Text = id.ToString();

        }

        private void DeathRegister_Load(object sender, EventArgs e)
        {
            GetSerialNumber();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             con = new SqlConnection();
            com = new SqlCommand();
            con.ConnectionString = "Data Source=ANNA\\SQLEXPRESS; Initial Catalog=civil; Integrated Security=True";
            con.Open();
            com.Connection = con;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || comboBox1.Text == "")
                MessageBox.Show("Please fill all the details");
            else
            {
                com.CommandText = "insert into DeathRegister values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox1.Text+"')";
                com.ExecuteNonQuery();
                this.Hide();
                Main l = new Main();
                l.Show(); 
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main l = new Main();
            l.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        }

        
    }


