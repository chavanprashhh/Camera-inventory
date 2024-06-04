namespace CameraInventory
{
    partial class RepairRequest
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
            label5 = new Label();
            label6 = new Label();
            textBoxID = new TextBox();
            textBoxPhone = new TextBox();
            textBoxName = new TextBox();
            textBoxStaffID = new TextBox();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonClear = new Button();
            comboBoxProblem = new ComboBox();
            comboBoxOrder = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            dateTimePickerdel = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 27);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Request ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 76);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Phone no";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 129);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 2;
            label3.Text = "Customer Name ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 184);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 3;
            label4.Text = "Problem";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 233);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 4;
            label5.Text = "Order Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 281);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 5;
            label6.Text = "Staff Id";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(154, 24);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(209, 27);
            textBoxID.TabIndex = 6;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(154, 73);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(209, 27);
            textBoxPhone.TabIndex = 7;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(158, 122);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(205, 27);
            textBoxName.TabIndex = 8;
            // 
            // textBoxStaffID
            // 
            textBoxStaffID.Location = new Point(158, 274);
            textBoxStaffID.Name = "textBoxStaffID";
            textBoxStaffID.Size = new Size(205, 27);
            textBoxStaffID.TabIndex = 11;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(424, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(591, 327);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(32, 555);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(983, 188);
            dataGridView2.TabIndex = 13;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(38, 389);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 14;
            buttonAdd.Text = "Request";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(154, 389);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 15;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(260, 389);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 16;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(154, 439);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(94, 29);
            buttonClear.TabIndex = 17;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // comboBoxProblem
            // 
            comboBoxProblem.FormattingEnabled = true;
            comboBoxProblem.Items.AddRange(new object[] { "Lens ", "DSLR" });
            comboBoxProblem.Location = new Point(158, 176);
            comboBoxProblem.Name = "comboBoxProblem";
            comboBoxProblem.Size = new Size(205, 28);
            comboBoxProblem.TabIndex = 18;
            // 
            // comboBoxOrder
            // 
            comboBoxOrder.FormattingEnabled = true;
            comboBoxOrder.Items.AddRange(new object[] { "Urgent ", "Normal" });
            comboBoxOrder.Location = new Point(158, 225);
            comboBoxOrder.Name = "comboBoxOrder";
            comboBoxOrder.Size = new Size(205, 28);
            comboBoxOrder.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(32, 493);
            label7.Name = "label7";
            label7.Size = new Size(217, 25);
            label7.TabIndex = 20;
            label7.Text = "Recommended Staffs";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 328);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 21;
            label8.Text = "Delivery Date";
            // 
            // dateTimePickerdel
            // 
            dateTimePickerdel.CustomFormat = "dd/MM/yy";
            dateTimePickerdel.Location = new Point(158, 324);
            dateTimePickerdel.Name = "dateTimePickerdel";
            dateTimePickerdel.Size = new Size(205, 27);
            dateTimePickerdel.TabIndex = 22;
            // 
            // RepairRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 778);
            Controls.Add(dateTimePickerdel);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(comboBoxOrder);
            Controls.Add(comboBoxProblem);
            Controls.Add(buttonClear);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxStaffID);
            Controls.Add(textBoxName);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RepairRequest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RepairRequest";
            Load += RepairRequest_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxID;
        private TextBox textBoxPhone;
        private TextBox textBoxName;
        private TextBox textBoxStaffID;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonClear;
        private ComboBox comboBoxProblem;
        private ComboBox comboBoxOrder;
        private Label label7;
        private Label label8;
        private DateTimePicker dateTimePickerdel;
    }
}