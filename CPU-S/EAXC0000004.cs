/*
    File           EAXC0000004.cs
    Brief          Form for displaying EAX=0xC0000004 CPU information.
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
    public partial class EAXC0000004 : Form
    {
        private CPUHelper cpuHelper;

        public EAXC0000004()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0xC0000004: Centaur and Zhaoxin - Performance Information - Centaur CN (Isaiah) and Zhaoxin ZX

            textBoxEAX.Text = cpuHelper.GetEAXC0000004EAXX();
            textBoxEBX.Text = cpuHelper.GetEAXC0000004EBXX();
            textBoxECX.Text = cpuHelper.GetEAXC0000004ECXX();
            textBoxEDX.Text = cpuHelper.GetEAXC0000004EDXX();

            #endregion
        }
    }
}
