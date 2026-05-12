using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperMarket
{
    internal class DatabaseConnection
    {
        private MySqlConnection connection;

        public DatabaseConnection()
        {
            String connectionString = "Server=127.0.0.1;Database=market;Uid=root;Pwd=123456;";
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
