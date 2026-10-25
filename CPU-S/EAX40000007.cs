/*
    File           EAX40000007.cs
    Brief          Form for displaying EAX=0x40000007 CPU information.
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
    public partial class EAX40000007 : Form
    {
        private CPUHelper cpuHelper;

        public EAX40000007()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x40000007: Reserved for Hypervisors - Hypervisor CPU management features

            textBoxEAX.Text = cpuHelper.GetEAX40000007EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX40000007EBXX();
            textBoxECX.Text = cpuHelper.GetEAX40000007ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX40000007EDXX();

            #endregion
        }
    }
}
