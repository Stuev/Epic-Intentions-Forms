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
                catch
                {
                    MessageBox.Show("Please update the database to the current one on the Google Drive. -Elie, 11/5/16");
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
                        list.Add(dataReader["GPA_Num"] + "");
                    }


                    dataReader.Close();


                    CloseConnection();


                    return list;

                }
                catch
                {
                    MessageBox.Show("Please update the database to the current one on the Google Drive. -Elie, 11/5/16");
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

        public static void UpdateUnCumGPA(string ID, string newGPA, string oldGPAID)
        {
            string query = "UPDATE un_cum_gpa SET GPA = '" + newGPA
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


        public static void UpdateAttends(string ID, string school, string staDate, string endDate)
        {

            string query; 
            if (endDate == "")
            {
                query = "UPDATE attends SET Start_Date = \"" + staDate
                + "\" WHERE Student_ID = \"" + ID
                + "\" AND School_Name = \"" + school
                + "\";";
            }
            else
            {
                 query = "UPDATE attends SET Start_Date = \"" + staDate
                    + "\", End_Date = \"" + endDate
                    + "\" WHERE Student_ID = \"" + ID
                    + "\" AND School_Name = \"" + school
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

        public static void UpdatePastStudent(string ID, string reason, string date)
        {
            string query = "UPDATE past_student SET Reason = @reason,"
                + "Leave_Date = '" + date
                + "' WHERE ID = '" + ID
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


        public static void UpdateSchoolName(string oldSchool, string newSchool)
        {
            string query = "UPDATE school SET Name= '" + newSchool
                + "'WHERE Name= '" + oldSchool
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

        public static void InsertToPastStudent()
        {

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

        public static bool InsertUnCumGPA(string ID, string GPA, string Date)
        {
            string query = "INSERT INTO un_cum_gpa SET ID = '" + ID + "',"
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

        public static void InsertAttends(string schoolStart, int id, string school)
        {
            string query = "INSERT INTO attends SET Start_Date = '" + schoolStart
                + "', Student_ID = '" + id
                + "', School_Name = '" + school
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

        public static List<string> getClasses()
        {
            return selectCol("un_cum_gpa", "Class");
        }

        public static int getMinClassGrade()
        {
            return getMin("un_cum_gpa", "Grade");
        }

        public static int getMaxClassGrade()
        {
            return getMax("un_cum_gpa", "Grade");
        }

        public static List<string> getCurrentStudentOptions()
        {
            List<string> options = new List<string>();
            options.Add("1");
            options.Add("0");

            return options;
        }

        public static string genTextOrComp(List<string> items, string colName)
        {
            string orComp = "(" + colName + " = '" + items[0] + "'";
            for (int i = 1; i < items.Count(); i++ )
            {
                orComp += " OR " + colName + " = '" + items[i] + "'";
            }
            orComp += ")";
            return orComp;
        }

        public static string genIntOrComp(List<string> items, string colName)
        {
            string orComp = "(" + colName + " = " + items[0];
            for (int i = 1; i < items.Count(); i++)
            {
                orComp += " OR " + colName + " = " + items[i];
            }
            orComp += ")";
            return orComp;
        }

        public static List<string>[] filterSelectStudent(float minGPA, float maxGPA, List<string> schools, int minGrade, int maxGrade, int minReferrals, int maxReferrals, int minDaysMissed, int maxDaysMissed, List<string> genders, List<string> races, List<string> statuses, int minClassGrade, int maxClassGrade, List<string> classes)
        {
            string schoolComp = genTextOrComp(schools, "School_Name");
            string genderComp = genTextOrComp(genders, "Gender");
            string raceComp = genTextOrComp(races, "Race");
            string statusComp = genIntOrComp(statuses, "isCurrent");
            string classComp = genTextOrComp(classes, "Class");

            string query = "SELECT * FROM student INNER JOIN cum_gpa ON student.ID = cum_gpa.ID INNER JOIN attends ON cum_gpa.ID = attends.student_ID INNER JOIN un_cum_gpa ON cum_gpa.ID = un_cum_gpa.ID INNER JOIN (SELECT id, COUNT(id)referral_count FROM referrals GROUP BY id) AS MyCounts ON cum_gpa.ID = MyCounts.id WHERE (GPA between " + minGPA + " AND " + maxGPA + ") AND " + schoolComp + " AND (Grade_Level between " + minGrade + " AND " + maxGrade + ") AND (referral_count between " + minReferrals + " AND " + maxReferrals + ") AND (Days_Missed between " + minDaysMissed + " AND " + maxDaysMissed + ") AND " + genderComp + " AND " + raceComp + " AND " + statusComp + " AND " + classComp + " AND (Grade between " + minClassGrade + " AND " + maxClassGrade + ");";
            System.Diagnostics.Debug.WriteLine(query);

            if (OpenConnection() == true)
            {

                List<string>[] returnval = new List<string>[20];
                for (int i = 0; i < 20; i++)
                {
                    returnval[i] = new List<string>();
                }
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
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
