/*
    File           EAX00000007ECX1.cs
    Brief          Form for displaying EAX=0x00000007, ECX=0x00000001 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           11/08/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX00000007ECX1 : Form
    {

        private CPUHelper cpuHelper;

        public EAX00000007ECX1()
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
            }

            #region EAX=0x7, ECX=0x1: Extended Features

            textBoxEAX7ECX1EAX.Text = cpuHelper.GetEAX7ECX1EAXX();
            textBoxEAX7ECX1EBX.Text = cpuHelper.GetEAX7ECX1EBXX();
            textBoxEAX7ECX1ECX.Text = cpuHelper.GetEAX7ECX1ECXX();
            textBoxEAX7ECX1EDX.Text = cpuHelper.GetEAX7ECX1EDXX();

            // EAX
            checkBoxSHA512.Checked = cpuHelper.GetEAX7ECX1_EAX0_SHA512IsSupportedX();
            checkBoxSM3.Checked = cpuHelper.GetEAX7ECX1_EAX1_SM3IsSupportedX();
            checkBoxSM4.Checked = cpuHelper.GetEAX7ECX1_EAX2_SM4IsSupportedX();
            checkBoxRAO_INT.Checked = cpuHelper.GetEAX7ECX1_EAX3_RAO_INTIsSupportedX();
            checkBoxAVX_VNNI.Checked = cpuHelper.GetEAX7ECX1_EAX4_AVX_VNNIIsSupportedX();
            checkBoxAVX512BF16.Checked = cpuHelper.GetEAX7ECX1_EAX5_AVX512_BF16IsSupportedX();
            checkBoxLASS.Checked = cpuHelper.GetEAX7ECX1_EAX6_LASSIsSupportedX();
            checkBoxCMPCCXADD.Checked = cpuHelper.GetEAX7ECX1_EAX7_CMPCCXADDIsSupportedX();
            checkBoxARCH_PERFMON.Checked = cpuHelper.GetEAX7ECX1_EAX8_ARCHPERFMONEXTIsSupportedX();
            checkBoxDEDUP.Checked = cpuHelper.GetEAX7ECX1_EAX9_DEDUPIsSupportedX();
            checkBoxFAST_REP_MOVSB.Checked = cpuHelper.GetEAX7ECX1_EAX10_FZRMIsSupportedX();
            checkBoxFAST_REP_STOSB.Checked = cpuHelper.GetEAX7ECX1_EAX11_FSRSIsSupportedX();
            checkBoxFAST_REP_CMPSB.Checked = cpuHelper.GetEAX7ECX1_EAX12_RSRCSIsSupportedX();
            checkBoxEAX13Reserved.Checked = cpuHelper.GetEAX7ECX1_EAX13_ReservedIsSupportedX();
            checkBoxEAX14Reserved.Checked = cpuHelper.GetEAX7ECX1_EAX14_ReservedIsSupportedX();
            checkBoxEAX15Reserved.Checked = cpuHelper.GetEAX7ECX1_EAX15_ReservedIsSupportedX();
            checkBoxEAX16Reserved.Checked = cpuHelper.GetEAX7ECX1_EAX16_ReservedIsSupportedX();
            checkBoxFRED.Checked = cpuHelper.GetEAX7ECX1_EAX17_FREDIsSupportedX();
            checkBoxLKGS.Checked = cpuHelper.GetEAX7ECX1_EAX18_LKGSIsSupportedX();
            checkBoxWRMSRNS.Checked = cpuHelper.GetEAX7ECX1_EAX19_WRMSRNSIsSupportedX();
            checkBoxNMI_SOURCE.Checked = cpuHelper.GetEAX7ECX1_EAX20_NMI_SRCIsSupportedX();
            checkBoxAMX_FP16.Checked = cpuHelper.GetEAX7ECX1_EAX21_AMX_FP16IsSupportedX();
            checkBoxHRESET.Checked = cpuHelper.GetEAX7ECX1_EAX22_HRESETIsSupportedX();
            checkBoxAVX_IFMA.Checked = cpuHelper.GetEAX7ECX1_EAX23_AVX_IFMAIsSupportedX();
            checkBoxEAX24Reserved.Checked = cpuHelper.GetEAX7ECX1_EAX24_ReservedIsSupportedX();
            checkBoxEAX25Reserved.Checked = cpuHelper.GetEAX7ECX1_EAX25_ReservedIsSupportedX();
            checkBoxLAM.Checked = cpuHelper.GetEAX7ECX1_EAX26_LAMIsSupportedX();
            checkBoxMSRLIST.Checked = cpuHelper.GetEAX7ECX1_EAX27_MSRListIsSupportedX();
            checkBoxEAX28Reserved.Checked = cpuHelper.GetEAX7ECX1_EAX28_ReservedIsSupportedX();
            checkBoxEAX29Reserved.Checked = cpuHelper.GetEAX7ECX1_EAX29_ReservedIsSupportedX();
            checkBoxINVD_DIS.Checked = cpuHelper.GetEAX7ECX1_EAX30_INVD_DISABLE_POST_BIOS_DONEIsSupportedX();
            checkBoxMOVRS.Checked = cpuHelper.GetEAX7ECX1_EAX31_MOVRSIsSupportedX();

            // EBX
            checkBoxPPIN.Checked = cpuHelper.GetEAX7ECX1_EBX0_PPINIsSupportedX();
            checkBoxPBNDKB.Checked = cpuHelper.GetEAX7ECX1_EBX1_PBNDKBIsSupportedX();
            checkBoxEBX2Reserved.Checked = cpuHelper.GetEAX7ECX1_EBX2_ReservedIsSupportedX();
            checkBoxNO_LCMV.Checked = cpuHelper.GetEAX7ECX1_EBX3_CPUID­MAXVAL_­LIM_RMVIsSupportedX();
            checkBoxEBX4Reserved.Checked = cpuHelper.GetEAX7ECX1_EBX4_ReservedIsSupportedX();
            checkBoxEBX5Reserved.Checked = cpuHelper.GetEAX7ECX1_EBX5_ReservedIsSupportedX();
            checkBoxEBX6Reserved.Checked = cpuHelper.GetEAX7ECX1_EBX6_ReservedIsSupportedX();
            checkBoxEBX7Reserved.Checked = cpuHelper.GetEAX7ECX1_EBX7_ReservedIsSupportedX();
            checkBoxEBX8Reserved.Checked = cpuHelper.GetEAX7ECX1_EBX8_ReservedIsSupportedX();
            checkBoxEBX9Reserved.Checked = cpuHelper.GetEAX7ECX1_EBX9_ReservedIsSupportedX();
            checkBoxEBX10Reserved.Checked = cpuHelper.GetEAX7ECX1_EBX10_ReservedIsSupportedX();
            checkBoxEBX11Reserved.Checked = cpuHelper.GetEAX7ECX1_EBX11_ReservedIsSupportedX();
            checkBoxEBX12Reserved.Checked = cpuHelper.GetEAX7ECX1_EBX12_ReservedIsSupportedX();
            checkBoxEBX13Reserved.Checked = cpuHelper.GetEAX7ECX1_EBX13_ReservedIsSupportedX();
            checkBoxEBX14Reserved.Checked = cpuHelper.GetEAX7ECX1_EBX14_ReservedIsSupportedX();
            checkBoxEBX15Reserved.Checked = cpuHelper.GetEAX7ECX1_EBX15_ReservedIsSupportedX();
            checkBoxEBX16Reserved.Checked = cpuHelper.GetEAX7ECX1_EBX16_ReservedIsSupportedX();
            checkBoxEBX17Reserved.Checked = cpuHelper.GetEAX7ECX1_EBX17_ReservedIsSupportedX();
            checkBoxEBX18Reserved.Checked = cpuHelper.GetEAX7ECX1_EBX18_ReservedIsSupportedX();
            checkBoxEBX19Reserved.Checked = cpuHelper.GetEAX7ECX1_EBX19_ReservedIsSupportedX();
            checkBoxEBX20Reserved.Checked = cpuHelper.GetEAX7ECX1_EBX20_ReservedIsSupportedX();
            checkBoxEBX21Reserved.Checked = cpuHelper.GetEAX7ECX1_EBX21_ReservedIsSupportedX();
            checkBoxEBX22Reserved.Checked = cpuHelper.GetEAX7ECX1_EBX22_ReservedIsSupportedX();
            checkBoxEBX23Reserved.Checked = cpuHelper.GetEAX7ECX1_EBX23_ReservedIsSupportedX();
            checkBoxEBX24Reserved.Checked = cpuHelper.GetEAX7ECX1_EBX24_ReservedIsSupportedX();
            checkBoxEBX25Reserved.Checked = cpuHelper.GetEAX7ECX1_EBX25_ReservedIsSupportedX();
            checkBoxEBX26Reserved.Checked = cpuHelper.GetEAX7ECX1_EBX26_ReservedIsSupportedX();
            checkBoxEBX27Reserved.Checked = cpuHelper.GetEAX7ECX1_EBX27_ReservedIsSupportedX();
            checkBoxMPSADBW_512.Checked = cpuHelper.GetEAX7ECX1_EBX28_Reserved_MPSADBW_512IsSupportedX();
            checkBoxEBX29Reserved.Checked = cpuHelper.GetEAX7ECX1_EBX29_ReservedIsSupportedX();
            checkBoxUnconfirmedAVX512_RAO_FP.Checked = cpuHelper.GetEAX7ECX1_EBX30_Reserved_AVX512_RAO_FPIsSupportedX();
            checkBoxUnconfirmedAVX_RAO_FP.Checked = cpuHelper.GetEAX7ECX1_EBX31_Reserved_AVX512_RAO_FPIsSupportedX();

            // ECX
            checkBoxRDT_M_ASYM.Checked = cpuHelper.GetEAX7ECX1_ECX0_RDT_M_ASYMIsSupportedX();
            checkBoxRDT_A_ASYM.Checked = cpuHelper.GetEAX7ECX1_ECX1_RDT_M_­ASYMIsSupportedX();
            checkBoxX86S.Checked = cpuHelper.GetEAX7ECX1_ECX2_Reserved_LEGACY_REDUCED_ISAIsSupportedX();
            checkBoxECX3Reserved.Checked = cpuHelper.GetEAX7ECX1_ECX3_ReservedIsSupportedX();
            checkBoxSIPI64.Checked = cpuHelper.GetEAX7ECX1_ECX4_SIPI64IsSupportedX();
            checkBoxMSR_IMM.Checked = cpuHelper.GetEAX7ECX1_ECX5_MSR_IMMIsSupportedX();
            checkBoxECX6Reserved.Checked = cpuHelper.GetEAX7ECX1_ECX6_ReservedIsSupportedX();
            checkBoxEDX7Unknown.Checked = cpuHelper.GetEAX7ECX1_ECX7_ReservedIsSupportedX();
            checkBoxECX8Reserved.Checked = cpuHelper.GetEAX7ECX1_ECX8_ReservedIsSupportedX();
            checkBoxEDX9Unknown.Checked = cpuHelper.GetEAX7ECX1_ECX9_ReservedIsSupportedX();
            checkBoxEDX10Unknown.Checked = cpuHelper.GetEAX7ECX1_ECX10_ReservedIsSupportedX();
            checkBoxACE.Checked = cpuHelper.GetEAX7ECX1_ECX11_ReservedIsSupportedX();
            checkBoxECX12Reserved.Checked = cpuHelper.GetEAX7ECX1_ECX12_ReservedIsSupportedX();
            checkBoxECX13Reserved.Checked = cpuHelper.GetEAX7ECX1_ECX13_ReservedIsSupportedX();
            checkBoxECX14Reserved.Checked = cpuHelper.GetEAX7ECX1_ECX14_ReservedIsSupportedX();
            checkBoxECX15Reserved.Checked = cpuHelper.GetEAX7ECX1_ECX15_ReservedIsSupportedX();
            checkBoxECX16Reserved.Checked = cpuHelper.GetEAX7ECX1_ECX16_ReservedIsSupportedX();
            checkBoxECX17Reserved.Checked = cpuHelper.GetEAX7ECX1_ECX17_ReservedIsSupportedX();
            checkBoxECX18Reserved.Checked = cpuHelper.GetEAX7ECX1_ECX18_ReservedIsSupportedX();
            checkBoxECX19Reserved.Checked = cpuHelper.GetEAX7ECX1_ECX19_ReservedIsSupportedX();
            checkBoxECX20Reserved.Checked = cpuHelper.GetEAX7ECX1_ECX20_ReservedIsSupportedX();
            checkBoxECX21Reserved.Checked = cpuHelper.GetEAX7ECX1_ECX21_ReservedIsSupportedX();
            checkBoxECX22Reserved.Checked = cpuHelper.GetEAX7ECX1_ECX22_ReservedIsSupportedX();
            checkBoxECX23Reserved.Checked = cpuHelper.GetEAX7ECX1_ECX23_ReservedIsSupportedX();
            checkBoxECX24Reserved.Checked = cpuHelper.GetEAX7ECX1_ECX24_ReservedIsSupportedX();
            checkBoxECX25Reserved.Checked = cpuHelper.GetEAX7ECX1_ECX25_ReservedIsSupportedX();
            checkBoxECX26Reserved.Checked = cpuHelper.GetEAX7ECX1_ECX26_ReservedIsSupportedX();
            checkBoxECX27Reserved.Checked = cpuHelper.GetEAX7ECX1_ECX27_ReservedIsSupportedX();
            checkBoxECX28Reserved.Checked = cpuHelper.GetEAX7ECX1_ECX28_ReservedIsSupportedX();
            checkBoxECX29Reserved.Checked = cpuHelper.GetEAX7ECX1_ECX29_ReservedIsSupportedX();
            checkBoxECX30Reserved.Checked = cpuHelper.GetEAX7ECX1_ECX30_ReservedIsSupportedX();
            checkBoxECX31Reserved.Checked = cpuHelper.GetEAX7ECX1_ECX31_ReservedIsSupportedX();

            // EDX
            checkBoxEDX0Reserved.Checked = cpuHelper.GetEAX7ECX1_EDX0_ReservedIsSupportedX();
            checkBoxUnconfirmedAVX512_VNNI_FP16.Checked = cpuHelper.GetEAX7ECX1_EDX1_Reserved_AVX512_VNNI_FP16IsSupportedX();
            checkBoxUnconfirmedAVX512_VNNI_INT8.Checked = cpuHelper.GetEAX7ECX1_EDX2_Reserved_AVX512_VNNI_INT8IsSupportedX();
            checkBoxUnconfirmedAVX512_NE_CONVERT.Checked = cpuHelper.GetEAX7ECX1_EDX3_Reserved_AVX512_NE_CONVERTIsSupportedX();
            checkBoxAVX_VNNI_INT8.Checked = cpuHelper.GetEAX7ECX1_EDX4_AVX_VNNI_INT8IsSupportedX();
            checkBoxAVX_NE_CONVERT.Checked = cpuHelper.GetEAX7ECX1_EDX5_AVX_NE_CONVERTIsSupportedX();
            checkBoxEDX6Reserved.Checked = cpuHelper.GetEAX7ECX1_EDX6_ReservedIsSupportedX();
            checkBoxEDX7Reserved.Checked = cpuHelper.GetEAX7ECX1_EDX7_ReservedIsSupportedX();
            checkBoxAMX_COMPLEX.Checked = cpuHelper.GetEAX7ECX1_EDX8_AMX_COMPLEXIsSupportedX();
            checkBoxEDX9Reserved.Checked = cpuHelper.GetEAX7ECX1_EDX9_ReservedIsSupportedX();
            checkBoxAVX_VNNI_INT16.Checked = cpuHelper.GetEAX7ECX1_EDX10_AVX_VNNI_INT16IsSupportedX();
            checkBoxUnconfirmedAVX512_VNNI_INT16.Checked = cpuHelper.GetEAX7ECX1_EDX11_Reserved_AVX512_VNNI_INT16IsSupportedX();
            checkBoxEDX12Reserved.Checked = cpuHelper.GetEAX7ECX1_EDX12_ReservedIsSupportedX();
            checkBoxUTMR.Checked = cpuHelper.GetEAX7ECX1_EDX13_UTMRIsSupportedX();
            checkBoxPREFETCHI.Checked = cpuHelper.GetEAX7ECX1_EDX14_PREFETCHIIsSupportedX();
            checkBoxUSER_MSR.Checked = cpuHelper.GetEAX7ECX1_EDX15_USER_MSRIsSupportedX();
            checkBoxUnconfirmedAVX512_BF16_NE.Checked = cpuHelper.GetEAX7ECX1_EDX16_Reserved_AVX512_BF16_NEIsSupportedX();
            checkBoxUIRET_UIF.Checked = cpuHelper.GetEAX7ECX1_EDX17_UIRET_UIF_FROM_RFLAGSIsSupportedX();
            checkBoxCET_SSS.Checked = cpuHelper.GetEAX7ECX1_EDX18_CET_SSSIsSupportedX();
            checkBoxAVX10.Checked = cpuHelper.GetEAX7ECX1_EDX19_AVX10IsSupportedX();
            checkBoxEDX20Reserved.Checked = cpuHelper.GetEAX7ECX1_EDX20_ReservedIsSupportedX();
            checkBoxAPX_F.Checked = cpuHelper.GetEAX7ECX1_EDX21_APX_FIsSupportedX();
            checkBoxSEC_TEE_ATT.Checked = cpuHelper.GetEAX7ECX1_EDX22_SEC_TEE_ATTESTATIONIsSupportedX();
            checkBoxMWAIT.Checked = cpuHelper.GetEAX7ECX1_EDX23_MWAITIsSupportedX();
            checkBoxSLSM.Checked = cpuHelper.GetEAX7ECX1_EDX24_SLSMIsSupportedX();
            checkBoxEDX25Reserved.Checked = cpuHelper.GetEAX7ECX1_EDX25_ReservedIsSupportedX();
            checkBoxEDX26Reserved.Checked = cpuHelper.GetEAX7ECX1_EDX26_ReservedIsSupportedX();
            checkBoxEDX27Reserved.Checked = cpuHelper.GetEAX7ECX1_EDX27_ReservedIsSupportedX();
            checkBoxEDX28Reserved.Checked = cpuHelper.GetEAX7ECX1_EDX28_ReservedIsSupportedX();
            checkBoxEDX29Reserved.Checked = cpuHelper.GetEAX7ECX1_EDX29_ReservedIsSupportedX();
            checkBoxEDX30Reserved.Checked = cpuHelper.GetEAX7ECX1_EDX30_ReservedIsSupportedX();
            checkBoxEDX31Reserved.Checked = cpuHelper.GetEAX7ECX1_EDX31_ReservedIsSupportedX();

            #endregion
        }
    }
}
