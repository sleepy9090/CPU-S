/*
    File           EAX4C780001.cs
    Brief          Form for displaying EAX=0x4C780001 CPU information.
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
    public partial class EAX4C780001 : Form
    {
        private CPUHelper cpuHelper;

        public EAX4C780001()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x4C780001: Get supervisor information - Linux flags

            textBoxEAX.Text = cpuHelper.GetEAX4C780001EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX4C780001EBXX();
            textBoxECX.Text = cpuHelper.GetEAX4C780001ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX4C780001EDXX();

            #endregion
        }
    }
}
