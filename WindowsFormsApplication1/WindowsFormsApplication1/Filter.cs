using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApplication1
{
    public partial class Filter : Form
    {
        public Filter()
        {
            InitializeComponent();
            GPA1.Text = Model.getMinGPA() + "";
            GPA2.Text = Model.getMaxGPA() + "";
            UnCumGrade1.Text = Model.getMinClassGrade() + "";
            UnCumGrade2.Text = Model.getMaxClassGrade() + "";
            Grade1.Text = Model.getMinGrade() + "";
            Grade2.Text = Model.getMaxGrade() + "";
            Behavior1.Text = Model.getMinReferrals() + "";
            Behavior2.Text = Model.getMaxReferrals() + "";
            Attend1.Text = Model.getMinDaysMissed() + "";
            Attend2.Text = Model.getMaxDaysMissed() + "";

            List<string> classes = Model.getClasses();
            classes.Insert(0, "all");

            List<string> genders = Model.getGenders();
            genders.Insert(0, "all");

            List<string> schools = Model.getSchools();
            schools.Insert(0, "all");

            List<string> races = Model.getRaces();
            races.Insert(0, "all");

            List<string> isCurrents = Model.getCurrentStudentOptions();
            isCurrents.Insert(0, "all");

            UnCumClass.DataSource = classes;
            Gender.DataSource = genders;
            School.DataSource = schools;
            Race.DataSource = races;
            Current.DataSource = isCurrents;

               
            Gender.DropDownStyle = ComboBoxStyle.DropDownList;
            School.DropDownStyle = ComboBoxStyle.DropDownList;
            Race.DropDownStyle = ComboBoxStyle.DropDownList;
            Current.DropDownStyle = ComboBoxStyle.DropDownList;
            UnCumClass.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void Submit_Click(object sender, EventArgs e)
        {
            float minGPA = float.Parse(GPA1.Text);
            float maxGPA = float.Parse(GPA2.Text);
            int minGrade = Int32.Parse(UnCumGrade1.Text);
            int maxGrade = Int32.Parse(UnCumGrade2.Text);
            int minGradeLevel = Int32.Parse(Grade1.Text);
            int maxGradeLevel = Int32.Parse(Grade2.Text);
            int minBehavior = Int32.Parse(Behavior1.Text);
            int maxBehavior = Int32.Parse(Behavior2.Text);
            int minAttendance = Int32.Parse(Attend1.Text);
            int maxAttendance = Int32.Parse(Attend2.Text);

            List<string> genders = new List<string>();
            if (Gender.GetItemText(Gender.SelectedItem).Equals("all"))
            {
                genders =  (List<string>) Gender.DataSource;
                genders.RemoveAt(0);
            } else {
                genders.Add(Gender.GetItemText(Gender.SelectedItem));
            }

            List<string> classes = new List<string>();
            if (UnCumClass.GetItemText(UnCumClass.SelectedItem).Equals("all"))
            {
                classes = (List<string>)UnCumClass.DataSource;
                classes.RemoveAt(0);

            }
            else
            {
                classes.Add(UnCumClass.GetItemText(UnCumClass.SelectedItem));
            }

            List<string> schools = new List<string>();
            if (School.GetItemText(School.SelectedItem).Equals("all"))
            {
                schools = (List<string>)School.DataSource;
                schools.RemoveAt(0);

            }
            else
            {
                schools.Add(School.GetItemText(School.SelectedItem));
            }

            List<string> races = new List<string>();
            if (Race.GetItemText(Race.SelectedItem).Equals("all"))
            {
                races = (List<string>)Race.DataSource;
                races.RemoveAt(0);

            }
            else
            {
                races.Add(Race.GetItemText(Race.SelectedItem));
            }
            List<string> statuses = new List<string>();
            if (Current.GetItemText(Current.SelectedItem).Equals("all"))
            {
                statuses = (List<string>)Current.DataSource;
                statuses.RemoveAt(0);

            }
            else
            {
                statuses.Add(Current.GetItemText(Current.SelectedItem));
            }

            List<string>[] selectedVals= Model.filterSelectStudent(minGPA, maxGPA, schools, minGradeLevel, maxGradeLevel, minBehavior, maxBehavior, minAttendance, maxAttendance, genders, races, statuses, minGrade, maxGrade, classes);

            Excel.Application oXL;
            Excel._Workbook oWB;
            Excel._Worksheet oSheet;
            Excel.Range oRng;

            
            try
            {
                //Start Excel and get Application object.
                oXL = new Excel.Application();
                oXL.Visible = false;

                //Get a new workbook. Set up worksheets
                oWB = (Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
                oSheet = (Excel._Worksheet)oWB.ActiveSheet;
                
                //oSheet = (Excel.Worksheet)oWB.Worksheets.Add();
                oSheet.Name = "Selected Students";

                //Add table headers going cell by cell.
                oSheet.Cells[1, 1] = "ID";
                oSheet.Cells[1, 2] = "First Name";
                oSheet.Cells[1, 3] = "Last Name";
                oSheet.Cells[1, 4] = "Grade Level";
                oSheet.Cells[1, 5] = "Grade Modified Date";
                oSheet.Cells[1, 6] = "Registration Date";
                oSheet.Cells[1, 7] = "Gender";
                oSheet.Cells[1, 8] = "Race";
                oSheet.Cells[1, 9] = "Current?";
                oSheet.Cells[1, 10] = "Days Missed";
                oSheet.Cells[1, 11] = "GPA";
                oSheet.Cells[1,12] = "GPA Entry Date";
                oSheet.Cells[1,13] = "Start Date";
                oSheet.Cells[1,14] = "End Date";
                oSheet.Cells[1,15] = "School Name";
                oSheet.Cells[1,16] = "Referral Count";

                //Format A1:P1 as bold, vertical alignment = center.
                oSheet.get_Range("A1", "P1").Font.Bold = true;
                oSheet.get_Range("A1", "P1").VerticalAlignment =
                    Excel.XlVAlign.xlVAlignCenter;

                // Create an array to multiple values at once.
                string[] toPrint = new string[selectedVals.Count()];


                for (int i = 0; i < selectedVals.Count(); i = i + 1)
                {
                    for (int j = 0; j < selectedVals[i].Count(); j++)
                    {
                        toPrint[i] = selectedVals[i][j];
                    }
                }


                //Fill A2:B6 with an array of values (First and Last Names).
                oSheet.get_Range("A2", "P2").Value2 = toPrint;

                //AutoFit columns A:P.
                oRng = oSheet.get_Range("A1", "P1");
                oRng.EntireColumn.AutoFit();



                

                //Make sure Excel is visible and give the user control
                //of Microsoft Excel's lifetime.
                oXL.Visible = true;
                oXL.UserControl = true;
            }
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                MessageBox.Show(errorMessage, "Error");
            }

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Filter_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UnCumClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
