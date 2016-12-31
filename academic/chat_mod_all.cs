using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Threading;

namespace academic
{
    public partial class chat_mod_all : UserControl
    {


        private static chat_mod_all chat_mod_all_inst;
        public BackgroundWorker backgroundWorker;
        public static chat_mod_all Instance
        {
            get
            {
                if (chat_mod_all_inst == null)
                    chat_mod_all_inst = new chat_mod_all();
                return chat_mod_all_inst;
            }
        }


        public chat_mod_all()
        {
            InitializeComponent();
            t_alert_login.Hide();
        }
        private void btn_send_msg_Click(object sender, EventArgs e)
        {
            if (TEACHER_OBJ.checkIfIsTeacher())
            {
                sendMSG(tb_send_msg.text);
                UPDATE_LB_MSGS();
                t_alert_login.Hide();
            }
            else
            {
                if (Program.runMYSQL_GET("SELECT * FROM USER WHERE user_name='" + PUPIL_OBJ.name + "'", Program.connection, "chat_ban") == "on")
                {
                    t_alert_login.Show();
                } else
                {
                    sendMSG(tb_send_msg.text);
                    UPDATE_LB_MSGS();
                    t_alert_login.Hide();
                }
            }
        }

        private void tb_send_msg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                sendMSG(tb_send_msg.text);
                UPDATE_LB_MSGS();
            }
        }

        public void UPDATE_LB_MSGS()
        {
            String oclass;
                if (TEACHER_OBJ.checkIfIsTeacher())
                {
                    oclass = dashboard_mod_teacher.selected;
                }
                else
                {
                    oclass = PUPIL_OBJ.get_user_class();
                }
                Program.INSERT_LB_CHAT(lb_msgs, "SELECT * FROM CHAT WHERE class='" + oclass + "'");
                int visibleItems = lb_msgs.ClientSize.Height / lb_msgs.ItemHeight;
                lb_msgs.TopIndex = Math.Max(lb_msgs.Items.Count - visibleItems + 1, 0);
        }

        public void sendMSG(String msg)
        {
            if (!(msg == "")) {
                Console.WriteLine(msg); 
                String oclass;
                String oname;
                if (TEACHER_OBJ.checkIfIsTeacher())
                {
                    oclass = dashboard_mod_teacher.selected;
                    oname = TEACHER_OBJ.name;
                }
                else
                {
                    oclass = PUPIL_OBJ.get_user_class();
                    oname = PUPIL_OBJ.name;
                }
                  Program.runMYSQL("INSERT INTO CHAT (class,msg,sender) VALUES ('" + oclass + "','" + msg + "','" + oname + "')", Program.connection);
                //Program.runMYSQL("INSERT INTO TEAC (tel_seeable,tidf) VALUES ('" + name + "','" + pw1 + "','" + user_class + "','" + user_class_pw + "','" + age + "','" + school + "','" + email + "','" + tel + "',' ',' ','" + teacher_id + "')", Program.connection);
                tb_send_msg.text = "";
                msg = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UPDATE_LB_MSGS();

        }

        private void chat_mod_all_Load(object sender, EventArgs e)
        {

        }

        private void lb_msgs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tb_send_msg_OnTextChange(object sender, EventArgs e)
        {

        }
    }
}
