using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace cafe
{
    public partial class placeorder : Form
    {
        function fn = new function();
        String query;

        public placeorder()
        {
            InitializeComponent();
        }

        private void placeorder_Load(object sender, EventArgs e)
        {
            labeldate.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();

        }


        int n, total = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (txttotal.Text != "0" && txttotal.Text != "")
            {
                n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = txtitemname.Text;
                dataGridView2.Rows[n].Cells[1].Value = txtprice.Text;
                dataGridView2.Rows[n].Cells[2].Value = txtqty.Text;
                dataGridView2.Rows[n].Cells[3].Value = txttotal.Text;
                total += Convert.ToInt32(txttotal.Text);

                labelamount.Text = "Rs " + total;
            }
            else
            {
                MessageBox.Show("Enter the Quantity,\n minimum quantity needs to be 1");
            }
            txtitemname.Clear();
            txtprice.Clear();
            txtqty.ResetText();
            txttotal.Clear();
            comboBox1.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            String category = comboBox1.Text;
            query = "Select name from items where category ='" + category + "'";
            DataSet ds = fn.getData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtqty.ResetText();
            txttotal.Clear();
            String text = listBox1.GetItemText(listBox1.SelectedItem);
            txtitemname.Text = text;
            query = "select price from items where name ='" + text + "'";
            DataSet ds = fn.getData(query);
            try
            {
                txtprice.Text = ds.Tables[0].Rows[0][0].ToString();

            }
            catch { }
        }

        private void txtqty_ValueChanged(object sender, EventArgs e)
        {
            int quan = Convert.ToInt32(txtqty.Value.ToString());
            int price = Convert.ToInt32(txtprice.Text);
            txttotal.Text = (quan * price).ToString();
        }
        int amount;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch { }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.Rows.RemoveAt(this.dataGridView2.SelectedRows[0].Index);
            }
            catch { }
            total -= amount;
            labelamount.Text = "Rs. " + total;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            query = "insert into placeorder values ('" + txtno.Text + "','" + labeldate.Text + "','" + labelamount.Text + "')";
            fn.setData(query);
            MessageBox.Show("Order Placed Successfully");

            



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // orderlist ol = new orderlist();
            //ol.Show();
        }
        int unitprice, qty, totalprice, x = 150;
        string itemname;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("BORCELLE CAFE", new Font("Arial", 14, FontStyle.Bold), Brushes.Red, new Point(100, 10));
            e.Graphics.DrawString("ORDER: " + txtno.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 40));
            e.Graphics.DrawString("DATE: " + labeldate.Text, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, new Point(20, 60));
            e.Graphics.DrawString("************************************************************************************************************************************************", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(0, 100));
            e.Graphics.DrawString("ITEM NAME            PRICE     QUANTITY    TOTAL", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(5, 130));
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                itemname = "" + row.Cells["Column1"].Value;
                unitprice = Convert.ToInt32(row.Cells["Column2"].Value);
                qty = Convert.ToInt32(row.Cells["Column3"].Value);
                totalprice = Convert.ToInt32(row.Cells["Column4"].Value);

                e.Graphics.DrawString("" + itemname, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(5, x));
                e.Graphics.DrawString("" + unitprice, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(150, x));
                e.Graphics.DrawString("" + qty, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(250, x));
                e.Graphics.DrawString("" + totalprice, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(300, x));
                x = x + 30;


            }
            e.Graphics.DrawString("GRAND TOTAL: " + labelamount.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Red, new Point(40, x + 50));
            x = 100;
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //  printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 385, 600);

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }


        }
        private void txtno_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
       // int a;
        private void button5_Click(object sender, EventArgs e)
        {
            txtno.Clear();
            labelamount.ResetText();
            total = 0;
            comboBox1.ResetText();
            listBox1.Refresh();
          /*  query = "select max(orderno)  from placeorder";
            DataSet ds = fn.getData(query);
            

           if(ds!= null)
            {

                txtno.Text += 1;
            }
            else
            {
                txtno.Text = "1";   
            }*/
             
            
                }
    }
}
