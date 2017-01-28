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


namespace academic.mail
{
    class mail_methods
    {
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
            mysql_basic_methods.runMYSQL(@"INSERT INTO MSG_SYS (sender, msg, reciever, checked) VALUES ('" + from + "','" + MSG + "','" + to + "','0')", mysql_connection_manager.connection);
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
            int b = mysql_basic_methods.runMYSQL_COUNT("SELECT * FROM MSG_SYS WHERE reciever='" + from + "' AND checked='0'", mysql_connection_manager.connection);
            if (b > 0)
            {
            }
            else

            {
                b = 0;
            }
            return b;
        }

    }
}
