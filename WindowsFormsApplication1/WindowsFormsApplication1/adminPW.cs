using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

//ajdfshljskhfuire

namespace WindowsFormsApplication1
{
    public partial class adminPW : Form
    {
        public adminPW()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminPW_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString().Equals(Properties.Settings.Default.AdminPassword.ToString())) {
                DialogResult = DialogResult.OK;
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("password".Equals(textBox1.Text.ToString()));
                System.Diagnostics.Debug.WriteLine("password".Equals(Properties.Settings.Default.AdminPassword.ToString()));
                System.Diagnostics.Debug.WriteLine(textBox1.Text.ToString().Equals(Properties.Settings.Default.AdminPassword.ToString()));

                DialogResult = DialogResult.No;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
