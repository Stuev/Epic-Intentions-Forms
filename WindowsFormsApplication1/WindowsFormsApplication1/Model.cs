using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApplication1
{
    class Model
    {
        private static MySqlConnection connection;
        private static string server;
        private static string database;
        private static string uid;
        private static string password;
        private static long numGenCalls = 0;
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
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex);
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
        public static void UpdateStudentTable(string ID, string first, string last,
            string Grade, string Modified, string Reg,
            string Gen, string Rac, string daysMi)
        {
            //Set up a SQL query, plugging in the passed in values into the strings
            string query = "UPDATE student SET First_Name = \"" + first
                + "\", Last_Name = \"" + last
                + "\", Grade_Level =\"" + Grade
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
                    CloseConnection();
                }
            }
        }

        public static void UpdateStudentTableGradeDate(string ID, string Modified)
        {
            //Set up a SQL query, plugging in the passed in values into the strings
            string query = "UPDATE student SET Grade_Modified_Date = \"" + Modified
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
                    CloseConnection();
                }
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
                    CloseConnection();
                }
            }
        }

        public static List<string> SelectCumGPAID(string ID)
        {
            string query = "SELECT * FROM cum_gpa "
            + "WHERE ID = '" + ID
            + "';";

            List<string> list = new List<string>();


            if (OpenConnection() == true)
            {

                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        list.Add(dataReader["GPA_Num"] + "");
                    }


                    dataReader.Close();


                    CloseConnection();


                    return list;

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    CloseConnection();
                    return list;
                }
            }
            else
            {
                return list;
            }
        }

        public static List<string> SelectAttendsID(string ID)
        {
            string query = "SELECT * FROM attends "
            + "WHERE Student_ID = '" + ID
            + "';";

            List<string> list = new List<string>();


            if (OpenConnection() == true)
            {

                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        list.Add(dataReader["Attends_Num"] + "");
                    }


                    dataReader.Close();


                    CloseConnection();


                    return list;

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    CloseConnection();
                    return list;
                }
            }
            else
            {
                return list;
            }
        }

        public static List<string> SelectAllPastID(string ID)
        {
            string query = "SELECT * FROM past_student "
            + "WHERE ID = '" + ID
            + "';";

            List<string> list = new List<string>();


            if (OpenConnection() == true)
            {

                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        list.Add(dataReader["Past_ID"] + "");
                    }


                    dataReader.Close();


                    CloseConnection();


                    return list;

                }
                catch
                {
                    MessageBox.Show("Please update the database to the current one on the Google Drive. -Elie, 11/13/16");
                    return list;
                }
            }
            else
            {
                return list;
            }
        }

        public static List<string> SelectUnCumGPAID(string ID)
        {
            string query = "SELECT * FROM un_cum_gpa "
            + "WHERE ID = '" + ID
            + "';";

            List<string> list = new List<string>();


            if (OpenConnection() == true)
            {

                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        list.Add(dataReader["Grade_Num"] + "");
                    }


                    dataReader.Close();


                    CloseConnection();


                    return list;

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    CloseConnection();
                    return list;
                }


            }
            else
            {
                return list;
            }
        }



        public static void UpdateCumGPA(string ID, string newGPA, string oldGPAID)
        {
            string query = "UPDATE cum_gpa SET GPA = '" + newGPA
                + "' WHERE GPA_Num = '" + oldGPAID
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
                    CloseConnection();
                }
            }
        }

        public static void UpdateUnCumGPA(string ID, string newGPA, string className, string oldGPAID)
        {
            string query = "UPDATE un_cum_gpa SET Grade = '" + newGPA
                + "', Class = @className "
                + " WHERE Grade_Num = '" + oldGPAID
                + "';";

            if (OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@className", className);

                    cmd.Connection = connection;

                    cmd.ExecuteNonQuery();

                    CloseConnection();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    CloseConnection();
                }
            }
        }


        public static void UpdateAttends(string staDate, string endDate, string attendsNum)
        {

            string query; 
            if (endDate == "")
            {
                query = "UPDATE attends SET Start_Date = \"" + staDate
                + "\" WHERE Attends_Num = \"" + attendsNum
                + "\";";
            }
            else
            {
                 query = "UPDATE attends SET Start_Date = \"" + staDate
                    + "\", End_Date = \"" + endDate
                    + "\" WHERE Attends_Num = \"" + attendsNum
                    + "\";";
            }
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
                    CloseConnection();
                }
            }
        }

        public static void UpdateCurSchoolToPast(string ID, string endDate)
        {

            string query;


            query = "UPDATE attends SET End_Date = \"" + endDate
            + "\" WHERE Student_ID = \"" + ID
            + "\" AND End_Date IS NULL;";
            
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
                    CloseConnection();
                }
            }
        }


        public static int convertGPA(double gpa)
        {
            if (gpa >= 90)
            {
                return 4;
            }
            else if (gpa >= 80)
            {
                return 3;
            }
            else if (gpa >= 70)
            {
                return 2;
            }
            else if (gpa >= 60)
            {
                return 1;
            }
            else return 0;
        }
        public static void UpdateReferrals (string RefID, string RefDate, string Type, string Description)
        {
            string query = "UPDATE referrals SET Referral_Date = @RefDate, "
                + " Type = @type, "
                + " Description = @Descr "
                + " WHERE Referral_Number = @RefID;";

            if (OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@RefDate", RefDate);
                    cmd.Parameters.AddWithValue("@type", Type);
                    cmd.Parameters.AddWithValue("@Descr", Description);
                    cmd.Parameters.AddWithValue("@RefID", RefID);

                    cmd.Connection = connection;

                    cmd.ExecuteNonQuery();

                    CloseConnection();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    CloseConnection();
                }
            }
        }

        public static void UpdatePastStudent(string pastID, string reason, string date)
        {
            string query = "UPDATE past_student SET Reason = @reason,"
                + "Leave_Date = '" + date
                + "' WHERE Past_ID = '" + pastID
                + "';";

            if (OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@reason", reason);



                    cmd.Connection = connection;

                    cmd.ExecuteNonQuery();

                    CloseConnection();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    CloseConnection();
                }
            }
        }




        public static void UpdateEndDate(string ID, string newDate)
        {
            string query = "UPDATE attends SET End_Date= '" + newDate
                + "'WHERE ID = '" + ID
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
                    CloseConnection();
                }
            }
        }

        public static void SetStudentStatusPast(string ID)
        {
            string query = "UPDATE student SET isCurrent= '0' WHERE ID = '" + ID + "';";

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
                    CloseConnection();
                }
            }
        }

        public static void SetStudentStatusCurrent(string ID)
        {
            string query = "UPDATE student SET isCurrent= '1' WHERE ID = '" + ID + "';";

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
                    CloseConnection();
                }
            }
        }



        public static void UpdateSchoolName(string oldSchool, string newSchool)
        {
            string query = "UPDATE school SET Name= @newSchool WHERE Name= '" + oldSchool
                + "';";

            if (OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@newSchool", newSchool);

                    cmd.Connection = connection;

                    cmd.ExecuteNonQuery();

                    CloseConnection();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    CloseConnection();
                }
            }
        }

        public static bool SchoolExists(String SchoolName)
        {
            string query = "SELECT * FROM school WHERE Name = @SchoolName;";

            List<string> school = new List<string>();
            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@SchoolName", SchoolName);


                MySqlDataReader dataReader = cmd.ExecuteReader();


                while (dataReader.Read())
                {
                    school.Add(dataReader["Name"] + "");
                }



                dataReader.Close();


                CloseConnection();

                return (school.Count > 0);
            }

            else
            {
                return false;
            }

        }

        public static bool StudentExists(String ID)
        {
            string query = "SELECT * FROM student WHERE ID = '" + ID + "';";

            List<string> student = new List<string>();
            if (OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);


                MySqlDataReader dataReader = cmd.ExecuteReader();


                while (dataReader.Read())
                {
                    student.Add(dataReader["ID"] + "");
                }



                dataReader.Close();


                CloseConnection();

                return (student.Count > 0);
            }

            else
            {
                return false;
            }

        }

        //INSERT INTO `referrals` (`ID`, `Referral_Date`, `Type`, `Description`) 
        //VALUES('1', '2016-02-01', 'Fighting', 'Fight');

        public static bool InsertReferral(string ID, string Date, string Type, string Desc)
        {
            string query = "INSERT INTO referrals SET ID = '" + ID + "',"
                + " Referral_Date = '" + Date + "', "
                + " Type = @Type, "
                + " Description = @Desc ;";

            if (StudentExists(ID) && OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.CommandText = query;
                    
                    cmd.Parameters.AddWithValue("@Type", Type);
                    cmd.Parameters.AddWithValue("@Desc", Desc);

                    cmd.Connection = connection;

                    cmd.ExecuteNonQuery();

                    CloseConnection();
                    return true;

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    CloseConnection();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static bool InsertPast(string ID, string Reason, string Date)
        {
            string query = "INSERT INTO past_student SET ID = '" + ID + "',"
                + " Leave_Date = '" + Date + "', "
                + " Reason = @Reason ;";

            if (StudentExists(ID) && OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.CommandText = query;

                    cmd.Parameters.AddWithValue("@Reason", Reason);

                    cmd.Connection = connection;

                    cmd.ExecuteNonQuery();

                    CloseConnection();
                    return true;

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    CloseConnection();
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        public static void InsertSchool(String SchoolName)
        {
            string query = "INSERT INTO school SET Name = @SchoolName;";

            if (OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@SchoolName", SchoolName);

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

        public static bool InsertCumGPA(string ID, string GPA, string Date)
        {
            string query = "INSERT INTO cum_gpa SET ID = '" + ID + "',"
                + " GPA_Entry_Date = '" + Date + "', "
                + " GPA = '" + GPA + "';";

            if (StudentExists(ID) && OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.CommandText = query;

                    cmd.Connection = connection;

                    cmd.ExecuteNonQuery();

                    CloseConnection();
                    return true;

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    CloseConnection();
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        public static bool InsertUnCumGPA(string ID, string GPA, string Date, string className)
        {
            string query = "INSERT INTO un_cum_gpa SET ID = '" + ID + "',"
                + " Grade_Entry_Date = '" + Date + "', "
                + " Grade = '" + GPA + "', "
                + " Class = @className;";

            if (StudentExists(ID) && OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@className", className);

                    cmd.Connection = connection;

                    cmd.ExecuteNonQuery();

                    CloseConnection();
                    return true;

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    CloseConnection();
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        public static void InsertAttends(string schoolStart, int id, string school)
        {
            string query = "INSERT INTO attends SET Start_Date = '" + schoolStart
                + "', Student_ID = '" + id
                + "', School_Name = @school;";

            if (OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@school", school);


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
                + "', First_Name = @firstName"
                + ", Last_Name = @lastName"
                + ", Grade_Modified_Date = '" + GradeMod
                + "', Registration_Date = '" + RegDate
                + "', Gender = '" + gender
                + "', Race = @race"
                + ", isCurrent = '" + curStudentInt
                + "', Days_Missed = '" + daysMissed
                + "';";

            if (OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();

                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@race", race);


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
        public static void InsertCumGPA(int studentID, float gpa, string date)
        {
            string query = "INSERT INTO cum_gpa SET ID = '" + studentID
                + "', GPA = '" + gpa
                + "', GPA_Entry_Date = '" + date
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

        public static void InsertEmptyReferrals(int ID, string date, int numRefs)
        {
            for (int i = 0; i < numRefs; i++)
            {
                string query = "INSERT INTO referrals SET ID = '" + ID
                + "', Referral_Date = '" + date
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
            }
            else
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
                        list[0].Add(dataReader["ID"] + "");
                        list[1].Add(dataReader["Grade"] + "");
                        list[2].Add(dataReader["Grade_Entry_Date"] + "");
                        list[3].Add(dataReader["Class"] + "");

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

        public static int numRefsByID(int id)
        {
            string query = "select count(*) from referrals where ID = ";

            query += id;
            int count = 0;

            if (OpenConnection() == true)
            {


                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();

                count = ((int) dataReader["count(*)"]);

                dataReader.Close();


                CloseConnection();
                return count;

            }
            else
            {
                return count;
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







        public static List<string>[] SelectStudent(string ID)
        {
            {
                string query = "SELECT * FROM student "
                + "WHERE ID = '" + ID
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
                        list[0].Add(dataReader["ID"] + "");
                        list[1].Add(dataReader["Grade"] + "");
                        list[2].Add(dataReader["Grade_Entry_Date"] + "");
                        list[3].Add(dataReader["Class"] + "");

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

        public static float getMin(string table, string col)
        {
            string query = "SELECT MIN(" + col + ") AS min FROM " + table + ";";
            System.Diagnostics.Debug.WriteLine(query);

            try {
                if (OpenConnection() == true)
                {

                    float returnval = 0;
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        returnval = float.Parse(dataReader["min"] + "");
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
            catch (Exception ex)
            {
                CloseConnection();
                return 0;
            }
        }

        public static float getMax(string table, string col)
        {
            string query = "SELECT MAX(" + col + ") AS max FROM " + table + ";";

            try
            {
                if (OpenConnection() == true)
                {

                    float returnval = 0;
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        returnval = float.Parse(dataReader["max"] + "");
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
            catch (Exception ex)
            {
                CloseConnection();
                return 0;
            }
        }

        public static List<string> selectCol(string table, string col)
        {
            string query = "SELECT DISTINCT CONCAT(" + col + ") as col FROM " + table + ";";

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
                    returnval.Add(dataReader["col"] + "");
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



        public static float getMinGPA()
        {
            return getMin("cum_GPA", "GPA");
        }

        public static float getMaxGPA()
        {
            return getMax("cum_GPA", "GPA");
        }

        public static List<string> getSchools()
        {
            return selectCol("school", "Name");
        }

        public static string getSchoolByID(int id)
        {
            string query = "SELECT School_Name FROM attends "
            + "WHERE ID = '" + id
            + "';";
            string school = "";
            if (OpenConnection() == true)
            {


                MySqlCommand cmd = new MySqlCommand(query, connection);

                MySqlDataReader dataReader = cmd.ExecuteReader();


                school = dataReader["School_Name"] + "";


                dataReader.Close();


                CloseConnection();


                return school;
            } else
            {
                return "";
            }

        }

        public static List<string> getStudentIDs()
        {
            return selectCol("Student", "ID");
        }
        public static int getMinGrade()
        {
            return (int) getMin("Student", "Grade_Level");
        }

        public static int getMaxGrade()
        {
            return (int) getMax("Student", "Grade_Level");
        }

        public static int getMinReferrals()
        {
            string query = "select min(coalesce(mc.referral_count, 0)) as min from student left join (SELECT id, count(id)referral_count, Referral_Date, Type, Description FROM referrals GROUP BY id) as mc on student.ID=mc.id;";


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
            return (int) getMin("Student", "Days_Missed");
        }

        public static int getMaxDaysMissed()
        {
            return (int) getMax("Student", "Days_Missed");
        }

        public static List<string> getGenders()
        {
            return selectCol("student", "gender");
        }

        public static List<string> getRaces()
        {
            return selectCol("student", "race");
        }

        public static List<string> getClasses()
        {
            return selectCol("un_cum_gpa", "Class");
        }

        public static int getMinClassGrade()
        {
            return (int) getMin("un_cum_gpa", "Grade");
        }

        public static int getMaxClassGrade()
        {
            return (int) getMax("un_cum_gpa", "Grade");
        }

        public static List<string> getCurrentStudentOptions()
        {
            List<string> options = new List<string>();
            options.Add("Yes");
            options.Add("No");

            return options;
        }

        public static List<string> getUnCumIds()
        {
            return selectCol("un_cum_gpa", "ID");
        }

        public static List<string> getUnCumClasses()
        {
            return selectCol("un_cum_gpa", "Class");
        }

        public static List<string> getUnCumGrades()
        {
            return selectCol("un_cum_gpa", "Grade");
        }

        public static List<string> getUnCumDates()
        {
            return selectCol("un_cum_gpa", "Grade_Entry_Date");
        }

        public static void deleteUnCum(List<string> id, List<string> classes,  List<string> grade, List<string> date)
        {


            if (OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    string query = "DELETE FROM un_cum_gpa WHERE";
                    genIntOrComp(id, "ID", cmd, true);
                    for (int i = 0; i < id.Count(); i++)
                    {
                        string tag = "@" + i + "_" + numGenCalls;
                        //cmd.CommandText += " OR " + colName + " = " + tag;
                        //MessageBox.Show(cmd.CommandText + "\n" + tag);
                        cmd.Parameters.Add(tag, SqlDbType.Int);
                        cmd.Parameters[tag].Value = Int32.Parse(id[i]);
                    }
                    genTextOrComp(classes, "Class", cmd, false);
                    for (int i = 0; i < classes.Count(); i++)
                    {
                        string tag = "@" + i + "_" + numGenCalls;
                        //cmd.CommandText += " OR " + colName + " = " + tag;
                        //MessageBox.Show(cmd.CommandText + "\n" + tag);
                        cmd.Parameters.AddWithValue(tag, classes[i]);
                        //cmd.Parameters.Add(tag, SqlDbType.VarChar);
                        //cmd.Parameters[tag].Value = classes[i];


                    }
                    genFloatOrComp(grade, "Grade", cmd, false);
                    genDateOrComp(date, "Grade_Entry_Date", cmd, false);
                    cmd.CommandText += ";";

                    cmd.CommandText = query;

                    cmd.Connection = connection;

                    cmd.ExecuteNonQuery();

                    CloseConnection();
                    MessageBox.Show("Delete succesful");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    CloseConnection();
                }
            }
        }

        public static List<string> getRefIds()
        {
            return selectCol("referrals", "ID");
        }

        public static List<string> getRefTypes()
        {
            return selectCol("referrals", "Type");
        }

        public static List<string> getRefDates()
        {
            return selectCol("referrals", "Referral_Date");
        }

        public static void deleteRef(List<string> id, List<string> type, List<string> date)
        {

            

            if (OpenConnection() == true)
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand();
                    string query = "DELETE FROM referrals WHERE ";
                    cmd.CommandText = query;
                    genIntOrComp(id, "ID", cmd, true);
                    for (int i = 0; i < id.Count(); i++)
                    {
                        string tag = "@" + i + "_" + numGenCalls;
                        //cmd.CommandText += " OR " + colName + " = " + tag;
                        //MessageBox.Show(cmd.CommandText + "\n" + tag);
                        cmd.Parameters.Add(tag, SqlDbType.Int);
                        cmd.Parameters[tag].Value = Int32.Parse(id[i]);
                    }
                    genTextOrComp(type, "Type", cmd, false);
                    for (int i = 0; i < type.Count(); i++)
                    {
                        string tag = "@" + i + "_" + numGenCalls;
                        //cmd.CommandText += " OR " + colName + " = " + tag;
                        //MessageBox.Show(cmd.CommandText + "\n" + tag);
                        cmd.Parameters.AddWithValue(tag, type[i]);
                        //cmd.Parameters.Add(tag, SqlDbType.VarChar);
                        //cmd.Parameters[tag].Value = type[i];
                    }
                    genDateOrComp(date, "Referral_Date", cmd, false);
                    cmd.CommandText += ";";

                    cmd.Connection = connection;

                    cmd.ExecuteNonQuery();

                    CloseConnection();
                    MessageBox.Show("Delete succesful");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    CloseConnection();
                }
            }
        }

        public static List<string> getStudentIds()
        {
            return selectCol("student", "ID");
        }

        public static List<string> getStudentFnames()
        {
            return selectCol("student", "First_Name");
        }

        public static List<string> getStudentLnames()
        {
            return selectCol("student", "Last_Name");
        }

        public static void deleteStudent(List<string> id, List<string> fnames, List<string> lnames)
        {
            

            if (OpenConnection() == true)
            {
                try
                {
                    string query = "DELETE FROM student WHERE ";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.CommandText = query;
                    genIntOrComp(id, "ID", cmd, true);
                    for (int i = 0; i < id.Count(); i++)
                    {
                        string tag = "@" + i + "_" + numGenCalls;
                        //cmd.CommandText += " OR " + colName + " = " + tag;
                        //MessageBox.Show(cmd.CommandText + "\n" + tag);
                        cmd.Parameters.Add(tag, SqlDbType.Int);
                        cmd.Parameters[tag].Value = Int32.Parse(id[i]);
                    }
                    genTextOrComp(fnames, "First_Name", cmd, false);
                    for (int i = 0; i < fnames.Count(); i++)
                    {
                        string tag = "@" + i + "_" + numGenCalls;
                        //cmd.CommandText += " OR " + colName + " = " + tag;
                        //MessageBox.Show(cmd.CommandText + "\n" + tag);
                        cmd.Parameters.AddWithValue(tag, fnames[i]);
                        //cmd.Parameters.Add(tag, SqlDbType.VarChar);
                        //cmd.Parameters[tag].Value = "'" + fnames[i] + "'";

                    }
                    genTextOrComp(lnames, "Last_name", cmd, false);
                    for (int i = 0; i < lnames.Count(); i++)
                    {
                        string tag = "@" + i + "_" + numGenCalls;
                        //cmd.CommandText += " OR " + colName + " = " + tag;
                        //MessageBox.Show(cmd.CommandText + "\n" + tag);
                        cmd.Parameters.AddWithValue(tag, lnames[i]);
                        //cmd.Parameters.Add(tag, SqlDbType.VarChar);
                        //cmd.Parameters[tag].Value = "'" + lnames[i] + "'";
                        //System.Diagnostics.Debug.WriteLine(cmd.Parameters.);


                    }
                    cmd.CommandText += ";";
                    System.Diagnostics.Debug.WriteLine(cmd.CommandText);

                    cmd.Connection = connection;

                    cmd.ExecuteNonQuery();

                    CloseConnection();
                    MessageBox.Show("Delete succesful");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    CloseConnection();
                }
            }
        }

        public static List<string> getCumIds()
        {
            return selectCol("cum_gpa", "ID");
        }

        public static List<string> getCumGPAs()
        {
            return selectCol("cum_gpa", "GPA");
        }

        public static List<string> getCumDates()
        {
            return selectCol("cum_gpa", "GPA_Entry_Date");
        }

        public static void deleteCum(List<string> id, List<string> grade, List<string> date)
        {

            string saved = "";
            if (OpenConnection() == true)
            {
                try
                {

                    string query = "DELETE FROM cum_gpa WHERE ";
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = query;
                    genIntOrComp(id, "ID", cmd, true);
                    for (int i = 0; i < id.Count(); i++)
                    {
                        string tag = "@" + i + "_" + numGenCalls;
                        //cmd.CommandText += " OR " + colName + " = " + tag;
                        //MessageBox.Show(cmd.CommandText + "\n" + tag);
                        cmd.Parameters.Add(tag, SqlDbType.Int);
                        cmd.Parameters[tag].Value = Int32.Parse(id[i]);
                        //cmd.Parameters.AddWithValue(tag, id[i]);

                    }
                    genFloatOrComp(grade, "GPA", cmd, false);
                    genDateOrComp(date, "GPA_Entry_Date", cmd, false);
                    cmd.CommandText += ";";
                    cmd.Connection = connection;
                    saved = cmd.CommandText;
                    System.Diagnostics.Debug.WriteLine(cmd.CommandText);

                    cmd.ExecuteNonQuery();

                    CloseConnection();
                    MessageBox.Show("Delete succesful");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + saved);
                    CloseConnection();
                }
            }
        }

        public static string genTextOrComp(List<string> items, string colName, MySqlCommand cmd, bool isFirst)
        {
            numGenCalls++;
            if (!isFirst)
            {
                cmd.CommandText += " AND ";
            }
            string tag = "@0_" + numGenCalls;
            cmd.CommandText += "(" + colName + " = " + tag;
            //cmd.Parameters.AddWithValue(tag, "'" + items[0] + "'");
            for (int i = 1; i < items.Count(); i++ )
            {
                tag = "@" + i + "_" + numGenCalls;
                cmd.CommandText += " OR " + colName + " = " + tag;
                //MessageBox.Show(cmd.CommandText + "\n" + tag);
                //cmd.Parameters.AddWithValue(tag, "'" + items[i] + "'");
            }
            cmd.CommandText += ")";
            return cmd.CommandText;
        }

        public static string genDateOrComp(List<string> items, string colName, MySqlCommand cmd, bool isFirst)
        {
            if (!isFirst)
            {
                cmd.CommandText += " AND ";
            }
            cmd.CommandText += "(" + colName + " = '" + items[0] + "'";
            for (int i = 1; i < items.Count(); i++)
            {
                cmd.CommandText += " OR " + colName + " = '" + items[i] + "'";
            }
            cmd.CommandText += ")";
            return cmd.CommandText;
        }

        public static string genFloatOrComp(List<string> items, string colName, MySqlCommand cmd, bool isFirst)
        {
            if (!isFirst)
            {
                cmd.CommandText += " AND ";
            }
            cmd.CommandText += "(((" + colName + " - " + items[0] + ") between -.0001 AND .0001)";
            for (int i = 1; i < items.Count(); i++)
            {
                cmd.CommandText += " OR ((" + colName + " - " + items[i] + ") between -.0001 AND .0001)";
            }
            cmd.CommandText += ")";
            return cmd.CommandText;
        }

        public static string genIntOrComp(List<string> items, string colName, MySqlCommand cmd, bool isFirst)
        {
            numGenCalls++;
            if (!isFirst)
            {
                cmd.CommandText += " AND ";
            }
            string tag = "@0_" + numGenCalls;
            cmd.CommandText += "(" + colName + " = " + tag;
            //cmd.Parameters.AddWithValue(tag, items[0]);

            for (int i = 1; i < items.Count(); i++)
            {
                tag = "@" + i + "_" + numGenCalls;
                cmd.CommandText += " OR " + colName + " = " + tag;
                //MessageBox.Show(cmd.CommandText + "\n" + tag);
                //cmd.Parameters.AddWithValue(tag, items[i]);

            }
            cmd.CommandText += ")";
            return cmd.CommandText;
        }



        public static List<string>[] filterSelectStudent(float minGPA, float maxGPA, List<string> schools, int minGrade, int maxGrade, int minReferrals, int maxReferrals, int minDaysMissed, int maxDaysMissed, List<string> genders, List<string> races, List<string> statuses, float minClassGrade, float maxClassGrade, List<string> classes)
        {
            string query = query = "SELECT student.ID, CONCAT(attends.Start_Date) as Start_Date, CONCAT(attends.End_Date) as End_Date, attends.School_Name, cum_gpa.GPA, CONCAT(cum_gpa.GPA_Entry_Date) as GPA_Entry_Date, CONCAT(MyCounts.Referral_Date), coalesce(MyCounts.referral_count, 0) as referral_count, MyCounts.Type, MyCounts.Description, student.First_Name, student.Last_Name, student.Grade_Level, CONCAT(student.Grade_Modified_Date) as Grade_Modified_Date, CONCAT(student.Registration_Date) as Registration_Date, student.Gender, student.Race, student.isCurrent, student.Days_Missed, un_cum_gpa.Grade_Num, un_cum_gpa.Class, un_cum_gpa.Grade, CONCAT(un_cum_gpa.Grade_Entry_Date) as Grade_Entry_Date FROM student LEFT JOIN cum_gpa ON student.ID = cum_gpa.ID LEFT JOIN attends ON cum_gpa.ID = attends.student_ID LEFT JOIN un_cum_gpa ON cum_gpa.ID = un_cum_gpa.ID left JOIN (SELECT id, count(id)referral_count, Referral_Date, Type, Description FROM referrals GROUP BY id) AS MyCounts ON cum_gpa.ID = MyCounts.id WHERE (coalesce(GPA, -1) between @minGPA AND @maxGPA) AND (Grade_Level between @minGrade AND @maxGrade ) AND (coalesce(referral_count, 0) between @minReferrals AND @maxReferrals) AND (Days_Missed between @minDaysMissed AND @maxDaysMissed) AND (coalesce(GRADE, -1) between " + (minClassGrade - .00001) + " AND " + (maxClassGrade + .00001) + ")";
            MySqlCommand cmd = new MySqlCommand(query, connection);

            if (schools != null && getSchools() != null && schools.Count() < getSchools().Count())
            {
                System.Diagnostics.Debug.WriteLine(schools[0]);

                genTextOrComp(schools, "School_Name", cmd, false);
                for (int i = 0; i < schools.Count(); i++)
                {
                    string tag = "@" + i + "_" + numGenCalls;
                    //cmd.CommandText += " OR " + colName + " = " + tag;
                    //MessageBox.Show(cmd.CommandText + "\n" + tag);
                    cmd.Parameters.AddWithValue(tag, schools[i]);
                    //cmd.Parameters.Add(tag, SqlDbType.VarChar);
                    //cmd.Parameters[tag].Value = "'" + lnames[i] + "'";
                    //System.Diagnostics.Debug.WriteLine(cmd.Parameters.);


                }
            }
            if (genders != null && getGenders() != null && genders.Count() < getGenders().Count())
            {
                genTextOrComp(genders, "Gender", cmd, false);
                for (int i = 0; i < genders.Count(); i++)
                {
                    string tag = "@" + i + "_" + numGenCalls;
                    //cmd.CommandText += " OR " + colName + " = " + tag;
                    //MessageBox.Show(cmd.CommandText + "\n" + tag);
                    cmd.Parameters.AddWithValue(tag, genders[i]);
                    //cmd.Parameters.Add(tag, SqlDbType.VarChar);
                    //cmd.Parameters[tag].Value = "'" + lnames[i] + "'";
                    //System.Diagnostics.Debug.WriteLine(cmd.Parameters.);


                }
            }
            if (races != null && getRaces() != null && races.Count() < getRaces().Count())
            {
                genTextOrComp(races, "Race", cmd, false);
                for (int i = 0; i < races.Count(); i++)
                {
                    string tag = "@" + i + "_" + numGenCalls;
                    //cmd.CommandText += " OR " + colName + " = " + tag;
                    //MessageBox.Show(cmd.CommandText + "\n" + tag);
                    cmd.Parameters.AddWithValue(tag, races[i]);
                    //cmd.Parameters.Add(tag, SqlDbType.VarChar);
                    //cmd.Parameters[tag].Value = "'" + lnames[i] + "'";
                    //System.Diagnostics.Debug.WriteLine(cmd.Parameters.);


                }
            }
            string[] status = { "1", "0" };
            if (statuses.Count() < 2)
            {
                genIntOrComp(statuses, "isCurrent", cmd, false);
                for (int i = 0; i < status.Count(); i++)
                {
                    string tag = "@" + i + "_" + numGenCalls;
                    //cmd.CommandText += " OR " + colName + " = " + tag;
                    //MessageBox.Show(cmd.CommandText + "\n" + tag);
                    //cmd.Parameters.AddWithValue(tag, lnames[i]);
                    cmd.Parameters.Add(tag, SqlDbType.Int);
                    cmd.Parameters[tag].Value = Int32.Parse(status[i]);
                    //System.Diagnostics.Debug.WriteLine(cmd.Parameters.);


                }

            }
            if (classes != null && getClasses() != null && classes.Count() < getClasses().Count())
            {
                genTextOrComp(classes, "Class", cmd, false);
                for (int i = 0; i < classes.Count(); i++)
                {
                    string tag = "@" + i + "_" + numGenCalls;
                    //cmd.CommandText += " OR " + colName + " = " + tag;
                    //MessageBox.Show(cmd.CommandText + "\n" + tag);
                    cmd.Parameters.AddWithValue(tag, classes[i]);
                    //cmd.Parameters.Add(tag, SqlDbType.VarChar);
                    //cmd.Parameters[tag].Value = "'" + lnames[i] + "'";
                    //System.Diagnostics.Debug.WriteLine(cmd.Parameters.);


                }
            }

                if (OpenConnection() == true)
            {

                List<string>[] returnval = new List<string>[20];
                for (int i = 0; i < 20; i++)
                {
                    returnval[i] = new List<string>();
                }
                //Create Command
                

                // string query = "SELECT student.ID, CONCAT(attends.Start_Date) as Start_Date, CONCAT(attends.End_Date) as End_Date, attends.School_Name, cum_gpa.GPA, CONCAT(cum_gpa.GPA_Entry_Date) as GPA_Entry_Date, CONCAT(MyCounts.Referral_Date), coalesce(MyCounts.referral_count, 0) as referral_count, MyCounts.Type, MyCounts.Description, student.First_Name, student.Last_Name, student.Grade_Level, CONCAT(student.Grade_Modified_Date) as Grade_Modified_Date, CONCAT(student.Registration_Date) as Registration_Date, student.Gender, student.Race, student.isCurrent, student.Days_Missed, un_cum_gpa.Grade_Num, un_cum_gpa.Class, un_cum_gpa.Grade, CONCAT(un_cum_gpa.Grade_Entry_Date) as Grade_Entry_Date FROM student LEFT JOIN cum_gpa ON student.ID = cum_gpa.ID LEFT JOIN attends ON cum_gpa.ID = attends.student_ID LEFT JOIN un_cum_gpa ON cum_gpa.ID = un_cum_gpa.ID left JOIN (SELECT id, count(id)referral_count, Referral_Date, Type, Description FROM referrals GROUP BY id) AS MyCounts ON cum_gpa.ID = MyCounts.id WHERE (coalesce(GPA, -1) between " + (minGPA - .00001) + " AND " + (maxGPA + .00001) + ") AND (Grade_Level between " + minGrade + " AND " + maxGrade + ") AND (coalesce(referral_count, 0) between " + minReferrals + " AND " + maxReferrals + ") AND (Days_Missed between " + minDaysMissed + " AND " + maxDaysMissed + ") " + conditions + " AND (coalesce(GRADE, -1) between " + (minClassGrade - .00001) + " AND " + (maxClassGrade + .00001) + ");";
                cmd.CommandText += ";";
                cmd.Parameters.AddWithValue("@minGPA", (minGPA - .00001));
                cmd.Parameters.AddWithValue("@maxGPA", (maxGPA + .00001));
                cmd.Parameters.AddWithValue("@minGrade", (minGrade - .00001));
                cmd.Parameters.AddWithValue("@maxGrade", (maxGrade + .00001));
                cmd.Parameters.AddWithValue("@minReferrals", minReferrals);
                cmd.Parameters.AddWithValue("@maxReferrals", maxReferrals);
                cmd.Parameters.AddWithValue("@minDaysMissed", minDaysMissed);
                cmd.Parameters.AddWithValue("@maxDaysMissed", maxDaysMissed);
                //cmd.Parameters.AddWithValue("@conditions", conditions);


                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    returnval[0].Add(dataReader["ID"] + "");
                    returnval[1].Add(dataReader["First_Name"] + "");
                    returnval[2].Add(dataReader["Last_Name"] + "");
                    returnval[3].Add(dataReader["Grade_Level"] + "");
                    returnval[4].Add(dataReader["Grade_Modified_Date"] + "");
                    returnval[5].Add(dataReader["Registration_Date"] + "");
                    returnval[6].Add(dataReader["Gender"] + "");
                    returnval[7].Add(dataReader["Race"] + "");
                    returnval[8].Add(dataReader["isCurrent"] + "");
                    returnval[9].Add(dataReader["Days_Missed"] + "");
                    returnval[10].Add(dataReader["GPA"] + "");
                    returnval[11].Add(dataReader["GPA_Entry_Date"] + "");
                    returnval[12].Add(dataReader["Start_Date"] + "");
                    returnval[13].Add(dataReader["End_Date"] + "");
                    returnval[14].Add(dataReader["School_Name"] + "");
                    returnval[15].Add(dataReader["referral_count"] + "");
                    returnval[16].Add(dataReader["Grade_Num"] + "");
                    returnval[17].Add(dataReader["Class"] + "");
                    returnval[18].Add(dataReader["Grade"] + "");
                    returnval[19].Add(dataReader["Grade_Entry_Date"] + "");
                }

                //close Data Reader
                dataReader.Close();
                
                //close Connection
                CloseConnection();
                System.Diagnostics.Debug.WriteLine(query);
                return returnval;

            }
            else
            {
                return new List<string>[1];
            }
        }
    }
}
