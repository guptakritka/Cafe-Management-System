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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }


        private void pLACEORDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            placeorder po = new placeorder();
            form3 f3 = new form3();
            f3.Close();
            po.Show();
            
        }

        private void iTEMSToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }
        private void oRDERBILLoolStripMenuItem_Click(object obj, EventArgs e)
        {
            orderlist ol = new orderlist();
            ol.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            form3 f3 = new form3();
            f3.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
                       this.Hide();
            fm.Show();

        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void pLACEORDERToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            placeorder po = new placeorder();
            po.Show();
        }

        private void iNVENTORYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form3 fm = new form3();
            fm.Show();
        }

        private void oRDERSLISTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            orderlist ol = new orderlist();
            ol.Show();
        }
    }
}
