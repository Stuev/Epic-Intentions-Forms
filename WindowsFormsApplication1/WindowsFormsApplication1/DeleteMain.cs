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
    public partial class DeleteMain : Form
    {
        public DeleteMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteCum nextForm = new DeleteCum();
            nextForm.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteUncum nextForm = new DeleteUncum();
            nextForm.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteReferrals nextForm = new DeleteReferrals();
            nextForm.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteStudent nextForm = new DeleteStudent();
            nextForm.ShowDialog();
            this.Show();
        }
    }
}
