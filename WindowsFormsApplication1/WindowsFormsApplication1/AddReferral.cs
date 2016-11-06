using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AddReferral : Form
    {
        public AddReferral()
        {
            InitializeComponent();
            var dataSource = new List<string>();
            dataSource.Add("Drugs");
            dataSource.Add("Fighting");
            dataSource.Add("Attendance");
            dataSource.Add("Behavior");
            dataSource.Add("Fighting");
            dataSource.Add("Other");

            AddReferral_Category.DataSource = dataSource;
            AddReferral_Category.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void AddReferral_Category_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

            int studentID;
            try
            {
                studentID = int.Parse(AddReferral_ID.Text);
            }
            catch
            {
                MessageBox.Show("Please Make sure a number is in the ID field!");
                return;
            }
            string ID = studentID + "";

            string Type = AddReferral_Category.Text;

            DateTime date = DateTime.Now;
            string year = date.Year.ToString();
            string month = date.Month.ToString();
            string day = date.Day.ToString();
            string curDay = year + '-' + month + '-' + day;

            string Desc = RefDesc.Text;
            if (Desc == "")
            {
                Desc = "[Description Missing]";
            }

            if (Model.InsertReferral(ID, curDay, Type, Desc))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Something went wrong in processing the Referral. Please try again.");
            }
        }
    }
}
