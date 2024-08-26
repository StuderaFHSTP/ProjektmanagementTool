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
    public partial class CreateTask : Form
    {
        private User loggedInUser;
        private string projectID;
        public CreateTask(string projectID, User loggedInUser)
        {
            InitializeComponent();
            this.projectID = projectID;
            this.loggedInUser = loggedInUser;
        }

        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            string taskName = txtTaskName.Text;
            string taskDescription = txtTaskDescription.Text;
            DateTime deadline = datePickerDeadline.Value;
            string assignedUser = txtAssignedUser.Text;

            OrganizerPro organizerPro = new OrganizerPro();
            organizerPro.createTask(taskName, taskDescription, deadline, 0, projectID, organizerPro.getUserID(assignedUser));

            this.Hide();
            ProjectDetails projectDetails = new ProjectDetails(projectID, loggedInUser);
            projectDetails.ShowDialog();
            this.Close();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProjectDetails projectDetails = new ProjectDetails(projectID, loggedInUser);
            projectDetails.ShowDialog();
            this.Close();
        }
    }
}