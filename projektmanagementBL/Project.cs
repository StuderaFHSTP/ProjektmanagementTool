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
