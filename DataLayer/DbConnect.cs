using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace DataLayer
{
    public class DbConnect
    {
        public MySqlConnection connection;
        public string connectionString;
        private string server;
        private string database;
        private string uid;
        private string password;

        public DbConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "127.0.0.1";
            database = "scrappingbvl";
            uid = "root";
            password = "vhjjmeVH87";
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {                
                return false;
            }
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {                
                return false;
            }
        }
    }
}
