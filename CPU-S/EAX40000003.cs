/*
    File           EAX40000003.cs
    Brief          Form for displaying EAX=0x40000003 CPU information.
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
    public partial class EAX40000003 : Form
    {
        // ECX 3...0 - Maximum Processor Power State (0=C0, 1=C1, 2=C2, 3=C3)
        public const string C0_ACTIVE = "C0 - Active";
        public const string C1_HALT = "C1 - Halt";
        public const string C2_STOP_CLOCK = "C2 - Stop-Clock";
        public const string C3_SLEEP = "C3 - Sleep";

        private CPUHelper cpuHelper;

        public EAX40000003()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x40000003: Reserved for Hypervisors - Features

            string cpuIdEAX40000003EAX = cpuHelper.GetEAX40000003EAXX();
            textBoxEAX40000003EAX.Text = cpuIdEAX40000003EAX;

            string cpuIdEAX40000003EBX = cpuHelper.GetEAX40000003EBXX();
            textBoxEAX40000003EBX.Text = cpuIdEAX40000003EBX;

            string cpuIdEAX40000003ECX = cpuHelper.GetEAX40000003ECXX();
            textBoxEAX40000003ECX.Text = cpuIdEAX40000003ECX;

            string cpuIdEAX40000003EDX = cpuHelper.GetEAX40000003EDXX();
            textBoxEAX40000003EDX.Text = cpuIdEAX40000003EDX;

            #endregion
        }
    }
}
