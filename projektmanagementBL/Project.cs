using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektmanagementBL
{
    public class Project
    {
        private string projectID { get; set; }
        private string projectName { get; set; }
        private DateTime projectStart { get; set; }
        private DateTime projectEnd { get; set; }
        private string projectDescription { get; set; }
        private string projectOwner { get; set; }

        //private Task[] tasks { get; set; }

        internal Project(){}

        private SqlConnection getConnection()
        {
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\fabia\\FH\\Software Architecture\\Projekt\\projektmanagementDL\\projektmanagementDB.mdf\";Integrated Security=True;Connect Timeout=5";
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                conn.Open();
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return conn;
            
        }

        public Project(string projectName, DateTime projectStart, DateTime projectEnd, string projectDescription, string projectOwner)
        {
            this.projectID = Guid.NewGuid().ToString();
            //create Project in DB
            SqlConnection conn = getConnection();
            string query = "INSERT INTO Project (projectID, projectName, projectStart, projectEnd, projectDescription, projectOwner) VALUES (@projectID, @projectName, @projectStart, @projectEnd, @projectDescription, @projectOwner)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@projectID", this.projectID);
            cmd.Parameters.AddWithValue("@projectName", projectName);
            cmd.Parameters.AddWithValue("@projectStart", projectStart);
            cmd.Parameters.AddWithValue("@projectEnd", projectEnd);
            cmd.Parameters.AddWithValue("@projectDescription", projectDescription);
            cmd.Parameters.AddWithValue("@projectOwner", projectOwner);
            cmd.ExecuteNonQuery();
            conn.Close();

            
        }

        public void getAllTasks()
        {

        }



    }
}
