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
    public partial class BirthRegisterDownload : Form
    {       
       
        public SqlCommand com;
        public SqlConnection con;
        public SqlDataAdapter da;
        public DataSet ds;
        public BirthRegisterDownload()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            com.CommandText="Select*from BirthRegister1 where SerialNumber='"+textBox1.Text+"'";
            da.SelectCommand=com;
            da.Fill(ds,"BirthRegister1");
            dataGridView1.DataSource=ds.Tables["BirthRegister1"];



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main l = new Main();
            l.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            com.CommandText=("update name,");
             com.ExecuteNonQuery();
                this.Hide();
                Main l = new Main();
                l.Show();
        }
        
        private void BirthRegisterDownload_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=ANNA\\SQLEXPRESS; Initial Catalog=civil; Integrated Security=True";
        }

        

        }

      
        
        
    }



