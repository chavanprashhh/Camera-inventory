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
    public partial class report : Form
    {

        CONNECT conn = new CONNECT();
        MySqlDataReader dr;
        public report()
        {
            InitializeComponent();
        }

        private void report_Load(object sender, EventArgs e)
        {
            dataGridView1.RowTemplate.Height = 30;
            Load_report();
        }

        public void Load_report()
        {
            dataGridView1.Rows.Clear();
            conn.openConnection();

            MySqlCommand cmd = new MySqlCommand("SELECT `stno`, `attendate`, `intime`, `instatus`, `outitme`, `outstatus` FROM `tbl_attend`", conn.getConnection());

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dr["stno"].ToString(), dr["attendate"].ToString(), dr["intime"].ToString(), dr["instatus"].ToString(), dr["outitme"].ToString(), dr["outstatus"].ToString());

            }
            dr.Dispose();
            conn.closeConnection();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

            dataGridView1.Rows.Clear();
            conn.openConnection();

            MySqlCommand cmd = new MySqlCommand("SELECT `stno`, `attendate`, `intime`, `instatus`, `outitme`, `outstatus` FROM `tbl_attend` WHERE stno like '%"+ txt_Search.Text +"%'  ", conn.getConnection());

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dr["stno"].ToString(), dr["attendate"].ToString(), dr["intime"].ToString(), dr["instatus"].ToString(), dr["outitme"].ToString(), dr["outstatus"].ToString());

            }
            dr.Dispose();
            conn.closeConnection();

        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            string date1 = dateTimePicker1.Value.ToString("yy-MM-dd");
            string date2 = dateTimePicker1.Value.ToString("yy-MM-dd");



            dataGridView1.Rows.Clear();
            conn.openConnection();

            MySqlCommand cmd = new MySqlCommand("SELECT `stno`, `attendate`, `intime`, `instatus`, `outitme`, `outstatus` FROM `tbl_attend` WHERE attendate between '"+ date1+"' and '"+ date2+"' ", conn.getConnection());

            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                dataGridView1.Rows.Add(dataGridView1.Rows.Count + 1, dr["stno"].ToString(), dr["attendate"].ToString(), dr["intime"].ToString(), dr["instatus"].ToString(), dr["outitme"].ToString(), dr["outstatus"].ToString());

            }
            dr.Dispose();
            conn.closeConnection();



        }
    }
}
