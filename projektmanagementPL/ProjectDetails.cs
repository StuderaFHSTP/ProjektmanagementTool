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
    public partial class ProjectDetails : Form
    {
        private string projectID;
        private User loggedInUser;
        public ProjectDetails(string projectID, User loggedInUser)
        {
            InitializeComponent();
            this.projectID = projectID;
            this.loggedInUser = loggedInUser;
        }

        private void ProjectDetails_Load(object sender, EventArgs e)
        {
            if(loggedInUser.Role != "Projektleiter")
            {
                btnProjectDetailsEdit.Visible = false;
            }
            OrganizerPro organizerPro = new OrganizerPro();
            Project project = organizerPro.selectProject(projectID);
            lblProjectName.Text = project.ProjectName;
            lblProjectDetailsStartTime.Text = project.ProjectStart.ToString("dd.MM.yyyy");
            lblProjectDetailEndTime.Text = project.ProjectEnd.ToString("dd.MM.yyyy");
            lblProjectDetailSetOwner.Text = project.getProjectOwnerName();
            txtProjectDetailsSetDescription.Text = project.ProjectDescription;
            //TODO: Tasks anzeigen

        }

        private void btnProjectDetailsEdit_Click(object sender, EventArgs e)
        {
            //TODO: Checken ob der User der Owner ist
            
            lblProjectName.Visible = false;
            txtEditprojectName.Visible = true;
            txtEditprojectName.Text = lblProjectName.Text;

            lblProjectDetailsStartTime.Visible = false;
            datePickerProjectStart.Visible = true;
            datePickerProjectStart.Value = DateTime.Parse(lblProjectDetailsStartTime.Text);

            lblProjectDetailEndTime.Visible = false;
            datePickerProjectEnd.Visible = true;
            datePickerProjectEnd.Value = DateTime.Parse(lblProjectDetailEndTime.Text);

            txtProjectDetailsSetDescription.ReadOnly = false;

            btnProjectDetailsEdit.Visible = false;
            btnProjectDetailSave.Visible = true;

        }

        private void btnProjectDetailSave_Click(object sender, EventArgs e)
        {
            OrganizerPro organizerPro = new OrganizerPro();
            organizerPro.editProject(projectID, txtEditprojectName.Text, datePickerProjectStart.Value, datePickerProjectEnd.Value, txtProjectDetailsSetDescription.Text);

            ProjectDetails_Load(sender, e);

            lblProjectName.Visible = true;
            txtEditprojectName.Visible = false;

            lblProjectDetailsStartTime.Visible = true;
            datePickerProjectStart.Visible = false;

            lblProjectDetailEndTime.Visible = true;
            datePickerProjectEnd.Visible = false;

            txtProjectDetailsSetDescription.ReadOnly = true;

            btnProjectDetailsEdit.Visible = false;
            btnProjectDetailSave.Visible = true;

            btnProjectDetailSave.Visible = false;
            btnProjectDetailsEdit.Visible = true;
        }
    }
}
