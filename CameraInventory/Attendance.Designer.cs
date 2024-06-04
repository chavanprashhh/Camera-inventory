namespace CameraInventory
{
    partial class Attendance
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
            panel1 = new Panel();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonReport = new Button();
            txt_enterStno = new TextBox();
            btn_Timeinout = new Button();
            lbl_info = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlText;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(896, 67);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(25, 22);
            label1.Name = "label1";
            label1.Size = new Size(132, 27);
            label1.TabIndex = 3;
            label1.Text = "Attendance";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(buttonReport, 0, 0);
            tableLayoutPanel1.Location = new Point(641, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(250, 53);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonReport
            // 
            buttonReport.BackColor = SystemColors.ActiveCaptionText;
            buttonReport.FlatAppearance.BorderColor = Color.DimGray;
            buttonReport.FlatAppearance.BorderSize = 0;
            buttonReport.ForeColor = Color.White;
            buttonReport.Location = new Point(3, 3);
            buttonReport.Name = "buttonReport";
            buttonReport.Size = new Size(119, 47);
            buttonReport.TabIndex = 1;
            buttonReport.Text = "Report";
            buttonReport.UseVisualStyleBackColor = false;
            buttonReport.Click += buttonReport_Click;
            // 
            // txt_enterStno
            // 
            txt_enterStno.BackColor = SystemColors.Menu;
            txt_enterStno.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_enterStno.ForeColor = SystemColors.ActiveCaptionText;
            txt_enterStno.Location = new Point(304, 258);
            txt_enterStno.Name = "txt_enterStno";
            txt_enterStno.Size = new Size(212, 34);
            txt_enterStno.TabIndex = 1;
            txt_enterStno.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_Timeinout
            // 
            btn_Timeinout.BackColor = Color.RoyalBlue;
            btn_Timeinout.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Timeinout.ForeColor = SystemColors.Control;
            btn_Timeinout.Location = new Point(304, 332);
            btn_Timeinout.Name = "btn_Timeinout";
            btn_Timeinout.Size = new Size(212, 43);
            btn_Timeinout.TabIndex = 2;
            btn_Timeinout.Text = "Time IN / OUT";
            btn_Timeinout.UseVisualStyleBackColor = false;
            btn_Timeinout.Click += btn_Timeinout_Click;
            // 
            // lbl_info
            // 
            lbl_info.AutoSize = true;
            lbl_info.Location = new Point(366, 224);
            lbl_info.Name = "lbl_info";
            lbl_info.Size = new Size(50, 20);
            lbl_info.TabIndex = 3;
            lbl_info.Text = "label2";
            // 
            // Attendance
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(896, 528);
            Controls.Add(lbl_info);
            Controls.Add(btn_Timeinout);
            Controls.Add(txt_enterStno);
            Controls.Add(panel1);
            Name = "Attendance";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Attendance_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonReport;
        private TextBox txt_enterStno;
        private Button btn_Timeinout;
        private Label label1;
        private Label lbl_info;
    }
}