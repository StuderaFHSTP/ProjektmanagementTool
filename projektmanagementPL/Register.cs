using projektmanagementBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektmanagementPL
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string email = txtEmail.Text;
            string password = txtPasswort.Text;
            String department = ddAbteilung.Text;
            String role = ddRolle.Text;
            
            OrganizerPro organizerPro = new OrganizerPro();

            bool createdUser=organizerPro.newUser(name, surname, email, password, role, department);

            if(createdUser)
            {
                User user = organizerPro.login(email, password);
                this.Hide();
                ProjectOverview projectOverview = new ProjectOverview(user);
                projectOverview.ShowDialog();
                this.Close();
            }else
            {
                lblError.Visible= true;
            }
            
        }
    }
}