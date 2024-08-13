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
    public partial class TaskComponent : UserControl
    {
        private projektmanagementBL.Task myTask { get; set; }
        public TaskComponent()
        {
            InitializeComponent();
        }

        public TaskComponent(projektmanagementBL.Task task)
        {
            InitializeComponent();
            myTask = task;
            createStandardLayout();




        }

        private void createStandardLayout()
        {   
            if(tableLayoutPanelTask.ColumnCount != 5)
            {
                tableLayoutPanelTask.ColumnCount = 5;
                tableLayoutPanelTask.ColumnStyles.RemoveAt(6);
                tableLayoutPanelTask.ColumnStyles.RemoveAt(5);
            }
            Label taskName = new Label();
            taskName.Text = myTask.TaskName;
            //taskName.AutoSize = true;
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
            edit.Text = "bearbeiten";
            edit.Margin = Padding.Empty;
            /*
            if (project.ProjectOwner == loggedInUser.UserID)
            {
                edit.Visible = true;
                tableLayoutProjectDetails.ColumnCount = 5;
            }
            else
            {
                edit.Visible = false;
            }*/
            tableLayoutPanelTask.Controls.Clear();
            tableLayoutPanelTask.Controls.Add(taskName);
            tableLayoutPanelTask.Controls.Add(deadline);
            tableLayoutPanelTask.Controls.Add(assignedUser);
            tableLayoutPanelTask.Controls.Add(details);
            tableLayoutPanelTask.Controls.Add(edit); 
        }

        private void createDetailLayout()
        {
            
            tableLayoutPanelTask.RowCount = 1;
            //tableLayoutPanelTask.AutoSize = true;
            tableLayoutPanelTask.ColumnCount = 7;
            tableLayoutPanelTask.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tableLayoutPanelTask.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            Label taskName = new Label();
            taskName.Text = myTask.TaskName;
            taskName.AutoSize = true;
            taskName.Margin = Padding.Empty;
            Label taskDescription = new Label();
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
            status.Text = myTask.Status.ToString();
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
            /*
            if (project.ProjectOwner == loggedInUser.UserID)
            {
                edit.Visible = true;
                tableLayoutProjectDetails.ColumnCount = 5;
            }
            else
            {
                edit.Visible = false;
            }*/
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
            
            tableLayoutPanelTask.RowCount = 1;
            //tableLayoutPanelTask.AutoSize = true;
            tableLayoutPanelTask.ColumnCount = 7;
            tableLayoutPanelTask.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tableLayoutPanelTask.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            TextBox taskName = new TextBox();
            taskName.Name = "tbTaskName";
            taskName.Text = myTask.TaskName;
            taskName.AutoSize = true;
            taskName.Margin = Padding.Empty;
            TextBox taskDescription = new TextBox();
            taskDescription.Name = "tbDescription";
            taskDescription.Text = myTask.TaskDescription;
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
            /*
            if (project.ProjectOwner == loggedInUser.UserID)
            {
                edit.Visible = true;
                tableLayoutProjectDetails.ColumnCount = 5;
            }
            else
            {
                edit.Visible = false;
            }*/
            tableLayoutPanelTask.Controls.Clear();
            tableLayoutPanelTask.Controls.Add(taskName);
            tableLayoutPanelTask.Controls.Add(taskDescription);
            tableLayoutPanelTask.Controls.Add(deadline);
            tableLayoutPanelTask.Controls.Add(assignedUser);
            tableLayoutPanelTask.Controls.Add(status);
            tableLayoutPanelTask.Controls.Add(cancel);
            tableLayoutPanelTask.Controls.Add(save);
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
            myTask.TaskName = tableLayoutPanelTask.Controls.Find("tbTaskName", true).FirstOrDefault().Text;
            myTask.TaskDescription = tableLayoutPanelTask.Controls.Find("tbDescription", true).FirstOrDefault().Text;
            myTask.Deadline = Convert.ToDateTime(tableLayoutPanelTask.Controls.Find("tbDeadline", true).FirstOrDefault().Text);
            myTask.Status = Convert.ToInt32(tableLayoutPanelTask.Controls.Find("tbStatus", true).FirstOrDefault().Text);
            string[] parts=tableLayoutPanelTask.Controls.Find("tbAssignedUser", true).FirstOrDefault().Text.Split(new[] { ' ' }, 2);
            String surname = "";
            if (parts.Length > 1)
                surname = parts[1];
            else
                surname = parts[0];

            myTask.AssignedUser = organizerPro.getUserID(surname);
            organizerPro.editTask(myTask.TaskID, myTask.TaskName, myTask.TaskDescription, myTask.Deadline, myTask.Status, myTask.AssignedUser);
            createStandardLayout();
        }

    }
}
