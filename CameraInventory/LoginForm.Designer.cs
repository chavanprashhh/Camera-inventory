namespace CameraInventory
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            groupBox1 = new GroupBox();
            Login = new Button();
            Password = new TextBox();
            Username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Login);
            groupBox1.Controls.Add(Password);
            groupBox1.Controls.Add(Username);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(49, 244);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(378, 193);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Login
            // 
            Login.BackColor = Color.Gold;
            Login.FlatAppearance.BorderSize = 0;
            Login.FlatStyle = FlatStyle.Flat;
            Login.Location = new Point(141, 144);
            Login.Name = "Login";
            Login.Size = new Size(94, 29);
            Login.TabIndex = 4;
            Login.Text = "Log in";
            Login.UseVisualStyleBackColor = false;
            Login.Click += button1_Click;
            // 
            // Password
            // 
            Password.Location = new Point(163, 78);
            Password.Name = "Password";
            Password.Size = new Size(178, 27);
            Password.TabIndex = 3;
            Password.UseSystemPasswordChar = true;
            // 
            // Username
            // 
            Username.Location = new Point(163, 31);
            Username.Name = "Username";
            Username.Size = new Size(178, 27);
            Username.TabIndex = 2;
            Username.TextChanged += Username_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 85);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 1;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 38);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 0;
            label2.Text = "User Name";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(49, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 159);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(72, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(245, 117);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(104, 221);
            label1.Name = "label1";
            label1.Size = new Size(237, 20);
            label1.TabIndex = 3;
            label1.Text = "Please fill in the details to sign in";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(486, 449);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "LoginForm";
            Text = "Login";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Button Login;
        private TextBox Password;
        private TextBox Username;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}