/*
    File           EAX40000005.cs
    Brief          Form for displaying EAX=0x40000005 CPU information.
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
    public partial class EAX40000005 : Form
    {
        private CPUHelper cpuHelper;

        public EAX40000005()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x40000005: Reserved for Hypervisors - Limits

            textBoxEAX.Text = cpuHelper.GetEAX40000005EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX40000005EBXX();
            textBoxECX.Text = cpuHelper.GetEAX40000005ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX40000005EDXX();

            textBoxMaximumSupportedVirtualProcessors.Text = cpuHelper.GetEAX40000005EAX0_31_MaximumSupportedVirtualProcessorsX();
            textBoxMaximumSupportedLogicalProcessors.Text = cpuHelper.GetEAX40000005EBX0_31_MaximumSupportedLogicalProcessorsX();
            textBoxMaximumSupportedPhysicalInterruptVectorsForRemapping.Text = cpuHelper.GetEAX40000005ECX0_31_MaximumSupportedPhysicalInterruptVectorsForRemappingX();
            textBoxReserved.Text = cpuHelper.GetEAX40000005EDX0_31_ReservedX();

            #endregion
        }
    }
}
