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
        /// <summary>
        /// Instance
        /// </summary>
        private static homework_teacher homework_teacher_inst;

        /// <summary>
        /// Instance const.
        /// </summary>
        public static homework_teacher Instance
        {
            get
            {
                if (homework_teacher_inst == null)
                    homework_teacher_inst = new homework_teacher();
                return homework_teacher_inst;
            }
        }

        /// <summary>
        /// Const.
        /// </summary>
        public homework_teacher()
        {
            InitializeComponent();
            reload();
        }

        /// <summary>
        /// Methode for reloading hw
        /// </summary>
        public void reload()
        {
            String class_name = dashboard_mod_teacher.selected;
            rtb_hw.Text = hw_meths.get_hw(class_name);
        }

        /// <summary>
        /// Event-> Reload
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            reload();
        }

        /// <summary>
        /// Event-> Set hw
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuThinButton1_Click(object sender, EventArgs e)
        {
            String class_name = dashboard_mod_teacher.selected;
            hw_meths.push_set_hw(rtb_hw.Text, class_name);
            reload();
        }
    }
}
