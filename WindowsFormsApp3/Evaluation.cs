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
    public partial class Evaluation : Form
    {
        public String conURL = "Data Source=ROHIT-MEHRA;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=secretpassword";
        public Evaluation()
        {
            InitializeComponent();
        }

        private void Evaluation_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Evaluation", conn);
                adapt.Fill(dt);
                EvaluationsGridView.DataSource = dt;
                EvaluationsGridView.Columns["Id"].Visible = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void BackEvaluationsBtn_Click(object sender, EventArgs e)
        {
            MainPage form = new MainPage();
            form.Show();
            this.Hide();
        }

        private void AddEvaluationsBtn_Click(object sender, EventArgs e)
        {
            AddEvaluation form = new AddEvaluation();
            form.Show();
            this.Hide();
        }

        private void UpdateEvaluationsBtn_Click(object sender, EventArgs e)
        {
            if (EvaluationsGridView.SelectedCells.Count != 0)
            {
                int row = EvaluationsGridView.SelectedCells[0].RowIndex;
                int id = Convert.ToInt32(EvaluationsGridView.Rows[row].Cells[0].Value);
                AddEvaluation form = new AddEvaluation(id);
                form.Show();
                this.Hide();
            }
        }

        private void DeleteEvaluationsBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();

            if (EvaluationsGridView.SelectedCells.Count != 0)
            {
                int row = EvaluationsGridView.SelectedCells[0].RowIndex;
                int id = Convert.ToInt32(EvaluationsGridView.Rows[row].Cells[0].Value);

                String delEvaluationCMD1 = String.Format("DELETE FROM GroupEvaluation WHERE GroupEvaluation.EvaluationId = {0}", id);
                SqlCommand delEvaluationCommand1 = new SqlCommand(delEvaluationCMD1, conn);

                int count = delEvaluationCommand1.ExecuteNonQuery();

                String delEvaluationCMD = String.Format("DELETE FROM Evaluation WHERE Id = {0}", id);
                SqlCommand delEvaluationCommand = new SqlCommand(delEvaluationCMD, conn);

                count = delEvaluationCommand.ExecuteNonQuery();
                Evaluation form = new Evaluation();
                this.Hide();
                form.Show();
            }
        }
    }
}
