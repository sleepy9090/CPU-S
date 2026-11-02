/*
    File           EAX00000012.cs
    Brief          Form for displaying EAX=0x00000012 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/26/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX00000012 : Form
    {

        private CPUHelper cpuHelper;

        public EAX00000012()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            foreach (TextBox textBox in this.GetAllControlsOfType<TextBox>())
            {
                textBox.ReadOnly = true;
            }

            #region EAX=0x00000012: SGX Capabilities

            textBoxEAX00000012EAX.Text = cpuHelper.GetEAX00000012EAXX();
            textBoxEAX00000012EBX.Text = cpuHelper.GetEAX00000012EBXX();
            textBoxEAX00000012ECX.Text = cpuHelper.GetEAX00000012ECXX();
            textBoxEAX00000012EDX.Text = cpuHelper.GetEAX00000012EDXX();

            checkBoxSGX1.Checked = cpuHelper.GetEAX00000012EAX0_SGX1IsSupportedX();
            checkBoxSGX2.Checked = cpuHelper.GetEAX00000012EAX1_SGX2IsSupportedX();
            textBoxEAX_2_4_Reserved.Text = cpuHelper.GetEAX00000012EAX2_4_ReservedX();
            checkBoxENCLVAndEINCVIRTCHILD_EDECVIRTCHILD_ESETCONTEXT.Checked = cpuHelper.GetEAX00000012EAX5_ENCLV_And_EINCVIRTCHILD_EDECVIRTCHILD_ESETCONTEXTIsSupportedX();
            checkBoxETRACKC_ERDINFO_ELDBC_ELDUC.Checked = cpuHelper.GetEAX00000012EAX6_ETRACKC_ERDINFO_ELDBC_ELDUCIsSupportedX();
            checkBoxENCLU_EVERIFYREPORT2.Checked = cpuHelper.GetEAX00000012EAX7_ENCLU_EVERIFYREPORT2IsSupportedX();
            textBoxEAX_8_9_Reserved.Text = cpuHelper.GetEAX00000012EAX8_9_ReservedX();
            checkBoxENCLS_EUPDATESVN.Checked = cpuHelper.GetEAX00000012EAX10_ENCLS_EUPDATESVNIsSupportedX();
            checkBoxENCLU_EDECCSSA.Checked = cpuHelper.GetEAX00000012EAX11_ENCLU_EDECCSSAIsSupportedX();
            checkBoxENCLU_EGETKEY256_And_ENCLU_EREPORT2_And_SGXLEPUBKEYHASH_4_5_And_SGXLECONFIG_MSRs.Checked = cpuHelper.GetEAX00000012EAX12_ENCLU_EGETKEY256_And_ENCLU_EREPORT2_And_SGXLEPUBKEYHASH_4_5_And_SGXLECONFIG_MSRsIsSupportedX();
            textBoxEAX_13_31_Reserved.Text = cpuHelper.GetEAX00000012EAX13_31_ReservedX();
            textBoxBitVectorOfSupportedExtendedFeatures.Text = cpuHelper.GetEAX00000012EBX_0_31_BitVectorOfSupportedExtendedFeaturesX();
            textBoxECXReserved.Text = cpuHelper.GetEAX00000012ECX_0_31_ReservedX();
            textBoxMaximumEnclaveSizeIn2ToTheNBytesWhenNotInPM64.Text = cpuHelper.GetEAX00000012EDX0_7_MaximumEnclaveSizeIn2ToTheNBytesWhenNotInPM64X();
            textBoxMaximumEnclaveSizeIn2ToTheNBytesWhenInPM64.Text = cpuHelper.GetEAX00000012EDX8_15_MaximumEnclaveSizeIn2ToTheNBytesWhenInPM64X();
            textBoxEDX_16_31_Reserved.Text = cpuHelper.GetEAX00000012EDX16_31_ReservedX();

            #endregion
        }
    }
}
