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
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        public static MySqlConnection connection;
        public static bool wasNOINT = false;
        [STAThread]
        static void Main()
        {
            connectMYSQL();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
        public static void connectMYSQL()
        {
            Thread workerThread = new Thread(DoMysql);
            workerThread.Start();
        }
        public static void DoMysql()
        {
            no_internet no_internet = new no_internet();
            if (Program.CheckForInternetConnection())
            {
                    //RUN -> OK
                    
                    connection = new MySqlConnection(@"Server=134.255.234.216;Uid=root;Pwd=" + data.pw + ";Database=academic;");
                    connection.Open();
                    runMYSQL("CREATE TABLE IF NOT EXISTS IDs(id INT NOT NULL AUTO_INCREMENT, name VARCHAR (128) default NULL, school VARCHAR (64) default NULL , tid VARCHAR (64) default NULL, used VARCHAR (64) default NULL , blocked VARCHAR (64) default NULL ,PRIMARY KEY (id))", connection);
                    runMYSQL("CREATE TABLE IF NOT EXISTS USER(id INT NOT NULL AUTO_INCREMENT, user_name VARCHAR (128) default NULL, user_pass VARCHAR (64) default NULL, user_class VARCHAR (64) default NULL, user_class_pw VARCHAR (64) default NULL, user_age VARCHAR (64) default NULL, user_school VARCHAR (64) default NULL, email VARCHAR (64) default NULL, chat_ban VARCHAR (64) default NULL, PRIMARY KEY (id))", connection);
                    runMYSQL("CREATE TABLE IF NOT EXISTS TEACHER(id INT NOT NULL AUTO_INCREMENT, user_name VARCHAR (128) default NULL, user_pass VARCHAR (64) default NULL, user_class VARCHAR (64) default NULL , user_class_pw VARCHAR (64) default NULL, user_age VARCHAR (64) default NULL, user_school VARCHAR (64) default NULL, email VARCHAR (64) default NULL, tel VARCHAR (64) default NULL, email_seeable VARCHAR (64) default NULL, tel_seeable VARCHAR (64) default NULL, tid VARCHAR (64) default NULL, PRIMARY KEY (id))", connection);
                    runMYSQL("CREATE TABLE IF NOT EXISTS CLASSES(id INT NOT NULL AUTO_INCREMENT, class_name VARCHAR (128) default NULL, class_pw VARCHAR (64) default NULL, class_school VARCHAR (64) default NULL , class_teacher VARCHAR (64) default NULL, created_date VARCHAR (64) default NULL, class_id VARCHAR (64) default NULL, teachers VARCHAR (64) default NULL, PRIMARY KEY (id))", connection);
                    runMYSQL("CREATE TABLE IF NOT EXISTS CHAT(id INT NOT NULL AUTO_INCREMENT, class VARCHAR (128) default NULL, msg VARCHAR (64) default NULL , sender VARCHAR (64) default NULL, PRIMARY KEY (id))", connection);
                    runMYSQL("CREATE TABLE IF NOT EXISTS MSG_SYS(id INT NOT NULL AUTO_INCREMENT, sender VARCHAR (128) default NULL, msg VARCHAR (64) default NULL , reciever VARCHAR (64) default NULL, checked VARCHAR (64) default NULL, PRIMARY KEY (id))", connection);


                    //RUN -> OK
            } else { 
                no_internet.Show();
            }
         }
        public static void runMYSQL(String cmd, MySqlConnection connection)
        {
            no_internet no_internet = new no_internet();
                if (Program.CheckForInternetConnection())
                {

                if (Program.wasNOINT == true)
                {
                    //RESTART
                    ProcessStartInfo Info = new ProcessStartInfo();
                    Info.Arguments = "/C ping 127.0.0.1 -n 2 && \"" + Application.ExecutablePath + "\"";
                    Info.WindowStyle = ProcessWindowStyle.Hidden;
                    Info.CreateNoWindow = true;
                    Info.FileName = "cmd.exe";
                    Process.Start(Info);
                    Application.Exit();
                }
                //RUN -> OK

                MySqlCommand insertCommand = new MySqlCommand(cmd, connection);
                    insertCommand.ExecuteNonQuery();
                    no_internet.Close();
                    
                    //RUN -> OK

                }
                else
                {
                    no_internet.Show();
                }
        }


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
        public static bool runMYSQL_EXISTS(String cmd, MySqlConnection connection)
        {
            bool b = false;
            no_internet no_internet = new no_internet();
          
                if (Program.CheckForInternetConnection())
                {
                //RUN -> OK
                if (Program.wasNOINT == true)
                {
                    //RESTART
                    ProcessStartInfo Info = new ProcessStartInfo();
                    Info.Arguments = "/C ping 127.0.0.1 -n 2 && \"" + Application.ExecutablePath + "\"";
                    Info.WindowStyle = ProcessWindowStyle.Hidden;
                    Info.CreateNoWindow = true;
                    Info.FileName = "cmd.exe";
                    Process.Start(Info);
                    Application.Exit();
                }

                MySqlCommand check_User_Name = new MySqlCommand(cmd, connection);
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
                    no_internet.Show();
                }
           

            return b;
        }
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
            Program.runMYSQL("INSERT INTO MSG_SYS (sender, msg, reciever, checked) VALUES ('" + from + "','" + MSG + "','" + to + "','0')", Program.connection);
        }
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
    }
}