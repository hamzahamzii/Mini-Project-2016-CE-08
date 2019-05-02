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
    public partial class Advisors : Form
    {
        public String conURL = "Data Source=ROHIT-MEHRA;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=secretpassword";
        public Advisors()
        {
            InitializeComponent();
        }


        private void AdvisorsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddAdvisorBtn_Click(object sender, EventArgs e)
        {
            AddAdvisor form = new AddAdvisor();
            form.Show();
            this.Hide();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Advisors_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Person JOIN Advisor on Person.Id = Advisor.Id", conn);
                adapt.Fill(dt);
                AdvisorsGridView.DataSource = dt;
                AdvisorsGridView.Columns["Id"].Visible = false;
                AdvisorsGridView.Columns["Id1"].Visible = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void UpdateAdvisorBtn_Click(object sender, EventArgs e)
        {

            if (AdvisorsGridView.SelectedCells.Count != 0)
            {
                int row = AdvisorsGridView.SelectedCells[0].RowIndex;
                int id = Convert.ToInt32(AdvisorsGridView.Rows[row].Cells[0].Value);
                AddAdvisor form = new AddAdvisor(id);
                form.Show();
                this.Hide();
            }
        }

        private void BackAdvisorsBtn_Click(object sender, EventArgs e)
        {
            MainPage form = new MainPage();
            form.Show();
            this.Hide();
        }

        private void DeleteAdvisorBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();

            if (AdvisorsGridView.SelectedCells.Count != 0)
            {
                int row = AdvisorsGridView.SelectedCells[0].RowIndex;
                int id = Convert.ToInt32(AdvisorsGridView.Rows[row].Cells[0].Value);

                String delAdvisorCMD2 = String.Format("DELETE FROM ProjectAdvisor WHERE AdvisorId = {0}", id);
                SqlCommand delAdvisorCommand2 = new SqlCommand(delAdvisorCMD2, conn);
                int count = delAdvisorCommand2.ExecuteNonQuery();

                String delAdvisorCMD = String.Format("DELETE FROM Advisor WHERE Id = {0}", id);
                SqlCommand delAdvisorCommand = new SqlCommand(delAdvisorCMD, conn);
                count = delAdvisorCommand.ExecuteNonQuery();

                String delPersonCMD = String.Format("DELETE FROM Person WHERE Id = {0}", id);
                SqlCommand delPersonCommand = new SqlCommand(delPersonCMD, conn);
                count = delPersonCommand.ExecuteNonQuery();

                Advisors form = new Advisors();
                this.Hide();
                form.Show();
            }
        }
    }
}
