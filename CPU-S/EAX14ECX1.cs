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
    public partial class EAX14ECX1 : Form
    {

        private CPUHelper cpuHelper;

        public EAX14ECX1()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x14, ECX=0x1: Processor Trace packet generation information in EAX, EBX and ECX

            string cpuIdEAX14ECX1EAXX = cpuHelper.GetEAX14ECX1EAXX();
            textBoxEAX14ECX1EAX.Text = cpuIdEAX14ECX1EAXX;

            string cpuIdEAX14ECX1EBX = cpuHelper.GetEAX14ECX1EBXX();
            textBoxEAX14ECX1EBX.Text = cpuIdEAX14ECX1EBX;

            string cpuIdEAX14ECX1ECX = cpuHelper.GetEAX14ECX1ECXX();
            textBoxEAX14ECX1ECX.Text = cpuIdEAX14ECX1ECX;

            string cpuIdEAX14ECX1EDX = cpuHelper.GetEAX14ECX1EDXX();
            textBoxEAX14ECX1EDX.Text = cpuIdEAX14ECX1EDX;

            string cpuIdEAX14ECX1EAX0_2_Rangecnt = cpuHelper.GetEAX14ECX1EAX0_2_RangecntX();
            textBoxRangecnt.Text = cpuIdEAX14ECX1EAX0_2_Rangecnt;

            string cpuIdEAX14ECX1EAX3_7_Reserved = cpuHelper.GetEAX14ECX1EAX3_7_ReservedX();
            textBoxReservedEAX3_7.Text = cpuIdEAX14ECX1EAX3_7_Reserved;

            string cpuIdEAX14ECX1EAX8_10_TriggerConfigCount = cpuHelper.GetEAX14ECX1EAX8_10_TriggerConfigCountX();
            textBoxTriggerCfgCnt.Text = cpuIdEAX14ECX1EAX8_10_TriggerConfigCount;

            string cpuIdEAX14ECX1EAX11_14_Reserved = cpuHelper.GetEAX14ECX1EAX11_14_ReservedX();
            textBoxReservedEAX11_14.Text = cpuIdEAX14ECX1EAX11_14_Reserved;

            string cpuIdEAX14ECX1EAX15_Reserved = cpuHelper.GetEAX14ECX1EAX15_ReservedX();
            textBoxReservedEAX15.Text = cpuIdEAX14ECX1EAX15_Reserved;

            string cpuIdEAX14ECX1EAX16_31_MtcRate = cpuHelper.GetEAX14ECX1EAX16_31_MtcRateX();
            textBoxMtcRate.Text = cpuIdEAX14ECX1EAX16_31_MtcRate;

            string cpuIdEAX14ECX1EBX0_15_CycThresholds = cpuHelper.GetEAX14ECX1EBX0_15_CycThresholdsX();
            textBoxCycThresholds.Text = cpuIdEAX14ECX1EBX0_15_CycThresholds;

            string cpuIdEAX14ECX1EBX16_31_PsbRate = cpuHelper.GetEAX14ECX1EBX16_31_PsbRateX();
            textBoxPsbRate.Text = cpuIdEAX14ECX1EBX16_31_PsbRate;

            string cpuIdEAX14ECX1ECX0_Icnt = cpuHelper.GetEAX14ECX1ECX0_IcntX();
            textBoxEnIcnt.Text = cpuIdEAX14ECX1ECX0_Icnt;

            string cpuIdEAX14ECX1ECX1_TriggerPause = cpuHelper.GetEAX14ECX1ECX1_TriggerPauseX();
            textBoxTriggerPause.Text = cpuIdEAX14ECX1ECX1_TriggerPause;

            string cpuIdEAX14ECX1ECX2_Reserved = cpuHelper.GetEAX14ECX1ECX2_ReservedX();
            textBoxReservedECX2.Text = cpuIdEAX14ECX1ECX2_Reserved;

            string cpuIdEAX14ECX1ECX3_7_Reserved = cpuHelper.GetEAX14ECX1ECX3_7_ReservedX();
            textBoxReservedECX3_7.Text = cpuIdEAX14ECX1ECX3_7_Reserved;

            string cpuIdEAX14ECX1ECX8_10_Reserved = cpuHelper.GetEAX14ECX1ECX8_10_ReservedX();
            textBoxReservedECX8_10.Text = cpuIdEAX14ECX1ECX8_10_Reserved;

            string cpuIdEAX14ECX1ECX11_14_Reserved = cpuHelper.GetEAX14ECX1ECX11_14_ReservedX();
            textBoxReservedECX11_14.Text = cpuIdEAX14ECX1ECX11_14_Reserved;

            string cpuIdEAX14ECX1ECX15_TriggerDrMatch = cpuHelper.GetEAX14ECX1ECX15_TriggerDrMatchX();
            textBoxTriggerDrMatch.Text = cpuIdEAX14ECX1ECX15_TriggerDrMatch;

            string cpuIdEAX14ECX1ECX16_31_Reserved = cpuHelper.GetEAX14ECX1ECX16_31_ReservedX();
            textBoxReservedECX16_31.Text = cpuIdEAX14ECX1ECX16_31_Reserved;

            #endregion
        }
    }
}
