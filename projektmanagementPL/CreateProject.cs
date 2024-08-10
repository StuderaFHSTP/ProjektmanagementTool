﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using projektmanagementBL;

namespace projektmanagementPL
{
    public partial class CreateProject : Form
    {
        private User loggedInUser;
        public CreateProject(User loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
        }

        private void btnProjectErstellen_Click(object sender, EventArgs e)
        {
            //get all the data from the form
            string projectName = txtProjectName.Text;
            DateTime projectStart = dateStart.Value;
            DateTime projectEnd = dateEnd.Value;
            string projectDescription = txtProjectBeschreibung.Text;

            //TODO ProjectOwnerID aus der Session holen
            OrganizerPro organizerPro = new OrganizerPro();
            organizerPro.createProject(projectName, projectStart, projectEnd, projectDescription, loggedInUser.UserID);

            //Ändern auf die detail seite des Projekts
            this.Hide();
            ProjectOverview projectOverview = new ProjectOverview(loggedInUser);
            projectOverview.ShowDialog();
            this.Close();
            
        }

        private void CreateProject_Load(object sender, EventArgs e)
        {

        }
    }
}
