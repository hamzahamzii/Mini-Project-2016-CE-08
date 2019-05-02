using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class AddProject : Form
    {
        public int flag = 0;
        public int incomingId;
        public String conURL = "Data Source=ROHIT-MEHRA;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=secretpassword";
        public AddProject()
        {
            InitializeComponent();
            incomingId = -1;
        }

        public AddProject(int id)
        {
            InitializeComponent();
            flag = 1;
            incomingId = id;
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            String getvaluescmd = String.Format("SELECT * FROM Project WHERE Id = {0}", id);
            SqlCommand getvaluesCommand = new SqlCommand(getvaluescmd, conn);
            SqlDataReader reader = getvaluesCommand.ExecuteReader();
            while (reader.Read())
            {
                ProjectDescriptionRichTextBox.Text = reader[1].ToString();
                ProjectTitleTextBox.Text = reader[2].ToString();
                Title.Text = "Update Project";
            }
        }

        public bool ValidateEntries()
        {
            bool valid = true;
            //Title
            if (String.IsNullOrEmpty(ProjectDescriptionRichTextBox.Text))
            {
                epTitle.SetError(ProjectTitleTextBox, "Please give Title !");
                valid = false;
            }
            else
            {
                epTitle.SetError(ProjectTitleTextBox, null);
            }

            return valid;
        }

        private void AddProject_Load(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Projects form = new Projects();
            form.Show();
            this.Hide();
        }

        private void AddStudentSaveBtn_Click(object sender, EventArgs e)
        {
            if(ValidateEntries())
            {
                if (flag == 0)
                {
                    SqlConnection conn = new SqlConnection(conURL);
                    conn.Open();
                    String AddProjectCMD = "INSERT INTO Project (Description, Title) VALUES (@description, @title)";
                    SqlCommand AddProjectCommand = new SqlCommand(AddProjectCMD, conn);
                    AddProjectCommand.Parameters.Add(new SqlParameter("description", ProjectDescriptionRichTextBox.Text));
                    AddProjectCommand.Parameters.Add(new SqlParameter("title", ProjectTitleTextBox.Text));
                    int count = AddProjectCommand.ExecuteNonQuery();
                    Projects form = new Projects();
                    form.Show();
                    this.Hide();
                }
                if (flag == 1)
                {
                    SqlConnection conn = new SqlConnection(conURL);
                    conn.Open();
                    String UpdateProjectCMD = "UPDATE Project SET Description = @description, Title = @title WHERE Id = @id";
                    SqlCommand UpdateProjectCommand = new SqlCommand(UpdateProjectCMD, conn);
                    UpdateProjectCommand.Parameters.Add(new SqlParameter("description", ProjectDescriptionRichTextBox.Text));
                    UpdateProjectCommand.Parameters.Add(new SqlParameter("title", ProjectTitleTextBox.Text));
                    UpdateProjectCommand.Parameters.Add(new SqlParameter("id", incomingId));

                    int count = UpdateProjectCommand.ExecuteNonQuery();

                    Projects form = new Projects();
                    form.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid Input");
            }
        }
    }
}
