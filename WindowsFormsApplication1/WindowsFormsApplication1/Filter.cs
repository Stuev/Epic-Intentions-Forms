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
            Grade1.Text = Model.getMinGrade() + "";
            Grade2.Text = Model.getMaxGrade() + ""; ;
            Behavior1.Text = Model.getMinReferrals() + "";
            Behavior2.Text = Model.getMaxReferrals() + "";
            Attend1.Text = Model.getMinDaysMissed() + "";
            Attend2.Text = Model.getMaxDaysMissed() + "";
            UnCumGrade1.Text = Model.getMinUncumGPA() + "";
            UnCumGrade2.Text = Model.getMaxUncumGPA() + "";



            List<String> schools = Model.getSchools();
            schools.Add("All");
            List<String> genders = Model.getGenders();
            genders.Add("All");
            List<String> isCurrents = Model.getCurrentStudentOptions();
            isCurrents.Add("All");
            List<String> races = Model.getRaces();
            races.Add("All");
            List<String> courses = Model.getClasses();
            courses.Add("All");

            School.DataSource = schools;
            Gender.DataSource = genders;
            Race.DataSource = races;
            Current.DataSource = isCurrents;
            UnCumClass.DataSource = courses;

            Gender.DropDownStyle = ComboBoxStyle.DropDownList;
            School.DropDownStyle = ComboBoxStyle.DropDownList;
            Race.DropDownStyle = ComboBoxStyle.DropDownList;
            Current.DropDownStyle = ComboBoxStyle.DropDownList;
            UnCumClass.DropDownStyle = ComboBoxStyle.DropDownList; 
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            int minGPA = Int32.Parse(GPA1.Text);
            int maxGPA = Int32.Parse(GPA2.Text);
            int minGrade = Int32.Parse(Grade1.Text);
            int maxGrade = Int32.Parse(Grade2.Text);
            int minBehavior = Int32.Parse(Behavior1.Text);
            int maxBehavior = Int32.Parse(Behavior2.Text);
            int minAttendance = Int32.Parse(Attend1.Text);
            int maxAttendance = Int32.Parse(Attend2.Text);
            int minClassGrade = Int32.Parse(UnCumGrade1.Text);
            int maxClassGrade = Int32.Parse(UnCumGrade2.Text);
            List<string> genders = new List<string>();
            List<string> schools = new List<string>();
            List<string> races = new List<string>();
            List<string> statuses = new List<string>();
            List<string> courses = new List<string>();

            
           if (Gender.GetItemText(Gender.SelectedItem) == "All")
           {
               genders = Model.getGenders();
           } else
           {
               genders.Add(Gender.GetItemText(Gender.SelectedItem));
           }

           if (School.GetItemText(School.SelectedItem) == "All")
           {
               schools = Model.getSchools();
           } else
           {
               schools.Add(School.GetItemText(School.SelectedItem));
           }

           if (Race.GetItemText(Race.SelectedItem) == "All")
           {
               races = Model.getRaces();
           }
           else
           {
               races.Add(Race.GetItemText(Race.SelectedItem));
           }
           if (Current.GetItemText(Current.SelectedItem) == "All")
           {
               statuses = Model.getCurrentStudentOptions();
           } else
           {
               statuses.Add(Current.GetItemText(Current.SelectedItem));
           }
            if (UnCumClass.GetItemText(UnCumClass.SelectedItem) == "All")
            {
                courses = Model.getCourses();
            }
            else
            {
                courses.Add(UnCumClass.GetItemText(UnCumClass.SelectedItem));
            }
            List<string>[] selectedVals= Model.filterSelectStudent(minGPA, maxGPA, schools, minGrade, maxGrade, minBehavior, maxBehavior, minAttendance, maxAttendance, genders, races, statuses);

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
                oSheet.Cells[1, 17] = "Class";
                oSheet.Cells[1, 18] = "Class grade";

                //Format A1:P1 as bold, vertical alignment = center.
                oSheet.get_Range("A1", "R1").Font.Bold = true;
                oSheet.get_Range("A1", "R1").VerticalAlignment =
                    Excel.XlVAlign.xlVAlignCenter;

                // Create an array to multiple values at once.
                string[] toPrint = new string[selectedVals.Count()];
                System.Diagnostics.Debug.WriteLine("ok2");


                for (int i = 0; i < selectedVals.Count(); i = i + 1)
                {
                    for (int j = 0; j < selectedVals[i].Count(); j++)
                    {
                        toPrint[i] = selectedVals[i][j];
                    }
                }
                System.Diagnostics.Debug.WriteLine("ok3");


                //Fill A2:B6 with an array of values (First and Last Names).
                oSheet.get_Range("A2", "R2").Value2 = toPrint;

                //AutoFit columns A:P.
                oRng = oSheet.get_Range("A1", "R1");
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
    }
}
