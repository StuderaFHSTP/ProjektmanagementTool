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
        internal string projectID { get; set; }
        internal string projectName { get; set; }
        internal DateTime projectStart { get; set; }
        internal DateTime projectEnd { get; set; }
        internal string projectDescription { get; set; }
        internal string projectOwner { get; set; }

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
