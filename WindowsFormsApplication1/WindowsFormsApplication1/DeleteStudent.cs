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
    public partial class DeleteStudent : Form
    {
        public DeleteStudent()
        {
            InitializeComponent();

            List<string> ids = Model.getStudentIds();
            ids.Insert(0, "all");

            List<string> fnames = Model.getStudentFnames();
            fnames.Insert(0, "all");

            List<string> lnames = Model.getStudentLnames();
            lnames.Insert(0, "all");

            DeleteStudentID.DataSource = ids;
            DeleteStudentFname.DataSource = fnames;
            DeleteStudentLname.DataSource = lnames;
        }

        private void DeleteStudentSubmit_Click(object sender, EventArgs e)
        {
            List<string> ids = new List<string>();
            if (DeleteStudentID.GetItemText(DeleteStudentID.SelectedItem).Equals("all"))
            {
                ids = (List<string>)DeleteStudentID.DataSource;
                ids.RemoveAt(0);
            }
            else
            {
                ids.Add(DeleteStudentID.GetItemText(DeleteStudentID.SelectedItem));
            }

            List<string> fnames = new List<string>();
            if (DeleteStudentFname.GetItemText(DeleteStudentFname.SelectedItem).Equals("all"))
            {
                fnames = (List<string>)DeleteStudentFname.DataSource;
                fnames.RemoveAt(0);

            }
            else
            {
                fnames.Add(DeleteStudentFname.GetItemText(DeleteStudentFname.SelectedItem));
            }

            List<string> lnames = new List<string>();
            if (DeleteStudentLname.GetItemText(DeleteStudentLname.SelectedItem).Equals("all"))
            {
                lnames = (List<string>)DeleteStudentLname.DataSource;
                lnames.RemoveAt(0);

            }
            else
            {
                lnames.Add(DeleteStudentLname.GetItemText(DeleteStudentLname.SelectedItem));
            }

            Model.deleteStudent(ids, fnames, lnames);
        }
    }
}
