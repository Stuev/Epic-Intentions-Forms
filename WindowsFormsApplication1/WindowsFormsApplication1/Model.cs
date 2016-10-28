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
        private static string password;

        //DO NOT USE EXCEPT FOR THE LOGIN FIELD
        public Model(string pass)
        {
            password = pass;
            Initialize();
        }

        //USE NO ARG CONSTRUCTOR
        public Model()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            uid = "root";
            database = "epicintentions";

            string connectionString;
            connectionString = "SERVER=" + server +
                ";DATABASE=" + database +
                ";UID=" + uid +
                ";PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
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
                }
                else if (ex.Number == 0)
                { 
                    MessageBox.Show("Invalid password, please try again");
                }

                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }


        /* Establish a method for updating the student table
         * 
         * Everything passed in are the fields of the student table:
         * ID, First, Last, Grade, Modified Date, Registration Date,
         * Gender, Race, Whether they are Current, and the days Missed
         * 
         * Note that there is no data validation here
         * Everything passed in should be a string and should be correct.
         * This is for the buttons elsewhere in the app to call
         * 
         */
        public void UpdateStudentTable(string ID, string First, string Last, 
            string Grade, string Modified, string Reg, 
            string Gen, string Rac, string cur, string daysMi)
        {
            //Set up a SQL query, plugging in the passed in values into the strings
            string query = "UPDATE student SET Grade_Level = " + Grade
                + ", Grade_Modified_Date = " + Modified
                + ", Registration_Date = " + Reg
                + ", Gender = " + Gen
                + ", Race = " + Rac
                + ", isCurrent = " + cur
                + ", Days_Missed = " + daysMi
                + "WHERE ID = " + ID
                + "OR AND(First_Name =" + First + "Last_Name=" + Last;

            //executes the query into the database
            //can be copied and pasted at the bottom of every other file
            //select statement will be slightly different
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = query;

                cmd.Connection = connection;

                //this would return something useful in select statement
                cmd.ExecuteNonQuery();

                this.CloseConnection();
            }
        }

        public void UpdateSchoolTable()
        {

        }

        public void Insert()
        {

        }

        public void Delete()
        {

        }

        public List <string> [] Select()
        {
            return null;
        }

    }
}
