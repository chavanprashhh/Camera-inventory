using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraInventory
{
    internal class deliv
    {
        CONNECT conn = new CONNECT();
        // creating a function to  get all the deadline day request from the repair request datatable 

        public DataTable getlist()
        {

            MySqlCommand command = new MySqlCommand("SELECT * FROM `repair_request` WHERE `Delivery Date`= CURDATE()", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);


            return table;
        }



    }
}
