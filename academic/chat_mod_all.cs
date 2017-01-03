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

        /// <summary>
        /// Instance 
        /// </summary>
        private static chat_mod_all chat_mod_all_inst;
        
        /// <summary>
        /// Instance const.
        /// </summary>
        public static chat_mod_all Instance
        {
            get
            {
                if (chat_mod_all_inst == null)
                    chat_mod_all_inst = new chat_mod_all();
                return chat_mod_all_inst;
            }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public chat_mod_all()
        {
            InitializeComponent();
            t_alert_login.Hide();
        }

        //Button send clicked.
        private void btn_send_msg_Click(object sender, EventArgs e)
        {
            //Check if is Teacher.
            if (TEACHER_OBJ.checkIfIsTeacher())
            {
                //Send MSG func.
                sendMSG(tb_send_msg.text);
                //Update ListBox
                UPDATE_LB_MSGS();
                //Hide "You are BLOCKED" text
                t_alert_login.Hide();
            }
            else
            {
                //Is no teacher

                //If is pupil and blocked
                if (Program.runMYSQL_GET("SELECT * FROM USER WHERE user_name='" + PUPIL_OBJ.name + "'", Program.connection, "chat_ban") == "on")
                {   
                    //blocked-> Show "You are BLOCKED" text and not send MSGs.
                    t_alert_login.Show();
                } else
                {
                    //Is not BLOCKED -> send MSG
                    sendMSG(tb_send_msg.text);
                    //Update ListBox
                    UPDATE_LB_MSGS();
                    //Show "You are BLOCKED"
                    t_alert_login.Hide();
                }
            }
        }

        /// <summary>
        /// -> Send by enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_send_msg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                //Send MSG 
                sendMSG(tb_send_msg.text);
                //Update Chat
                UPDATE_LB_MSGS();
            }
        }

        /// <summary>
        /// Update ListBox from MYSQL database
        /// </summary>
        public void UPDATE_LB_MSGS()
        {
                //Class Strign
                String oclass;
                //Check if is Teacher
                if (TEACHER_OBJ.checkIfIsTeacher())
                {
                    //If is teacher get SELECTED class
                    oclass = dashboard_mod_teacher.selected;
                }
                else
                {
                    //If is not teacher get class of pupil
                    oclass = PUPIL_OBJ.get_user_class();
                }
                //Insert MSGs into Chat(ListBox)
                Program.INSERT_LB_CHAT(lb_msgs, "SELECT * FROM CHAT WHERE class='" + oclass + "'");
                //Get int-> visible items
                int visibleItems = lb_msgs.ClientSize.Height / lb_msgs.ItemHeight;
                //Scroll down
                lb_msgs.TopIndex = Math.Max(lb_msgs.Items.Count - visibleItems + 1, 0);
        }
        /// <summary>
        /// Methode for sending MSGs
        /// </summary>
        /// <param name="msg"></param>
        public void sendMSG(String msg)
        {
            //Check if is empty
            if (!(msg == "")) {
                //String oclass-> class name
                String oclass;
                //String oname-> name
                String oname;
                //Check if is teacher
                if (TEACHER_OBJ.checkIfIsTeacher())
                {   
                    //Define oclass
                    oclass = dashboard_mod_teacher.selected;
                    //Define name
                    oname = TEACHER_OBJ.name;
                }
                else
                {
                    //Define class
                    oclass = PUPIL_OBJ.get_user_class();
                    //Define name
                    oname = PUPIL_OBJ.name;
                }
                  //Insert into MYSQL database
                  Program.runMYSQL("INSERT INTO CHAT (class,msg,sender) VALUES ('" + oclass + "','" + msg + "','" + oname + "')", Program.connection);
                //Program.runMYSQL("INSERT INTO TEAC (tel_seeable,tidf) VALUES ('" + name + "','" + pw1 + "','" + user_class + "','" + user_class_pw + "','" + age + "','" + school + "','" + email + "','" + tel + "',' ',' ','" + teacher_id + "')", Program.connection);
                //Set Text box -> ""
                tb_send_msg.text = "";
                //Empty String msg
                msg = "";
            }
        }
        
        /// <summary>
        /// Reload button clicked-> UPDATE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
