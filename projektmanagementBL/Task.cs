using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektmanagementBL
{
    public class Task
    {
        private string taskID { get; set; }
        private string taskName { get; set; }
        private string taskDescription { get; set; }
        private DateTime deadline { get; set; }
        private int status { get; set; }
        private string projectID { get; set; }
        private string assignedUser { get; set; }

        internal Task() { }

        public Task(string taskID, string taskName, string taskDescription, DateTime deadline, int status, string projectID, string assignedUser)
        {
            this.taskID = taskID;
            this.taskName = taskName;
            this.taskDescription = taskDescription;
            this.deadline = deadline;
            this.status = status;
            this.projectID = projectID;
            this.assignedUser = assignedUser;
        }

        public Task( string taskName, string taskDescription, DateTime deadline, int status, string projectID, string assignedUser)
        {
            this.taskID = Guid.NewGuid().ToString();
            DatabaseConnection dbConn = new DatabaseConnection();
            SqlConnection conn = dbConn.GetConnection();
            string query = "INSERT INTO Task (taskID, taskName, taskDescription, deadline, status, projectID, assignedUser) VALUES (@taskID, @taskName, @taskDescription, @deadline, @status, @projectID, @assignedUser)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@taskID", this.taskID);
            cmd.Parameters.AddWithValue("@taskName", taskName);
            cmd.Parameters.AddWithValue("@taskDescription", taskDescription);
            cmd.Parameters.AddWithValue("@deadline", deadline);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@projectID", projectID);
            cmd.Parameters.AddWithValue("@assignedUser", assignedUser);

            cmd.ExecuteNonQuery();
            conn.Close();


        }
    }
}
