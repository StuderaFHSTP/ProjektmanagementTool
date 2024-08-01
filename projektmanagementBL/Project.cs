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

        private Task[] tasks { get; set; }

        internal Project(){}

        public Project(string projectName, DateTime projectStart, DateTime projectEnd, string projectDescription, string projectOwner)
        {
            this.projectID = Guid.NewGuid().ToString();
            DatabaseConnection dbConn = new DatabaseConnection();
            SqlConnection conn = dbConn.GetConnection();
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
            DatabaseConnection dbConn = new DatabaseConnection();
            SqlConnection conn = dbConn.GetConnection();
            string query = "SELECT taskID, taskName, taskDescription, deadline, status, projectID, assignedUser FROM Task WHERE projectID = @projectID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@projectID", this.projectID);

            List<Task> taskList = new List<Task>();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Task task = new Task(
                    reader["taskID"].ToString(),
                    reader["taskName"].ToString(),
                    reader["taskDescription"].ToString(),
                    DateTime.Parse(reader["deadline"].ToString()),
                    int.Parse(reader["status"].ToString()),
                    reader["projectID"].ToString(),
                    reader["assignedUser"].ToString()
                );
                taskList.Add(task);
            }

            reader.Close();
            conn.Close();

            this.tasks = taskList.ToArray();
        }



    }
}
