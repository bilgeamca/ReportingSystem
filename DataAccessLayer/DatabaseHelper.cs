using MySql.Data.MySqlClient;
using System;

namespace DataAccessLayer
{
    public static class DatabaseHelper
    {
        private static string connectionString = "server=your_server;database=your_database;user=your_username;password=your_password;";

        public static MySqlConnection GetConnection()
        {
            try
            {
                var connection = new MySqlConnection(connectionString);
                connection.Open();
                return connection;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error opening connection: {ex.Message}");
                throw;
            }
        }

        public static void CloseConnection(MySqlConnection connection)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}