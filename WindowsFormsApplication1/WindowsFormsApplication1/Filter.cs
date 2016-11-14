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

            List<string> isCurrents = new List<string>();
            isCurrents.Add("all");
            isCurrents.Add("yes");
            isCurrents.Add("no");


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
            float minGPA = -1;
            if (checkBox1.Checked) {
                try
                {
                    minGPA = float.Parse(GPA1.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Input for minimum GPA must be a number");
                    return;
                }
            }

            float maxGPA;
            try
            {
                maxGPA = float.Parse(GPA2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input for maximum GPA must be a number");
                return;
            }

            float minGrade = -1;
            if (checkBox2.Checked)
            {
                try
                {
                    minGrade = float.Parse(UnCumGrade1.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Input for minimum class grade must be a number");
                    return;
                }

            }

            float maxGrade;
            try
            {
                maxGrade = float.Parse(UnCumGrade2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input for maximum class grade must be a number");
                return;
            }

            int minGradeLevel;
            try
            {
                minGradeLevel = Int32.Parse(Grade1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input for minimum grade level must be a number");
                return;
            }

            int maxGradeLevel;
            try
            {
                maxGradeLevel = Int32.Parse(Grade2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input for maximum grade level must be a number");
                return;
            }

            int minBehavior;
            try
            {
                minBehavior = Int32.Parse(Behavior1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input for minimum referrals level must be a number");
                return;
            }

            int maxBehavior;
            try
            {
                maxBehavior = Int32.Parse(Behavior2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input for maximum referrals level must be a number");
                return;
            }

            int minAttendance;
            try
            {
                minAttendance = Int32.Parse(Attend1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input for minimum missed attendance must be a number");
                return;
            }

            int maxAttendance;
            try
            {
                maxAttendance = Int32.Parse(Attend2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input for maximum missed attendance must be a number");
                return;
            }

            List<string> genders = new List<string>();
            if (Gender.GetItemText(Gender.SelectedItem).Equals("all"))
            {
                genders = Model.getGenders();
            } else {
                genders.Add(Gender.GetItemText(Gender.SelectedItem));
            }

            List<string> classes = new List<string>();
            if (UnCumClass.GetItemText(UnCumClass.SelectedItem).Equals("all"))
            {
                classes = Model.getClasses();

            }
            else
            {
                classes.Add(UnCumClass.GetItemText(UnCumClass.SelectedItem));
            }

            List<string> schools = new List<string>();
            if (School.GetItemText(School.SelectedItem).Equals("all"))
            {
                schools = Model.getSchools();

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
                statuses = new List<string>();
                statuses.Add("1");
                statuses.Add("0");

            }
            else if (Current.GetItemText(Current.SelectedItem).Equals("yes"))
            {
                statuses = new List<string>();
                statuses.Add("1");
            }
            else
            {
                statuses = new List<string>();
                statuses.Add("0");
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
                oSheet.Cells[1, 11] = "Cumulative GPA";
                oSheet.Cells[1,12] = "GPA Entry Date";
                oSheet.Cells[1,13] = "Start Date";
                oSheet.Cells[1,14] = "End Date";
                oSheet.Cells[1,15] = "School Name";
                oSheet.Cells[1,16] = "Referral Count";
                oSheet.Cells[1,17] = "Grade Level";
                oSheet.Cells[1,18] = "Class";
                oSheet.Cells[1, 19] = "Grade in Class";
                oSheet.Cells[1, 20] = "Grade Entry Date";

                //Format A1:P1 as bold, vertical alignment = center.
                oSheet.get_Range("A1", "T1").Font.Bold = true;
                oSheet.get_Range("A1", "T1").VerticalAlignment =
                    Excel.XlVAlign.xlVAlignCenter;


                string[] toPrint = new string[selectedVals.Count()];


                for (int j = 0; j < selectedVals[0].Count(); j++)
                {
                    int k = j + 2;
                    for (int i = 0; i < selectedVals.Count(); i = i + 1)
                    {
                        if ((i == 20 || i == 10) && selectedVals[i][j] == null)
                        {
                            toPrint[i] = "DNE";
                        }
                        else
                        {
                            toPrint[i] = selectedVals[i][j];

                        }
                    }
                    //Fill with an array of values (First and Last Names).
                    oSheet.get_Range("A" + k, "T" + k).Value2 = toPrint;
                }

                /*
                // Create an array to multiple values at once.
                string[][] toPrint = new string[selectedVals.Count()][];


                for (int i = 0; i < selectedVals.Count(); i = i + 1)
                {
                    toPrint[0] = new string[selectedVals[i].Count()]; 

                    for (int j = 0; j < selectedVals[i].Count(); j++)
                    {
                        toPrint[i][j] = selectedVals[i][j];
                    }
                }
                


                //Fill A2:B6 with an array of values (First and Last Names).
                for (int i = 0; i < toPrint[0].Count(); i++)
                {
                    oSheet.get_Range("A" + (i + 2), "T" + (i + 2)).Value2 = toPrint[i];

                }
                */
                //AutoFit columns A:P.
                oRng = oSheet.get_Range("A1", "T1");
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

        private void GPA1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox2.Checked)
            {
                UnCumClass.Visible = false;
                UnCumGrade1.Visible = false;
                UnCumGrade2.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                checkBox2.Text = "Filter by class?";
            }
            else
            {
                UnCumClass.Visible = true;
                UnCumGrade1.Visible = true;
                UnCumGrade2.Visible = true;
                label24.Visible = true;
                label25.Visible = true;
                checkBox2.Text = "";

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                label5.Visible = false;
                label6.Visible = false;
                GPA1.Visible = false;
                GPA2.Visible = false;
                checkBox1.Text = "Filter by GPA?";
            }
            else
            {
                label5.Visible = true;
                label6.Visible = true;
                GPA1.Visible = true;
                GPA2.Visible = true;
                checkBox1.Text = "";
            }
        }

        private void UnCumGrade2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UnCumGrade1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
    }
}
