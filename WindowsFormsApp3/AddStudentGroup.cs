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

    public partial class AddStudentGroup : Form
    {
        public String conURL = "Data Source=ROHIT-MEHRA;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=secretpassword";
        public int groupId;
        public AddStudentGroup()
        {
            InitializeComponent();
        }

        public AddStudentGroup(int id)
        {
            InitializeComponent();
            groupId = id;
            try
            {
                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();
                DataTable dt = new DataTable();
                String cmd = String.Format("SELECT * FROM [Student] WHERE Student.Id NOT IN (SELECT GroupStudent.StudentId FROM GroupStudent WHERE GroupStudent.GroupId = {0})", id);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd, conn);
                adapt.Fill(dt);
                GroupStudentDataGridView.DataSource = dt;

                DataGridViewButtonColumn addbtn = new DataGridViewButtonColumn();
                addbtn.HeaderText = "Add to Group";
                addbtn.Text = "Add";
                addbtn.UseColumnTextForButtonValue = true;
                addbtn.Width = 80;
                GroupStudentDataGridView.Columns.Add(addbtn);
                for (int i = 0; i < GroupStudentDataGridView.Rows.Count; i++)
                {
                    GroupStudentDataGridView.Rows[i].Cells[0].ReadOnly = true;

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }


        private void AddStudentGroup_Load(object sender, EventArgs e)
        {

        }

        private void GroupStudentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = int.Parse(e.RowIndex.ToString());
            int curentcolumnindex = int.Parse(e.ColumnIndex.ToString());
            int sid = Convert.ToInt32(GroupStudentDataGridView.Rows[currentRow].Cells[1].Value);
            if (curentcolumnindex == 0)
            {
                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();
                String UpdateCMD = "UPDATE GroupStudent SET Status = @status WHERE GroupStudent.StudentId = @sid";
                SqlCommand UpdateCommand = new SqlCommand(UpdateCMD, conn);
                UpdateCommand.Parameters.Add(new SqlParameter("status", 4));
                UpdateCommand.Parameters.Add(new SqlParameter("sid", sid));
                int count = UpdateCommand.ExecuteNonQuery();

                String AddCMD = "INSERT INTO GroupStudent (GroupId, StudentId, Status, AssignmentDate) VALUES (@gid, @sid, @status, @asgnDate)";
                SqlCommand AddCommand = new SqlCommand(AddCMD, conn);

                AddCommand.Parameters.Add(new SqlParameter("status", 3));
                AddCommand.Parameters.Add(new SqlParameter("sid", sid));
                AddCommand.Parameters.Add(new SqlParameter("gid", groupId));
                AddCommand.Parameters.Add(new SqlParameter("asgnDate", DateTime.Today));

                count = AddCommand.ExecuteNonQuery();
                AddStudentGroup form = new AddStudentGroup(Convert.ToInt32(groupId));
                form.Show();
                this.Hide();
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            GroupStudent form = new GroupStudent();
            form.Show();
            this.Hide();
        }
    }
}
