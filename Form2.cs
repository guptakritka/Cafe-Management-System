using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "admin" && txtpassword.Text == "cafe1234")
            {
                main m = new main();
                m.Show();
                this.Hide();
            }
            else
            {
                txtusername.Text = String.Empty;
                txtpassword.Text = String.Empty;
                
                MessageBox.Show("UNVALID USERNAME OR PASSWORD");

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
