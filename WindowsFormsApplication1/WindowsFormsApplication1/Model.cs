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
        private static MySqlConnection connection;
        private static string server;
        private static string database;
        private static string uid;
        private static string password;

        //DO NOT USE EXCEPT FOR THE LOGIN FIELD
        public Model(string pass)
        {
            password = pass;
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

        public static bool OpenConnection()
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

                return false;
            }
        }

        public static bool CloseConnection()
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
        public static void UpdateStudentTable(string ID, 
            string Grade, string Modified, string Reg, 
            string Gen, string Rac, string daysMi)
        {
            //Set up a SQL query, plugging in the passed in values into the strings
            string query = "UPDATE student SET Grade_Level =\"" + Grade
                + "\", Grade_Modified_Date = \"" + Modified
                + "\", Registration_Date = \"" + Reg
                + "\", Gender = \"" + Gen
                + "\", Race = \"" + Rac
                + "\", Days_Missed = \"" + daysMi
                + "\" WHERE ID = \"" + ID
                + "\";";

            if (OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.CommandText = query;

                    cmd.Connection = connection;

                    cmd.ExecuteNonQuery();

                    CloseConnection();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void UpdateEndDate(string ID, string newDate)
        {
            string query = "UPDATE attends SET End_Date= '" + newDate
                + "'WHERE ID = '" + ID
                + "';";

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = query;

                cmd.Connection = connection;

                cmd.ExecuteNonQuery();

                CloseConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void UpdateSchoolName(string oldSchool, string newSchool)
        {
            string query = "UPDATE school SET Name= '" + newSchool
                + "'WHERE Name= '" + oldSchool
                + "';";

            try
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = query;

                cmd.Connection = connection;

                cmd.ExecuteNonQuery();

                CloseConnection();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void InsertToPastStudent()
        {

        }

        public static void Insert()
        {

        }

        public static void InsertStudent(String firstName, String lastName, int studentID, Double gpa,
            String school, int grade, int numRefs, int daysMissed, String gender, String race, String curStudent, String RegDate, String GradeMod)
        {
            int curStudentInt;
            if (curStudent.ToLower() == "yes")
            {
                curStudentInt = 1;
            }
            else
            {
                curStudentInt = 0;
            }
            string query = "INSERT INTO student SET Grade_Level = '" + grade
                + "', ID = '" + studentID
                + "', First_Name = '" + firstName
                + "', Last_Name = '" + lastName
                + "', Grade_Modified_Date = '" + GradeMod
                + "', Registration_Date = '" + RegDate
                + "', Gender = '" + gender
                + "', Race = '" + race
                + "', isCurrent = '" + curStudentInt
                + "', Days_Missed = '" + daysMissed
                + "';";

            if (OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.CommandText = query;

                    cmd.Connection = connection;

                    cmd.ExecuteNonQuery();

                    CloseConnection();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void DeleteReferral()
        {

        }

        public static void DeleteCumGPA()
        {

        }

        public static void DeleteUnCumGPA()
        {

        }

        public static string FindIDFromName(string First, string Last)
        {
            string query = "SELECT * FROM student WHERE "
                + "First_Name = \"" + First + "\" AND Last_Name = \"" + Last + "\"; ";
            string ID = null;

            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();


                while (dataReader.Read())
                {

                    ID = dataReader["ID"] + "";
                }


                dataReader.Close();


                CloseConnection();


                return ID;
            } else
            {
                return ID;
            }
        }
        public static List<string>[] SelectAllStudents()
        {
            string query = "SELECT * FROM student;";

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
            if (OpenConnection() == true)
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
                CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public static List<string>[] SelectAllCumGPAS()
        {
            {
                string query = "SELECT * FROM cum_gpa;";

                List<string>[] list = new List<string>[3];
                list[0] = new List<string>();
                list[1] = new List<string>();
                list[2] = new List<string>();

                if (OpenConnection() == true)
                {


                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataReader dataReader = cmd.ExecuteReader();


                    while (dataReader.Read())
                    {
                        list[0].Add(dataReader["ID"] + "");
                        list[1].Add(dataReader["GPA"] + "");
                        list[2].Add(dataReader["GPA_Entry_Date"] + "");
                    }


                    dataReader.Close();


                    CloseConnection();


                    return list;
                }
                else
                {
                    return list;
                }
            }
        }

        public static List<string>[] SelectAllUnCumGPAS()
        {
            {
                string query = "SELECT * FROM un_cum_gpa;";


                List<string>[] list = new List<string>[3];
                list[0] = new List<string>();
                list[1] = new List<string>();
                list[2] = new List<string>();


                if (OpenConnection() == true)
                {


                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataReader dataReader = cmd.ExecuteReader();


                    while (dataReader.Read())
                    {
                        list[0].Add(dataReader["ID"] + "");
                        list[1].Add(dataReader["GPA"] + "");
                        list[2].Add(dataReader["GPA_Entry_Date"] + "");
                    }


                    dataReader.Close();

                    CloseConnection();

                    return list;
                }
                else
                {
                    return list;
                }
            }
        }

        public static List<string>[] SelectAllAttends()
        {
            {
                string query = "SELECT * FROM attends;";


                List<string>[] list = new List<string>[4];
                list[0] = new List<string>();
                list[1] = new List<string>();
                list[2] = new List<string>();
                list[3] = new List<string>();


                if (OpenConnection() == true)
                {


                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataReader dataReader = cmd.ExecuteReader();


                    while (dataReader.Read())
                    {
                        list[0].Add(dataReader["Student_ID"] + "");
                        list[1].Add(dataReader["School_Name"] + "");
                        list[2].Add(dataReader["Start_Date"] + "");
                        list[3].Add(dataReader["End_Date"] + "");
                    }


                    dataReader.Close();


                    CloseConnection();


                    return list;
                }
                else
                {
                    return list;
                }
            }
        }

        public static List<string>[] SelectAllPasts()
        {
            {
                string query = "SELECT * FROM past_student;";

                List<string>[] list = new List<string>[3];
                list[0] = new List<string>();
                list[1] = new List<string>();
                list[2] = new List<string>();


                if (OpenConnection() == true)
                {


                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataReader dataReader = cmd.ExecuteReader();


                    while (dataReader.Read())
                    {
                        list[0].Add(dataReader["ID"] + "");
                        list[1].Add(dataReader["Reason"] + "");
                        list[2].Add(dataReader["Leave_Date"] + "");
                    }


                    dataReader.Close();


                    CloseConnection();


                    return list;
                }
                else
                {
                    return list;
                }
            }
        }

        public static List<string>[] SelectAllReferrals()
        {
            string query = "SELECT * FROM referrals;";


            List<string>[] list = new List<string>[5];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();


            if (OpenConnection() == true)
            {


                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();


                while (dataReader.Read())
                {
                    list[0].Add(dataReader["ID"] + "");
                    list[1].Add(dataReader["Referral_Number"] + "");
                    list[2].Add(dataReader["Referral_Date"] + "");
                    list[3].Add(dataReader["Type"] + "");
                    list[4].Add(dataReader["Description"] + "");
                }


                dataReader.Close();


                CloseConnection();


                return list;
            }
            else
            {
                return list;
            }
        }







        public static List <string>[] SelectStudent(string ID)
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
                if (OpenConnection() == true)
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
                    CloseConnection();

                    //return list to be displayed
                    return list;
                }
                else
                {
                    return list;
                }
            }
        }

        public static List<string>[] SelectAllCumGPA(string ID)
        {
            {
                string query = "SELECT * FROM cum_gpa "
                + "WHERE ID = '" + ID
                + "';";

                List<string>[] list = new List<string>[3];
                list[0] = new List<string>();
                list[1] = new List<string>();
                list[2] = new List<string>();

                if (OpenConnection() == true)
                {


                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataReader dataReader = cmd.ExecuteReader();


                    while (dataReader.Read())
                    {
                        list[0].Add(dataReader["ID"] + "");
                        list[1].Add(dataReader["GPA"] + "");
                        list[2].Add(dataReader["GPA_Entry_Date"] + "");
                    }


                    dataReader.Close();


                    CloseConnection();


                    return list;
                }
                else
                {
                    return list;
                }
            }
        }

        public static List<string>[] SelectAllUnCumGPA(string ID)
        {
            {
                string query = "SELECT * FROM un_cum_gpa "
                + "WHERE ID = '" + ID
                + "';";


                List<string>[] list = new List<string>[3];
                list[0] = new List<string>();
                list[1] = new List<string>();
                list[2] = new List<string>();


                if (OpenConnection() == true)
                {


                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataReader dataReader = cmd.ExecuteReader();


                    while (dataReader.Read())
                    {
                        list[0].Add(dataReader["ID"] + "");
                        list[1].Add(dataReader["GPA"] + "");
                        list[2].Add(dataReader["GPA_Entry_Date"] + "");
                    }


                    dataReader.Close();

                    CloseConnection();

                    return list;
                }
                else
                {
                    return list;
                }
            }
        }



        public static List<string>[] SelectAllAttend(string ID)
        {
            {
                string query = "SELECT * FROM attends "
                + "WHERE Student_ID = '" + ID
                + "';";


                List<string>[] list = new List<string>[4];
                list[0] = new List<string>();
                list[1] = new List<string>();
                list[2] = new List<string>();
                list[3] = new List<string>();


                if (OpenConnection() == true)
                {


                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataReader dataReader = cmd.ExecuteReader();


                    while (dataReader.Read())
                    {
                        list[0].Add(dataReader["Student_ID"] + "");
                        list[1].Add(dataReader["School_Name"] + "");
                        list[2].Add(dataReader["Start_Date"] + "");
                        list[3].Add(dataReader["End_Date"] + "");
                    }


                    dataReader.Close();


                    CloseConnection();


                    return list;
                }
                else
                {
                    return list;
                }
            }
        }

        public static List<string>[] SelectAllPast(string ID)
        {
            {
                string query = "SELECT * FROM past_student "
                + "WHERE ID = '" + ID
                + "';";

                List<string>[] list = new List<string>[3];
                list[0] = new List<string>();
                list[1] = new List<string>();
                list[2] = new List<string>();


                if (OpenConnection() == true)
                {


                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataReader dataReader = cmd.ExecuteReader();


                    while (dataReader.Read())
                    {
                        list[0].Add(dataReader["ID"] + "");
                        list[1].Add(dataReader["Reason"] + "");
                        list[2].Add(dataReader["Leave_Date"] + "");
                    }


                    dataReader.Close();


                    CloseConnection();


                    return list;
                }
                else
                {
                    return list;
                }
            }
        }

        public static List<string>[] SelectAllReferral(string ID)
        {
            string query = "SELECT * FROM referrals "
            + "WHERE ID = '" + ID
            + "';";


            List<string>[] list = new List<string>[5];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();


            if (OpenConnection() == true)
            {


                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();


                while (dataReader.Read())
                {
                    list[0].Add(dataReader["ID"] + "");
                    list[1].Add(dataReader["Referral_Number"] + "");
                    list[2].Add(dataReader["Referral_Date"] + "");
                    list[3].Add(dataReader["Type"] + "");
                    list[4].Add(dataReader["Description"] + "");
                }


                dataReader.Close();


                CloseConnection();


                return list;
            }
            else
            {
                return list;
            }
        }

        public static int getMin(string table, string col)
        {
            string query = "SELECT MIN(" + col + ") AS min FROM " + table + ";";

            if (OpenConnection() == true)
            {

                int returnval = 0;
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    returnval = Int32.Parse(dataReader["min"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                return returnval;
                
            }
            else
            {
                return 0;
            }
        }

        public static int getMax(string table, string col)
        {
            string query = "SELECT MAX(" + col + ") AS max FROM " + table + ";";

            if (OpenConnection() == true)
            {

                int returnval = 0;
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    returnval = Int32.Parse(dataReader["max"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                return returnval;

            }
            else
            {
                return 0;
            }
        }

        public static List<string> selectCol(string table, string col)
        {
            string query = "SELECT DISTINCT " + col + " FROM " + table + ";";

            if (OpenConnection() == true)
            {

                List<string> returnval = new List<string>();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    returnval.Add(dataReader[col] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                return returnval;

            }
            else
            {
                return null;
            }
        }



        public static int getMinGPA()
        {
            return getMin("cum_GPA", "GPA");
        }

        public static int getMaxGPA()
        {
            return getMax("cum_GPA", "GPA");
        }

        public static List<string> getSchools()
        {
            return selectCol("school", "Name");
        }

        public static List<string> getStudentIDs()
        {
            return selectCol("Student", "ID");
        }
        public static int getMinGrade()
        {
            return getMin("Student", "Grade_Level");
        }

        public static int getMaxGrade()
        {
            return getMax("Student", "Grade_Level");
        }

        public static int getMinReferrals()
        {
            string query = "SELECT MIN(mycount) AS min FROM(SELECT id, COUNT(id) mycount FROM referrals GROUP BY id) AS MyCounts;";

            if (OpenConnection() == true)
            {

                int returnval = 0;
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    returnval = Int32.Parse(dataReader["min"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                return returnval;

            }
            else
            {
                return 0;
            }
        }

        public static int getMaxReferrals()
        {
            string query = "SELECT MAX(mycount) AS max FROM(SELECT id, COUNT(id) mycount FROM referrals GROUP BY id) AS MyCounts;";
            if (OpenConnection() == true)
            {

                int returnval = 0;
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    returnval = Int32.Parse(dataReader["max"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                CloseConnection();

                return returnval;

            }
            else
            {
                return 0;
            }
        }

        public static int getMinDaysMissed()
        {
            return getMin("Student", "Days_Missed");
        }

        public static int getMaxDaysMissed()
        {
            return getMax("Student", "Days_Missed");
        }

        public static List<string> getGenders()
        {
            return selectCol("student", "gender");
        }

        public static List<string> getRaces()
        {
            return selectCol("student", "race");
        }

        public static List<string> getCurrentStudentOptions()
        {
            List<string> options = new List<string>();
            options.Add("current");
            options.Add("alumni");

            return options;
        }

        public static List<string>[] filterSelectStudent(int minGPA, int maxGPA, List<string> schools, int minGrade, int maxGrade, int minReferrals, int maxReferrals, int minDaysMissed, int maxDaysMissed, List<string> genders, List<string> races, List<string> statuses)
        {
            return new List<string>[1];
        }
    }
}
