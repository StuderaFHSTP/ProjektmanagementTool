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
    public partial class ProjectOverview : Form
    {
        public ProjectOverview()
        {
            InitializeComponent();
        }

        private void ProjectOverview_Load(object sender, EventArgs e)
        {
            OrganizerPro organizerPro = new OrganizerPro();
            Project[] projects = organizerPro.viewProjects();

            foreach (Project project in projects)
            {
                Label lblProjectName = new Label();
                lblProjectName.Text = project.ProjectName;
                lblProjectName.AutoSize = true;
                lblProjectName.Margin = Padding.Empty; // Entfernt den Abstand

                Button btnDetails = new Button();
                btnDetails.Text = "Details";
                btnDetails.Margin = Padding.Empty; // Entfernt den Abstand

                tableLayoutProjectOverview.Controls.Add(lblProjectName);
                tableLayoutProjectOverview.Controls.Add(btnDetails);
            }

        }

        private void btnProjectOverviewCreate_Click(object sender, EventArgs e)
        {
            //close this window and open create project window
            this.Hide();
            CreateProject createProject = new CreateProject();
            createProject.ShowDialog();
            this.Close();
        }
    }
}
