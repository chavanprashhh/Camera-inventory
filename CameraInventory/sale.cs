using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraInventory
{
    internal class sale
    {
        CONNECT conn = new CONNECT();


        // creating a function to get cameras listed in sale , rent

        public DataTable getitem()
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM `camera_sale`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);


            return table;
        }


        // creating a function to list camera in camera sale list 


        public bool additem(string status, string soldto,string phone, int inventoryID,int staffID)
        {

            MySqlCommand command = new MySqlCommand();
            string insertQuery = "INSERT INTO `camera_sale`(`Status`, `Sold to`, `Phone No`, `Inventory ID`, `Staff ID`) VALUES (@sta ,@sold ,@phn,@iid,@stid)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();


            // @sta ,@sold ,@phn,@iid,@stid

            command.Parameters.Add("sta", MySqlDbType.VarChar).Value = status;
            command.Parameters.Add("@sold", MySqlDbType.VarChar).Value = soldto;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@iid", MySqlDbType.Int32).Value = inventoryID;
            command.Parameters.Add("@stid", MySqlDbType.Int32).Value = staffID;


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


        // creating a function to edit sale deatails in the list 


        public bool edititem(int ID, string status, string soldto, string phone, int inventoryID, int staffID)
        {



            MySqlCommand command = new MySqlCommand();
            // @sta ,@sold ,@phn,@iid,@stid

            string editQuery = "UPDATE `camera_sale` SET `Status`=@sta,`Sold to`=@sold,`Phone No`=@phn,`Inventory ID`=@iid,`Staff ID`=@stid WHERE `ID`=@salid";
            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@salid", MySqlDbType.Int32).Value = ID;
            command.Parameters.Add("sta", MySqlDbType.VarChar).Value = status;
            command.Parameters.Add("@sold", MySqlDbType.VarChar).Value = soldto;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@iid", MySqlDbType.Int32).Value = inventoryID;
            command.Parameters.Add("@stid", MySqlDbType.Int32).Value = staffID;


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


        // creating a function to delete the item from sales list 
        public bool removeitem(int id)
        {

            MySqlCommand command = new MySqlCommand();
            string removeQuery = "DELETE FROM `camera_sale` WHERE `ID`=@salid";
            command.CommandText = removeQuery;
            command.Connection = conn.getConnection();



            command.Parameters.Add("@salid", MySqlDbType.Int32).Value = id;

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
