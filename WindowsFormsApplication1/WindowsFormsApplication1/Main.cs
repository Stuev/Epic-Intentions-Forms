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

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'epicintentionsDataSet.cum_gpa' table. You can move, or remove it, as needed.
            //this.cum_gpaTableAdapter.Fill(this.epicintentionsDataSet.cum_gpa);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewStudent nextForm = new AddNewStudent();
            nextForm.ShowDialog();
            this.Show();
        }

        private void FilterStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Filter nextForm = new Filter();
            nextForm.ShowDialog();
            this.Show();
        }

        private void EditStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit nextForm = new Edit();
            nextForm.ShowDialog();
            this.Show();
        }

        private void cum_gpaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.cum_gpaBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.epicintentionsDataSet);

        }

        private void ViewStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            View nextForm = new View();
            nextForm.ShowDialog();
            this.Show();
        }

        private void ViewAll_Click(object sender, EventArgs e)
        {
            List<string>[] studentList = Model.SelectAllStudents();
            List<string>[] cumGPAList = Model.SelectAllCumGPAS();
            List<string>[] unCumGPAList = Model.SelectAllUnCumGPAS();
            List<string>[] attendsList = Model.SelectAllAttends();
            List<string>[] pastStudent = Model.SelectAllPasts();
            List<string>[] referralsList = Model.SelectAllReferrals();

            Excel.Application oXL;
            Excel._Workbook oWB;
            Excel._Worksheet oSheet;
            Excel.Range oRng;

            if (studentList[0].Count != 0)
            {

                try
                {
                    //Start Excel and get Application object.
                    oXL = new Excel.Application();
                    oXL.Visible = false;

                    //Get a new workbook. Set up worksheets
                    oWB = (Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
                    oSheet = (Excel._Worksheet)oWB.ActiveSheet;
                    oSheet = (Excel.Worksheet)oWB.Worksheets.Add();
                    oSheet.Name = "Referrals";
                    oSheet = (Excel.Worksheet)oWB.Worksheets.Add();
                    oSheet.Name = "Schools Attended";
                    oSheet = (Excel.Worksheet)oWB.Worksheets.Add();
                    oSheet.Name = "UnCumulative GPA";
                    oSheet = (Excel.Worksheet)oWB.Worksheets.Add();
                    oSheet.Name = "Cumulative GPA";
                    oSheet = (Excel.Worksheet)oWB.Worksheets.Add();
                    oSheet.Name = "Basic Information";

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

                    //Format A1:D1 as bold, vertical alignment = center.
                    oSheet.get_Range("A1", "J1").Font.Bold = true;
                    oSheet.get_Range("A1", "J1").VerticalAlignment =
                        Excel.XlVAlign.xlVAlignCenter;

                    // Create an array to multiple values at once.
                    string[] toPrint = new string[10];


                    for (int j = 0; j < studentList[0].Count(); j = j + 1)
                    {
                        int k = j + 2;
                        for (int i = 0; i < studentList.Count(); i = i + 1)
                        {
                            toPrint[i] = studentList[i][j];
                        }
                        //Fill with an array of values (First and Last Names).
                        oSheet.get_Range("A" + k, "J" + k).Value2 = toPrint;
                    }

                    //AutoFit columns A:J.
                    oRng = oSheet.get_Range("A1", "J1");
                    oRng.EntireColumn.AutoFit();



                    oSheet = (Excel.Worksheet)oWB.Sheets[2];

                    //Add table headers going cell by cell.
                    oSheet.Cells[1, 1] = "ID";
                    oSheet.Cells[1, 2] = "GPA";
                    oSheet.Cells[1, 3] = "Entry Date";


                    //Format A1:D1 as bold, vertical alignment = center.
                    oSheet.get_Range("A1", "C1").Font.Bold = true;
                    oSheet.get_Range("A1", "C1").VerticalAlignment =
                        Excel.XlVAlign.xlVAlignCenter;

                    // Create an array to multiple values at once.
                    toPrint = new string[3];


                    for (int j = 0; j < cumGPAList[0].Count(); j = j + 1)
                    {
                        int k = j + 2;
                        for (int i = 0; i < cumGPAList.Count(); i = i + 1)
                        {
                            toPrint[i] = cumGPAList[i][j];
                        }
                        //Fill with an array of values (First and Last Names).
                        oSheet.get_Range("A" + k, "C" + k).Value2 = toPrint;
                    }

                    //Fill A2:B6 with an array of values (First and Last Names).
                    oRng = oSheet.get_Range("A1", "J1");
                    oRng.EntireColumn.AutoFit();



                    oSheet = (Excel.Worksheet)oWB.Sheets[3];

                    //Add table headers going cell by cell.
                    oSheet.Cells[1, 1] = "ID";
                    oSheet.Cells[1, 2] = "GPA";
                    oSheet.Cells[1, 3] = "Entry Date";


                    //Format A1:D1 as bold, vertical alignment = center.
                    oSheet.get_Range("A1", "C1").Font.Bold = true;
                    oSheet.get_Range("A1", "C1").VerticalAlignment =
                        Excel.XlVAlign.xlVAlignCenter;

                    // Create an array to multiple values at once.
                    toPrint = new string[3];


                    for (int j = 0; j < unCumGPAList[0].Count(); j = j + 1)
                    {
                        int k = j + 2;
                        for (int i = 0; i < unCumGPAList.Count(); i = i + 1)
                        {
                            toPrint[i] = unCumGPAList[i][j];
                        }
                        //Fill with an array of values (First and Last Names).
                        oSheet.get_Range("A" + k, "C" + k).Value2 = toPrint;
                    }

                    //Fill A2:B6 with an array of values (First and Last Names).
                    oRng = oSheet.get_Range("A1", "J1");
                    oRng.EntireColumn.AutoFit();




                    oSheet = (Excel.Worksheet)oWB.Sheets[4];

                    //Add table headers going cell by cell.
                    oSheet.Cells[1, 1] = "ID";
                    oSheet.Cells[1, 2] = "School";
                    oSheet.Cells[1, 3] = "Start Date";
                    oSheet.Cells[1, 4] = "End Date";

                    //Format A1:D1 as bold, vertical alignment = center.
                    oSheet.get_Range("A1", "D1").Font.Bold = true;
                    oSheet.get_Range("A1", "D1").VerticalAlignment =
                        Excel.XlVAlign.xlVAlignCenter;

                    // Create an array to multiple values at once.
                    toPrint = new string[4];


                    for (int j = 0; j < attendsList[0].Count(); j = j + 1)
                    {
                        int k = j + 2;
                        for (int i = 0; i < attendsList.Count(); i = i + 1)
                        {
                            toPrint[i] = attendsList[i][j];
                        }
                        //Fill with an array of values (First and Last Names).
                        oSheet.get_Range("A" + k, "D" + k).Value2 = toPrint;
                    }

                    //Fill A2:B6 with an array of values (First and Last Names).
                    oRng = oSheet.get_Range("A1", "J1");
                    oRng.EntireColumn.AutoFit();




                    oSheet = (Excel.Worksheet)oWB.Sheets[5];

                    //Add table headers going cell by cell.
                    oSheet.Cells[1, 1] = "ID";
                    oSheet.Cells[1, 2] = "Referral Number";
                    oSheet.Cells[1, 3] = "Referral Date";
                    oSheet.Cells[1, 4] = "Type";
                    oSheet.Cells[1, 5] = "Description";

                    //Format A1:D1 as bold, vertical alignment = center.
                    oSheet.get_Range("A1", "E1").Font.Bold = true;
                    oSheet.get_Range("A1", "E1").VerticalAlignment =
                        Excel.XlVAlign.xlVAlignCenter;

                    // Create an array to multiple values at once.
                    toPrint = new string[5];


                    for (int j = 0; j < referralsList[0].Count(); j = j + 1)
                    {
                        int k = j + 2;
                        for (int i = 0; i < referralsList.Count(); i = i + 1)
                        {
                            toPrint[i] = referralsList[i][j];
                        }
                        //Fill with an array of values (First and Last Names).
                        oSheet.get_Range("A" + k, "E" + k).Value2 = toPrint;
                    }

                    //Fill A2:B6 with an array of values (First and Last Names).
                    oRng = oSheet.get_Range("A1", "J1");
                    oRng.EntireColumn.AutoFit();


                    oSheet = (Excel.Worksheet)oWB.Sheets[6];
                    oSheet.Name = "Past Student Information";


                    //Add table headers going cell by cell.
                    oSheet.Cells[1, 1] = "ID";
                    oSheet.Cells[1, 2] = "Reason";
                    oSheet.Cells[1, 3] = "Leaving Date";

                    //Format A1:D1 as bold, vertical alignment = center.
                    oSheet.get_Range("A1", "C1").Font.Bold = true;
                    oSheet.get_Range("A1", "C1").VerticalAlignment =
                        Excel.XlVAlign.xlVAlignCenter;

                    // Create an array to multiple values at once.
                    toPrint = new string[3];

                    for (int j = 0; j < pastStudent[0].Count(); j = j + 1)
                    {
                        int k = j + 2;
                        for (int i = 0; i < pastStudent.Count(); i = i + 1)
                        {
                            toPrint[i] = pastStudent[i][j];
                        }
                        //Fill with an array of values (First and Last Names).
                        oSheet.get_Range("A" + k, "C" + k).Value2 = toPrint;
                    }

                    //Fill A2:B6 with an array of values (First and Last Names).
                    oRng = oSheet.get_Range("A1", "J1");
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
        }

        private void ImportData_Click(object sender, EventArgs e)
        {
            this.Hide();
            ImportSchoolData nextForm = new ImportSchoolData();
            nextForm.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddInfo nextForm = new AddInfo();
            nextForm.ShowDialog();
            this.Show();
        }

        private void PastStudents_Click(object sender, EventArgs e)
        {
            this.Hide();
            PastStudent nextForm = new PastStudent();
            nextForm.ShowDialog();
            this.Show();
        }
    }
}
