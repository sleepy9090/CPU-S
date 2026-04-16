using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_S
{
    public partial class FormCPUS : Form
    {
        CPUHelper cpuHelper;

        public FormCPUS()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            GetCPUInfo();
            PopulateCPUInfo();
        }

        private void GetCPUInfo()
        {
            ManagementObject cpu = new ManagementObjectSearcher("SELECT * FROM Win32_Processor")
                                   .Get()
                                   .Cast<ManagementObject>()
                                   .First();

            CPU.AddressWidth = (ushort)cpu["AddressWidth"];
            CPU.Architecture = (ushort)cpu["Architecture"];
            CPU.AssetTag = (string)cpu["AssetTag"];
            CPU.Availability = (ushort)cpu["Availability"];
            CPU.Caption = (string)cpu["Caption"];
            CPU.Characteristics = (uint)cpu["Characteristics"];

            try
            {
                CPU.ConfigManagerErrorCode = (uint)cpu["ConfigManagerErrorCode"];
            }
            catch (Exception ex)
            {
                CPU.ConfigManagerErrorCode = 0;
            }

            try
            {
                CPU.ConfigManagerUserConfig = (bool)cpu["ConfigManagerUserConfig"];
            }
            catch (Exception ex)
            {
                CPU.ConfigManagerUserConfig = false;
            }
            
            CPU.CpuStatus = (ushort)cpu["CpuStatus"];
            CPU.CreationClassName = (string)cpu["CreationClassName"];
            CPU.CurrentClockSpeed = (uint)cpu["CurrentClockSpeed"];
            CPU.CurrentVoltage = (ushort)cpu["CurrentVoltage"];
            CPU.DataWidth = (ushort)cpu["DataWidth"];
            CPU.Description = (string)cpu["Description"];
            CPU.DeviceID = (string)cpu["DeviceID"];

            try
            {
                CPU.ErrorCleared = (bool)cpu["ErrorCleared"];
            }
            catch (Exception ex)
            {
                CPU.ErrorCleared = false;
            }

            try
            {
                CPU.ErrorDescription = (string)cpu["ErrorDescription"];
            }
            catch (Exception ex)
            {
                CPU.ErrorDescription = "";
            }
            
            CPU.ExtClock = (uint)cpu["ExtClock"];
            CPU.Family = (ushort)cpu["Family"];

            try
            {
                CPU.InstallDate = (DateTime)cpu["InstallDate"];
            }
            catch (Exception ex)
            {
                CPU.InstallDate = new DateTime();
            }
            

            CPU.L2CacheSize = (uint)cpu["L2CacheSize"] * 1024;

            try
            {
                CPU.L2CacheSpeed = (uint)cpu["L2CacheSpeed"];
            }
            catch (Exception ex)
            {
                CPU.L2CacheSpeed = 0;
            }
            
            CPU.L3CacheSize = (uint)cpu["L3CacheSize"] * 1024;

            try
            {
                CPU.L3CacheSpeed = (uint)cpu["L3CacheSpeed"];
            }
            catch (Exception ex)
            {
                CPU.L3CacheSpeed = 0;
            }

            try
            {
                CPU.LastErrorCode = (uint)cpu["LastErrorCode"];
            }
            catch (Exception ex)
            {
                CPU.LastErrorCode = 0;
            }

            
            CPU.Level = (ushort)cpu["Level"];
            CPU.LoadPercentage = (ushort)cpu["LoadPercentage"];
            CPU.Manufacturer = (string)cpu["Manufacturer"];
            CPU.MaxClockSpeed = (uint)cpu["MaxClockSpeed"];
            CPU.Name = (string)cpu["Name"];
            CPU.NumberOfCores = (uint)cpu["NumberOfCores"];
            CPU.NumberOfEnabledCore = (uint)cpu["NumberOfEnabledCore"];
            CPU.NumberOfLogicalProcessors = (uint)cpu["NumberOfLogicalProcessors"];
            CPU.OtherFamilyDescription = (string)cpu["OtherFamilyDescription"];
            CPU.PartNumber = (string)cpu["PartNumber"];
            CPU.PNPDeviceID = (string)cpu["PNPDeviceID"];
            CPU.PowerManagementCapabilities = (ushort[])cpu["PowerManagementCapabilities"];
            CPU.PowerManagementSupported = (bool)cpu["PowerManagementSupported"];
            CPU.ProcessorId = (string)cpu["ProcessorId"];
            CPU.ProcessorType = (ushort)cpu["ProcessorType"];

            try
            {
                CPU.Revision = (ushort)cpu["Revision"];
            }
            catch (Exception ex)
            {
                CPU.Revision = 0;
            }
            
            CPU.Role = (string)cpu["Role"];
            CPU.SecondLevelAddressTranslationExtensions = (bool)cpu["SecondLevelAddressTranslationExtensions"];
            CPU.SerialNumber = (string)cpu["SerialNumber"];
            CPU.SocketDesignation = (string)cpu["SocketDesignation"];
            CPU.Status = (string)cpu["Status"];
            CPU.StatusInfo = (ushort)cpu["StatusInfo"];
            CPU.Stepping = (string)cpu["Stepping"];
            CPU.SystemCreationClassName = (string)cpu["SystemCreationClassName"];
            CPU.SystemName = (string)cpu["SystemName"];
            CPU.ThreadCount = (uint)cpu["ThreadCount"];
            CPU.UniqueId = (string)cpu["UniqueId"];
            CPU.UpgradeMethod = (ushort)cpu["UpgradeMethod"];
            CPU.Version = (string)cpu["Version"];
            CPU.VirtualizationFirmwareEnabled = (bool)cpu["VirtualizationFirmwareEnabled"];
            CPU.VMMonitorModeExtensions = (bool)cpu["VMMonitorModeExtensions"];

            try
            {
                CPU.VoltageCaps = (uint)cpu["VoltageCaps"];
            }
            catch (Exception ex)
            {
                CPU.VoltageCaps = 0;
            }
            
        }

        private void PopulateCPUInfo()
        {
            textBoxCPUAddressWidth.Text = $"{CPU.AddressWidth.ToString()} {CPUConstants.BITS}";
            textBoxCPUArchitecture.Text = $"{CPU.Architecture.ToString()} - {cpuHelper.GetArchitecture(CPU.Architecture)}";
            textBoxCPUAssetTag.Text = CPU.AssetTag.ToString();
            textBoxCPUAvailability.Text = $"{CPU.Availability.ToString()} - {cpuHelper.GetAvailability(CPU.Availability)}";
            textBoxCPUCaption.Text = CPU.Caption.ToString();
            textBoxCPUCharacteristics.Text = CPU.Characteristics.ToString();
            textBoxCPUConfigManagerErrorCode.Text = CPU.ConfigManagerErrorCode.ToString();
            textBoxCPUConfigManagerUserConfig.Text = CPU.ConfigManagerUserConfig.ToString();
            textBoxCPUCpuStatus.Text = CPU.CpuStatus.ToString();
            textBoxCPUCreationClassName.Text = CPU.CreationClassName.ToString();
            textBoxCPUCurrentClockSpeed.Text = CPU.CurrentClockSpeed.ToString();
            textBoxCPUCurrentVoltage.Text = CPU.CurrentVoltage.ToString();
            textBoxCPUDataWidth.Text = CPU.DataWidth.ToString();
            textBoxCPUDescription.Text = CPU.Description;
            textBoxCPUDeviceID.Text = CPU.DeviceID.ToString();
            textBoxCPUErrorCleared.Text = CPU.ErrorCleared.ToString();

            if(!String.IsNullOrEmpty(CPU.ErrorDescription))
            {
                textBoxCPUErrorDescription.Text = CPU.ErrorDescription.ToString();
            }

            textBoxCPUExtClock.Text = CPU.ExtClock.ToString();
            textBoxCPUFamily.Text = CPU.Family.ToString();
            textBoxCPUInstallDate.Text = CPU.InstallDate.ToString();
            textBoxCPUL2CacheSize.Text = CPU.L2CacheSize.ToString();
            textBoxCPUL2CacheSpeed.Text = CPU.L2CacheSpeed.ToString();
            textBoxCPUL3CacheSize.Text = CPU.L3CacheSize.ToString();
            textBoxCPUL3CacheSpeed.Text = CPU.L3CacheSpeed.ToString();
            textBoxCPULastErrorCode.Text = CPU.LastErrorCode.ToString();
            textBoxCPULevel.Text = CPU.Level.ToString();
            textBoxCPULoadPercentage.Text = CPU.LoadPercentage.ToString();
            textBoxCPUManufacturer.Text = CPU.Manufacturer.ToString();
            textBoxCPUMaxClockSpeed.Text = CPU.MaxClockSpeed.ToString();
            textBoxCPUName.Text = CPU.Name;
            textBoxCPUNumberOfCores.Text = CPU.NumberOfCores.ToString();
            textBoxCPUNumberOfEnabledCore.Text = CPU.NumberOfEnabledCore.ToString();
            textBoxCPUNumberOfLogicalProcessors.Text = CPU.NumberOfLogicalProcessors.ToString();

            if (!String.IsNullOrEmpty(CPU.OtherFamilyDescription))
            {
                textBoxCPUOtherFamilyDescription.Text = CPU.OtherFamilyDescription.ToString();
            }
            
            textBoxCPUPartNumber.Text = CPU.PartNumber.ToString();
            textBoxCPUPNPDeviceID.Text = CPU.DeviceID.ToString();

            if ((null != CPU.PowerManagementCapabilities))
            {
                foreach (ushort capability in CPU.PowerManagementCapabilities)
                {
                    textBoxCPUPowerManagementCapabilities.Text += capability.ToString() + ", ";
                }
                
            }
            
            textBoxCPUPowerManagementSupported.Text = CPU.PowerManagementSupported.ToString();
            textBoxCPUProcessorId.Text = CPU.ProcessorId;
            textBoxCPUProcessorType.Text = CPU.ProcessorType.ToString();
            textBoxCPURevision.Text = CPU.Revision.ToString();
            textBoxCPURole.Text = CPU.Role.ToString();
            textBoxCPUSecondLevelAddressTranslationExtensions.Text = CPU.SecondLevelAddressTranslationExtensions.ToString();
            textBoxCPUSerialNumber.Text = CPU.SerialNumber.ToString();
            textBoxCPUSocketDesignation.Text = CPU.SocketDesignation;
            textBoxCPUStatus.Text = CPU.Status.ToString();
            textBoxCPUStatusInfo.Text = CPU.StatusInfo.ToString();
            textBoxCPUStepping.Text = CPU.StatusInfo.ToString();
            textBoxCPUSystemCreationClassName.Text = CPU.SystemCreationClassName.ToString();
            textBoxCPUSystemName.Text = CPU.SystemName.ToString();
            textBoxCPUThreadCount.Text = CPU.ThreadCount.ToString();

            if (!String.IsNullOrEmpty(CPU.UniqueId))
            {
                textBoxCPUUniqueId.Text = CPU.UniqueId.ToString();
            }
            
            textBoxCPUUpgradeMethod.Text = CPU.UpgradeMethod.ToString();
            textBoxCPUVersion.Text = CPU.Version.ToString();
            textBoxCPUVirtualizationFirmwareEnabled.Text = CPU.VirtualizationFirmwareEnabled.ToString();
            textBoxCPUVMMonitorModeExtensions.Text = CPU.VMMonitorModeExtensions.ToString();
            textBoxCPUVoltageCaps.Text = CPU.VoltageCaps.ToString();
        }
    }
}
