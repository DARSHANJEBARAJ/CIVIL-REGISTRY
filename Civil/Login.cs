using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.VisualBasic.Logging;

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
            string username = textBox1.Text;
            string password = textBox2.Text;
            string ConnectionString = "Data Source=ANNA\\SQLEXPRESS; Initial Catalog=civil; Integrated Security=True";

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM Account WHERE UserName = @Username AND Password = @Password";
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Login successful!");
                        this.Hide();
                        Main l = new Main();
                        l.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }



    /* con=new SqlConnection();
     com=new SqlCommand();
     con.ConnectionString="Data Source=ANNA\\SQLEXPRESS; Initial Catalog=civil; Integrated Security=True";
     con.Open();
     com.Connection=con;
     if(textBox1.Text==""|| textBox2.Text=="")
         MessageBox.Show("Please fill all the details");
     else
     {
         try
         {
             com.CommandText = "Select * from Account where UserName = '" + textBox1.Text + "'AND Password ='" + textBox2.Text + "'  ";
             com.ExecuteNonQuery();
             int count = (int)com.ExecuteScalar();
             if (count > 0)
             {
                 this.Hide();
                 Main l = new Main();
                 l.Show();
             }
             else
             {

                 MessageBox.Show("No User Found");

             }
             //this.Hide();

             /* if(com.CommandText=="")
              {
                  MessageBox.Show("hgfdfgh",com.CommandText);
                  Main l = new Main();
                  l.Show();
              }
              else
              {
                  MessageBox.Show("No User Found");
              } 

         }
         catch(Exception ex) {

             MessageBox.Show("Database error Found");
         }



     }*/
}

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void message_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
    }

