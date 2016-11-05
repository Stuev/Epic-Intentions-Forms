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
        }

        private void AddReferral_Category_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
