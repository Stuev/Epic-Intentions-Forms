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
using System.Globalization;

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

            int test = 0;
            int r = 0;
            try
            {
                //Start Excel and get Application object.
                oXL = new Excel.Application();
                oXL.Visible = false;

                
                oWB = oXL.Workbooks.Open("ImportData.xlsx");
                oSheet = (Excel._Worksheet)oWB.ActiveSheet;
                oRng = oSheet.UsedRange;

                rows = oRng.Rows.Count;
                for (r = 2; r <= rows; r++)
                {
                    try
                    {
                    //studentID = oRng.Cells[r, 1] + "";
                    studentID = int.Parse(oRng.Cells[r, 1].Value.ToString());
                    }
                    catch
                    {
                        oWB.Close(false);
                        //MessageBox.Show("error");
                        MessageBox.Show("There is an error in the Student ID. Please make sure there is a number.");
                        this.Close();
                        return;
                    }
                    test = 1;
                    students = Model.getStudentIDs();
                    bool isAlreadyStudent = false;
                    foreach (string a in students)
                    {
                        if (a.TrimStart('0').Equals(studentID.ToString()))
                        {
                            isAlreadyStudent = true;
                        }
                    }
                    if (isAlreadyStudent)
                    {
                        ;
                    } else { 
                        try
                        {
                            firstName = oSheet.Cells[r, 2].Value.ToString();
                        }
                        catch
                        {
                            MessageBox.Show("Please provide a first name");
                            return;
                        }
                        try
                        {
                            lastName = oSheet.Cells[r, 3].Value.ToString();
                        }
                        catch
                        {
                            MessageBox.Show("Please provide a last name");
                            return;
                        }
                    }
                    try
                    {
                        gender = oSheet.Cells[r, 4].Value.ToString();
                    } catch
                    {
                        gender = " ";
                    }
                    try
                    {
                        race = oSheet.Cells[r, 5].Value.ToString();
                    } catch
                    {
                        race = " ";
                    }
                    try
                    {
                        gpa = float.Parse((string)oSheet.Cells[r, 6].Value.ToString());
                    }
                    catch
                    {
                        try
                        {
                            gpa = float.Parse((string)oSheet.Cells[r, 7].Value.ToString());
                            gpa = Model.convertGPA(gpa);
                        }
                        catch
                        {
                            gpa = 0;
                        }
                    }
                try
                {
                    string gradeDate = oRng.Cells[r, 8].Value.ToString();
                    string[] gradeDate2 = gradeDate.Split(' ');
                    gradeDate = gradeDate2[0];
                    gradeDate2 = gradeDate.Split('/');
                    string month = gradeDate2[0];
                    string day = gradeDate2[1];
                    string year = gradeDate2[2];
//                double d = double.Parse((string) oRng.Cells[r, 8].Value.ToString());
 //                       MessageBox.Show(d.ToString() + "grademod");
 //                   DateTime conv = DateTime.FromOADate(d);
                    //String year = conv.Year.ToString();
                    //String month = conv.Month.ToString();
                    //String day = conv.Day.ToString();
                    gradeMod = year + '-' + month + '-' + day;
                } 
                catch
                {
                    DateTime date = DateTime.Now;
                    String year = date.Year.ToString();
                    String month = date.Month.ToString();
                    String day = date.Day.ToString();
                    gradeMod = year + '-' + month + '-' + day;
                }
                    try
                    {
                        daysAbsent = int.Parse((string)oSheet.Cells[r, 9].Value.ToString());
                    } catch
                    {
                        daysAbsent = 0;
                    }
                    try
                    {
                        numRefs = int.Parse((string)oSheet.Cells[r, 10].Value.ToString());
                    } catch
                    {
                        numRefs = 0;
                    }
                    try
                    {
                        school = oSheet.Cells[r, 11].Value.ToString();
                    } catch
                    {
                        school = " ";
                    }                   
                    
                    String y = "";
                    String m = "";
                    String da = "";
                try
                {
                    string gradeDate = oRng.Cells[r, 12].Value.ToString();
                    string[] gradeDate2 = gradeDate.Split(' ');
                    gradeDate = gradeDate2[0];
                    gradeDate2 = gradeDate.Split('/');
                    m = gradeDate2[0];
                    da = gradeDate2[1];
                    y = gradeDate2[2];
                    regDate = y + '-' + m + '-' + da;
                }
                catch
                {
                    DateTime date = DateTime.Now;
                    String year = date.Year.ToString();
                    String month = date.Month.ToString();
                    String day = date.Day.ToString();
                    gradeMod = year + '-' + month + '-' + day;
                }
                    try
                    {
                        grade = int.Parse((string)oSheet.Cells[r, 13].Value.ToString());
                    } catch
                    {
                        grade = 0;
                    }
                    students = Model.getStudentIDs();
                    isAlreadyStudent = false;
                    foreach (string a in students)
                    {
                        if (a.TrimStart('0').Equals(studentID.ToString()))
                        {
                            isAlreadyStudent = true;
                        }
                    }
                    if (isAlreadyStudent)
                    {
                        try
                        {
                            Model.UpdateStudentTable(studentID.ToString(), grade.ToString(), gradeMod, regDate, gender, race, daysAbsent.ToString());
                            Model.InsertCumGPA(studentID, gpa, gradeMod);
                            DateTime date = DateTime.Now;
                            String year = date.Year.ToString();
                            String month = date.Month.ToString();
                            String day = date.Day.ToString();
                            string curDate = year + '-' + month + '-' + day;
                            Model.InsertEmptyReferrals(studentID, curDate, numRefs);
                        }
                        catch
                        {
                            MessageBox.Show("SQL update didn't work");
                            oWB.Close(false);
                        }
                    } else
                    {
                        try
                        {
                            Model.InsertStudent(firstName, lastName, studentID, gpa, school, grade, numRefs,
                                daysAbsent, gender, race, "yes", regDate, gradeMod);
                            DateTime date = DateTime.Now;
                            String year = date.Year.ToString();
                            String month = date.Month.ToString();
                            String day = date.Day.ToString();
                            string curDate = year + '-' + month + '-' + day;
                            List<String> schools = Model.getSchools();
                            if (!schools.Contains(school))
                            {
                                Model.InsertSchool(school);
                            }
                            Model.InsertAttends(curDate, studentID, school);
                            Model.InsertCumGPA(studentID, gpa, gradeMod);
                            Model.InsertEmptyReferrals(studentID, curDate, numRefs);
                        }
                        catch
                        {
                            MessageBox.Show("sql insert didn't work");
                            oWB.Close(false);
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
                errorMessage = string.Concat(errorMessage, ex.StackTrace);

                MessageBox.Show(errorMessage);
                //oWB.Close(false);
            }
            this.Close();
        }
    }
}
