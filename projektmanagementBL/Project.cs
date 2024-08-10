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
        public string ProjectID
        {
            get { return projectID; }
            internal set { projectID = value; }
        }

        private string projectName { get; set; }
        public string ProjectName
        {
            get { return projectName; }
            internal set { projectName = value; }
        }

        private DateTime projectStart { get; set; }
        public DateTime ProjectStart
        {
            get { return projectStart; }
            internal set { projectStart = value; }
        }

        private DateTime projectEnd { get; set; }
        public DateTime ProjectEnd
        {
            get { return projectEnd; }
            internal set { projectEnd = value; }
        }

        private string projectDescription { get; set; }
        public string ProjectDescription
        {
            get { return projectDescription; }
            internal set { projectDescription = value; }
        }

        private string projectOwner { get; set; }
        public string ProjectOwner
        {
            get { return projectOwner; }
            internal set { projectOwner = value; }
        }

        private List<Task> tasks { get; set; } = new List<Task>();
        public List<Task> Tasks
        {
            get { return tasks; }
            internal set { tasks = value; }
        }

        internal Project(){}

        public Project(string projectID, string projectName, DateTime projectStart, DateTime projectEnd, string projectDescription, string projectOwner)
        {
            this.projectID = projectID;
            this.projectName = projectName;
            this.projectStart = projectStart;
            this.projectEnd = projectEnd;
            this.projectDescription = projectDescription;
            this.projectOwner = projectOwner;
        }


        public void getAllTasks()
        {
            OrganizerPro organizerPro = new OrganizerPro();
            SqlConnection conn = organizerPro.GetConnection();
            string query = "SELECT * FROM Task WHERE projectID = @projectID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@projectID", projectID);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Task task = new Task(reader["taskID"].ToString(), reader["taskName"].ToString(), reader["taskDescription"].ToString(), Convert.ToDateTime(reader["deadline"]), Convert.ToInt32(reader["status"]), reader["projectID"].ToString(), reader["assignedUser"].ToString());
                tasks.Add(task);
            }
            conn.Close();
        }



        public string getProjectOwnerName()
        {
            OrganizerPro organizerPro = new OrganizerPro();
            SqlConnection conn = organizerPro.GetConnection();
            string query = "SELECT * FROM [User] WHERE userID = @userID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@userID", projectOwner);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string ownerName = reader["name"].ToString() + " " + reader["surname"].ToString();
            conn.Close();
            return ownerName;
        }



    }
}
