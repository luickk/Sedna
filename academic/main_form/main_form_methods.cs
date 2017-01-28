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

namespace academic.main_form
{
    class main_form_methods
    { /// <summary>
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
    }
}
