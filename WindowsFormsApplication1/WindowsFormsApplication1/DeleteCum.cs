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
    public partial class DeleteCum : Form
    {
        public DeleteCum()
        {
            InitializeComponent();

            List<string> ids = Model.getCumIds();
            ids.Insert(0, "all");

            List<string> cumGPAs = Model.getCumGPAs();
            cumGPAs.Insert(0, "all");

            List<string> dates = Model.getCumDates();
            dates.Insert(0, "all");

            DeleteCumID.DataSource = ids;
            DeleteCumGPA.DataSource = cumGPAs;
            DeleteCumDate.DataSource = dates;

        }

        private void DeleteCumID_TextChanged(object sender, EventArgs e)
        {

        }

        private void DeleteCumId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteCumGPA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteCumDate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UnCumClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteCumSubmit_Click_1(object sender, EventArgs e)
        {
            List<string> ids = new List<string>();
            if (DeleteCumID.GetItemText(DeleteCumID.SelectedItem).Equals("all"))
            {
                ids = (List<string>)DeleteCumID.DataSource;
                ids.RemoveAt(0);
            }
            else
            {
                ids.Add(DeleteCumID.GetItemText(DeleteCumID.SelectedItem));
            }

            List<string> gpas = new List<string>();
            if (DeleteCumGPA.GetItemText(DeleteCumGPA.SelectedItem).Equals("all"))
            {
                gpas = (List<string>)DeleteCumGPA.DataSource;
                gpas.RemoveAt(0);

            }
            else
            {
                gpas.Add(DeleteCumGPA.GetItemText(DeleteCumGPA.SelectedItem));
            }

            List<string> dates = new List<string>();
            if (DeleteCumDate.GetItemText(DeleteCumDate.SelectedItem).Equals("all"))
            {
                dates = (List<string>)DeleteCumDate.DataSource;
                dates.RemoveAt(0);

            }
            else
            {
                dates.Add(DeleteCumDate.GetItemText(DeleteCumDate.SelectedItem));
            }

            Model.deleteCum(ids, gpas, dates);
        }
    }
}
