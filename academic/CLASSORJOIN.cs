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
    public partial class CLASSORJOIN : UserControl
    {




        private static CLASSORJOIN CLASSORJOIN_inst;

        public static CLASSORJOIN Instance
        {
            get
            {
                if (CLASSORJOIN_inst == null)
                    CLASSORJOIN_inst = new CLASSORJOIN();
                return CLASSORJOIN_inst;
            }
        }

        public CLASSORJOIN()
        {
            InitializeComponent();
        }


    }
}
