using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace academic
{



    public partial class Login : Form
    {
        /// <summary>
        /// Var teacher
        /// </summary>
        public static bool teacher = false;

        /// <summary>
        /// Var login teacher
        /// </summary>
        public static bool teacher_login = false;

        /// <summary>
        /// Login const.
        /// </summary>
        public Login()
        {
            InitializeComponent();
            dd_te_or_pup.Text = "Pupil";
        }

        /// <summary>
        /// Event-> Exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
        
         }

        /// <summary>
        /// Event-> Minimize
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                mousesX = MousePosition.X;
                mousesY = MousePosition.Y;

                this.SetDesktopLocation(mousesX - MX, mousesY - MY);
            }
        }


        //LOGIN

        String user_username;
        String user_pw;
        /// <summary>
        /// Event-> Login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuThinButton1_Click(object sender, EventArgs e)
        {
            user_username = this.tb_login_first_name.text.Trim() + "," + this.tb_login_last_name.text.Trim();
            user_pw = this.tb_pw.text.Trim();
            //dd_login
            if (teacher_login)
            {
                if (Program.runMYSQL_EXISTS("SELECT count(*) FROM TEACHER WHERE user_name = '" + user_username.Trim() + "' AND user_pass='" + user_pw.Trim() + "'", Program.connection))
                {
                    TEACHER_OBJ.name = user_username;
                    TEACHER_OBJ.pass= user_pw;
                    Main main_form = new Main();
                    main_form.Show();
                    this.Hide();
                }
                else
                {
                    alert_login.Text = "Wrong data, are you a pupil?";
                }
            }
            else
            {
                if (Program.runMYSQL_EXISTS("SELECT count(*) FROM USER WHERE user_name = '" + user_username.Trim() + "' AND user_pass='" + user_pw.Trim() + "'", Program.connection))
                {
                    
                    PUPIL_OBJ.name = user_username;
                    PUPIL_OBJ.pass = user_pw;
                    Main main_form = new Main();
                    main_form.Show();
                    this.Hide();
                    Console.WriteLine(PUPIL_OBJ.name);
                }
                else
                {
                    alert_login.Text = "Wrong data, are you a teacher?";
                }
            }


        }
        //LOGIN

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Slide login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_login_sel_Click(object sender, EventArgs e)
        {
            if (panel_login.Left >= 20)
            {
                toLogin();
            }
        }

        /// <summary>
        /// Slide reg
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_reg_sel_Click(object sender, EventArgs e)
        {
            if (panel_reg.Left >= 20)
            {
                toReg();
            }

        }

        //---------------------------
        private void bunifuSeparator2_Load(object sender, EventArgs e)
        {

        }


        private void bunifuTextbox3_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuTextbox4_OnTextChange(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        //REGISTER
        String name;
        String pw1;
        String pw2;
        String user_class;
        String user_class_pw;
        String age;
        String school;
        String teacher_id;
        String email;
        String tel;
        /// <summary>
        /// Event-> Reg
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_reg_Click(object sender, EventArgs e)
        {
            name = this.tb_fn.text + "," + this.tb_ln.text;
            pw1 = this.tb_pw1.text;
            pw2 = this.tb_pw2.text;
            email = this.tb_email.text;
            tel = this.tb_tel.text;
            if (teacher)
            {
                teacher_id = this.tb_class.text;
            } else
            {
                user_class = this.tb_class.text;
            }
            user_class_pw = this.tb_class_pw.text;
            school = this.tb_school.text;
            age = this.tb_age.text;
            //Console.WriteLine(name+pw1+pw2 + user_class + user_class_pw + school);



            if ( name == "First Name,Last Name"  || school == "School name" || school == "School name" || email == "Email" || tel == "Telephone number" || email == "" || name == "" || tel == "" || school == "")
            { 

                reg_alert.Text = "Error, please fill every field!";
            } else
            {
                if ((pw1.Equals(pw2)))
                {
                    reg_alert.Text = "Data Correct";

                        if (teacher)
                    {
                        //////////////////////TEACHER REG
                        if (!Program.runMYSQL_EXISTS("SELECT count(*) FROM TEACHER WHERE user_name = '" + name.Trim() + "'", Program.connection))
                        {
                        user_class_pw = "";
                            age = "0";
                            if (Program.runMYSQL_EXISTS("SELECT count(*) FROM IDs WHERE tid = '" + teacher_id.Trim() + "'", Program.connection))
                            {
                                if(Program.runMYSQL_EXISTS("SELECT count(*) FROM IDs WHERE tid = '" + teacher_id.Trim() + "' AND used=1", Program.connection))
                                {
                                    reg_alert.Text = "ID Already in use";
                                } else
                                {
                                    Program.runMYSQL("UPDATE IDs SET name='" + name.Trim() + "',school='" + school.Trim() + "',tid='" + teacher_id.Trim() + "',used='1',blocked='0' WHERE tid='" + teacher_id.Trim() + "'", Program.connection);
                                    //UPDATE sss SET lastname='Doe'                                                                            WHERE id=2
                                    Program.runMYSQL("INSERT INTO TEACHER (user_name,user_pass,user_class,user_class_pw,user_age,user_school,email,tel,email_seeable,tel_seeable,tid) VALUES ('" + name + "','" + pw1 + "','" + user_class + "','" + user_class_pw + "','" + age + "','" + school + "','" + email + "','" + tel + "','off','off','" + teacher_id + "')", Program.connection);
                                    reg_alert.Text = "Registered successfully";
                                    toLogin();
                                }
                            }
                            else
                            {
                                reg_alert.Text = "No ID Found";
                            }
                        } else
                        {
                            reg_alert.Text = "Name Already in use";

                        }
                        //////////////////////TEACHER REG
                    }
                    else
                    {
                        //////////////////////PUPIL REG
                        if (!Program.runMYSQL_EXISTS("SELECT count(*) FROM USER WHERE user_name = '" + name.Trim() + "'", Program.connection))
                        {
                            if (Program.runMYSQL_EXISTS("SELECT count(*) FROM CLASSES WHERE class_name = '" + user_class.Trim() + "' AND class_pw = '" + user_class_pw.Trim() + "'", Program.connection))
                            {
                                Program.runMYSQL("INSERT INTO USER (user_name,user_pass,user_class,user_class_pw,user_age,user_school,email,chat_ban) VALUES ('" + name.Trim() + "','" + pw1.Trim() + "','" + user_class.Trim() + "','" + user_class_pw.Trim() + "','" + age.Trim() + "','" + school.Trim() + "','" + email.Trim() + "','off')", Program.connection);
                                reg_alert.Text = "Registered successfully";
                                toLogin();
                                } else
                            {
                                reg_alert.Text = "Class Pw or Name wrong!";
                            }
                        }
                        else
                        {
                            reg_alert.Text = "Name Already in use";

                        }
                       
                        //////////////////////PUPIL REG
                    }
                } else
                {
                    reg_alert.Text = "Passwords don t match";
                }

            }
        }

        //REGISTER
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void tb_pw_OnTextChange(object sender, EventArgs e)
        {
            Console.WriteLine(tb_pw.text);
        }

        private void panel_reg_Paint(object sender, PaintEventArgs e)
        {

        }
        /// <summary>
        /// Event-> Selected item 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        bool isteach =false;
        private void dd_te_or_pup_onItemSelected(object sender, EventArgs e)
        {
            int row = int.Parse(dd_te_or_pup.selectedIndex.ToString());
            if (row == 0)
            {
                isteach = true;
                tb_class_pw.Hide();
                tb_age.Hide();
                tb_class.text = "Teacher ID";
                tb_class.Width = 414;
                tb_class.Height = 67;
                tb_reg_class = false;
                 //414; 67
                 teacher = true;
            }
            else if (row == 1)
            {
                isteach = false;
                tb_class.text = "Class name";
                tb_class.Width = 194;
                tb_class.Height = 57;
                //194; 57
                tb_class_pw.Show();
                tb_age.Show();
                teacher = false;
            }
        }

        private void tb_class_pw_OnTextChange(object sender, EventArgs e)
        {

        }

        // Window drag and drop funcs.
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

        private void dd_login_onItemSelected(object sender, EventArgs e)
        {
            int row = int.Parse(dd_login.selectedIndex.ToString());
            if (row == 0)
            {
                t_login.Text = "Login as teacher";
                teacher_login = true;
            }
            else if (row == 1)
            {
                t_login.Text = "Login as pupil";
                teacher_login = false;
            }
        }
        // Window drag and drop funcs.

        //<----------Clear TextBoxes when clicked------------->
        bool tb_l_fn =false;
        private void tb_login_first_name_Enter_1(object sender, EventArgs e)
        {
            if(!tb_l_fn)
                tb_login_first_name.text = "";
                tb_l_fn = true;
        }

        bool tb_l_ln = false;
        private void tb_login_last_name_Enter_(object sender, EventArgs e)
        {
            if (!tb_l_ln)
                tb_login_last_name.text = "";
                tb_l_ln = true;
        }

        bool tb_l_pw = false;
        private void tb_pw_Enter_(object sender, EventArgs e)
        {
            if (!tb_l_pw)
                tb_pw.text = "";
                tb_l_pw = true;
        }

        bool tb_reg_fn = false;
        private void tb_fn_Enter(object sender, EventArgs e)
        {
            if (!tb_reg_fn)
                tb_fn.text = "";
                tb_reg_fn = true;
        }

        bool tb_reg_ln = false;
        private void tb_ln_Enter(object sender, EventArgs e)
        {
            if (!tb_reg_ln)
                tb_ln.text = "";
                tb_reg_ln = true;
        }

        bool tb_reg_school = false;
        private void tb_school_Enter(object sender, EventArgs e)
        {
            if (!tb_reg_school)
                tb_school.text = "";
                tb_reg_school = true;
        }

        bool tb_reg_pw1 = false;
        private void tb_pw1_Enter(object sender, EventArgs e)
        {
            if (!tb_reg_pw1)
                tb_pw1.text = "";
                tb_reg_pw1 = true;
        }

        bool tb_reg_pw2 = false;
        private void tb_pw2_Enter(object sender, EventArgs e)
        {
            if (!tb_reg_pw2)
                tb_pw2.text = "";
                tb_reg_pw2 = true;
        }

        bool tb_reg_class = false;
        private void tb_class_Enter(object sender, EventArgs e)
        {
            if (!tb_reg_class)
                tb_class.text = "";
                tb_reg_class = true;
                if(isteach)
                    System.Diagnostics.Process.Start("http://134.255.234.216/createKey.php");
        }

        bool tb_reg_class_pw = false;
        private void tb_class_pw_Enter(object sender, EventArgs e)
        {
            if (!tb_reg_class_pw)
                tb_class_pw.text = "";
                tb_reg_class_pw = true;
        }

        bool tb_reg_age = false;
        private void tb_age_Enter(object sender, EventArgs e)
        {
            if (!tb_reg_age)
                tb_age.text = "";
                tb_reg_age = true;
        }

        bool tb_reg_email = false;
        private void tb_email_Enter(object sender, EventArgs e)
        {
            if (!tb_reg_email)
                tb_email.text = "";
                tb_reg_email = true;

        }
        
        bool tb_reg_tel = false;
        private void tb_tel_Enter(object sender, EventArgs e)
        {
            if (!tb_reg_tel)
                tb_tel.text = "";
                tb_reg_tel = true;
        }

        //<----------Clear TextBoxes when clicked------------->



        /// <summary>
        /// Methode to Slide to Login
        /// </summary>
        private void toLogin()
        {

            line.Left = 124;
            panel_reg.Visible = false;
            panel_reg.Left = 574;

            panel_login.Visible = false;
            panel_login.Left = 53;
            panel_login.Visible = true;
            panel_login.Refresh();
        }

        /// <summary>
        /// Methode for Slide to Reg 
        /// </summary>
        private void toReg()
        {
            line.Left = 297;
            panel_login.Visible = false;
            panel_login.Left = 574;

            panel_reg.Visible = false;
            panel_reg.Left = 23;
            panel_reg.Visible = true;
            panel_reg.Refresh();
        }
    }
}
