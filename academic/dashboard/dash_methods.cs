using academic.mysql;
using MySql.Data.MySqlClient;
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

namespace academic.dashboard
{
    class dash_methods
    {


        /// <summary>
        /// Methode to insert Mysqldata into ListView
        /// </summary>
        /// <param name="myListView"></param>
        /// <param name="query"></param>
        public static void INSERT_LIST_VIEW(ListView myListView, string query)
        {
            myListView.Items.Clear();
            myListView.Columns.Clear();
            myListView.View = System.Windows.Forms.View.Details;
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


    }
}
