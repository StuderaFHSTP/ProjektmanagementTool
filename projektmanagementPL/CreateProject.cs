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
    public partial class CreateProject : Form
    {
        public CreateProject()
        {
            InitializeComponent();
        }

        private void btnProjectErstellen_Click(object sender, EventArgs e)
        {
            //get all the data from the form
            string projectName = txtProjectName.Text;
            DateTime projectStart = dateStart.Value;
            DateTime projectEnd = dateEnd.Value;
            string projectDescription = txtProjectBeschreibung.Text;

            //create a new project
            OrganizerPro organizerPro = new OrganizerPro();
            organizerPro.createProject(projectName, projectStart, projectEnd, projectDescription, "1");
            
        }
    }
}
