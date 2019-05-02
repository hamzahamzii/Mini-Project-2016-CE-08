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
    public partial class GroupStudent : Form
    {
        public String conURL = "Data Source=ROHIT-MEHRA;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=secretpassword";
        public GroupStudent()
        {
            InitializeComponent();
        }

        private void GroupStudent_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM [Group]", conn);
                adapt.Fill(dt);
                StdGroupDataGridView.DataSource = dt;
                 

                DataGridViewButtonColumn addbtn = new DataGridViewButtonColumn();
                addbtn.HeaderText = "Add Students";
                addbtn.Text = "Add Students";
                addbtn.UseColumnTextForButtonValue = true;
                addbtn.Width = 80;
                StdGroupDataGridView.Columns.Add(addbtn);
                for(int i = 0; i < StdGroupDataGridView.Rows.Count; i++)
                {
                    StdGroupDataGridView.Rows[i].Cells[0].ReadOnly = true;

                }
                DataGridViewButtonColumn viewBtn = new DataGridViewButtonColumn();
                viewBtn.HeaderText = "View Students";
                viewBtn.Text = "View Students";
                viewBtn.UseColumnTextForButtonValue = true;
                viewBtn.Width = 80;
                StdGroupDataGridView.Columns.Add(viewBtn);
                for (int i = 0; i < StdGroupDataGridView.Rows.Count; i++)
                {
                    StdGroupDataGridView.Rows[i].Cells[0].ReadOnly = true;

                }

                DataGridViewButtonColumn AddEvalBtn = new DataGridViewButtonColumn();
                AddEvalBtn.HeaderText = "Add Evaluaton";
                AddEvalBtn.Text = "Add Evalutaion";
                AddEvalBtn.UseColumnTextForButtonValue = true;
                AddEvalBtn.Width = 80;
                StdGroupDataGridView.Columns.Add(AddEvalBtn);
                for (int i = 0; i < StdGroupDataGridView.Rows.Count; i++)
                {
                    StdGroupDataGridView.Rows[i].Cells[0].ReadOnly = true;
                }

                DataGridViewButtonColumn ViewEvalBtn = new DataGridViewButtonColumn();
                ViewEvalBtn.HeaderText = "View Evaluaton";
                ViewEvalBtn.Text = "View Evalutaion";
                ViewEvalBtn.UseColumnTextForButtonValue = true;
                ViewEvalBtn.Width = 80;
                StdGroupDataGridView.Columns.Add(ViewEvalBtn);
                for (int i = 0; i < StdGroupDataGridView.Rows.Count; i++)
                {
                    StdGroupDataGridView.Rows[i].Cells[0].ReadOnly = true;
                }

                DataGridViewButtonColumn AddProjectBtn = new DataGridViewButtonColumn();
                AddProjectBtn.HeaderText = "Add Project";
                AddProjectBtn.Text = "Add Project";
                AddProjectBtn.UseColumnTextForButtonValue = true;
                AddProjectBtn.Width = 80;
                StdGroupDataGridView.Columns.Add(AddProjectBtn);
                for (int i = 0; i < StdGroupDataGridView.Rows.Count; i++)
                {
                    StdGroupDataGridView.Rows[i].Cells[0].ReadOnly = true;
                }

                DataGridViewButtonColumn ViewProjectBtn = new DataGridViewButtonColumn();
                ViewProjectBtn.HeaderText = "View Project";
                ViewProjectBtn.Text = "View Project";
                ViewProjectBtn.UseColumnTextForButtonValue = true;
                ViewProjectBtn.Width = 80;
                StdGroupDataGridView.Columns.Add(ViewProjectBtn);
                for (int i = 0; i < StdGroupDataGridView.Rows.Count; i++)
                {
                    StdGroupDataGridView.Rows[i].Cells[0].ReadOnly = true;
                }

                DataGridViewButtonColumn DeleteBtn = new DataGridViewButtonColumn();
                DeleteBtn.HeaderText = "Delete Group";
                DeleteBtn.Text = "Delete";
                DeleteBtn.UseColumnTextForButtonValue = true;
                DeleteBtn.Width = 80;
                StdGroupDataGridView.Columns.Add(DeleteBtn);
                for (int i = 0; i < StdGroupDataGridView.Rows.Count; i++)
                {
                    StdGroupDataGridView.Rows[i].Cells[0].ReadOnly = true;

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void AddGroupBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            String AddGroupCMD = "INSERT INTO [Group] (Created_On) VALUES (@cdate)";
            SqlCommand AddGroupCommand = new SqlCommand(AddGroupCMD, conn);
            AddGroupCommand.Parameters.Add(new SqlParameter("cdate", DateTime.Today));
            int count = AddGroupCommand.ExecuteNonQuery();

            GroupStudent form = new GroupStudent();
            form.Show();
            this.Hide();
        }

        private void StdGroupDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = int.Parse(e.RowIndex.ToString());
            int curentcolumnindex = int.Parse(e.ColumnIndex.ToString());
            string gid = StdGroupDataGridView.Rows[currentRow].Cells[0].Value.ToString();
            if(curentcolumnindex == 2)
            {
                AddStudentGroup form = new AddStudentGroup(Convert.ToInt32(gid));
                form.Show();
                this.Hide();
            }
            if (curentcolumnindex == 3)
            {
                ViewGroupStudents form = new ViewGroupStudents(Convert.ToInt32(gid));
                form.Show();
                this.Hide();
            }
            if (curentcolumnindex == 4)
            {
                AddEvaluationGroup form = new AddEvaluationGroup(Convert.ToInt32(gid));
                form.Show();
                this.Hide();
            }
            if (curentcolumnindex == 5)
            {
                ViewGroupEvaluation form = new ViewGroupEvaluation(Convert.ToInt32(gid));
                form.Show();
                this.Hide();
            }
            if (curentcolumnindex == 6)
            {
                AddGroupProject form = new AddGroupProject(Convert.ToInt32(gid));
                form.Show();
                this.Hide();
            }
            if (curentcolumnindex == 7)
            {
                ViewGroupProject form = new ViewGroupProject(Convert.ToInt32(gid));
                form.Show();
                this.Hide();
            }

            if (curentcolumnindex == 8)
            {
                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();
                String DeleteCMD = "DELETE FROM GroupStudent WHERE GroupStudent.GroupId = @id";
                SqlCommand DeleteCommand = new SqlCommand(DeleteCMD, conn);
                DeleteCommand.Parameters.Add(new SqlParameter("id", Convert.ToInt32(gid)));
                int count = DeleteCommand.ExecuteNonQuery();

                String DeleteCMD2 = "DELETE FROM GroupEvaluation WHERE GroupEvaluation.GroupId = @id";
                SqlCommand DeleteCommand2 = new SqlCommand(DeleteCMD2, conn);
                DeleteCommand2.Parameters.Add(new SqlParameter("id", Convert.ToInt32(gid)));
                count = DeleteCommand2.ExecuteNonQuery();
                 
                String DeleteCMD3 = "DELETE FROM GroupProject WHERE GroupProject.GroupId = @id";
                SqlCommand DeleteCommand3 = new SqlCommand(DeleteCMD3, conn);
                DeleteCommand3.Parameters.Add(new SqlParameter("id", Convert.ToInt32(gid)));
                count = DeleteCommand3.ExecuteNonQuery();

                String DeleteCMD4 = "DELETE FROM [Group] WHERE [Group].Id = @id";
                SqlCommand DeleteCommand4 = new SqlCommand(DeleteCMD4, conn);
                DeleteCommand4.Parameters.Add(new SqlParameter("id", Convert.ToInt32(gid)));
                count = DeleteCommand4.ExecuteNonQuery();

                GroupStudent form = new GroupStudent();
                form.Show();
                this.Hide();
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainPage form = new MainPage();
            form.Show();
            this.Hide();
        }
    }
}
