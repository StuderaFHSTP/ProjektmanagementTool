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
                /*Label taskName = new Label();
                taskName.Text = task.TaskName;
                taskName.AutoSize = true;
                taskName.Margin = Padding.Empty;
                Label deadline = new Label();
                deadline.Text = task.Deadline.ToString("dd.MM.yyyy");
                deadline.AutoSize = true;
                deadline.Margin = Padding.Empty;
                Label assignedUser = new Label();
                assignedUser.Text = task.getTaskAssignedUserName();
                assignedUser.AutoSize = true;
                assignedUser.Margin = Padding.Empty;
                Button details = new Button();
                details.Text = "Details";
                details.Margin = Padding.Empty;
                Button edit = new Button();
                edit.Text = "Bearbeiten";
                edit.Margin = Padding.Empty;
                if (project.ProjectOwner == loggedInUser.UserID)
                {
                    edit.Visible = true;
                    tableLayoutProjectDetails.ColumnCount = 5;
                } else {
                    edit.Visible = false;
                }
                tableLayoutProjectDetails.Controls.Add(taskName);
                tableLayoutProjectDetails.Controls.Add(deadline);
                tableLayoutProjectDetails.Controls.Add(assignedUser);
                tableLayoutProjectDetails.Controls.Add(details);
                tableLayoutProjectDetails.Controls.Add(edit);*/
            }
            //TODO: Task details anzeigen
            //TODO: Task editieren
            
            
        }

        private void TaskComponent_TaskSaved(object sender, EventArgs e)
        {
            // Laden Sie die ProjectDetails-Seite neu
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
