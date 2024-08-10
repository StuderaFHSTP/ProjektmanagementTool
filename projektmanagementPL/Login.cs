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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //get all the data from the form
            string email = txtLoginEmail.Text;
            string password = txtLoginPW.Text;

            //TODO ProjectOwnerID aus der Session holen
            OrganizerPro organizerPro = new OrganizerPro();
            User user=organizerPro.login(email,password);


            if(user!=null) {
                //Ändern auf die detail seite des Projekts
                this.Hide();
                ProjectOverview projectOverview = new ProjectOverview(user);
                projectOverview.ShowDialog();
                this.Close();

            }else
            {
                lblError.Visible= true;
            }
            
        }

        private void btnGoToRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
            this.Close();
        }
    }
}
