/*
    File           EAX00000007ECX1.cs
    Brief          Form for displaying EAX=0x00000007, ECX=0x00000001 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
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

            // ECX

            // EDX


            #endregion
        }
    }
}
