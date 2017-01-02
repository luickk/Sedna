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
    public partial class homework_teacher : UserControl
    {

        private static homework_teacher homework_teacher_inst;

        public static homework_teacher Instance
        {
            get
            {
                if (homework_teacher_inst == null)
                    homework_teacher_inst = new homework_teacher();
                return homework_teacher_inst;
            }
        }


        public homework_teacher()
        {
            InitializeComponent();
            reload();
        }
        public void reload()
        {
            String class_name = dashboard_mod_teacher.selected;
            rtb_hw.Text = hw_meths.get_hw(class_name);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void bunifuThinButton1_Click(object sender, EventArgs e)
        {
            String class_name = dashboard_mod_teacher.selected;
            hw_meths.push_set_hw(rtb_hw.Text, class_name);
            reload();
        }
    }
}
