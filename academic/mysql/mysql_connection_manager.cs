using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace academic.mysql
{
    class mysql_connection_manager
    {



        /// <summary>
        /// Mainenterpoint
        /// </summary>
        public static MySqlConnection connection;

        /// <summary>
        /// Methode to start MYSQL Thread
        /// </summary>
        public static void connectMYSQL()
        {
            Thread workerThread = new Thread(create_datatables);
            workerThread.Start();
        }

        /// <summary>
        /// MYSQL Management
        /// </summary>
        public static void create_datatables()
        {
            if (create_connection())
            {
                //Table for teacher ids
                mysql_basic_methods.runMYSQL("CREATE TABLE IF NOT EXISTS IDs(id INT NOT NULL AUTO_INCREMENT, name VARCHAR (128) default NULL, school VARCHAR (64) default NULL , tid VARCHAR (64) default NULL, used VARCHAR (64) default NULL , blocked VARCHAR (64) default NULL ,PRIMARY KEY (id))", connection);
                //Table for pupils
                mysql_basic_methods.runMYSQL("CREATE TABLE IF NOT EXISTS USER(id INT NOT NULL AUTO_INCREMENT, user_name VARCHAR (128) default NULL, user_pass VARCHAR (64) default NULL, user_class VARCHAR (64) default NULL, user_class_pw VARCHAR (64) default NULL, user_age VARCHAR (64) default NULL, user_school VARCHAR (64) default NULL, email VARCHAR (64) default NULL, chat_ban VARCHAR (64) default NULL, PRIMARY KEY (id))", connection);
                //Table for teachers
                mysql_basic_methods.runMYSQL("CREATE TABLE IF NOT EXISTS TEACHER(id INT NOT NULL AUTO_INCREMENT, user_name VARCHAR (128) default NULL, user_pass VARCHAR (64) default NULL, user_class VARCHAR (64) default NULL , user_class_pw VARCHAR (64) default NULL, user_age VARCHAR (64) default NULL, user_school VARCHAR (64) default NULL, email VARCHAR (64) default NULL, tel VARCHAR (64) default NULL, email_seeable VARCHAR (64) default NULL, tel_seeable VARCHAR (64) default NULL, tid VARCHAR (64) default NULL, PRIMARY KEY (id))", connection);
                //Table for classes
                mysql_basic_methods.runMYSQL("CREATE TABLE IF NOT EXISTS CLASSES(id INT NOT NULL AUTO_INCREMENT, class_name VARCHAR (128) default NULL, class_pw VARCHAR (64) default NULL, class_school VARCHAR (64) default NULL , class_teacher VARCHAR (64) default NULL, created_date VARCHAR (64) default NULL, class_id VARCHAR (64) default NULL, teachers VARCHAR (64) default NULL, teacher_calss_pw VARCHAR (64) default NULL, PRIMARY KEY (id))", connection);
                //Table for chat
                mysql_basic_methods.runMYSQL("CREATE TABLE IF NOT EXISTS CHAT(id INT NOT NULL AUTO_INCREMENT, class VARCHAR (128) default NULL, msg VARCHAR (64) default NULL , sender VARCHAR (64) default NULL, PRIMARY KEY (id))", connection);
                //Table for msg system
                mysql_basic_methods.runMYSQL("CREATE TABLE IF NOT EXISTS MSG_SYS(id INT NOT NULL AUTO_INCREMENT, sender VARCHAR (128) default NULL, msg VARCHAR (64) default NULL , reciever VARCHAR (64) default NULL, checked VARCHAR (64) default NULL, PRIMARY KEY (id))", connection);
                //Table for WHITELISTS
                mysql_basic_methods.runMYSQL("CREATE TABLE IF NOT EXISTS WHITELIST(id INT NOT NULL AUTO_INCREMENT, teacher_name VARCHAR (128) default NULL, class_name VARCHAR (128) default NULL, objects VARCHAR (500) default NULL , PRIMARY KEY (id))", connection);
                //Table for homeworkss
                mysql_basic_methods.runMYSQL("CREATE TABLE IF NOT EXISTS HOMEWORK(id INT NOT NULL AUTO_INCREMENT, hw VARCHAR (128) default NULL, class_name VARCHAR (64) default NULL , PRIMARY KEY (id))", connection);
            }
        }

        /// <summary>
        /// Creates connection
        /// </summary>
        /// <returns></returns>
        public static bool create_connection()
        {
            bool connected = false;

            //Check internetconnection
            if (mysql_basic_methods.CheckForInternetConnection())
            {
                connected = true;
                //RUN -> OK
                //Define connection
                connection = new MySqlConnection(@"Server=" + data.ip + ";Uid=" + data.user + ";Pwd=" + data.pw + ";Database=" + data.database + ";");
                //Open connection
                connection.Open();
                //Create tables
            }
            else
            {
                connected = false;
                //No internet
                System.Windows.Forms.MessageBox.Show("No internet!");
            }

            return connected;
        }



    }
}
