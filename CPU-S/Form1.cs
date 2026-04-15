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
        public FormCPUS()
        {
            InitializeComponent();
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
            CPU.ConfigManagerErrorCode = (uint)cpu["ConfigManagerErrorCode"];
            CPU.ConfigManagerUserConfig = (bool)cpu["ConfigManagerUserConfig"];
            CPU.CpuStatus = (ushort)cpu["CpuStatus"];
            CPU.CreationClassName = (string)cpu["CreationClassName"];
            CPU.CurrentClockSpeed = (uint)cpu["CurrentClockSpeed"];
            CPU.CurrentVoltage = (ushort)cpu["CurrentVoltage"];
            CPU.DataWidth = (ushort)cpu["DataWidth"];
            CPU.Description = (string)cpu["Description"];
            CPU.DeviceID = (string)cpu["DeviceID"];
            CPU.ErrorCleared = (bool)cpu["ErrorCleared"];
            CPU.ErrorDescription = (string)cpu["ErrorDescription"];
            CPU.ExtClock = (uint)cpu["ExtClock"];
            CPU.Family = (ushort)cpu["Family"];
            CPU.InstallDate = (DateTime)cpu["InstallDate"];
            CPU.L2CacheSize = (uint)cpu["L2CacheSize"] * 1024;
            CPU.L2CacheSpeed = (uint)cpu["L2CacheSpeed"];
            CPU.L3CacheSize = (uint)cpu["L3CacheSize"] * 1024;
            CPU.L3CacheSpeed = (uint)cpu["L3CacheSpeed"];
            CPU.LastErrorCode = (uint)cpu["LastErrorCode"];
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
            CPU.Revision = (ushort)cpu["Revision"];
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
            CPU.VoltageCaps = (uint)cpu["VoltageCaps"];
        }

        private void PopulateCPUInfo()
        {
            textBoxCPUAddressWidth.Text = CPU.AddressWidth.ToString();
            textBoxCPUArchitecture.Text = CPU.Architecture.ToString();
            textBoxCPUDataWidth.Text = CPU.DataWidth.ToString();
            textBoxCPUDescription.Text = CPU.Description;
            textBoxCPUExtClock.Text = CPU.ExtClock.ToString();
            textBoxCPUL2CacheSize.Text = CPU.L2CacheSize.ToString();
            textBoxCPUL3CacheSize.Text = CPU.L3CacheSize.ToString();
            textBoxCPUMaxClockSpeed.Text = CPU.MaxClockSpeed.ToString();
            textBoxCPUName.Text = CPU.Name;
            textBoxCPUNumberOfCores.Text = CPU.NumberOfCores.ToString();
            textBoxCPUNumberOfLogicalProcessors.Text = CPU.NumberOfLogicalProcessors.ToString();
            textBoxCPUProcessorId.Text = CPU.ProcessorId;
            textBoxCPUSocketDesignation.Text = CPU.SocketDesignation;
        }
    }
}
