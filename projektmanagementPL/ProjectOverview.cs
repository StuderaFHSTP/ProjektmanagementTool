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
        public ProjectOverview()
        {
            InitializeComponent();
        }

        private void ProjectOverview_Load(object sender, EventArgs e)
        {
            OrganizerPro organizerPro = new OrganizerPro();
            Project[] projects = organizerPro.viewProjects();
            //show the project name for every project in the list
            foreach (Project project in projects)
            {
                ListViewItem item = new ListViewItem(project.ProjectName);
                listViewProjectOverview.Items.Add(item);
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
