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
    public partial class Students : Form
    {
        public String conURL = "Data Source=ROHIT-MEHRA;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=secretpassword";
        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(conURL);
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM Person JOIN Student on Person.Id = Student.Id", conn);
                adapt.Fill(dt);
                StudentsGridView.DataSource = dt;
                StudentsGridView.Columns["Id"].Visible = false;
                StudentsGridView.Columns["Id1"].Visible = false;
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }     
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void AddStudentsButton_Click(object sender, EventArgs e)
        {
            AddStudent form = new AddStudent();
            form.Show();
            this.Hide();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DeleteStudentBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();

            if(StudentsGridView.SelectedCells.Count != 0)
            {
                int row = StudentsGridView.SelectedCells[0].RowIndex;
                int id = Convert.ToInt32(StudentsGridView.Rows[row].Cells[0].Value);

                String delStdCMD1 = String.Format("DELETE FROM GroupStudent WHERE StudentId = {0}", id);
                SqlCommand delStdCommand1 = new SqlCommand(delStdCMD1, conn);
                int count = delStdCommand1.ExecuteNonQuery();

                String delStdCMD = String.Format("DELETE FROM Student WHERE Id = {0}", id);
                SqlCommand delStdCommand = new SqlCommand(delStdCMD, conn);
                count = delStdCommand.ExecuteNonQuery();

                
                String delPersonCMD = String.Format("DELETE FROM Person WHERE Id = {0}", id);
                SqlCommand delPersonCommand = new SqlCommand(delPersonCMD, conn);
                count = delPersonCommand.ExecuteNonQuery();
                Students form = new Students();
                this.Hide();
                form.Show();
            }
        }

        private void RefreshStudentsBtn_Click(object sender, EventArgs e)
        {
            Students form = new Students();
            this.Hide();
            form.Show();
        }

        private void UpdateStudentBtn_Click(object sender, EventArgs e)
        {
            if (StudentsGridView.SelectedCells.Count != 0)
            {
                int row = StudentsGridView.SelectedCells[0].RowIndex;
                int id = Convert.ToInt32(StudentsGridView.Rows[row].Cells[0].Value);
                AddStudent form = new AddStudent(id);
                form.Show();
                this.Hide();
            }
                
        }

        private void BackStudentsBtn_Click(object sender, EventArgs e)
        {
            MainPage form = new MainPage();
            form.Show();
            this.Hide();
        }
    }
}
