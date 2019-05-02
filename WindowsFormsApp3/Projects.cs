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
    public partial class Projects : Form
    {
        public String conURL = "Data Source=ROHIT-MEHRA;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=secretpassword";
        public Projects()
        {
            InitializeComponent();

            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Project", conn);
            adapt.Fill(dt);
            ProjectsGridView.DataSource = dt;

            DataGridViewButtonColumn addbtn = new DataGridViewButtonColumn();
            addbtn.HeaderText = "Add Project Advisor";
            addbtn.Text = "Add Advisor";
            addbtn.UseColumnTextForButtonValue = true;
            addbtn.Width = 80;
            ProjectsGridView.Columns.Add(addbtn);
            for (int i = 0; i < ProjectsGridView.Rows.Count; i++)
            {
                ProjectsGridView.Rows[i].Cells[0].ReadOnly = true;
            }

            DataGridViewButtonColumn viewbtn = new DataGridViewButtonColumn();
            viewbtn.HeaderText = "View Project Advisor";
            viewbtn.Text = "View Advisors";
            viewbtn.UseColumnTextForButtonValue = true;
            viewbtn.Width = 80;
            ProjectsGridView.Columns.Add(viewbtn);
            for (int i = 0; i < ProjectsGridView.Rows.Count; i++)
            {
                ProjectsGridView.Rows[i].Cells[0].ReadOnly = true;
            }

            ProjectsGridView.Columns["Id"].Visible = false;
        }

        private void Projects_Load(object sender, EventArgs e)
        {
            
        }

        private void ProjectsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int currentRow = int.Parse(e.RowIndex.ToString());
            int curentcolumnindex = int.Parse(e.ColumnIndex.ToString());
            int ProjectId = Convert.ToInt32(ProjectsGridView.Rows[currentRow].Cells[2].Value);
            if (curentcolumnindex == 0)
            {
                AddProjectAdvisor form = new AddProjectAdvisor(ProjectId);
                form.Show();
                this.Hide();
            }
             if (curentcolumnindex == 1)
             {
                 ViewProjectAdvisor form = new ViewProjectAdvisor(ProjectId);
                 form.Show();
                 this.Hide();
             }
        }

        private void AddProjectsBtn_Click(object sender, EventArgs e)
        {
            AddProject form = new AddProject();
            form.Show();
            this.Hide();
        }

        private void DeleteProjectBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();

            if (ProjectsGridView.SelectedCells.Count != 0)
            {
                int row = ProjectsGridView.SelectedCells[0].RowIndex;
                int id = Convert.ToInt32(ProjectsGridView.Rows[row].Cells[2].Value);


                String delStdCMD2 = String.Format("DELETE FROM ProjectAdvisor WHERE ProjectAdvisor.ProjectId = {0}", id);
                SqlCommand delStdCommand2 = new SqlCommand(delStdCMD2, conn);
                int count = delStdCommand2.ExecuteNonQuery();

                String delStdCMD1 = String.Format("DELETE FROM GroupProject WHERE GroupProject.ProjectId = {0}", id);
                SqlCommand delStdCommand1 = new SqlCommand(delStdCMD1, conn);
                count = delStdCommand1.ExecuteNonQuery();

                String delStdCMD = String.Format("DELETE FROM Project WHERE Id = {0}", id);
                SqlCommand delStdCommand = new SqlCommand(delStdCMD, conn);
                count = delStdCommand.ExecuteNonQuery();
                Projects form = new Projects();
                this.Hide();
                form.Show();
            }
        }

        private void UpdateProjectBtn_Click(object sender, EventArgs e)
        {
            if (ProjectsGridView.SelectedCells.Count != 0)
            {
                int row = ProjectsGridView.SelectedCells[0].RowIndex;
                int id = Convert.ToInt32(ProjectsGridView.Rows[row].Cells[0].Value);
                AddProject form = new AddProject(id);
                form.Show();
                this.Hide();
            }
        }

        private void BackProjectBtn_Click(object sender, EventArgs e)
        {
            MainPage form = new MainPage();
            form.Show();
            this.Hide();
        }
    }
}
