/*
    File           EAX4000000A.cs
    Brief          Form for displaying EAX=0x4000000A CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           09/22/2026
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
    public partial class EAX4000000A : Form
    {
        private CPUHelper cpuHelper;

        public EAX4000000A()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x4000000A: Reserved for Hypervisors - Hypervisor nested virtualization features

            textBoxEAX.Text = cpuHelper.GetEAX4000000AEAXX();
            textBoxEBX.Text = cpuHelper.GetEAX4000000AEBXX();
            textBoxECX.Text = cpuHelper.GetEAX4000000AECXX();
            textBoxEDX.Text = cpuHelper.GetEAX4000000AEDXX();

            #endregion
        }
    }
}
