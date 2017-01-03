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
    public partial class show_msg : UserControl
    {

        /// <summary>
        /// Name of sender
        /// </summary>
        public static String name;

        /// <summary>
        /// Instance
        /// </summary>
        private static show_msg show_msg_all_inst;

        /// <summary>
        /// Instance const.
        /// </summary>
        public static show_msg Instance
        {
            get
            {
                if (show_msg_all_inst == null)
                    show_msg_all_inst = new show_msg();
                return show_msg_all_inst;
            }
        }

        /// <summary>
        /// Const.
        /// </summary>
        public show_msg()
        {
            InitializeComponent();
        }

        /// <summary>
        /// GETTER and SETTER for NAME
        /// </summary>
        public string NAME
        {
            get { return label1.Text; }
            set { label1.Text = value;}
        }

        /// <summary>
        /// GETTER and SETTER for MSG
        /// </summary>
        public string MSG
        {
            get { return label2.Text; }
            set { label2.Text = value;
                  name = value;}
        }

        /// <summary>
        /// Event-> Answer 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_answer_Click(object sender, EventArgs e)
        {
            String msg = rtb_answer_val.Text;
            Program.send_MSG(name, msg);
            rtb_answer_val.Text = "";
        }
    }
}
