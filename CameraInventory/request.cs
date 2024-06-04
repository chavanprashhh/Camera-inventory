using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CameraInventory
{
    internal class request
    {
        CONNECT conn = new CONNECT();

        // creating a function to get all the repair list 

        public DataTable getrepair()
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM `repair_request`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);


            return table;
        }

        // creating a function to get all the recommended staff list 

        public DataTable getstaff()
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM `staff`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);


            return table;
        }



        // creating a function to add repair request 


        public bool addrequest(string Phone, string Name, string Problem, string OrderType, int staffID, DateTime delDate)
        {

            MySqlCommand command = new MySqlCommand();
            string insertQuery = "INSERT INTO `repair_request`(`Phone no`, `Customer Name`, `Problem`, `Order Type`, `Staff ID`, `Delivery Date`) VALUES (@phn,@nm,@prb,@odr,@stid,@date)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();


            // @phn,@nm,@prb,@odr,@stid,@date

            command.Parameters.Add("phn", MySqlDbType.VarChar).Value = Phone;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@prb", MySqlDbType.VarChar).Value = Problem;
            command.Parameters.Add("@odr", MySqlDbType.VarChar).Value = OrderType;
            command.Parameters.Add("@stid", MySqlDbType.Int32).Value = staffID;
            command.Parameters.Add("@date", MySqlDbType.Date).Value = delDate;

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

        // creating a function to edit the repair request 

        public bool editrequest(int ID, string Phone, string Name, string Problem, string OrderType, int staffID, DateTime delDate)
        {



            MySqlCommand command = new MySqlCommand();
            //@rid @phn,@nm,@prb,@odr,@stid,@date

            string editQuery = "UPDATE `repair_request` SET `Phone no`=@phn,`Customer Name`=@nm,`Problem`=@prb,`Order Type`=@odr,`Staff ID`=@stid,`Delivery Date`=@date WHERE `ID`=@rid";
            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@rid", MySqlDbType.Int32).Value = ID;
            command.Parameters.Add("phn", MySqlDbType.VarChar).Value = Phone;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@prb", MySqlDbType.VarChar).Value = Problem;
            command.Parameters.Add("@odr", MySqlDbType.VarChar).Value = OrderType;
            command.Parameters.Add("@stid", MySqlDbType.Int32).Value = staffID;
            command.Parameters.Add("@date", MySqlDbType.Date).Value = delDate;

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


        // creating a function to delete the repair request 
        // for this we will only need the request id 

        public bool removeRequest(int id)
        {

            MySqlCommand command = new MySqlCommand();
            string removeQuery = "DELETE FROM `repair_request` WHERE `ID`=@rid";
            command.CommandText = removeQuery;
            command.Connection = conn.getConnection();



            command.Parameters.Add("@rid", MySqlDbType.Int32).Value = id;

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
