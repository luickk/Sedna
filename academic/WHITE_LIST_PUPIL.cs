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
    public partial class WHITE_LIST_PUPIL : UserControl
    {


        /// <summary>
        /// Instance 
        /// </summary>
        private static WHITE_LIST_PUPIL WHITE_LIST_PUPIL_inst;

        /// <summary>
        /// Instance const.
        /// </summary>
        public static WHITE_LIST_PUPIL Instance
        {
            get
            {
                if (WHITE_LIST_PUPIL_inst == null)
                    WHITE_LIST_PUPIL_inst = new WHITE_LIST_PUPIL();
                return WHITE_LIST_PUPIL_inst;
            }
        }


        /// <summary>
        /// Constructor.
        /// </summary>
        public WHITE_LIST_PUPIL()
        {
            InitializeComponent();
            reload();
        }




        /// <summary>
        /// Methode for reloading white_list list
        /// </summary>
        public void reload()
        {
            Program.INSERT_INTO_WHITE_LIST(tv_user);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            reload();
        }
    }
}
