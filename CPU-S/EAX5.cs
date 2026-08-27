/*
    File           EAX5.cs
    Brief          Form for displaying EAX=0x5 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX5 : Form
    {

        private CPUHelper cpuHelper;

        public EAX5()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x5: MONITOR/MWAIT Features

            string cpuIdEAX5EAX = cpuHelper.GetEAX5EAXX();
            textBoxEAX5EAX.Text = cpuIdEAX5EAX;

            string cpuIdEAX5EBX = cpuHelper.GetEAX5EBXX();
            textBoxEAX5EBX.Text = cpuIdEAX5EBX;

            string cpuIdEAX5ECX = cpuHelper.GetEAX5ECXX();
            textBoxEAX5ECX.Text = cpuIdEAX5ECX;

            string cpuIdEAX5EDX = cpuHelper.GetEAX5EDXX();
            textBoxEAX5EDX.Text = cpuIdEAX5EDX;

            string cpuIdEAX5_EAX0_15_SmallestMonitorLineSize = cpuHelper.GetEAX5_EAX0_15_SmallestMonitorLineSizeX();
            textBoxEAX5_EAX0_15_SmallestMonitorLineSize.Text = cpuIdEAX5_EAX0_15_SmallestMonitorLineSize;

            string cpuIdEAX5_EAX16_31_Reserved = cpuHelper.GetEAX5_EAX16_31_ReservedX();
            textBoxEAX5_EAX16_31_Reserved.Text = cpuIdEAX5_EAX16_31_Reserved;

            string cpuIdEAX5_EBX0_15_LargestMonitorLineSize = cpuHelper.GetEAX5_EBX0_15_LargestMonitorLineSizeX();
            textBoxEAX5_EBX0_15_LargestMonitorLineSize.Text = cpuIdEAX5_EBX0_15_LargestMonitorLineSize;

            string cpuIdEAX5_EBX16_31_Reserved = cpuHelper.GetEAX5_EBX16_31_ReservedX();
            textBoxEAX5_EBX16_31_Reserved.Text = cpuIdEAX5_EBX16_31_Reserved;

            string cpuIdEAX5_ECX0_EnumOfMonitorMWAITExtensionsInECXAndEDXSupported_EMX = cpuHelper.GetEAX5_ECX0_EnumOfMonitorMWAITExtensionsInECXAndEDXSupported_EMXX();
            textBoxEAX5_ECX0_EnumOfMonitorMWAITExtensionsInECXAndEDXSupported_EMX.Text = cpuIdEAX5_ECX0_EnumOfMonitorMWAITExtensionsInECXAndEDXSupported_EMX;

            string cpuIdEAX5_ECX1_SupportsTreatingInterruptsAsBreakEventsForMWAITEvenWhenInterruptsAreDisabled_IBE = cpuHelper.GetEAX5_ECX1_SupportsTreatingInterruptsAsBreakEventsForMWAITEvenWhenInterruptsAreDisabled_IBEX();
            textBoxEAX5_ECX1_SupportsTreatingInterruptsAsBreakEventsForMWAITEvenWhenInterruptsAreDisabled_IBE.Text = cpuIdEAX5_ECX1_SupportsTreatingInterruptsAsBreakEventsForMWAITEvenWhenInterruptsAreDisabled_IBE;

            string cpuIdEAX5_ECX2_Reserved = cpuHelper.GetEAX5_ECX2_ReservedX();
            textBoxEAX5_ECX2_Reserved.Text = cpuIdEAX5_ECX2_Reserved;

            string cpuIdEAX5_ECX3_AllowMWAITToBeUsedForPowerManagementWithoutSettingUpMemoryMonitoringWithMONITOR_Monitorless_MWAIT = cpuHelper.GetEAX5_ECX3_AllowMWAITToBeUsedForPowerManagementWithoutSettingUpMemoryMonitoringWithMONITOR_Monitorless_MWAITX();
            textBoxEAX5_ECX3_AllowMWAITToBeUsedForPowerManagementWithoutSettingUpMemoryMonitoringWithMONITOR_Monitorless_MWAIT.Text = cpuIdEAX5_ECX3_AllowMWAITToBeUsedForPowerManagementWithoutSettingUpMemoryMonitoringWithMONITOR_Monitorless_MWAIT;

            string cpuIdEAX5_ECX4_31_Reserved = cpuHelper.GetEAX5_ECX4_31_ReservedX();
            textBoxEAX5_ECX4_31_Reserved.Text = cpuIdEAX5_ECX4_31_Reserved;

            string cpuIdEAX5_EDX0_3_NumberOfC0SubStatesSupportedForMWAIT = cpuHelper.GetEAX5_EDX0_3_NumberOfC0SubStatesSupportedForMWAITX();
            textBoxEAX5_EDX0_3_NumberOfC0SubStatesSupportedForMWAIT.Text = cpuIdEAX5_EDX0_3_NumberOfC0SubStatesSupportedForMWAIT;

            string cpuIdEAX5_EDX4_7_NumberOfC1SubStatesSupportedForMWAIT = cpuHelper.GetEAX5_EDX4_7_NumberOfC1SubStatesSupportedForMWAITX();
            textBoxEAX5_EDX4_7_NumberOfC1SubStatesSupportedForMWAIT.Text = cpuIdEAX5_EDX4_7_NumberOfC1SubStatesSupportedForMWAIT;

            string cpuIdEAX5_EDX8_11_NumberOfC2SubStatesSupportedForMWAIT = cpuHelper.GetEAX5_EDX8_11_NumberOfC2SubStatesSupportedForMWAITX();
            textBoxEAX5_EDX8_11_NumberOfC2SubStatesSupportedForMWAIT.Text = cpuIdEAX5_EDX8_11_NumberOfC2SubStatesSupportedForMWAIT;

            string cpuIdEAX5_EDX12_15_NumberOfC3SubStatesSupportedForMWAIT = cpuHelper.GetEAX5_EDX12_15_NumberOfC3SubStatesSupportedForMWAITX();
            textBoxEAX5_EDX12_15_NumberOfC3SubStatesSupportedForMWAIT.Text = cpuIdEAX5_EDX12_15_NumberOfC3SubStatesSupportedForMWAIT;

            string cpuIdEAX5_EDX16_19_NumberOfC4SubStatesSupportedForMWAIT = cpuHelper.GetEAX5_EDX16_19_NumberOfC4SubStatesSupportedForMWAITX();
            textBoxEAX5_EDX16_19_NumberOfC4SubStatesSupportedForMWAIT.Text = cpuIdEAX5_EDX16_19_NumberOfC4SubStatesSupportedForMWAIT;

            string cpuIdEAX5_EDX20_23_NumberOfC5SubStatesSupportedForMWAIT = cpuHelper.GetEAX5_EDX20_23_NumberOfC5SubStatesSupportedForMWAITX();
            textBoxEAX5_EDX20_23_NumberOfC5SubStatesSupportedForMWAIT.Text = cpuIdEAX5_EDX20_23_NumberOfC5SubStatesSupportedForMWAIT;

            string cpuIdEAX5_EDX24_27_NumberOfC6SubStatesSupportedForMWAIT = cpuHelper.GetEAX5_EDX24_27_NumberOfC6SubStatesSupportedForMWAITX();
            textBoxEAX5_EDX24_27_NumberOfC6SubStatesSupportedForMWAIT.Text = cpuIdEAX5_EDX24_27_NumberOfC6SubStatesSupportedForMWAIT;

            string cpuIdEAX5_EDX28_31_NumberOfC7SubStatesSupportedForMWAIT = cpuHelper.GetEAX5_EDX28_31_NumberOfC7SubStatesSupportedForMWAITX();
            textBoxEAX5_EDX28_31_NumberOfC7SubStatesSupportedForMWAIT.Text = cpuIdEAX5_EDX28_31_NumberOfC7SubStatesSupportedForMWAIT;

            #endregion
        }
    }
}
