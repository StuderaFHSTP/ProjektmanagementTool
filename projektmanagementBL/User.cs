using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektmanagementBL
{
    internal class User
    {
        private String userID { get; set; }
        private String name { get; set; }
        private String surname { get; set; }
        private String email { get; set; }
        private String role { get; set; }
        private String department { get; set; }
        private String projectID { get; set; }

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
