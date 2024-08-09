using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace projektmanagementBL
{
    public class OrganizerPro
    {
        //Connection String muss geändert werden abhängig von wer die Datenbank lokal speichert
        //private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\fabia\\FH\\Software Architecture\\Projekt\\projektmanagementDL\\projektmanagementDB.mdf\";Integrated Security=True;Connect Timeout=5";
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Dokumente\\FH STP\\4. Semester\\Software Architektur\\Projekte\\ProjektmanagementTool\\projektmanagementDL\\projektmanagementDB.mdf\";Integrated Security=True;Connect Timeout=5";



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

        public User login(string email, string password)
        {
            SqlConnection conn = GetConnection();
            string query = "SELECT * FROM [User] WHERE email = @email AND password = @password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = cmd.ExecuteReader();
            try { 
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        return new User(reader["userID"].ToString(), reader["name"].ToString(), reader["surname"].ToString(), reader["email"].ToString(), reader["role"].ToString(), reader["department"].ToString(), reader["projectID"].ToString());
                    }
                    return null;
                }else
                {
                    return null;
                }
            }finally
            {
                conn.Close();
            }
            //Diese Methode hat bei mir einen Fehler passt es trotzdem?
        }

        public void goToRegister()
        {
            //TODO: Ansicht für Registrierung
        }

        public bool newUser(String name, String surname, String email, String password, String role, String deparment)
        {
            string userID = Guid.NewGuid().ToString("N").Substring(0, 30);
            try
            {
                SqlConnection conn = GetConnection();
                string query = "INSERT INTO [User] (userID, name, surname, email, password, role, department) VALUES (@userID, @name, @surname, @email, @password, @role, @department)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userID", userID);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@surname", surname);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@department", deparment);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            
        }

        public void createTask(string taskName, string taskDescription, DateTime deadline, int status, string projectID, string assignedUser)
        {
            //TODO: UserID und ProjectID müssen noch dynamisch generiert werden
            Task task = new Task("10", taskName, taskDescription, deadline, status, projectID, assignedUser);
            SqlConnection conn = GetConnection();
            string query = "INSERT INTO Task (taskID, taskName, taskDescription, deadline, status, projectID, assignedUser) VALUES (@taskID, @taskName, @taskDescription, @deadline, @status, @projectID, @assignedUser)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@taskID", task.TaskID);
            cmd.Parameters.AddWithValue("@taskName", task.TaskName);
            cmd.Parameters.AddWithValue("@taskDescription", task.TaskDescription);
            cmd.Parameters.AddWithValue("@deadline", task.Deadline);
            cmd.Parameters.AddWithValue("@status", task.Status);
            cmd.Parameters.AddWithValue("@projectID", task.ProjectID);
            cmd.Parameters.AddWithValue("@assignedUser", task.AssignedUser);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void showTaskDetails(string taskID)
        {

            SqlConnection conn = GetConnection();
            string query = "SELECT * FROM Task WHERE taskID = @taskID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@taskID", taskID);
            SqlDataReader reader = cmd.ExecuteReader();
            //TODO : Ansicht für Task Details
        }

        public void enterTaskProgress(string taskID, int status)
        {

            SqlConnection conn = GetConnection();
            string query = "UPDATE Task SET status = @status WHERE taskID = @taskID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@taskID", taskID);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void editTask(string taskID, string taskName, string taskDescription, DateTime deadline, int status, string assignedUser)
        {
            SqlConnection conn = GetConnection();
            string query = "UPDATE Task SET taskName = @taskName, taskDescription = @taskDescription, deadline = @deadline, status = @status, assignedUser = @assignedUser WHERE taskID = @taskID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@taskID", taskID);
            cmd.Parameters.AddWithValue("@taskName", taskName);
            cmd.Parameters.AddWithValue("@taskDescription", taskDescription);
            cmd.Parameters.AddWithValue("@deadline", deadline);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@assignedUser", assignedUser);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void newProject() { 
            //TODO: Ansicht für erstellen eines neuen Projekts
        }

        public void createProject(string projectName, DateTime projectStart, DateTime projectEnd, string projectDescription, string projectOwner)
        {
            //TODO: UserID müssen noch dynamisch generiert werden
            string projectID = Guid.NewGuid().ToString("N").Substring(0,30);
            Project project = new Project(projectID,projectName, projectStart, projectEnd, projectDescription, projectOwner);
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

        public void editProject(string projectID, string projectName, DateTime projectStart, DateTime projectEnd, string projectDescription)
        {
            SqlConnection conn = GetConnection();
            string query = "UPDATE Project SET projectName = @projectName, projectStart = @projectStart, projectEnd = @projectEnd, projectDescription = @projectDescription WHERE projectID = @projectID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@projectID", projectID);
            cmd.Parameters.AddWithValue("@projectName", projectName);
            cmd.Parameters.AddWithValue("@projectStart", projectStart);
            cmd.Parameters.AddWithValue("@projectEnd", projectEnd);
            cmd.Parameters.AddWithValue("@projectDescription", projectDescription);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


    }
}
