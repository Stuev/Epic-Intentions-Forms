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

            String firstName;
            String lastName;
            if (addFirstName.Text != "" && addLastName.Text != "")
            {
                firstName = addFirstName.Text;
                lastName = addLastName.Text;
            } else
            {
                MessageBox.Show("Please enter a name for the student!");
                return;
            }

            int studentID;

            if (addStudentID.Text != "")
            {
                try
                {
                    studentID = int.Parse(addStudentID.Text);
                } catch
                {
                    MessageBox.Show("Something went wrong in reading the ID of the student." +
                        "\nPlease make sure that there is a number in the ID field.");
                    return;
                }
            } else
            {
                MessageBox.Show("Please enter an ID for the student!");
                return;
            }

            if (Model.StudentExists(studentID.ToString()))
            {
                MessageBox.Show("A student with this ID already exists in the database!");
                return;
            }


            Double gpa;
            
            if (AddGPA.Text != "")
            {
                try
                {
                    gpa = Double.Parse(AddGPA.Text);
                } catch
                {
                    MessageBox.Show("Something went wrong in reading the GPA of the student." +
                        "\nPlease make sure that there is a number in the GPA field.");
                    return;
                }
            } else
            {
                MessageBox.Show("Please enter a GPA on a 4.0 scale!");
                return;
            }
            String school = addSchool.Text;
            int grade;

            if (AddGrade.Text != "")
            {
                try
                {
                    grade = int.Parse(AddGrade.Text);
                }
                catch
                {
                    MessageBox.Show("Something went wrong in reading the grade level of the student." +
                        "\nPlease make sure that there is a number in the grade level.");
                    return;
                }
            } else
            {
                MessageBox.Show("There is nothing in the Grade Level blank!");
                return;
            }

            int numRefs;

            if (AddBehavior.Text != "")
            {
                numRefs = int.Parse(AddBehavior.Text);
            } else
            {
                numRefs = 0;
            }

            int daysMissed;
            if (AddAttend.Text != "")
            {
                daysMissed = int.Parse(AddAttend.Text);
            } else
            {
                daysMissed = 0;
            }
            String gender = AddGender.Text;
            String race = raceBox.Text;
            String curStudent = AddCurrent.Text;
            DateTime date = DateTime.Now;
            String year = date.Year.ToString();
            String month = date.Month.ToString();
            String day = date.Day.ToString();
            String curDay = year + '-' + month + '-' + day;

            Model.InsertStudent(firstName, lastName, studentID, gpa, school, grade, numRefs, daysMissed, gender, race, curStudent, curDay, curDay);
            Model.InsertAttends(curDay, studentID, school);
            Model.InsertCumGPA(studentID, (float)gpa, curDay);
            Model.InsertEmptyReferrals(studentID, curDay, numRefs);
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void addSchool_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddCurrent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddGPA_TextChanged(object sender, EventArgs e)
        {

        }

        private void addFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
