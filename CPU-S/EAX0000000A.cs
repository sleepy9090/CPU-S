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
