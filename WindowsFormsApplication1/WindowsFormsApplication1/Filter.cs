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
    public partial class Filter : Form
    {
        public Filter()
        {
            InitializeComponent();
            GPA1.Text = Model.getMinGPA() + "";
            GPA2.Text = Model.getMaxGPA() + "";
            Grade1.Text = Model.getMinGrade() + "";
            Grade2.Text = Model.getMaxGrade() + ""; ;
            Behavior1.Text = Model.getMinReferrals() + "";
            Behavior2.Text = Model.getMaxReferrals() + "";
            Attend1.Text = Model.getMinDaysMissed() + "";
            Attend2.Text = Model.getMaxDaysMissed() + "";

            Gender.DataSource = Model.getGenders();
            School.DataSource = Model.getSchools();
            Race.DataSource = Model.getRaces();
            Current.DataSource = Model.getCurrentStudentOptions();

            /*Gender.Items.Add("All");
            School.Items.Add("All");
            Race.Items.Add("All");
            Current.Items.Add("All");
              */          
            Gender.DropDownStyle = ComboBoxStyle.DropDownList;
            School.DropDownStyle = ComboBoxStyle.DropDownList;
            Race.DropDownStyle = ComboBoxStyle.DropDownList;
            Current.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void Submit_Click(object sender, EventArgs e)
        {
            int minGPA = Int32.Parse(GPA1.Text);
            int maxGPA = Int32.Parse(GPA2.Text);
            int minGrade = Int32.Parse(Grade1.Text);
            int maxGrade = Int32.Parse(Grade2.Text);
            int minBehavior = Int32.Parse(Behavior1.Text);
            int maxBehavior = Int32.Parse(Behavior2.Text);
            int minAttendence = Int32.Parse(Attend1.Text);
            int maxAttendence = Int32.Parse(Attend2.Text);

            string gender = Gender.GetItemText(Gender.SelectedItem);
            string school = School.GetItemText(School.SelectedItem);
            string race = Gender.GetItemText(Race.SelectedItem);
            string current = Current.GetItemText(Current.SelectedItem);

            if (Model.OpenConnection() == true)
            {
                this.Hide();
                Model.CloseConnection();
                //Main nextForm = new Main();
                //nextForm.ShowDialog();
                this.Close();
            }

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Filter_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
