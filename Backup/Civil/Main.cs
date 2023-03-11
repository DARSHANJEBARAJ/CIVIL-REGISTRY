using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Civil
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            BirthRegister l =new BirthRegister();
            l.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeathRegister l = new DeathRegister();
            l.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BirthRegisterDownload l = new BirthRegisterDownload();
            l.Show();
        }
    }
}
