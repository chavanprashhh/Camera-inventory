namespace CameraInventory
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            buttondel = new Button();
            buttonSupp = new Button();
            buttonStaff = new Button();
            buttonSale = new Button();
            buttonAtt = new Button();
            buttonReport = new Button();
            buttonRep = new Button();
            buttonInv = new Button();
            panel3 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            panel5 = new Panel();
            button3 = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 39, 40);
            panel1.Controls.Add(buttondel);
            panel1.Controls.Add(buttonSupp);
            panel1.Controls.Add(buttonStaff);
            panel1.Controls.Add(buttonSale);
            panel1.Controls.Add(buttonAtt);
            panel1.Controls.Add(buttonReport);
            panel1.Controls.Add(buttonRep);
            panel1.Controls.Add(buttonInv);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(162, 539);
            panel1.TabIndex = 3;
            // 
            // buttondel
            // 
            buttondel.BackColor = Color.FromArgb(41, 39, 40);
            buttondel.FlatAppearance.BorderSize = 0;
            buttondel.FlatStyle = FlatStyle.Flat;
            buttondel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttondel.ForeColor = SystemColors.ButtonFace;
            buttondel.Location = new Point(0, 295);
            buttondel.Name = "buttondel";
            buttondel.Size = new Size(162, 29);
            buttondel.TabIndex = 5;
            buttondel.Text = "Delivery Deadline ";
            buttondel.UseVisualStyleBackColor = false;
            buttondel.Click += buttondel_Click;
            // 
            // buttonSupp
            // 
            buttonSupp.BackColor = Color.FromArgb(41, 39, 40);
            buttonSupp.FlatAppearance.BorderSize = 0;
            buttonSupp.FlatStyle = FlatStyle.Flat;
            buttonSupp.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSupp.ForeColor = SystemColors.ButtonFace;
            buttonSupp.Location = new Point(0, 247);
            buttonSupp.Name = "buttonSupp";
            buttonSupp.Size = new Size(162, 29);
            buttonSupp.TabIndex = 5;
            buttonSupp.Text = "Suppliers";
            buttonSupp.UseVisualStyleBackColor = false;
            buttonSupp.Click += buttonSupp_Click;
            // 
            // buttonStaff
            // 
            buttonStaff.BackColor = Color.FromArgb(41, 39, 40);
            buttonStaff.FlatAppearance.BorderSize = 0;
            buttonStaff.FlatStyle = FlatStyle.Flat;
            buttonStaff.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonStaff.ForeColor = SystemColors.ButtonFace;
            buttonStaff.Location = new Point(0, 347);
            buttonStaff.Name = "buttonStaff";
            buttonStaff.Size = new Size(162, 29);
            buttonStaff.TabIndex = 5;
            buttonStaff.Text = "Staff";
            buttonStaff.UseVisualStyleBackColor = false;
            buttonStaff.Click += buttonStaff_Click;
            // 
            // buttonSale
            // 
            buttonSale.BackColor = Color.FromArgb(41, 39, 40);
            buttonSale.FlatAppearance.BorderSize = 0;
            buttonSale.FlatStyle = FlatStyle.Flat;
            buttonSale.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSale.ForeColor = SystemColors.ButtonFace;
            buttonSale.Location = new Point(0, 202);
            buttonSale.Name = "buttonSale";
            buttonSale.Size = new Size(162, 29);
            buttonSale.TabIndex = 5;
            buttonSale.Text = " Rent/Sale";
            buttonSale.UseVisualStyleBackColor = false;
            buttonSale.Click += buttonSale_Click;
            // 
            // buttonAtt
            // 
            buttonAtt.BackColor = Color.FromArgb(41, 39, 40);
            buttonAtt.FlatAppearance.BorderSize = 0;
            buttonAtt.FlatStyle = FlatStyle.Flat;
            buttonAtt.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAtt.ForeColor = SystemColors.ButtonFace;
            buttonAtt.Location = new Point(0, 394);
            buttonAtt.Name = "buttonAtt";
            buttonAtt.Size = new Size(162, 29);
            buttonAtt.TabIndex = 7;
            buttonAtt.Text = "Attendance";
            buttonAtt.UseVisualStyleBackColor = false;
            buttonAtt.Click += buttonAtt_Click;
            // 
            // buttonReport
            // 
            buttonReport.BackColor = Color.FromArgb(41, 39, 40);
            buttonReport.FlatAppearance.BorderSize = 0;
            buttonReport.FlatStyle = FlatStyle.Flat;
            buttonReport.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReport.ForeColor = SystemColors.ButtonFace;
            buttonReport.Location = new Point(0, 444);
            buttonReport.Name = "buttonReport";
            buttonReport.Size = new Size(162, 29);
            buttonReport.TabIndex = 5;
            buttonReport.Text = "Attendance Report";
            buttonReport.UseVisualStyleBackColor = false;
            buttonReport.Click += buttonReport_Click;
            // 
            // buttonRep
            // 
            buttonRep.BackColor = Color.FromArgb(41, 39, 40);
            buttonRep.FlatAppearance.BorderSize = 0;
            buttonRep.FlatStyle = FlatStyle.Flat;
            buttonRep.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonRep.ForeColor = SystemColors.ButtonFace;
            buttonRep.Location = new Point(0, 154);
            buttonRep.Name = "buttonRep";
            buttonRep.Size = new Size(162, 29);
            buttonRep.TabIndex = 6;
            buttonRep.Text = "Repair Request";
            buttonRep.UseVisualStyleBackColor = false;
            buttonRep.Click += buttonRep_Click;
            // 
            // buttonInv
            // 
            buttonInv.BackColor = Color.FromArgb(41, 39, 40);
            buttonInv.FlatAppearance.BorderSize = 0;
            buttonInv.FlatStyle = FlatStyle.Flat;
            buttonInv.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonInv.ForeColor = SystemColors.ActiveCaptionText;
            buttonInv.Image = (Image)resources.GetObject("buttonInv.Image");
            buttonInv.ImageAlign = ContentAlignment.MiddleLeft;
            buttonInv.Location = new Point(0, 108);
            buttonInv.Name = "buttonInv";
            buttonInv.Size = new Size(162, 30);
            buttonInv.TabIndex = 5;
            buttonInv.Text = "Inventory";
            buttonInv.UseVisualStyleBackColor = false;
            buttonInv.Click += buttonInv_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(178, 8, 55);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(37, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(91, 126);
            panel3.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(6, 85);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 7;
            label1.Text = "Inventory";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.AutoSize = true;
            panel4.Controls.Add(button3);
            panel4.Controls.Add(panel2);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(panel5);
            panel4.Location = new Point(162, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(798, 611);
            panel4.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(22, 165);
            panel2.Name = "panel2";
            panel2.Size = new Size(764, 352);
            panel2.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(472, 47);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(223, 185);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(246, 174, 0);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(42, 229);
            button2.Name = "button2";
            button2.Size = new Size(208, 43);
            button2.TabIndex = 2;
            button2.Text = "Contact us";
            button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 130);
            label3.Name = "label3";
            label3.Size = new Size(344, 60);
            label3.TabIndex = 1;
            label3.Text = "Are you facing techincal difficulties? \r\nDon't worry you can contact one of our technicials \r\nwith a simple click of the button below.";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Elephant", 32F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(246, 174, 0);
            label2.Location = new Point(30, 37);
            label2.Name = "label2";
            label2.Size = new Size(250, 70);
            label2.TabIndex = 0;
            label2.Text = "Support";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(750, 27);
            button1.Name = "button1";
            button1.Size = new Size(45, 43);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(178, 8, 55);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(798, 22);
            panel5.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonHighlight;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(713, 34);
            button3.Name = "button3";
            button3.Size = new Size(31, 28);
            button3.TabIndex = 9;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(960, 539);
            Controls.Add(panel4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button buttonReport;
        private Button buttonSupp;
        private Button buttonStaff;
        private Button buttonSale;
        private Button buttonAtt;
        private Button buttonRep;
        private Button buttonInv;
        private Button buttondel;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Button button1;
        private Panel panel5;
        private Panel panel2;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox2;
        private Button button2;
        private Button button3;
    }
}