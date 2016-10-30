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
        public void UpdateStudentTable(string ID, 
            string Grade, string Modified, string Reg, 
            string Gen, string Rac, string cur, string daysMi)
        {
            //Set up a SQL query, plugging in the passed in values into the strings
            string query = "UPDATE student SET Grade_Level = '" + Grade
                + "', Grade_Modified_Date = '" + Modified
                + "', Registration_Date = '" + Reg
                + "', Gender = " + Gen
                + "', Race = " + Rac
                + "', isCurrent = '" + cur
                + "', Days_Missed = '" + daysMi
                + "'WHERE ID = '" + ID
                + "';";

            //OR (First_Name='Bob' AND Last_Name='White')
            //executes the query into the database
            //can be copied and pasted at the bottom of every other file
            //select statement will be slightly different
            if (this.OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.CommandText = query;

                    cmd.Connection = connection;

                    //this would return something useful in select statement
                    cmd.ExecuteNonQuery();

                    this.CloseConnection();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void UpdateEndDate(string ID, string newDate)
        {
            string query = "UPDATE attends SET End_Date= '" + newDate
                + "'WHERE ID = '" + ID
                + "';";

            //OR (First_Name='Bob' AND Last_Name='White')
            //executes the query into the database
            //can be copied and pasted at the bottom of every other file
            //select statement will be slightly different
            try
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = query;

                cmd.Connection = connection;

                //this would return something useful in select statement
                cmd.ExecuteNonQuery();

                this.CloseConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateSchoolName(string oldSchool, string newSchool)
        {
            string query = "UPDATE school SET Name= '" + newSchool
                + "'WHERE Name= '" + oldSchool
                + "';";

            //OR (First_Name='Bob' AND Last_Name='White')
            //executes the query into the database
            //can be copied and pasted at the bottom of every other file
            //select statement will be slightly different
            try
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = query;

                cmd.Connection = connection;

                //this would return something useful in select statement
                cmd.ExecuteNonQuery();

                this.CloseConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void InsertToPastStudent()
        {

        }

        public void Insert()
        {

        }

        public void DeleteReferral()
        {

        }

        public void DeleteCumGPA()
        {

        }

        public void DeleteUnCumGPA()
        {

        }

        public string FindIDFromName(string First, string Last)
        {
            string query = "SELECT * FROM student WHERE "
                + "First_Name = '" + First + "' AND Last_Name = '" + Last + "'; ";
            string ID = null;

            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {

                    ID = dataReader["ID"] + "";
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return ID;
            } else
            {
                return ID;
            }
        }

        public List <string>[] SelectStudent(string ID)
        {
            {
                string query = "SELECT * FROM student "
                +"WHERE ID = '" + ID
                + "';";

                //Create a list to store the result
                List<string>[] list = new List<string>[10];
                list[0] = new List<string>();
                list[1] = new List<string>();
                list[2] = new List<string>();
                list[3] = new List<string>();
                list[4] = new List<string>();
                list[5] = new List<string>();
                list[6] = new List<string>();
                list[7] = new List<string>();
                list[8] = new List<string>();
                list[9] = new List<string>();

                //Open connection
                if (this.OpenConnection() == true)
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    
                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        list[0].Add(dataReader["ID"] + "");
                        list[1].Add(dataReader["First_Name"] + "");
                        list[2].Add(dataReader["Last_Name"] + "");
                        list[3].Add(dataReader["Grade_Level"] + "");
                        list[4].Add(dataReader["Grade_Modified_Date"] + "");
                        list[5].Add(dataReader["Registration_Date"] + "");
                        list[6].Add(dataReader["Gender"] + "");
                        list[7].Add(dataReader["Race"] + "");
                        list[8].Add(dataReader["isCurrent"] + "");
                        list[9].Add(dataReader["Days_Missed"] + "");
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();

                    //return list to be displayed
                    return list;
                }
                else
                {
                    return list;
                }
            }
        }

        public int getMin()
        {
            return 0;
        }

        public int getMax()
        {
            return 0;
        }

        public int getMinGPA()
        {
            return 0;
        }

        public int getMaxGPA()
        {
            return 0;
        }

        public List<string> getSchools()
        {
            return new List<string>();
        }

        public int getMinGrade()
        {
            return 0;
        }

        public int getMaxGrade()
        {
            return 0;
        }

        public int getMinReferrals()
        {
            return 0;
        }

        public int getMaxReferrals()
        {
            return 0;
        }

        public int getMinDaysMissed()
        {
            return 0;
        }

        public int getMaxDaysMissed()
        {
            return 0;
        }

        public List<string> getGenders()
        {
            return new List<string>();
        }

        public List<string> getRaces()
        {
            return new List<string>();
        }

        public List<string> getCurrentStudentOptions()
        {
            return new List<string>();
        }
    }
}
