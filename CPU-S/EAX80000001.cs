/*
    File           EAX80000001.cs
    Brief          Form for displaying EAX=0x80000001 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX80000001 : Form
    {

        private CPUHelper cpuHelper;

        public EAX80000001()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x80000001: Extended Processor Info and Feature Bits

            string cpuIdEAX80000001EAX = cpuHelper.GetEAX80000001EAXX();
            textBoxEAX80000001EAX.Text = cpuIdEAX80000001EAX;

            string cpuIdEAX80000001EBX = cpuHelper.GetEAX80000001EBXX();
            textBoxEAX80000001EBX.Text = cpuIdEAX80000001EBX;

            string cpuIdEAX80000001ECX = cpuHelper.GetEAX80000001ECXX();
            textBoxEAX80000001ECX.Text = cpuIdEAX80000001ECX;

            string cpuIdEAX80000001EDX = cpuHelper.GetEAX80000001EDXX();
            textBoxEAX80000001EDX.Text = cpuIdEAX80000001EDX;

            string cpuIdEAX80000001EAX0_3_SteppingId = cpuHelper.GetEAX80000001EAX0_3_SteppingIdX();
            textBoxEAX80000001EAX0_3_SteppingId.Text = cpuIdEAX80000001EAX0_3_SteppingId;

            string cpuIdEAX80000001EAX4_7_ModelId = cpuHelper.GetEAX80000001EAX4_7_ModelIdX();
            textBoxEAX80000001EAX4_7_ModelId.Text = cpuIdEAX80000001EAX4_7_ModelId;

            string cpuIdEAX80000001EAX8_11_FamilyId = cpuHelper.GetEAX80000001EAX8_11_FamilyIdX();
            textBoxEAX80000001EAX8_11_FamilyId.Text = cpuIdEAX80000001EAX8_11_FamilyId;

            string cpuIdEAX80000001EAX12_13_ProcessorType = cpuHelper.GetEAX80000001EAX12_13_ProcessorTypeX();
            textBoxEAX80000001EAX12_13_ProcessorType.Text = cpuIdEAX80000001EAX12_13_ProcessorType;

            string cpuIdEAX80000001EAX14_15_Reserved = cpuHelper.GetEAX80000001EAX14_15_ReservedX();
            textBoxEAX80000001EAX14_15_Reserved.Text = cpuIdEAX80000001EAX14_15_Reserved;

            string cpuIdEAX80000001EAX16_19_ExtendedModelId = cpuHelper.GetEAX80000001EAX16_19_ExtendedModelIdX();
            textBoxEAX80000001EAX16_19_ExtendedModelId.Text = cpuIdEAX80000001EAX16_19_ExtendedModelId;

            string cpuIdEAX80000001EAX16_19_ExtendedModelIdLeftShifted = cpuHelper.GetEAX80000001EAX16_19_ExtendedModelIdLeftShiftedX();
            textBoxEAX80000001EAX16_19_ExtendedModelIdLeftShifted.Text = cpuIdEAX80000001EAX16_19_ExtendedModelIdLeftShifted;

            string cpuIdEAX80000001EAX_CalculatedProcessorModel = (int.Parse(cpuIdEAX80000001EAX4_7_ModelId) + int.Parse(cpuIdEAX80000001EAX16_19_ExtendedModelIdLeftShifted)).ToString();
            textBoxEAX80000001EAX_CalculatedProcessorModel.Text = cpuIdEAX80000001EAX_CalculatedProcessorModel;

            string cpuIdEAX80000001EAX20_27_ExtendedFamilyId = cpuHelper.GetEAX80000001EAX20_27_ExtendedFamilyIdX();
            textBoxEAX80000001EAX20_27_ExtendedFamilyId.Text = cpuIdEAX80000001EAX20_27_ExtendedFamilyId;

            string cpuIdEAX80000001EAX28_31_Reserved = cpuHelper.GetEAX80000001EAX28_31_ReservedX();
            textBoxEAX80000001EAX28_31_Reserved.Text = cpuIdEAX80000001EAX28_31_Reserved;

            string cpuIdEAX80000001EBX0_7_BrandIndex = cpuHelper.GetEAX80000001EBX0_7_BrandIndexX();
            textBoxEAX80000001EBX0_7_BrandIndex.Text = cpuIdEAX80000001EBX0_7_BrandIndex;

            string cpuIdEAX80000001EBX8_15_CLFLUSHLineSize = cpuHelper.GetEAX80000001EBX8_15_CLFLUSHLineSizeX();
            textBoxEAX80000001EBX8_15_CLFLUSHLineSize.Text = cpuIdEAX80000001EBX8_15_CLFLUSHLineSize;

            string cpuIdEAX80000001EBX16_23_MaxNumAddrIdsLogProcsInPhyPckg = cpuHelper.GetEAX80000001EBX16_23_MaxNumAddrIdsLogProcsInPhyPckgX();
            textBoxEAX80000001EBX16_23_MaxNumAddrIdsLogProcsInPhyPckg.Text = cpuIdEAX80000001EBX16_23_MaxNumAddrIdsLogProcsInPhyPckg;

            string cpuIdEAX80000001EBX24_31_LocalAPICID = cpuHelper.GetEAX80000001EBX24_31_LocalAPICIDX();
            textBoxEAX80000001EBX24_31_LocalAPICID.Text = cpuIdEAX80000001EBX24_31_LocalAPICID;

            bool cpuIdEAX80000001ECX0_LAHF_LMIsSupported = cpuHelper.GetEAX80000001ECX0_LAHF_LMIsSupportedX();
            checkBoxEAX80000001ECX0_LAHF_LM.Checked = cpuIdEAX80000001ECX0_LAHF_LMIsSupported;

            bool cpuIdEAX80000001ECX1_CMP_LEGACYIsSupported = cpuHelper.GetEAX80000001ECX1_CMP_LEGACYIsSupportedX();
            checkBoxEAX80000001ECX1_CMP_LEGACY.Checked = cpuIdEAX80000001ECX1_CMP_LEGACYIsSupported;

            bool cpuIdEAX80000001ECX2_SVMIsSupported = cpuHelper.GetEAX80000001ECX2_SVMIsSupportedX();
            checkBoxEAX80000001ECX2_SVM.Checked = cpuIdEAX80000001ECX2_SVMIsSupported;

            bool cpuIdEAX80000001ECX3_EXTAPICIsSupported = cpuHelper.GetEAX80000001ECX3_EXTAPICIsSupportedX();
            checkBoxEAX80000001ECX3_EXTAPIC.Checked = cpuIdEAX80000001ECX3_EXTAPICIsSupported;

            bool cpuIdEAX80000001ECX4_CR8_LEGACYIsSupported = cpuHelper.GetEAX80000001ECX4_CR8_LEGACYIsSupportedX();
            checkBoxEAX80000001ECX4_CR8_LEGACY.Checked = cpuIdEAX80000001ECX4_CR8_LEGACYIsSupported;

            bool cpuIdEAX80000001ECX5_ABMIsSupported = cpuHelper.GetEAX80000001ECX5_ABMIsSupportedX();
            checkBoxEAX80000001ECX5_ABM_LXCNT.Checked = cpuIdEAX80000001ECX5_ABMIsSupported;

            bool cpuIdEAX80000001ECX6_SSE4AIsSupported = cpuHelper.GetEAX80000001ECX6_SSE4AIsSupportedX();
            checkBoxEAX80000001ECX6_SSE4A.Checked = cpuIdEAX80000001ECX6_SSE4AIsSupported;

            bool cpuIdEAX80000001ECX7_MISALIGNSSEIsSupported = cpuHelper.GetEAX80000001ECX7_MISALIGNSSEIsSupportedX();
            checkBoxEAX80000001ECX7_MISALIGNSSE.Checked = cpuIdEAX80000001ECX7_MISALIGNSSEIsSupported;

            bool cpuIdEAX80000001ECX8_3DNOWPREFETCHIsSupported = cpuHelper.GetEAX80000001ECX8_3DNOWPREFETCHIsSupportedX();
            checkBoxEAX80000001ECX8_3DNOWPREFETCH.Checked = cpuIdEAX80000001ECX8_3DNOWPREFETCHIsSupported;

            bool cpuIdEAX80000001ECX9_OSvwIsSupported = cpuHelper.GetEAX80000001ECX9_OSvwIsSupportedX();
            checkBoxEAX80000001ECX9_OSVW.Checked = cpuIdEAX80000001ECX9_OSvwIsSupported;

            bool cpuIdEAX80000001ECX10_IbsIsSupported = cpuHelper.GetEAX80000001ECX10_IbsIsSupportedX();
            checkBoxEAX80000001ECX10_IBS.Checked = cpuIdEAX80000001ECX10_IbsIsSupported;

            bool cpuIdEAX80000001ECX11_XOPIsSupported = cpuHelper.GetEAX80000001ECX11_XOPIsSupportedX();
            checkBoxEAX80000001ECX11_XOP.Checked = cpuIdEAX80000001ECX11_XOPIsSupported;

            bool cpuIdEAX80000001ECX12_SKINITIsSupported = cpuHelper.GetEAX80000001ECX12_SKINITIsSupportedX();
            checkBoxEAX80000001ECX12_SKINIT.Checked = cpuIdEAX80000001ECX12_SKINITIsSupported;

            bool cpuIdEAX80000001ECX13_WDTIsSupported = cpuHelper.GetEAX80000001ECX13_WDTIsSupportedX();
            checkBoxEAX80000001ECX13_WDT.Checked = cpuIdEAX80000001ECX13_WDTIsSupported;

            bool cpuIdEAX80000001ECX14_TBM0IsSupported = cpuHelper.GetEAX80000001ECX14_TBM0IsSupportedX();
            checkBoxEAX80000001ECX14_TBM0.Checked = cpuIdEAX80000001ECX14_TBM0IsSupported;

            bool cpuIdEAX80000001ECX15_LWPIsSupported = cpuHelper.GetEAX80000001ECX15_LWPIsSupportedX();
            checkBoxEAX80000001ECX15_LWP.Checked = cpuIdEAX80000001ECX15_LWPIsSupported;

            bool cpuIdEAX80000001ECX16_FMA4IsSupported = cpuHelper.GetEAX80000001ECX16_FMA4IsSupportedX();
            checkBoxEAX80000001ECX16_FMA4.Checked = cpuIdEAX80000001ECX16_FMA4IsSupported;

            bool cpuIdEAX80000001ECX17_TCEIsSupported = cpuHelper.GetEAX80000001ECX17_TCEIsSupportedX();
            checkBoxEAX80000001ECX17_TCE.Checked = cpuIdEAX80000001ECX17_TCEIsSupported;

            bool cpuIdEAX80000001ECX18_CVT16IsSupported = cpuHelper.GetEAX80000001ECX18_CVT16IsSupportedX();
            checkBoxEAX80000001ECX18_CVT16.Checked = cpuIdEAX80000001ECX18_CVT16IsSupported;

            bool cpuIdEAX80000001ECX19_NODEID_MSRIsSupported = cpuHelper.GetEAX80000001ECX19_NODEID_MSRIsSupportedX();
            checkBoxEAX80000001ECX19_NODEID_MSR.Checked = cpuIdEAX80000001ECX19_NODEID_MSRIsSupported;

            bool cpuIdEAX80000001ECX20_ReservedIsSupported = cpuHelper.GetEAX80000001ECX20_ReservedIsSupportedX();
            checkBoxEAX80000001ECX20_Reserved.Checked = cpuIdEAX80000001ECX20_ReservedIsSupported;

            bool cpuIdEAX80000001ECX21_TBMIsSupported = cpuHelper.GetEAX80000001ECX21_TBMIsSupportedX();
            checkBoxEAX80000001ECX21_TBM.Checked = cpuIdEAX80000001ECX21_TBMIsSupported;

            bool cpuIdEAX80000001ECX22_TOPOEXTIsSupported = cpuHelper.GetEAX80000001ECX22_TOPOEXTIsSupportedX();
            checkBoxEAX80000001ECX22_TOPOEXT.Checked = cpuIdEAX80000001ECX22_TOPOEXTIsSupported;

            bool cpuIdEAX80000001ECX23_PERFCTR_COREIsSupported = cpuHelper.GetEAX80000001ECX23_PERFCTR_COREIsSupportedX();
            checkBoxEAX80000001ECX23_PERFCTR_CORE.Checked = cpuIdEAX80000001ECX23_PERFCTR_COREIsSupported;

            bool cpuIdEAX80000001ECX24_PERFCTR_NBIsSupported = cpuHelper.GetEAX80000001ECX24_PERFCTR_NBIsSupportedX();
            checkBoxEAX80000001ECX24_PERFCTR_NB.Checked = cpuIdEAX80000001ECX24_PERFCTR_NBIsSupported;

            bool cpuIdEAX80000001ECX25_StreamPerfMonIsSupported = cpuHelper.GetEAX80000001ECX25_StreamPerfMonIsSupportedX();
            checkBoxEAX80000001ECX25_STREAMPERFMON.Checked = cpuIdEAX80000001ECX25_StreamPerfMonIsSupported;

            bool cpuIdEAX80000001ECX26_DBXIsSupported = cpuHelper.GetEAX80000001ECX26_DBXIsSupportedX();
            checkBoxEAX80000001ECX26_DBX.Checked = cpuIdEAX80000001ECX26_DBXIsSupported;

            bool cpuIdEAX80000001ECX27_PERFTSCIsSupported = cpuHelper.GetEAX80000001ECX27_PERFTSCIsSupportedX();
            checkBoxEAX80000001ECX27_PERFTSC.Checked = cpuIdEAX80000001ECX27_PERFTSCIsSupported;

            bool cpuIdEAX80000001ECX28_PCX_L2_L3_IsSupported = cpuHelper.GetEAX80000001ECX28_PCX_L2_L3_IsSupportedX();
            checkBoxEAX80000001ECX28_PCX_L2_PCX_L3.Checked = cpuIdEAX80000001ECX28_PCX_L2_L3_IsSupported;

            bool cpuIdEAX80000001ECX29_MONITORXIsSupported = cpuHelper.GetEAX80000001ECX29_MONITORXIsSupportedX();
            checkBoxEAX80000001ECX29_MONITORX.Checked = cpuIdEAX80000001ECX29_MONITORXIsSupported;

            bool cpuIdEAX80000001ECX30_ADDR_MASK_EXTIsSupported = cpuHelper.GetEAX80000001ECX30_ADDR_MASK_EXTIsSupportedX();
            checkBoxEAX80000001ECX30_ADDR_MASK_EXT.Checked = cpuIdEAX80000001ECX30_ADDR_MASK_EXTIsSupported;

            bool cpuIdEAX80000001ECX31_ReservedIsSupported = cpuHelper.GetEAX80000001ECX31_ReservedIsSupportedX();
            checkBoxEAX80000001ECX31_Reserved.Checked = cpuIdEAX80000001ECX31_ReservedIsSupported;

            bool cpuIdEAX80000001EDX0_FPUIsSupported = cpuHelper.GetEAX80000001EDX0_FPUIsSupportedX();
            checkBoxEAX80000001EDX0_FPU.Checked = cpuIdEAX80000001EDX0_FPUIsSupported;

            bool cpuIdEAX80000001EDX1_VMEIsSupported = cpuHelper.GetEAX80000001EDX1_VMEIsSupportedX();
            checkBoxEAX80000001EDX1_VME.Checked = cpuIdEAX80000001EDX1_VMEIsSupported;

            bool cpuIdEAX80000001EDX2_DEIsSupported = cpuHelper.GetEAX80000001EDX2_DEIsSupportedX();
            checkBoxEAX80000001EDX2_DE.Checked = cpuIdEAX80000001EDX2_DEIsSupported;

            bool cpuIdEAX80000001EDX3_PSEIsSupported = cpuHelper.GetEAX80000001EDX3_PSEIsSupportedX();
            checkBoxEAX80000001EDX3_PSE.Checked = cpuIdEAX80000001EDX3_PSEIsSupported;

            bool cpuIdEAX80000001EDX4_TSCIsSupported = cpuHelper.GetEAX80000001EDX4_TSCIsSupportedX();
            checkBoxEAX80000001EDX4_TSC.Checked = cpuIdEAX80000001EDX4_TSCIsSupported;

            bool cpuIdEAX80000001EDX5_MSRIsSupported = cpuHelper.GetEAX80000001EDX5_MSRIsSupportedX();
            checkBoxEAX80000001EDX5_MSR.Checked = cpuIdEAX80000001EDX5_MSRIsSupported;

            bool cpuIdEAX80000001EDX6_PAEIsSupported = cpuHelper.GetEAX80000001EDX6_PAEIsSupportedX();
            checkBoxEAX80000001EDX6_PAE.Checked = cpuIdEAX80000001EDX6_PAEIsSupported;

            bool cpuIdEAX80000001EDX7_MCEIsSupported = cpuHelper.GetEAX80000001EDX7_MCEIsSupportedX();
            checkBoxEAX80000001EDX7_MCE.Checked = cpuIdEAX80000001EDX7_MCEIsSupported;

            bool cpuIdEAX80000001EDX8_CX8IsSupported = cpuHelper.GetEAX80000001EDX8_CX8IsSupportedX();
            checkBoxEAX80000001EDX8_CX8.Checked = cpuIdEAX80000001EDX8_CX8IsSupported;

            bool cpuIdEAX80000001EDX9_APICIsSupported = cpuHelper.GetEAX80000001EDX9_APICIsSupportedX();
            checkBoxEAX80000001EDX9_APIC.Checked = cpuIdEAX80000001EDX9_APICIsSupported;

            bool cpuIdEAX80000001EDX10_SYSCALL_K6IsSupported = cpuHelper.GetEAX80000001EDX10_SYSCALL_K6IsSupportedX();
            checkBoxEAX80000001EDX10_SYSCALLK6.Checked = cpuIdEAX80000001EDX10_SYSCALL_K6IsSupported;

            bool cpuIdEAX80000001EDX11_SYSCALLIsSupported = cpuHelper.GetEAX80000001EDX11_SYSCALLIsSupportedX();
            checkBoxEAX80000001EDX11_SYSCALL.Checked = cpuIdEAX80000001EDX11_SYSCALLIsSupported;

            bool cpuIdEAX80000001EDX12_MTRRIsSupported = cpuHelper.GetEAX80000001EDX12_MTRRIsSupportedX();
            checkBoxEAX80000001_EDX12_MTRR.Checked = cpuIdEAX80000001EDX12_MTRRIsSupported;

            bool cpuIdEAX80000001EDX13_PGEIsSupported = cpuHelper.GetEAX80000001EDX13_PGEIsSupportedX();
            checkBoxEAX80000001_EDX13_PGE.Checked = cpuIdEAX80000001EDX13_PGEIsSupported;

            bool cpuIdEAX80000001EDX14_MCAIsSupported = cpuHelper.GetEAX80000001EDX14_MCAIsSupportedX();
            checkBoxEAX80000001_EDX14_MCA.Checked = cpuIdEAX80000001EDX14_MCAIsSupported;

            bool cpuIdEAX80000001EDX15_CMOVIsSupported = cpuHelper.GetEAX80000001EDX15_CMOVIsSupportedX();
            checkBoxEAX80000001_EDX15_CMOV.Checked = cpuIdEAX80000001EDX15_CMOVIsSupported;

            bool cpuIdEAX80000001EDX16_PATIsSupported = cpuHelper.GetEAX80000001EDX16_PATIsSupportedX();
            checkBoxEAX80000001_EDX16_PAT.Checked = cpuIdEAX80000001EDX16_PATIsSupported;

            bool cpuIdEAX80000001EDX17_PSE36IsSupported = cpuHelper.GetEAX80000001EDX17_PSE36IsSupportedX();
            checkBoxEAX80000001_EDX17_PSE36.Checked = cpuIdEAX80000001EDX17_PSE36IsSupported;

            bool cpuIdEAX80000001EDX18_ECC_K7IsSupported = cpuHelper.GetEAX80000001EDX18_ECC_K7IsSupportedX();
            checkBoxEAX80000001_EDX18_ECC_K7.Checked = cpuIdEAX80000001EDX18_ECC_K7IsSupported;

            bool cpuIdEAX80000001EDX19_ECCIsSupported = cpuHelper.GetEAX80000001EDX19_ECCIsSupportedX();
            checkBoxEAX80000001_EDX19_ECC.Checked = cpuIdEAX80000001EDX19_ECCIsSupported;

            bool cpuIdEAX80000001EDX20_NXIsSupported = cpuHelper.GetEAX80000001EDX20_NXIsSupportedX();
            checkBoxEAX80000001_EDX20_NX.Checked = cpuIdEAX80000001EDX20_NXIsSupported;

            bool cpuIdEAX80000001EDX21_SEMIsSupported = cpuHelper.GetEAX80000001EDX21_SEMIsSupportedX();
            checkBoxEAX80000001_EDX21_SEM.Checked = cpuIdEAX80000001EDX21_SEMIsSupported;

            bool cpuIdEAX80000001EDX22_MMXEXTIsSupported = cpuHelper.GetEAX80000001EDX22_MMXEXTIsSupportedX();
            checkBoxEAX80000001_EDX22_MMXEXT.Checked = cpuIdEAX80000001EDX22_MMXEXTIsSupported;

            bool cpuIdEAX80000001EDX23_MMXIsSupported = cpuHelper.GetEAX80000001EDX23_MMXIsSupportedX();
            checkBoxEAX80000001_EDX23_MMX.Checked = cpuIdEAX80000001EDX23_MMXIsSupported;

            bool cpuIdEAX80000001EDX24_FXSRIsSupported = cpuHelper.GetEAX80000001EDX24_FXSRIsSupportedX();
            checkBoxEAX80000001_EDX24_FXSR.Checked = cpuIdEAX80000001EDX24_FXSRIsSupported;

            bool cpuIdEAX80000001EDX25_FXSR_OPTIsSupported = cpuHelper.GetEAX80000001EDX25_FXSR_OPTIsSupportedX();
            checkBoxEAX80000001_EDX25_FXSR_OPT.Checked = cpuIdEAX80000001EDX25_FXSR_OPTIsSupported;

            bool cpuIdEAX80000001EDX26_PDPE1GBIsSupported = cpuHelper.GetEAX80000001EDX26_PDPE1GBIsSupportedX();
            checkBoxEAX80000001_EDX26_PDPE1GB.Checked = cpuIdEAX80000001EDX26_PDPE1GBIsSupported;

            bool cpuIdEAX80000001EDX27_RDTSCPIsSupported = cpuHelper.GetEAX80000001EDX27_RDTSCPIsSupportedX();
            checkBoxEAX80000001_EDX27_RDTSCP.Checked = cpuIdEAX80000001EDX27_RDTSCPIsSupported;

            bool cpuIdEAX80000001EDX28_REX32IsSupported = cpuHelper.GetEAX80000001EDX28_REX32IsSupportedX();
            checkBoxEAX80000001_EDX28_REX32.Checked = cpuIdEAX80000001EDX28_REX32IsSupported;

            bool cpuIdEAX80000001EDX29_LMIsSupported = cpuHelper.GetEAX80000001EDX29_LMIsSupportedX();
            checkBoxEAX80000001_EDX29_LM.Checked = cpuIdEAX80000001EDX29_LMIsSupported;

            bool cpuIdEAX80000001EDX30_3DNOWEXTIsSupported = cpuHelper.GetEAX80000001EDX30_3DNOWEXTIsSupportedX();
            checkBoxEAX80000001_EDX30_3DNOWEXT.Checked = cpuIdEAX80000001EDX30_3DNOWEXTIsSupported;

            bool cpuIdEAX80000001EDX31_3DNOWIsSupported = cpuHelper.GetEAX80000001EDX31_3DNOWIsSupportedX();
            checkBoxEAX80000001_EDX31_3DNOW.Checked = cpuIdEAX80000001EDX31_3DNOWIsSupported;

            #endregion
        }
    }
}
