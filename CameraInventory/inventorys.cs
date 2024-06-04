using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraInventory
{
    internal class inventorys
    {

        CONNECT conn = new CONNECT();




        // creating a new functin to get all the items from the inventory
        public DataTable getitem()
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM `inventory`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);


            return table;
        }




        //Creating a new function to enter new items in the inventory 


        public bool additem(string item , string quantity, int supplierID)
        {

            MySqlCommand command = new MySqlCommand();
            string insertQuery = "INSERT INTO `inventory`(`Item`, `Quantity`, `Supplier ID`) VALUES (@item,@qt,@suid)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();


            // @item,@qt,@suid

            command.Parameters.Add("item", MySqlDbType.VarChar).Value = item;
            command.Parameters.Add("@qt", MySqlDbType.VarChar).Value = quantity;
            command.Parameters.Add("@suid", MySqlDbType.Int32).Value = supplierID;


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


        // creating a function to edit items in the inventory

        public bool edititem(int ID,string item, string quantity, int supplierID)
        {



            MySqlCommand command = new MySqlCommand();
            //

            string editQuery = "UPDATE `inventory` SET `Item`=@item,`Quantity`=@qt,`Supplier ID`=@suid WHERE `ID`= @iid";
            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@iid", MySqlDbType.Int32).Value = ID;
            command.Parameters.Add("item", MySqlDbType.VarChar).Value = item;
            command.Parameters.Add("@qt", MySqlDbType.VarChar).Value = quantity;
            command.Parameters.Add("@suid", MySqlDbType.Int32).Value = supplierID;


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

        // creating a function to remove items from the inventory 
        // for this we will only need the inventory id 

        public bool removeitem(int id)
        {

            MySqlCommand command = new MySqlCommand();
            string removeQuery = "DELETE FROM `inventory` WHERE `ID`=@iid";
            command.CommandText = removeQuery;
            command.Connection = conn.getConnection();



            command.Parameters.Add("@iid", MySqlDbType.Int32).Value = id;

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
