/*
    File           EAX00000029.cs
    Brief          Form for displaying EAX=0x00000029 CPU information.
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
    public partial class EAX00000029 : Form
    {
        private CPUHelper cpuHelper;

        public EAX00000029()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x00000029: APX Information

            textBoxEAX.Text = cpuHelper.GetEAX00000029EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX00000029EBXX();
            textBoxECX.Text = cpuHelper.GetEAX00000029ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX00000029EDXX();

            #endregion
        }
    }
}
