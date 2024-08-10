using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektmanagementBL
{
    public class User
    {
        private string userID { get; set; }
        public string UserID
        {
            get { return userID; }
            internal set { userID = value; }
        }
        private string name { get; set; }
        public string Name
        {
            get { return name; }
            internal set { name = value; }
        }
        private string surname { get; set; }
        public string Surname
        {
            get { return surname; }
            internal set { surname = value; }
        }
        private string email { get; set; }
        public string Email
        {
            get { return email; }
            internal set { email = value; }
        }
        private string role { get; set; }
        public string Role
        {
            get { return role; }
            internal set { role = value; }
        }
        private string department { get; set; }
        public string Department
        {
            get { return department; }
            internal set { department = value; }
        }
        private string projectID { get; set; }
        public string ProjectID
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
