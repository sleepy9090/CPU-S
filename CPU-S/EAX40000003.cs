/*
    File           EAX40000003.cs
    Brief          Form for displaying EAX=0x40000003 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           09/22/2026
    Author         Shawn M. Crawford [sleepy]
*/
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
    public partial class EAX40000003 : Form
    {
        // ECX 3...0 - Maximum Processor Power State (0=C0, 1=C1, 2=C2, 3=C3)
        public const string C0_ACTIVE = "C0 - Active";
        public const string C1_HALT = "C1 - Halt";
        public const string C2_STOP_CLOCK = "C2 - Stop-Clock";
        public const string C3_SLEEP = "C3 - Sleep";

        private CPUHelper cpuHelper;

        public EAX40000003()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x40000003: Reserved for Hypervisors - Features

            string cpuIdEAX40000003EAX = cpuHelper.GetEAX40000003EAXX();
            textBoxEAX40000003EAX.Text = cpuIdEAX40000003EAX;

            string cpuIdEAX40000003EBX = cpuHelper.GetEAX40000003EBXX();
            textBoxEAX40000003EBX.Text = cpuIdEAX40000003EBX;

            string cpuIdEAX40000003ECX = cpuHelper.GetEAX40000003ECXX();
            textBoxEAX40000003ECX.Text = cpuIdEAX40000003ECX;

            string cpuIdEAX40000003EDX = cpuHelper.GetEAX40000003EDXX();
            textBoxEAX40000003EDX.Text = cpuIdEAX40000003EDX;

            // EAX
            checkBoxVPRuntime.Checked = cpuHelper.GetEAX40000003EAX0_VPRuntimeIsSupportedX();
            checkBoxPartitionReferenceCounter.Checked = cpuHelper.GetEAX40000003EAX1_PartitionReferenceCounterIsSupportedX();
            checkBoxBasicSyncICMSRs.Checked = cpuHelper.GetEAX40000003EAX2_BasicSyncICMSRsIsSupportedX();
            checkBoxSyntheticTimerMSRs.Checked = cpuHelper.GetEAX40000003EAX3_SyntheticTimerMSRsIsSupportedX();
            checkBoxAPICAccessMSRs.Checked = cpuHelper.GetEAX40000003EAX4_APICAccessMSRsIsSupportedX();
            checkBoxHypercallMSRs.Checked = cpuHelper.GetEAX40000003EAX5_HypercallMSRsIsSupportedX();
            checkBoxAccessVirtualProcessorIndexMSR.Checked = cpuHelper.GetEAX40000003EAX6_AccessVirtualProcessorIndexMSRsIsSupportedX();
            checkBoxVirtualSystemResetMSR.Checked = cpuHelper.GetEAX40000003EAX7_VirtualSystemResetMSRsIsSupportedX();
            checkBoxAccessStatisticsPagesMSRs.Checked = cpuHelper.GetEAX40000003EAX8_AccessStatisticsPagesMSRsIsSupportedX();
            checkBoxPartitionReferenceTSCMSR.Checked = cpuHelper.GetEAX40000003EAX9_PartitionReferenceTSCMSRIsSupportedX();
            checkBoxVirtualGuestIdleStateMSR.Checked = cpuHelper.GetEAX40000003EAX10_VirtualGuestIdleStateMSRIsSupportedX();
            checkBoxTimerFrequencyMSRs.Checked = cpuHelper.GetEAX40000003EAX11_TimerFrequencyMSRsIsSupportedX();
            checkBoxDebugMSRs.Checked = cpuHelper.GetEAX40000003EAX12_DebugMSRsIsSupportedX();
            checkBoxReenlightenmentControl.Checked = cpuHelper.GetEAX40000003EAX13_ReenlightenmentControlIsSupportedX();
            checkBoxReservedEAX14.Checked = cpuHelper.GetEAX40000003EAX14_ReservedIsSupportedX();
            checkBoxReservedEAX15.Checked = cpuHelper.GetEAX40000003EAX15_ReservedIsSupportedX();
            checkBoxReservedEAX16.Checked = cpuHelper.GetEAX40000003EAX16_ReservedIsSupportedX();
            checkBoxReservedEAX17.Checked = cpuHelper.GetEAX40000003EAX17_ReservedIsSupportedX();
            checkBoxReservedEAX18.Checked = cpuHelper.GetEAX40000003EAX18_ReservedIsSupportedX();
            checkBoxReservedEAX19.Checked = cpuHelper.GetEAX40000003EAX19_ReservedIsSupportedX();
            checkBoxReservedEAX20.Checked = cpuHelper.GetEAX40000003EAX20_ReservedIsSupportedX();
            checkBoxReservedEAX21.Checked = cpuHelper.GetEAX40000003EAX21_ReservedIsSupportedX();
            checkBoxReservedEAX22.Checked = cpuHelper.GetEAX40000003EAX22_ReservedIsSupportedX();
            checkBoxReservedEAX23.Checked = cpuHelper.GetEAX40000003EAX23_ReservedIsSupportedX();
            checkBoxReservedEAX24.Checked = cpuHelper.GetEAX40000003EAX24_ReservedIsSupportedX();
            checkBoxReservedEAX25.Checked = cpuHelper.GetEAX40000003EAX25_ReservedIsSupportedX();
            checkBoxReservedEAX26.Checked = cpuHelper.GetEAX40000003EAX26_ReservedIsSupportedX();
            checkBoxReservedEAX27.Checked = cpuHelper.GetEAX40000003EAX27_ReservedIsSupportedX();
            checkBoxReservedEAX28.Checked = cpuHelper.GetEAX40000003EAX28_ReservedIsSupportedX();
            checkBoxReservedEAX29.Checked = cpuHelper.GetEAX40000003EAX29_ReservedIsSupportedX();
            checkBoxReservedEAX30.Checked = cpuHelper.GetEAX40000003EAX30_ReservedIsSupportedX();
            checkBoxReservedEAX31.Checked = cpuHelper.GetEAX40000003EAX31_ReservedIsSupportedX();

            // EBX
            checkBoxCreatePartition.Checked = cpuHelper.GetEAX40000003EBX0_CreatePartitionIsSupportedX();
            checkBoxAccessPartitionId.Checked = cpuHelper.GetEAX40000003EBX1_AccessPartitionIdIsSupportedX();
            checkBoxAccessMemoryPool.Checked = cpuHelper.GetEAX40000003EBX2_AccessMemoryPoolIsSupportedX();
            checkBoxAdjustMessageBuffers.Checked = cpuHelper.GetEAX40000003EBX3_AdjustMessageBuffersIsSupportedX();
            checkBoxPostMessages.Checked = cpuHelper.GetEAX40000003EBX4_PostMessagesIsSupportedX();
            checkBoxSignalEvents.Checked = cpuHelper.GetEAX40000003EBX5_SignalEventsIsSupportedX();
            checkBoxCreatePort.Checked = cpuHelper.GetEAX40000003EBX6_CreatePortIsSupportedX();
            checkBoxConnectPort.Checked = cpuHelper.GetEAX40000003EBX7_ConnectPortIsSupportedX();
            checkBoxAccessStats.Checked = cpuHelper.GetEAX40000003EBX8_AccessStatsIsSupportedX();
            checkBoxReservedEBX9.Checked = cpuHelper.GetEAX40000003EBX9_ReservedIsSupportedX();
            checkBoxReservedEBX10.Checked = cpuHelper.GetEAX40000003EBX10_ReservedIsSupportedX();
            checkBoxDebugging.Checked = cpuHelper.GetEAX40000003EBX11_DebuggingIsSupportedX();
            checkBoxCpuManagement.Checked = cpuHelper.GetEAX40000003EBX12_CpuManagementIsSupportedX();
            checkBoxConfigureProfiler.Checked = cpuHelper.GetEAX40000003EBX13_ConfigureProfilerIsSupportedX();
            checkBoxReservedEBX14.Checked = cpuHelper.GetEAX40000003EBX14_ReservedIsSupportedX();
            checkBoxReservedEBX15.Checked = cpuHelper.GetEAX40000003EBX15_ReservedIsSupportedX();
            checkBoxAccessVSM.Checked = cpuHelper.GetEAX40000003EBX16_AccessVSMIsSupportedX();
            checkBoxAccessVpRegisters.Checked = cpuHelper.GetEAX40000003EBX17_AccessVpRegistersIsSupportedX();
            checkBoxReservedEBX18.Checked = cpuHelper.GetEAX40000003EBX18_ReservedIsSupportedX();
            checkBoxReservedEBX19.Checked = cpuHelper.GetEAX40000003EBX19_ReservedIsSupportedX();
            checkBoxEnableExtendedHypercalls.Checked = cpuHelper.GetEAX40000003EBX20_EnableExtendedHypercallsIsSupportedX();
            checkBoxStartVirtualProcessor.Checked = cpuHelper.GetEAX40000003EBX21_StartVirtualProcessorIsSupportedX();
            checkBoxIsolation.Checked = cpuHelper.GetEAX40000003EBX22_IsolationIsSupportedX();
            checkBoxReservedEBX23.Checked = cpuHelper.GetEAX40000003EBX23_ReservedIsSupportedX();
            checkBoxReservedEBX24.Checked = cpuHelper.GetEAX40000003EBX24_ReservedIsSupportedX();
            checkBoxReservedEBX25.Checked = cpuHelper.GetEAX40000003EBX25_ReservedIsSupportedX();
            checkBoxReservedEBX26.Checked = cpuHelper.GetEAX40000003EBX26_ReservedIsSupportedX();
            checkBoxReservedEBX27.Checked = cpuHelper.GetEAX40000003EBX27_ReservedIsSupportedX();
            checkBoxReservedEBX28.Checked = cpuHelper.GetEAX40000003EBX28_ReservedIsSupportedX();
            checkBoxReservedEBX29.Checked = cpuHelper.GetEAX40000003EBX29_ReservedIsSupportedX();
            checkBoxReservedEBX30.Checked = cpuHelper.GetEAX40000003EBX30_ReservedIsSupportedX();
            checkBoxReservedEBX31.Checked = cpuHelper.GetEAX40000003EBX31_ReservedIsSupportedX();

            // ECX
            string maximumProcessorPowerState = cpuHelper.Get40000003ECX0_3_MaximumProcessorPowerStateX();
            textBoxMaximumProcessorPowerState.Text = maximumProcessorPowerState;
            int maxprocpowst = -1;
            int.TryParse(maximumProcessorPowerState,out maxprocpowst);
            switch (maxprocpowst)
            {
                case 0:
                    textBoxMaximumProcessorPowerStateCState.Text = C0_ACTIVE;
                    break;
                case 1:
                    textBoxMaximumProcessorPowerStateCState.Text = C1_HALT;
                    break;
                case 2:
                    textBoxMaximumProcessorPowerStateCState.Text = C2_STOP_CLOCK;
                    break;
                case 3:
                    textBoxMaximumProcessorPowerStateCState.Text = C3_SLEEP;
                    break;
                default:
                    textBoxMaximumProcessorPowerStateCState.Text = "Unknown";
                    break;
            }

            checkBoxHPETIsRequiredToEnterC3.Checked = cpuHelper.GetEAX40000003ECX4_HPETIsRequiredToEnterC3X();
            checkBoxInvariantMPERF.Checked = cpuHelper.GetEAX40000003ECX5_InvariantMPERFIsSupportedX();
            checkBoxSupervisorShadowStack.Checked = cpuHelper.GetEAX40000003ECX6_SupervisorShadowStackIsSupportedX();
            checkBoxArchitecturalPMU.Checked = cpuHelper.GetEAX40000003ECX7_ArchitecturalPMUIsSupportedX();
            checkBoxExceptionTrapIntercept.Checked = cpuHelper.GetEAX40000003ECX8_ExceptionTrapInterceptIsSupportedX();
            checkBoxHVVPDispatchInterruptInjection.Checked = cpuHelper.GetEAX40000003ECX9_HVVPDispatchInterruptInjectionIsSupportedX();
            checkBoxHVVPGHCBRootMapping.Checked = cpuHelper.GetEAX40000003ECX10_HVVPGHCBRootMappingIsSupportedX();
            checkBoxReservedECX11.Checked = cpuHelper.GetEAX40000003ECX11_ReservedIsSupportedX();
            checkBoxReservedECX12.Checked = cpuHelper.GetEAX40000003ECX12_ReservedIsSupportedX();
            checkBoxReservedECX13.Checked = cpuHelper.GetEAX40000003ECX13_ReservedIsSupportedX();
            checkBoxReservedECX14.Checked = cpuHelper.GetEAX40000003ECX14_ReservedIsSupportedX();
            checkBoxReservedECX15.Checked = cpuHelper.GetEAX40000003ECX15_ReservedIsSupportedX();
            checkBoxReservedECX16.Checked = cpuHelper.GetEAX40000003ECX16_ReservedIsSupportedX();
            checkBoxReservedECX17.Checked = cpuHelper.GetEAX40000003ECX17_ReservedIsSupportedX();
            checkBoxReservedECX18.Checked = cpuHelper.GetEAX40000003ECX18_ReservedIsSupportedX();
            checkBoxReservedECX19.Checked = cpuHelper.GetEAX40000003ECX19_ReservedIsSupportedX();
            checkBoxReservedECX20.Checked = cpuHelper.GetEAX40000003ECX20_ReservedIsSupportedX();
            checkBoxReservedECX21.Checked = cpuHelper.GetEAX40000003ECX21_ReservedIsSupportedX();
            checkBoxReservedECX22.Checked = cpuHelper.GetEAX40000003ECX22_ReservedIsSupportedX();
            checkBoxReservedECX23.Checked = cpuHelper.GetEAX40000003ECX23_ReservedIsSupportedX();
            checkBoxReservedECX24.Checked = cpuHelper.GetEAX40000003ECX24_ReservedIsSupportedX();
            checkBoxReservedECX25.Checked = cpuHelper.GetEAX40000003ECX25_ReservedIsSupportedX();
            checkBoxReservedECX26.Checked = cpuHelper.GetEAX40000003ECX26_ReservedIsSupportedX();
            checkBoxReservedECX27.Checked = cpuHelper.GetEAX40000003ECX27_ReservedIsSupportedX();
            checkBoxReservedECX28.Checked = cpuHelper.GetEAX40000003ECX28_ReservedIsSupportedX();
            checkBoxReservedECX29.Checked = cpuHelper.GetEAX40000003ECX29_ReservedIsSupportedX();
            checkBoxReservedECX30.Checked = cpuHelper.GetEAX40000003ECX30_ReservedIsSupportedX();
            checkBoxReservedECX31.Checked = cpuHelper.GetEAX40000003ECX31_ReservedIsSupportedX();

            // EDX
            checkBoxDepractedMWAIT.Checked = cpuHelper.GetEAX40000003EDX0_DeprecatedMWAITIsSupportedX();
            checkBoxGuestDebugging.Checked = cpuHelper.GetEAX40000003EDX1_GuestDebuggingIsSupportedX();
            checkBoxPerformanceMonitor.Checked = cpuHelper.GetEAX40000003EDX2_PerformanceMonitorIsSupportedX();
            checkBoxPhysicalCPUDynamicPartitioningEvents.Checked = cpuHelper.GetEAX40000003EDX3_PhysicalCPUDynamicPartitioningEventsIsSupportedX();
            checkBoxHypercallInputParameterBlockViaXMM.Checked = cpuHelper.GetEAX40000003EDX4_HypercallInputParameterBlockViaXMMIsSupportedX();
            checkBoxVirtualGuestIdleState.Checked = cpuHelper.GetEAX40000003EDX5_VirtualGuestIdleStateIsSupportedX();
            checkBoxHypervisiorSleepState.Checked = cpuHelper.GetEAX40000003EDX6_HypervisorSleepStateIsSupportedX();
            checkBoxQueryNUMADistances.Checked = cpuHelper.GetEAX40000003EDX7_QueryNUMADistancesIsSupportedX();
            checkBoxDetermineTimerFrequencies.Checked = cpuHelper.GetEAX40000003EDX8_DetermineTimerFrequenciesIsSupportedX();
            checkBoxInjectSyntheticMCs.Checked = cpuHelper.GetEAX40000003EDX9_InjectSyntheticMCsIsSupportedX();
            checkBoxGuestCrashMSRs.Checked = cpuHelper.GetEAX40000003EDX10_GuestCrashMSRsIsSupportedX();
            checkBoxDebugMSRsEDX11.Checked = cpuHelper.GetEAX40000003EDX11_DebugMSRsIsSupportedX();
            checkBoxNPIEP.Checked = cpuHelper.GetEAX40000003EDX12_NPIEPIsSupportedX();
            checkBoxDisableHypervisor.Checked = cpuHelper.GetEAX40000003EDX13_DisableHypervisorIsSupportedX();
            checkBoxExtendedGvaRangesForFlushVirtualAddressList.Checked = cpuHelper.GetEAX40000003EDX14_ExtendedGvaRangesForFlushVirtualAddressListIsSupportedX();
            checkBoxHypercallOutputViaXMM.Checked = cpuHelper.GetEAX40000003EDX15_HypercallOutputViaXMMIsSupportedX();
            checkBoxReservedEDX16.Checked = cpuHelper.GetEAX40000003EDX16_ReservedIsSupportedX();
            checkBoxSintPollingMode.Checked = cpuHelper.GetEAX40000003EDX17_SintPollingModeIsSupportedX();
            checkBoxHypercallMSRLock.Checked = cpuHelper.GetEAX40000003EDX18_HypercallMSRLockIsSupportedX();
            checkBoxUseDirectSyntheticTimers.Checked = cpuHelper.GetEAX40000003EDX19_UseDirectSyntheticTimersIsSupportedX();
            checkBoxPATRegistersForVSM.Checked = cpuHelper.GetEAX40000003EDX20_PATRegistersForVSMIsSupportedX();
            checkBoxBNDCFGSRegisterForVSM.Checked = cpuHelper.GetEAX40000003EDX21_BNDCFGSRegisterForVSMIsSupportedX();
            checkBoxReservedEDX22.Checked = cpuHelper.GetEAX40000003EDX22_ReservedIsSupportedX();
            checkBoxSyntheticTimeUnhaltedTimer.Checked = cpuHelper.GetEAX40000003EDX23_SyntheticTimeUnhaltedTimerIsSupportedX();
            checkBoxReservedEDX24.Checked = cpuHelper.GetEAX40000003EDX24_ReservedIsSupportedX();
            checkBoxReservedEDX25.Checked = cpuHelper.GetEAX40000003EDX25_ReservedIsSupportedX();
            checkBoxLBR.Checked = cpuHelper.GetEAX40000003EDX26_LBRIsSupportedX();
            checkBoxReservedEDX27.Checked = cpuHelper.GetEAX40000003EDX27_ReservedIsSupportedX();
            checkBoxReservedEDX28.Checked = cpuHelper.GetEAX40000003EDX28_ReservedIsSupportedX();
            checkBoxReservedEDX29.Checked = cpuHelper.GetEAX40000003EDX29_ReservedIsSupportedX();
            checkBoxReservedEDX30.Checked = cpuHelper.GetEAX40000003EDX30_ReservedIsSupportedX();
            checkBoxReservedEDX31.Checked = cpuHelper.GetEAX40000003EDX31_ReservedIsSupportedX();

            #endregion
        }
    }
}
