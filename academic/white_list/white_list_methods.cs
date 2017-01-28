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


namespace academic.white_list
{
    class white_list_methods
    {

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

                String obj_list = mysql_basic_methods.runMYSQL_GET("SELECT * FROM WHITELIST WHERE class_name='" + class_name + "'", mysql_connection_manager.connection, "objects");
                myListView.Columns.Add("ID", 0, HorizontalAlignment.Left);
                myListView.Columns.Add("Name", 0, HorizontalAlignment.Left);

                ListViewItem lv = new ListViewItem();

                char[] delimiterChars = { '.' };

                string[] words = obj_list.Split(delimiterChars);

                foreach (string s in words)
                {
                    System.Console.WriteLine(s);
                    lv = myListView.Items.Add("", s);
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
    }
}
