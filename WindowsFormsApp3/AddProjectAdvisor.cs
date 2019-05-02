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
    public partial class AddProjectAdvisor : Form
    {
        public String conURL = "Data Source=ROHIT-MEHRA;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=secretpassword";
        public int projectId;
        public AddProjectAdvisor()
        {
            InitializeComponent();
        }

        public AddProjectAdvisor(int id)
        {
            InitializeComponent();
            projectId = id;
            try
            {
                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();
                DataTable dt = new DataTable();
                String cmd = String.Format("SELECT * FROM [Advisor] WHERE Advisor.Id NOT IN (SELECT AdvisorId FROM ProjectAdvisor WHERE ProjectAdvisor.ProjectId = {0})", projectId);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd, conn);
                adapt.Fill(dt);
                AddProjectAdvisorDataGridView.DataSource = dt;

                DataGridViewButtonColumn addbtn = new DataGridViewButtonColumn();
                addbtn.HeaderText = "Add";
                addbtn.Text = "Add";
                addbtn.UseColumnTextForButtonValue = true;
                addbtn.Width = 80;
                AddProjectAdvisorDataGridView.Columns.Add(addbtn);
                for (int i = 0; i < AddProjectAdvisorDataGridView.Rows.Count; i++)
                {
                    AddProjectAdvisorDataGridView.Rows[i].Cells[0].ReadOnly = true;
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Projects form = new Projects();
            form.Show();
            this.Hide();
        }

        private void AddProjectAdvisorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = int.Parse(e.RowIndex.ToString());
            int curentcolumnindex = int.Parse(e.ColumnIndex.ToString());
            int AdvisorId = Convert.ToInt32(AddProjectAdvisorDataGridView.Rows[currentRow].Cells[1].Value);
            if (curentcolumnindex == 0)
            {
                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();
                String AddCMD = "INSERT INTO ProjectAdvisor (AdvisorId, ProjectId, AdvisorRole, AssignmentDate) VALUES (@adid, @prid, @arole, @asgnDate)";
                SqlCommand AddCommand = new SqlCommand(AddCMD, conn);
                AddCommand.Parameters.Add(new SqlParameter("adid", AdvisorId));
                AddCommand.Parameters.Add(new SqlParameter("prid", projectId));

                String getAdvisorRoleIdCMD = String.Format("SELECT Id FROM Lookup WHERE Value = '{0}'", AdvisorRoleComboBox.Text);
                SqlCommand getAdvisorRoleIdCommand = new SqlCommand(getAdvisorRoleIdCMD, conn);
                int AdvisorRoleId = (Int32)getAdvisorRoleIdCommand.ExecuteScalar();
                AddCommand.Parameters.Add(new SqlParameter("arole", AdvisorRoleId));

                AddCommand.Parameters.Add(new SqlParameter("asgnDate", DateTime.Today));

                int count = AddCommand.ExecuteNonQuery();

                AddProjectAdvisor form = new AddProjectAdvisor(projectId);
                form.Show();
                this.Hide();
            }
            
        }

        private void AddProjectAdvisor_Load(object sender, EventArgs e)
        {

        }
    }
}
