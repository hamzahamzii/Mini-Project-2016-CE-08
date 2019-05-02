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
    public partial class ViewGroupEvaluation : Form
    {
        public String conURL = "Data Source=ROHIT-MEHRA;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=secretpassword";
        public int groupId;
        public ViewGroupEvaluation()
        {
            InitializeComponent();
        }

        public ViewGroupEvaluation(int id)
        {
            InitializeComponent();
            groupId = id;
            try
            {
                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();
                DataTable dt = new DataTable();
                String cmd = String.Format("SELECT Evaluation.Id, Evaluation.Name, GroupEvaluation.ObtainedMarks, Evaluation.TotalMarks, Evaluation.TotalWeightage, GroupEvaluation.EvaluationDate  FROM [GroupEvaluation] JOIN Evaluation on GroupEvaluation.EvaluationId = Evaluation.Id WHERE GroupEvaluation.GroupId = {0}", id);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd, conn);
                adapt.Fill(dt);
                ViewGroupEvalDataGridView.DataSource = dt;
                ViewGroupEvalDataGridView.Columns["Id"].Visible = false;


                DataGridViewButtonColumn DeleteBtn = new DataGridViewButtonColumn();
                DeleteBtn.HeaderText = "Delete Evaluation";
                DeleteBtn.Text = "Delete";
                DeleteBtn.UseColumnTextForButtonValue = true;
                DeleteBtn.Width = 80;
                ViewGroupEvalDataGridView.Columns.Add(DeleteBtn);
                for (int i = 0; i < ViewGroupEvalDataGridView.Rows.Count; i++)
                {
                    ViewGroupEvalDataGridView.Rows[i].Cells[0].ReadOnly = true;
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

        private void ViewGroupEvaluation_Load(object sender, EventArgs e)
        {

        }

        private void ViewGroupEvalDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = int.Parse(e.RowIndex.ToString());
            int curentcolumnindex = int.Parse(e.ColumnIndex.ToString());
            int evalid = Convert.ToInt32(ViewGroupEvalDataGridView.Rows[currentRow].Cells[1].Value.ToString());
            if (curentcolumnindex == 0)
            {
                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();
                String DeleteCMD = "DELETE FROM GroupEvaluation WHERE GroupEvaluation.EvaluationId = @id";
                SqlCommand DeleteCommand = new SqlCommand(DeleteCMD, conn);
                DeleteCommand.Parameters.Add(new SqlParameter("id", evalid));
                int count = DeleteCommand.ExecuteNonQuery();

                ViewGroupEvaluation form = new ViewGroupEvaluation(groupId);
                form.Show();
                this.Hide();
            }
        }
    }
}
