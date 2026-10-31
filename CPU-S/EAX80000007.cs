/*
    File           EAX80000007.cs
    Brief          Form for displaying EAX=0x80000007 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX80000007 : Form
    {

        private CPUHelper cpuHelper;

        public EAX80000007()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x80000007: Processor Power Management Information and RAS Capabilities

            string cpuIdEAX80000007EAX = cpuHelper.GetEAX80000007EAXX();
            textBoxEAX80000007EAX.Text = cpuIdEAX80000007EAX;

            string cpuIdEAX80000007EBX = cpuHelper.GetEAX80000007EBXX();
            textBoxEAX80000007EBX.Text = cpuIdEAX80000007EBX;

            string cpuIdEAX80000007ECX = cpuHelper.GetEAX80000007ECXX();
            textBoxEAX80000007ECX.Text = cpuIdEAX80000007ECX;

            string cpuIdEAX80000007EDX = cpuHelper.GetEAX80000007EDXX();
            textBoxEAX80000007EDX.Text = cpuIdEAX80000007EDX;

            //EAX
            textBoxNumberOfMonitors.Text = cpuHelper.GetEAX80000007EAX0_7_NumberOfMonitorsX();
            textBoxVersion.Text = cpuHelper.GetEAX80000007EAX8_15_VersionX();
            textBoxMaximumWrapTimeInMs.Text = cpuHelper.GetEAX80000007EAX16_31_MaximumWrapTimeInMsX();

            //EBC
            checkBoxMCAOVR.Checked = cpuHelper.GetEAX80000007EBX0_MCAOVR_IsSupportedX();
            checkBoxSUCCOR.Checked = cpuHelper.GetEAX80000007EBX1_SUCCOR_IsSupportedX();
            checkBoxHWA.Checked = cpuHelper.GetEAX80000007EBX2_HWA_IsSupportedX();
            checkBoxSCMCA.Checked = cpuHelper.GetEAX80000007EBX3_SCMCA_IsSupportedX();
            checkBoxPFEH.Checked = cpuHelper.GetEAX80000007EBX4_PFEH_IsSupportedX();
            checkBoxLWSMI.Checked = cpuHelper.GetEAX80000007EBX5_LWSMI_IsSupportedX();
            textBoxEBX6_14Reserved.Text = cpuHelper.GetEAX80000007EBX6_14_ReservedX();
            checkBoxMCA_Q.Checked = cpuHelper.GetEAX80000007EBX15_MCA_Q_IsSupportedX();
            textBoxEBX16_31Reserved.Text = cpuHelper.GetEAX80000007EBX16_31_ReservedX();

            //ECX
            textBoxRatioOfPowerAccumulatorSamplePeriodToGTSCCounterPeriod.Text = cpuHelper.GetEAX80000007ECX0_31_RatioOfPowerAccumulatorSamplePeriodToGTSCCounterPeriodX();

            //EDX
            checkBoxTS.Checked = cpuHelper.GetEAX80000007EDX0_TS_IsSupportedX();
            checkBoxFID.Checked = cpuHelper.GetEAX80000007EDX1_FID_IsSupportedX();
            checkBoxVID.Checked = cpuHelper.GetEAX80000007EDX2_VID_IsSupportedX();
            checkBoxTTP.Checked = cpuHelper.GetEAX80000007EDX3_TTP_IsSupportedX();
            checkBoxTM.Checked = cpuHelper.GetEAX80000007EDX4_TM_IsSupportedX();
            checkBoxSTC.Checked = cpuHelper.GetEAX80000007EDX5_STC_IsSupportedX();
            checkBoxMUL100.Checked = cpuHelper.GetEAX80000007EDX6_MUL100_IsSupportedX();
            checkBoxHWPS.Checked = cpuHelper.GetEAX80000007EDX7_HWPS_IsSupportedX();
            checkBoxITSC.Checked = cpuHelper.GetEAX80000007EDX8_ITSC_IsSupportedX();
            checkBoxCPB.Checked = cpuHelper.GetEAX80000007EDX9_CPB_IsSupportedX();
            checkBoxEFRO.Checked = cpuHelper.GetEAX80000007EDX10_EFRO_IsSupportedX();
            checkBoxPFI.Checked = cpuHelper.GetEAX80000007EDX11_PFI_IsSupportedX();
            checkBoxPA.Checked = cpuHelper.GetEAX80000007EDX12_PA_IsSupportedX();
            checkBoxCSB.Checked = cpuHelper.GetEAX80000007EDX13_CSB_IsSupportedX();
            checkBoxRAPL.Checked = cpuHelper.GetEAX80000007EDX14_RAPL_IsSupportedX();
            checkBoxCPPCFAST.Checked = cpuHelper.GetEAX80000007EDX15_CPPC_FAST_IsSupportedX();
            checkBoxCPPCPRIO.Checked = cpuHelper.GetEAX80000007EDX16_CPPC_PRIO_IsSupportedX();
            textBoxEDXReserved.Text = cpuHelper.GetEAX80000007EDX17_31_ReservedX();

            #endregion
        }
    }
}
