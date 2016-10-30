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
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ViewFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ViewSubmit_Click(object sender, EventArgs e)
        {
            string ID = "";
            int n;
            if (ViewID.Text == "")
            {
                if (ViewLastName.Text == "" || ViewFirstName.Text == "")
                {
                    MessageBox.Show("Please type in a Student ID or a First and Last Name!");
                    return;
                }
                else
                {
                    if(ViewLastName.Text.Contains(";") || ViewFirstName.Text.Contains(";"))
                    {
                        MessageBox.Show("Semicolons are not a valid character in student names");
                        return;
                    }
                    ID = Model.FindIDFromName(ViewFirstName.Text, ViewLastName.Text);
                }
            }
            else
            {
                ID = ViewID.Text;
            }

            if (ID != "" && int.TryParse(ID, out n))
            {
                List<string>[] studentList = Model.SelectStudent(ID);
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
                        oXL.Visible = true;

                        //Get a new workbook.
                        oWB = (Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
                        oSheet = (Excel._Worksheet)oWB.ActiveSheet;

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
                        string[] saNames = new string[10];


                        for (int i = 0; i < studentList.Count(); i = i + 1)
                        {
                            saNames[i] = studentList[i][0];
                        }

                        //Fill A2:B6 with an array of values (First and Last Names).
                        oSheet.get_Range("A2", "J2").Value2 = saNames;

                        //AutoFit columns A:D.
                        oRng = oSheet.get_Range("A1", "J1");
                        oRng.EntireColumn.AutoFit();

                        //Manipulate a variable number of columns for Quarterly Sales Data.
                        //DisplayQuarterlySales(oSheet);

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
                else
                {
                    MessageBox.Show("ID Provided is Not Correct!");
                }
            }
            else
            {
                MessageBox.Show("Information Provided is Not Correct!");
            }
        }
    }
}
