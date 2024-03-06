namespace cafe
{
    partial class placeorder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(placeorder));
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            txtno = new TextBox();
            button1 = new Button();
            dataGridView2 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            button2 = new Button();
            label5 = new Label();
            txtitemname = new TextBox();
            label7 = new Label();
            listBox1 = new ListBox();
            txtprice = new TextBox();
            label6 = new Label();
            txttotal = new TextBox();
            label8 = new Label();
            labelamount = new Label();
            txtqty = new NumericUpDown();
            button3 = new Button();
            labeldate = new Label();
            label9 = new Label();
            button4 = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtqty).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(602, 28);
            label1.Name = "label1";
            label1.Size = new Size(279, 52);
            label1.TabIndex = 0;
            label1.Text = "PLACE ORDER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(134, 130);
            label2.Name = "label2";
            label2.Size = new Size(129, 31);
            label2.TabIndex = 1;
            label2.Text = "CATEGORY";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "COFFEE", "JUICE", "DESSERT" });
            comboBox1.Location = new Point(288, 131);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(206, 28);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "-SELECT-";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(80, 180);
            label3.Name = "label3";
            label3.Size = new Size(195, 31);
            label3.TabIndex = 3;
            label3.Text = "ORDER NUMBER";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(649, 178);
            label4.Name = "label4";
            label4.Size = new Size(128, 31);
            label4.TabIndex = 4;
            label4.Text = "QUANTITY";
            // 
            // txtno
            // 
            txtno.Location = new Point(288, 184);
            txtno.Name = "txtno";
            txtno.Size = new Size(206, 27);
            txtno.TabIndex = 5;
            txtno.TextChanged += txtno_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Sienna;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1145, 255);
            button1.Name = "button1";
            button1.Size = new Size(230, 50);
            button1.TabIndex = 7;
            button1.Text = "ADD TO CART";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle3.NullValue = null;
            dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView2.Location = new Point(649, 333);
            dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.Sienna;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(758, 317);
            dataGridView2.TabIndex = 9;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ITEM NAME";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 175;
            // 
            // Column2
            // 
            Column2.HeaderText = "UNIT PRICE";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 175;
            // 
            // Column3
            // 
            Column3.HeaderText = "QUANTITY";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 175;
            // 
            // Column4
            // 
            Column4.HeaderText = "TOATAL PRICE";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 175;
            // 
            // button2
            // 
            button2.BackColor = Color.Sienna;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(1199, 706);
            button2.Name = "button2";
            button2.Size = new Size(208, 55);
            button2.TabIndex = 10;
            button2.Text = "PLACE ORDER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(920, 688);
            label5.Name = "label5";
            label5.Size = new Size(199, 31);
            label5.TabIndex = 11;
            label5.Text = "ORDER AMOUNT";
            label5.Click += label5_Click;
            // 
            // txtitemname
            // 
            txtitemname.Location = new Point(806, 136);
            txtitemname.Name = "txtitemname";
            txtitemname.Size = new Size(175, 27);
            txtitemname.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(649, 131);
            label7.Name = "label7";
            label7.Size = new Size(142, 31);
            label7.TabIndex = 14;
            label7.Text = "ITEM NAME";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(95, 255);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(399, 384);
            listBox1.TabIndex = 16;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // txtprice
            // 
            txtprice.Location = new Point(1193, 142);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(182, 27);
            txtprice.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(1078, 136);
            label6.Name = "label6";
            label6.Size = new Size(76, 31);
            label6.TabIndex = 17;
            label6.Text = "PRICE";
            // 
            // txttotal
            // 
            txttotal.Location = new Point(1193, 194);
            txttotal.Name = "txttotal";
            txttotal.Size = new Size(182, 27);
            txttotal.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(1083, 185);
            label8.Name = "label8";
            label8.Size = new Size(81, 31);
            label8.TabIndex = 20;
            label8.Text = "TOTAL";
            // 
            // labelamount
            // 
            labelamount.BackColor = Color.Peru;
            labelamount.Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labelamount.ForeColor = Color.DarkRed;
            labelamount.Location = new Point(970, 732);
            labelamount.Name = "labelamount";
            labelamount.Size = new Size(120, 46);
            labelamount.TabIndex = 22;
            labelamount.Text = "Rs.";
            labelamount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtqty
            // 
            txtqty.Location = new Point(806, 185);
            txtqty.Name = "txtqty";
            txtqty.Size = new Size(175, 27);
            txtqty.TabIndex = 23;
            txtqty.ValueChanged += txtqty_ValueChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.Sienna;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(672, 703);
            button3.Name = "button3";
            button3.Size = new Size(209, 60);
            button3.TabIndex = 24;
            button3.Text = "REMOVE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // labeldate
            // 
            labeldate.AutoSize = true;
            labeldate.BackColor = Color.Transparent;
            labeldate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            labeldate.ForeColor = Color.Sienna;
            labeldate.Location = new Point(1283, 35);
            labeldate.Name = "labeldate";
            labeldate.Size = new Size(70, 31);
            labeldate.TabIndex = 25;
            labeldate.Text = "DATE";
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(1494, -4);
            label9.Name = "label9";
            label9.Size = new Size(127, 54);
            label9.TabIndex = 26;
            label9.Text = "X";
            label9.Click += label9_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Sienna;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(920, 807);
            button4.Name = "button4";
            button4.Size = new Size(209, 60);
            button4.TabIndex = 27;
            button4.Text = "PRINT RECEIPT";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Sienna;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(270, 706);
            button5.Name = "button5";
            button5.Size = new Size(209, 60);
            button5.TabIndex = 28;
            button5.Text = "RESET";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // placeorder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1551, 1010);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(label9);
            Controls.Add(labeldate);
            Controls.Add(button3);
            Controls.Add(txtqty);
            Controls.Add(labelamount);
            Controls.Add(label8);
            Controls.Add(txttotal);
            Controls.Add(txtprice);
            Controls.Add(label6);
            Controls.Add(listBox1);
            Controls.Add(txtitemname);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(dataGridView2);
            Controls.Add(button1);
            Controls.Add(txtno);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(324, 30);
            Name = "placeorder";
            StartPosition = FormStartPosition.Manual;
            Text = "placeorder";
            Load += placeorder_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtqty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private TextBox txtno;
        private Button button1;
        private Button button2;
        private Label label5;
        private TextBox txtitemname;
        private Label label7;
        private ListBox listBox1;
        private TextBox txtprice;
        private Label label6;
        private TextBox txttotal;
        private Label label8;
        private Label labelamount;
        private NumericUpDown txtqty;
        private Button button3;
        private Label labeldate;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label9;
        public DataGridView dataGridView2;
        private Button button4;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Button button5;
    }
}