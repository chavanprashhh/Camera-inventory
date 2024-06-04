using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CameraInventory
{
    public partial class RepairRequest : Form
    {

        request requests = new request();
        public RepairRequest()
        {
            InitializeComponent();
        }

        private void RepairRequest_Load(object sender, EventArgs e)
        {
            // show all repair request in the datagrid table 
            dataGridView1.DataSource = requests.getrepair();
            dataGridView2.DataSource = requests.getstaff();

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxPhone.Text = "";
            textBoxName.Text = "";
            comboBoxProblem.Text = "";
            comboBoxOrder.Text = "";
            textBoxStaffID.Text = "";
            dateTimePickerdel.Value = DateTime.Now;

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                String Phone = textBoxPhone.Text;
                String Name = textBoxName.Text;
                String Problem = comboBoxProblem.Text;
                String OrderType = comboBoxOrder.Text;
                DateTime deldate = dateTimePickerdel.Value;
                int staffID = Convert.ToInt32(textBoxStaffID.Text);

                // delivery date must be greater than current date 

                if (deldate <= DateTime.Now)
                {

                    MessageBox.Show("Delivery date must be later than todays date", "Invalid date", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    if (requests.addrequest(Phone, Name, Problem, OrderType, staffID, deldate))
                    {
                        MessageBox.Show("Request has been added", "Add request", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        MessageBox.Show("Request has not been added", "Add request", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add request error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }







        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(textBoxID.Text);
                String Phone = textBoxPhone.Text;
                String Name = textBoxName.Text;
                String Problem = comboBoxProblem.Text;
                String OrderType = comboBoxOrder.Text;
                DateTime deldate = dateTimePickerdel.Value;
                int staffID = Convert.ToInt32(textBoxStaffID.Text);

                // delivery date must be greater than current date 

                if (deldate < DateTime.Now)
                {

                    MessageBox.Show("Delivery date must be later than todays date", "Invalid date", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    if (requests.editrequest(ID, Phone, Name, Problem, OrderType, staffID, deldate))
                    {
                        MessageBox.Show("Request has been added", "Add request", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        MessageBox.Show("Request has not been added", "Add request", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add request error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }







        }



        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxID.Text);
                if (requests.removeRequest(id)){
                    MessageBox.Show("Request deleted", "Delete request ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete request error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxPhone.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBoxProblem.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBoxOrder.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBoxStaffID.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
