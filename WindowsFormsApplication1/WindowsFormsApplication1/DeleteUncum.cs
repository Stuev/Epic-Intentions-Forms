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
    public partial class DeleteUncum : Form
    {
        public DeleteUncum()
        {
            InitializeComponent();

            List<string> ids = Model.getUnCumIds();
            ids.Insert(0, "all");

            List<string> classes = Model.getUnCumClasses();
            classes.Insert(0, "all");

            List<string> cumGPAs = Model.getUnCumGrades();
            cumGPAs.Insert(0, "all");

            List<string> dates = Model.getUnCumDates();
            dates.Insert(0, "all");

            DeleteUnCumID.DataSource = ids;
            DeleteUnCumClass.DataSource = classes;
            DeleteUnCumGrade.DataSource = cumGPAs;
            DeleteUnCumDate.DataSource = dates;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteUnCumID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteUnCumClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteUnCumDate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteUnCumSubmit_Click(object sender, EventArgs e)
        {
            List<string> ids = new List<string>();
            if (DeleteUnCumID.GetItemText(DeleteUnCumID.SelectedItem).Equals("all"))
            {
                ids = (List<string>)DeleteUnCumID.DataSource;
                ids.RemoveAt(0);
            }
            else
            {
                ids.Add(DeleteUnCumID.GetItemText(DeleteUnCumID.SelectedItem));
            }

            List<string> classes = new List<string>();
            if (DeleteUnCumClass.GetItemText(DeleteUnCumClass.SelectedItem).Equals("all"))
            {
                ids = (List<string>)DeleteUnCumClass.DataSource;
                ids.RemoveAt(0);
            }
            else
            {
                ids.Add(DeleteUnCumClass.GetItemText(DeleteUnCumClass.SelectedItem));
            }

            List<string> gpas = new List<string>();
            if (DeleteUnCumGrade.GetItemText(DeleteUnCumGrade.SelectedItem).Equals("all"))
            {
                gpas = (List<string>)DeleteUnCumGrade.DataSource;
                gpas.RemoveAt(0);

            }
            else
            {
                gpas.Add(DeleteUnCumGrade.GetItemText(DeleteUnCumGrade.SelectedItem));
            }

            List<string> dates = new List<string>();
            if (DeleteUnCumDate.GetItemText(DeleteUnCumDate.SelectedItem).Equals("all"))
            {
                dates = (List<string>)DeleteUnCumDate.DataSource;
                dates.RemoveAt(0);

            }
            else
            {
                dates.Add(DeleteUnCumDate.GetItemText(DeleteUnCumDate.SelectedItem));
            }

            Model.deleteUnCum(ids, classes, gpas, dates);
        }
    }
}
