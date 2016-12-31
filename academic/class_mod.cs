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
    public partial class class_mod : UserControl
    {
        private static class_mod class_mod_inst;

        public static class_mod Instance
        {
            get
            {
                if (class_mod_inst == null)
                    class_mod_inst = new class_mod();
                return class_mod_inst;
            }
        }

        public class_mod()
        {
            InitializeComponent();
        }

        private void class_mod_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
