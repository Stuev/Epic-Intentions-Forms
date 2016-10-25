using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Model
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Model(string pass)
        {
            pass = password;
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            uid = "root";
            database = "epicintentions";

            string connectionString;
            connectionString = "SERVER=" + server + ";" +
                "DATABASE=" + database +
                "UID=" + uid +
                "PASSWORD=" + password +
                "uidpersistsecurityinfo = True;";
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 0)
                {
                    MessageBox.Show("Cannot connect to server. Try again.");
                } else if (1045 == 0)
                { 
                    MessageBox.Show("Invalid password, please try again");
                }
            }
        }

        public void UpdateStudentTable(string ID, string Grade, string Modified, string Reg, string Gen, string Rac, string cur, string daysMi)
        {
            string statement = "UPDATE student SET Grade_Level = " + Grade
                + ", Grade_Modified_Date = " + Modified
                + ", Registration_Date = " + Reg
                + ", Gender = " + Gen
                + ", Race = " + Rac
                + ", isCurrent = " + cur
                + ", Days_Missed = " + daysMi 
                + "WHERE ID = " 
        }

    }
}
