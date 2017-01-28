using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;

namespace academic.mysql
{
    class mysql_basic_methods
    { /// <summary>
      /// Methode to run Mysql commands
      /// </summary>
      /// <param name="cmd"></param>
      /// <param name="connection"></param>
        public static void runMYSQL(String cmd, MySqlConnection connection)
        {
            no_internet no_internet = new no_internet();
            if (mysql_basic_methods.CheckForInternetConnection())
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
            if (mysql_basic_methods.CheckForInternetConnection())
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
    }
}
