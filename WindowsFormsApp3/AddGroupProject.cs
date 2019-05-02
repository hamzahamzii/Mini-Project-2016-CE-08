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
    public partial class AddGroupProject : Form
    {
        public String conURL = "Data Source=ROHIT-MEHRA;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=secretpassword";
        public int groupId;
        public AddGroupProject()
        {
            InitializeComponent();
        }

        public AddGroupProject(int id)
        {
            InitializeComponent();
            groupId = id;
            try
            {
                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();
                DataTable dt = new DataTable();
                String cmd = String.Format("SELECT * FROM [Project] WHERE Project.Id NOT IN (SELECT GroupProject.ProjectId FROM GroupProject)");
                SqlDataAdapter adapt = new SqlDataAdapter(cmd, conn);
                adapt.Fill(dt);
                AddGroupProjectDataGridView.DataSource = dt;

                DataGridViewButtonColumn addbtn = new DataGridViewButtonColumn();
                addbtn.HeaderText = "Add to Group";
                addbtn.Text = "Add";
                addbtn.UseColumnTextForButtonValue = true;
                addbtn.Width = 80;
                AddGroupProjectDataGridView.Columns.Add(addbtn);
                for (int i = 0; i < AddGroupProjectDataGridView.Rows.Count; i++)
                {
                    AddGroupProjectDataGridView.Rows[i].Cells[0].ReadOnly = true;

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

        private void AddGroupProject_Load(object sender, EventArgs e)
        {

        }

        private void AddGroupProjectDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = int.Parse(e.RowIndex.ToString());
            int curentcolumnindex = int.Parse(e.ColumnIndex.ToString());
            int ProjectId = Convert.ToInt32(AddGroupProjectDataGridView.Rows[currentRow].Cells[1].Value);
            if (curentcolumnindex == 0)
            {
                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();
                String AddCMD = "INSERT INTO GroupProject (ProjectId, GroupId, AssignmentDate) VALUES (@prid, @gid, @asgnDate)";
                SqlCommand AddCommand = new SqlCommand(AddCMD, conn);
                AddCommand.Parameters.Add(new SqlParameter("prid", ProjectId));
                AddCommand.Parameters.Add(new SqlParameter("gid", groupId));
                AddCommand.Parameters.Add(new SqlParameter("asgnDate", DateTime.Today));

                int count = AddCommand.ExecuteNonQuery();
             }
                GroupStudent form = new GroupStudent();
                form.Show();
                this.Hide();
            }
        }
}
