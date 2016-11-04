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

            AddReferral_Category.DataSource = dataSource;
        }

        private void AddReferral_Category_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}
