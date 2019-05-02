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
    public partial class AddEvaluationGroup : Form
    {
        public String conURL = "Data Source=ROHIT-MEHRA;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=secretpassword";
        public int groupId;
        public AddEvaluationGroup()
        {
            InitializeComponent();
        }

        public AddEvaluationGroup(int id)
        {
            InitializeComponent();
            groupId = id;
            try
            {
                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();
                DataTable dt = new DataTable();
                String cmd = String.Format("SELECT * FROM [Evaluation] WHERE Evaluation.Id NOT IN (SELECT GroupEvaluation.EvaluationId FROM GroupEvaluation WHERE GroupEvaluation.GroupId = {0})", id);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd, conn);
                adapt.Fill(dt);
                GroupEvaluationDataGridView.DataSource = dt;

                DataGridViewButtonColumn addbtn = new DataGridViewButtonColumn();
                addbtn.HeaderText = "Add to Group";
                addbtn.Text = "Add Evaluation";
                addbtn.UseColumnTextForButtonValue = true;
                addbtn.Width = 80;
                GroupEvaluationDataGridView.Columns.Add(addbtn);
                for (int i = 0; i < GroupEvaluationDataGridView.Rows.Count; i++)
                {
                    GroupEvaluationDataGridView.Rows[i].Cells[0].ReadOnly = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void GroupEvaluationDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = int.Parse(e.RowIndex.ToString());
            int curentcolumnindex = int.Parse(e.ColumnIndex.ToString());
            int EvaluationId = Convert.ToInt32(GroupEvaluationDataGridView.Rows[currentRow].Cells[1].Value);
            if (curentcolumnindex == 0)
            {
                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();
               
                if(!String.IsNullOrEmpty(ObtainedMarksTextBox.Text))
                {
                    String AddCMD = "INSERT INTO GroupEvaluation (GroupId, EvaluationId, ObtainedMarks, EvaluationDate) VALUES (@gid, @eid, @marks, @evalDate)";
                    SqlCommand AddCommand = new SqlCommand(AddCMD, conn);

                    AddCommand.Parameters.Add(new SqlParameter("status", 3));
                    AddCommand.Parameters.Add(new SqlParameter("eid", EvaluationId));
                    AddCommand.Parameters.Add(new SqlParameter("gid", groupId));
                    AddCommand.Parameters.Add(new SqlParameter("marks", Convert.ToInt32(ObtainedMarksTextBox.Text)));
                    AddCommand.Parameters.Add(new SqlParameter("evalDate", DateTime.Today));

                    int count = AddCommand.ExecuteNonQuery();
                }
                GroupStudent form = new GroupStudent();
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

        private void AddEvaluationGroup_Load(object sender, EventArgs e)
        {

        }
    }
}
