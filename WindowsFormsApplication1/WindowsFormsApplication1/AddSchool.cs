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
    public partial class AddSchool : Form
    {
        public AddSchool()
        {
            InitializeComponent();
        }

        private void AddSchool_Button_Click(object sender, EventArgs e)
        {

            string school = AddSchool_Name.Text;
            if (school == "")
            {
                MessageBox.Show("School Field is Empty!");
                return;
            }

            if (!Model.SchoolExists(school))
            {
                Model.InsertSchool(school);
                this.Close();
            }
            else
            {
                MessageBox.Show("School already exists!");
                return;
            }
        }
    }
}
