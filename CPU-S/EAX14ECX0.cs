/*
    File           EAX14ECX0.cs
    Brief          Form for displaying EAX=0x14, ECX=0x0 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX14ECX0 : Form
    {

        private CPUHelper cpuHelper;

        public EAX14ECX0()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x14, ECX=0x0: Processor Trace feature bits in EBX and ECX

            string cpuIdEAX14ECX0EAXX = cpuHelper.GetEAX14ECX0EAXX();
            textBoxEAX14ECX0EAX.Text = cpuIdEAX14ECX0EAXX;

            string cpuIdEAX14ECX0EBX = cpuHelper.GetEAX14ECX0EBXX();
            textBoxEAX14ECX0EBX.Text = cpuIdEAX14ECX0EBX;

            string cpuIdEAX14ECX0ECX = cpuHelper.GetEAX14ECX0ECXX();
            textBoxEAX14ECX0ECX.Text = cpuIdEAX14ECX0ECX;

            string cpuIdEAX14ECX0EDX = cpuHelper.GetEAX14ECX0EDXX();
            textBoxEAX14ECX0EDX.Text = cpuIdEAX14ECX0EDX;

            bool cpuIdEAX14ECX0_EBX0_Cr3FilterIsSupported = cpuHelper.GetEAX14ECX0_EBX0_Cr3FilterIsSupportedX();
            checkBoxCR3Filter.Checked = cpuIdEAX14ECX0_EBX0_Cr3FilterIsSupported;

            bool cpuIdEAX14ECX0_EBX1_ConfigurablePSBIsSupported = cpuHelper.GetEAX14ECX0_EBX1_ConfigurablePSBIsSupportedX();
            checkBoxCycAcc.Checked = cpuIdEAX14ECX0_EBX1_ConfigurablePSBIsSupported;

            bool cpuIdEAX14ECX0_EBX2_IPFilterIsSupported = cpuHelper.GetEAX14ECX0_EBX2_IPFilterIsSupportedX();
            checkBoxIpFilter.Checked = cpuIdEAX14ECX0_EBX2_IPFilterIsSupported;

            bool cpuIdEAX14ECX0_EBX3_MtcIsSupported = cpuHelper.GetEAX14ECX0_EBX3_MtcIsSupportedX();
            checkBoxMtc.Checked = cpuIdEAX14ECX0_EBX3_MtcIsSupported;

            bool cpuIdEAX14ECX0_EBX4_PtwriteIsSupported = cpuHelper.GetEAX14ECX0_EBX4_PtwriteIsSupportedX();
            checkBoxPtwrite.Checked = cpuIdEAX14ECX0_EBX4_PtwriteIsSupported;

            bool cpuIdEAX14ECX0_EBX5_PwrEvtTraceIsSupported = cpuHelper.GetEAX14ECX0_EBX5_PwrEvtTraceIsSupportedX();
            checkBoxPwrEvtTrace.Checked = cpuIdEAX14ECX0_EBX5_PwrEvtTraceIsSupported;

            bool cpuIdEAX14ECX0_EBX6_PmiPreserveIsSupported = cpuHelper.GetEAX14ECX0_EBX6_PmiPreserveIsSupportedX();
            checkBoxPmiPreserve.Checked = cpuIdEAX14ECX0_EBX6_PmiPreserveIsSupported;

            bool cpuIdEAX14ECX0_EBX7_EventTraceIsSupported = cpuHelper.GetEAX14ECX0_EBX7_EventTraceIsSupportedX();
            checkBoxEventTrace.Checked = cpuIdEAX14ECX0_EBX7_EventTraceIsSupported;

            bool cpuIdEAX14ECX0_EBX8_TntDisIsSupported = cpuHelper.GetEAX14ECX0_EBX8_TntDisIsSupportedX();
            checkBoxTntDis.Checked = cpuIdEAX14ECX0_EBX8_TntDisIsSupported;

            bool cpuIdEAX14ECX0_EBX9_PtttIsSupported = cpuHelper.GetEAX14ECX0_EBX9_PtttIsSupportedX();
            checkBoxPTTT.Checked = cpuIdEAX14ECX0_EBX9_PtttIsSupported;

            bool cpuIdEAX14ECX0_EBX10_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX10_ReservedIsSupportedX();
            checkBoxReserved10.Checked = cpuIdEAX14ECX0_EBX10_ReservedIsSupported;

            bool cpuIdEAX14ECX0_EBX11_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX11_ReservedIsSupportedX();
            checkBoxReserved11.Checked = cpuIdEAX14ECX0_EBX11_ReservedIsSupported;

            bool cpuIdEAX14ECX0_EBX12_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX12_ReservedIsSupportedX();
            checkBoxReserved12.Checked = cpuIdEAX14ECX0_EBX12_ReservedIsSupported;

            bool cpuIdEAX14ECX0_EBX13_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX13_ReservedIsSupportedX();
            checkBoxReserved13.Checked = cpuIdEAX14ECX0_EBX13_ReservedIsSupported;

            bool cpuIdEAX14ECX0_EBX14_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX14_ReservedIsSupportedX();
            checkBoxReserved14.Checked = cpuIdEAX14ECX0_EBX14_ReservedIsSupported;

            bool cpuIdEAX14ECX0_EBX15_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX15_ReservedIsSupportedX();
            checkBoxReserved15.Checked = cpuIdEAX14ECX0_EBX15_ReservedIsSupported;

            bool cpuIdEAX14ECX0_EBX16_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX16_ReservedIsSupportedX();
            checkBoxReserved16.Checked = cpuIdEAX14ECX0_EBX16_ReservedIsSupported;

            bool cpuIdEAX14ECX0_EBX17_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX17_ReservedIsSupportedX();
            checkBoxReserved17.Checked = cpuIdEAX14ECX0_EBX17_ReservedIsSupported;

            bool cpuIdEAX14ECX0_EBX18_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX18_ReservedIsSupportedX();
            checkBoxReserved18.Checked = cpuIdEAX14ECX0_EBX18_ReservedIsSupported;

            bool cpuIdEAX14ECX0_EBX19_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX19_ReservedIsSupportedX();
            checkBoxReserved19.Checked = cpuIdEAX14ECX0_EBX19_ReservedIsSupported;

            bool cpuIdEAX14ECX0_EBX20_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX20_ReservedIsSupportedX();
            checkBoxReserved20.Checked = cpuIdEAX14ECX0_EBX20_ReservedIsSupported;

            bool cpuIdEAX14ECX0_EBX21_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX21_ReservedIsSupportedX();
            checkBoxReserved21.Checked = cpuIdEAX14ECX0_EBX21_ReservedIsSupported;

            bool cpuIdEAX14ECX0_EBX22_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX22_ReservedIsSupportedX();
            checkBoxReserved22.Checked = cpuIdEAX14ECX0_EBX22_ReservedIsSupported;

            bool cpuIdEAX14ECX0_EBX23_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX23_ReservedIsSupportedX();
            checkBoxReserved23.Checked = cpuIdEAX14ECX0_EBX23_ReservedIsSupported;

            bool cpuIdEAX14ECX0_EBX24_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX24_ReservedIsSupportedX();
            checkBoxReserved24.Checked = cpuIdEAX14ECX0_EBX24_ReservedIsSupported;

            bool cpuIdEAX14ECX0_EBX25_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX25_ReservedIsSupportedX();
            checkBoxReserved25.Checked = cpuIdEAX14ECX0_EBX25_ReservedIsSupported;

            bool cpuIdEAX14ECX0_EBX26_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX26_ReservedIsSupportedX();
            checkBoxReserved26.Checked = cpuIdEAX14ECX0_EBX26_ReservedIsSupported;

            bool cpuIdEAX14ECX0_EBX27_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX27_ReservedIsSupportedX();
            checkBoxReserved27.Checked = cpuIdEAX14ECX0_EBX27_ReservedIsSupported;

            bool cpuIdEAX14ECX0_EBX28_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX28_ReservedIsSupportedX();
            checkBoxReserved28.Checked = cpuIdEAX14ECX0_EBX28_ReservedIsSupported;

            bool cpuIdEAX14ECX0_EBX29_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX29_ReservedIsSupportedX();
            checkBoxReserved29.Checked = cpuIdEAX14ECX0_EBX29_ReservedIsSupported;

            bool cpuIdEAX14ECX0_EBX30_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX30_ReservedIsSupportedX();
            checkBoxReserved30.Checked = cpuIdEAX14ECX0_EBX30_ReservedIsSupported;

            bool cpuIdEAX14ECX0_EBX31_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX31_ReservedIsSupportedX();
            checkBoxReserved31.Checked = cpuIdEAX14ECX0_EBX31_ReservedIsSupported;

            bool cpuIdEAX14ECX0_ECX0_TopaOutIsSupported = cpuHelper.GetEAX14ECX0_ECX0_TopaOutIsSupportedX();
            checkBoxTopaout.Checked = cpuIdEAX14ECX0_ECX0_TopaOutIsSupported;

            bool cpuIdEAX14ECX0_ECX1_MentryIsSupported = cpuHelper.GetEAX14ECX0_ECX1_MentryIsSupportedX();
            checkBoxMentry.Checked = cpuIdEAX14ECX0_ECX1_MentryIsSupported;

            bool cpuIdEAX14ECX0_ECX2_SnglRngOutIsSupported = cpuHelper.GetEAX14ECX0_ECX2_SnglRngOutIsSupportedX();
            checkBoxSnglRngOut.Checked = cpuIdEAX14ECX0_ECX2_SnglRngOutIsSupported;

            bool cpuIdEAX14ECX0_ECX3_TraceTransportSubsystemIsSupported = cpuHelper.GetEAX14ECX0_ECX3_TraceTransportSubsystemIsSupportedX();
            checkBoxTraceTransportSubsystem.Checked = cpuIdEAX14ECX0_ECX3_TraceTransportSubsystemIsSupported;

            bool cpuIdEAX14ECX0_ECX4_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX4_ReservedIsSupportedX();
            checkBoxReservedECX4.Checked = cpuIdEAX14ECX0_ECX4_ReservedIsSupported;

            bool cpuIdEAX14ECX0_ECX5_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX5_ReservedIsSupportedX();
            checkBoxReservedECX5.Checked = cpuIdEAX14ECX0_ECX5_ReservedIsSupported;

            bool cpuIdEAX14ECX0_ECX6_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX6_ReservedIsSupportedX();
            checkBoxReservedECX6.Checked = cpuIdEAX14ECX0_ECX6_ReservedIsSupported;

            bool cpuIdEAX14ECX0_ECX7_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX7_ReservedIsSupportedX();
            checkBoxReservedECX7.Checked = cpuIdEAX14ECX0_ECX7_ReservedIsSupported;

            bool cpuIdEAX14ECX0_ECX8_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX8_ReservedIsSupportedX();
            checkBoxReservedECX8.Checked = cpuIdEAX14ECX0_ECX8_ReservedIsSupported;

            bool cpuIdEAX14ECX0_ECX9_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX9_ReservedIsSupportedX();
            checkBoxReservedECX9.Checked = cpuIdEAX14ECX0_ECX9_ReservedIsSupported;

            bool cpuIdEAX14ECX0_ECX10_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX10_ReservedIsSupportedX();
            checkBoxReservedECX10.Checked = cpuIdEAX14ECX0_ECX10_ReservedIsSupported;

            bool cpuIdEAX14ECX0_ECX11_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX11_ReservedIsSupportedX();
            checkBoxReservedECX11.Checked = cpuIdEAX14ECX0_ECX11_ReservedIsSupported;

            bool cpuIdEAX14ECX0_ECX12_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX12_ReservedIsSupportedX();
            checkBoxReservedECX12.Checked = cpuIdEAX14ECX0_ECX12_ReservedIsSupported;

            bool cpuIdEAX14ECX0_ECX13_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX13_ReservedIsSupportedX();
            checkBoxReservedECX13.Checked = cpuIdEAX14ECX0_ECX13_ReservedIsSupported;

            bool cpuIdEAX14ECX0_ECX14_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX14_ReservedIsSupportedX();
            checkBoxReservedECX14.Checked = cpuIdEAX14ECX0_ECX14_ReservedIsSupported;

            bool cpuIdEAX14ECX0_ECX15_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX15_ReservedIsSupportedX();
            checkBoxReservedECX15.Checked = cpuIdEAX14ECX0_ECX15_ReservedIsSupported;

            bool cpuIdEAX14ECX0_ECX16_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX16_ReservedIsSupportedX();
            checkBoxReservedECX16.Checked = cpuIdEAX14ECX0_ECX16_ReservedIsSupported;

            bool cpuIdEAX14ECX0_ECX17_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX17_ReservedIsSupportedX();
            checkBoxReservedECX17.Checked = cpuIdEAX14ECX0_ECX17_ReservedIsSupported;

            bool cpuIdEAX14ECX0_ECX18_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX18_ReservedIsSupportedX();
            checkBoxReservedECX18.Checked = cpuIdEAX14ECX0_ECX18_ReservedIsSupported;

            bool cpuIdEAX14ECX0_ECX19_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX19_ReservedIsSupportedX();
            checkBoxReservedECX19.Checked = cpuIdEAX14ECX0_ECX19_ReservedIsSupported;

            bool cpuIdEAX14ECX0_ECX20_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX20_ReservedIsSupportedX();
            checkBoxReservedECX20.Checked = cpuIdEAX14ECX0_ECX20_ReservedIsSupported;

            bool cpuIdEAX14ECX0_ECX21_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX21_ReservedIsSupportedX();
            checkBoxReservedECX21.Checked = cpuIdEAX14ECX0_ECX21_ReservedIsSupported;

            bool cpuIdEAX14ECX0_ECX22_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX22_ReservedIsSupportedX();
            checkBoxReservedECX22.Checked = cpuIdEAX14ECX0_ECX22_ReservedIsSupported;

            bool cpuIdEAX14ECX0_ECX23_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX23_ReservedIsSupportedX();
            checkBoxReservedECX23.Checked = cpuIdEAX14ECX0_ECX23_ReservedIsSupported;

            bool cpuIdEAX14ECX0_ECX24_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX24_ReservedIsSupportedX();
            checkBoxReservedECX24.Checked = cpuIdEAX14ECX0_ECX24_ReservedIsSupported;

            bool cpuIdEAX14ECX0_ECX25_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX25_ReservedIsSupportedX();
            checkBoxReservedECX25.Checked = cpuIdEAX14ECX0_ECX25_ReservedIsSupported;

            bool cpuIdEAX14ECX0_ECX26_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX26_ReservedIsSupportedX();
            checkBoxReservedECX26.Checked = cpuIdEAX14ECX0_ECX26_ReservedIsSupported;

            bool cpuIdEAX14ECX0_ECX27_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX27_ReservedIsSupportedX();
            checkBoxReservedECX27.Checked = cpuIdEAX14ECX0_ECX27_ReservedIsSupported;

            bool cpuIdEAX14ECX0_ECX28_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX28_ReservedIsSupportedX();
            checkBoxReservedECX28.Checked = cpuIdEAX14ECX0_ECX28_ReservedIsSupported;

            bool cpuIdEAX14ECX0_ECX29_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX29_ReservedIsSupportedX();
            checkBoxReservedECX29.Checked = cpuIdEAX14ECX0_ECX29_ReservedIsSupported;

            bool cpuIdEAX14ECX0_ECX30_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX30_ReservedIsSupportedX();
            checkBoxReservedECX30.Checked = cpuIdEAX14ECX0_ECX30_ReservedIsSupported;

            bool cpuIdEAX14ECX0_ECX31_IPFormatForTracePacketsThatContainIPPayloadsIsSupported = cpuHelper.GetEAX14ECX0_ECX31_IPFormatForTracePacketsThatContainIPPayloadsIsSupportedX();
            checkBoxLip.Checked = cpuIdEAX14ECX0_ECX31_IPFormatForTracePacketsThatContainIPPayloadsIsSupported;

            #endregion
        }
    }
}
