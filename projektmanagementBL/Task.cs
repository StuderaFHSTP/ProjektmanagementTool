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
        public string TaskID
        {
            get { return taskID; }
            set { taskID = value; }
        }
        private string taskName { get; set; }
        public string TaskName
        {
            get { return taskName; }
            set { taskName = value; }
        }
        private string taskDescription { get; set; }
        public string TaskDescription
        {
            get { return taskDescription; }
            set { taskDescription = value; }
        }
        private DateTime deadline { get; set; }
        public DateTime Deadline
        {
            get { return deadline; }
            set { deadline = value; }
        }
        private int status { get; set; }
        public int Status
        {
            get { return status; }
            set { status = value; }
        }
        private string projectID { get; set; }
        public string ProjectID
        {
            get { return projectID; }
            internal set { projectID = value; }
        }
        private string assignedUser { get; set; }
        public string AssignedUser
        {
            get { return assignedUser; }
            set { assignedUser = value; }
        }

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

        public string getTaskAssignedUserName()
        {
            OrganizerPro organizerPro = new OrganizerPro();
            SqlConnection conn = organizerPro.GetConnection();
            string query = "SELECT * FROM [User] WHERE userID = @userID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@userID", assignedUser);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string assignedUserName = reader["name"].ToString() + " " +reader["surname"].ToString();
            conn.Close();
            return assignedUserName;
            
        }
    }
}
