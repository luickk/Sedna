using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Threading;
using System.Net;
using System.Diagnostics;

namespace academic
{
    static class Program
    {
        /// <summary>
        /// Mainenterpoint
        /// </summary>
        public static MySqlConnection connection;


        /// <summary>
        /// Mainfunction
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Program.CheckForInternetConnection())
            {
                connectMYSQL();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Login());
            } else
            {
                System.Windows.Forms.MessageBox.Show("No internet!");
            }
        }

        /// <summary>
        /// Methode to start MYSQL Thread
        /// </summary>
        public static void connectMYSQL()
        {
            Thread workerThread = new Thread(DoMysql);
            workerThread.Start();
        }

        /// <summary>
        /// MYSQL Management
        /// </summary>
        public static void DoMysql()
        {
            //Check internetconnection
            if (Program.CheckForInternetConnection())
            {
                    //RUN -> OK
                    //Define connection
                    connection = new MySqlConnection(@"Server=134.255.234.216;Uid=root;Pwd=" + data.pw + ";Database=academic;");
                    //Open connection
                    connection.Open();
                    //Create tables
                    
                    //Table for teacher ids
                    runMYSQL("CREATE TABLE IF NOT EXISTS IDs(id INT NOT NULL AUTO_INCREMENT, name VARCHAR (128) default NULL, school VARCHAR (64) default NULL , tid VARCHAR (64) default NULL, used VARCHAR (64) default NULL , blocked VARCHAR (64) default NULL ,PRIMARY KEY (id))", connection);
                    //Table for pupils
                    runMYSQL("CREATE TABLE IF NOT EXISTS USER(id INT NOT NULL AUTO_INCREMENT, user_name VARCHAR (128) default NULL, user_pass VARCHAR (64) default NULL, user_class VARCHAR (64) default NULL, user_class_pw VARCHAR (64) default NULL, user_age VARCHAR (64) default NULL, user_school VARCHAR (64) default NULL, email VARCHAR (64) default NULL, chat_ban VARCHAR (64) default NULL, PRIMARY KEY (id))", connection);
                    //Table for teachers
                    runMYSQL("CREATE TABLE IF NOT EXISTS TEACHER(id INT NOT NULL AUTO_INCREMENT, user_name VARCHAR (128) default NULL, user_pass VARCHAR (64) default NULL, user_class VARCHAR (64) default NULL , user_class_pw VARCHAR (64) default NULL, user_age VARCHAR (64) default NULL, user_school VARCHAR (64) default NULL, email VARCHAR (64) default NULL, tel VARCHAR (64) default NULL, email_seeable VARCHAR (64) default NULL, tel_seeable VARCHAR (64) default NULL, tid VARCHAR (64) default NULL, PRIMARY KEY (id))", connection);
                    //Table for classes
                    runMYSQL("CREATE TABLE IF NOT EXISTS CLASSES(id INT NOT NULL AUTO_INCREMENT, class_name VARCHAR (128) default NULL, class_pw VARCHAR (64) default NULL, class_school VARCHAR (64) default NULL , class_teacher VARCHAR (64) default NULL, created_date VARCHAR (64) default NULL, class_id VARCHAR (64) default NULL, teachers VARCHAR (64) default NULL, teacher_calss_pw VARCHAR (64) default NULL, PRIMARY KEY (id))", connection);
                    //Table for chat
                    runMYSQL("CREATE TABLE IF NOT EXISTS CHAT(id INT NOT NULL AUTO_INCREMENT, class VARCHAR (128) default NULL, msg VARCHAR (64) default NULL , sender VARCHAR (64) default NULL, PRIMARY KEY (id))", connection);
                    //Table for msg system
                    runMYSQL("CREATE TABLE IF NOT EXISTS MSG_SYS(id INT NOT NULL AUTO_INCREMENT, sender VARCHAR (128) default NULL, msg VARCHAR (64) default NULL , reciever VARCHAR (64) default NULL, checked VARCHAR (64) default NULL, PRIMARY KEY (id))", connection);
                    //Table for WHITELISTS
                    runMYSQL("CREATE TABLE IF NOT EXISTS WHITELIST(id INT NOT NULL AUTO_INCREMENT, teacher_name VARCHAR (128) default NULL, class_name VARCHAR (128) default NULL, objects VARCHAR (500) default NULL , PRIMARY KEY (id))", connection);
                    //Table for homeworkss
                    runMYSQL("CREATE TABLE IF NOT EXISTS HOMEWORK(id INT NOT NULL AUTO_INCREMENT, hw VARCHAR (128) default NULL, class_name VARCHAR (64) default NULL , PRIMARY KEY (id))", connection);

                    //TEMP


                //RUN -> OK
            }
            else
            {
                //No internet
                System.Windows.Forms.MessageBox.Show("No internet!");
            }
         }


        /// <summary>
        /// Methode to run Mysql commands
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="connection"></param>
        public static void runMYSQL(String cmd, MySqlConnection connection)
        {
            no_internet no_internet = new no_internet();
                if (Program.CheckForInternetConnection())
                {
                //RUN -> OK

                MySqlCommand insertCommand = new MySqlCommand(cmd, connection);
                    insertCommand.ExecuteNonQuery();
                    no_internet.Close();
                    
                    //RUN -> OK

                }
                else
                {
                System.Windows.Forms.MessageBox.Show("No internet!");
            }
        }

        /// <summary>
        /// Methode to run Mysql and return data
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="connection"></param>
        /// <returns></returns>
        public static String runMYSQL_RET(String cmd, MySqlConnection connection)
        {
            MySqlCommand readCommand = new MySqlCommand(cmd, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(readCommand);
            DataTable datatable = new DataTable();

            adapter.Fill(datatable);
            for (int x = 0; x < datatable.Rows.Count; x++)
            {
                object[] values = datatable.Rows[x].ItemArray;
            }

            return datatable.ToString();
        }


        /// <summary>
        /// Methode to check Mysql data
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="connection"></param>
        /// <returns></returns>
        public static bool runMYSQL_EXISTS(String cmd, MySqlConnection connection)
        {
            bool b = false;
            no_internet no_internet = new no_internet();
                MySqlCommand check_User_Name;
                if (Program.CheckForInternetConnection())
                {
                //RUN -> OK

                    check_User_Name = new MySqlCommand(cmd, connection);
                    int UserExist = Convert.ToInt32(check_User_Name.ExecuteScalar());
                    if (UserExist > 0)
                    {
                        return true;
                        b = true;
                        Console.WriteLine("EXISTS");
                    }
                    else
                    {
                        return false;
                        b = false;
                        Console.WriteLine("EXISTS_NOT");
                    }

                    //RUN -> OK
                }
                else
            {
                System.Windows.Forms.MessageBox.Show("No internet!");
            }
                
            return b;
        }

        /// <summary>
        /// Methode to get data from Mysql
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="connection"></param>
        /// <param name="item"></param>
        /// <returns></returns>
        public static String runMYSQL_GET(String cmd, MySqlConnection connection, String item)
        {
            String res = "";
            MySqlCommand cmdd = new MySqlCommand(cmd, connection);

            MySqlDataReader dataReader = cmdd.ExecuteReader();

            while (dataReader.Read())
            {
                try
                {
                    res = dataReader.GetString(item);
                }
                catch (System.IndexOutOfRangeException e)
                {
                    res = "";
                }
            }

            dataReader.Close();

            return res;
        }

        /// <summary>
        /// Methode to count Mysql data
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="connection"></param>
        /// <returns></returns>
        public static int runMYSQL_COUNT(String cmd, MySqlConnection connection)
        {
            int c = 0;
            MySqlCommand cmdd = new MySqlCommand(cmd, connection);
            MySqlDataReader rdr = cmdd.ExecuteReader();
            try
            {
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        c++;
                    }
                }
                else
                {
                    c = 0;
                }
            }
            catch (MySqlException ex)
            {
                c = 0;
            }
            rdr.Close();
            return c;
        }

        /// <summary>
        /// Methode to insert Mysqldata into ListView
        /// </summary>
        /// <param name="myListView"></param>
        /// <param name="query"></param>
        public static void INSERT_LIST_VIEW(ListView myListView, string query)
        {
            myListView.Items.Clear();
            myListView.Columns.Clear();
            myListView.View = View.Details;
            try
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                //Read the data and store them in the listview
                if (dataReader.FieldCount > 0)
                {
                    myListView.Columns.Add("ID", 0, HorizontalAlignment.Left);
                    myListView.Columns.Add("Name", 0, HorizontalAlignment.Left);
                    myListView.Columns.Add("School", 0, HorizontalAlignment.Left);
                    myListView.Columns.Add("Teacher", 0, HorizontalAlignment.Left);
                    myListView.Columns.Add("Created Date", 0, HorizontalAlignment.Left);
                    myListView.Columns.Add("Licence", 0, HorizontalAlignment.Left);
                    myListView.Columns.Add("Teachers", 0, HorizontalAlignment.Left);

                    ListViewItem lv = new ListViewItem();
                    //
                    while (dataReader.Read())
                    {
                        lv = myListView.Items.Add(dataReader[dataReader.GetName(0)].ToString().Replace('_', ' '));
                        for (int h = 1; h < dataReader.FieldCount; h++)
                        {
                            if (!(h == 2))
                            {
                                lv.SubItems.Add(dataReader[dataReader.GetName(h)].ToString());
                            }
                        }
                    }
                }
                for (int i = 1; i < myListView.Columns.Count; i++)
                    myListView.Columns[i].Width = -2;
                dataReader.Close();
                myListView.View = View.Details;
            }
            catch (Exception e)
            {

            }
        }



        /// <summary>
        /// Methode to insert Mysqldata into pupil ListView
        /// </summary>
        /// <param name="myListView"></param>
        /// <param name="query"></param>
        public static void INSERT_LIST_VIEW_USER(ListView myListView, string query)
        {
            myListView.Items.Clear();
            myListView.Columns.Clear();
            myListView.View = View.Details;
            try
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                //Read the data and store them in the listview
                if (dataReader.FieldCount > 0)
                {
                    myListView.Columns.Add("ID", 0, HorizontalAlignment.Left);
                    myListView.Columns.Add("Name", 0, HorizontalAlignment.Left);
                    myListView.Columns.Add("Class", 0, HorizontalAlignment.Left);
                    myListView.Columns.Add("Age", 0, HorizontalAlignment.Left);
                    myListView.Columns.Add("School", 0, HorizontalAlignment.Left);
                    myListView.Columns.Add("Email", 0, HorizontalAlignment.Left);
                    myListView.Columns.Add("chat_ban", 0, HorizontalAlignment.Left);

                    Console.WriteLine("INSERT LISVIEW ADD FINISHED");
                    ListViewItem lv = new ListViewItem();
                    //
                    while (dataReader.Read())
                    {
                        lv = myListView.Items.Add(dataReader[dataReader.GetName(0)].ToString().Replace('_', ' '));
                        for (int h = 1; h < dataReader.FieldCount; h++)
                        {
                            if (!(h == 2))
                            {
                                if (!(h == 4))
                                {
                                    Console.WriteLine(dataReader[dataReader.GetName(h)].ToString());
                                    lv.SubItems.Add(dataReader[dataReader.GetName(h)].ToString());
                                }
                            }
                        }
                    }
                }
                for (int i = 1; i < myListView.Columns.Count; i++)
                    myListView.Columns[i].Width = -2;
                dataReader.Close();
                myListView.View = View.Details;
            }
            catch (Exception e)
            {

            }
        }



        /// <summary>
        /// Methode to insert Mysqldata into pupil ListView
        /// </summary>
        /// <param name="myListView"></param>
        /// <param name="query"></param>
        public static void INSERT_INTO_WHITE_LIST(ListView myListView)
        {
            myListView.Items.Clear();
            myListView.Columns.Clear();
            myListView.View = View.Details;
            try
            {
                    String class_name;
                    String teacher_name;
                    if (PUPIL_OBJ.checkIfIsPupil())
                    {
                        class_name = PUPIL_OBJ.get_user_class();
                        teacher_name = PUPIL_OBJ.name;
                    }
                    else
                    {
                        class_name = dashboard_mod_teacher.selected;
                        teacher_name = TEACHER_OBJ.name;
                    }

                    String obj_list = runMYSQL_GET("SELECT * FROM WHITELIST WHERE class_name='"+class_name+"'", Program.connection, "objects");
                    myListView.Columns.Add("ID", 0, HorizontalAlignment.Left);
                    myListView.Columns.Add("Name", 0, HorizontalAlignment.Left);
                
                    ListViewItem lv = new ListViewItem();
                
                    char[] delimiterChars = {'.'};

                    string[] words = obj_list.Split(delimiterChars);

                    foreach (string s in words)
                    {
                        System.Console.WriteLine(s);
                        lv = myListView.Items.Add("",s);
                        lv.SubItems.Add(s);
                }




                for (int i = 1; i < myListView.Columns.Count; i++)
                    myListView.Columns[i].Width = -2;

                myListView.View = View.Details;
            }
            catch (Exception e)
            {

            }
        }



        /// <summary>
        /// Methode to insert Mysqldata into Listbox
        /// </summary>
        /// <param name="myListView"></param>
        /// <param name="query"></param>
        public static void INSERT_LB_MSG_ALERT(ListBox myListBox, string query)
        {
            myListBox.Items.Clear();
            String name = "";
            String msg = "";
            String from = "";
            try
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                //Read the data and store them in the listview
                //"[PUPIL]" + 
                //"[TEACHER]" + 
                if (dataReader.FieldCount > 0)
                {
                    while (dataReader.Read())
                    {
                        for (int h = 1; h < dataReader.FieldCount; h++)
                        {
                            if ((h == 1))
                            {
                                name = dataReader[dataReader.GetName(h)].ToString();
                            }
                            else if (h == 2)
                            {
                                msg = dataReader[dataReader.GetName(h)].ToString();
                            }
                            else if (h == 3)
                            {
                                from = dataReader[dataReader.GetName(h)].ToString();
                            }
                            //lv.SubItems.Add(dataReader[dataReader.GetName(h)].ToString());
                            if (h == 3)
                            {
                                myListBox.Items.Add(name + ": " + msg);
                                name = "";
                                msg = "";
                                break;
                            }
                        }
                    }
                }
                dataReader.Close();
            }
            catch (Exception e)
            {

            }
        }

        /// <summary>
        /// Methode to insert Mysqldata into chat ListBox
        /// </summary>
        /// <param name="myListView"></param>
        /// <param name="query"></param>
        public static void INSERT_LB_CHAT(ListBox myListBox, string query)
        {
            myListBox.Items.Clear();
            String name = "";
            String msg = "";
            try
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                //Read the data and store them in the listview
                //"[PUPIL]" + 
                //"[TEACHER]" + 
                if (dataReader.FieldCount > 0)
                {
                    while (dataReader.Read())
                    {
                        for (int h = 1; h < dataReader.FieldCount; h++)
                        {
                            if ((h == 2))
                            {
                                msg = dataReader[dataReader.GetName(h)].ToString();
                            }
                            else if (h == 3)
                            {
                                name = dataReader[dataReader.GetName(h)].ToString();
                            }
                            //lv.SubItems.Add(dataReader[dataReader.GetName(h)].ToString());
                            if (h == 3)
                            {
                                myListBox.Items.Add(name + "->    " + msg);
                                name = "";
                                msg = "";
                                break;
                            }
                        }
                    }
                }
                dataReader.Close();
            }
            catch (Exception e)
            {

            }
        }


        /// <summary>
        /// Methode to send MSGs to specific person 
        /// </summary>
        /// <param name="myListView"></param>
        /// <param name="query"></param>
        public static void send_MSG(String to, String MSG)
        {
            String from;
            if (TEACHER_OBJ.checkIfIsTeacher())
            {
                from = TEACHER_OBJ.name;
            }
            else
            {
                from = PUPIL_OBJ.name;
            }
            Program.runMYSQL(@"INSERT INTO MSG_SYS (sender, msg, reciever, checked) VALUES ('" + from + "','" + MSG + "','" + to + "','0')", Program.connection);
        }

        /// <summary>
        /// Check if new MSGs available
        /// </summary>
        /// <returns></returns>
        public static int checkMSGS_AVAILABLE()
        {
            String from;
            if (TEACHER_OBJ.checkIfIsTeacher())
            {
                from = TEACHER_OBJ.name;
            }
            else
            {
                from = PUPIL_OBJ.name;
            }
            int b = Program.runMYSQL_COUNT("SELECT * FROM MSG_SYS WHERE reciever='" + from + "' AND checked='0'", Program.connection);
            if (b > 0)
            {
            }
            else

            {
                b = 0;
            }
            return b;
        }

        /// <summary>
        /// Methode to check for internet connection
        /// </summary>
        /// <returns></returns>
        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// Methode to send MSG to other classes chats
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="class_name"></param>
        public static void sendMSG_SPE(String msg,String class_name)
        {
            //Check if is empty
            if (!(msg == ""))
            {
                //String oname-> name
                String oname;
                //Check if is teacher
                if (TEACHER_OBJ.checkIfIsTeacher())
                {
                    //Define name
                    oname = TEACHER_OBJ.name;
                }
                else
                {
                    //Define name
                    oname = PUPIL_OBJ.name;
                }
                //Insert into MYSQL database
                Program.runMYSQL("INSERT INTO CHAT (class,msg,sender) VALUES ('" + class_name + "','" + msg + "','" + oname + "')", Program.connection);
                //Program.runMYSQL("INSERT INTO TEAC (tel_seeable,tidf) VALUES ('" + name + "','" + pw1 + "','" + user_class + "','" + user_class_pw + "','" + age + "','" + school + "','" + email + "','" + tel + "',' ',' ','" + teacher_id + "')", Program.connection);
               //Empty String msg
                msg = "";
            }
        }
    }
}