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
    public partial class AddUnCumGPA : Form
    {
        public AddUnCumGPA()
        {
            InitializeComponent();

            var dataSource = new List<string>();
            dataSource.Add("Math");
            dataSource.Add("Science");
            dataSource.Add("Social Studies");
            dataSource.Add("Language Arts");
            dataSource.Add("Elective");
            dataSource.Add("Other");

            classNameDrop.DataSource = dataSource;
            classNameDrop.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Submit_AddUnCummGPA_Click(object sender, EventArgs e)
        {
            int studentID;
            try
            {
                studentID = int.Parse(ID_AddUnCummGPA.Text);
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
                GPA = float.Parse(Grade_AddUnCummGPA.Text);
            }
            catch
            {
                MessageBox.Show("Please make sure a number is in the GPA field!");
                return;
            }
            string unCumGPA = GPA + "";

            if (GPA > 100 || GPA < 0)
            {
                MessageBox.Show("Please make sure GPA is between 0 and 100!");
                return;
            }

            DateTime date = DateTime.Now;
            string year = date.Year.ToString();
            string month = date.Month.ToString();
            string day = date.Day.ToString();
            string curDay = year + '-' + month + '-' + day;

            string className = classNameDrop.Text;

            if (Model.InsertUnCumGPA(ID, unCumGPA, curDay, className))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong in processing the GPA. Please try again.");
            }

        }

        private void AddUnCumGPA_Load(object sender, EventArgs e)
        {

        }

        private void classNameDrop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
