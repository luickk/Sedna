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
    public partial class chat_mod : UserControl
    {


        private static chat_mod chat_mod_inst;

        public static chat_mod Instance
        {
            get
            {
                if (chat_mod_inst == null)
                    chat_mod_inst = new chat_mod();
                return chat_mod_inst;
            }
        }


        public chat_mod()
        {
            InitializeComponent();
        }

        private void chat_mod_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel_err_Click(object sender, EventArgs e)
        {

        }
    }
}
