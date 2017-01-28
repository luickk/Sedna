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
    public partial class settings_mod : UserControl
    {


        private static settings_mod settings_mod_inst;

        public static settings_mod Instance
        {
            get
            {
                if (settings_mod_inst == null)
                    settings_mod_inst = new settings_mod();
                return settings_mod_inst;
            }
        }


        public settings_mod()
        {
            InitializeComponent();
        }

        private void settings_mod_Load(object sender, EventArgs e)
        {

        }
    }
}
