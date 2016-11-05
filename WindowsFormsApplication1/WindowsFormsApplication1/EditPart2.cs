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
        private double grade;
        private double daysMissed;
        private string gender;
        private string race;
        private string regDate;
        private string gradeMod;
        private List<float> cumGPAs;
        //private List<string> cumGPAEntries;
        private List<string> refDate;
        private List<string> refType;
        private List<string> refDescr;
        private List<string>[] oldReferralList;
        private string pastReason;
        private string pastDate;
        private bool pastUpdate = false;
        private List<string> attendsStartDate;
        private List<string> attendsEndDate;
        private List<string> attendsSchoolName;
        private List<float> unCumGPAs;
        private List<string>[] oldUnCumGPAs;
        private List<string>[] oldCumGPAs;
        private List<string>[] oldAttends;
        private bool clicked = false;
        //private List<string> unCumGPAEntries;

        public EditPart2(string ID)
        {
            InitializeComponent();
            thisID = ID;
            oldUnCumGPAs = Model.SelectAllUnCumGPA(ID);
            oldCumGPAs = Model.SelectAllCumGPA(ID);
            oldReferralList = Model.SelectAllReferral(ID);
            oldAttends = Model.SelectAllAttend(ID);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ImportFile_Click(object sender, EventArgs e)
        {
            clicked = true;
            Excel.Application oXL;
            Excel._Workbook oWB;
            Excel._Worksheet oSheet;
            Excel.Range oRng;

            //Start Excel and get Application object.

            try
            {
                oXL = new Excel.Application();
                oXL.Visible = false;

                oWB = oXL.Workbooks.Open(fileName);
                oSheet = (Excel._Worksheet)oWB.Sheets[1];
                oRng = oSheet.UsedRange;
            }
            catch
            {
                MessageBox.Show("Something went wrong in reading the file. Please make sure the file was saved correctly.");
                this.Close();
                return;
            }

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
                grade = int.Parse(oRng.Cells[2, 4].Value2 + "");
            }
            catch
            {
                try
                {
                    grade = oRng.Cells[2, 4].Value2;
                }
                catch
                {
                    oWB.Close(false);
                    MessageBox.Show("Something went wrong in reading the student grade. Please try again. Make sure there is a number in the cell.");
                    this.Close();
                    return;
                }
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
                daysMissed = int.Parse(oRng.Cells[2, 10].Value2 + "");
            }
            catch
            {
                try
                {
                    daysMissed = oRng.Cells[2, 10].Value2;
                }
                catch
                {
                    oWB.Close(false);
                    MessageBox.Show("Something went wrong in reading the student number of days missed. Please try again. Make sure there is a number in the cell.");
                    this.Close();
                    return;
                }
                
            }

            try
            {
                double d = double.Parse(oRng.Cells[2, 5].Value2 + "");
                DateTime conv = DateTime.FromOADate(d);
                gradeMod = conv.ToShortDateString();
            }
            catch
            {
                try
                {
                    DateTime conv = DateTime.Parse(oRng.Cells[2, 5].Value2 + "");
                    gradeMod = conv.ToShortDateString();
                }
                catch
                {
                    oWB.Close(false);
                    MessageBox.Show("Something went wrong in reading the input dates. Please try again. Make sure they are in MM/DD/YYYY format.");
                    this.Close();
                    return;
                }
            }



            try
            {
                double d = double.Parse(oRng.Cells[2, 6].Value2 + "");
                DateTime conv = DateTime.FromOADate(d);
                regDate = conv.ToShortDateString();
            }
            catch
            {
                try
                {
                    DateTime conv = DateTime.Parse(oRng.Cells[2, 6].Value2 + "");
                    regDate = conv.ToShortDateString();
                }
                catch
                {
                    oWB.Close(false);
                    MessageBox.Show("Something went wrong in reading the input dates. Please try again. Make sure they are in MM/DD/YYYY format.");
                    this.Close();
                    return;
                }
            }

            oSheet = (Excel._Worksheet)oWB.Sheets[2];
            oRng = oSheet.UsedRange;

            cumGPAs = new List<float>();
            //cumGPAEntries = new List<string>();

            for (int i = 0; i < oldCumGPAs[0].Count(); i = i + 1)
            {
                try
                {
                    cumGPAs.Add(float.Parse(oRng.Cells[i + 2, 2].Value2 + ""));
                }
                catch
                {
                    try
                    {
                        cumGPAs.Add(oRng.Cells[i + 2, 2].Value2);
                    }
                    catch
                    {
                        oWB.Close(false);
                        MessageBox.Show("Something went wrong in reading the Uncumulative GPAs. Please try again. Make sure there is a number in the cells.");
                        this.Close();
                        return;
                    }
                }
            }

            oSheet = (Excel._Worksheet)oWB.Sheets[3];
            oRng = oSheet.UsedRange;

            unCumGPAs = new List<float>();
            //unCumGPAEntries = new List<string>();

            for (int i = 0; i < oldUnCumGPAs[0].Count(); i = i + 1)
            {
                try
                {
                    unCumGPAs.Add(float.Parse(oRng.Cells[i + 2, 2].Value2 + ""));
                }
                catch
                {
                    oWB.Close(false);
                    MessageBox.Show("Something went wrong in reading the Uncumulative GPAs. Please try again. Make sure there is a number in the cells.");
                    this.Close();
                    return;
                }
            }

            oSheet = (Excel._Worksheet)oWB.Sheets[4];
            oRng = oSheet.UsedRange;

            attendsSchoolName = new List<string>();
            attendsStartDate = new List<string>();
            attendsEndDate = new List<string>();
            
            for (int i = 0; i < oldAttends[0].Count(); i = i + 1)
            {
                attendsSchoolName.Add(oRng.Cells[i + 2, 2].Value2 + "");


                if (attendsSchoolName[attendsSchoolName.Count - 1].Contains('"') 
                    || attendsSchoolName[attendsSchoolName.Count - 1].Contains(';'))
                {
                    oWB.Close(false);
                    MessageBox.Show("Something went wrong in reading the school name. Please try again. Make sure there are no invalid characters in the name.");
                    this.Close();
                    return;
                }

                try
                {
                    double d = double.Parse(oRng.Cells[i + 2, 3].Value2 + "");
                    DateTime conv = DateTime.FromOADate(d);
                    attendsStartDate.Add(conv.ToShortDateString());
                }
                catch
                {
                    try
                    {
                        DateTime conv = DateTime.Parse(oRng.Cells[i + 2, 3].Value2 + "");
                        attendsStartDate.Add(conv.ToShortDateString());
                    }
                    catch
                    {
                        oWB.Close(false);
                        MessageBox.Show("Something went wrong in reading the input dates. Please try again. Make sure they are in MM/DD/YYYY format.");
                        this.Close();
                        return;
                    }
                }

                try
                {
                    double d = double.Parse(oRng.Cells[i + 2, 4].Value2 + "");
                    DateTime conv = DateTime.FromOADate(d);
                    attendsEndDate.Add(conv.ToShortDateString());
                }
                catch
                {
                    try
                    {
                        DateTime conv = DateTime.Parse(oRng.Cells[i + 2, 4].Value2 + "");
                        attendsEndDate.Add(conv.ToShortDateString());
                    }
                    catch
                    {
                        if (oRng.Cells[i + 2, 4].Value2 + "" == "")
                        {
                            attendsEndDate.Add("");
                        }
                        else
                        { 
                            oWB.Close(false);
                            MessageBox.Show("Something went wrong in reading the input dates. Please try again. Make sure they are in MM/DD/YYYY format.");
                            this.Close();
                            return;
                        }
                    }
                }

                
            }

            oSheet = (Excel._Worksheet)oWB.Sheets[5];
            oRng = oSheet.UsedRange;

            refType = new List<string>();
            refDate = new List<string>();
            refDescr = new List<string>();


            for (int i = 0; i < oldReferralList[0].Count(); i = i + 1)
            {
                try
                {
                    double d = double.Parse(oRng.Cells[i + 2, 3].Value2 + "");
                    DateTime conv = DateTime.FromOADate(d);
                    refDate.Add(conv.ToShortDateString());
                }
                catch
                {
                    try
                    {
                        DateTime conv = DateTime.Parse(oRng.Cells[i + 2, 3].Value2 + "");
                        refDate.Add(conv.ToShortDateString());
                    }
                    catch
                    {
                        oWB.Close(false);
                        MessageBox.Show("Something went wrong in reading the input dates. Please try again. Make sure they are in MM/DD/YYYY format.");
                        this.Close();
                        return;
                    }
                }

                refType.Add(oRng.Cells[i + 2, 4].Value2 + "");
                refType[refType.Count - 1].Replace("\'", "\\\'");

                refDescr.Add(oRng.Cells[i + 2, 5].Value2 + "");
                refDescr[refDescr.Count - 1].Replace("\'", "\\\'");

                
            }

            oSheet = (Excel._Worksheet)oWB.Sheets[6];
            oRng = oSheet.UsedRange;

            if(oSheet.Name == "Past Student Information")
            {
                pastUpdate = true;

                try
                {
                    double d = double.Parse(oRng.Cells[2, 3].Value2 + "");
                    DateTime conv = DateTime.FromOADate(d);
                    pastDate = conv.ToShortDateString();
                }
                catch
                {
                    try
                    {
                        DateTime conv = DateTime.Parse(oRng.Cells[2, 3].Value2 + "");
                        pastDate = conv.ToShortDateString();
                    }
                    catch
                    {
                        oWB.Close(false);
                        MessageBox.Show("Something went wrong in reading the input dates. Please try again. Make sure they are in MM/DD/YYYY format.");
                        this.Close();
                        return;
                    }
                }

                pastReason = oRng.Cells[2, 2].Value2 + "";

            }

            oWB.Close(false);
            MessageBox.Show("File has been successfully imported! Press \"Complete Edit\" Button to save changes!");
            
        }

        private void UploadFile_Click(object sender, EventArgs e)
        {
            if (!clicked)
            {
                MessageBox.Show("Please import the file before trying to save changes!");
                return;
            }
            this.Close();
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
