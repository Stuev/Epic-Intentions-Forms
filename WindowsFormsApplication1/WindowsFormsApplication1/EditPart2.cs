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
    public partial class EditPart2 : Form
    {
        private string thisID;
        private string fileName = "Editing.xlsx";
        private string firstName;
        private string lastName;
        private int grade;
        private int daysMissed;
        private string gender;
        private string race;
        private string regDate;
        private string gradeMod;
        private float cumGPA;
        private string cumGPAEntry;
        private List<string> referrals;
        private List<string> refDate;
        private List<string> refType;
        private List<string> refDescr;
        private string pastReason;
        private string pastDate;
        private string attendsStartDate;
        private string attendsEndDate;
        private string attendsSchoolName;
        private List<float> unCumGPAs;
        private List<string> unCumGPAEntries;

        public EditPart2(string ID)
        {
            InitializeComponent();
            thisID = ID;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ImportFile_Click(object sender, EventArgs e)
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

                
                oWB = oXL.Workbooks.Open(fileName);
                oSheet = (Excel._Worksheet)oWB.Sheets[1];
                oRng = oSheet.UsedRange;

                firstName = oRng.Cells[2, 2].Value2 + "";
                lastName = oRng.Cells[2, 3].Value2 + "";

                if (firstName.Contains('"') || lastName.Contains('"'))
                {
                    oWB.Close(false);
                    MessageBox.Show("Something went wrong in reading the names. Please try again. Make sure there are no invalid characters in the name.");
                    this.Close();
                    return;
                }

                if (firstName.Contains(';') || lastName.Contains(';'))
                {
                    oWB.Close(false);
                    MessageBox.Show("Something went wrong in reading the names. Please try again. Make sure there are no invalid characters in the name.");
                    this.Close();
                    return;
                }


                try
                {
                    grade = int.Parse((string)oRng.Cells[2, 4].Value2);
                }
                catch
                {
                    oWB.Close(false);
                    MessageBox.Show("Something went wrong in reading the student grade. Please try again. Make sure there is a number in the cell.");
                    this.Close();
                    return;
                }

                gender = oRng.Cells[2, 7].Value2 + "";
                race = oRng.Cells[2, 8].Value2 + "";

                if (gender.Contains('"') || race.Contains('"'))
                {
                    oWB.Close(false);
                    MessageBox.Show("Something went wrong in reading the gender and race. Please try again. Make sure there are no invalid characters in the name.");
                    this.Close();
                    return;
                }

                if (gender.Contains(';') || race.Contains(';'))
                {
                    oWB.Close(false);
                    MessageBox.Show("Something went wrong in reading the gender and race. Please try again. Make sure there are no invalid characters in the name.");
                    this.Close();
                    return;
                }

                try
                {
                    daysMissed = int.Parse((string)oRng.Cells[2, 10]);
                }
                catch
                {
                    oWB.Close(false);
                    MessageBox.Show("Something went wrong in reading the student number of days missed. Please try again. Make sure there is a number in the cell.");
                    this.Close();
                    return;
                }

                try
                {
                    double d = double.Parse(oRng.Cells[2, 5].Value2 + "");
                    DateTime conv = DateTime.FromOADate(d);
                    gradeMod = conv.ToShortDateString();

                    d = double.Parse(oRng.Cells[2, 5].Value2 + "");
                    conv = DateTime.FromOADate(d);
                    regDate = conv.ToShortDateString();
                }
                catch
                {
                    oWB.Close(false);
                    MessageBox.Show("Something went wrong in reading the input dates. Please try again. Make sure they are in MM/DD/YYYY format.");
                    this.Close();
                    return;
                }

                oSheet = (Excel._Worksheet)oWB.Sheets[2];
                oRng = oSheet.UsedRange;



                oWB.Close(false);
            }
            catch (Exception theException)
            {
                string errorMessage;
                errorMessage = "Error: ";
                errorMessage = string.Concat(errorMessage, theException.Message);
                errorMessage = string.Concat(errorMessage, " Line: ");
                errorMessage = string.Concat(errorMessage, theException.Source);

                //oWB.Close(false);

                MessageBox.Show(errorMessage, "Error");
            }
        }

        private void UploadFile_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void EditPart2_Load(object sender, EventArgs e)
        {

        }
    }
}
