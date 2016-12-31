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
    public partial class homework : UserControl
    {


        private static homework homework_inst;

        public static homework Instance
        {
            get
            {
                if (homework_inst == null)
                    homework_inst = new homework();
                return homework_inst;
            }
        }


        public homework()
        {
            InitializeComponent();
        }

        private void homework_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel_err_Click(object sender, EventArgs e)
        {

        }

        private void class_pic_Click(object sender, EventArgs e)
        {

        }
    }
}
