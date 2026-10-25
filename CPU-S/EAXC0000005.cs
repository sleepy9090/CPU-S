/*
    File           EAXC0000005.cs
    Brief          Form for displaying EAX=0xC0000005 CPU information.
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
    public partial class EAXC0000005 : Form
    {
        private CPUHelper cpuHelper;

        public EAXC0000005()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0xC0000005: Zhaoxin - Isolation Information

            textBoxEAX.Text = cpuHelper.GetEAXC0000005EAXX();
            textBoxEBX.Text = cpuHelper.GetEAXC0000005EBXX();
            textBoxECX.Text = cpuHelper.GetEAXC0000005ECXX();
            textBoxEDX.Text = cpuHelper.GetEAXC0000005EDXX();

            #endregion
        }
    }
}
