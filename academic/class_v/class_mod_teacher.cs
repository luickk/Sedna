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
using academic.class_v;
using academic.mail;

namespace academic
{
    public partial class class_mod_teacher : UserControl
    {
        /// <summary>
        /// Instance
        /// </summary>
        private static class_mod_teacher class_mod_teacher_inst;

        /// <summary>
        /// Selected Item
        /// </summary>
        String selected;

        /// <summary>
        /// Instance const.
        /// </summary>
        public static class_mod_teacher Instance
        {
            get
            {
                if (class_mod_teacher_inst == null)
                    class_mod_teacher_inst = new class_mod_teacher();
                return class_mod_teacher_inst;
            }
        }

        /// <summary>
        /// Returns selected user name
        /// </summary>
        /// <returns></returns>
        public String getSelectedUser()
        {
            ListViewItem selectedItem = tv_user.SelectedItems[0];
            return selectedItem.SubItems[1].Text;
        }

        /// <summary>
        /// Const.
        /// </summary>
        public class_mod_teacher()
        {
            InitializeComponent();
            panel_pop.Height = 0;
            reload();
        }

        /// <summary>
        /// Event -> If user is selected -> SETs selected var
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tv_user_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = tv_user.SelectedItems[0];
            String selected = selectedItem.SubItems[1].Text;
        }
        public String getSelectedTeacher()
        {
            ListViewItem selectedItem = tv_user.SelectedItems[0];
            return selectedItem.SubItems[1].Text;
        }
        /// <summary>
        /// Methode for reloading user lists
        /// </summary>
        public void reload()
        {
                cl_methods.INSERT_LIST_VIEW_USER(tv_user, "SELECT * FROM USER WHERE user_class = '" + dashboard_mod_teacher.selected + "'");
        }

        private void t_selected_user_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Event-> Reload clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            reload();
        }

        /// <summary>
        /// Metohde for loading and rendering pupil info pppup
        /// </summary>
        /// <param name="name"></param>
        public void load_popup_teacher_info(String name)
        {
            t__popup_user_name.Text = name;
            String t_class = mysql_basic_methods.runMYSQL_GET("SELECT * FROM USER WHERE user_name='" + name + "'", mysql_connection_manager.connection, "user_class");
            String t_school = mysql_basic_methods.runMYSQL_GET("SELECT * FROM USER WHERE user_name='" + name + "'", mysql_connection_manager.connection, "user_school");
            String t_email = mysql_basic_methods.runMYSQL_GET("SELECT * FROM USER WHERE user_name='" + name + "'", mysql_connection_manager.connection, "email");
            String t_tel = mysql_basic_methods.runMYSQL_GET("SELECT * FROM USER WHERE user_name='" + name + "'", mysql_connection_manager.connection, "tel");
            String t_chat_ban = mysql_basic_methods.runMYSQL_GET("SELECT * FROM USER WHERE user_name='" + name + "'", mysql_connection_manager.connection, "chat_ban");
            t_info_class.Text = t_class;
            t_info_school.Text = t_school;
            t_info_tel.Text = t_tel;
            t_info_email.Text = t_email;
            t_chat_ban_text.Text = t_chat_ban;
            if (mysql_basic_methods.runMYSQL_GET("SELECT * FROM USER WHERE user_name='" + name + "'", mysql_connection_manager.connection, "chat_ban") == "on")
            {
                btn_chatban.ButtonText = "ChatBan ON";
            }
            else
            {
                btn_chatban.ButtonText = "ChatBan OFF";
            }
        }

        /// <summary>
        /// Event-> Closes popup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            t_info_class.Text = "";
            t_info_school.Text = "";
            t_info_email.Text = "";
            t_info_tel.Text = "";
        }

        /// <summary>
        /// Loads popup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tv_user_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selectedItem = tv_user.SelectedItems[0];
            selected = selectedItem.SubItems[1].Text;

            load_popup_teacher_info(selected);
            if (mysql_basic_methods.runMYSQL_GET("SELECT * FROM USER WHERE user_name='"+selected+"'", mysql_connection_manager.connection, "chat_ban") == "on")
            {
                btn_chatban.ButtonText = "ChatBan OFF";
            }
            else
            {
                btn_chatban.ButtonText = "ChatBan ON";
            }
        }

        /// <summary>
        /// Enables/Disables Chatban
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_chatban_Click(object sender, EventArgs e)
        {
            if (mysql_basic_methods.runMYSQL_GET("SELECT * FROM USER WHERE user_name='" + selected + "'", mysql_connection_manager.connection, "chat_ban") == "on")
            {
                mysql_basic_methods.runMYSQL("UPDATE USER SET chat_ban='off' WHERE user_name='" + selected + "'", mysql_connection_manager.connection);
                btn_chatban.ButtonText = "ChatBan ON";
                load_popup("User ban removed!", "You unbanned: " + selected);
            } else
            {
                mysql_basic_methods.runMYSQL("UPDATE USER SET chat_ban='on' WHERE user_name='" + selected + "'", mysql_connection_manager.connection);
                btn_chatban.ButtonText = "ChatBan OFF";
                load_popup("User banned!", "You banned: " + selected);
            }
        }

        private void btn_send_msg_name_Click(object sender, EventArgs e)
        {
            String name = getSelectedTeacher();
            String msg = tb_msg.Text;
            mail_methods.send_MSG(getSelectedTeacher(),msg);
            load_popup("MSGS sent!", "MSG sent to: " + getSelectedTeacher());

            tb_msg.Text = "";
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

        private void bunifuSeparator1_Load(object sender, EventArgs e)
        {

        }

        private void t_chat_ban_text_Click(object sender, EventArgs e)
        {

        }

        private void t_info_tel_Click(object sender, EventArgs e)
        {

        }
    }
}
