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
    public partial class CameraSale : Form
    {

        sale sale = new sale();
        public CameraSale()
        {
            InitializeComponent();
        }

        private void CameraSale_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = sale.getitem();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            comboBoxStatus.Text = "";
            textBoxSoldto.Text = "";
            textBoxPhone.Text = "";
            textBoxInvid.Text = "";
            textBoxstid.Text = "";

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                String status = comboBoxStatus.Text;
                String soldto = textBoxSoldto.Text;
                String phone = textBoxPhone.Text;
                int inventoryID = Convert.ToInt32(textBoxInvid.Text);
                int staffID = Convert.ToInt32(textBoxstid.Text);



                if (sale.additem(status, soldto, phone, inventoryID, staffID))
                {
                    MessageBox.Show("item has been added", "Add item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = sale.getitem();
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

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(textBoxID.Text);
                String status = comboBoxStatus.Text;
                String soldto = textBoxSoldto.Text;
                String phone = textBoxPhone.Text;
                int inventoryID = Convert.ToInt32(textBoxInvid.Text);
                int staffID = Convert.ToInt32(textBoxstid.Text);


                if (sale.edititem(ID, status, soldto, phone, inventoryID, staffID))
                {
                    MessageBox.Show("item has been updated", "update item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = sale.getitem();
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
                if (sale.removeitem(id))
                {
                    MessageBox.Show("Item deleted", "Delete item ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridView1.DataSource = sale.getitem();
                    buttonClear.PerformClick();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete request error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBoxStatus.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxSoldto.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxPhone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBoxInvid.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxstid.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
