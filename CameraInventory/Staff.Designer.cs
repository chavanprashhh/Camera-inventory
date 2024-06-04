namespace CameraInventory
{
    partial class Staff
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
            textBoxUserName = new TextBox();
            textBoxPassword = new TextBox();
            textBoxName = new TextBox();
            textBoxAddress = new TextBox();
            textBoxPhone = new TextBox();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            buttonClear = new Button();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            comboBoxSpec = new ComboBox();
            label8 = new Label();
            textBoxStaffno = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 58);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 0;
            label1.Text = "Staff ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 110);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "User name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 165);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 220);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 272);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 4;
            label5.Text = "Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 327);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 5;
            label6.Text = "Phone";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(147, 55);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(202, 27);
            textBoxID.TabIndex = 6;
            // 
            // textBoxUserName
            // 
            textBoxUserName.Location = new Point(147, 103);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(202, 27);
            textBoxUserName.TabIndex = 7;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(147, 162);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(202, 27);
            textBoxPassword.TabIndex = 8;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(147, 217);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(202, 27);
            textBoxName.TabIndex = 9;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(147, 272);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(202, 27);
            textBoxAddress.TabIndex = 10;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(147, 327);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(202, 27);
            textBoxPhone.TabIndex = 11;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(27, 488);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 12;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(137, 488);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 29);
            buttonUpdate.TabIndex = 13;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(237, 488);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(94, 29);
            buttonDelete.TabIndex = 14;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(137, 544);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(94, 29);
            buttonClear.TabIndex = 15;
            buttonClear.Text = "Clear";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(374, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(663, 450);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += dataGridView1_CellClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 377);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 17;
            label7.Text = "Specilization";
            // 
            // comboBoxSpec
            // 
            comboBoxSpec.FormattingEnabled = true;
            comboBoxSpec.Items.AddRange(new object[] { "Lens ", "DSLR" });
            comboBoxSpec.Location = new Point(147, 377);
            comboBoxSpec.Name = "comboBoxSpec";
            comboBoxSpec.Size = new Size(202, 28);
            comboBoxSpec.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 431);
            label8.Name = "label8";
            label8.Size = new Size(101, 20);
            label8.TabIndex = 19;
            label8.Text = "Atendance no";
            // 
            // textBoxStaffno
            // 
            textBoxStaffno.Location = new Point(147, 428);
            textBoxStaffno.Name = "textBoxStaffno";
            textBoxStaffno.Size = new Size(202, 27);
            textBoxStaffno.TabIndex = 20;
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 598);
            Controls.Add(textBoxStaffno);
            Controls.Add(label8);
            Controls.Add(comboBoxSpec);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(buttonClear);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxName);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUserName);
            Controls.Add(textBoxID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Staff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff";
            Load += Staff_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox textBoxUserName;
        private TextBox textBoxPassword;
        private TextBox textBoxName;
        private TextBox textBoxAddress;
        private TextBox textBoxPhone;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
        private Button buttonClear;
        private DataGridView dataGridView1;
        private Label label7;
        private ComboBox comboBoxSpec;
        private Label label8;
        private TextBox textBoxStaffno;
    }
}