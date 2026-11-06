/*
    File           EAX40000004.cs
    Brief          Form for displaying EAX=0x40000004 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           09/22/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Drawing;
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX40000004 : Form
    {
        private CPUHelper cpuHelper;

        public EAX40000004()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            foreach (TextBox textBox in this.GetAllControlsOfType<TextBox>())
            {
                textBox.ReadOnly = true;
            }

            foreach (CheckBox checkBox in this.GetAllControlsOfType<CheckBox>())
            {
                checkBox.AutoCheck = false;
                //checkBox.ForeColor = Color.Gray;
                //checkBox.UseVisualStyleBackColor = true;
                //checkBox.BackColor = Color.LightGray;
            }

            #region EAX=0x40000004: Reserved for Hypervisors - Recommendations

            textBoxEAX.Text = cpuHelper.GetEAX40000004EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX40000004EBXX();
            textBoxECX.Text = cpuHelper.GetEAX40000004ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX40000004EDXX();

            checkBoxHypercallForAddressSpaceSwitch.Checked = cpuHelper.GetEAX40000004EAX0_HypercallForAddressSpaceSwitchIsSupportedX();
            checkBoxHypercallForLocalTLBFlush.Checked = cpuHelper.GetEAX40000004EAX1_HypercallForLocalTLBFlushIsSupportedX();
            checkBoxHypercallForRemoteTLBFlush.Checked = cpuHelper.GetEAX40000004EAX2_HypercallForRemoteTLBFlushIsSupportedX();
            checkBoxMSRsforAPIC_EOI_ICR_TPR.Checked = cpuHelper.GetEAX40000004EAX3_MSRsForAPICEOIICRTPRIsSupportedX();
            checkBoxMSRForSystemReset.Checked = cpuHelper.GetEAX40000004EAX4_MSRForSystemResetIsSupportedX();
            checkBoxRelaxedTimingDisableWatchdogs.Checked = cpuHelper.GetEAX40000004EAX5_RelaxedTimingDisableWatchdogsIsSupportedX();
            checkBoxDMARemapping.Checked = cpuHelper.GetEAX40000004EAX6_DMARemappingIsSupportedX();
            checkBoxInterruptRemapping.Checked = cpuHelper.GetEAX40000004EAX7_InterruptRemappingIsSupportedX();
            checkBoxReserved_was_x2APIC_MSRs.Checked = cpuHelper.GetEAX40000004EAX8_ReservedWasX2APICMSRsIsSupportedX();
            checkBoxDeprecateAutoEOI.Checked = cpuHelper.GetEAX40000004EAX9_DeprecateAutoEOIIsSupportedX();
            checkBoxHypercallForSyntheticClusterIpi.Checked = cpuHelper.GetEAX40000004EAX10_HypercallForSyntheticClusterIpiIsSupportedX();
            checkBoxNewerExProcessorMasksInterface.Checked = cpuHelper.GetEAX40000004EAX11_NewerExProcessorMasksInterfaceIsSupportedX();
            checkBoxHVIsNestedWithinAHyperVPartition.Checked = cpuHelper.GetEAX40000004EAX12_HVIsNestedWithinAHyperVPartitionIsSupportedX();
            checkBoxUseINTForMBECSystemCalls.Checked = cpuHelper.GetEAX40000004EAX13_UseINTForMBECSystemCallsIsSupportedX();
            checkBoxUseNestedHVUsingEnlightenedVMCSInterfaceSee4000_000Ah.Checked = cpuHelper.GetEAX40000004EAX14_UseNestedHVUsingEnlightenedVMCSInterfaceIsSupportedX();
            checkBoxUseSyncedTimelineConsumeRootQueryPerformanceCounterBias.Checked = cpuHelper.GetEAX40000004EAX15_UseSyncedTimelineConsumeRootQueryPerformanceCounterBiasIsSupportedX();
            checkBoxEAX16Reserved.Checked = cpuHelper.GetEAX40000004EAX16_ReservedIsSupportedX();
            checkBoxUseCR4PGEToggleToFlushEntireTLBWhenFasterThanHypercall.Checked = cpuHelper.GetEAX40000004EAX17_UseCR4PGEToggleToFlushEntireTLBIsSupportedX();
            checkBoxNoNonArchitecturalCoreSharingAvoidSTIBPOverhead.Checked = cpuHelper.GetEAX40000004EAX18_NoNonArchitecturalCoreSharingIsSupportedX();
            checkBoxEAXReserved19.Checked = cpuHelper.GetEAX40000004EAX19_ReservedIsSupportedX();
            checkBoxEAXReserved20.Checked = cpuHelper.GetEAX40000004EAX20_ReservedIsSupportedX();
            checkBoxEAXReserved21.Checked = cpuHelper.GetEAX40000004EAX21_ReservedIsSupportedX();
            checkBoxEAXReserved22.Checked = cpuHelper.GetEAX40000004EAX22_ReservedIsSupportedX();
            checkBoxEAXReserved23.Checked = cpuHelper.GetEAX40000004EAX23_ReservedIsSupportedX();
            checkBoxEAXReserved24.Checked = cpuHelper.GetEAX40000004EAX24_ReservedIsSupportedX();
            checkBoxEAXReserved25.Checked = cpuHelper.GetEAX40000004EAX25_ReservedIsSupportedX();
            checkBoxEAXReserved26.Checked = cpuHelper.GetEAX40000004EAX26_ReservedIsSupportedX();
            checkBoxEAXReserved27.Checked = cpuHelper.GetEAX40000004EAX27_ReservedIsSupportedX();
            checkBoxEAXReserved28.Checked = cpuHelper.GetEAX40000004EAX28_ReservedIsSupportedX();
            checkBoxEAXReserved29.Checked = cpuHelper.GetEAX40000004EAX29_ReservedIsSupportedX();
            checkBoxEAXReserved30.Checked = cpuHelper.GetEAX40000004EAX30_ReservedIsSupportedX();
            checkBoxEAXReserved31.Checked = cpuHelper.GetEAX40000004EAX31_ReservedIsSupportedX();

            textBoxRecommendedSpinlockFailureRetries.Text = cpuHelper.GetEAX40000004EBX0_31_RecommendedSpinlockFailureRetriesX();

            textBoxImplementedPhysicalAddressBits.Text = cpuHelper.GetEAX40000004ECX0_6_ImplementedPhysicalAddressBitsX();
            textBoxECX7_31_Reserved.Text = cpuHelper.GetEAX40000004ECX7_31_ReservedX();

            textBoxEDXReserved.Text = cpuHelper.GetEAX40000004EDX0_31_ReservedX();

            #endregion
        }
    }
}
