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
    public partial class BirthRegister : Form
    {
        public SqlCommand com;
        public SqlConnection con;
        public SqlDataAdapter da;
        public SqlDataReader dr;
       
        public BirthRegister()
        {
            InitializeComponent();
        }
        public void GetSerialNumber()
        {
            string id;
            string q = "select SerialNumber from BirthRegister1 order by SerialNumber Desc";
            con = new SqlConnection();
           
            con.ConnectionString = "Data Source=ANNA\\SQLEXPRESS;Initial Catalog=civil;Integrated Security=True";
            con.Open();
            com = new SqlCommand(q,con);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                int i = int.Parse(dr[0].ToString()) + 1;
                id = i.ToString("00000");

            }
            else if (Convert.IsDBNull(dr))
            {
                id = ("00001");
            }
            else
            {
                id = ("00001");
            }
            
            textBox8.Text = id.ToString();
            con.Close();
           
        }
           
        private void BirthRegister_Load(object sender, EventArgs e)
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
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" ||textBox7.Text==""|| comboBox1.Text == "")
                MessageBox.Show("Please fill all the details");
            else
            {
                try
                {
                    com.CommandText = "insert into BirthRegister1 values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + comboBox1.Text + "')";
                    com.ExecuteNonQuery();
                    MessageBox.Show("Inserted successfully");
                    this.Hide();
                    Main l = new Main();
                    l.Show();
                }
                catch(Exception)
                {
                    MessageBox.Show("Something went Wrong");
                }
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main l = new Main();
            l.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
