namespace cafe
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            panel3 = new Panel();
            button1 = new Button();
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            pLACEORDERToolStripMenuItem = new ToolStripMenuItem();
            iNVENTORYToolStripMenuItem = new ToolStripMenuItem();
            oRDERSLISTToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Location = new Point(324, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(1551, 1010);
            panel3.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 64, 0);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.ForeColor = Color.Beige;
            button1.Location = new Point(97, 939);
            button1.Name = "button1";
            button1.Size = new Size(240, 41);
            button1.TabIndex = 6;
            button1.Text = "LOG OUT";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(128, 64, 0);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(menuStrip1);
            panel1.Location = new Point(51, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 1010);
            panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { pLACEORDERToolStripMenuItem, iNVENTORYToolStripMenuItem, oRDERSLISTToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(273, 1010);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // pLACEORDERToolStripMenuItem
            // 
            pLACEORDERToolStripMenuItem.AutoSize = false;
            pLACEORDERToolStripMenuItem.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            pLACEORDERToolStripMenuItem.ForeColor = Color.White;
            pLACEORDERToolStripMenuItem.Name = "pLACEORDERToolStripMenuItem";
            pLACEORDERToolStripMenuItem.Size = new Size(266, 100);
            pLACEORDERToolStripMenuItem.Text = "PLACE ORDER";
            pLACEORDERToolStripMenuItem.Click += pLACEORDERToolStripMenuItem_Click_1;
            // 
            // iNVENTORYToolStripMenuItem
            // 
            iNVENTORYToolStripMenuItem.AutoSize = false;
            iNVENTORYToolStripMenuItem.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            iNVENTORYToolStripMenuItem.ForeColor = Color.White;
            iNVENTORYToolStripMenuItem.Name = "iNVENTORYToolStripMenuItem";
            iNVENTORYToolStripMenuItem.Size = new Size(266, 100);
            iNVENTORYToolStripMenuItem.Text = "INVENTORY";
            iNVENTORYToolStripMenuItem.Click += iNVENTORYToolStripMenuItem_Click;
            // 
            // oRDERSLISTToolStripMenuItem
            // 
            oRDERSLISTToolStripMenuItem.AutoSize = false;
            oRDERSLISTToolStripMenuItem.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            oRDERSLISTToolStripMenuItem.ForeColor = Color.White;
            oRDERSLISTToolStripMenuItem.Name = "oRDERSLISTToolStripMenuItem";
            oRDERSLISTToolStripMenuItem.Size = new Size(266, 100);
            oRDERSLISTToolStripMenuItem.Text = "ORDERS LIST";
            oRDERSLISTToolStripMenuItem.Click += oRDERSLISTToolStripMenuItem_Click;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 0);
            ClientSize = new Size(1942, 1102);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "main";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "main";
            WindowState = FormWindowState.Maximized;
            Load += main_Load;
            panel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Button button1;
        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem pLACEORDERToolStripMenuItem;
        private ToolStripMenuItem iNVENTORYToolStripMenuItem;
        private ToolStripMenuItem oRDERSLISTToolStripMenuItem;
    }
}