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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace projektmanagementPL
{
    public partial class TaskComponent : UserControl
    {
        private projektmanagementBL.Task myTask { get; set; }
        private User loggedInUser;
        private Project project;
        public event EventHandler TaskSaved;

        public TaskComponent()
        {
            InitializeComponent();
        }

        public TaskComponent(projektmanagementBL.Task task, User loggedInUser, Project project)
        {
            InitializeComponent();
            this.myTask = task;
            this.loggedInUser = loggedInUser;
            this.project = project;
            createStandardLayout();
        }

        private void createStandardLayout()
        {
            if (tableLayoutPanelTask.ColumnCount != 5)
            {
                tableLayoutPanelTask.ColumnCount = 5;
                tableLayoutPanelTask.ColumnStyles.RemoveAt(6);
                tableLayoutPanelTask.ColumnStyles.RemoveAt(5);
            }

            tableLayoutPanelTask.ColumnStyles.Clear();
            tableLayoutPanelTask.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18F));
            tableLayoutPanelTask.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelTask.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanelTask.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tableLayoutPanelTask.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            Label taskName = new Label();
            taskName.Text = myTask.TaskName;
            taskName.AutoSize = true;
            taskName.Margin = Padding.Empty;
            Label deadline = new Label();
            deadline.Text = myTask.Deadline.ToString("dd.MM.yyyy");
            deadline.AutoSize = true;
            deadline.Margin = Padding.Empty;
            
            Label assignedUser = new Label();
            assignedUser.Text = myTask.getTaskAssignedUserName();
            assignedUser.AutoSize = true;
            assignedUser.Margin = Padding.Empty;
            Button details = new Button();
            details.Text = "Details";
            details.Click += new EventHandler(btnTaskDetails_Click);
            details.Margin = Padding.Empty;


            Button edit = new Button();
            edit.Click += new EventHandler(btnTaskEdit_Click);
            edit.Text = "Bearbeiten";
            edit.Margin = Padding.Empty;
            if(myTask.AssignedUser == loggedInUser.UserID || project.ProjectOwner == loggedInUser.UserID)
            {
                edit.Visible = true;
            }
            else
            {
                edit.Visible = false;
            }
            tableLayoutPanelTask.Controls.Clear();
            tableLayoutPanelTask.Controls.Add(taskName);
            tableLayoutPanelTask.Controls.Add(deadline);
            tableLayoutPanelTask.Controls.Add(assignedUser);
            tableLayoutPanelTask.Controls.Add(details);
            tableLayoutPanelTask.Controls.Add(edit); 
        }

        private void createDetailLayout()
        {
            tableLayoutPanelTask.ColumnStyles.Clear();
            tableLayoutPanelTask.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanelTask.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelTask.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));
            tableLayoutPanelTask.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));
            tableLayoutPanelTask.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));

            tableLayoutPanelTask.RowCount = 1;
            tableLayoutPanelTask.ColumnCount = 7;
            tableLayoutPanelTask.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tableLayoutPanelTask.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            Label taskName = new Label();
            taskName.Text = myTask.TaskName;
            taskName.AutoSize = true;
            taskName.Margin = Padding.Empty;
            RichTextBox taskDescription = new RichTextBox();
            taskDescription.Width = 200;
            //taskDescription.Enabled = false;
            taskDescription.Text = myTask.TaskDescription;
            taskDescription.AutoSize = true;
            taskDescription.Margin = Padding.Empty;
            Label deadline = new Label();
            deadline.Text = myTask.Deadline.ToString("dd.MM.yyyy");
            deadline.AutoSize = true;
            deadline.Margin = Padding.Empty;
            Label assignedUser = new Label();
            assignedUser.Text = myTask.getTaskAssignedUserName();
            assignedUser.AutoSize = true;
            assignedUser.Margin = Padding.Empty;
            Label status = new Label();
            //status.Text = myTask.Status.ToString();
            status.Text = "------";
            status.ForeColor = getColorFromStatus(myTask.Status);
            status.BackColor = getColorFromStatus(myTask.Status);
            
            status.AutoSize = true;
            status.Margin = Padding.Empty;
            Button standard = new Button();
            standard.Text = "weniger anzeigen";
            standard.Margin = Padding.Empty;
            standard.Click += new EventHandler(btnStandardLayout_Click);
            Button edit = new Button();
            edit.Click += new EventHandler(btnTaskEdit_Click);
            edit.Text = "Bearbeiten";
            edit.Margin = Padding.Empty;
            if (myTask.AssignedUser == loggedInUser.UserID || project.ProjectOwner == loggedInUser.UserID)
            {
                edit.Visible = true;
            }
            else
            {
                edit.Visible = false;
            }
            tableLayoutPanelTask.Controls.Clear();
            tableLayoutPanelTask.Controls.Add(taskName);
            tableLayoutPanelTask.Controls.Add(taskDescription);
            tableLayoutPanelTask.Controls.Add(deadline);
            tableLayoutPanelTask.Controls.Add(assignedUser);
            tableLayoutPanelTask.Controls.Add(status);
            tableLayoutPanelTask.Controls.Add(standard);
            tableLayoutPanelTask.Controls.Add(edit);

        }

        private void createEditLayout()
        {   
            
            tableLayoutPanelTask.ColumnStyles.Clear();
            tableLayoutPanelTask.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanelTask.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanelTask.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));
            tableLayoutPanelTask.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));
            tableLayoutPanelTask.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 7F));

            tableLayoutPanelTask.RowCount = 2;
            tableLayoutPanelTask.ColumnCount = 8;
            tableLayoutPanelTask.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tableLayoutPanelTask.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tableLayoutPanelTask.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            TextBox taskName = new TextBox();
            taskName.Name = "tbTaskName";
            taskName.Text = myTask.TaskName;
            taskName.Dock = DockStyle.Fill;
            taskName.AutoSize = true;
            taskName.Margin = Padding.Empty;
            TextBox taskDescription = new TextBox();
            taskDescription.Name = "tbDescription";
            taskDescription.Text = myTask.TaskDescription;
            taskDescription.Dock = DockStyle.Fill;
            taskDescription.AutoSize = true;
            taskDescription.Margin = Padding.Empty;
            TextBox deadline = new TextBox();
            deadline.Name = "tbDeadline";
            deadline.Text = myTask.Deadline.ToString("dd.MM.yyyy");
            deadline.AutoSize = true;
            deadline.Margin = Padding.Empty;
            TextBox assignedUser = new TextBox();
            assignedUser.Name = "tbAssignedUser";
            assignedUser.Text = myTask.getTaskAssignedUserName();
            assignedUser.AutoSize = true;
            assignedUser.Margin = Padding.Empty;
            TextBox status = new TextBox();
            status.Name = "tbStatus";
            status.Text = myTask.Status.ToString();
            status.AutoSize = true;
            status.Margin = Padding.Empty;
            Button cancel = new Button();
            cancel.Text = "abbrechen";
            cancel.Margin = Padding.Empty;
            cancel.Click += new EventHandler(btnStandardLayout_Click);
            Button save = new Button();
            save.Click += new EventHandler(btnTaskSave_Click);
            save.Text = "speichern";
            save.Margin = Padding.Empty;

            Button delete = new Button();
            delete.Text = "löschen";
            delete.Margin = Padding.Empty;
            delete.Click += new EventHandler(btnTaskDelete_Click);

            if (project.ProjectOwner != loggedInUser.UserID)
            {
                taskName.ReadOnly = true;
                taskDescription.ReadOnly = true;
                deadline.ReadOnly = true;
                assignedUser.ReadOnly = true;
            }

            tableLayoutPanelTask.Controls.Clear();
            tableLayoutPanelTask.Controls.Add(taskName);        
            tableLayoutPanelTask.Controls.Add(taskDescription);
            tableLayoutPanelTask.Controls.Add(deadline);
            tableLayoutPanelTask.Controls.Add(assignedUser);
            tableLayoutPanelTask.Controls.Add(status);
            tableLayoutPanelTask.Controls.Add(cancel);
            tableLayoutPanelTask.Controls.Add(save);
            tableLayoutPanelTask.Controls.Add(delete);
        }

        private void btnTaskDetails_Click(object sender, EventArgs e)
        {   
            Console.WriteLine("Details Button Clicked");
            createDetailLayout();
        }

        private void btnStandardLayout_Click(object sender, EventArgs e)
        {   
            Console.WriteLine("Standard Button Clicked");
            createStandardLayout();
        }

        private void btnTaskEdit_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Edit Button Clicked");

            tableLayoutPanelTask.Controls.Clear();
            createEditLayout();
        }

        private void btnTaskSave_Click(object sender, EventArgs e)
        {
            OrganizerPro organizerPro = new OrganizerPro();
            string taskName = tableLayoutPanelTask.Controls.Find("tbTaskName", true).FirstOrDefault().Text;
            string taskDescription = tableLayoutPanelTask.Controls.Find("tbDescription", true).FirstOrDefault().Text;
            DateTime deadline = Convert.ToDateTime(tableLayoutPanelTask.Controls.Find("tbDeadline", true).FirstOrDefault().Text);
            int status = Convert.ToInt32(tableLayoutPanelTask.Controls.Find("tbStatus", true).FirstOrDefault().Text);
            string[] parts=tableLayoutPanelTask.Controls.Find("tbAssignedUser", true).FirstOrDefault().Text.Split(new[] { ' ' }, 2);
            String surname = "";
            if (parts.Length > 1)
                surname = parts[1];
            else
                surname = parts[0];

            string assignedUser = organizerPro.getUserID(surname);
            if(myTask.AssignedUser == loggedInUser.UserID)
            {
                organizerPro.enterTaskProgress(myTask.TaskID, status);
            } else
            {
                organizerPro.editTask(myTask.TaskID, taskName, taskDescription, deadline, status, assignedUser);
            }
            TaskSaved?.Invoke(this, EventArgs.Empty);
            createStandardLayout();
        }

        private Color getColorFromStatus(int status)
        {
            switch (status)
            {
                case 0:
                    return Color.Red;
                case 1:
                    return Color.Yellow;
                case 2:
                    return Color.Green;
                default:
                    return Color.Black;
            }
        }

        private void btnTaskDelete_Click(object sender, EventArgs e)
        {
            OrganizerPro organizerPro = new OrganizerPro();
            organizerPro.deleteTask(myTask.TaskID);
            TaskSaved?.Invoke(this, EventArgs.Empty);  
            
        }
    }
}