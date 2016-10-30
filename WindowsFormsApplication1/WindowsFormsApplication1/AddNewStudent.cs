using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AddNewStudent : Form
    {
        public AddNewStudent()
        {
            InitializeComponent();
            addSchool.DataSource = Model.getSchools();
            AddCurrent.DataSource = Model.getCurrentStudentOptions();
            AddGender.DataSource = Model.getGenders();

            AddGender.DropDownStyle = ComboBoxStyle.DropDownList;
            addSchool.DropDownStyle = ComboBoxStyle.DropDownList;
            AddCurrent.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void School_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddNewStudent_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void AddStudentSubmit_Click(object sender, EventArgs e)
        {

        }

        private void AddStudentSubmit_Click_1(object sender, EventArgs e)
        {
            String firstName = addFirstName.Text;
            String lastName = addLastName.Text;
            int studentID = int.Parse(addStudentID.Text);
            Double gpa;
            if (AddGPA.Text != "")
            {
                gpa = Double.Parse(AddGPA.Text);
            } else
            {
                Double cumGPA = Double.Parse(CumGradeAdd.Text);
                gpa = cumGPA / 25;
            }
            String school = addSchool.Text;
            int grade = int.Parse(AddGrade.Text);
            int numRefs = int.Parse(AddBehavior.Text);
            int daysMissed = int.Parse(AddAttend.Text);
            String gender = AddGender.Text;
            String race = raceBox.Text;
            String curStudent = AddCurrent.Text;

            Model.InsertStudent(firstName, lastName, studentID, gpa, school, grade, numRefs, daysMissed, gender, race, curStudent);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
