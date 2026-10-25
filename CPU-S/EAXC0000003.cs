/*
    File           EAXC0000003.cs
    Brief          Form for displaying EAX=0xC0000003 CPU information.
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
    public partial class EAXC0000003 : Form
    {

        private CPUHelper cpuHelper;

        public EAXC0000003()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0xC0000003: Centaur - [speculative interpretation] Processor Serial Number

            textBoxEAX.Text = cpuHelper.GetEAXC0000003EAXX();
            textBoxEBX.Text = cpuHelper.GetEAXC0000003EBXX();
            textBoxECX.Text = cpuHelper.GetEAXC0000003ECXX();
            textBoxEDX.Text = cpuHelper.GetEAXC0000003EDXX();

            #endregion
        }
    }
}
