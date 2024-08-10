using System;
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
        private User loggedInUser;
        public ProjectOverview(User loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
        }

        private void ProjectOverview_Load(object sender, EventArgs e)
        {
            if (loggedInUser.Role != "Projektleiter")
            {
                btnProjectOverviewCreate.Visible = false;
            }
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
                //button click open ProjectDetails window
                btnDetails.Click += (s, args) =>
                {
                    this.Hide();
                    ProjectDetails projectDetails = new ProjectDetails(project.ProjectID, loggedInUser);
                    projectDetails.ShowDialog();
                    this.Close();
                };

                tableLayoutProjectOverview.Controls.Add(lblProjectName);
                tableLayoutProjectOverview.Controls.Add(btnDetails);
            }

        }

        private void btnProjectOverviewCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateProject createProject = new CreateProject(loggedInUser);
            createProject.ShowDialog();
            this.Close();
        }
    }
}
