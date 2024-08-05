using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace projektmanagementBL
{
    public class OrganizerPro
    {

        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\fabia\\FH\\Software Architecture\\Projekt\\projektmanagementDL\\projektmanagementDB.mdf\";Integrated Security=True;Connect Timeout=5";

        public SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return conn;
        }

        public void newProject() { 
            //TODO: Ansicht für erstellen eines neuen Projekts
        }

        public void createProject(string projectName, DateTime projectStart, DateTime projectEnd, string projectDescription, string projectOwner)
        {
            //TODO: UserID und ProjectID müssen noch dynamisch generiert werden
            Project project = new Project("4",projectName, projectStart, projectEnd, projectDescription, projectOwner);
            SqlConnection conn = GetConnection();
            string query = "INSERT INTO Project (projectID, projectName, projectStart, projectEnd, projectDescription, projectOwner) VALUES (@projectID, @projectName, @projectStart, @projectEnd, @projectDescription, @projectOwner)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@projectID", project.ProjectID);
            cmd.Parameters.AddWithValue("@projectName", project.ProjectName);
            cmd.Parameters.AddWithValue("@projectStart", project.ProjectStart);
            cmd.Parameters.AddWithValue("@projectEnd", project.ProjectEnd);
            cmd.Parameters.AddWithValue("@projectDescription", project.ProjectDescription);
            cmd.Parameters.AddWithValue("@projectOwner", project.ProjectOwner);
            cmd.ExecuteNonQuery();
            conn.Close();   

        }

        public Project selectProject(string projectID)
        {
            SqlConnection conn = GetConnection();
            string query = "SELECT * FROM Project WHERE projectID = @projectID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@projectID", projectID);
            SqlDataReader reader = cmd.ExecuteReader();
            Project project = new Project();
            while (reader.Read())
            {
                project.ProjectID = reader["projectID"].ToString();
                project.ProjectName = reader["projectName"].ToString();
                project.ProjectStart = Convert.ToDateTime(reader["projectStart"]);
                project.ProjectEnd = Convert.ToDateTime(reader["projectEnd"]);
                project.ProjectDescription = reader["projectDescription"].ToString();
                project.ProjectOwner = reader["projectOwner"].ToString();
            }
            conn.Close();
            return project;
        }

        public Project[] viewProjects()
        {
            //get every project from the database and safe in array
            SqlConnection conn = GetConnection();
            string query = "SELECT * FROM Project";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Project> projects = new List<Project>();
            while (reader.Read())
            {
                Project project = new Project();
                project.ProjectID = reader["projectID"].ToString();
                project.ProjectName = reader["projectName"].ToString();
                project.ProjectStart = Convert.ToDateTime(reader["projectStart"]);
                project.ProjectEnd = Convert.ToDateTime(reader["projectEnd"]);
                project.ProjectDescription = reader["projectDescription"].ToString();
                project.ProjectOwner = reader["projectOwner"].ToString();
                projects.Add(project);
            }
            conn.Close();
            return projects.ToArray();
        }

        public void editProject(string projectID, string projectName, DateTime projectStart, DateTime projectEnd, string projectDescription, string projectOwner)
        {

        }


    }
}
