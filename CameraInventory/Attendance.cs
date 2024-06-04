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
using System.Diagnostics.Eventing.Reader;

namespace CameraInventory
{
    public partial class Attendance : Form
    {
        int i = 0;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        DataTable dt;

        CONNECT conn = new CONNECT();
        public Attendance()
        {
            InitializeComponent();


        }

        private void buttonReport_Click(object sender, EventArgs e)
        {

        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            lbl_info.Text = "";
        }

        private void btn_Timeinout_Click(object sender, EventArgs e)
        {
            conn.openConnection();
            if (txt_enterStno.Text == string.Empty)
            {
                lbl_info.Text = "Enter Staff no";
                lbl_info.ForeColor = Color.Orange;
            }


            else
            {

                MySqlCommand cmd = new MySqlCommand("SELECT * FROM `staff` WHERE `stno`=@stno", conn.getConnection());
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@stno", txt_enterStno.Text);

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                da.SelectCommand = cmd;

                if (dt.Rows.Count > 0)
                {
                    cmd = new MySqlCommand("SELECT * FROM `tbl_attend` WHERE `stno`=@stno AND `attendate`=@attendate AND `outstatus`=@outstatus AND `instatus`=@instatus", conn.getConnection());
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@stno", txt_enterStno.Text);
                    cmd.Parameters.AddWithValue("@attendate", DateTime.Now.ToString("yy-MM-dd"));
                    cmd.Parameters.AddWithValue("@outstatus", "Time in");
                    cmd.Parameters.AddWithValue("@instatus", "Time out");

                    da = new MySqlDataAdapter();
                    dt = new DataTable();
                    da.SelectCommand = cmd;
                    da.Fill(dt);
                    

                    if (dt.Rows.Count > 0)
                    {
                        lbl_info.Text = "Already Timed out today ";
                        lbl_info.ForeColor = Color.Green;
                    }
                    else
                    {
                        cmd = new MySqlCommand("SELECT * FROM `tbl_attend` WHERE `stno`=@stno AND `attendate`=@attendate AND `instatus`=@instatus", conn.getConnection());
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddWithValue("@stno", txt_enterStno.Text);
                        cmd.Parameters.AddWithValue("@attendate", DateTime.Now.ToString("yy-MM-dd"));
                        cmd.Parameters.AddWithValue("@instatus","Time in");

                        da = new MySqlDataAdapter();
                        dt = new DataTable();
                        da.SelectCommand = cmd;
                        da.Fill(dt);
                        da.SelectCommand = cmd;

                        if (dt.Rows.Count > 0)
                        {
                            cmd = new MySqlCommand("UPDATE `tbl_attend` SET `outitme`=@outtime,`outstatus`=@outstatus WHERE `stno`=@stno AND `attendate`=@attendate", conn.getConnection());
                            
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@outtime", DateTime.Now.ToString("hh:mm:ss tt"));
                            cmd.Parameters.AddWithValue("@outstatus", "Time out");
                            cmd.Parameters.AddWithValue("@stno", txt_enterStno.Text);
                            cmd.Parameters.AddWithValue("@attendate", DateTime.Now.ToString("yy-MM-dd"));

                            i = cmd.ExecuteNonQuery();

                           

                            if (i > 0)
                            {

                                lbl_info.Text = "Timed out Succesful ";
                                lbl_info.ForeColor = Color.Green;
                            }
                            else
                            {
                                lbl_info.Text = "Timed out Failed ";
                                lbl_info.ForeColor = Color.Red;
                            }

                        }

                        else
                        {
                            cmd = new MySqlCommand("INSERT INTO `tbl_attend`(`stno`, `attendate`, `intime`, `instatus`) VALUES (@stno,@attendate,@intime,@instatus)", conn.getConnection());
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddWithValue("@stno", txt_enterStno.Text);
                            cmd.Parameters.AddWithValue("@attendate", DateTime.Now.ToString("yy-MM-dd"));
                            cmd.Parameters.AddWithValue("@intime", DateTime.Now.ToString("hh:mm:ss tt"));
                            cmd.Parameters.AddWithValue("@instatus", "Time in");



                            i = cmd.ExecuteNonQuery();

                            if (i > 0)
                            {

                                lbl_info.Text = "Timed in Succesful ";
                                lbl_info.ForeColor = Color.Green;
                            }
                            else
                            {
                                lbl_info.Text = "Timed in Failed ";
                                lbl_info.ForeColor = Color.Red;
                            }

                        }


                    }



                }

                else
                {

                    lbl_info.Text = "Staff not found ";
                    lbl_info.ForeColor = Color.Red;
                }

            }
            conn.closeConnection();
        }
    }
}
