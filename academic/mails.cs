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
    public partial class mails : UserControl
    {

        /// <summary>
        /// Instance
        /// </summary>
        private static mails mails_inst;

        /// <summary>
        /// Instance const.
        /// </summary>
        public static mails Instance
        {
            get
            {
                if (mails_inst == null)
                    mails_inst = new mails();
                return mails_inst;
            }
        }

        /// <summary>
        /// Const.
        /// </summary>
        public mails()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event-> Send MSG
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuThinButton1_Click(object sender, EventArgs e)
        {
            String name = tb_mail_first_name.text + "," +tb_mail_last_name.text;
            String msg = rtb_msg_mail.Text;
            Program.send_MSG(name, msg);
            msg = "";
            name = "";
            tb_mail_first_name.text = "";
            tb_mail_last_name.text = "";
            rtb_msg_mail.Text = "";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_answer_Click(object sender, EventArgs e)
        {

        }
    }
}
