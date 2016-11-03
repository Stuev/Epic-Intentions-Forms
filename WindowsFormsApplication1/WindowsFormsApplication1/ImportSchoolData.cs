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
                oSheet = (Excel.Worksheet)oWB.Worksheets.Add();
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

                rows = oSheet.Rows.Count;

                for (int r = 2; r <= rows; r++)
                {

                    try
                    {
                        studentID = oRng.Cells[r, 1].Value2 + "";
                    }
                    catch
                    {
                        oWB.Close(false);
                        MessageBox.Show("Something went wrong in reading the student ID. Please try again. Make sure there is a number in the cell.");
                        this.Close();
                        return;
                    }
                    firstName = oRng.Cells[r, 2].Value2 + "";
                    lastName = oRng.Cells[r, 3].Value2 + "";
                    gender = oRng.Cells[r, 4].Value2 + "";
                    race = oRng.Cells[r, 5].Value2 + "";
                    try
                    {
                        gpa = float.Parse((string)oRng.Cells[r, 6]);
                    }
                    catch
                    {
                        try
                        {
                            gpa = float.Parse((string)oRng.Cells[r, 7]);
                            gpa = gpa / 25;
                        }
                        catch
                        {
                            ;
                        }
                    }
                    gradeMod = oRng.Cells[r, 8].Value2 + "";
                    if (gradeMod.Equals(""))
                    {
                        DateTime date = DateTime.Now;
                        String year = date.Year.ToString();
                        String month = date.Month.ToString();
                        String day = date.Day.ToString();
                        String gradeMod = year + '-' + month + '-' + day;
                    }
                    daysAbsent = int.Parse((string)oRng.Cells[r, 9]);
                    numRefs = int.Parse((string)oRng.Cells[r, 10]);
                    school = oRng.Cells[r, 11].Value2 + "";
                    regDate = oRng.Cells[r, 12].Value2 + "";
                    grade = int.Parse((string)oRng.Cells[r, 13]);

                    students = getStudentIDs();
                    for (String s : students)
                    {
                        if (s.Equals(studentID))
                        {
                            //update data
                        }
                        else
                        {
                            //add new student
                            Model.InsertStudent(firstName, lastName, studentID, gpa, school, grade, numRefs,
                                daysAbsent, gender, race, "yes");
                        }
                    }
                }
               
            } catch (Exception ex)
            {
                string errorMessage;
                errorMessage = "Error: ";
                errorMessage = string.Concat(errorMessage, ex.Message);
                errorMessage = string.Concat(errorMessage, " Line: ");
                errorMessage = string.Concat(errorMessage, ex.Source);

                //oWB.Close(false);

                MessageBox.Show(errorMessage, "Error");
            }
            }
    }
}
