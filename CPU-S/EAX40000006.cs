/*
    File           EAX40000006.cs
    Brief          Form for displaying EAX=0x40000006 CPU information.
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
    public partial class EAX40000006 : Form
    {

        private CPUHelper cpuHelper;

        public EAX40000006()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x40000006: Reserved for Hypervisors - Hardware Features detected and in use

            textBoxEAX.Text = cpuHelper.GetEAX40000006EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX40000006EBXX();
            textBoxECX.Text = cpuHelper.GetEAX40000006ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX40000006EDXX();

            #endregion
        }
    }
}
