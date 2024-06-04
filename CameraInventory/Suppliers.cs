using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraInventory
{
    public partial class Suppliers : Form
    {

        SUPPLIER supplier = new SUPPLIER();
        public Suppliers()
        {
            InitializeComponent();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {


            dataGridView1.DataSource = supplier.getSuppliers();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            String Name = textBoxName.Text;
            String Address = textBoxAddress.Text;
            String Phone = textBoxPhone.Text;


            if (Name.Trim().Equals("") || Address.Trim().Equals("") || Phone.Trim().Equals(""))
            {
                MessageBox.Show("Error empty fields", "Supplier Add", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            else
            {

                Boolean insertSupplier = supplier.insertSupplier(Name, Address, Phone);

                if (insertSupplier)
                {
                    MessageBox.Show("New Supplier has been entered", "Supplier Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = supplier.getSuppliers();
                }
                else
                {
                    MessageBox.Show("Error Supplier has not been entered", "Supplier Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }



        private void buttonEdit_Click(object sender, EventArgs e)
        {
            int id;
            String Name = textBoxName.Text;
            String Address = textBoxAddress.Text;
            String Phone = textBoxPhone.Text;


            try
            {
                id = Convert.ToInt32(textBoxID.Text);



                if (Name.Trim().Equals("") || Address.Trim().Equals("") || Phone.Trim().Equals(""))
                {
                    MessageBox.Show("Error empty fields", " Update Supplier ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                {

                    Boolean insertSupplier = supplier.editSupplier(id, Name, Address, Phone);


                    if (insertSupplier)
                    {

                        dataGridView1.DataSource = supplier.getSuppliers();
                        MessageBox.Show("Supplier has been updated", "Update Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Error Supplier notupdated", "Update Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }







            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        // display the data from the datagrid to the text boxes 
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxAddress.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxPhone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {

                int id = Convert.ToInt32(textBoxID.Text);

                if (supplier.removeSupplier(id))
                {
                    dataGridView1.DataSource = supplier.getSuppliers();
                    MessageBox.Show("Supplier has been deleted", "Delete Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // calling the clear button function to clear all the fields after the data from the data table has been deleted

                    buttonClear.PerformClick();


                }
                else
                {
                    MessageBox.Show("Error Supplier not deleted", "Delete Supplier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxName.Text = "";
            textBoxAddress.Text = "";
            textBoxPhone.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

