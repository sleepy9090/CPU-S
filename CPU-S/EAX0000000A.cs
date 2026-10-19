/*
    File           EAX0000000A.cs
    Brief          Form for displaying EAX=0x0000000A CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/18/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX0000000A : Form
    {

        private CPUHelper cpuHelper;

        public EAX0000000A()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX = 0x0000000A: Architectural perf mon information

            textBoxEAX0000000AEAX.Text = cpuHelper.GetEAX0000000AEAXX();
            textBoxEAX0000000AEBX.Text = cpuHelper.GetEAX0000000AEBXX();
            textBoxEAX0000000AECX.Text = cpuHelper.GetEAX0000000AECXX();
            textBoxEAX0000000AEDX.Text = cpuHelper.GetEAX0000000AEDXX();

            #endregion
        }
    }
}
