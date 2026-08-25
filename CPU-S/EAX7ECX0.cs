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



            #endregion

            #region EDX



            #endregion

            #endregion
        }
    }
}
