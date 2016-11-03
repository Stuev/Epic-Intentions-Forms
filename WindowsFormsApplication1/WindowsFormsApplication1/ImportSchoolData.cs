using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.IO;



namespace WindowsFormsApplication1
{
    public partial class ImportSchoolData : Form
    {

        private int rows;
        private int columns;
        private int studentID;
        private string firstName;
        private string lastName;
        private string gender;
        private string race;
        private float gpa;
        private string gradeMod;
        private int daysAbsent;
        private int numRefs;
        private string school;
        private string regDate;
        private int grade;
        private List<String> students;


        public ImportSchoolData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
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
                oSheet.Name = "Basic Information";

             
                //Make sure Excel is visible and give the user control
                //of Microsoft Excel's lifetime.

                oXL.DisplayAlerts = false;
                if (File.Exists("ImportData.xlsx"))
                {
                    File.Delete("ImportData.xlsx");
                }

                oWB.SaveAs("ImportData.xlsx");

                oXL.DisplayAlerts = true;
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

                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            }

        private void subButton_Click(object sender, EventArgs e)
        {
            Excel.Application oXL;
            Excel._Workbook oWB;
            Excel._Worksheet oSheet;
            Excel.Range oRng;


            try
            {
                //Start Excel and get Application object.
                oXL = new Excel.Application();
                oXL.Visible = false;


                oWB = oXL.Workbooks.Open("ImportData.xlsx");
                oSheet = (Excel._Worksheet)oWB.Sheets[1];
                oRng = oSheet.UsedRange;

                rows = oRng.Rows.Count;
                for (int r = 2; r <= rows; r++)
                {

                    try
                    {
                        studentID = int.Parse(oSheet.Cells[r, 1]);
                    }
                    catch
                    {
                        oWB.Close(false);
                        MessageBox.Show((string) oSheet.Cells[r, 1]);
                        //MessageBox.Show("There is an error in the Student ID. Please make sure there is a number.");
                        this.Close();
                        return;
                    }
                    firstName = oSheet.Cells[r, 2] + "";
                    lastName = oSheet.Cells[r, 3] + "";
                    gender = oSheet.Cells[r, 4] + "";
                    race = oSheet.Cells[r, 5] + "";
                    try
                    {
                        gpa = float.Parse((string)oSheet.Cells[r, 6]);
                    }
                    catch
                    {
                        try
                        {
                            gpa = float.Parse((string)oSheet.Cells[r, 7]);
                            gpa = gpa / 25;
                        }
                        catch
                        {
                            ;
                        }
                    }
                    gradeMod = oSheet.Cells[r, 8] + "";
                    if (gradeMod.Equals(""))
                    {
                        DateTime date = DateTime.Now;
                        String year = date.Year.ToString();
                        String month = date.Month.ToString();
                        String day = date.Day.ToString();
                        String gradeMod = year + '-' + month + '-' + day;
                    }
                    daysAbsent = int.Parse((string)oSheet.Cells[r, 9]);
                    numRefs = int.Parse((string)oSheet.Cells[r, 10]);
                    school = oSheet.Cells[r, 11] + "";
                    regDate = oSheet.Cells[r, 12] + "";
                    grade = int.Parse((string)oSheet.Cells[r, 13]);

                    students = Model.getStudentIDs();
                    foreach (String s in students)
                    {
                        if (s.Equals(studentID))
                        {
                            //update data
                            try
                            {
                                Model.UpdateStudentTable(studentID.ToString(), grade.ToString(), gradeMod, regDate, gender, race, daysAbsent.ToString());
                            } catch
                            {
                                MessageBox.Show("SQL update didn't work");

                            }
                        }
                        else
                        {
                            //add new student
                            try
                            {
                                Model.InsertStudent(firstName, lastName, studentID, gpa, school, grade, numRefs,
                                    daysAbsent, gender, race, "yes");
                            } catch
                            {
                                MessageBox.Show("sql insert didn't work");
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                string errorMessage;
                errorMessage = "Error: ";
                errorMessage = string.Concat(errorMessage, ex.Message);
                errorMessage = string.Concat(errorMessage, " Line: ");
                errorMessage = string.Concat(errorMessage, ex.Source);

                //oWB.Close(false);

                MessageBox.Show(errorMessage, "Error");
            }
            this.Close();
        }
    }
}
