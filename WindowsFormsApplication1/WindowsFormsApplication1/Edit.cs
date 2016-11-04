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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EditSubmit_Click(object sender, EventArgs e)
        {
            string ID = "";
            int n;
            if (EditID.Text == "")
            {
                if (EditLastName.Text == "" || EditFirstName.Text == "")
                {
                    MessageBox.Show("Please type in a Student ID or a First and Last Name!");
                    return;
                }
                else
                {
                    if (EditLastName.Text.Contains(";") || EditFirstName.Text.Contains(";"))
                    {
                        MessageBox.Show("Invalid character in student name!");
                        return;
                    }
                    else if (EditLastName.Text.Contains('"') || EditFirstName.Text.Contains('"'))
                    {
                        MessageBox.Show("Invalid character in student name!");
                        return;
                    }
                    ID = Model.FindIDFromName(EditFirstName.Text, EditLastName.Text);
                }
            }
            else
            {
                ID = EditID.Text;
            }

            if (ID != "" && int.TryParse(ID, out n))
            {
                List<string>[] studentList = Model.SelectStudent(ID);
                if (studentList[0].Count() < 1)
                {
                    MessageBox.Show("Student ID not Found!");
                    return;
                }
                List<string>[] cumGPAList = Model.SelectAllCumGPA(ID);
                List<string>[] unCumGPAList = Model.SelectAllUnCumGPA(ID);
                List<string>[] attendsList = Model.SelectAllAttend(ID);
                List<string>[] pastStudent = Model.SelectAllPast(ID);
                List<string>[] referralsList = Model.SelectAllReferral(ID);

                bool cur;
                if (studentList[8].Count() > 0)
                {
                    if (studentList[8][0] == "True") { cur = true; }
                    else { cur = false; }
                }
                else { cur = true; }

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
                    //oSheet.Cells[1, 1] = "ID";
                    oSheet.Cells[1, 2] = "First Name";
                    oSheet.Cells[1, 3] = "Last Name";
                    oSheet.Cells[1, 4] = "Grade Level";
                    oSheet.Cells[1, 5] = "Grade Modified Date";
                    oSheet.Cells[1, 6] = "Registration Date";
                    oSheet.Cells[1, 7] = "Gender";
                    oSheet.Cells[1, 8] = "Race";
                    //oSheet.Cells[1, 9] = "Current?";
                    oSheet.Cells[1, 10] = "Days Missed";

                    //Format A1:D1 as bold, vertical alignment = center.
                    oSheet.get_Range("A1", "J1").Font.Bold = true;
                    oSheet.get_Range("A1", "J1").VerticalAlignment =
                        Excel.XlVAlign.xlVAlignCenter;

                    // Create an array to multiple values at once.
                    string[] toPrint = new string[10];


                    for (int i = 1; i < studentList.Count(); i = i + 1)
                    {
                        if (i != 8) { toPrint[i] = studentList[i][0]; }
                    }

                    //Fill A2:B6 with an array of values (First and Last Names).
                    oSheet.get_Range("A2", "J2").Value2 = toPrint;

                    //AutoFit columns A:J.
                    oRng = oSheet.get_Range("A1", "J1");
                    oRng.EntireColumn.AutoFit();




                    oSheet = (Excel.Worksheet)oWB.Sheets[2];

                    //Add table headers going cell by cell.
                    //oSheet.Cells[1, 1] = "ID";
                    oSheet.Cells[1, 2] = "GPA";
                    //oSheet.Cells[1, 3] = "Entry Date";


                    //Format A1:D1 as bold, vertical alignment = center.
                    oSheet.get_Range("A1", "C1").Font.Bold = true;
                    oSheet.get_Range("A1", "C1").VerticalAlignment =
                        Excel.XlVAlign.xlVAlignCenter;

                    // Create an array to multiple values at once.
                    toPrint = new string[3];

                    if (cumGPAList[0].Count() > 0)
                    {
                        for (int j = 0; j < cumGPAList[0].Count(); j = j + 1)
                        {
                            int k = j + 2;
                            for (int i = 1; i < cumGPAList.Count() - 1; i = i + 1)
                            {
                                toPrint[i] = cumGPAList[i][j];
                            }
                            //Fill with an array of values (First and Last Names).
                            oSheet.get_Range("B" + k).Value2 = toPrint;
                        }
                    }

                    //Fill A2:B6 with an array of values (First and Last Names).
                    if (toPrint.Count() == 3)
                    {
                        oSheet.get_Range("A2", "C2").Value2 = toPrint;
                    }
                    oRng = oSheet.get_Range("A1", "J1");
                    oRng.EntireColumn.AutoFit();




                    oSheet = (Excel.Worksheet)oWB.Sheets[3];

                    //Add table headers going cell by cell.
                    //oSheet.Cells[1, 1] = "ID";
                    oSheet.Cells[1, 2] = "GPA";
                    //oSheet.Cells[1, 3] = "Entry Date";


                    //Format A1:D1 as bold, vertical alignment = center.
                    oSheet.get_Range("A1", "C1").Font.Bold = true;
                    oSheet.get_Range("A1", "C1").VerticalAlignment =
                        Excel.XlVAlign.xlVAlignCenter;

                    // Create an array to multiple values at once.
                    toPrint = new string[3];

                    if (unCumGPAList[0].Count() > 0)
                    {
                        for (int j = 0; j < unCumGPAList[0].Count(); j = j + 1)
                        {
                            int k = j + 2;
                            for (int i = 1; i < unCumGPAList.Count() - 1; i = i + 1)
                            {
                                toPrint[i] = unCumGPAList[i][j];
                            }
                            //Fill with an array of values (First and Last Names).
                            oSheet.get_Range("A" + k, "C" + k).Value2 = toPrint;
                        }
                    }

                    //Fill A2:B6 with an array of values (First and Last Names).
                    oRng = oSheet.get_Range("A1", "J1");
                    oRng.EntireColumn.AutoFit();




                    oSheet = (Excel.Worksheet)oWB.Sheets[4];

                    //Add table headers going cell by cell.
                    //oSheet.Cells[1, 1] = "ID";
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
                        for (int i = 1; i < attendsList.Count(); i = i + 1)
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
                    //oSheet.Cells[1, 1] = "ID";
                    //oSheet.Cells[1, 2] = "Referral Number";
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
                        for (int i = 2; i < referralsList.Count(); i = i + 1)
                        {
                            toPrint[i] = referralsList[i][j];
                        }
                        //Fill with an array of values (First and Last Names).
                        oSheet.get_Range("A" + k, "E" + k).Value2 = toPrint;
                    }

                    //Fill A2:B6 with an array of values (First and Last Names).
                    oRng = oSheet.get_Range("A1", "J1");
                    oRng.EntireColumn.AutoFit();

                    if (!cur)
                    {
                        oSheet = (Excel.Worksheet)oWB.Sheets[6];
                        oSheet.Name = "Past Student Information";


                        //Add table headers going cell by cell.
                        //oSheet.Cells[1, 1] = "ID";
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
                            for (int i = 1; i < pastStudent.Count(); i = i + 1)
                            {
                                toPrint[i] = pastStudent[i][j];
                            }
                            //Fill with an array of values (First and Last Names).
                            oSheet.get_Range("A" + k, "C" + k).Value2 = toPrint;
                        }

                        //Fill A2:B6 with an array of values (First and Last Names).
                        oRng = oSheet.get_Range("A1", "J1");
                        oRng.EntireColumn.AutoFit();
                    }


                    oXL.DisplayAlerts = false;
                    if (File.Exists("Editing.xlsx"))
                    {
                        File.Delete("Editing.xlsx");
                    }

                    oWB.SaveAs("Editing.xlsx");

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

                Hide();
                EditPart2 nextForm = new EditPart2(ID);
                nextForm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Information Provided is Not Correct!");
            }
        }
    }
}
