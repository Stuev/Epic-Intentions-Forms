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
    public partial class PastStudent : Form
    {
        public PastStudent()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void PastStudentSubmit_Click(object sender, EventArgs e)
        {
            string ID = "";
            int n;
            if (PastStudentID.Text == "")
            {
                if (PastStudentLastName.Text == "" || PastStudentFirstName.Text == "")
                {
                    MessageBox.Show("Please type in a Student ID or a First and Last Name!");
                    return;
                }
                else
                {
                    if (PastStudentLastName.Text.Contains(";") || PastStudentFirstName.Text.Contains(";"))
                    {
                        MessageBox.Show("Invalid character in student name!");
                        return;
                    }
                    else if (PastStudentLastName.Text.Contains('"') || PastStudentFirstName.Text.Contains('"'))
                    {
                        MessageBox.Show("Invalid character in student name!");
                        return;
                    }
                    ID = Model.FindIDFromName(PastStudentFirstName.Text, PastStudentLastName.Text);
                }
            }
            else
            {
                ID = PastStudentID.Text;
            }

            if (ID != "" && int.TryParse(ID, out n))
            {
                List<string>[] studentList = Model.SelectStudent(ID);
                if (studentList[0].Count() < 1)
                {
                    MessageBox.Show("Student ID not Found!");
                    return;
                }

                bool cur;

                if (studentList[8][0] == "True") { cur = true; }
                else { cur = false; }

                if (cur)
                {
                    DateTime date = DateTime.Now;
                    string year = date.Year.ToString();
                    string month = date.Month.ToString();
                    string day = date.Day.ToString();
                    string curDay = year + '-' + month + '-' + day;

                    string Reason = PastReason.Text;
                    if (Reason == "")
                    {
                        Reason = "[Description Missing]";
                    }

                    if (Model.InsertPast(ID, Reason, curDay))
                    {
                        Model.SetStudentStatusPast(ID);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong in processing the Request. Please try again.");
                    }
                }
                else
                {
                    MessageBox.Show("Student is already an alumni!");
                }

            }
            else
            {
                MessageBox.Show("Information Provided is Not Correct!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID = "";
            int n;
            if (PastStudentID.Text == "")
            {
                if (PastStudentLastName.Text == "" || PastStudentFirstName.Text == "")
                {
                    MessageBox.Show("Please type in a Student ID or a First and Last Name!");
                    return;
                }
                else
                {
                    if (PastStudentLastName.Text.Contains(";") || PastStudentFirstName.Text.Contains(";"))
                    {
                        MessageBox.Show("Invalid character in student name!");
                        return;
                    }
                    else if (PastStudentLastName.Text.Contains('"') || PastStudentFirstName.Text.Contains('"'))
                    {
                        MessageBox.Show("Invalid character in student name!");
                        return;
                    }
                    ID = Model.FindIDFromName(PastStudentFirstName.Text, PastStudentLastName.Text);
                }
            }
            else
            {
                ID = PastStudentID.Text;
            }

            if (ID != "" && int.TryParse(ID, out n))
            {
                List<string>[] studentList = Model.SelectStudent(ID);
                if (studentList[0].Count() < 1)
                {
                    MessageBox.Show("Student ID not Found!");
                    return;
                }

                bool cur;

                if (studentList[8][0] == "True") { cur = true; }
                else { cur = false; }

                if (!cur)
                {
                    Model.SetStudentStatusCurrent(ID);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Student is already current!");
                }

            }
            else
            {
                MessageBox.Show("Information Provided is Not Correct!");
            }
        }
    }
}
