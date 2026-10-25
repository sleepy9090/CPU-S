/*
    File           EAX4000000E.cs
    Brief          Form for displaying EAX=0x4000000E CPU information.
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
    public partial class EAX40000081 : Form
    {
        private CPUHelper cpuHelper;

        public EAX40000081()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x40000081: SYNDBG interface (deprecated) / undocumented/Virtual Stack Interface

            textBoxEAX.Text = cpuHelper.GetEAX40000081EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX40000081EBXX();
            textBoxECX.Text = cpuHelper.GetEAX40000081ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX40000081EDXX();

            #endregion
        }
    }
}
