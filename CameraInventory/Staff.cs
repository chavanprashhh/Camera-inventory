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
using System.IO;


namespace CameraInventory
{
    public partial class Staff : Form
    {
        Staffs staffs = new Staffs();
        public Staff()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxUserName.Text = "";
            textBoxPassword.Text = "";
            textBoxName.Text = "";
            textBoxAddress.Text = "";
            textBoxPhone.Text = "";
            comboBoxSpec.Text = "";
            textBoxStaffno.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            String Username = textBoxUserName.Text;
            String Password = textBoxPassword.Text;
            String Name = textBoxName.Text;
            String Address = textBoxAddress.Text;
            String Phone = textBoxPhone.Text;
            String Specialization = comboBoxSpec.Text;
            String Staffno = textBoxStaffno.Text;


            if (Username.Trim().Equals("") || Password.Trim().Equals("") || Name.Trim().Equals("") || Address.Trim().Equals("") || Phone.Trim().Equals("") || Specialization.Trim().Equals("") || Staffno.Trim().Equals(""))
            {
                MessageBox.Show("Error empty fields", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {

                Boolean insertStaff = staffs.insertStaff(Username, Password, Name, Address, Phone, Specialization, Staffno);

                if (insertStaff)
                {
                    MessageBox.Show("New Staff has been added", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = staffs.getStaff();
                }
                else
                {
                    MessageBox.Show("Error Staff has not been added", "Add Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = staffs.getStaff();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int id;
            String Username = textBoxUserName.Text;
            String Password = textBoxPassword.Text;
            String Name = textBoxName.Text;
            String Address = textBoxAddress.Text;
            String Phone = textBoxPhone.Text;
            String Specialization = comboBoxSpec.Text;
            String Staffno = textBoxStaffno.Text;

            try
            {
                id = Convert.ToInt32(textBoxID.Text);



                if (Username.Trim().Equals("") || Password.Trim().Equals("") || Name.Trim().Equals("") || Address.Trim().Equals("") || Phone.Trim().Equals("") || Specialization.Trim().Equals("") || Staffno.Trim().Equals(""))
                {
                    MessageBox.Show("Error empty fields", " Update Staff ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {

                    Boolean insertSupplier = staffs.editStaff(id, Username, Password, Name, Address, Phone, Specialization, Staffno);


                    if (insertSupplier)
                    {

                        dataGridView1.DataSource = staffs.getStaff();
                        MessageBox.Show("Staff has been updated", "Update Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Error Staff notupdated", "Update Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }







            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxUserName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxPassword.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxAddress.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxPhone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBoxSpec.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBoxStaffno.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {

                int id = Convert.ToInt32(textBoxID.Text);

                if (staffs.removeStaff(id))
                {
                    dataGridView1.DataSource = staffs.getStaff();
                    MessageBox.Show("Staff has been deleted", "Delete Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // calling the clear button function to clear all the fields after the data from the data table has been deleted

                    buttonClear.PerformClick();


                }
                else
                {
                    MessageBox.Show("Error Staff not deleted", "Delete Staff", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
