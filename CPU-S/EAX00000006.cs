/*
    File           EAX00000006.cs
    Brief          Form for displaying EAX=0x00000006 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           11/01/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX00000006 : Form
    {

        private CPUHelper cpuHelper;

        public EAX00000006()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x00000006: Thermal and Power Management

            textBoxeAX00000006EAX.Text = cpuHelper.GetEAX00000006EAXX();
            textBoxeAX00000006EBX.Text = cpuHelper.GetEAX00000006EBXX();
            textBoxeAX00000006ECX.Text = cpuHelper.GetEAX00000006ECXX();
            textBoxeAX00000006EDX.Text = cpuHelper.GetEAX00000006EDXX();

            //EAX
            bool cpuIdeAX00000006EAX0_DTSIsSupported = cpuHelper.GetEAX00000006EAX0_DTSIsSupportedX();
            checkBoxDTS0.Checked = cpuIdeAX00000006EAX0_DTSIsSupported;

            bool cpuIdeAX00000006EAX1_TURBO_BOOSTIsSupported = cpuHelper.GetEAX00000006EAX1_TURBO_BOOSTIsSupportedX();
            checkBoxTurboBoost1.Checked = cpuIdeAX00000006EAX1_TURBO_BOOSTIsSupported;

            bool cpuIdeAX00000006EAX2_ARATIsSupported = cpuHelper.GetEAX00000006EAX2_ARATIsSupportedX();
            checkBoxARAT2.Checked = cpuIdeAX00000006EAX2_ARATIsSupported;

            bool cpuIdeAX00000006EAX3_ReservedIsSupported = cpuHelper.GetEAX00000006EAX3_ReservedIsSupportedX();
            checkBoxReserved3.Checked = cpuIdeAX00000006EAX3_ReservedIsSupported;

            bool cpuIdeAX00000006EAX4_PowerLimitNotificationCapability_PLNIsSupported = cpuHelper.GetEAX00000006EAX4_PowerLimitNotificationCapability_PLNIsSupportedX();
            checkBoxPLN4.Checked = cpuIdeAX00000006EAX4_PowerLimitNotificationCapability_PLNIsSupported;

            bool cpuIdeAX00000006EAX5_ExtendedClockModulationDutyCapability_ECMDIsSupported = cpuHelper.GetEAX00000006EAX5_ExtendedClockModulationDutyCapability_ECMDIsSupportedX();
            checkBoxECMD5.Checked = cpuIdeAX00000006EAX5_ExtendedClockModulationDutyCapability_ECMDIsSupported;

            bool cpuIdeAX00000006eAX00000006_PackageThermalManagementCapability_PTMIsSupported = cpuHelper.GetEAX00000006eAX00000006_PackageThermalManagementCapability_PTMIsSupportedX();
            checkBoxPTM6.Checked = cpuIdeAX00000006eAX00000006_PackageThermalManagementCapability_PTMIsSupported;

            bool cpuIdeAX00000006EAX7_HardwareControlledPerformanceStatesCapability_HWPIsSupported = cpuHelper.GetEAX00000006EAX7_HardwareControlledPerformanceStatesCapability_HWPIsSupportedX();
            checkBoxHWP7.Checked = cpuIdeAX00000006EAX7_HardwareControlledPerformanceStatesCapability_HWPIsSupported;

            bool cpuIdeAX00000006EAX8_HWPNotificationCapability_HWP_NotificationIsSupported = cpuHelper.GetEAX00000006EAX8_HWPNotificationCapability_HWP_NotificationIsSupportedX();
            checkBoxHWPNotification8.Checked = cpuIdeAX00000006EAX8_HWPNotificationCapability_HWP_NotificationIsSupported;

            bool cpuIdeAX00000006EAX9_HWPActivityWindowCapability_HWP_Activity_WindowIsSupported = cpuHelper.GetEAX00000006EAX9_HWPActivityWindowCapability_HWP_Activity_WindowIsSupportedX();
            checkBoxHWPActivityWindow9.Checked = cpuIdeAX00000006EAX9_HWPActivityWindowCapability_HWP_Activity_WindowIsSupported;

            bool cpuIdeAX00000006EAX10_HWPEnergyPerformancePreferenceCapability_HWP_Energy_Performance_PreferenceIsSupported = cpuHelper.GetEAX00000006EAX10_HWPEnergyPerformancePreferenceCapability_HWP_Energy_Performance_PreferenceIsSupportedX();
            checkBoxHWPEnergyPerformancePreference10.Checked = cpuIdeAX00000006EAX10_HWPEnergyPerformancePreferenceCapability_HWP_Energy_Performance_PreferenceIsSupported;

            bool cpuIdeAX00000006EAX11_HWPPackageLevelRequestCapability_HWP_Package_Level_RequestIsSupported = cpuHelper.GetEAX00000006EAX11_HWPPackageLevelRequestCapability_HWP_Package_Level_RequestIsSupportedX();
            checkBoxHWPPackageLevelRequest11.Checked = cpuIdeAX00000006EAX11_HWPPackageLevelRequestCapability_HWP_Package_Level_RequestIsSupported;

            bool cpuIdeAX00000006EAX12_ReservedIsSupported = cpuHelper.GetEAX00000006EAX12_ReservedIsSupportedX();
            checkBoxReserved12.Checked = cpuIdeAX00000006EAX12_ReservedIsSupported;

            bool cpuIdeAX00000006EAX13_HardwareDutyCyclingCapability_HDCIsSupported = cpuHelper.GetEAX00000006EAX13_HardwareDutyCyclingCapability_HDCIsSupportedX();
            checkBoxHDC13.Checked = cpuIdeAX00000006EAX13_HardwareDutyCyclingCapability_HDCIsSupported;

            bool cpuIdeAX00000006EAX14_IntelTurboBoostMaxTechnology30Availability_TURBO_BOOST_MAXIsSupported = cpuHelper.GetEAX00000006EAX14_IntelTurboBoostMaxTechnology30Availability_TURBO_BOOST_MAXIsSupportedX();
            checkBoxTurboBoostMax14.Checked = cpuIdeAX00000006EAX14_IntelTurboBoostMaxTechnology30Availability_TURBO_BOOST_MAXIsSupported;

            bool cpuIdeAX00000006EAX15_HWP_CAPIsSupported = cpuHelper.GetEAX00000006EAX15_HWP_CAPIsSupportedX();
            checkBoxHwpCap15.Checked = cpuIdeAX00000006EAX15_HWP_CAPIsSupported;

            bool cpuIdeAX00000006EAX16_HWP_PECI_OVERRIDEIsSupported = cpuHelper.GetEAX00000006EAX16_HWP_PECI_OVERRIDEIsSupportedX();
            checkBoxHwpPeciOverride16.Checked = cpuIdeAX00000006EAX16_HWP_PECI_OVERRIDEIsSupported;

            bool cpuIdeAX00000006EAX17_FlexibleHWPIsSupported = cpuHelper.GetEAX00000006EAX17_FlexibleHWPIsSupportedX();
            checkBoxFlexibleHwp17.Checked = cpuIdeAX00000006EAX17_FlexibleHWPIsSupported;

            bool cpuIdeAX00000006EAX18_HWP_REQUEST_FAST_ACCESSIsSupported = cpuHelper.GetEAX00000006EAX18_HWP_REQUEST_FAST_ACCESSIsSupportedX();
            checkBoxHwpRequestFastAccess18.Checked = cpuIdeAX00000006EAX18_HWP_REQUEST_FAST_ACCESSIsSupported;

            bool cpuIdeAX00000006EAX19_HW_FEEDBACKIsSupported = cpuHelper.GetEAX00000006EAX19_HW_FEEDBACKIsSupportedX();
            checkBoxHardwareFeedbackInterface19.Checked = cpuIdeAX00000006EAX19_HW_FEEDBACKIsSupported;

            bool cpuIdeAX00000006EAX20_HWP_REQUEST_IGNORE_IDLEIsSupported = cpuHelper.GetEAX00000006EAX20_HWP_REQUEST_IGNORE_IDLEIsSupportedX();
            checkBoxHwpRequestIgnoreIdle20.Checked = cpuIdeAX00000006EAX20_HWP_REQUEST_IGNORE_IDLEIsSupported;

            bool cpuIdeAX00000006EAX21_ReservedIsSupported = cpuHelper.GetEAX00000006EAX21_ReservedIsSupportedX();
            checkBoxReserved21.Checked = cpuIdeAX00000006EAX21_ReservedIsSupported;

            bool cpuIdeAX00000006EAX22_HWP_CTLIsSupported = cpuHelper.GetEAX00000006EAX22_HWP_CTLIsSupportedX();
            checkBoxHwpControlMsr22.Checked = cpuIdeAX00000006EAX22_HWP_CTLIsSupported;

            bool cpuIdeAX00000006EAX23_THREAD_DIRECTORIsSupported = cpuHelper.GetEAX00000006EAX23_THREAD_DIRECTORIsSupportedX();
            checkBoxThreadDirector23.Checked = cpuIdeAX00000006EAX23_THREAD_DIRECTORIsSupported;

            bool cpuIdeAX00000006EAX24_IA32_THERM_INTERRUPTIsSupported = cpuHelper.GetEAX00000006EAX24_IA32_THERM_INTERRUPTIsSupportedX();
            checkBoxIa32ThermInterrupt24.Checked = cpuIdeAX00000006EAX24_IA32_THERM_INTERRUPTIsSupported;

            bool cpuIdeAX00000006EAX25_ReservedIsSupported = cpuHelper.GetEAX00000006EAX25_ReservedIsSupportedX();
            checkBoxReserved25.Checked = cpuIdeAX00000006EAX25_ReservedIsSupported;

            bool cpuIdeAX00000006EAX26_ReservedIsSupported = cpuHelper.GetEAX00000006EAX26_ReservedIsSupportedX();
            checkBoxReserved26.Checked = cpuIdeAX00000006EAX26_ReservedIsSupported;

            bool cpuIdeAX00000006EAX27_ReservedIsSupported = cpuHelper.GetEAX00000006EAX27_ReservedIsSupportedX();
            checkBoxReserved27.Checked = cpuIdeAX00000006EAX27_ReservedIsSupported;

            bool cpuIdeAX00000006EAX28_ReservedIsSupported = cpuHelper.GetEAX00000006EAX28_ReservedIsSupportedX();
            checkBoxReserved28.Checked = cpuIdeAX00000006EAX28_ReservedIsSupported;

            bool cpuIdeAX00000006EAX29_ReservedIsSupported = cpuHelper.GetEAX00000006EAX29_ReservedIsSupportedX();
            checkBoxReserved29.Checked = cpuIdeAX00000006EAX29_ReservedIsSupported;

            bool cpuIdeAX00000006EAX30_ReservedIsSupported = cpuHelper.GetEAX00000006EAX30_ReservedIsSupportedX();
            checkBoxReserved30.Checked = cpuIdeAX00000006EAX30_ReservedIsSupported;

            bool cpuIdeAX00000006EAX31_ReservedIsSupported = cpuHelper.GetEAX00000006EAX31_ReservedIsSupportedX();
            checkBoxReserved31.Checked = cpuIdeAX00000006EAX31_ReservedIsSupported;

            //EBX
            textBoxeAX00000006_EBX0_3_NumberOfInterruptThresholdsInDigitalThermalSensor.Text = cpuHelper.GetEAX00000006_EBX0_3_NumberOfInterruptThresholdsInDigitalThermalSensorX();
            textBoxeAX00000006_EBX4_31_Reserved.Text = cpuHelper.GetEAX00000006_EBX4_31_ReservedX();

            //ECX
            bool cpuIdeAX00000006ECX0_EffectiveFrequencyInterfaceIsSupported = cpuHelper.GetEAX00000006ECX0_EffectiveFrequencyInterfaceIsSupportedX();
            checkBoxEffectiveFrequencyInterface0.Checked = cpuIdeAX00000006ECX0_EffectiveFrequencyInterfaceIsSupported;

            bool cpuIdeAX00000006ECX1_ACNT2CapabilityIsSupported = cpuHelper.GetEAX00000006ECX1_ACNT2CapabilityIsSupportedX();
            checkBoxACNT21.Checked = cpuIdeAX00000006ECX1_ACNT2CapabilityIsSupported;

            bool cpuIdeAX00000006ECX2_ReservedIsSupported = cpuHelper.GetEAX00000006ECX2_ReservedIsSupportedX();
            checkBoxReserved2.Checked = cpuIdeAX00000006ECX2_ReservedIsSupported;

            bool cpuIdeAX00000006ECX3_PerformanceEnergyBiasCapabilityMSRIsSupported = cpuHelper.GetEAX00000006ECX3_PerformanceEnergyBiasCapabilityMSRIsSupportedX();
            checkBoxPerformanceEnergyBiasCapability3.Checked = cpuIdeAX00000006ECX3_PerformanceEnergyBiasCapabilityMSRIsSupported;

            string cpuIdeAX00000006ECX4_7_Reserved = cpuHelper.GetEAX00000006ECX4_7_ReservedX();
            textBoxeAX00000006ECX4_7_Reserved.Text = cpuIdeAX00000006ECX4_7_Reserved;

            string cpuIdeAX00000006ECX8_15_NumberOfIntelThreadDirectorClasses = cpuHelper.GetEAX00000006ECX8_15_NumberOfIntelThreadDirectorClassesX();
            textBoxeAX00000006ECX8_15_NumberOfIntelThreadDirectorClasses.Text = cpuIdeAX00000006ECX8_15_NumberOfIntelThreadDirectorClasses;

            string cpuIdeAX00000006ECX16_31_Reserved = cpuHelper.GetEAX00000006ECX16_31_ReservedX();
            textBoxeAX00000006ECX16_31_Reserved.Text = cpuIdeAX00000006ECX16_31_Reserved;

            //EDX
            bool cpuIdeAX00000006EDX0_HardwareFeedbackReportingPerformanceCapabilityReportingIsSupported = cpuHelper.GetEAX00000006EDX0_HardwareFeedbackReportingPerformanceCapabilityReportingIsSupportedX();
            checkBoxPerformanceCapabilitySupported0.Checked = cpuIdeAX00000006EDX0_HardwareFeedbackReportingPerformanceCapabilityReportingIsSupported;

            bool cpuIdeAX00000006EDX1_HardwareFeedbackReportingEfficiencyCapabilityReportingIsSupported = cpuHelper.GetEAX00000006EDX1_HardwareFeedbackReportingEfficiencyCapabilityReportingIsSupportedX();
            checkBoxEfficiencyReportingSupported1.Checked = cpuIdeAX00000006EDX1_HardwareFeedbackReportingEfficiencyCapabilityReportingIsSupported;

            string cpuIdeAX00000006EDX2_7_Reserved = cpuHelper.GetEAX00000006EDX2_7_ReservedX();
            textBoxeAX00000006EDX2_7_Reserved.Text = cpuIdeAX00000006EDX2_7_Reserved;

            string cpuIdeAX00000006EDX8_11_SizeOfHardwareFeedbackInterfaceStructure = cpuHelper.GetEAX00000006EDX8_11_SizeOfHardwareFeedbackInterfaceStructureX();
            textBoxeAX00000006EDX8_11_SizeOfHardwareFeedbackInterfaceStructure.Text = cpuIdeAX00000006EDX8_11_SizeOfHardwareFeedbackInterfaceStructure;

            string cpuIdeAX00000006EDX12_15_Reserved = cpuHelper.GetEAX00000006EDX12_15_ReservedX();
            textBoxeAX00000006EDX12_15_Reserved.Text = cpuIdeAX00000006EDX12_15_Reserved;

            string cpuIdeAX00000006EDX16_31_IndexOfThisLogicalProcessorsRowInHardwareFeedbackInterfaceStructure = cpuHelper.GetEAX00000006EDX16_31_IndexOfThisLogicalProcessorsRowInHardwareFeedbackInterfaceStructureX();
            textBoxeAX00000006EDX16_31_IndexOfThisLogicalProcessorsRowInHardwareFeedbackInterfaceStructure.Text = cpuIdeAX00000006EDX16_31_IndexOfThisLogicalProcessorsRowInHardwareFeedbackInterfaceStructure;

            #endregion
        }
    }
}
