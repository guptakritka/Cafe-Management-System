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
    public partial class form3 : Form
    {
        function fn = new function();
        String query;
        public void set()
        {
            query = "select * from items";
            fn.Gridviewer(dataGridView1, query);
        }
        public form3()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (txtitemname.Text == "" || txtprice.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {

                query = "insert into items values ('" + txtitemname.Text + "','" + txtcategory.Text + "'," + txtprice.Text + ")";
                fn.setData(query);
                MessageBox.Show("Item Added Successfully");
                set();
                clearAll();
            }

        }
        public void clearAll()
        {
            txtcategory.SelectedIndex = -1;
            txtitemname.Clear();
            txtprice.Clear();
        }

        private void newitem_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void form3_Load(object sender, EventArgs e)
        {
            set();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
                query = "update items set name= '" + txtitemname.Text + "',category='" + txtcategory.Text + "',price=" + txtprice.Text + "where id="+id+"";
                fn.setData(query);
                MessageBox.Show("Item Updated Successfully");
                set();
                clearAll();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtitemname.Text == "")
            {
                MessageBox.Show("Select the item NAME to Delete");
            }
            else
            {
                query = "delete from  items where name='" + txtitemname.Text + "'";
                fn.setData(query);
                MessageBox.Show("Item Delected Successfully");
                set();
                clearAll();

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
             id = Convert.ToInt32(row.Cells[0].Value.ToString());
            txtcategory.Text = row.Cells[2].Value.ToString();
            txtitemname.Text= row.Cells[1].Value.ToString();
            txtprice.Text= row.Cells[3].Value.ToString();
        }
    }
}
