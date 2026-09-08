/*
    File           EAX80000008.cs
    Brief          Form for displaying EAX=0x80000008 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX80000008 : Form
    {

        private CPUHelper cpuHelper;

        public EAX80000008()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x80000008: Virtual and Physical Address Sizes

            string cpuIdEAX80000008EAX = cpuHelper.GetEAX80000008EAXX();
            textBoxEAX80000008EAX.Text = cpuIdEAX80000008EAX;

            string cpuIdEAX80000008EBX = cpuHelper.GetEAX80000008EBXX();
            textBoxEAX80000008EBX.Text = cpuIdEAX80000008EBX;

            string cpuIdEAX80000008ECX = cpuHelper.GetEAX80000008ECXX();
            textBoxEAX80000008ECX.Text = cpuIdEAX80000008ECX;

            string cpuIdEAX80000008EDX = cpuHelper.GetEAX80000008EDXX();
            textBoxEAX80000008EDX.Text = cpuIdEAX80000008EDX;

            string cpuIdEAX80000008EAX0_7_NumberOfPhysicalAddressBits = cpuHelper.GetEAX80000008EAX0_7_NumberOfPhysicalAddressBitsX();
            textBoxNumberOfPhysicalAddressBits.Text = cpuIdEAX80000008EAX0_7_NumberOfPhysicalAddressBits;

            string cpuIdEAX80000008EAX8_15_NumberOfLinearAddressBits = cpuHelper.GetEAX80000008EAX8_15_NumberOfLinearAddressBitsX();
            textBoxNumberOfLinearAddressBits.Text = cpuIdEAX80000008EAX8_15_NumberOfLinearAddressBits;

            string cpuIdEAX80000008EAX16_23_GuestPhysicalAddressSize = cpuHelper.GetEAX80000008EAX16_23_GuestPhysicalAddressSizeX();
            textBoxGuestPhysicalAddressSize.Text = cpuIdEAX80000008EAX16_23_GuestPhysicalAddressSize;

            string cpuIdEAX80000008EAX24_31_Reserved = cpuHelper.GetEAX80000008EAX24_31_ReservedX();
            textBoxEAXReserved24_31.Text = cpuIdEAX80000008EAX24_31_Reserved;

            string cpuIdEAX80000008ECX0_7_NumberOfPhysicalThreadsInProcessorMinus1 = cpuHelper.GetEAX80000008ECX0_7_NumberOfPhysicalThreadsInProcessorMinus1X();
            textBoxNumOfPhyThreadsInProcMinusOne.Text = cpuIdEAX80000008ECX0_7_NumberOfPhysicalThreadsInProcessorMinus1;

            string cpuIdEAX80000008ECX8_11_Reserved = cpuHelper.GetEAX80000008ECX8_11_ReservedX();
            textBoxECXReserved8_11.Text = cpuIdEAX80000008ECX8_11_Reserved;

            string cpuIdEAX80000008ECX12_15_APIC_IDSize = cpuHelper.GetEAX80000008ECX12_15_APIC_IDSizeX();
            textBoxApicIdSize.Text = cpuIdEAX80000008ECX12_15_APIC_IDSize;

            string cpuIdEAX80000008ECX16_17_PerformanceTimestampCounterSize = cpuHelper.GetEAX80000008ECX16_17_PerformanceTimestampCounterSizeX();
            textBoxPerfTimestampCounterSize.Text = cpuIdEAX80000008ECX16_17_PerformanceTimestampCounterSize;

            string cpuIdEAX80000008ECX18_31_Reserverd = cpuHelper.GetEAX80000008ECX18_31_ReserverdX();
            textBoxECXReserved18_31.Text = cpuIdEAX80000008ECX18_31_Reserverd;

            string cpuIdEAX80000008EDX0_15_MaximumPageCountForINVLPGBInstruction = cpuHelper.GetEAX80000008EDX0_15_MaximumPageCountForINVLPGBInstructionX();
            textBoxMaxPageCountForInvlpgbInstruction.Text = cpuIdEAX80000008EDX0_15_MaximumPageCountForINVLPGBInstruction;

            string cpuIdEAX80000008EDX16_31_MaximumECXValueForRDPRUInstruction = cpuHelper.GetEAX80000008EDX16_31_MaximumECXValueForRDPRUInstructionX();
            textBoxMaxECXValRecByRdpruInst.Text = cpuIdEAX80000008EDX16_31_MaximumECXValueForRDPRUInstruction;

            bool cpuIdEAX80000008EBX0_CLZERO_IsSupported = cpuHelper.GetEAX80000008EBX0_CLZERO_IsSupportedX();
            checkBoxCLZERO.Checked = cpuIdEAX80000008EBX0_CLZERO_IsSupported;

            bool cpuIdEAX80000008EBX1_RetiredInstr_IsSupported = cpuHelper.GetEAX80000008EBX1_RetiredInstr_IsSupportedX();
            checkBoxRETIREDINSTR.Checked = cpuIdEAX80000008EBX1_RetiredInstr_IsSupported;

            bool cpuIdEAX80000008EBX2_XRSTOR_FP_ERR_IsSupported = cpuHelper.GetEAX80000008EBX2_XRSTOR_FP_ERR_IsSupportedX();
            checkBoxXSTORFPERR.Checked = cpuIdEAX80000008EBX2_XRSTOR_FP_ERR_IsSupported;

            bool cpuIdEAX80000008EBX3_INVLPGB_TLBSYNC_IsSupported = cpuHelper.GetEAX80000008EBX3_INVLPGB_TLBSYNC_IsSupportedX();
            checkBoxINVLPGB.Checked = cpuIdEAX80000008EBX3_INVLPGB_TLBSYNC_IsSupported;

            bool cpuIdEAX80000008EBX4_RDPRU_IsSupported = cpuHelper.GetEAX80000008EBX4_RDPRU_IsSupportedX();
            checkBoxRDPRU.Checked = cpuIdEAX80000008EBX4_RDPRU_IsSupported;

            bool cpuIdEAX80000008EBX5_XOTEXT_IsSupported = cpuHelper.GetEAX80000008EBX5_XOTEXT_IsSupportedX();
            checkBoxXOTEXT.Checked = cpuIdEAX80000008EBX5_XOTEXT_IsSupported;

            bool cpuIdEAX80000008EBX6_MBE_IsSupported = cpuHelper.GetEAX80000008EBX6_MBE_IsSupportedX();
            checkBoxMBE.Checked = cpuIdEAX80000008EBX6_MBE_IsSupported;

            bool cpuIdEAX80000008EBX7_ReservedIsSupported = cpuHelper.GetEAX80000008EBX7_ReservedIsSupportedX();
            checkBoxEBXReserved7.Checked = cpuIdEAX80000008EBX7_ReservedIsSupported;

            bool cpuIdEAX80000008EBX8_MCOMMIT_IsSupported = cpuHelper.GetEAX80000008EBX8_MCOMMIT_IsSupportedX();
            checkBoxMCOMMIT.Checked = cpuIdEAX80000008EBX8_MCOMMIT_IsSupported;

            bool cpuIdEAX80000008EBX9_WBNOINVD_IsSupported = cpuHelper.GetEAX80000008EBX9_WBNOINVD_IsSupportedX();
            checkBoxWBNOINVD.Checked = cpuIdEAX80000008EBX9_WBNOINVD_IsSupported;

            bool cpuIdEAX80000008EBX10_LBR_EXT_V1_IsSupported = cpuHelper.GetEAX80000008EBX10_LBR_EXT_V1_IsSupportedX();
            checkBoxLBREXTV1.Checked = cpuIdEAX80000008EBX10_LBR_EXT_V1_IsSupported;

            bool cpuIdEAX80000008EBX11_ReservedIsSupported = cpuHelper.GetEAX80000008EBX11_ReservedIsSupportedX();
            checkBoxEBXReserved11.Checked = cpuIdEAX80000008EBX11_ReservedIsSupported;

            bool cpuIdEAX80000008EBX12_IBPB_IsSupported = cpuHelper.GetEAX80000008EBX12_IBPB_IsSupportedX();
            checkBoxIBPB.Checked = cpuIdEAX80000008EBX12_IBPB_IsSupported;

            bool cpuIdEAX80000008EBX13_WBINVD_INT_IsSupported = cpuHelper.GetEAX80000008EBX13_WBINVD_INT_IsSupportedX();
            checkBoxWBINVDINT.Checked = cpuIdEAX80000008EBX13_WBINVD_INT_IsSupported;

            bool cpuIdEAX80000008EBX14_IBRS_IsSupported = cpuHelper.GetEAX80000008EBX14_IBRS_IsSupportedX();
            checkBoxIBRS.Checked = cpuIdEAX80000008EBX14_IBRS_IsSupported;

            bool cpuIdEAX80000008EBX15_STIBP_IsSupported = cpuHelper.GetEAX80000008EBX15_STIBP_IsSupportedX();
            checkBoxSTIBP.Checked = cpuIdEAX80000008EBX15_STIBP_IsSupported;

            bool cpuIdEAX80000008EBX16_IBRS_ALWAYS_ON_IsSupported = cpuHelper.GetEAX80000008EBX16_IBRS_ALWAYS_ON_IsSupportedX();
            checkBoxIBRSALWAYSON.Checked = cpuIdEAX80000008EBX16_IBRS_ALWAYS_ON_IsSupported;

            bool cpuIdEAX80000008EBX17_STIBP_ALWAYS_ON_IsSupported = cpuHelper.GetEAX80000008EBX17_STIBP_ALWAYS_ON_IsSupportedX();
            checkBoxSTIBPALWAYSON.Checked = cpuIdEAX80000008EBX17_STIBP_ALWAYS_ON_IsSupported;

            bool cpuIdEAX80000008EBX18_IBRS_PREFERRED_IsSupported = cpuHelper.GetEAX80000008EBX18_IBRS_PREFERRED_IsSupportedX();
            checkBoxIBRSPREFERRED.Checked = cpuIdEAX80000008EBX18_IBRS_PREFERRED_IsSupported;

            bool cpuIdEAX80000008EBX19_IBRS_SAME_MODE_PROTECTION_IsSupported = cpuHelper.GetEAX80000008EBX19_IBRS_SAME_MODE_PROTECTION_IsSupportedX();
            checkBoxIBRSSAMEMODEPROTECTION.Checked = cpuIdEAX80000008EBX19_IBRS_SAME_MODE_PROTECTION_IsSupported;

            bool cpuIdEAX80000008EBX20_NO_EFER_LMSLE_IsSupported = cpuHelper.GetEAX80000008EBX20_NO_EFER_LMSLE_IsSupportedX();
            checkBoxNOEFERLMSLE.Checked = cpuIdEAX80000008EBX20_NO_EFER_LMSLE_IsSupported;

            bool cpuIdEAX80000008EBX21_INVLPGB_NESTED_IsSupported = cpuHelper.GetEAX80000008EBX21_INVLPGB_NESTED_IsSupportedX();
            checkBoxINVLPGBNESTED.Checked = cpuIdEAX80000008EBX21_INVLPGB_NESTED_IsSupported;

            bool cpuIdEAX80000008EBX22_LBR_TSX_IsSupported = cpuHelper.GetEAX80000008EBX22_LBR_TSX_IsSupportedX();
            checkBoxLBRTSX.Checked = cpuIdEAX80000008EBX22_LBR_TSX_IsSupported;

            bool cpuIdEAX80000008EBX23_PPIN_IsSupported = cpuHelper.GetEAX80000008EBX23_PPIN_IsSupportedX();
            checkBoxPPIN.Checked = cpuIdEAX80000008EBX23_PPIN_IsSupported;

            bool cpuIdEAX80000008EBX24_SSBD_IsSupported = cpuHelper.GetEAX80000008EBX24_SSBD_IsSupportedX();
            checkBoxSSBD.Checked = cpuIdEAX80000008EBX24_SSBD_IsSupported;

            bool cpuIdEAX80000008EBX25_SSBD_LEGACY_IsSupported = cpuHelper.GetEAX80000008EBX25_SSBD_LEGACY_IsSupportedX();
            checkBoxSSBDLEGACY.Checked = cpuIdEAX80000008EBX25_SSBD_LEGACY_IsSupported;

            bool cpuIdEAX80000008EBX26_SSBD_NO_IsSupported = cpuHelper.GetEAX80000008EBX26_SSBD_NO_IsSupportedX();
            checkBoxSSBDNO.Checked = cpuIdEAX80000008EBX26_SSBD_NO_IsSupported;

            bool cpuIdEAX80000008EBX27_CPPC_IsSupported = cpuHelper.GetEAX80000008EBX27_CPPC_IsSupportedX();
            checkBoxCPPC.Checked = cpuIdEAX80000008EBX27_CPPC_IsSupported;

            bool cpuIdEAX80000008EBX28_PSFD_IsSupported = cpuHelper.GetEAX80000008EBX28_PSFD_IsSupportedX();
            checkBoxPSFD.Checked = cpuIdEAX80000008EBX28_PSFD_IsSupported;

            bool cpuIdEAX80000008EBX29_BTC_NO_IsSupported = cpuHelper.GetEAX80000008EBX29_BTC_NO_IsSupportedX();
            checkBoxBTCNO.Checked = cpuIdEAX80000008EBX29_BTC_NO_IsSupported;

            bool cpuIdEAX80000008EBX30_IBPB_RET_IsSupported = cpuHelper.GetEAX80000008EBX30_IBPB_RET_IsSupportedX();
            checkBoxIBPBRET.Checked = cpuIdEAX80000008EBX30_IBPB_RET_IsSupported;

            bool cpuIdEAX80000008EBX31_BRANCH_SAMPLING_IsSupported = cpuHelper.GetEAX80000008EBX31_BRANCH_SAMPLING_IsSupportedX();
            checkBoxBRANCHSAMPLING.Checked = cpuIdEAX80000008EBX31_BRANCH_SAMPLING_IsSupported;

            #endregion
        }
    }
}
