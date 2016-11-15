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
    public partial class AddCumGPA : Form
    {
        public AddCumGPA()
        {
            InitializeComponent();
        }

        private void Submit_AddCumGPA_Click(object sender, EventArgs e)
        {
            int studentID;
            try
            {
                studentID = int.Parse(ID_AddCumGPA.Text);
            }
            catch
            {
                MessageBox.Show("Please make sure a number is in the ID field!");
                return;
            }
            string ID = studentID + "";

            float GPA;
            try
            {
                GPA = float.Parse(GPA_AddCumGPA.Text);
            }
            catch
            {
                MessageBox.Show("Please make sure a number is in the GPA field!");
                return;
            }
            string CumGPA = GPA + "";

            if (GPA > 4.0 || GPA < 0)
            {
                MessageBox.Show("Please make sure GPA is between 0 and 4.0!");
                return;
            }

            DateTime date = DateTime.Now;
            string year = date.Year.ToString();
            string month = date.Month.ToString();
            string day = date.Day.ToString();
            string curDay = year + '-' + month + '-' + day;

            if (Model.InsertCumGPA(ID, CumGPA, curDay))
            {
                Model.UpdateStudentTableGradeDate(ID, curDay);
                this.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong in processing the GPA. Please try again.");
            }

        }
    }
}
