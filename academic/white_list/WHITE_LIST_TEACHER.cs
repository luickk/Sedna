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
using academic.mysql;
using academic.white_list;

namespace academic
{
    public partial class WHITE_LIST_TEACHER : UserControl
    {
        String selected = "";


        /// <summary>
        /// Instance 
        /// </summary>
        private static WHITE_LIST_TEACHER WHITE_LIST_TEACHER_inst;

        /// <summary>
        /// Instance const.
        /// </summary>
        public static WHITE_LIST_TEACHER Instance
        {
            get
            {
                if (WHITE_LIST_TEACHER_inst == null)
                    WHITE_LIST_TEACHER_inst = new WHITE_LIST_TEACHER();
                return WHITE_LIST_TEACHER_inst;
            }
        }


        /// <summary>
        /// Constructor.
        /// </summary>
        public WHITE_LIST_TEACHER()
        {
            InitializeComponent();
            panel_pop.Height = 0;
            reload();
        }


        /// <summary>
        /// Methode for reloading white_list list
        /// </summary>
        public void reload()
        {
            white_list_methods.INSERT_INTO_WHITE_LIST(tv_user);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            reload();
        }




        /// <summary>
        /// Methode to load a popup in main screen 
        /// </summary>
        /// <param name="head_line">The Headline</param>
        /// <param name="msg">The Message</param>
        public void load_popup(String head_line, String msg)
        {
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            String name;
            name = tb_first_name.text.Trim() + "," + tb_last_name.text.Trim();
            mysql_basic_methods.runMYSQL("UPDATE WHITELIST SET objects= CONCAT(objects,'" + name + "." + "')", mysql_connection_manager.connection);
            tb_last_name.text = "";
            tb_first_name.text = "";
            load_popup("ADDED!", "Added: "+name);
            name = "";
            reload();
        }

        private void tv_user_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem selectedItem = tv_user.SelectedItems[0];
            String selectedd = selectedItem.SubItems[1].Text;
            selected = selectedd;
        }

        private void pb_class_delet_Click(object sender, EventArgs e)
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
            if (selected == "")
            {
                load_popup("No user selected!", "No user selected!");
            } else
            {
                mysql_basic_methods.runMYSQL("UPDATE WHITELIST SET objects=REPLACE(objects,'" + selected.Trim() + "." + "','') WHERE class_name='" + class_name.Trim() + "'", mysql_connection_manager.connection);
                load_popup("User removed!", "Removed: " + selected);
                reload();
                selected = "";
            }
        }

        
        bool tb_first_name_bool = false;
        private void tb_first_name_Enter(object sender, EventArgs e)
        {
            if (!tb_first_name_bool)
                tb_first_name.text = "";
            tb_first_name_bool = true;

        }

        bool tb_last_name_bool = false;
        private void tb_last_name_Enter(object sender, EventArgs e)
        {
            if (!tb_last_name_bool)
                tb_last_name.text = "";
            tb_last_name_bool = true;

        }
    }
}
