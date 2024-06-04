using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CameraInventory
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CONNECT conn = new CONNECT();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            String query = "SELECT * FROM `staff` WHERE `username`=@usn AND `password`=@pass";



            command.CommandText = query;
            command.Connection = conn.getConnection();


            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = Username.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = Password.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);


            // IF THE USER NAME AND THE PASSWORD EXISTS IN THE DATABASE 

            if (table.Rows.Count > 0)
            {
                // if the username and password is correct the user can proceed to the main page of the application 
                this.Hide();
                MainForm mform = new MainForm(Username.Text);
                mform.Show();
            }
            else
            {
                if (Username.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your username", "Empty username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Password.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter your password", "Empty password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("This username or password doesn't exist", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
