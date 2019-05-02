using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class AddEvaluation : Form
    {
        public int flag = 0;
        public int incomingId;
        public String conURL = "Data Source=ROHIT-MEHRA;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=secretpassword";
        public AddEvaluation()
        {
            InitializeComponent();
        }

        public AddEvaluation(int id)
        {
            InitializeComponent();
            flag = 1;
            incomingId = id;
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            String getvaluescmd = String.Format("SELECT * FROM Evaluation WHERE Id = {0}", id);
            SqlCommand getvaluesCommand = new SqlCommand(getvaluescmd, conn);
            SqlDataReader reader = getvaluesCommand.ExecuteReader();
            while (reader.Read())
            {
                EvaluationNameTextBox.Text = reader[1].ToString();
                EvaluationMarksTextBox.Text = reader[2].ToString();
                TotalWeightageTextBox.Text = reader[3].ToString();
                Title.Text = "Update Project";
            }
        }

        public bool ValidateEntries()
        {
            bool valid = true;
            //EvaluationName
            if (!String.IsNullOrEmpty(EvaluationNameTextBox.Text) && !Regex.Match(EvaluationNameTextBox.Text, "^[a-zA-z]*$").Success)
            {
                epName.SetError(EvaluationNameTextBox, "Invalid Evaluation Name !");
                valid = false;
            }
            else
            {
                epName.SetError(EvaluationNameTextBox, null);
            }
            if (String.IsNullOrEmpty(EvaluationNameTextBox.Text))
            {
                epName.SetError(EvaluationNameTextBox, "Give Evaluation Name please !");
                valid = false;
            }
            else
            {
                epName.SetError(EvaluationNameTextBox, null);
            }


            //Evaluation Total Marks
            if (!String.IsNullOrEmpty(EvaluationMarksTextBox.Text) && !Regex.Match(EvaluationMarksTextBox.Text, "^[0-9]{1,3}$").Success)
            {
                epTotalMarks.SetError(EvaluationMarksTextBox, "Invalid Evaluation Marks !");
                valid = false;
            }
            else
            {
                epTotalMarks.SetError(EvaluationMarksTextBox, null);
            }
            if (String.IsNullOrEmpty(EvaluationMarksTextBox.Text))
            {
                epTotalMarks.SetError(EvaluationMarksTextBox, "Give Total Marks please !");
                valid = false;
            }
            else
            {
                epTotalMarks.SetError(EvaluationMarksTextBox, null);
            }


            //Evaluation Total Weightage
            if (!String.IsNullOrEmpty(TotalWeightageTextBox.Text) && !Regex.Match(TotalWeightageTextBox.Text, "^[0-9]{1,3}$").Success)
            {
                epTotalWeightage.SetError(TotalWeightageTextBox, "Invalid Total Weightage !");
                valid = false;
            }
            else
            {
                epTotalWeightage.SetError(TotalWeightageTextBox, null);
            }
            if (String.IsNullOrEmpty(TotalWeightageTextBox.Text))
            {
                epTotalWeightage.SetError(TotalWeightageTextBox, "Give Total Weightage please !");
                valid = false;
            }
            else
            {
                epTotalWeightage.SetError(TotalWeightageTextBox, null);
            }
            

            return valid;
        }


        private void AddEvaluationSaveBtn_Click(object sender, EventArgs e)
        {
            if(ValidateEntries())
            {
                if (flag == 0)
                {
                    SqlConnection conn = new SqlConnection(conURL);
                    conn.Open();
                    String AddEvaluationCMD = "INSERT INTO Evaluation (Name, TotalMarks, TotalWeightage) VALUES (@name, @marks, @weightage)";
                    SqlCommand AddEvaluationCommand = new SqlCommand(AddEvaluationCMD, conn);
                    AddEvaluationCommand.Parameters.Add(new SqlParameter("name", EvaluationNameTextBox.Text));
                    AddEvaluationCommand.Parameters.Add(new SqlParameter("marks", EvaluationMarksTextBox.Text));
                    AddEvaluationCommand.Parameters.Add(new SqlParameter("weightage", TotalWeightageTextBox.Text));
                    int count = AddEvaluationCommand.ExecuteNonQuery();
                    Evaluation form = new Evaluation();
                    form.Show();
                    this.Hide();
                }
                if (flag == 1)
                {
                    SqlConnection conn = new SqlConnection(conURL);
                    conn.Open();
                    String UpdateEvaluationCMD = "UPDATE Evaluation SET Name = @name, TotalMarks = @marks, TotalWeightage = @weightage WHERE Id = @id";
                    SqlCommand UpdateEvaluationCommand = new SqlCommand(UpdateEvaluationCMD, conn);
                    UpdateEvaluationCommand.Parameters.Add(new SqlParameter("name", EvaluationNameTextBox.Text));
                    UpdateEvaluationCommand.Parameters.Add(new SqlParameter("marks", EvaluationMarksTextBox.Text));
                    UpdateEvaluationCommand.Parameters.Add(new SqlParameter("weightage", TotalWeightageTextBox.Text));
                    UpdateEvaluationCommand.Parameters.Add(new SqlParameter("id", incomingId));

                    int count = UpdateEvaluationCommand.ExecuteNonQuery();

                    Evaluation form = new Evaluation();
                    form.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Evaluation form = new Evaluation();
            form.Show();
            this.Hide();
        }

        private void AddEvaluation_Load(object sender, EventArgs e)
        {

        }
    }
}
