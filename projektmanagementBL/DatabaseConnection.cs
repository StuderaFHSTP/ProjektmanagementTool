using System;
using System.Data.SqlClient;

namespace projektmanagementBL
{
    public class DatabaseConnection
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\fabia\\FH\\Software Architecture\\Projekt\\projektmanagementDL\\projektmanagementDB.mdf\";Integrated Security=True;Connect Timeout=5";

        public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return conn;
        }
    }
}
