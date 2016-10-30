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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'epicintentionsDataSet.cum_gpa' table. You can move, or remove it, as needed.
            //this.cum_gpaTableAdapter.Fill(this.epicintentionsDataSet.cum_gpa);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddStudent_Click(object sender, EventArgs e)
        {

        }

        private void FilterStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Filter nextForm = new Filter();
            nextForm.ShowDialog();
            this.Show();
        }

        private void EditStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edit nextForm = new Edit();
            nextForm.ShowDialog();
            this.Show();
        }

        private void cum_gpaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.cum_gpaBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.epicintentionsDataSet);

        }

        private void ViewStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            View nextForm = new View();
            nextForm.ShowDialog();
            this.Show();
        }
    }
}
