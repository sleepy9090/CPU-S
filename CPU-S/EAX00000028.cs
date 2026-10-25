/*
    File           EAX00000028.cs
    Brief          Form for displaying EAX=0x00000028 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/25/2026
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
    public partial class EAX00000028 : Form
    {
        private CPUHelper cpuHelper;

        public EAX00000028()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x00000028: Asymmetric RDT-A (QoS allocation) enumeration

            textBoxEAX.Text = cpuHelper.GetEAX00000028EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX00000028EBXX();
            textBoxECX.Text = cpuHelper.GetEAX00000028ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX00000028EDXX();

            #endregion
        }
    }
}
