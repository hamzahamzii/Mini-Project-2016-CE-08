using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void StudentBtn_Click(object sender, EventArgs e)
        {
            Students form = new Students();
            form.Show();
            this.Hide();
        }

        private void AdvisorBtn_Click(object sender, EventArgs e)
        {
            Advisors form2 = new Advisors();
            form2.Show();
            this.Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Advisors form = new Advisors();
            form.Show();
            this.Hide();
        }

        private void ProjectsBtn_Click_1(object sender, EventArgs e)
        {
            Projects form = new Projects();
            form.Show();
            this.Hide();
        }

        private void EvaluationsBtn_Click_1(object sender, EventArgs e)
        {
            Evaluation form = new Evaluation();
            form.Show();
            this.Hide();
        }

        private void GroupsBtn_Click(object sender, EventArgs e)
        {
            GroupStudent form = new GroupStudent();
            form.Show();
            this.Hide();
        }
    }
}
