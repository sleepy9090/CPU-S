/*
    File           EAX8000001A.cs
    Brief          Form for displaying EAX=0x8000001A CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/26/2026
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
    public partial class EAX8000001A : Form
    {
        private CPUHelper cpuHelper;

        public EAX8000001A()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x8000001A: Performance optimization identifiers

            textBoxEAX.Text = cpuHelper.GetEAX8000001AEAXX();
            textBoxEBX.Text = cpuHelper.GetEAX8000001AEBXX();
            textBoxECX.Text = cpuHelper.GetEAX8000001AECXX();
            textBoxEDX.Text = cpuHelper.GetEAX8000001AEDXX();

            #endregion
        }
    }
}
