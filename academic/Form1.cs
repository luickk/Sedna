using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace academic
{   
    public partial class Form1 : Form
    {
        public static String msg_name;
        public static String msg_msg;
        public Form1()
        {
            InitializeComponent();
            panel_alert.Hide();
            if (TEACHER_OBJ.name=="" && PUPIL_OBJ.name == "")
            {
                //NEUTRAL STARTUP (ERROR)
                Login login = new Login();
                login.Show();
                Form1 f = new Form1();
                f.Hide();
                Console.WriteLine("----------------------------------ERROR--------------------------------");
                //NEUTRAL STARTUP (ERROR)
            }
            if(TEACHER_OBJ.name != "")
            {
                Console.WriteLine("----------------------------------TEACHER STARTUP--------------------------------");
                //TEACHER STARTUP
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
            if(PUPIL_OBJ.name != "")
            {
                Console.WriteLine("----------------------------------PUPIL STARTUP--------------------------------");
                //PUPIL STARTUP
                t_user_name.Text = PUPIL_OBJ.name;
                //PUPIL STARTUP
            }
        }

            private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Console.WriteLine(this.Width+","+this.Height);

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void dash_Click(object sender, EventArgs e)
        {
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
                } else
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

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
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

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {


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

        private void btn_homework_Click(object sender, EventArgs e)
        {

            if (TEACHER_OBJ.checkIfIsTeacher())
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

            }
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
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
                WindowState = FormWindowState.Maximized;
                maxi = true;
            }
            else
            {
                this.Size = new Size(300, 300);
                maxi = false;
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btn_mail_Click(object sender, EventArgs e)
        {
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

        private void top_bar2_MouseDown(object sender, MouseEventArgs e)
        {
            mousDown = true;
        }


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


    }
}
