/*
    File           EAX0000000F.cs
    Brief          Form for displaying EAX=0x0000000F CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/21/2026
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
    public partial class EAX0000000FECXN : Form
    {

        private CPUHelper cpuHelper;

        public EAX0000000FECXN(int subLeafIndex)
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x0000000F: RDT-M (QoS monitoring) enumeration, ECX=1..n - 1=L3

            textBoxEAX0000000FEAX.Text = cpuHelper.GetEAX0000000FEAX_ECXX(subLeafIndex);
            textBoxEAX0000000FEBX.Text = cpuHelper.GetEAX0000000FEBX_ECXX(subLeafIndex);
            textBoxEAX0000000FECX.Text = cpuHelper.GetEAX0000000FECX_ECXX(subLeafIndex);
            textBoxEAX0000000FEDX.Text = cpuHelper.GetEAX0000000FEDX_ECXX(subLeafIndex);

            textBoxCounterWidth.Text = cpuHelper.GetEAX0000000F_ECX_EAX_0_7_CounterWidthX(subLeafIndex);
            checkBoxCounterBit61IsOverflowBit.Checked = cpuHelper.GetEAX0000000F_ECX_EAX_8_CounterBit61IsOverflowBitX(subLeafIndex);
            checkBoxNonCPUAgentPresentSupportingIntelRDTCMT.Checked = cpuHelper.GetEAX0000000F_ECX_EAX_9_NonCPUAgentPresentSupportingIntelRDTCMTX(subLeafIndex);
            checkBoxNonCPUAgentPresentSupportingIntelRDTMBM.Checked = cpuHelper.GetEAX0000000F_ECX_EAX_10_NonCPUAgentPresentSupportingIntelRDTMBMX(subLeafIndex);
            textBoxReservedEAX.Text = cpuHelper.GetEAX0000000F_ECX_EAX_11_31_ReservedX(subLeafIndex);

            textBoxConversionFactorFromQM_CTRValueToOccupancyMetricBytes.Text = cpuHelper.GetEAX0000000F_ECX_EBX_0_31_ConversionFactorFromQM_CTRValueToOccupancyMetricBytesX(subLeafIndex);

            textBoxMaxRangeOfRMIDWithinThisResourceType.Text = cpuHelper.GetEAX0000000F_ECX_ECX_0_31_MaxRangeOfRMIDWithinThisResourceTypeX(subLeafIndex);

            checkBoxL3OccupancyMonitoring.Checked = cpuHelper.GetEAX0000000F_ECX_EDX_0_L3OccupancyMonitoringX(subLeafIndex);
            checkBoxL3TotalExternalBandwidthMonitoring.Checked = cpuHelper.GetEAX0000000F_ECX_EDX_1_L3TotalExternalBandwidthMonitoringX(subLeafIndex);
            checkBoxL3LocalExternalBandwidthMonitoring.Checked = cpuHelper.GetEAX0000000F_ECX_EDX_2_L3LocalExternalBandwidthMonitoringX(subLeafIndex);
            textBoxReservedEDX.Text = cpuHelper.GetEAX0000000F_ECX_EDX_3_31_ReservedX(subLeafIndex);

            #endregion
        }
    }
}
