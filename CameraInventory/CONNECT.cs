using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace CameraInventory
{

    // This class will connect our desktop inventory application with mysql database
    internal class CONNECT
    {

        private MySqlConnection connection = new MySqlConnection("datasource = localhost; port=3306;username=root;password=;database=Camera_Inventory;" );


        //creating a function to return our connection

        public MySqlConnection getConnection()
        {
            return connection;
        }


        // creating a function to open connection

        public void openConnection()
        {
            if(connection.State == ConnectionState.Closed) { 
                connection.Open();
            }
        }


        // creating a function to close the connection 
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }


    }
}
