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

    public partial class orderlist : Form
    {
        function fn = new function();
        String query;
        public void set()
        {
            query = "select * from placeorder";
            fn.Gridviewer(dataGridView1, query);
        }
        public orderlist()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void orderlist_Load(object sender, EventArgs e)
        {
            set();
        }
    }
}
