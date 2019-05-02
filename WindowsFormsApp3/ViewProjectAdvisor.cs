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
    public partial class ViewProjectAdvisor : Form
    {
        public String conURL = "Data Source=ROHIT-MEHRA;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=secretpassword";
        public int projectId;
        public ViewProjectAdvisor()
        {
            InitializeComponent();
        }

        public ViewProjectAdvisor(int id)
        {
            InitializeComponent();
            projectId = id;
            try
            {
                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();
                DataTable dt = new DataTable();
                String cmd = String.Format("SELECT * FROM [ProjectAdvisor] WHERE ProjectAdvisor.ProjectId = {0}", id);
                SqlDataAdapter adapt = new SqlDataAdapter(cmd, conn);
                adapt.Fill(dt);
                ViewProjectAdvisorDataGridView.DataSource = dt;
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
    }
}
