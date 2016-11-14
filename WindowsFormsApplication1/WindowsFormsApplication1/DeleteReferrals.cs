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
    public partial class DeleteReferrals : Form
    {
        public DeleteReferrals()
        {
            InitializeComponent();

            List<string> ids = Model.getRefIds();
            ids.Insert(0, "all");

            List<string> types = Model.getRefTypes();
            types.Insert(0, "all");

            List<string> dates = Model.getRefDates();
            dates.Insert(0, "all");

            DeleteReferralID.DataSource = ids;
            DeleteReferralType.DataSource = types;
            DeleteReferralDate.DataSource = dates;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void DeleteReferralID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteRefSubmit_Click(object sender, EventArgs e)
        {
            adminPW authentication = new adminPW();
            authentication.ShowDialog();

            if (!(authentication.DialogResult == DialogResult.OK))
            {
                MessageBox.Show("Password authentication failed.");
                return;
            }

            List<string> ids = new List<string>();
            if (DeleteReferralID.GetItemText(DeleteReferralID.SelectedItem).Equals("all"))
            {
                ids = (List<string>)DeleteReferralID.DataSource;
                ids.RemoveAt(0);
            }
            else
            {
                ids.Add(DeleteReferralID.GetItemText(DeleteReferralID.SelectedItem));
            }

            List<string> types = new List<string>();
            if (DeleteReferralType.GetItemText(DeleteReferralType.SelectedItem).Equals("all"))
            {
                types = (List<string>)DeleteReferralType.DataSource;
                types.RemoveAt(0);

            }
            else
            {
                types.Add(DeleteReferralType.GetItemText(DeleteReferralType.SelectedItem));
            }

            List<string> dates = new List<string>();
            if (DeleteReferralDate.GetItemText(DeleteReferralDate.SelectedItem).Equals("all"))
            {
                dates = (List<string>)DeleteReferralDate.DataSource;
                dates.RemoveAt(0);

            }
            else
            {
                dates.Add(DeleteReferralDate.GetItemText(DeleteReferralDate.SelectedItem));
            }

            Model.deleteRef(ids, types, dates);
        }

        private void DeleteReferrals_Load(object sender, EventArgs e)
        {

        }
    }
}
