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

        internal Task[] tasks { get; set; }

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
            //Get Tasks from database - erst machen wenn Tasks erstellt werden können
        }



    }
}
