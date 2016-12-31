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
        public static String name;
        private static show_msg show_msg_all_inst;
        public static show_msg Instance
        {
            get
            {
                if (show_msg_all_inst == null)
                    show_msg_all_inst = new show_msg();
                return show_msg_all_inst;
            }
        }
        public show_msg()
        {
            InitializeComponent();
        }


        public string NAME
        {
            get { return label1.Text; }
            set { label1.Text = value;}
        }



        public string MSG
        {
            get { return label2.Text; }
            set { label2.Text = value;
                  name = value;}
        }

        private void btn_answer_Click(object sender, EventArgs e)
        {
            String msg = rtb_answer_val.Text;
            Program.send_MSG(name, msg);
            rtb_answer_val.Text = "";
        }
    }
}
