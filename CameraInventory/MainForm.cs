using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
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
    public partial class MainForm : Form
    {

        LoginForm log = new LoginForm();
        public MainForm()
        {
            InitializeComponent();
        }

        String username;
        public MainForm(String s)
        {
            InitializeComponent();

            username = s;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void buttonReport_Click(object sender, EventArgs e)
        {
            report rep = new report();
            rep.ShowDialog();


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (username != "admin")
            {
                buttonReport.Hide();
                buttonStaff.Hide();
                buttonAtt.Hide();

            }
        }

        private void buttonInv_Click(object sender, EventArgs e)
        {
            Inventory inventoryCF = new Inventory();
            inventoryCF.ShowDialog();
        }

        private void buttonRep_Click(object sender, EventArgs e)
        {
            RepairRequest repairCM = new RepairRequest();
            repairCM.ShowDialog();
        }

        private void buttonSale_Click(object sender, EventArgs e)
        {
            CameraSale saleCM = new CameraSale();
            saleCM.ShowDialog();
        }

        private void buttonSupp_Click(object sender, EventArgs e)
        {
            Suppliers suppliersSF = new Suppliers();
            suppliersSF.ShowDialog();
        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            Staff staffSF = new Staff();
            staffSF.ShowDialog();
        }

        private void buttonAtt_Click(object sender, EventArgs e)
        {
            Attendance attendanceCM = new Attendance();
            attendanceCM.ShowDialog();
        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            delivery del = new delivery();
            del.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
