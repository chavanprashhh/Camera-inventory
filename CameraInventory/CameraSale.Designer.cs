namespace CameraInventory
{
    partial class CameraSale
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxID = new TextBox();
            textBoxSoldto = new TextBox();
            textBoxPhone = new TextBox();
            textBoxInvid = new TextBox();
            comboBoxStatus = new ComboBox();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            label6 = new Label();
            textBoxstid = new TextBox();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 64);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Sale ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 123);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(495, 67);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 2;
            label3.Text = "Sold to ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(495, 120);
            label4.Name = "label4";
            label4.Size = new Size(109, 20);
            label4.TabIndex = 3;
            label4.Text = "Phone number ";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(215, 64);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(151, 27);
            textBoxID.TabIndex = 4;
            // 
            // textBoxSoldto
            // 
            textBoxSoldto.Location = new Point(632, 64);
            textBoxSoldto.Name = "textBoxSoldto";
            textBoxSoldto.Size = new Size(151, 27);
            textBoxSoldto.TabIndex = 5;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(632, 117);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(151, 27);
            textBoxPhone.TabIndex = 6;
            // 
            // textBoxInvid
            // 
            textBoxInvid.Location = new Point(215, 181);
            textBoxInvid.Name = "textBoxInvid";
            textBoxInvid.Size = new Size(151, 27);
            textBoxInvid.TabIndex = 7;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "Sold ", "Rent", "Not Sold" });
            comboBoxStatus.Location = new Point(215, 120);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(151, 28);
            comboBoxStatus.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(80, 184);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 9;
            label5.Text = "Inventory ID";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(113, 287);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(746, 327);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(497, 181);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 11;
            label6.Text = "Staff ID";
            // 
            // textBoxstid
            // 
            textBoxstid.Location = new Point(632, 174);
            textBoxstid.Name = "textBoxstid";
            textBoxstid.Size = new Size(149, 27);
            textBoxstid.TabIndex = 12;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(156, 242);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(293, 242);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 14;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(421, 242);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 15;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(591, 242);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(94, 29);
            buttonClear.TabIndex = 16;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // CameraSale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 643);
            Controls.Add(buttonClear);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxstid);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(comboBoxStatus);
            Controls.Add(textBoxInvid);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxSoldto);
            Controls.Add(textBoxID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CameraSale";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CameraSale";
            Load += CameraSale_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxID;
        private TextBox textBoxSoldto;
        private TextBox textBoxPhone;
        private TextBox textBoxInvid;
        private ComboBox comboBoxStatus;
        private Label label5;
        private DataGridView dataGridView1;
        private Label label6;
        private TextBox textBoxstid;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonClear;
    }
}