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
    public partial class EAX7ECX0 : Form
    {

        private CPUHelper cpuHelper;

        public EAX7ECX0()
        {
            InitializeComponent();

            /*
            foreach (Control control in groupBoxEBX.Controls)
            {
                if (control is CheckBox)
                {
                    (CheckBox)control.AutoCheck = false;
                }
            }
            */

            cpuHelper = new CPUHelper();

            #region EAX=0x7, ECX=0x0: Extended Features

            string cpuIdEAX7ECX0EAX = cpuHelper.GetEAX7ECX0EAXX();
            textBoxEAX7ECX0EAX.Text = cpuIdEAX7ECX0EAX;

            string cpuIdEAX7ECX0EBX = cpuHelper.GetEAX7ECX0EBXX();
            textBoxEAX7ECX0EBX.Text = cpuIdEAX7ECX0EBX;

            string cpuIdEAX7ECX0ECX = cpuHelper.GetEAX7ECX0ECXX();
            textBoxEAX7ECX0ECX.Text = cpuIdEAX7ECX0ECX;

            string cpuIdEAX7ECX0EDX = cpuHelper.GetEAX7ECX0EDXX();
            textBoxEAX7ECX0EDX.Text = cpuIdEAX7ECX0EDX;

            #region EAX

            string maxSubLeaf = cpuHelper.BinaryStringToDecimalString(cpuHelper.GetEAX7ECX0EAXX());
            textBoxMaxSubLeaf.Text = maxSubLeaf;

            #endregion

            #region EBX

            bool cpuIdEAX7ECX0_FSGSBaseIsSupported = cpuHelper.GetEAX7ECX0_EBX0_FSGSBaseIsSupportedX();
            checkBoxFSGSBASE.Checked = cpuIdEAX7ECX0_FSGSBaseIsSupported;

            bool cpuIdEAX7ECX0_TSCAdjustIsSupported = cpuHelper.GetEAX7ECX0_EBX1_TSCAdjustIsSupportedX();
            checkBoxTSCADJUST.Checked = cpuIdEAX7ECX0_TSCAdjustIsSupported;

            bool cpuIdEAX7ECX0_SGXIsSupported = cpuHelper.GetEAX7ECX0_EBX2_SGXIsSupportedX();
            checkBoxSGX.Checked = cpuIdEAX7ECX0_SGXIsSupported;

            bool cpuIdEAX7ECX0_BMI1IsSupported = cpuHelper.GetEAX7ECX0_EBX3_BMI1IsSupportedX();
            checkBoxBMI1.Checked = cpuIdEAX7ECX0_BMI1IsSupported;

            bool cpuIdEAX7ECX0_HLEIsSupported = cpuHelper.GetEAX7ECX0_EBX4_HLEIsSupportedX();
            checkBoxHLE.Checked = cpuIdEAX7ECX0_HLEIsSupported;

            bool cpuIdEAX7ECX0_AVX2IsSupported = cpuHelper.GetEAX7ECX0_EBX5_AVX2IsSupportedX();
            checkBoxAVX2.Checked = cpuIdEAX7ECX0_AVX2IsSupported;

            bool cpuIdEAX7ECX0_FDPExcptnOnlyIsSupported = cpuHelper.GetEAX7ECX0_EBX6_FDPExcptnOnlyIsSupportedX();
            checkBoxFDPEXCPTNONLY.Checked = cpuIdEAX7ECX0_FDPExcptnOnlyIsSupported;

            bool cpuIdEAX7ECX0_SMEPIsSupported = cpuHelper.GetEAX7ECX0_EBX7_SMEPIsSupportedX();
            checkBoxSMEP.Checked = cpuIdEAX7ECX0_SMEPIsSupported;

            bool cpuIdEAX7ECX0_BMI2IsSupported = cpuHelper.GetEAX7ECX0_EBX8_BMI2IsSupportedX();
            checkBoxBMI2.Checked = cpuIdEAX7ECX0_BMI2IsSupported;

            bool cpuIdEAX7ECX0_ERMSIsSupported = cpuHelper.GetEAX7ECX0_EBX9_ERMSIsSupportedX();
            checkBoxERMS.Checked = cpuIdEAX7ECX0_ERMSIsSupported;

            bool cpuIdEAX7ECX0_INVPCIDIsSupported = cpuHelper.GetEAX7ECX0_EBX10_INVPCIDIsSupportedX();
            checkBoxINVPCID.Checked = cpuIdEAX7ECX0_INVPCIDIsSupported;

            bool cpuIdEAX7ECX0_RTMIsSupported = cpuHelper.GetEAX7ECX0_EBX11_RTMIsSupportedX();
            checkBoxRTM.Checked = cpuIdEAX7ECX0_RTMIsSupported;

            bool cpuIdEAX7ECX0_RDTMIsSupported = cpuHelper.GetEAX7ECX0_EBX12_RDTMIsSupportedX();
            checkBoxRDTMPQM.Checked = cpuIdEAX7ECX0_RDTMIsSupported;

            bool cpuIdEAX7ECX0_FCSFDSDEPRECATIONIsSupported = cpuHelper.GetEAX7ECX0_EBX13_FCSFDSDeprecationIsSupportedX();
            checkBoxFCSFDSDEPRECATION.Checked = cpuIdEAX7ECX0_FCSFDSDEPRECATIONIsSupported;

            bool cpuIdEAX7ECX0_MPXIsSupported = cpuHelper.GetEAX7ECX0_EBX14_MPXIsSupportedX();
            checkBoxMPX.Checked = cpuIdEAX7ECX0_MPXIsSupported;

            bool cpuIdEAX7ECX0_RDTAIsSupported = cpuHelper.GetEAX7ECX0_EBX15_RDTAIsSupportedX();
            checkBoxRDTAPQE.Checked = cpuIdEAX7ECX0_RDTAIsSupported;

            bool cpuIdEAX7ECX0_AVX512FIsSupported = cpuHelper.GetEAX7ECX0_EBX16_AVX512FIsSupportedX();
            checkBoxAVX512F.Checked = cpuIdEAX7ECX0_AVX512FIsSupported;

            bool cpuIdEAX7ECX0_AVX512DQIsSupported = cpuHelper.GetEAX7ECX0_EBX17_AVX512DQIsSupportedX();
            checkBoxAVX512DQ.Checked = cpuIdEAX7ECX0_AVX512DQIsSupported;

            bool cpuIdEAX7ECX0_RDSEEDIsSupported = cpuHelper.GetEAX7ECX0_EBX18_RDSEEDIsSupportedX();
            checkBoxRDSEED.Checked = cpuIdEAX7ECX0_RDSEEDIsSupported;

            bool cpuIdEAX7ECX0_ADXIsSupported = cpuHelper.GetEAX7ECX0_EBX19_ADXIsSupportedX();
            checkBoxADX.Checked = cpuIdEAX7ECX0_ADXIsSupported;

            bool cpuIdEAX7ECX0_SMAPIsSupported = cpuHelper.GetEAX7ECX0_EBX20_SMAPIsSupportedX();
            checkBoxSMAP.Checked = cpuIdEAX7ECX0_SMAPIsSupported;

            bool cpuIdEAX7ECX0_AVX512IFMAIsSupported = cpuHelper.GetEAX7ECX0_EBX21_AVX512IFMAIsSupportedX();
            checkBoxAVX512IFMA.Checked = cpuIdEAX7ECX0_AVX512IFMAIsSupported;

            bool cpuIdEAX7ECX0_PCOMMITIsSupported = cpuHelper.GetEAX7ECX0_EBX22_PCOMMITIsSupportedX();
            checkBoxPCOMMIT.Checked = cpuIdEAX7ECX0_PCOMMITIsSupported;

            bool cpuIdEAX7ECX0_CLFLUSHOPTIsSupported = cpuHelper.GetEAX7ECX0_EBX23_CLFLUSHOPTIsSupportedX();
            checkBoxCLFLUSHOPT.Checked = cpuIdEAX7ECX0_CLFLUSHOPTIsSupported;

            bool cpuIdEAX7ECX0_CLWBIsSupported = cpuHelper.GetEAX7ECX0_EBX24_CLWBIsSupportedX();
            checkBoxCLWB.Checked = cpuIdEAX7ECX0_CLWBIsSupported;

            bool cpuIdEAX7ECX0_PTIsSupported = cpuHelper.GetEAX7ECX0_EBX25_PTIsSupportedX();
            checkBoxPT.Checked = cpuIdEAX7ECX0_PTIsSupported;

            bool cpuIdEAX7ECX0_AVX512PFIsSupported = cpuHelper.GetEAX7ECX0_EBX26_AVX512PFIsSupportedX();
            checkBoxAVX512PF.Checked = cpuIdEAX7ECX0_AVX512PFIsSupported;

            bool cpuIdEAX7ECX0_AVX512ERIsSupported = cpuHelper.GetEAX7ECX0_EBX27_AVX512ERIsSupportedX();
            checkBoxAVX512ER.Checked = cpuIdEAX7ECX0_AVX512ERIsSupported;

            bool cpuIdEAX7ECX0_AVX512CDIsSupported = cpuHelper.GetEAX7ECX0_EBX28_AVX512CDIsSupportedX();
            checkBoxAVX512CD.Checked = cpuIdEAX7ECX0_AVX512CDIsSupported;

            bool cpuIdEAX7ECX0_SHAIsSupported = cpuHelper.GetEAX7ECX0_EBX29_SHAIsSupportedX();
            checkBoxSHA.Checked = cpuIdEAX7ECX0_SHAIsSupported;

            bool cpuIdEAX7ECX0_AVX512BWIsSupported = cpuHelper.GetEAX7ECX0_EBX30_AVX512BWIsSupportedX();
            checkBoxAVX512BW.Checked = cpuIdEAX7ECX0_AVX512BWIsSupported;

            bool cpuIdEAX7ECX0_AVX512VLIsSupported = cpuHelper.GetEAX7ECX0_EBX31_AVX512VLIsSupportedX();
            checkBoxAVX512VL.Checked = cpuIdEAX7ECX0_AVX512VLIsSupported;

            #endregion

            #region ECX

            bool cpuIdEAX7ECX0_PREFETCHWT1IsSupported = cpuHelper.GetEAX7ECX0_ECX0_PREFETCHWT1IsSupportedX();
            checkBoxPREFETCHWT1.Checked = cpuIdEAX7ECX0_PREFETCHWT1IsSupported;

            bool cpuIdEAX7ECX0_AVX512VBMIIsSupported = cpuHelper.GetEAX7ECX0_ECX1_AVX512VBMIIsSupportedX();
            checkBoxAVX512VBMI.Checked = cpuIdEAX7ECX0_AVX512VBMIIsSupported;

            bool cpuIdEAX7ECX0_UMIPIsSupported = cpuHelper.GetEAX7ECX0_ECX2_UMIPIsSupportedX();
            checkBoxUMIP.Checked = cpuIdEAX7ECX0_UMIPIsSupported;

            bool cpuIdEAX7ECX0_PKUIsSupported = cpuHelper.GetEAX7ECX0_ECX3_PKUIsSupportedX();
            checkBoxPKU.Checked = cpuIdEAX7ECX0_PKUIsSupported;

            bool cpuIdEAX7ECX0_OSPKEIsSupported = cpuHelper.GetEAX7ECX0_ECX4_OSPKEIsSupportedX();
            checkBoxOSPKE.Checked = cpuIdEAX7ECX0_OSPKEIsSupported;

            bool cpuIdEAX7ECX0_WAITPKGIsSupported = cpuHelper.GetEAX7ECX0_ECX5_WAITPKGIsSupportedX();
            checkBoxWAITPKG.Checked = cpuIdEAX7ECX0_WAITPKGIsSupported;

            bool cpuIdEAX7ECX0_AVX512VBMI2IsSupported = cpuHelper.GetEAX7ECX0_ECX6_AVX512VBMI2IsSupportedX();
            checkBoxAVX512VBMI2.Checked = cpuIdEAX7ECX0_AVX512VBMI2IsSupported;

            bool cpuIdEAX7ECX0_CETSSIsSupported = cpuHelper.GetEAX7ECX0_ECX7_CETSSIsSupportedX();
            checkBoxCETSSSHSTK.Checked = cpuIdEAX7ECX0_CETSSIsSupported;

            bool cpuIdEAX7ECX0_GFNIIsSupported = cpuHelper.GetEAX7ECX0_ECX8_GFNIIsSupportedX();
            checkBoxGFNI.Checked = cpuIdEAX7ECX0_GFNIIsSupported;

            bool cpuIdEAX7ECX0_VAESIsSupported = cpuHelper.GetEAX7ECX0_ECX9_VAESIsSupportedX();
            checkBoxVAES.Checked = cpuIdEAX7ECX0_VAESIsSupported;

            bool cpuIdEAX7ECX0_VPCLMULQDQIsSupported = cpuHelper.GetEAX7ECX0_ECX10_VPCLMULQDQIsSupportedX();
            checkBoxVPCLMULQDQ.Checked = cpuIdEAX7ECX0_VPCLMULQDQIsSupported;

            bool cpuIdEAX7ECX0_AVX512VNNIIsSupported = cpuHelper.GetEAX7ECX0_ECX11_AVX512VNNIIsSupportedX();
            checkBoxAVX512VNNI.Checked = cpuIdEAX7ECX0_AVX512VNNIIsSupported;

            bool cpuIdEAX7ECX0_AVX512BITALGIsSupported = cpuHelper.GetEAX7ECX0_ECX12_AVX512BITALGIsSupportedX();
            checkBoxAVX512BITALG.Checked = cpuIdEAX7ECX0_AVX512BITALGIsSupported;

            bool cpuIdEAX7ECX0_TME_ENIsSupported = cpuHelper.GetEAX7ECX0_ECX13_TME_ENIsSupportedX();
            checkBoxTMEEN.Checked = cpuIdEAX7ECX0_TME_ENIsSupported;

            bool cpuIdEAX7ECX0_AVX512VPOPCNTDQIsSupported = cpuHelper.GetEAX7ECX0_ECX14_AVX512VPOPCNTDQIsSupportedX();
            checkBoxAVX512VPOPCNTDQ.Checked = cpuIdEAX7ECX0_AVX512VPOPCNTDQIsSupported;

            bool cpuIdEAX7ECX0_FZMIsSupported = cpuHelper.GetEAX7ECX0_ECX15_FZMIsSupportedX();
            checkBoxFZM.Checked = cpuIdEAX7ECX0_FZMIsSupported;

            bool cpuIdEAX7ECX0_LA57IsSupported = cpuHelper.GetEAX7ECX0_ECX16_LA57IsSupportedX();
            checkBoxLA57.Checked = cpuIdEAX7ECX0_LA57IsSupported;

            int mawaui = 0;
            if (cpuHelper.GetEAX7ECX0_ECX17_MAWAUIsSupported1X())
            {
                mawaui += 1;
            }

            if (cpuHelper.GetEAX7ECX0_ECX18_MAWAUIsSupported2X())
            {
                mawaui += 2;
            }

            if (cpuHelper.GetEAX7ECX0_ECX19_MAWAUIsSupported3X())
            {
                mawaui += 4;
            }

            if (cpuHelper.GetEAX7ECX0_ECX20_MAWAUIsSupported4X())
            {
                mawaui += 8;
            }

            if (cpuHelper.GetEAX7ECX0_ECX21_MAWAUIsSupported5X())
            {
                mawaui += 16;
            }

            textBoxMAWAU.Text = mawaui.ToString();

            bool cpuIdEAX7ECX0_RDPIDIsSupported = cpuHelper.GetEAX7ECX0_ECX22_RDPIDIsSupportedX();
            checkBoxRDPID.Checked = cpuIdEAX7ECX0_RDPIDIsSupported;

            bool cpuIdEAX7ECX0_KLIsSupported = cpuHelper.GetEAX7ECX0_ECX23_KLIsSupportedX();
            checkBoxKL.Checked = cpuIdEAX7ECX0_KLIsSupported;

            bool cpuIdEAX7ECX0_BusLockDetectIsSupported = cpuHelper.GetEAX7ECX0_ECX24_BusLockDetectIsSupportedX();
            checkBoxCLDEMOTE.Checked = cpuIdEAX7ECX0_BusLockDetectIsSupported;

            bool cpuIdEAX7ECX0_CLDEMOTEIsSupported = cpuHelper.GetEAX7ECX0_ECX25_CLDEMOTEIsSupportedX();
            checkBoxCLDEMOTE.Checked = cpuIdEAX7ECX0_CLDEMOTEIsSupported;

            bool cpuIdEAX7ECX0_MPRRIsSupported = cpuHelper.GetEAX7ECX0_ECX26_MPRRIsSupportedX();
            checkBoxMPRR.Checked = cpuIdEAX7ECX0_MPRRIsSupported;

            bool cpuIdEAX7ECX0_MOVDIRIIsSupported = cpuHelper.GetEAX7ECX0_ECX27_MOVDIRIIsSupportedX();
            checkBoxMOVDIRI.Checked = cpuIdEAX7ECX0_MOVDIRIIsSupported;

            bool cpuIdEAX7ECX0_MOVDIR64BIsSupported = cpuHelper.GetEAX7ECX0_ECX28_MOVDIR64BIsSupportedX();
            checkBoxMOVDIR64B.Checked = cpuIdEAX7ECX0_MOVDIR64BIsSupported;

            bool cpuIdEAX7ECX0_ENQCMDIsSupported = cpuHelper.GetEAX7ECX0_ECX29_ENQCMDIsSupportedX();
            checkBoxENQCMD.Checked = cpuIdEAX7ECX0_ENQCMDIsSupported;

            bool cpuIdEAX7ECX0_SGXLcIsSupported = cpuHelper.GetEAX7ECX0_ECX30_SGXLcIsSupportedX();
            checkBoxSGXLC.Checked = cpuIdEAX7ECX0_SGXLcIsSupported;

            bool cpuIdEAX7ECX0_PKSIsSupported = cpuHelper.GetEAX7ECX0_ECX31_PKSIsSupportedX();
            checkBoxPKS.Checked = cpuIdEAX7ECX0_PKSIsSupported;

            #endregion

            #region EDX

            bool cpuIdEAX7ECX0_SGXTEMIsSupported = cpuHelper.GetEAX7ECX0_EDX0_SGXTEMIsSupportedX();
            checkBoxSGXTEM.Checked = cpuIdEAX7ECX0_SGXTEMIsSupported;

            bool cpuIdEAX7ECX0_SGXKEYIsSupported = cpuHelper.GetEAX7ECX0_EDX1_SGXKEYIsSupportedX();
            checkBoxSGXKEYS.Checked = cpuIdEAX7ECX0_SGXKEYIsSupported;

            bool cpuIdEAX7ECX0_AVX5124VNNIIsSupported = cpuHelper.GetEAX7ECX0_EDX2_AVX5124VNNIIsSupportedX();
            checkBoxAVX5124VNNIW.Checked = cpuIdEAX7ECX0_AVX5124VNNIIsSupported;

            bool cpuIdEAX7ECX0_AVX5124FMAPSIsSupported = cpuHelper.GetEAX7ECX0_EDX3_AVX5124FMAPSIsSupportedX();
            checkBoxAVX5124FMAPS.Checked = cpuIdEAX7ECX0_AVX5124FMAPSIsSupported;

            bool cpuIdEAX7ECX0_FSRMIsSupported = cpuHelper.GetEAX7ECX0_EDX4_FSRMIsSupportedX();
            checkBoxFSRM.Checked = cpuIdEAX7ECX0_FSRMIsSupported;

            bool cpuIdEAX7ECX0_UINTRIsSupported = cpuHelper.GetEAX7ECX0_EDX5_UINTRIsSupportedX();
            checkBoxUINTR.Checked = cpuIdEAX7ECX0_UINTRIsSupported;

            bool cpuIdEAX7ECX0_EDX6_ReservedIsSupported = cpuHelper.GetEAX7ECX0_EDX6_ReservedIsSupportedX();
            checkBoxReserved6.Checked = cpuIdEAX7ECX0_EDX6_ReservedIsSupported;

            bool cpuIdEAX7ECX0_EDX7_ReservedIsSupported = cpuHelper.GetEAX7ECX0_EDX7_ReservedIsSupportedX();
            checkBoxReserved7.Checked = cpuIdEAX7ECX0_EDX7_ReservedIsSupported;

            bool cpuIdEAX7ECX0_EDX8_AVX512VP2INTERSECTIsSupported = cpuHelper.GetEAX7ECX0_EDX8_AVX512VP2INTERSECTIsSupportedX();
            checkBoxAVX512CP2INTERSECT.Checked = cpuIdEAX7ECX0_EDX8_AVX512VP2INTERSECTIsSupported;

            bool cpuIdEAX7ECX0_EDX9_SRBDSCtrlIsSupported = cpuHelper.GetEAX7ECX0_EDX9_SRBDSCtrlIsSupportedX();
            checkBoxSRBDSCTRL.Checked = cpuIdEAX7ECX0_EDX9_SRBDSCtrlIsSupported;

            bool cpuIdEAX7ECX0_EDX10_MDClearIsSupported = cpuHelper.GetEAX7ECX0_EDX10_MDClearIsSupportedX();
            checkBoxMDCLEAR.Checked = cpuIdEAX7ECX0_EDX10_MDClearIsSupported;

            bool cpuIdEAX7ECX0_EDX11_RTMAlwaysAbortIsSupported = cpuHelper.GetEAX7ECX0_EDX11_RTMAlwaysAbortIsSupportedX();
            checkBoxRTMALWAYSABORT.Checked = cpuIdEAX7ECX0_EDX11_RTMAlwaysAbortIsSupported;

            bool cpuIdEAX7ECX0_EDX12_ReservedIsSupported = cpuHelper.GetEAX7ECX0_EDX12_ReservedIsSupportedX();
            checkBoxReserved12.Checked = cpuIdEAX7ECX0_EDX12_ReservedIsSupported;

            bool cpuIdEAX7ECX0_EDX13_RTMForceAbortIsSupported = cpuHelper.GetEAX7ECX0_EDX13_RTMForceAbortIsSupportedX();
            checkBoxRTMFORCEABORT.Checked = cpuIdEAX7ECX0_EDX13_RTMForceAbortIsSupported;

            bool cpuIdEAX7ECX0_EDX14_SERIALIZEIsSupported = cpuHelper.GetEAX7ECX0_EDX14_SERIALIZEIsSupportedX();
            checkBoxSERIALIZE.Checked = cpuIdEAX7ECX0_EDX14_SERIALIZEIsSupported;

            bool cpuIdEAX7ECX0_EDX15_HYBRIDIsSupported = cpuHelper.GetEAX7ECX0_EDX15_HYBRIDIsSupportedX();
            checkBoxHYBRID.Checked = cpuIdEAX7ECX0_EDX15_HYBRIDIsSupported;

            bool cpuIdEAX7ECX0_EDX16_TSXLDTRKIsSupported = cpuHelper.GetEAX7ECX0_EDX16_TSXLDTRKIsSupportedX();
            checkBoxTSXLDTRK.Checked = cpuIdEAX7ECX0_EDX16_TSXLDTRKIsSupported;

            bool cpuIdEAX7ECX0_EDX17_ReservedIsSupported = cpuHelper.GetEAX7ECX0_EDX17_ReservedIsSupportedX();
            checkBoxReserved17.Checked = cpuIdEAX7ECX0_EDX17_ReservedIsSupported;

            bool cpuIdEAX7ECX0_EDX18_PCONFIGIsSupported = cpuHelper.GetEAX7ECX0_EDX18_PCONFIGIsSupportedX();
            checkBoxPCONFIG.Checked = cpuIdEAX7ECX0_EDX18_PCONFIGIsSupported;

            bool cpuIdEAX7ECX0_EDX19_LBRIsSupported = cpuHelper.GetEAX7ECX0_EDX19_LBRIsSupportedX();
            checkBoxLBR.Checked = cpuIdEAX7ECX0_EDX19_LBRIsSupported;

            bool cpuIdEAX7ECX0_EDX20_CETIBTIsSupported = cpuHelper.GetEAX7ECX0_EDX20_CETIBTIsSupportedX();
            checkBoxCETIBT.Checked = cpuIdEAX7ECX0_EDX20_CETIBTIsSupported;

            bool cpuIdEAX7ECX0_EDX21_ReservedIsSupported = cpuHelper.GetEAX7ECX0_EDX21_ReservedIsSupportedX();
            checkBoxReserved21.Checked = cpuIdEAX7ECX0_EDX21_ReservedIsSupported;

            bool cpuIdEAX7ECX0_EDX22_AMXBF16IsSupported = cpuHelper.GetEAX7ECX0_EDX22_AMXBF16IsSupportedX();
            checkBoxAMXBF16.Checked = cpuIdEAX7ECX0_EDX22_AMXBF16IsSupported;

            bool cpuIdEAX7ECX0_EDX23_AVX512FP16IsSupported = cpuHelper.GetEAX7ECX0_EDX23_AVX512FP16IsSupportedX();
            checkBoxAVX512FP16.Checked = cpuIdEAX7ECX0_EDX23_AVX512FP16IsSupported;

            bool cpuIdEAX7ECX0_EDX24_AMXTILEIsSupported = cpuHelper.GetEAX7ECX0_EDX24_AMXTILEIsSupportedX();
            checkBoxAMXTILE.Checked = cpuIdEAX7ECX0_EDX24_AMXTILEIsSupported;

            bool cpuIdEAX7ECX0_EDX25_AMXINT8IsSupported = cpuHelper.GetEAX7ECX0_EDX25_AMXINT8IsSupportedX();
            checkBoxAMXINT8.Checked = cpuIdEAX7ECX0_EDX25_AMXINT8IsSupported;

            bool cpuIdEAX7ECX0_EDX26_SPEC_CTRLIsSupported = cpuHelper.GetEAX7ECX0_EDX26_SPEC_CTRLIsSupportedX();
            checkBoxIBRSSPECCTRL.Checked = cpuIdEAX7ECX0_EDX26_SPEC_CTRLIsSupported;

            bool cpuIdEAX7ECX0_EDX27_STIBPIsSupported = cpuHelper.GetEAX7ECX0_EDX27_STIBPIsSupportedX();
            checkBoxSTIBP.Checked = cpuIdEAX7ECX0_EDX27_STIBPIsSupported;

            bool cpuIdEAX7ECX0_EDX28_L1D_FLUSHIsSupported = cpuHelper.GetEAX7ECX0_EDX28_L1D_FLUSHIsSupportedX();
            checkBoxL1DFLUSH.Checked = cpuIdEAX7ECX0_EDX28_L1D_FLUSHIsSupported;

            bool cpuIdEAX7ECX0_EDX29_ARCH_CAPABILITIESIsSupported = cpuHelper.GetEAX7ECX0_EDX29_ARCH_CAPABILITIESIsSupportedX();
            checkBoxARCHCAPABILITIES.Checked = cpuIdEAX7ECX0_EDX29_ARCH_CAPABILITIESIsSupported;

            bool cpuIdEAX7ECX0_EDX30_CORE_CAPABILITIESIsSupported = cpuHelper.GetEAX7ECX0_EDX30_CORE_CAPABILITIESIsSupportedX();
            checkBoxCORECAPABILITIES.Checked = cpuIdEAX7ECX0_EDX30_CORE_CAPABILITIESIsSupported;

            bool cpuIdEAX7ECX0_EDX31_SSBDIsSupported = cpuHelper.GetEAX7ECX0_EDX31_SSBDIsSupportedX();
            checkBoxSSBD.Checked = cpuIdEAX7ECX0_EDX31_SSBDIsSupported;

            #endregion

            #endregion
        }
    }
}
