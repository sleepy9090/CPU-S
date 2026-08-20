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
    public partial class EAX6 : Form
    {

        private CPUHelper cpuHelper;

        public EAX6()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x6: Thermal and Power Management

            string cpuIdEAX6EAX = cpuHelper.GetEAX6EAXX();
            textBoxEAX6EAX.Text = cpuIdEAX6EAX;

            string cpuIdEAX6EBX = cpuHelper.GetEAX6EBXX();
            textBoxEAX6EBX.Text = cpuIdEAX6EBX;

            string cpuIdEAX6ECX = cpuHelper.GetEAX6ECXX();
            textBoxEAX6ECX.Text = cpuIdEAX6ECX;

            string cpuIdEAX6EDX = cpuHelper.GetEAX6EDXX();
            textBoxEAX6EDX.Text = cpuIdEAX6EDX;

            bool cpuIdEAX6EAX0_DTSIsSupported = cpuHelper.GetEAX6EAX0_DTSIsSupportedX();
            checkBoxDTS0.Checked = cpuIdEAX6EAX0_DTSIsSupported;

            bool cpuIdEAX6EAX1_TURBO_BOOSTIsSupported = cpuHelper.GetEAX6EAX1_TURBO_BOOSTIsSupportedX();
            checkBoxTurboBoost1.Checked = cpuIdEAX6EAX1_TURBO_BOOSTIsSupported;

            bool cpuIdEAX6EAX2_ARATIsSupported = cpuHelper.GetEAX6EAX2_ARATIsSupportedX();
            checkBoxARAT2.Checked = cpuIdEAX6EAX2_ARATIsSupported;

            bool cpuIdEAX6EAX3_ReservedIsSupported = cpuHelper.GetEAX6EAX3_ReservedIsSupportedX();
            checkBoxReserved3.Checked = cpuIdEAX6EAX3_ReservedIsSupported;

            bool cpuIdEAX6EAX4_PowerLimitNotificationCapability_PLNIsSupported = cpuHelper.GetEAX6EAX4_PowerLimitNotificationCapability_PLNIsSupportedX();
            checkBoxPLN4.Checked = cpuIdEAX6EAX4_PowerLimitNotificationCapability_PLNIsSupported;

            bool cpuIdEAX6EAX5_ExtendedClockModulationDutyCapability_ECMDIsSupported = cpuHelper.GetEAX6EAX5_ExtendedClockModulationDutyCapability_ECMDIsSupportedX();
            checkBoxECMD5.Checked = cpuIdEAX6EAX5_ExtendedClockModulationDutyCapability_ECMDIsSupported;

            bool cpuIdEAX6EAX6_PackageThermalManagementCapability_PTMIsSupported = cpuHelper.GetEAX6EAX6_PackageThermalManagementCapability_PTMIsSupportedX();
            checkBoxPTM6.Checked = cpuIdEAX6EAX6_PackageThermalManagementCapability_PTMIsSupported;

            bool cpuIdEAX6EAX7_HardwareControlledPerformanceStatesCapability_HWPIsSupported = cpuHelper.GetEAX6EAX7_HardwareControlledPerformanceStatesCapability_HWPIsSupportedX();
            checkBoxHWP7.Checked = cpuIdEAX6EAX7_HardwareControlledPerformanceStatesCapability_HWPIsSupported;

            bool cpuIdEAX6EAX8_HWPNotificationCapability_HWP_NotificationIsSupported = cpuHelper.GetEAX6EAX8_HWPNotificationCapability_HWP_NotificationIsSupportedX();
            checkBoxHWPNotification8.Checked = cpuIdEAX6EAX8_HWPNotificationCapability_HWP_NotificationIsSupported;

            bool cpuIdEAX6EAX9_HWPActivityWindowCapability_HWP_Activity_WindowIsSupported = cpuHelper.GetEAX6EAX9_HWPActivityWindowCapability_HWP_Activity_WindowIsSupportedX();
            checkBoxHWPActivityWindow9.Checked = cpuIdEAX6EAX9_HWPActivityWindowCapability_HWP_Activity_WindowIsSupported;

            bool cpuIdEAX6EAX10_HWPEnergyPerformancePreferenceCapability_HWP_Energy_Performance_PreferenceIsSupported = cpuHelper.GetEAX6EAX10_HWPEnergyPerformancePreferenceCapability_HWP_Energy_Performance_PreferenceIsSupportedX();
            checkBoxHWPEnergyPerformancePreference10.Checked = cpuIdEAX6EAX10_HWPEnergyPerformancePreferenceCapability_HWP_Energy_Performance_PreferenceIsSupported;

            bool cpuIdEAX6EAX11_HWPPackageLevelRequestCapability_HWP_Package_Level_RequestIsSupported = cpuHelper.GetEAX6EAX11_HWPPackageLevelRequestCapability_HWP_Package_Level_RequestIsSupportedX();
            checkBoxHWPPackageLevelRequest11.Checked = cpuIdEAX6EAX11_HWPPackageLevelRequestCapability_HWP_Package_Level_RequestIsSupported;

            bool cpuIdEAX6EAX12_ReservedIsSupported = cpuHelper.GetEAX6EAX12_ReservedIsSupportedX();
            checkBoxReserved12.Checked = cpuIdEAX6EAX12_ReservedIsSupported;

            bool cpuIdEAX6EAX13_HardwareDutyCyclingCapability_HDCIsSupported = cpuHelper.GetEAX6EAX13_HardwareDutyCyclingCapability_HDCIsSupportedX();
            checkBoxHDC13.Checked = cpuIdEAX6EAX13_HardwareDutyCyclingCapability_HDCIsSupported;

            bool cpuIdEAX6EAX14_IntelTurboBoostMaxTechnology30Availability_TURBO_BOOST_MAXIsSupported = cpuHelper.GetEAX6EAX14_IntelTurboBoostMaxTechnology30Availability_TURBO_BOOST_MAXIsSupportedX();
            checkBoxTurboBoostMax14.Checked = cpuIdEAX6EAX14_IntelTurboBoostMaxTechnology30Availability_TURBO_BOOST_MAXIsSupported;

            bool cpuIdEAX6EAX15_HWP_CAPIsSupported = cpuHelper.GetEAX6EAX15_HWP_CAPIsSupportedX();
            checkBoxHwpCap15.Checked = cpuIdEAX6EAX15_HWP_CAPIsSupported;

            bool cpuIdEAX6EAX16_HWP_PECI_OVERRIDEIsSupported = cpuHelper.GetEAX6EAX16_HWP_PECI_OVERRIDEIsSupportedX();
            checkBoxHwpPeciOverride16.Checked = cpuIdEAX6EAX16_HWP_PECI_OVERRIDEIsSupported;

            bool cpuIdEAX6EAX17_FlexibleHWPIsSupported = cpuHelper.GetEAX6EAX17_FlexibleHWPIsSupportedX();
            checkBoxFlexibleHwp17.Checked = cpuIdEAX6EAX17_FlexibleHWPIsSupported;

            bool cpuIdEAX6EAX18_HWP_REQUEST_FAST_ACCESSIsSupported = cpuHelper.GetEAX6EAX18_HWP_REQUEST_FAST_ACCESSIsSupportedX();
            checkBoxHwpRequestFastAccess18.Checked = cpuIdEAX6EAX18_HWP_REQUEST_FAST_ACCESSIsSupported;

            bool cpuIdEAX6EAX19_HW_FEEDBACKIsSupported = cpuHelper.GetEAX6EAX19_HW_FEEDBACKIsSupportedX();
            checkBoxHardwareFeedbackInterface19.Checked = cpuIdEAX6EAX19_HW_FEEDBACKIsSupported;

            bool cpuIdEAX6EAX20_HWP_REQUEST_IGNORE_IDLEIsSupported = cpuHelper.GetEAX6EAX20_HWP_REQUEST_IGNORE_IDLEIsSupportedX();
            checkBoxHwpRequestIgnoreIdle20.Checked = cpuIdEAX6EAX20_HWP_REQUEST_IGNORE_IDLEIsSupported;

            bool cpuIdEAX6EAX21_ReservedIsSupported = cpuHelper.GetEAX6EAX21_ReservedIsSupportedX();
            checkBoxReserved21.Checked = cpuIdEAX6EAX21_ReservedIsSupported;

            bool cpuIdEAX6EAX22_HWP_CTLIsSupported = cpuHelper.GetEAX6EAX22_HWP_CTLIsSupportedX();
            checkBoxHwpControlMsr22.Checked = cpuIdEAX6EAX22_HWP_CTLIsSupported;

            bool cpuIdEAX6EAX23_THREAD_DIRECTORIsSupported = cpuHelper.GetEAX6EAX23_THREAD_DIRECTORIsSupportedX();
            checkBoxThreadDirector23.Checked = cpuIdEAX6EAX23_THREAD_DIRECTORIsSupported;

            bool cpuIdEAX6EAX24_IA32_THERM_INTERRUPTIsSupported = cpuHelper.GetEAX6EAX24_IA32_THERM_INTERRUPTIsSupportedX();
            checkBoxIa32ThermInterrupt24.Checked = cpuIdEAX6EAX24_IA32_THERM_INTERRUPTIsSupported;

            bool cpuIdEAX6EAX25_ReservedIsSupported = cpuHelper.GetEAX6EAX25_ReservedIsSupportedX();
            checkBoxReserved25.Checked = cpuIdEAX6EAX25_ReservedIsSupported;

            bool cpuIdEAX6EAX26_ReservedIsSupported = cpuHelper.GetEAX6EAX26_ReservedIsSupportedX();
            checkBoxReserved26.Checked = cpuIdEAX6EAX26_ReservedIsSupported;

            bool cpuIdEAX6EAX27_ReservedIsSupported = cpuHelper.GetEAX6EAX27_ReservedIsSupportedX();
            checkBoxReserved27.Checked = cpuIdEAX6EAX27_ReservedIsSupported;

            bool cpuIdEAX6EAX28_ReservedIsSupported = cpuHelper.GetEAX6EAX28_ReservedIsSupportedX();
            checkBoxReserved28.Checked = cpuIdEAX6EAX28_ReservedIsSupported;

            bool cpuIdEAX6EAX29_ReservedIsSupported = cpuHelper.GetEAX6EAX29_ReservedIsSupportedX();
            checkBoxReserved29.Checked = cpuIdEAX6EAX29_ReservedIsSupported;

            bool cpuIdEAX6EAX30_ReservedIsSupported = cpuHelper.GetEAX6EAX30_ReservedIsSupportedX();
            checkBoxReserved30.Checked = cpuIdEAX6EAX30_ReservedIsSupported;

            bool cpuIdEAX6EAX31_ReservedIsSupported = cpuHelper.GetEAX6EAX31_ReservedIsSupportedX();
            checkBoxReserved31.Checked = cpuIdEAX6EAX31_ReservedIsSupported;

            string cpuIdEAX6EAX6_EBX0_3_NumberOfInterruptThresholdsInDigitalThermalSensor = cpuHelper.GetEAX6_EBX0_3_NumberOfInterruptThresholdsInDigitalThermalSensorX();
            textBoxEAX6_EBX0_3_NumberOfInterruptThresholdsInDigitalThermalSensor.Text = cpuIdEAX6EAX6_EBX0_3_NumberOfInterruptThresholdsInDigitalThermalSensor;

            string cpuIdEAX6EAX6_EBX4_31_Reserved = cpuHelper.GetEAX6_EBX4_31_ReservedX();
            textBoxEAX6_EBX4_31_Reserved.Text = cpuIdEAX6EAX6_EBX4_31_Reserved;

            bool cpuIdEAX6ECX0_EffectiveFrequencyInterfaceIsSupported = cpuHelper.GetEAX6ECX0_EffectiveFrequencyInterfaceIsSupportedX();
            checkBoxEffectiveFrequencyInterface0.Checked = cpuIdEAX6ECX0_EffectiveFrequencyInterfaceIsSupported;

            bool cpuIdEAX6ECX1_ACNT2CapabilityIsSupported = cpuHelper.GetEAX6ECX1_ACNT2CapabilityIsSupportedX();
            checkBoxACNT21.Checked = cpuIdEAX6ECX1_ACNT2CapabilityIsSupported;

            bool cpuIdEAX6ECX2_ReservedIsSupported = cpuHelper.GetEAX6ECX2_ReservedIsSupportedX();
            checkBoxReserved2.Checked = cpuIdEAX6ECX2_ReservedIsSupported;

            bool cpuIdEAX6ECX3_PerformanceEnergyBiasCapabilityMSRIsSupported = cpuHelper.GetEAX6ECX3_PerformanceEnergyBiasCapabilityMSRIsSupportedX();
            checkBoxPerformanceEnergyBiasCapability3.Checked = cpuIdEAX6ECX3_PerformanceEnergyBiasCapabilityMSRIsSupported;

            string cpuIdEAX6ECX4_7_Reserved = cpuHelper.GetEAX6ECX4_7_ReservedX();
            textBoxEAX6ECX4_7_Reserved.Text = cpuIdEAX6ECX4_7_Reserved;

            string cpuIdEAX6ECX8_15_NumberOfIntelThreadDirectorClasses = cpuHelper.GetEAX6ECX8_15_NumberOfIntelThreadDirectorClassesX();
            textBoxEAX6ECX8_15_NumberOfIntelThreadDirectorClasses.Text = cpuIdEAX6ECX8_15_NumberOfIntelThreadDirectorClasses;

            string cpuIdEAX6ECX16_31_Reserved = cpuHelper.GetEAX6ECX16_31_ReservedX();
            textBoxEAX6ECX16_31_Reserved.Text = cpuIdEAX6ECX16_31_Reserved;

            bool cpuIdEAX6EDX0_HardwareFeedbackReportingPerformanceCapabilityReportingIsSupported = cpuHelper.GetEAX6EDX0_HardwareFeedbackReportingPerformanceCapabilityReportingIsSupportedX();
            checkBoxPerformanceCapabilitySupported0.Checked = cpuIdEAX6EDX0_HardwareFeedbackReportingPerformanceCapabilityReportingIsSupported;

            bool cpuIdEAX6EDX1_HardwareFeedbackReportingEfficiencyCapabilityReportingIsSupported = cpuHelper.GetEAX6EDX1_HardwareFeedbackReportingEfficiencyCapabilityReportingIsSupportedX();
            checkBoxEfficiencyReportingSupported1.Checked = cpuIdEAX6EDX1_HardwareFeedbackReportingEfficiencyCapabilityReportingIsSupported;

            string cpuIdEAX6EDX2_7_Reserved = cpuHelper.GetEAX6EDX2_7_ReservedX();
            textBoxEAX6EDX2_7_Reserved.Text = cpuIdEAX6EDX2_7_Reserved;

            string cpuIdEAX6EDX8_11_SizeOfHardwareFeedbackInterfaceStructure = cpuHelper.GetEAX6EDX8_11_SizeOfHardwareFeedbackInterfaceStructureX();
            textBoxEAX6EDX8_11_SizeOfHardwareFeedbackInterfaceStructure.Text = cpuIdEAX6EDX8_11_SizeOfHardwareFeedbackInterfaceStructure;

            string cpuIdEAX6EDX12_15_Reserved = cpuHelper.GetEAX6EDX12_15_ReservedX();
            textBoxEAX6EDX12_15_Reserved.Text = cpuIdEAX6EDX12_15_Reserved;

            string cpuIdEAX6EDX16_31_IndexOfThisLogicalProcessorsRowInHardwareFeedbackInterfaceStructure = cpuHelper.GetEAX6EDX16_31_IndexOfThisLogicalProcessorsRowInHardwareFeedbackInterfaceStructureX();
            textBoxEAX6EDX16_31_IndexOfThisLogicalProcessorsRowInHardwareFeedbackInterfaceStructure.Text = cpuIdEAX6EDX16_31_IndexOfThisLogicalProcessorsRowInHardwareFeedbackInterfaceStructure;

            #endregion
        }
    }
}
