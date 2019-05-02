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
    public partial class ViewGroupStudents : Form
    {
        public String conURL = "Data Source=ROHIT-MEHRA;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=secretpassword";
        public int gid;
        public ViewGroupStudents()
        {
            InitializeComponent();
        }

        public ViewGroupStudents(int id)
        {
            InitializeComponent();
            gid = id;
            try
            {
                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();
                DataTable dt = new DataTable();
                String cmd = String.Format("SELECT Id, RegistrationNo, GroupStudent.[Status], AssignmentDate FROM GroupStudent JOIN Student ON GroupStudent.StudentId = Student.Id WHERE GroupStudent.GroupId = {0}", id);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd, conn);
                adapt.Fill(dt);
                ViewGroupStudentsDataGridView.DataSource = dt;
                ViewGroupStudentsDataGridView.Columns["Id"].Visible = false;

                DataGridViewButtonColumn DeleteBtn = new DataGridViewButtonColumn();
                DeleteBtn.HeaderText = "Delete Student";
                DeleteBtn.Text = "Delete";
                DeleteBtn.UseColumnTextForButtonValue = true;
                DeleteBtn.Width = 80;
                ViewGroupStudentsDataGridView.Columns.Add(DeleteBtn);
                for (int i = 0; i < ViewGroupStudentsDataGridView.Rows.Count; i++)
                {
                    ViewGroupStudentsDataGridView.Rows[i].Cells[0].ReadOnly = true;

                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void ViewGroupStudents_Load(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            GroupStudent form = new GroupStudent();
            form.Show();
            this.Hide();
        }

        private void ViewGroupStudentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = int.Parse(e.RowIndex.ToString());
            int curentcolumnindex = int.Parse(e.ColumnIndex.ToString());
            int sid = Convert.ToInt32(ViewGroupStudentsDataGridView.Rows[currentRow].Cells[1].Value.ToString());
            if (curentcolumnindex == 0)
            {
                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();
                String DeleteCMD = "DELETE FROM GroupStudent WHERE GroupStudent.StudentId = @id";
                SqlCommand DeleteCommand = new SqlCommand(DeleteCMD, conn);
                DeleteCommand.Parameters.Add(new SqlParameter("id", sid));
                int count = DeleteCommand.ExecuteNonQuery();
                
                ViewGroupStudents form = new ViewGroupStudents(gid);
                form.Show();
                this.Hide();
            }
        }
    }
}
