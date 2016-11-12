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
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string id = DeleteCumID.Text;
            string grade = DeleteCumGrade.Text;
            string date = DeleteCumDate.Text;
            
        }

        private void DeleteCumID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
