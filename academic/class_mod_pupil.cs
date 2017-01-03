using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace academic
{
    public partial class class_mod_pupil : UserControl
    {


        /// <summary>
        /// Instance
        /// </summary>
        private static class_mod_pupil class_mod_pupil_inst;

        /// <summary>
        /// Instance const.
        /// </summary>
        public static class_mod_pupil Instance
        {
            get
            {
                if (class_mod_pupil_inst == null)
                    class_mod_pupil_inst = new class_mod_pupil();
                return class_mod_pupil_inst;
            }
        }


        /// <summary>
        /// Const.
        /// </summary>
        public class_mod_pupil()
        {
            InitializeComponent();
            panel_teacher_pupil_info_popup.Hide();
        }
        /// <summary>
        /// Methode for reloading pupil list
        /// </summary>
        public void reload_pupil()
        {
           Program.INSERT_LIST_VIEW_USER(tv_user, "SELECT * FROM USER WHERE user_class = '" + PUPIL_OBJ.get_user_class() + "'");
        }

        /// <summary>
        /// Event -> click button -> reloading pupil/teacher list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            reload_pupil();
            realod_teacher_lv();
        }

        /// <summary>
        /// Methode for loading pupup (pupils)
        /// </summary>
        /// <param name="name"></param>
        public void load_popup_teacher_info(String name)
        {
            panel_teacher_pupil_info_popup.Show();
            t__popup_user_name.Text = name;
            String t_class = Program.runMYSQL_GET("SELECT * FROM TEACHER WHERE user_name='"+name+"'", Program.connection, "user_class");
            String t_school = Program.runMYSQL_GET("SELECT * FROM TEACHER WHERE user_name='" + name + "'", Program.connection, "user_school");
            String t_email = Program.runMYSQL_GET("SELECT * FROM TEACHER WHERE user_name='" + name + "'", Program.connection, "email");
            String t_tel = Program.runMYSQL_GET("SELECT * FROM TEACHER WHERE user_name='" + name + "'", Program.connection, "tel");
            String t_tel_seeable = Program.runMYSQL_GET("SELECT * FROM TEACHER WHERE user_name='" + name + "'", Program.connection, "tel_seeable");
            String t_email_seeable = Program.runMYSQL_GET("SELECT * FROM TEACHER WHERE user_name='" + name + "'", Program.connection, "email_seeable");
            t_info_class.Text = t_class;
            t_info_school.Text = t_school;

            if (t_tel_seeable == "on")
            {
                t_info_tel.Text = t_tel;
            } else
            {
                t_info_tel.Text = "Privat";
            }


            if (t_email_seeable == "on")
            {
                t_info_email.Text = t_email;
            } else
            {
                t_info_email.Text = "Privat";
            }
        }

        /// <summary>
        /// Methode for reloading teacher list
        /// </summary>
        String[] substrings;
        private void realod_teacher_lv()
        {

            lv_teacher.Items.Clear();
            lv_teacher.Columns.Clear();
            String teachers = Program.runMYSQL_GET("SELECT * FROM CLASSES WHERE class_name='"+PUPIL_OBJ.get_user_class()+"'", Program.connection,"teachers");
            String main_teacher = Program.runMYSQL_GET("SELECT * FROM CLASSES WHERE class_name='" + PUPIL_OBJ.get_user_class() + "'", Program.connection, "class_teacher");
            teachers = teachers+"."+main_teacher;
            Char delimiter = '.';
            substrings = teachers.Split(delimiter);
            Console.WriteLine(substrings);
            lv_teacher.View = View.Details;
            lv_teacher.Columns.Add("ID", 0, HorizontalAlignment.Right);
            lv_teacher.Columns.Add("Name", 150, HorizontalAlignment.Center);
             ListViewItem lv = new ListViewItem();
              foreach (var substring in substrings)
         {
            Console.WriteLine(substring);
            lv = lv_teacher.Items.Add(substring);
            lv.SubItems.Add(substring);
            }

        }
        
        /// <summary>
        /// Event -> doubleclick teacher list and loading popup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lv_teacher_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selectedItem = lv_teacher.SelectedItems[0];
            String selected = selectedItem.SubItems[1].Text;

            load_popup_teacher_info(selected);
        }

        /// <summary>
        /// Methode for closing pupup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel_teacher_pupil_info_popup.Hide();
            t_info_class.Text = "";
            t_info_school.Text = "";
            t_info_email.Text = "";
            t_info_tel.Text = "";
        }

        /// <summary>
        /// Methode for loading pupup (teachers)
        /// </summary>
        /// <param name="name"></param>
        public void load_pup_popup_teacher_info(String name)
        {
            panel_teacher_pupil_info_popup.Show();
            t__popup_user_name.Text = name;
            String t_class = Program.runMYSQL_GET("SELECT * FROM USER WHERE user_name='" + name + "'", Program.connection, "user_class");
            String t_school = Program.runMYSQL_GET("SELECT * FROM USER WHERE user_name='" + name + "'", Program.connection, "user_school");
            String t_email = Program.runMYSQL_GET("SELECT * FROM USER WHERE user_name='" + name + "'", Program.connection, "email");
            String t_tel = Program.runMYSQL_GET("SELECT * FROM USER WHERE user_name='" + name + "'", Program.connection, "tel");
            String t_chat_ban = Program.runMYSQL_GET("SELECT * FROM USER WHERE user_name='" + name + "'", Program.connection, "chat_ban");
            t_info_class.Text = t_class;
            t_info_school.Text = t_school;
            t_info_tel.Text = t_tel;
            t_info_email.Text = t_email;
        }
        /// <summary>
        /// Event -> doubleclick pupils list and loading popup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tv_user_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem selectedItem = tv_user.SelectedItems[0];
            String selected = selectedItem.SubItems[1].Text;

            load_pup_popup_teacher_info(selected);
        }

        private void btn_send_msg_name_Click(object sender, EventArgs e)
        {

        }
    }
}
