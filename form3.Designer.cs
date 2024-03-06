namespace cafe
{
    partial class form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form3));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtcategory = new ComboBox();
            txtitemname = new TextBox();
            txtprice = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button3 = new Button();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Comic Sans MS", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(842, 34);
            label1.Name = "label1";
            label1.Size = new Size(151, 56);
            label1.TabIndex = 0;
            label1.Text = " ITEM";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(184, 177);
            label2.Name = "label2";
            label2.Size = new Size(167, 39);
            label2.TabIndex = 1;
            label2.Text = "CATEGORY";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(184, 293);
            label3.Name = "label3";
            label3.Size = new Size(190, 39);
            label3.TabIndex = 2;
            label3.Text = "ITEM NAME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(184, 423);
            label4.Name = "label4";
            label4.Size = new Size(99, 39);
            label4.TabIndex = 3;
            label4.Text = "PRICE";
            // 
            // txtcategory
            // 
            txtcategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtcategory.FormattingEnabled = true;
            txtcategory.Items.AddRange(new object[] { "COFFEE", "JUICE", "DESSERT" });
            txtcategory.Location = new Point(409, 177);
            txtcategory.Name = "txtcategory";
            txtcategory.Size = new Size(285, 36);
            txtcategory.TabIndex = 4;
            // 
            // txtitemname
            // 
            txtitemname.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtitemname.Location = new Point(409, 298);
            txtitemname.Name = "txtitemname";
            txtitemname.Size = new Size(285, 34);
            txtitemname.TabIndex = 5;
            // 
            // txtprice
            // 
            txtprice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtprice.Location = new Point(409, 423);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(285, 34);
            txtprice.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Sienna;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(82, 550);
            button1.Name = "button1";
            button1.Size = new Size(269, 57);
            button1.TabIndex = 7;
            button1.Text = "ADD ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.PeachPuff;
            dataGridView1.Location = new Point(783, 166);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(708, 408);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button2
            // 
            button2.BackColor = Color.Sienna;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(256, 647);
            button2.Name = "button2";
            button2.Size = new Size(279, 57);
            button2.TabIndex = 9;
            button2.Text = "DELETE ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Sienna;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(438, 550);
            button3.Name = "button3";
            button3.Size = new Size(275, 57);
            button3.TabIndex = 10;
            button3.Text = "UPDATE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(1501, -2);
            label9.Name = "label9";
            label9.Size = new Size(127, 54);
            label9.TabIndex = 27;
            label9.Text = "X";
            label9.Click += label9_Click;
            // 
            // form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1551, 1010);
            Controls.Add(label9);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(txtprice);
            Controls.Add(txtitemname);
            Controls.Add(txtcategory);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(324, 30);
            Name = "form3";
            StartPosition = FormStartPosition.Manual;
            Text = "newitem";
            Load += form3_Load;
            Leave += newitem_Leave;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox txtcategory;
        private TextBox txtitemname;
        private TextBox txtprice;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button3;
        private Label label9;
    }
}