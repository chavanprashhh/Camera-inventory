using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CameraInventory
{

    // creating a class supplier to insert update and get all suppliers 
    internal class SUPPLIER
    {
        CONNECT conn = new CONNECT();

        // creating a function to insert a new supplier 

        public bool insertSupplier( string Name, string Address ,string Phone)
        {

            MySqlCommand command = new MySqlCommand();
            string insertQuery = "INSERT INTO `suppliers`(`Name`, `Address`, `Phone No`) VALUES (@nm,@phn,@add)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();


            // ,@phn,@add,@nm
            command.Parameters.Add("@nm",MySqlDbType.VarChar).Value=Name;
            command.Parameters.Add("@add", MySqlDbType.VarChar).Value = Address;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = Phone;
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


        // creating a function to get the supplier list 

        public DataTable getSuppliers()
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM `suppliers`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.SelectCommand = command;   
            adapter.Fill(table);

            
            return table;
        }


        // creating a function to edit suppliers list 

        public bool editSupplier(int ID, string Name, string Address, string Phone) {
            


            MySqlCommand command = new MySqlCommand();


            string editQuery = "UPDATE `suppliers` SET `Name`=@nm,`Address`=@add,`Phone No`=@phn WHERE `ID`=@sid";
            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@sid", MySqlDbType.Int32).Value = ID;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@add", MySqlDbType.VarChar).Value = Address;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = Phone;


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

        // creating a function to delete items from the table 
        // to do this we will will only take the supplier id into account and use it to delete the data 

        public bool removeSupplier(int id)
        {

            MySqlCommand command = new MySqlCommand();
            string removeQuery = "DELETE FROM `suppliers` WHERE `ID` =@sid";
            command.CommandText = removeQuery;
            command.Connection = conn.getConnection();



            command.Parameters.Add("@sid", MySqlDbType.Int32).Value = id;

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

