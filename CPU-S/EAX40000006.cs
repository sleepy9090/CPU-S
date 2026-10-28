/*
    File           EAX40000006.cs
    Brief          Form for displaying EAX=0x40000006 CPU information.
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
    public partial class EAX40000006 : Form
    {

        private CPUHelper cpuHelper;

        public EAX40000006()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x40000006: Reserved for Hypervisors - Hardware Features detected and in use

            textBoxEAX.Text = cpuHelper.GetEAX40000006EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX40000006EBXX();
            textBoxECX.Text = cpuHelper.GetEAX40000006ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX40000006EDXX();

            checkBoxAPICOverlayAssist.Checked = cpuHelper.GetEAX40000006EAX0_APICOverlayAssistIsSupportedX();
            checkBoxMSRBitmaps.Checked = cpuHelper.GetEAX40000006EAX1_MSRBitmapsIsSupportedX();
            checkBoxArchitecturalPerformanceCounters.Checked = cpuHelper.GetEAX40000006EAX2_ArchitecturalPerformanceCounterIsSupportedX();
            checkBoxSecondLevelAddressTranslation.Checked = cpuHelper.GetEAX40000006EAX3_SecondLevelAddressTranslationIsSupportedX();
            checkBoxDMARemapping.Checked = cpuHelper.GetEAX40000006EAX4_DMARemappingIsSupportedX();
            checkBoxInterruptRemapping.Checked = cpuHelper.GetEAX40000006EAX5_InterruptRemappingIsSupportedX();
            checkBoxMemoryPatrolScrubber.Checked = cpuHelper.GetEAX40000006EAX6_MemoryPatrolScrubberIsSupportedX();
            checkBoxDMAProtectionIsInUse.Checked = cpuHelper.GetEAX40000006EAX7_DMAProtectionIsInUseIsSupportedX();
            checkBoxHPETIsRequested.Checked = cpuHelper.GetEAX40000006EAX8_HPETIsRequestedIsSupportedX();
            checkBoxSyntheticTimersAreVolatile.Checked = cpuHelper.GetEAX40000006EAX9_SyntheticTimersAreVolatileIsSupportedX();
            textBoxHVLevelOfCurrentGuest.Text = cpuHelper.GetEAX40000006EAX10_13_HVLevelOfCurrentGuestX();
            checkBoxPhysicalDestinationModeRequired.Checked = cpuHelper.GetEAX40000006EAX14_PhysicalDestinationModeRequiredIsSupportedX();
            checkBoxUseVMFUNCForAliasMapSwitch.Checked = cpuHelper.GetEAX40000006EAX15_UseVMFUNCForAliasMapSwitchIsSupportedX();
            checkBoxHardwareMemoryZeroing.Checked = cpuHelper.GetEAX40000006EAX16_HardwareMemoryZeroingIsSupportedX();
            checkBoxUnrestrictedGuest.Checked = cpuHelper.GetEAX40000006EAX17_UnrestrictedGuestIsSupportedX();
            checkBoxResourceAllocation.Checked = cpuHelper.GetEAX40000006EAX18_ResourceAllocationIsSupportedX();
            checkBoxResourceMonitoring.Checked = cpuHelper.GetEAX40000006EAX19_ResourceMonitoringIsSupportedX();
            checkBoxGuestVirtualPMU.Checked = cpuHelper.GetEAX40000006EAX20_GuestVirtualPMUIsSupportedX();
            checkBoxGuestVirtualLBR.Checked = cpuHelper.GetEAX40000006EAX21_GuestVirtualLBRIsSupportedX();
            checkBoxGuestVirtualIPT.Checked = cpuHelper.GetEAX40000006EAX22_GuestVirtualIPTIsSupportedX();
            checkBoxAPICEmulation.Checked = cpuHelper.GetEAX40000006EAX23_APICEmulationIsSupportedX();
            checkBoxACPIWDATTableDetectedAndInUseByHV.Checked = cpuHelper.GetEAX40000006EAX24_ACPIWDATTableDetectedAndInUseByHVIsSupportedX();
            textBoxEAXReserved.Text = cpuHelper.GetEAX40000006EAX25_31_ReservedX();

            textBoxEBXReserved.Text = cpuHelper.GetEAX40000006EBX0_31_ReservedX();

            textBoxECXReserved.Text = cpuHelper.GetEAX40000006ECX0_31_ReservedX();

            textBoxEDXReserved.Text = cpuHelper.GetEAX40000006EDX0_31_ReservedX();

            #endregion
        }
    }
}
