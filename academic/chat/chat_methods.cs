using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Threading;
using System.Net;
using System.Diagnostics;
using academic.mysql;

namespace academic.chat
{
    class chat_methods
    {/// <summary>
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
                MySqlCommand cmd = new MySqlCommand(query, mysql_connection_manager.connection);
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
        /// Methode to send MSG to other classes chats
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="class_name"></param>
        public static void sendMSG_SPE(String msg, String class_name)
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
                mysql_basic_methods.runMYSQL("INSERT INTO CHAT (class,msg,sender) VALUES ('" + class_name + "','" + msg + "','" + oname + "')", mysql_connection_manager.connection);
                //Program.runMYSQL("INSERT INTO TEAC (tel_seeable,tidf) VALUES ('" + name + "','" + pw1 + "','" + user_class + "','" + user_class_pw + "','" + age + "','" + school + "','" + email + "','" + tel + "',' ',' ','" + teacher_id + "')", Program.connection);
                //Empty String msg
                msg = "";
            }
        }
    }
}
