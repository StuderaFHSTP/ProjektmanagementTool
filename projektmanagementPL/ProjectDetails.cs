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
        private List<TaskComponent> taskComponentList = new List<TaskComponent>();
        public ProjectDetails(string projectID, User loggedInUser)
        {
            InitializeComponent();
            this.projectID = projectID;
            this.loggedInUser = loggedInUser;
        }

        private void ProjectDetails_Load(object sender, EventArgs e)
        {
            tableLayoutProjectDetails.Controls.Clear();

            OrganizerPro organizerPro = new OrganizerPro();
            Project project = organizerPro.selectProject(projectID);
            if(project.ProjectOwner != loggedInUser.UserID)
            {
                btnCreateTask.Visible = false;
                btnProjectDetailsEdit.Visible = false;
                btnCreateTask.Visible = false;
            }
            lblProjectName.Text = project.ProjectName;
            lblProjectDetailsStartTime.Text = project.ProjectStart.ToString("dd.MM.yyyy");
            lblProjectDetailEndTime.Text = project.ProjectEnd.ToString("dd.MM.yyyy");
            User projectOwner = organizerPro.getProjectOwner(projectID);
            lblProjectDetailSetOwner.Text = projectOwner.Name + " " + projectOwner.Surname;
            txtProjectDetailsSetDescription.Text = project.ProjectDescription;

            project.getAllTasks();
            foreach (projektmanagementBL.Task task in project.Tasks)
            {
                TaskComponent newTask = new TaskComponent(task, loggedInUser, project);
                newTask.TaskSaved += TaskComponent_TaskSaved;
                taskComponentList.Add(newTask);     
                tableLayoutProjectDetails.Controls.Add(newTask);
            }          
        }

        private void TaskComponent_TaskSaved(object sender, EventArgs e)
        {
            ProjectDetails_Load(sender, e);
        }

        private void btnProjectDetailsEdit_Click(object sender, EventArgs e)
        {
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
            btnCreateTask.Enabled = false;
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
            btnCreateTask.Enabled = true;
        }
        private void btnCreateTask_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateTask createTask = new CreateTask(projectID, loggedInUser);
            createTask.ShowDialog();
            this.Close();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProjectOverview projectOverview = new ProjectOverview(loggedInUser);
            projectOverview.ShowDialog();
            this.Close();
        }
    }
}