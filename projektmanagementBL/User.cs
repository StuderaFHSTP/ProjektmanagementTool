using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektmanagementBL
{
    public class User
    {
        private String userID { get; set; }
        public string UserID
        {
            get { return userID; }
            internal set { userID = value; }
        }
        private String name { get; set; }
        public String Name
        {
            get { return name; }
            internal set { name = value; }
        }
        private String surname { get; set; }
        public String Surname
        {
            get { return surname; }
            internal set { surname = value; }
        }
        private String email { get; set; }
        public String Email
        {
            get { return email; }
            internal set { email = value; }
        }
        private String role { get; set; }
        public String Role
        {
            get { return role; }
            internal set { role = value; }
        }
        private String department { get; set; }
        public String Department
        {
            get { return department; }
            internal set { department = value; }
        }
        private String projectID { get; set; }
        public String ProjectID
        {
            get { return projectID; }
            internal set { projectID = value; }
        }

        internal User() { }

        public User(String userID, String name, String surname, String email, String role, String department, String projectID)
        {
            this.userID = userID;
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.role = role;
            this.department = department;
            this.projectID = projectID;
        }



    }
}
