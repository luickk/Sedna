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
    public partial class settings_teacher : UserControl
    {
        /// <summary>
        /// Instance 
        /// </summary>
        private static settings_teacher settings_teacher_inst;

        /// <summary>
        /// Instance const.
        /// </summary>
        public static settings_teacher Instance
        {
            get
            {
                if (settings_teacher_inst == null)
                    settings_teacher_inst = new settings_teacher();
                return settings_teacher_inst;
            }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public settings_teacher()
        {
            InitializeComponent();
        }
    }
}
