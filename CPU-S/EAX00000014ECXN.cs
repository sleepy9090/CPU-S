/*
    File           EAX14ECX1.cs
    Brief          Form for displaying EAX=0x14, ECX=0x1 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX00000014ECXN : Form
    {

        private CPUHelper cpuHelper;

        public EAX00000014ECXN(int subLeafIndex)
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x000000014, ECX=0x1..n: Processor Trace packet generation information in EAX, EBX and ECX

            textBoxEAX14ECX1EAX.Text = cpuHelper.GetEAX14ECX1EAXX(subLeafIndex);
            textBoxEAX14ECX1EBX.Text = cpuHelper.GetEAX14ECX1EBXX(subLeafIndex);
            textBoxEAX14ECX1ECX.Text = cpuHelper.GetEAX14ECX1ECXX(subLeafIndex);
            textBoxEAX14ECX1EDX.Text = cpuHelper.GetEAX14ECX1EDXX(subLeafIndex);

            textBoxRangecnt.Text = cpuHelper.GetEAX14ECX1EAX0_2_RangecntX(subLeafIndex);
            textBoxReservedEAX3_7.Text = cpuHelper.GetEAX14ECX1EAX3_7_ReservedX(subLeafIndex);
            textBoxTriggerCfgCnt.Text = cpuHelper.GetEAX14ECX1EAX8_10_TriggerConfigCountX(subLeafIndex);
            textBoxReservedEAX11_14.Text = cpuHelper.GetEAX14ECX1EAX11_14_ReservedX(subLeafIndex);
            textBoxReservedEAX15.Text = cpuHelper.GetEAX14ECX1EAX15_ReservedX(subLeafIndex);
            textBoxMtcRate.Text = cpuHelper.GetEAX14ECX1EAX16_31_MtcRateX(subLeafIndex);

            textBoxCycThresholds.Text = cpuHelper.GetEAX14ECX1EBX0_15_CycThresholdsX(subLeafIndex);
            textBoxPsbRate.Text = cpuHelper.GetEAX14ECX1EBX16_31_PsbRateX(subLeafIndex);

            textBoxEnIcnt.Text = cpuHelper.GetEAX14ECX1ECX0_IcntX(subLeafIndex);
            textBoxTriggerPause.Text = cpuHelper.GetEAX14ECX1ECX1_TriggerPauseX(subLeafIndex);
            textBoxReservedECX2.Text = cpuHelper.GetEAX14ECX1ECX2_ReservedX(subLeafIndex);
            textBoxReservedECX3_7.Text = cpuHelper.GetEAX14ECX1ECX3_7_ReservedX(subLeafIndex);
            textBoxReservedECX8_10.Text = cpuHelper.GetEAX14ECX1ECX8_10_ReservedX(subLeafIndex);
            textBoxReservedECX11_14.Text = cpuHelper.GetEAX14ECX1ECX11_14_ReservedX(subLeafIndex);
            textBoxTriggerDrMatch.Text = cpuHelper.GetEAX14ECX1ECX15_TriggerDrMatchX(subLeafIndex);
            textBoxReservedECX16_31.Text = cpuHelper.GetEAX14ECX1ECX16_31_ReservedX(subLeafIndex);

            textBoxEDX0_31Reserved.Text = cpuHelper.GetEAX00000014_ECX1_EDX_0_31_ReservedX(subLeafIndex);

            #endregion
        }
    }
}
