using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace academic
{
    public partial class settings_pupil : UserControl
    {
        /// <summary>
        /// Instance 
        /// </summary>
        private static settings_pupil settings_pupil_inst;

        /// <summary>
        /// Instance const.
        /// </summary>
        public static settings_pupil Instance
        {
            get
            {
                if (settings_pupil_inst == null)
                    settings_pupil_inst = new settings_pupil();
                return settings_pupil_inst;
            }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public settings_pupil()
        {
            InitializeComponent();
            pan_join.Hide();
            panel_pop.Hide();
        }

        private void settings_pupil_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Methode to load a popup in main screen 
        /// </summary>
        /// <param name="head_line">The Headline</param>
        /// <param name="msg">The Message</param>
        public void load_popup(String head_line, String msg)
        {
            panel_pop.Show();
            t_head_line.Text = head_line;
            t_pop_msg.Text = msg;
            //--------------------

            while (panel_pop.Height < 100)
            {
                wait_mill_sec(50);
                panel_pop.Height++;
                Application.DoEvents();
            }
            Thread.Sleep(1000);
            while (panel_pop.Height > 0)
            {
                wait_mill_sec(50);
                panel_pop.Height--;
                Application.DoEvents();
            }
            //--------------------
        }
        /// <summary>
        /// Methode to wait less than mill seconds.
        /// </summary>
        /// <param name="durationTicks"></param>
        private static void wait_mill_sec(long durationTicks)
        {
            var sw = Stopwatch.StartNew();

            while (sw.ElapsedTicks < durationTicks)
            {

            }
        }

        private void bunifuThinButton1_Click(object sender, EventArgs e)
        {
            String user_class;
            String user_class_pw;
            user_class = tb_join_name.text;
            user_class_pw = tb_join_pw.text;

            String name;
            if (TEACHER_OBJ.checkIfIsTeacher())
            {
                name = TEACHER_OBJ.name;
            } else
            {
                name = PUPIL_OBJ.name;
            }

            if (Program.runMYSQL_EXISTS("SELECT count(*) FROM CLASSES WHERE class_name = '" + user_class.Trim() + "' AND class_pw = '" + user_class_pw.Trim() + "'", Program.connection))
            {
                Program.runMYSQL("UPDATE USER SET user_class='" + user_class.Trim() + "' WHERE user_name='" + name.Trim() + "'", Program.connection);
                load_popup("Changed class!", "Changed class to" + user_class);
                pan_join.Hide();
                tb_join_name.text = "";
                tb_join_pw.text = "";
            }
            else
            {
                t_join_class_alert.Text = "Class name or pw wrong!";
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            pan_join.Show();
        }


        bool tb_join_name_bool = false;
        private void tb_join_name_Enter_1(object sender, EventArgs e)
        {
            if (!tb_join_name_bool)
                tb_join_name.text = "";
            tb_join_name_bool = true;
        }


        bool tb_join_name_pw_bool = false;
        private void tb_join_pw_Enter_1(object sender, EventArgs e)
        {
            if (!tb_join_name_pw_bool)
                tb_join_pw.text = "";
            tb_join_name_pw_bool = true;
        }
    }
}
