/*
    File           EAX4C780002.cs
    Brief          Form for displaying EAX=0x4C780002 CPU information.
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
    public partial class EAX4C780002 : Form
    {
        private CPUHelper cpuHelper;

        public EAX4C780002()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x4C780002: Get supervisor information - Linux bugs

            textBoxEAX.Text = cpuHelper.GetEAX4C780002EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX4C780002EBXX();
            textBoxECX.Text = cpuHelper.GetEAX4C780002ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX4C780002EDXX();

            #endregion
        }
    }
}
