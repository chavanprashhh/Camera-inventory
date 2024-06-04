using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace CameraInventory
{
    internal class Staffs
    {

        CONNECT conn = new CONNECT();
        // creating a function to insert a new staff 

        public bool insertStaff(string Usname, string Password, string Name, string Address, string Phone, string Specialization, string Staffno)
        {

            MySqlCommand command = new MySqlCommand();
            string insertQuery = "INSERT INTO `staff`(`username`, `password`, `Name`, `Address`, `Phone`, `Specialization`,`stno`) VALUES (@usn,@pas,@nam,@add,@phn,@spz,@stno)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();


            // @usn,@pas,@nam,@add,@phn,@spz @ stno
            
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = Usname;
            command.Parameters.Add("@pas", MySqlDbType.VarChar).Value = Password;
            command.Parameters.Add("@nam", MySqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@add", MySqlDbType.VarChar).Value = Address;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = Phone;
            command.Parameters.Add("@spz", MySqlDbType.VarChar).Value = Specialization;
            command.Parameters.Add("@stno", MySqlDbType.VarChar).Value = Staffno;
            conn.openConnection();


            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }

        // creating a function to get all the staff list 

        public DataTable getStaff()
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM `staff`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);


            return table;
        }


        // creating a funciton to edit the staff list 

        public bool editStaff(int ID, string Usname, string Password, string Name, string Address, string Phone, string Specialization ,string Staffno)
        {



            MySqlCommand command = new MySqlCommand();


            string editQuery = "UPDATE `staff` SET `username`=@usn,`password`=@pas,`Name`=@nam,`Address`=@add,`Phone`=@phn,`Specialization`=@spz ,`stno`=@stno WHERE `Staff_ID`=@stid";
            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@stid", MySqlDbType.Int32).Value = ID;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = Usname;
            command.Parameters.Add("@pas", MySqlDbType.VarChar).Value = Password;
            command.Parameters.Add("@nam", MySqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@add", MySqlDbType.VarChar).Value = Address;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = Phone;
            command.Parameters.Add("@spz", MySqlDbType.VarChar).Value = Specialization;
            command.Parameters.Add("@stno", MySqlDbType.VarChar).Value = Staffno;


            conn.openConnection();


            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }

        }


        // creating a function to remove staff id 
        // for this processs we will only need the staff id to remove the whole row 

        public bool removeStaff(int id)
        {

            MySqlCommand command = new MySqlCommand();
            string removeQuery = "DELETE FROM `staff` WHERE `Staff_ID` =@stid";
            command.CommandText = removeQuery;
            command.Connection = conn.getConnection();



            command.Parameters.Add("@stid", MySqlDbType.Int32).Value = id;

            conn.openConnection();


            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }

        }

    }
}
