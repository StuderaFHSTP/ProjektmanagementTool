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
    }
}
