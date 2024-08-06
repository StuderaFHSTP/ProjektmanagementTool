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
        public ProjectDetails(string projectID)
        {
            InitializeComponent();
            this.projectID = projectID;
        }

        private void ProjectDetails_Load(object sender, EventArgs e)
        {
            OrganizerPro organizerPro = new OrganizerPro();
            Project project = organizerPro.selectProject(projectID);
            //output Project Name in new label
            lblProjectName.Text = project.ProjectName;

        }
    }
}
