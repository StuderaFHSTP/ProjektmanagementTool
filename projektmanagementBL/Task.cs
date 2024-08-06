﻿using System;
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
            internal set { taskID = value; }
        }
        private string taskName { get; set; }
        public string TaskName
        {
            get { return taskName; }
            internal set { taskName = value; }
        }
        private string taskDescription { get; set; }
        public string TaskDescription
        {
            get { return taskDescription; }
            internal set { taskDescription = value; }
        }
        private DateTime deadline { get; set; }
        public DateTime Deadline
        {
            get { return deadline; }
            internal set { deadline = value; }
        }
        private int status { get; set; }
        public int Status
        {
            get { return status; }
            internal set { status = value; }
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
            internal set { assignedUser = value; }
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
    }
}
