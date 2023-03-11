using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Civil
{
    public partial class DeathRegisterDownload : Form
    {
        public SqlCommand com;
        public SqlConnection con;
        public SqlDataAdapter da;
        public DataSet ds;
        public DeathRegisterDownload()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection();
            com = new SqlCommand();
            con.ConnectionString = "Data Source=ANNA\\SQLEXPRESS; Initial Catalog=civil; Integrated Security=True";
            con.Open();

            SqlCommand comm = new SqlCommand("select * from DeathRegister1 where SerialNumber='" + (textBox1.Text) + "'", con);
            SqlDataReader srd = comm.ExecuteReader();
            while (srd.Read())
            {
                textBox1.Text = srd.GetValue(0).ToString();
                textBox2.Text = srd.GetValue(1).ToString();
                textBox3.Text = srd.GetValue(2).ToString();
                textBox4.Text = srd.GetValue(3).ToString();
                textBox5.Text = srd.GetValue(4).ToString();
                textBox6.Text = srd.GetValue(5).ToString();
                textBox7.Text = srd.GetValue(6).ToString();
                textBox8.Text = srd.GetValue(7).ToString();
                comboBox1.Text = srd.GetValue(8).ToString();

            }
            con.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con = new SqlConnection();
            com = new SqlCommand();
            con.ConnectionString = "Data Source=ANNA\\SQLEXPRESS; Initial Catalog=civil; Integrated Security=True";
            con.Open();

            SqlCommand comm = new SqlCommand("select * from DeathRegister1 where SerialNumber='" + (textBox1.Text) + "'", con);
            SqlDataReader srd = comm.ExecuteReader();
            while (srd.Read())
            {
                textBox1.Text = srd.GetValue(0).ToString();
                textBox2.Text = srd.GetValue(1).ToString();
                textBox3.Text = srd.GetValue(2).ToString();
                textBox4.Text = srd.GetValue(3).ToString();
                textBox5.Text = srd.GetValue(4).ToString();
                textBox6.Text = srd.GetValue(5).ToString();
                textBox7.Text = srd.GetValue(6).ToString();
                textBox8.Text = srd.GetValue(7).ToString();
                comboBox1.Text = srd.GetValue(8).ToString();

            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main l = new Main();
            l.Show();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Death Register", new Font("Airal", 20, FontStyle.Bold), Brushes.Black, 300, 100);
            e.Graphics.DrawString("S.no", new Font("Airal", 20, FontStyle.Bold), Brushes.Black, 250, 250);
            e.Graphics.DrawString("Name", new Font("Airal", 20, FontStyle.Bold), Brushes.Black, 250, 350);
            e.Graphics.DrawString("Place", new Font("Airal", 20, FontStyle.Bold), Brushes.Black, 250, 450);
            e.Graphics.DrawString("DateOfDeath", new Font("Airal", 20, FontStyle.Bold), Brushes.Black, 250, 550);
            e.Graphics.DrawString("Father Name", new Font("Airal", 20, FontStyle.Bold), Brushes.Black, 250, 650);
            e.Graphics.DrawString("Mother Name ", new Font("Airal", 20, FontStyle.Bold), Brushes.Black, 250, 750);
            e.Graphics.DrawString("Hospital Name", new Font("Airal", 20, FontStyle.Bold), Brushes.Black, 250, 850);
            e.Graphics.DrawString("Address ", new Font("Airal", 20, FontStyle.Bold), Brushes.Black, 250, 950);
            e.Graphics.DrawString("Gender ", new Font("Airal", 20, FontStyle.Bold), Brushes.Black, 250, 1050);
            e.Graphics.DrawString(textBox1.Text, new Font("Airal", 20, FontStyle.Bold), Brushes.Black, 450, 250);
            e.Graphics.DrawString(textBox2.Text, new Font("Airal", 20, FontStyle.Bold), Brushes.Black, 450, 350);
            e.Graphics.DrawString(textBox3.Text, new Font("Airal", 20, FontStyle.Bold), Brushes.Black, 450, 450);
            e.Graphics.DrawString(textBox4.Text, new Font("Airal", 20, FontStyle.Bold), Brushes.Black, 450, 550);
            e.Graphics.DrawString(textBox5.Text, new Font("Airal", 20, FontStyle.Bold), Brushes.Black, 450, 650);
            e.Graphics.DrawString(textBox6.Text, new Font("Airal", 20, FontStyle.Bold), Brushes.Black, 450, 750);
            e.Graphics.DrawString(textBox7.Text, new Font("Airal", 20, FontStyle.Bold), Brushes.Black, 450, 850);
            e.Graphics.DrawString(textBox8.Text, new Font("Airal", 20, FontStyle.Bold), Brushes.Black, 450, 950);
            e.Graphics.DrawString(comboBox1.Text, new Font("Airal", 20, FontStyle.Bold), Brushes.Black, 450, 1050);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();

            }
        }
    }
}
