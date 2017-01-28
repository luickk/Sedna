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
using academic.mysql;

namespace academic
{
    static class Program
    {


        /// <summary>
        /// Mainfunction
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (mysql_basic_methods.CheckForInternetConnection())
            {
                mysql_connection_manager.connectMYSQL();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Login());
            } else
            {
                System.Windows.Forms.MessageBox.Show("No internet!");
            }
        }
    }
}