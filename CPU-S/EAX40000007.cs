/*
    File           EAX40000007.cs
    Brief          Form for displaying EAX=0x40000007 CPU information.
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
    public partial class EAX40000007 : Form
    {
        private CPUHelper cpuHelper;

        public EAX40000007()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x40000007: Reserved for Hypervisors - Hypervisor CPU management features

            textBoxEAX.Text = cpuHelper.GetEAX40000007EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX40000007EBXX();
            textBoxECX.Text = cpuHelper.GetEAX40000007ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX40000007EDXX();

            checkBoxStartLogicalProcessor.Checked = cpuHelper.GetEAX40000007EAX0_StartLogicalProcessorIsSupportedX();
            checkBoxCreateRootVirtualProcessor.Checked = cpuHelper.GetEAX40000007EAX1_CreateRootVirtualProcessorIsSupportedX();
            checkBoxPerformanceCounterSync.Checked = cpuHelper.GetEAX40000007EAX1_PerformanceCounterSyncIsSupportedX();
            textBoxEAXReserved.Text = cpuHelper.GetEAX40000007EAX3_30_ReservedX();
            checkBoxReservedIdentityBit.Checked = cpuHelper.GetEAX40000007EAX31_ReservedIdentityBitIsSupportedX();

            checkBoxProcessorPowerManagement.Checked = cpuHelper.GetEAX40000007EBX0_ProcessorPowerManagementIsSupportedX();
            checkBoxMwaitIdleStates.Checked = cpuHelper.GetEAX40000007EBX1_MwaitIdleStatesIsSupportedX();
            checkBoxLogicalProcessorIdling.Checked = cpuHelper.GetEAX40000007EBX2_LogicalProcessorIdlingIsSupportedX();
            textBoxEBXReserved.Text = cpuHelper.GetEAX40000007EBX3_31_ReservedX();

            checkBoxRemapGuestUncached.Checked = cpuHelper.GetEAX40000007ECX0_RemapGuestUncachedIsSupportedX();
            textBoxECXReserved.Text = cpuHelper.GetEAX40000007ECX1_31_ReservedX();

            textBoxEDXReserved.Text = cpuHelper.GetEAX40000007EDX0_31_ReservedX();

            #endregion
        }
    }
}
