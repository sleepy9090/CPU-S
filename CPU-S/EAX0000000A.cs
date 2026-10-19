/*
    File           EAX0000000A.cs
    Brief          Form for displaying EAX=0x0000000A CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/18/2026
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
    public partial class EAX0000000A : Form
    {

        private CPUHelper cpuHelper;

        public EAX0000000A()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX = 0x0000000A: Architectural perf mon information

            textBoxEAX0000000AEAX.Text = cpuHelper.GetEAX0000000AEAXX();
            textBoxEAX0000000AEBX.Text = cpuHelper.GetEAX0000000AEBXX();
            textBoxEAX0000000AECX.Text = cpuHelper.GetEAX0000000AECXX();
            textBoxEAX0000000AEDX.Text = cpuHelper.GetEAX0000000AEDXX();

            // EAX
            textBoxRevision.Text = cpuHelper.GetEAX0000000AEAX0_7_RevisionX();
            textBoxNumberOfPerfMonCountersPerLogicalProcessor.Text = cpuHelper.GetEAX0000000AEAX8_15_NumberOfPerfMonCountersPerLogicalProcessorX();
            textBoxBitWidthOfPerfMonCounter.Text = cpuHelper.GetEAX0000000AEAX16_23_BitWidthOfPerfMonCounterX();
            textBoxLengthOfEBXBitVector.Text = cpuHelper.GetEAX0000000AEAX24_31_LengthOfEBXBitVectorX();

            // EBX
            checkBoxCoreCyclesEventUnavailable.Checked = cpuHelper.GetEAX0000000A_EBX0_CoreCyclesEventUnavailableX();
            checkBoxInstructionsRetiredEventUnavailable.Checked = cpuHelper.GetEAX0000000A_EBX1_InstructionsRetiredEventUnavailableX();
            checkBoxReferenceCyclesEventUnavailable.Checked = cpuHelper.GetEAX0000000A_EBX2_ReferenceCyclesEventUnavailableX();
            checkBoxLastLevelCacheReferencesEventUnavailable.Checked = cpuHelper.GetEAX0000000A_EBX3_LastLevelCacheReferencesEventUnavailableX();
            checkBoxLastLevelCacheMissesEventUnavailable.Checked = cpuHelper.GetEAX0000000A_EBX4_LastLevelCacheMissesEventUnavailableX();
            checkBoxBranchInstructionsRetiredEventUnavailable.Checked = cpuHelper.GetEAX0000000A_EBX5_BranchInstructionsRetiredEventUnavailableX();
            checkBoxBranchMispredictsRetiredEventUnavailable.Checked = cpuHelper.GetEAX0000000A_EBX6_BranchMispredictsRetiredEventUnavailableX();
            checkBoxTopdownSlotsEventUnavailable.Checked = cpuHelper.GetEAX0000000A_EBX7_TopdownSlotsEventUnavailableX();
            checkBoxTopdownBackendBoundUnavailable.Checked = cpuHelper.GetEAX0000000A_EBX8_TopdownBackendBoundUnavailableX();
            checkBoxTopdownBadSpeculationUnavailable.Checked = cpuHelper.GetEAX0000000A_EBX9_TopdownBadSpeculationUnavailableX();
            checkBoxTopdownFrontendBoundUnavailable.Checked = cpuHelper.GetEAX0000000A_EBX10_TopdownFrontendBoundUnavailableX();
            checkBoxTopdownRetiringUnavailable.Checked = cpuHelper.GetEAX0000000A_EBX11_TopdownRetiringUnavailableX();
            checkBoxLBRInsertsUnavailable.Checked = cpuHelper.GetEAX0000000A_EBX12_LBRInsertsUnavailableX();
            checkBoxEBX13_Reserved.Checked = cpuHelper.GetEAX0000000A_EBX13_ReservedX();
            checkBoxEBX14_Reserved.Checked = cpuHelper.GetEAX0000000A_EBX14_ReservedX();
            checkBoxEBX15_Reserved.Checked = cpuHelper.GetEAX0000000A_EBX15_ReservedX();
            checkBoxEBX16_Reserved.Checked = cpuHelper.GetEAX0000000A_EBX16_ReservedX();
            checkBoxEBX17_Reserved.Checked = cpuHelper.GetEAX0000000A_EBX17_ReservedX();
            checkBoxEBX18_Reserved.Checked = cpuHelper.GetEAX0000000A_EBX18_ReservedX();
            checkBoxEBX19_Reserved.Checked = cpuHelper.GetEAX0000000A_EBX19_ReservedX();
            checkBoxEBX20_Reserved.Checked = cpuHelper.GetEAX0000000A_EBX20_ReservedX();
            checkBoxEBX21_Reserved.Checked = cpuHelper.GetEAX0000000A_EBX21_ReservedX();
            checkBoxEBX22_Reserved.Checked = cpuHelper.GetEAX0000000A_EBX22_ReservedX();
            checkBoxEBX23_Reserved.Checked = cpuHelper.GetEAX0000000A_EBX23_ReservedX();
            checkBoxEBX24_Reserved.Checked = cpuHelper.GetEAX0000000A_EBX24_ReservedX();
            checkBoxEBX25_Reserved.Checked = cpuHelper.GetEAX0000000A_EBX25_ReservedX();
            checkBoxEBX26_Reserved.Checked = cpuHelper.GetEAX0000000A_EBX26_ReservedX();
            checkBoxEBX27_Reserved.Checked = cpuHelper.GetEAX0000000A_EBX27_ReservedX();
            checkBoxEBX28_Reserved.Checked = cpuHelper.GetEAX0000000A_EBX28_ReservedX();
            checkBoxEBX29_Reserved.Checked = cpuHelper.GetEAX0000000A_EBX29_ReservedX();
            checkBoxEBX30_Reserved.Checked = cpuHelper.GetEAX0000000A_EBX30_ReservedX();
            checkBoxEBX31_Reserved.Checked = cpuHelper.GetEAX0000000A_EBX31_ReservedX();

            // ECX
            textBoxFixedCountersBitMask.Text = cpuHelper.GetEAX0000000AECX0_31_FixedCountersBitMaskX();

            // EDX
            textBoxNumberOfFixedFunctionPerfMonCounters.Text = cpuHelper.GetEAX0000000AEDX0_4_NumberOfFixedFunctionPerfMonCountersX();
            textBoxBitWidthOfFixedFunctionPerfMonCounters.Text = cpuHelper.GetEAX0000000AEDX5_12_BitWidthOfFixedFunctionPerfMonCountersX();
            textBoxEDX13_14_Reserved.Text = cpuHelper.GetEAX0000000AEDX13_14_ReservedX();
            textBoxAnyThreadModeDeprecation.Text = cpuHelper.GetEAX0000000AEDX15_AnyThreadModeDeprecationX();
            textBoxNumberOfTopdownMicroarchitectureAnalysisTMASlotsPerCycle.Text = cpuHelper.GetEAX0000000AEDX16_19_NumberOfTopdownMicroarchitectureAnalysisTMASlotsPerCycleX();
            textBoxEDX20_31_Reserved.Text = cpuHelper.GetEAX0000000AEDX20_31_ReservedX();


            #endregion
        }
    }
}
