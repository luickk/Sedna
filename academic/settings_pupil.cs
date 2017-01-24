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
    public partial class settings_pupil : UserControl
    {
        /// <summary>
        /// Instance 
        /// </summary>
        private static settings_pupil settings_pupil_inst;

        /// <summary>
        /// Instance const.
        /// </summary>
        public static settings_pupil Instance
        {
            get
            {
                if (settings_pupil_inst == null)
                    settings_pupil_inst = new settings_pupil();
                return settings_pupil_inst;
            }
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public settings_pupil()
        {
            InitializeComponent();
        }
    }
}
