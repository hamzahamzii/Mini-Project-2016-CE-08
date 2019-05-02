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
    public partial class ViewGroupProject : Form
    {
        public String conURL = "Data Source=ROHIT-MEHRA;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=secretpassword";
        public int groupId;
        public ViewGroupProject()
        {
            InitializeComponent();
        }

        public ViewGroupProject(int id)
        {
            InitializeComponent();
            groupId = id;
            try
            {
                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();
                DataTable dt = new DataTable();
                String cmd = String.Format("SELECT Project.Id, Title, Description, AssignmentDate FROM [GroupProject] JOIN Project ON GroupProject.ProjectId = Project.Id WHERE GroupProject.GroupId = {0}", id);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd, conn);
                adapt.Fill(dt);
                ViewGroupProjectDataGridView.DataSource = dt;
                ViewGroupProjectDataGridView.Columns["Id"].Visible = false;

                DataGridViewButtonColumn DeleteBtn = new DataGridViewButtonColumn();
                DeleteBtn.HeaderText = "Delete Project";
                DeleteBtn.Text = "Delete";
                DeleteBtn.UseColumnTextForButtonValue = true;
                DeleteBtn.Width = 80;
                ViewGroupProjectDataGridView.Columns.Add(DeleteBtn);
                for (int i = 0; i < ViewGroupProjectDataGridView.Rows.Count; i++)
                {
                    ViewGroupProjectDataGridView.Rows[i].Cells[0].ReadOnly = true;

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            GroupStudent form = new GroupStudent();
            form.Show();
            this.Hide();
        }

        private void ViewGroupProject_Load(object sender, EventArgs e)
        {

        }

        private void ViewGroupProjectDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = int.Parse(e.RowIndex.ToString());
            int curentcolumnindex = int.Parse(e.ColumnIndex.ToString());
            int prid = Convert.ToInt32(ViewGroupProjectDataGridView.Rows[currentRow].Cells[1].Value.ToString());
            if (curentcolumnindex == 0)
            {
                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();
                String DeleteCMD = "DELETE FROM GroupProject WHERE GroupProject.ProjectId = @id";
                SqlCommand DeleteCommand = new SqlCommand(DeleteCMD, conn);
                DeleteCommand.Parameters.Add(new SqlParameter("id", prid));
                int count = DeleteCommand.ExecuteNonQuery();

                ViewGroupProject form = new ViewGroupProject(groupId);
                form.Show();
                this.Hide();
            }
        }
    }
}
