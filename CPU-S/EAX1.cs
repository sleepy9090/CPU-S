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
    public partial class EAX1 : Form
    {

        private CPUHelper cpuHelper;

        public EAX1()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region

            string cpuIdEAX1EAX = cpuHelper.GetEAX1EAXX();
            textBoxEAX1EAX.Text = cpuIdEAX1EAX;

            string cpuIdEAX1EBX = cpuHelper.GetEAX1EBXX();
            textBoxEAX1EBX.Text = cpuIdEAX1EBX;

            string cpuIdEAX1ECX = cpuHelper.GetEAX1ECXX();
            textBoxEAX1ECX.Text = cpuIdEAX1ECX;

            string cpuIdEAX1EDX = cpuHelper.GetEAX1EDXX();
            textBoxEAX1EDX.Text = cpuIdEAX1EDX;

            string cpuIdEAX1EAX0_3_SteppingId = cpuHelper.GetEAX1EAX0_3_SteppingIdX();
            textBoxEAX1EAX0_3_SteppingId.Text = cpuIdEAX1EAX0_3_SteppingId;

            string cpuIdEAX1EAX4_7_ModelId = cpuHelper.GetEAX1EAX4_7_ModelIdX();
            textBoxEAX1EAX4_7_ModelId.Text = cpuIdEAX1EAX4_7_ModelId;

            string cpuIdEAX1EAX8_11_FamilyId = cpuHelper.GetEAX1EAX8_11_FamilyIdX();
            textBoxEAX1EAX8_11_FamilyId.Text = cpuIdEAX1EAX8_11_FamilyId;

            string cpuIdEAX1EAX12_13_ProcessorType = cpuHelper.GetEAX1EAX12_13_ProcessorTypeX();
            textBoxEAX1EAX12_13_ProcessorType.Text = cpuIdEAX1EAX12_13_ProcessorType;

            string cpuIdEAX1EAX14_15_Reserved = cpuHelper.GetEAX1EAX14_15_ReservedX();
            textBoxEAX1EAX14_15_Reserved.Text = cpuIdEAX1EAX14_15_Reserved;

            string cpuIdEAX1EAX16_19_ExtendedModelId = cpuHelper.GetEAX1EAX16_19_ExtendedModelIdX();
            textBoxEAX1EAX16_19_ExtendedModelId.Text = cpuIdEAX1EAX16_19_ExtendedModelId;

            string cpuIdEAX1EAX16_19_ExtendedModelIdLeftShifted = cpuHelper.GetEAX1EAX16_19_ExtendedModelIdLeftShiftedX();
            textBoxEAX1EAX16_19_ExtendedModelIdLeftShifted.Text = cpuIdEAX1EAX16_19_ExtendedModelIdLeftShifted;

            string cpuIdEAX1EAX_CalculatedProcessorModel = (int.Parse(cpuIdEAX1EAX4_7_ModelId) + int.Parse(cpuIdEAX1EAX16_19_ExtendedModelIdLeftShifted)).ToString();
            textBoxEAX1EAX_CalculatedProcessorModel.Text = cpuIdEAX1EAX_CalculatedProcessorModel;

            string cpuIdEAX1EAX20_27_ExtendedFamilyId = cpuHelper.GetEAX1EAX20_27_ExtendedFamilyIdX();
            textBoxEAX1EAX20_27_ExtendedFamilyId.Text = cpuIdEAX1EAX20_27_ExtendedFamilyId;

            string cpuIdEAX1EAX28_31_Reserved = cpuHelper.GetEAX1EAX28_31_ReservedX();
            textBoxEAX1EAX28_31_Reserved.Text = cpuIdEAX1EAX28_31_Reserved;

            string cpuIdEAX1EBX0_7_BrandIndex = cpuHelper.GetEAX1EBX0_7_BrandIndexX();
            textBoxEAX1EBX0_7_BrandIndex.Text = cpuIdEAX1EBX0_7_BrandIndex;

            string cpuIdEAX1EBX8_15_CLFLUSHLineSize = cpuHelper.GetEAX1EBX8_15_CLFLUSHLineSizeX();
            textBoxEAX1EBX8_15_CLFLUSHLineSize.Text = cpuIdEAX1EBX8_15_CLFLUSHLineSize;

            string cpuIdEAX1EBX16_23_MaxNumAddrIdsLogProcsInPhyPckg = cpuHelper.GetEAX1EBX16_23_MaxNumAddrIdsLogProcsInPhyPckgX();
            textBoxEAX1EBX16_23_MaxNumAddrIdsLogProcsInPhyPckg.Text = cpuIdEAX1EBX16_23_MaxNumAddrIdsLogProcsInPhyPckg;

            string cpuIdEAX1EBX24_31_LocalAPICID = cpuHelper.GetEAX1EBX24_31_LocalAPICIDX();
            textBoxEAX1EBX24_31_LocalAPICID.Text = cpuIdEAX1EBX24_31_LocalAPICID;

            bool cpuIdEAX1ECX0_SSE3IsSupported = cpuHelper.GetEAX1ECX0_SSE3IsSupportedX();
            checkBoxEAX1ECX0_SSE3.Checked = cpuIdEAX1ECX0_SSE3IsSupported;

            bool cpuIdEAX1ECX1_PCLMULQDQIsSupported = cpuHelper.GetEAX1ECX1_PCLMULQDQIsSupportedX();
            checkBoxEAX1ECX1_PCLMULQDQ.Checked = cpuIdEAX1ECX1_PCLMULQDQIsSupported;

            bool cpuIdEAX1ECX2_DTES64IsSupported = cpuHelper.GetEAX1ECX2_DTES64IsSupportedX();
            checkBoxEAX1ECX2_DTES64.Checked = cpuIdEAX1ECX2_DTES64IsSupported;

            bool cpuIdEAX1ECX3_MONITORIsSupported = cpuHelper.GetEAX1ECX3_MONITORIsSupportedX();
            checkBoxEAX1ECX3_MONITOR.Checked = cpuIdEAX1ECX3_MONITORIsSupported;

            bool cpuIdEAX1ECX4_DSCPLIsSupported = cpuHelper.GetEAX1ECX4_DSCPLIsSupportedX();
            checkBoxEAX1ECX4_DSCPL.Checked = cpuIdEAX1ECX4_DSCPLIsSupported;

            bool cpuIdEAX1ECX5_VMXIsSupported = cpuHelper.GetEAX1ECX5_VMXIsSupportedX();
            checkBoxEAX1ECX5_VMX.Checked = cpuIdEAX1ECX5_VMXIsSupported;

            bool cpuIdEAX1ECX6_SMXIsSupported = cpuHelper.GetEAX1ECX6_SMXIsSupportedX();
            checkBoxEAX1ECX6_SMX.Checked = cpuIdEAX1ECX6_SMXIsSupported;

            bool cpuIdEAX1ECX7_ESTIsSupported = cpuHelper.GetEAX1ECX7_ESTIsSupportedX();
            checkBoxEAX1ECX7_EST.Checked = cpuIdEAX1ECX7_ESTIsSupported;

            bool cpuIdEAX1ECX8_TM2IsSupported = cpuHelper.GetEAX1ECX8_TM2IsSupportedX();
            checkBoxEAX1ECX8_TM2.Checked = cpuIdEAX1ECX8_TM2IsSupported;

            bool cpuIdEAX1ECX9_SSSE3IsSupported = cpuHelper.GetEAX1ECX9_SSSE3IsSupportedX();
            checkBoxEAX1ECX9_SSSE3.Checked = cpuIdEAX1ECX9_SSSE3IsSupported;

            bool cpuIdEAX1ECX10_CNXTIDIsSupported = cpuHelper.GetEAX1ECX10_CNXTIDIsSupportedX();
            checkBoxEAX1ECX10_CNXTID.Checked = cpuIdEAX1ECX10_CNXTIDIsSupported;

            bool cpuIdEAX1ECX11_SDBGIsSupported = cpuHelper.GetEAX1ECX11_SDBGIsSupportedX();
            checkBoxEAX1ECX11_SDBG.Checked = cpuIdEAX1ECX11_SDBGIsSupported;

            bool cpuIdEAX1ECX12_FMAIsSupported = cpuHelper.GetEAX1ECX12_FMAIsSupportedX();
            checkBoxEAX1ECX12_FMA.Checked = cpuIdEAX1ECX12_FMAIsSupported;

            bool cpuIdEAX1ECX13_CMPXCHG16BIsSupported = cpuHelper.GetEAX1ECX13_CMPXCHG16BIsSupportedX();
            checkBoxEAX1ECX13_CMPXCHG16B.Checked = cpuIdEAX1ECX13_CMPXCHG16BIsSupported;

            bool cpuIdEAX1ECX14_xTPRUpdateControlIsSupported = cpuHelper.GetEAX1ECX14_xTPRUpdateControlIsSupportedX();
            checkBoxEAX1ECX14_xTPRUpdateControl.Checked = cpuIdEAX1ECX14_xTPRUpdateControlIsSupported;

            bool cpuIdEAX1ECX15_PDCMIsSupported = cpuHelper.GetEAX1ECX15_PDCMIsSupportedX();
            checkBoxEAX1ECX15_PDCM.Checked = cpuIdEAX1ECX15_PDCMIsSupported;

            bool cpuIdEAX1ECX16_ReservedIsSupported = cpuHelper.GetEAX1ECX16_ReservedIsSupportedX();
            checkBoxEAX1ECX16_Reserved.Checked = cpuIdEAX1ECX16_ReservedIsSupported;

            bool cpuIdEAX1ECX17_PCIDIsSupported = cpuHelper.GetEAX1ECX17_PCIDIsSupportedX();
            checkBoxEAX1ECX17_PCID.Checked = cpuIdEAX1ECX17_PCIDIsSupported;

            bool cpuIdEAX1ECX18_DCAIsSupported = cpuHelper.GetEAX1ECX18_DCAIsSupportedX();
            checkBoxEAX1ECX18_DCA.Checked = cpuIdEAX1ECX18_DCAIsSupported;

            bool cpuIdEAX1ECX19_SSE41IsSupported = cpuHelper.GetEAX1ECX19_SSE41IsSupportedX();
            checkBoxEAX1ECX19_SSE41.Checked = cpuIdEAX1ECX19_SSE41IsSupported;

            bool cpuIdEAX1ECX20_SSE42IsSupported = cpuHelper.GetEAX1ECX20_SSE42IsSupportedX();
            checkBoxEAX1ECX20_SSE42.Checked = cpuIdEAX1ECX20_SSE42IsSupported;

            bool cpuIdEAX1ECX21_X2APICIsSupported = cpuHelper.GetEAX1ECX21_X2APICIsSupportedX();
            checkBoxEAX1ECX21_X2APIC.Checked = cpuIdEAX1ECX21_X2APICIsSupported;

            bool cpuIdEAX1ECX22_MOVBEIsSupported = cpuHelper.GetEAX1ECX22_MOVBEIsSupportedX();
            checkBoxEAX1ECX22_MOVBE.Checked = cpuIdEAX1ECX22_MOVBEIsSupported;

            bool cpuIdEAX1ECX23_POPCNTIsSupported = cpuHelper.GetEAX1ECX23_POPCNTIsSupportedX();
            checkBoxEAX1ECX23_POPCNT.Checked = cpuIdEAX1ECX23_POPCNTIsSupported;

            bool cpuIdEAX1ECX24_TSCDeadlineIsSupported = cpuHelper.GetEAX1ECX24_TSCDeadlineIsSupportedX();
            checkBoxEAX1ECX24_TSCDeadline.Checked = cpuIdEAX1ECX24_TSCDeadlineIsSupported;

            bool cpuIdEAX1ECX25_AESNIIsSupported = cpuHelper.GetEAX1ECX25_AESNIIsSupportedX();
            checkBoxEAX1ECX25_AESNI.Checked = cpuIdEAX1ECX25_AESNIIsSupported;

            bool cpuIdEAX1ECX26_XSAVEIsSupported = cpuHelper.GetEAX1ECX26_XSAVEIsSupportedX();
            checkBoxEAX1ECX26_XSAVE.Checked = cpuIdEAX1ECX26_XSAVEIsSupported;

            bool cpuIdEAX1ECX27_OSXSAVEIsSupported = cpuHelper.GetEAX1ECX27_OSXSAVEIsSupportedX();
            checkBoxEAX1ECX27_OSXSAVE.Checked = cpuIdEAX1ECX27_OSXSAVEIsSupported;

            bool cpuIdEAX1ECX28_AVXIsSupported = cpuHelper.GetEAX1ECX28_AVXIsSupportedX();
            checkBoxEAX1ECX28_AVX.Checked = cpuIdEAX1ECX28_AVXIsSupported;

            bool cpuIdEAX1ECX29_F16CIsSupported = cpuHelper.GetEAX1ECX29_F16CIsSupportedX();
            checkBoxEAX1ECX29_F16C.Checked = cpuIdEAX1ECX29_F16CIsSupported;

            bool cpuIdEAX1ECX30_RDRANDIsSupported = cpuHelper.GetEAX1ECX30_RDRANDIsSupportedX();
            checkBoxEAX1ECX30_RDRAND.Checked = cpuIdEAX1ECX30_RDRANDIsSupported;

            bool cpuIdEAX1ECX31_HypervisorIsSupported = cpuHelper.GetEAX1ECX31_HypervisorIsSupportedX();
            checkBoxEAX1ECX31_Hypervisor.Checked = cpuIdEAX1ECX31_HypervisorIsSupported;

            bool cpuIdEAX1EDX0_FPUIsSupported = cpuHelper.GetEAX1EDX0_FPUIsSupportedX();
            checkBoxEAX1EDX0_FPU.Checked = cpuIdEAX1EDX0_FPUIsSupported;

            bool cpuIdEAX1EDX1_VMEIsSupported = cpuHelper.GetEAX1EDX1_VMEIsSupportedX();
            checkBoxEAX1EDX1_VME.Checked = cpuIdEAX1EDX1_VMEIsSupported;

            bool cpuIdEAX1EDX2_DEIsSupported = cpuHelper.GetEAX1EDX2_DEIsSupportedX();
            checkBoxEAX1EDX2_DE.Checked = cpuIdEAX1EDX2_DEIsSupported;

            bool cpuIdEAX1EDX3_PSEIsSupported = cpuHelper.GetEAX1EDX3_PSEIsSupportedX();
            checkBoxEAX1EDX3_PSE.Checked = cpuIdEAX1EDX3_PSEIsSupported;

            bool cpuIdEAX1EDX4_TSCIsSupported = cpuHelper.GetEAX1EDX4_TSCIsSupportedX();
            checkBoxEAX1EDX4_TSC.Checked = cpuIdEAX1EDX4_TSCIsSupported;

            bool cpuIdEAX1EDX5_MSRIsSupported = cpuHelper.GetEAX1EDX5_MSRIsSupportedX();
            checkBoxEAX1EDX5_MSR.Checked = cpuIdEAX1EDX5_MSRIsSupported;

            bool cpuIdEAX1EDX6_PAEIsSupported = cpuHelper.GetEAX1EDX6_PAEIsSupportedX();
            checkBoxEAX1EDX6_PAE.Checked = cpuIdEAX1EDX6_PAEIsSupported;

            bool cpuIdEAX1EDX7_MCEIsSupported = cpuHelper.GetEAX1EDX7_MCEIsSupportedX();
            checkBoxEAX1EDX7_MCE.Checked = cpuIdEAX1EDX7_MCEIsSupported;

            bool cpuIdEAX1EDX8_CX8IsSupported = cpuHelper.GetEAX1EDX8_CX8IsSupportedX();
            checkBoxEAX1EDX8_CX8.Checked = cpuIdEAX1EDX8_CX8IsSupported;

            bool cpuIdEAX1EDX9_APICIsSupported = cpuHelper.GetEAX1EDX9_APICIsSupportedX();
            checkBoxEAX1EDX9_APIC.Checked = cpuIdEAX1EDX9_APICIsSupported;

            bool cpuIdEAX1EDX10_ReservedIsSupported = cpuHelper.GetEAX1EDX10_ReservedIsSupportedX();
            checkBoxEAX1EDX10_Reserved.Checked = cpuIdEAX1EDX10_ReservedIsSupported;

            bool cpuIdEAX1EDX11_SEPIsSupported = cpuHelper.GetEAX1EDX11_SEPIsSupportedX();
            checkBoxEAX1EDX11_SEP.Checked = cpuIdEAX1EDX11_SEPIsSupported;

            bool cpuIdEAX1EDX12_MTRRIsSupported = cpuHelper.GetEAX1EDX12_MTRRIsSupportedX();
            checkBoxEAX1EDX12_MTRR.Checked = cpuIdEAX1EDX12_MTRRIsSupported;

            bool cpuIdEAX1EDX13_PGEIsSupported = cpuHelper.GetEAX1EDX13_PGEIsSupportedX();
            checkBoxEAX1EDX13_PGE.Checked = cpuIdEAX1EDX13_PGEIsSupported;

            bool cpuIdEAX1EDX14_MCAIsSupported = cpuHelper.GetEAX1EDX14_MCAIsSupportedX();
            checkBoxEAX1EDX14_MCA.Checked = cpuIdEAX1EDX14_MCAIsSupported;

            bool cpuIdEAX1EDX15_CMOVIsSupported = cpuHelper.GetEAX1EDX15_CMOVIsSupportedX();
            checkBoxEAX1EDX15_CMOV.Checked = cpuIdEAX1EDX15_CMOVIsSupported;

            bool cpuIdEAX1EDX16_PATIsSupported = cpuHelper.GetEAX1EDX16_PATIsSupportedX();
            checkBoxEAX1EDX16_PAT.Checked = cpuIdEAX1EDX16_PATIsSupported;

            bool cpuIdEAX1EDX17_PSE36IsSupported = cpuHelper.GetEAX1EDX17_PSE36IsSupportedX();
            checkBoxEAX1EDX17_PSE36.Checked = cpuIdEAX1EDX17_PSE36IsSupported;

            bool cpuIdEAX1EDX18_PSNIsSupported = cpuHelper.GetEAX1EDX18_PSNIsSupportedX();
            checkBoxEAX1EDX18_PSN.Checked = cpuIdEAX1EDX18_PSNIsSupported;

            bool cpuIdEAX1EDX19_CLFSHIsSupported = cpuHelper.GetEAX1EDX19_CLFSHIsSupportedX();
            checkBoxEAX1EDX19_CLFSH.Checked = cpuIdEAX1EDX19_CLFSHIsSupported;

            bool cpuIdEAX1EDX20_NXIsSupported = cpuHelper.GetEAX1EDX20_NXIsSupportedX();
            checkBoxEAX1EDX20_NX.Checked = cpuIdEAX1EDX20_NXIsSupported;

            bool cpuIdEAX1EDX21_DSIsSupported = cpuHelper.GetEAX1EDX21_DSIsSupportedX();
            checkBoxEAX1EDX21_DS.Checked = cpuIdEAX1EDX21_DSIsSupported;

            bool cpuIdEAX1EDX22_ACPIIsSupported = cpuHelper.GetEAX1EDX22_ACPIIsSupportedX();
            checkBoxEAX1EDX22_ACPI.Checked = cpuIdEAX1EDX22_ACPIIsSupported;

            bool cpuIdEAX1EDX23_MMXIsSupported = cpuHelper.GetEAX1EDX23_MMXIsSupportedX();
            checkBoxEAX1EDX23_MMX.Checked = cpuIdEAX1EDX23_MMXIsSupported;

            bool cpuIdEAX1EDX24_FXSRIsSupported = cpuHelper.GetEAX1EDX24_FXSRIsSupportedX();
            checkBoxEAX1EDX24_FXSR.Checked = cpuIdEAX1EDX24_FXSRIsSupported;

            bool cpuIdEAX1EDX25_SSEIsSupported = cpuHelper.GetEAX1EDX25_SSEIsSupportedX();
            checkBoxEAX1EDX25_SSE.Checked = cpuIdEAX1EDX25_SSEIsSupported;

            bool cpuIdEAX1EDX26_SSE2IsSupported = cpuHelper.GetEAX1EDX26_SSE2IsSupportedX();
            checkBoxEAX1EDX26_SSE2.Checked = cpuIdEAX1EDX26_SSE2IsSupported;

            bool cpuIdEAX1EDX27_SSIsSupported = cpuHelper.GetEAX1EDX27_SSIsSupportedX();
            checkBoxEAX1EDX27_SS.Checked = cpuIdEAX1EDX27_SSIsSupported;

            bool cpuIdEAX1EDX28_HTTIsSupported = cpuHelper.GetEAX1EDX28_HTTIsSupportedX();
            checkBoxEAX1EDX28_HTT.Checked = cpuIdEAX1EDX28_HTTIsSupported;

            bool cpuIdEAX1EDX29_TMIsSupported = cpuHelper.GetEAX1EDX29_TMIsSupportedX();
            checkBoxEAX1EDX29_TM.Checked = cpuIdEAX1EDX29_TMIsSupported;

            bool cpuIdEAX1EDX30_IA64IsSupported = cpuHelper.GetEAX1EDX30_IA64IsSupportedX();
            checkBoxEAX1EDX30_IA64.Checked = cpuIdEAX1EDX30_IA64IsSupported;

            bool cpuIdEAX1EDX31_PBEIsSupported = cpuHelper.GetEAX1EDX31_PBEIsSupportedX();
            checkBoxEAX1EDX31_PBE.Checked = cpuIdEAX1EDX31_PBEIsSupported;

            #endregion
        }
    }
}
