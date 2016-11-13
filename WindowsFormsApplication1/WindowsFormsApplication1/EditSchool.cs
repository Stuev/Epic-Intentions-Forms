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
    public partial class EditSchool : Form
    {
        public EditSchool()
        {
            InitializeComponent();
            List<string> data = Model.getSchools();

            School.DataSource = data;
            School.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void UploadFile_Click(object sender, EventArgs e)
        {
            if (NewSchool.Text != "")
            {
                Model.UpdateSchoolName(School.Text, NewSchool.Text);
            }
        }
    }
}
