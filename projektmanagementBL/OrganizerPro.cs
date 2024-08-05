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
            Project project = new Project("1",projectName, projectStart, projectEnd, projectDescription, projectOwner);
            SqlConnection conn = GetConnection();
            string query = "INSERT INTO Project (projectID, projectName, projectStart, projectEnd, projectDescription, projectOwner) VALUES (@projectID, @projectName, @projectStart, @projectEnd, @projectDescription, @projectOwner)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@projectID", project.projectID);
            cmd.Parameters.AddWithValue("@projectName", project.projectName);
            cmd.Parameters.AddWithValue("@projectStart", project.projectStart);
            cmd.Parameters.AddWithValue("@projectEnd", project.projectEnd);
            cmd.Parameters.AddWithValue("@projectDescription", project.projectDescription);
            cmd.Parameters.AddWithValue("@projectOwner", project.projectOwner);
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
                project.projectID = reader["projectID"].ToString();
                project.projectName = reader["projectName"].ToString();
                project.projectStart = Convert.ToDateTime(reader["projectStart"]);
                project.projectEnd = Convert.ToDateTime(reader["projectEnd"]);
                project.projectDescription = reader["projectDescription"].ToString();
                project.projectOwner = reader["projectOwner"].ToString();
            }
            conn.Close();
            return project;
        }

        public Project[] viewProjects()
        {
            return null;
        }

        public void editProject(string projectID, string projectName, DateTime projectStart, DateTime projectEnd, string projectDescription, string projectOwner)
        {

        }


    }
}
