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
    public partial class EditAdminPassword : Form
    {
        public EditAdminPassword()
        {
            InitializeComponent();
        }

        private void EditAdminPassword_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToString().Equals(Properties.Settings.Default.AdminPassword.ToString()))
            {
                if (textBox2.Text.Equals(textBox3.Text))
                {
                    Properties.Settings.Default.AdminPassword = textBox2.Text.ToString();
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Password change successful");

                }
                else
                {
                    MessageBox.Show("Your new password entries do not match");
                    return;
                }
            }
            else
            {
                MessageBox.Show("The old password entry is incorrect");
                return;
            }
            DialogResult = DialogResult.OK;
        }
    }
}
