/*
    File           EAX80000021.cs
    Brief          Form for displaying EAX=0x80000021 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           11/02/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX80000021 : Form
    {

        private CPUHelper cpuHelper;

        public EAX80000021()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x80000021: Extended Feature Identification / Feature Information

            textBoxEAX.Text = cpuHelper.GetEAX80000021EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX80000021EBXX();
            textBoxECX.Text = cpuHelper.GetEAX80000021ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX80000021EDXX();

            checkBoxProcessorIgnoresNestedDataBreakpoints.Checked = cpuHelper.GetEAX80000021EAX0_ProcessorIgnoresNestedDataBreakpointsIsSupportedX();
            checkBoxFS_BAS_GS_BAS_And_KERNEL_GS_BAS_WritesAreNonserializing.Checked = cpuHelper.GetEAX80000021EAX1_FS_BAS_GS_BAS_And_KERNEL_GS_BAS_WritesAreNonserializingIsSupportedX();
            checkBoxLFENCE_AlwaysDispatchSerializing.Checked = cpuHelper.GetEAX80000021EAX2_LFENCE_AlwaysDispatchSerializingIsSupportedX();
            checkBoxSMM_PagingConfiguration.Checked = cpuHelper.GetEAX80000021EAX3_SMM_Paging_Configuration_LockIsSupportedX();
            checkBoxTLBSYNC_SFW_NO.Checked = cpuHelper.GetEAX80000021EAX4_TLBSYNC_SFW_NOIsSupportedX();
            checkBoxVERW_ForTSA_Mitigation.Checked = cpuHelper.GetEAX80000021EAX5_VERW_ForTSA_MitigationIsSupportedX();
            checkBoxNullSregSelLoadAlsoClearsSregBasAndSregLim.Checked = cpuHelper.GetEAX80000021EAX6_NullSregSelLoadAlsoClearsSregBasAndSregLimIsSupportedX();
            checkBoxUAIv1_EFER_UAI_V1_E.Checked = cpuHelper.GetEAX80000021EAX7_UAIv1_EFER_UAI_V1_EIsSupportedX();
            checkBoxAutomaticIBRS.Checked = cpuHelper.GetEAX80000021EAX8_AutomaticIBRSIsSupportedX();
            checkBoxSMM_CTL_MSR_NotSupported.Checked = cpuHelper.GetEAX80000021EAX9_SMM_CTL_MSR_NotSupportedIsSupportedX();
            checkBoxFastShortREPSTOSB.Checked = cpuHelper.GetEAX80000021EAX10_FastShortREPSTOSBIsSupportedX();
            checkBoxFastShortREPE_CMPSB.Checked = cpuHelper.GetEAX80000021EAX11_FastShortREPE_CMPSBIsSupportedX();
            checkBoxPerfEvtSel2_PreciseRetire.Checked = cpuHelper.GetEAX80000021EAX12_PerfEvtSel2_PreciseRetireIsSupportedX();
            checkBoxPREFETCH_CTRL_MSR.Checked = cpuHelper.GetEAX80000021EAX13_PREFETCH_CTRL_MSRIsSupportedX();
            checkBoxL2_TLB_Sizes_Are_Encoded_As_Multiples_Of_32.Checked = cpuHelper.GetEAX80000021EAX14_L2_TLB_Sizes_Are_Encoded_As_Multiples_Of_32IsSupportedX();
            checkBoxEnhanced_REP_MOVSB_STOSB.Checked = cpuHelper.GetEAX80000021EAX15_Enhanced_REP_MOVSB_STOSBIsSupportedX();
            checkBox0Fh_01h_7_Opcode_Space_Is_Reserved_For_AMD_Use.Checked = cpuHelper.GetEAX80000021EAX16_0Fh_01h_7_Opcode_Space_Is_Reserved_For_AMD_UseIsSupportedX();
            checkBoxCPUID_At_CPL0_Outside_SMM_May_GP.Checked = cpuHelper.GetEAX80000021EAX17_CPUID_At_CPL0_Outside_SMM_May_GPIsSupportedX();
            checkBoxEPSF_Enhanced_PSF.Checked = cpuHelper.GetEAX80000021EAX18_EPSF_Enhanced_PSFIsSupportedX();
            checkBoxFast_Short_REP_SCASB.Checked = cpuHelper.GetEAX80000021EAX19_Fast_Short_REP_SCASBIsSupportedX();
            checkBoxPREFETCHIT0_PREFETCHIT1.Checked = cpuHelper.GetEAX80000021EAX20_PREFETCHIT0_PREFETCHIT1IsSupportedX();
            checkBoxFP512_Downgraded_To_FP256_Via_HWCR34.Checked = cpuHelper.GetEAX80000021EAX21_FP512_Downgraded_To_FP256_Via_HWCR34IsSupportedX();
            checkBoxWorkload_Class_Extended_Leaf_8000_0027h.Checked = cpuHelper.GetEAX80000021EAX22_Workload_Class_Extended_Leaf_8000_0027hIsSupportedX();
            checkBoxAVX512BMM.Checked = cpuHelper.GetEAX80000021EAX23_AVX512BMM_IsSupportedX();
            checkBoxERAPS.Checked = cpuHelper.GetEAX80000021EAX24_ERAPS_IsSupportedX();
            checkBoxEAX25Reserved.Checked = cpuHelper.GetEAX80000021EAX25_Reserved_IsSupportedX();
            checkBoxUAIv2_EFER_UAI_S_U_E_CR3_LAM_U_57.Checked = cpuHelper.GetEAX80000021EAX26_UAIv2_EFER_UAI_S_U_E_CR3_LAM_U_57_IsSupportedX();
            checkBoxPRED_CMD_SBPB.Checked = cpuHelper.GetEAX80000021EAX27_PRED_CMD_SBPB_IsSupportedX();
            checkBoxPRED_CMD_Ibpb_Clears_All_Branch_Type_Predictions.Checked = cpuHelper.GetEAX80000021EAX28_PRED_CMD_Ibpb_Clears_All_Branch_Type_Predictions_IsSupportedX();
            checkBoxSRSO_NO.Checked = cpuHelper.GetEAX80000021EAX29_SRSO_NO_IsSupportedX();
            checkBoxSRSO_USER_KERNEL_NO.Checked = cpuHelper.GetEAX80000021EAX30_SRSO_USER_KERNEL_NO_IsSupportedX();
            checkBoxSRSO_MSR_FIX.Checked = cpuHelper.GetEAX80000021EAX31_SRSO_MSR_FIX_IsSupportedX();

            textBoxMPBSize.Text = cpuHelper.GetEAX80000021EBX0_15_MPBSizeX();
            textBoxRAPSize.Text = cpuHelper.GetEAX80000021EBX16_23_RAPSizeX();
            textBoxEBX24_31_Reserved.Text = cpuHelper.GetEAX80000021EBX24_31_ReservedX();

            checkBoxECX0Reserved.Checked = cpuHelper.GetEAX80000021ECX0_ReservedIsSupportedX();
            checkBoxTSA_SQ_NO.Checked = cpuHelper.GetEAX80000021ECX1_TSA_SQ_NO_IsSupportedX();
            checkBoxTSA_L1_NO.Checked = cpuHelper.GetEAX80000021ECX2_TSA_L1_NO_IsSupportedX();
            checkBoxThreadPatchLevel.Checked = cpuHelper.GetEAX80000021ECX3_ThreadPatchLevel_IsSupportedX();
            checkBoxAspPatchAuth.Checked = cpuHelper.GetEAX80000021ECX4_AspPatchAuth_IsSupportedX();
            checkBoxOobPatchLoad.Checked = cpuHelper.GetEAX80000021ECX5_OobPatchLoad_IsSupportedX();
            checkBoxECX6Reserved.Checked = cpuHelper.GetEAX80000021ECX6_Reserved_IsSupportedX();
            checkBoxECX7Reserved.Checked = cpuHelper.GetEAX80000021ECX7_Reserved_IsSupportedX();
            checkBoxBTB_CTX_ISOLATION.Checked = cpuHelper.GetEAX80000021ECX8_BTB_CTX_ISOLATION_IsSupportedX();
            checkBoxECX9Reserved.Checked = cpuHelper.GetEAX80000021ECX9_Reserved_IsSupportedX();
            checkBoxSameFpWidthReporting.Checked = cpuHelper.GetEAX80000021ECX10_SameFpWidthReporting_IsSupportedX();
            textBoxECX11_31_Reserved.Text = cpuHelper.GetEAX80000021ECX11_31_ReservedX();

            textBoxEDXReserved.Text = cpuHelper.GetEAX80000021EDX0_31_ReservedX();

            #endregion
        }
    }
}
