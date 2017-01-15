using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

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
            panel_pop.Height = 0;
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
            load_popup("Homework Update", "You updated the homework!");
        }



        /// <summary>
        /// Methode to load a popup in main screen 
        /// </summary>
        /// <param name="head_line">The Headline</param>
        /// <param name="msg">The Message</param>
        public void load_popup(String head_line, String msg)
        {
            t_head_line.Text = head_line;
            t_pop_msg.Text = msg;
            //--------------------

            while (panel_pop.Height < 100)
            {
                wait_mill_sec(50);
                panel_pop.Height++;
                Application.DoEvents();
            }
            Thread.Sleep(1000);
            while (panel_pop.Height > 0)
            {
                wait_mill_sec(50);
                panel_pop.Height--;
                Application.DoEvents();
            }
            //--------------------
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

        private void homework_teacher_Load(object sender, EventArgs e)
        {

        }
    }
}
