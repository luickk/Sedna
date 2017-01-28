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

namespace academic.class_v
{
    class cl_methods
    {

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
                MySqlCommand cmd = new MySqlCommand(query, mysql_connection_manager.connection);
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

    }
}
