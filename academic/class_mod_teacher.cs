using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace academic
{
    public partial class class_mod_teacher : UserControl
    {
        private static class_mod_teacher class_mod_teacher_inst;
        String selected;
        public static class_mod_teacher Instance
        {
            get
            {
                if (class_mod_teacher_inst == null)
                    class_mod_teacher_inst = new class_mod_teacher();
                return class_mod_teacher_inst;
            }
        }
        public String getSelectedUser()
        {
            ListViewItem selectedItem = tv_user.SelectedItems[0];
            return selectedItem.SubItems[1].Text;
        }
        public class_mod_teacher()
        {
            InitializeComponent();
            panel_teacher_pupil_info_popup.Hide();
        }


        private void tv_user_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = tv_user.SelectedItems[0];
            String selected = selectedItem.SubItems[1].Text;
            Console.WriteLine(selected);
            t_selected_user.Text = "Selected User: " + selected;
        }

        public void reload()
        {
                Program.INSERT_LIST_VIEW_USER(tv_user, "SELECT * FROM USER WHERE user_class = '" + dashboard_mod_teacher.selected + "'");
        }

        private void t_selected_user_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            reload();
        }

        public void load_popup_teacher_info(String name)
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
            t_chat_ban_text.Text = t_chat_ban;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            panel_teacher_pupil_info_popup.Hide();
            t_info_class.Text = "";
            t_info_school.Text = "";
            t_info_email.Text = "";
            t_info_tel.Text = "";
        }

        private void tv_user_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem selectedItem = tv_user.SelectedItems[0];
            selected = selectedItem.SubItems[1].Text;

            load_popup_teacher_info(selected);
            if (Program.runMYSQL_GET("SELECT * FROM USER WHERE user_name='"+selected+"'", Program.connection, "chat_ban") == "on")
            {
                btn_chatban.ButtonText = "ChatBan OFF";
            }
            else
            {
                btn_chatban.ButtonText = "ChatBan ON";
            }
        }

        private void btn_chatban_Click(object sender, EventArgs e)
        {
            if (Program.runMYSQL_GET("SELECT * FROM USER WHERE user_name='" + selected + "'", Program.connection, "chat_ban") == "on")
            {
                Program.runMYSQL("UPDATE USER SET chat_ban='off' WHERE user_name='" + selected + "'", Program.connection);
                btn_chatban.ButtonText = "ChatBan ON";
            } else
            {
                Program.runMYSQL("UPDATE USER SET chat_ban='on' WHERE user_name='" + selected + "'", Program.connection);
                btn_chatban.ButtonText = "ChatBan OFF";
            }
        }
    }
}
