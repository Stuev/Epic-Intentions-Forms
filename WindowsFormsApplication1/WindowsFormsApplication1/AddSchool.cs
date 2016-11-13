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
    public partial class AddSchool_ID : Form
    {
        public AddSchool_ID()
        {
            InitializeComponent();
            List<string> data = Model.getSchools();
            data.Add("Other");

            AddSchoolExistingSchool.DataSource = data;
            AddSchoolExistingSchool.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void AddSchool_Button_Click(object sender, EventArgs e)
        {
            int studentID;
            try
            {
                studentID = int.Parse(stID.Text);
            }
            catch
            {
                MessageBox.Show("Please make sure a number is in the ID field!");
                return;
            }

            string gradeDate;
            string endDate;

            if (AddSchool_StartDate.Text == "")
            {
                MessageBox.Show("Date Field is Empty!");
                return;
            }

            try
            {
                DateTime date = DateTime.Parse(AddSchool_StartDate.Text);
                string year = date.Year.ToString();
                string month = date.Month.ToString();
                string day = date.Day.ToString();
                gradeDate = year + "-" + month + "-" + day;
                date = date.AddDays(-1);
                year = date.Year.ToString();
                month = date.Month.ToString();
                day = date.Day.ToString();
                endDate = year + "-" + month + "-" + day;
            } catch
            {
                MessageBox.Show("Date Field is Incorrectly Formatted!");
                return;
            }

            if (AddSchoolNewSchool.Text == "" && AddSchoolExistingSchool.Text == "Other")
            {
                MessageBox.Show("New school field is Empty!");
                return;

            }
            string school;



            if (AddSchoolExistingSchool.Text == "Other")
            {
                school = AddSchoolNewSchool.Text;

                if (!Model.SchoolExists(school))
                {
                    Model.InsertSchool(school);
                }
                else
                {
                    MessageBox.Show("School already exists!");
                    return;
                }
            }
            else
            {
                school = AddSchoolExistingSchool.Text;
            }

            Model.UpdateCurSchoolToPast(studentID.ToString(), endDate);

            Model.InsertAttends(gradeDate, studentID, school);

            this.Close();

        }

        private void AddSchool_Load(object sender, EventArgs e)
        {

        }

        private void AddSchool_StartDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddSchoolNewSchool_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddSchoolExistingSchool_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
