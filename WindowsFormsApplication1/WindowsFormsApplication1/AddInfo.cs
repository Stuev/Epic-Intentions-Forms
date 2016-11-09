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
    public partial class AddInfo : Form
    {
        public AddInfo()
        {
            InitializeComponent();
        }

        private void AddSchool_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddSchool_ID nextForm = new AddSchool_ID();
            nextForm.ShowDialog();
            this.Show();
        }

        private void AddUncumGPA_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddUnCumGPA nextForm = new AddUnCumGPA();
            nextForm.ShowDialog();
            this.Show();
        }

        private void AddCumGPA_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCumGPA nextForm = new AddCumGPA();
            nextForm.ShowDialog();
            this.Show();
        }

        private void AddReferral_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddReferral nextForm = new AddReferral();
            nextForm.ShowDialog();
            this.Show();
        }
    }
}
