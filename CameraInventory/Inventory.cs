using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraInventory
{
    public partial class Inventory : Form
    {
        inventorys inventory = new inventorys();
        public Inventory()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                String item = textBoxItem.Text;
                String quantity = textBoxQuantity.Text;
                int supplierID = Convert.ToInt32(textBoxSid.Text);



                if (inventory.additem(item, quantity, supplierID))
                {
                    MessageBox.Show("item has been added", "Add item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = inventory.getitem();
                    buttonClear.PerformClick();
                }

                else
                {
                    MessageBox.Show("item has not been added", "Add item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add item error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxItem.Text = "";
            textBoxQuantity.Text = "";
            textBoxSid.Text = "";

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(textBoxID.Text);
                String item = textBoxItem.Text;
                String quantity = textBoxQuantity.Text;
                int supplierID = Convert.ToInt32(textBoxSid.Text);


                if (inventory.edititem(ID, item, quantity, supplierID))
                {
                    MessageBox.Show("item has been updated", "update item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = inventory.getitem();
                    buttonClear.PerformClick();
                }

                else
                {
                    MessageBox.Show("item has not been updated", "updat item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "update item error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                if (inventory.removeitem(id))
                {
                    MessageBox.Show("Item deleted", "Delete item ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridView1.DataSource = inventory.getitem();
                    buttonClear.PerformClick();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete request error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = inventory.getitem();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxItem.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxQuantity.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxSid.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
