using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace academic
{   
    public partial class Main : Form
    {

        /// <summary>
        /// MSG Sender name
        /// </summary>
        public static String msg_name;

        /// <summary>
        /// MSG value
        /// </summary>
        public static String msg_msg;


        /// <summary>
        /// Form1 const.
        /// </summary>
        public Main()
        {
            //Methode for Initializing Methodes 
            InitializeComponent();
            //Hiding panel for new incoming panels.
            panel_alert.Hide();
            
            //Checked if loged in correctly 
            if (TEACHER_OBJ.name=="" && PUPIL_OBJ.name == "")
            {
                //NEUTRAL STARTUP (ERROR)
                Login login = new Login();
                login.Show();
                Main f = new Main();
                f.Hide();
                Console.WriteLine("----------------------------------ERROR--------------------------------");
                //NEUTRAL STARTUP (ERROR)
            }
            //Checke if is teacher
            if(TEACHER_OBJ.name != "")
            {
                Console.WriteLine("----------------------------------TEACHER STARTUP--------------------------------");
                hideall();
                line_btn.Show();
                //TEACHER STARTUP -> Loading Dashboard
                t_user_name.Text = TEACHER_OBJ.name;

                CONTENT.Controls.Remove(dashboard_mod_teacher.Instance);
                if (!CONTENT.Controls.Contains(dashboard_mod_teacher.Instance))
                {
                    CONTENT.Controls.Add(dashboard_mod_teacher.Instance);
                    dashboard_mod_teacher.Instance.Dock = DockStyle.Fill;
                    dashboard_mod_teacher.Instance.BringToFront();
                }
                else
                {

                    dashboard_mod_teacher.Instance.BringToFront();
                }

                //TEACHER STARTUP                                                                                                                                      
            }
            //Cheack if is pupil
            if (PUPIL_OBJ.name != "")
            {
                Console.WriteLine("----------------------------------PUPIL STARTUP--------------------------------");
                hideall();
                //PUPIL STARTUP -> No Dashboard
                t_user_name.Text = PUPIL_OBJ.name;
                //PUPIL STARTUP
            }
        }

        /// <summary>
        /// Event-> Form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Loading class_user_controll in Form1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dash_Click(object sender, EventArgs e)
        {
            //Check if is teacher
            hideall();
            bunifuSeparator1.Show();
            if (TEACHER_OBJ.checkIfIsTeacher())
            {
                if (dashboard_mod_teacher.selected == "")
                {

                    if (!CONTENT.Controls.Contains(class_mod.Instance))
                    {
                        CONTENT.Controls.Add(class_mod.Instance);
                        class_mod.Instance.Dock = DockStyle.Fill;
                        class_mod.Instance.BringToFront();
                    }
                    else
                    {
                        class_mod_pupil.Instance.BringToFront();
                    }
                }
                //If is not teacher
                else
                {
                    if (!CONTENT.Controls.Contains(class_mod_teacher.Instance))
                    {
                        CONTENT.Controls.Add(class_mod_teacher.Instance);
                        class_mod_teacher.Instance.Dock = DockStyle.Fill;
                        class_mod_teacher.Instance.BringToFront();
                    }
                    else
                    {
                        class_mod_teacher.Instance.BringToFront();
                    }
                }
            } else
            {
                if (!CONTENT.Controls.Contains(class_mod_pupil.Instance))
                {
                    CONTENT.Controls.Add(class_mod_pupil.Instance);
                    class_mod_pupil.Instance.Dock = DockStyle.Fill;
                    class_mod_pupil.Instance.BringToFront();
                }
                else
                {
                    class_mod_pupil.Instance.BringToFront();
                }

            }
        }

        /// <summary>
        /// Loading chat_view_user_controll in Form1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            hideall();
            bunifuSeparator2.Show();
            if (dashboard_mod_teacher.selected == "")
            {
                if (!(TEACHER_OBJ.checkIfIsTeacher())){
                    if (!CONTENT.Controls.Contains(chat_mod_all.Instance))
                    {
                        CONTENT.Controls.Add(chat_mod_all.Instance);
                        chat_mod_all.Instance.Dock = DockStyle.Fill;
                        chat_mod_all.Instance.BringToFront();
                    }
                    else
                    {
                        chat_mod_all.Instance.BringToFront();
                    }
                } else
                {
                    if (!CONTENT.Controls.Contains(chat_mod.Instance))
                    {
                        CONTENT.Controls.Add(chat_mod.Instance);
                        chat_mod.Instance.Dock = DockStyle.Fill;
                        chat_mod.Instance.BringToFront();
                    }
                    else
                    {
                        chat_mod.Instance.BringToFront();
                    }
                }
            } else
            {
                if (!CONTENT.Controls.Contains(chat_mod_all.Instance))
                {
                    CONTENT.Controls.Add(chat_mod_all.Instance);
                    chat_mod_all.Instance.Dock = DockStyle.Fill;
                    chat_mod_all.Instance.BringToFront();
                }
                else
                {
                    chat_mod_all.Instance.BringToFront();
                }
            }
        }

        /// <summary>
        /// Loading settings_view_user_controll in Form1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            hideall();
            bunifuSeparator6.Show();

            if (TEACHER_OBJ.checkIfIsTeacher())
            {

            }
            else
            {
            if (!CONTENT.Controls.Contains(settings_mod.Instance))
            {
                CONTENT.Controls.Add(settings_mod.Instance);
                settings_mod.Instance.Dock = DockStyle.Fill;
                settings_mod.Instance.BringToFront();
            }
            else
            {
                settings_mod.Instance.BringToFront();
                }

            }

        }

        /// <summary>
        /// Loading homework_view_user_controll in Form1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_homework_Click(object sender, EventArgs e)
        {
            hideall();
            bunifuSeparator3.Show();
            if (TEACHER_OBJ.checkIfIsTeacher())
            {

                if (dashboard_mod_teacher.selected == "")
                {

                    if (!CONTENT.Controls.Contains(homework.Instance))
                    {
                        CONTENT.Controls.Add(homework.Instance);
                        homework.Instance.Dock = DockStyle.Fill;
                        homework.Instance.BringToFront();
                    }
                    else
                    {
                        homework.Instance.BringToFront();
                    }

                } else
                {
                    hw_meths.check_and_create();
                    if (!CONTENT.Controls.Contains(homework_teacher.Instance))
                    {
                        CONTENT.Controls.Add(homework_teacher.Instance);
                        homework_teacher.Instance.Dock = DockStyle.Fill;
                        homework_teacher.Instance.BringToFront();
                    }
                    else
                    {
                        homework_teacher.Instance.BringToFront();
                    }
                }
            } else
                {
                    if (!CONTENT.Controls.Contains(homework_pupil.Instance))
                {
                    CONTENT.Controls.Add(homework_pupil.Instance);
                    homework_pupil.Instance.Dock = DockStyle.Fill;
                    homework_pupil.Instance.BringToFront();
                }
                else
                {
                    homework_pupil.Instance.BringToFront();
                    }

            }
        }

        /// <summary>
        /// Loading dashboard_view_user_controll in Form1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            hideall();
            line_btn.Show();
            if (TEACHER_OBJ.checkIfIsTeacher())
            {
                CONTENT.Controls.Remove(dashboard_mod_teacher.Instance);
                if (!CONTENT.Controls.Contains(dashboard_mod_teacher.Instance))
                {
                    CONTENT.Controls.Add(dashboard_mod_teacher.Instance);
                    dashboard_mod_teacher.Instance.Dock = DockStyle.Fill;
                    dashboard_mod_teacher.Instance.BringToFront();
                }
                else
                {
                    dashboard_mod_teacher.Instance.BringToFront();
                }
            } else
            {

            }
        }
        private void CONTENT_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        bool maxi = false;
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (!maxi)
            {
                this.Size = new Size(300, 300);
                maxi = false;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                maxi = true;
            }
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //-----------------------------
        int mousesX = 0, mousesY = 0;
        int MX = 0, MY = 0;
        bool mousDown;

        private void top_bar_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousDown)
            {
                mousesX = MousePosition.X-300;
                mousesY = MousePosition.Y;

                this.SetDesktopLocation(mousesX-MX, mousesY-MY);
            }
        }

        private void top_bar_MouseUp(object sender, MouseEventArgs e)
        {
            mousDown = false;
        }

        private void top_bar_MouseDown(object sender, MouseEventArgs e)
        {
            mousDown = true;
            MX = e.X;
            MY = e.Y;
        }

        private void top_bar2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousDown)
            {
                mousesX = MousePosition.X;
                mousesY = MousePosition.Y;

                this.SetDesktopLocation(mousesX, mousesY);
            }
        }

        private void top_bar_Paint(object sender, PaintEventArgs e)
        {

        }

        bool alert_clicked=false;
        private void pb_alert_Click(object sender, EventArgs e)
        {
            if (!alert_clicked) {
                panel_alert.Show();
                alert_clicked = true;

                String name;
                if (TEACHER_OBJ.checkIfIsTeacher())
                {
                    name = TEACHER_OBJ.name;
                }
                else
                {
                    name = PUPIL_OBJ.name;
                }
                Program.INSERT_LB_MSG_ALERT(lb_msgs_alert, "SELECT * FROM MSG_SYS WHERE reciever='" + name + "' ORDER BY id");
                Program.runMYSQL("UPDATE MSG_SYS SET checked='1' WHERE reciever='"+name+"'", Program.connection);
                REFRESH_ALERT_MSG();
            } else {
                panel_alert.Hide();
                alert_clicked = false;
            }

        }
        public void REFRESH_ALERT_MSG()
        {
            int t = Program.checkMSGS_AVAILABLE();
            if (t > 0)
            {
                t_alert_count.Text = t.ToString();
            } else
            {
                t_alert_count.Text = "0";
            }
        }


        
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            REFRESH_ALERT_MSG();
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


        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Loading mails_view_user_controll in Form1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_mail_Click(object sender, EventArgs e)
        {
            hideall();
            bunifuSeparator4.Show();
            //////////////---------------
            if (!CONTENT.Controls.Contains(mails.Instance))
                {
                    CONTENT.Controls.Add(mails.Instance);
                    mails.Instance.Dock = DockStyle.Fill;
                    mails.Instance.BringToFront();
                }
                else
                {
                    mails.Instance.BringToFront();
                }
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {

        }

        private void panel_alert_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lb_msgs_alert.SelectedIndex;
        }

        private void top_bar2_MouseUp(object sender, MouseEventArgs e)
        {
            mousDown = false;
        }

        /// <summary>
        /// Event-> Message List double clicked -> Open expanded message view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lb_msgs_alert_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String text = lb_msgs_alert.SelectedItem.ToString();
            String name="";
            String msg="";
            Char delimiter = ':';
            String[] substrings = text.Split(delimiter);
            int id=0;
            foreach (var substring in substrings)
            {
                id++;
                if(id == 1){
                    name = substring;
                } else if (id == 2)
                {
                    msg = substring;
                }
            }
            Console.WriteLine(name+","+ msg);
            load_msg(name, msg);
            msg_name = name;
            msg_msg = msg;
        }

        /// <summary>
        /// Event-> Opens mail view in Form1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_sendMSG_alert_Click(object sender, EventArgs e)
        {
            if (!CONTENT.Controls.Contains(mails.Instance))
            {
                CONTENT.Controls.Add(mails.Instance);
                mails.Instance.Dock = DockStyle.Fill;
                mails.Instance.BringToFront();
            }
            else
            {
                mails.Instance.BringToFront();
            }
        }

        private void MENU2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void line_btn_Load(object sender, EventArgs e)
        {

        }

        private void top_bar2_MouseDown(object sender, MouseEventArgs e)
        {
            mousDown = true;
        }

        private void bunifuSeparator2_Load(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator3_Load(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator6_Load(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator4_Load(object sender, EventArgs e)
        {

        }

        private void bunifuSeparator7_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Methode for loaing messages into expanded message view
        /// </summary>
        /// <param name="MSG"></param>
        /// <param name="name"></param>
        public void load_msg(String MSG, String name)
        {
            if (!CONTENT.Controls.Contains(show_msg.Instance))
            {
                CONTENT.Controls.Add(show_msg.Instance);
                show_msg.Instance.Dock = DockStyle.Fill;
                show_msg.Instance.BringToFront();
            }
            else
            {
                show_msg.Instance.BringToFront();
            }
            show_msg.Instance.MSG = MSG;
            show_msg.Instance.NAME = name;
        }

        public void hideall()
        {
            line_btn.Hide();
            bunifuSeparator1.Hide();
            bunifuSeparator2.Hide();
            bunifuSeparator3.Hide();
            bunifuSeparator4.Hide();
            bunifuSeparator5.Hide();
            bunifuSeparator6.Hide();
        }
    }
}
