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
    public partial class AddStudent : Form
    {
        public int flag = 0;
        public int incomingId;
        public String conURL = "Data Source=ROHIT-MEHRA;Initial Catalog=ProjectA;Persist Security Info=True;User ID=sa;Password=secretpassword";

        public AddStudent()
        {
            InitializeComponent();
            flag = 0;
            incomingId = -1;
            GenderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public AddStudent(int id)
        {
            InitializeComponent();
            GenderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            flag = 1;
            incomingId = id;
            SqlConnection conn = new SqlConnection(conURL);
            conn.Open();
            String getvaluescmd = String.Format("SELECT * FROM Person JOIN Student on Person.Id = Student.Id WHERE Person.Id = {0}", id);
            SqlCommand getvaluesCommand = new SqlCommand(getvaluescmd, conn);
            SqlDataReader reader = getvaluesCommand.ExecuteReader();
            while(reader.Read())
            {
                FirstNameTextBox.Text = reader[1].ToString();
                if (!String.IsNullOrEmpty(reader.GetValue(2).ToString()))
                {
                    LastNameTextBox.Text = reader[2].ToString();
                }
                if(!String.IsNullOrEmpty(reader.GetValue(3).ToString()))
                {
                    ContactTextBox.Text = reader[3].ToString();
                }
                EmailTextBox.Text = reader[4].ToString();
                if (!String.IsNullOrEmpty(reader[5].ToString()))
                {
                    DobDateTimePicker.Value = (DateTime)reader.GetValue(5);
                }
                RegNoTextBox.Text = reader[8].ToString();
                if(!String.IsNullOrEmpty(reader.GetValue(6).ToString()))
                {
                    if ((int)reader.GetValue(6) == 1)
                    {
                        GenderComboBox.Text = "Male";
                    }
                    if ((int)reader.GetValue(6) == 2)
                    {
                        GenderComboBox.Text = "Female";
                    }
                }
                
                Title.Text = "Update Student";
            }
        }

        public bool ValidateEntries()
        {
            bool valid = true;

            //FIRSTNAME
            if (!String.IsNullOrEmpty(FirstNameTextBox.Text) && !Regex.Match(FirstNameTextBox.Text, "^[a-zA-z]*$").Success)
            {
                epFirstName.SetError(FirstNameTextBox, "Invalid First Name !");
                valid = false;
            }
            else
            {
                epFirstName.SetError(FirstNameTextBox, null);
            }
            if (String.IsNullOrEmpty(FirstNameTextBox.Text))
            {
                epFirstName.SetError(FirstNameTextBox, "Give first name please !");
                valid = false;
            }
            else
            {
                epFirstName.SetError(FirstNameTextBox, null);
            }

            //LASTNAME
            if (!String.IsNullOrEmpty(LastNameTextBox.Text) && !Regex.Match(LastNameTextBox.Text, "^[a-zA-z]*$").Success)
            {
                epLastName.SetError(LastNameTextBox, "Invalid Last Name !");
                valid = false;
            }
            else
            {
                epLastName.SetError(LastNameTextBox, null);
            }


            //RegNo
            if (!String.IsNullOrEmpty(RegNoTextBox.Text) && !Regex.Match(RegNoTextBox.Text, "^[0-9]{4}-(CE|CS|MEC|EE|CIV|ME|ARC|PID)-[0-9]{1,3}$").Success)
            {
                epRegNo.SetError(RegNoTextBox, "Invalid Registration Number !");
                valid = false;
            }
            else
            {
                epRegNo.SetError(RegNoTextBox, null);
            }
            if (String.IsNullOrEmpty(RegNoTextBox.Text))
            {
                epRegNo.SetError(RegNoTextBox, "Give Registration number please !");
                valid = false;
            }
            else
            {
                epRegNo.SetError(RegNoTextBox, null);
            }


            //EMAIL
            if (!String.IsNullOrEmpty(EmailTextBox.Text) && !Regex.Match(EmailTextBox.Text, "^[a-zA-Z0-9.-_]{3,20}@[a-z]{3,20}.(com|net|org|uet.edu.pk|co.uk)$").Success)
            {
                epEmail.SetError(EmailTextBox, "Invalid Email !");
                valid = false;
            }
            else
            {
                epEmail.SetError(EmailTextBox, null);
            }
            if (String.IsNullOrEmpty(EmailTextBox.Text))
            {
                epEmail.SetError(EmailTextBox, "Give Email please !");
                valid = false;
            }
            else
            {
                epEmail.SetError(EmailTextBox, null);
            }
            

            

            //Contact
            if (!String.IsNullOrEmpty(ContactTextBox.Text) && !Regex.Match(ContactTextBox.Text, "^[0-9+]{11,14}$").Success)
            {
                epContact.SetError(ContactTextBox, "Invalid Contact Number !");
                valid = false;
            }
            else
            {
                epContact.SetError(ContactTextBox, null);
            }

            return valid;
        }

        private void AddStudentSaveBtn_Click(object sender, EventArgs e)
        {
            if(ValidateEntries())
            {
                if (flag == 0)
                {

                    SqlConnection conn = new SqlConnection(conURL);
                    conn.Open();
                    String AddPersonCMD = "INSERT INTO Person (FirstName, LastName, Contact, Email, DateOfBirth, Gender) VALUES (@fname, @lname, @contact, @email, @dob, @gender)";
                    SqlCommand AddPersonCommand = new SqlCommand(AddPersonCMD, conn);
                    AddPersonCommand.Parameters.Add(new SqlParameter("fname", FirstNameTextBox.Text));

                    //LastName
                    if(!String.IsNullOrEmpty(LastNameTextBox.Text))
                    {
                        AddPersonCommand.Parameters.Add(new SqlParameter("lname", LastNameTextBox.Text));
                    }
                    else
                    {
                        AddPersonCommand.Parameters.Add(new SqlParameter("lname", DBNull.Value));
                    }

                    //Contact
                    if (!String.IsNullOrEmpty(ContactTextBox.Text))
                    {
                        AddPersonCommand.Parameters.Add(new SqlParameter("contact", ContactTextBox.Text));
                    }
                    else
                    {
                        AddPersonCommand.Parameters.Add(new SqlParameter("contact", DBNull.Value));
                    }

                    //DOB
                    if (!String.IsNullOrEmpty(DobDateTimePicker.Text))
                    {
                        AddPersonCommand.Parameters.Add(new SqlParameter("dob", DobDateTimePicker.Value));
                    }
                    else
                    {
                        AddPersonCommand.Parameters.Add(new SqlParameter("dob", DBNull.Value));
                    }

                    AddPersonCommand.Parameters.Add(new SqlParameter("email", EmailTextBox.Text));

                    //GENDER
                    if(!String.IsNullOrEmpty(GenderComboBox.Text))
                    {
                        String getGenderIdCMD = String.Format("SELECT Id FROM Lookup WHERE Value = '{0}'", GenderComboBox.Text);
                        SqlCommand getGenderIdCommand = new SqlCommand(getGenderIdCMD, conn);
                        int genderid = (Int32)getGenderIdCommand.ExecuteScalar();
                        AddPersonCommand.Parameters.Add(new SqlParameter("gender", genderid));
                    }
                    else
                    {
                        AddPersonCommand.Parameters.Add(new SqlParameter("gender", DBNull.Value));
                    }


                    int count = AddPersonCommand.ExecuteNonQuery();

                    String getpIdCMD = "SELECT MAX(Id) FROM Person";
                    SqlCommand getpIdCommand = new SqlCommand(getpIdCMD, conn);
                    int pId = (Int32)getpIdCommand.ExecuteScalar();

                    String AddStudentCMD = "INSERT INTO Student (Id, RegistrationNo) VALUES (@sid, @regno)";
                    SqlCommand AddStudentCommand = new SqlCommand(AddStudentCMD, conn);
                    AddStudentCommand.Parameters.Add(new SqlParameter("sid", pId));
                    AddStudentCommand.Parameters.Add(new SqlParameter("regno", RegNoTextBox.Text));
                    count = AddStudentCommand.ExecuteNonQuery();

                    Students form = new Students();
                    form.Show();
                    this.Hide();
                }
                if (flag == 1)
                {
                    SqlConnection conn = new SqlConnection(conURL);
                    conn.Open();
                    String UpdatePersonCMD = "UPDATE Person SET FirstName = @fname, LastName = @lname, Contact = @contact, Email = @email, DateOfBirth = @dob, Gender = @gender WHERE Id = @id";
                    SqlCommand UpdatePersonCommand = new SqlCommand(UpdatePersonCMD, conn);
                    UpdatePersonCommand.Parameters.Add(new SqlParameter("fname", FirstNameTextBox.Text));
                    //LastName
                    if (!String.IsNullOrEmpty(LastNameTextBox.Text))
                    {
                        UpdatePersonCommand.Parameters.Add(new SqlParameter("lname", LastNameTextBox.Text));
                    }
                    else
                    {
                        UpdatePersonCommand.Parameters.Add(new SqlParameter("lname", DBNull.Value));
                    }

                    //Contact
                    if (!String.IsNullOrEmpty(ContactTextBox.Text))
                    {
                        UpdatePersonCommand.Parameters.Add(new SqlParameter("contact", ContactTextBox.Text));
                    }
                    else
                    {
                        UpdatePersonCommand.Parameters.Add(new SqlParameter("contact", DBNull.Value));
                    }

                    //DOB
                    if (!String.IsNullOrEmpty(DobDateTimePicker.Text.ToString()))
                    {
                        UpdatePersonCommand.Parameters.Add(new SqlParameter("dob", DobDateTimePicker.Value));
                    }
                    else
                    {
                        UpdatePersonCommand.Parameters.Add(new SqlParameter("dob", DBNull.Value));
                    }

                    UpdatePersonCommand.Parameters.Add(new SqlParameter("email", EmailTextBox.Text));

                    //GENDER
                    if (!String.IsNullOrEmpty(GenderComboBox.Text))
                    {
                        String getGenderIdCMD = String.Format("SELECT Id FROM Lookup WHERE Value = '{0}'", GenderComboBox.Text);
                        SqlCommand getGenderIdCommand = new SqlCommand(getGenderIdCMD, conn);
                        int genderid = (Int32)getGenderIdCommand.ExecuteScalar();
                        UpdatePersonCommand.Parameters.Add(new SqlParameter("gender", genderid));
                    }
                    else
                    {
                        UpdatePersonCommand.Parameters.Add(new SqlParameter("gender", DBNull.Value));
                    }

                    UpdatePersonCommand.Parameters.Add(new SqlParameter("id", incomingId));

                    int count = UpdatePersonCommand.ExecuteNonQuery();

                    String UpdateStudentCMD = "UPDATE Student SET RegistrationNo = @regno WHERE Id = @id";
                    SqlCommand UpdateStudentCommand = new SqlCommand(UpdateStudentCMD, conn);
                    UpdateStudentCommand.Parameters.Add(new SqlParameter("regno", RegNoTextBox.Text));
                    UpdateStudentCommand.Parameters.Add(new SqlParameter("id", incomingId));

                    count = UpdateStudentCommand.ExecuteNonQuery();

                    Students form = new Students();
                    form.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Input Error");
            }
              
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Students form = new Students();
            form.Show();
            this.Hide();
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
