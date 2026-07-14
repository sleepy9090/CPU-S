using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Timer = System.Threading.Timer;

namespace CPU_S
{
    public partial class FormCPUS : Form
    {
        private CPUHelper cpuHelper;
        private Timer timer;
        ManagementObject cpu;
        ManagementObjectCollection cpus;
        ManagementObjectSearcher searcher2;
        int counter = 0;

        public FormCPUS()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            comboBoxCPU.Items.Clear();
            

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            cpus = searcher.Get();
            foreach (ManagementObject cpu in cpus)
            {
                comboBoxCPU.Items.Add(cpu["DeviceID"]);
            }
            comboBoxCPU.SelectedIndex = 0;

            searcher2 = new ManagementObjectSearcher("SELECT * FROM Win32_PerfFormattedData_PerfOS_Processor");

            cpu = new ManagementObjectSearcher("SELECT * FROM Win32_Processor")
                                               .Get()
                                               .Cast<ManagementObject>()
                                               .First();

            try
            {
                timer = new Timer(TimerCallback, null, 0, 250);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Thread exception: " + ex);
            }

            GetCPUInfo();
        }

        private void TimerCallback(object state)
        {
            counter++;
            //Console.WriteLine($"Task running on Thread ID: {Thread.CurrentThread.ManagedThreadId} Total count: {counter}");

            try
            {
                CPU.CpuStatus = (ushort)cpu["CpuStatus"];

                if (textBoxCPUCpuStatus.InvokeRequired)
                {
                    textBoxCPUCpuStatus.Invoke(new Action(() =>
                    {
                        textBoxCPUCpuStatus.Text = $"{CPU.CpuStatus.ToString()} - {cpuHelper.GetStatus(CPU.CpuStatus)}";
                    }));
                }
                else
                {
                    textBoxCPUCpuStatus.Text = $"{CPU.CpuStatus.ToString()} - {cpuHelper.GetStatus(CPU.CpuStatus)}";
                }
            }
            catch (Exception ex)
            {
                if (textBoxCPUCpuStatus.InvokeRequired)
                {
                    textBoxCPUCpuStatus.Invoke(new Action(() =>
                    {
                        textBoxCPUCpuStatus.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
                    }));
                }
                else
                {
                    textBoxCPUCpuStatus.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
                }
            }

            try
            {
                CPU.CurrentClockSpeed = (uint)cpu["CurrentClockSpeed"];

                if (textBoxCPUCurrentClockSpeed.InvokeRequired)
                {
                    textBoxCPUCurrentClockSpeed.Invoke(new Action(() =>
                    {
                        textBoxCPUCurrentClockSpeed.Text = $"{CPU.CurrentClockSpeed} {CPUConstants.MHZ}";
                    }));
                }
                else
                {
                    textBoxCPUCurrentClockSpeed.Text = $"{CPU.CurrentClockSpeed} {CPUConstants.MHZ}";
                }
            }
            catch (Exception ex)
            {
                if (textBoxCPUCurrentClockSpeed.InvokeRequired)
                {
                    textBoxCPUCurrentClockSpeed.Invoke(new Action(() =>
                    {
                        textBoxCPUCurrentClockSpeed.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
                    }));
                }
                else
                {
                    textBoxCPUCurrentClockSpeed.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
                }
            }

            try
            {
                CPU.CurrentVoltage = (ushort)cpu["CurrentVoltage"];

                if (textBoxCPUCurrentVoltage.InvokeRequired)
                {
                    textBoxCPUCurrentVoltage.Invoke(new Action(() =>
                    {
                        textBoxCPUCurrentVoltage.Text = $"{CPU.CurrentVoltage.ToString()} - {cpuHelper.GetCurrentVoltage(CPU.CurrentVoltage)}{CPUConstants.VOLTAGE}";
                    }));
                }
                else
                {
                    textBoxCPUCurrentVoltage.Text = $"{CPU.CurrentVoltage.ToString()} - {cpuHelper.GetCurrentVoltage(CPU.CurrentVoltage)}{CPUConstants.VOLTAGE}";
                }
            }
            catch (Exception ex)
            {
                if (textBoxCPUCurrentVoltage.InvokeRequired)
                {
                    textBoxCPUCurrentVoltage.Invoke(new Action(() =>
                    {
                        textBoxCPUCurrentVoltage.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
                    }));
                }
                else
                {
                    textBoxCPUCurrentVoltage.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
                }
            }

            try
            {
                CPU.ExtClock = (uint)cpu["ExtClock"];

                if (textBoxCPUExtClock.InvokeRequired)
                {
                    textBoxCPUExtClock.Invoke(new Action(() =>
                    {
                        textBoxCPUExtClock.Text = $"{CPU.ExtClock} {CPUConstants.MHZ}";
                    }));
                }
                else
                {
                    textBoxCPUExtClock.Text = $"{CPU.ExtClock} {CPUConstants.MHZ}";
                }
            }
            catch (Exception ex)
            {
                if (textBoxCPUExtClock.InvokeRequired)
                {
                    textBoxCPUExtClock.Invoke(new Action(() =>
                    {
                        textBoxCPUExtClock.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
                    }));
                }
                else
                {
                    textBoxCPUExtClock.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
                }
            }

            /*
            try
            {
                CPU.LoadPercentage = (ushort)cpu["LoadPercentage"];

                if (textBoxCPULoadPercentage.InvokeRequired)
                {
                    textBoxCPULoadPercentage.Invoke(new Action(() =>
                    {
                        textBoxCPULoadPercentage.Text = $"{CPU.LoadPercentage.ToString()}{CPUConstants.PERCENTAGE}";
                    }));
                }
                else
                {
                    textBoxCPULoadPercentage.Text = $"{CPU.LoadPercentage.ToString()}{CPUConstants.PERCENTAGE}";
                }
                
            }
            catch (Exception ex)
            {
                if (textBoxCPULoadPercentage.InvokeRequired)
                {
                    textBoxCPULoadPercentage.Invoke(new Action(() =>
                    {
                        textBoxCPULoadPercentage.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
                    }));
                }
                else
                {
                    textBoxCPULoadPercentage.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
                }
            }
            */

            if (textBoxCPULoadPercentageLogicalProcThread.InvokeRequired)
            {
                textBoxCPULoadPercentageLogicalProcThread.Invoke(new Action(() =>
                {
                    textBoxCPULoadPercentageLogicalProcThread.Clear();
                }));
            }
            else
            {
                textBoxCPULoadPercentageLogicalProcThread.Clear();
            }
            

            foreach (ManagementObject managementObject in searcher2.Get())
            {
                try
                {

                    string name = (string)managementObject["Name"];
                    ulong usage = (ulong)managementObject["PercentProcessorTime"];

                    if (textBoxCPULoadPercentageLogicalProcThread.InvokeRequired)
                    {
                        textBoxCPULoadPercentageLogicalProcThread.Invoke(new Action(() =>
                        {
                            if (name != "_Total")
                            {
                                textBoxCPULoadPercentageLogicalProcThread.Text += $"{CPUConstants.LOGICAL_PROC} {name}: {usage}{CPUConstants.PERCENTAGE}{Environment.NewLine}";
                            }
                            else
                            {
                                textBoxCPULoadPercentage.Text = $"{usage}{CPUConstants.PERCENTAGE}{Environment.NewLine}";
                            }
                            
                        }));
                    }
                    else
                    {
                        if (name != "_Total")
                        {
                            textBoxCPULoadPercentageLogicalProcThread.Text += $"{CPUConstants.LOGICAL_PROC} {name}: {usage}{CPUConstants.PERCENTAGE}{Environment.NewLine}";
                        }
                        else
                        {
                            textBoxCPULoadPercentage.Text = $"{usage}{CPUConstants.PERCENTAGE}{Environment.NewLine}";
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (textBoxCPULoadPercentageLogicalProcThread.InvokeRequired)
                    {
                        textBoxCPULoadPercentageLogicalProcThread.Invoke(new Action(() =>
                        {
                            textBoxCPULoadPercentageLogicalProcThread.Text += CPUConstants.NOT_FOUND_OR_UNKNOWN + Environment.NewLine;
                        }));
                    }
                    else
                    {
                        textBoxCPULoadPercentageLogicalProcThread.Text += CPUConstants.NOT_FOUND_OR_UNKNOWN + Environment.NewLine;
                    }
                }
            }

            try
            {
                CPU.MaxClockSpeed = (uint)cpu["MaxClockSpeed"];

                if (textBoxCPUMaxClockSpeed.InvokeRequired)
                {
                    textBoxCPUMaxClockSpeed.Invoke(new Action(() =>
                    {
                        textBoxCPUMaxClockSpeed.Text = $"{CPU.MaxClockSpeed} {CPUConstants.MHZ}";
                    }));
                }
                else
                {
                    textBoxCPUMaxClockSpeed.Text = $"{CPU.MaxClockSpeed} {CPUConstants.MHZ}";
                }
            }
            catch (Exception ex)
            {
                if (textBoxCPUMaxClockSpeed.InvokeRequired)
                {
                    textBoxCPUMaxClockSpeed.Invoke(new Action(() =>
                    {
                        textBoxCPUMaxClockSpeed.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
                    }));
                }
                else
                {
                    textBoxCPUMaxClockSpeed.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
                }
            }
        }

        private void GetCPUInfo()
        {
            try
            {
                CPU.AddressWidth = (ushort)cpu["AddressWidth"];
                textBoxCPUAddressWidth.Text = $"{CPU.AddressWidth} {CPUConstants.BITS}";
            }
            catch (Exception ex)
            {
                textBoxCPUAddressWidth.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.Architecture = (ushort)cpu["Architecture"];
                textBoxCPUArchitecture.Text = $"{CPU.Architecture} - {cpuHelper.GetArchitecture(CPU.Architecture)}";
            }
            catch (Exception ex)
            {
                textBoxCPUArchitecture.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.AssetTag = (string)cpu["AssetTag"];
                textBoxCPUAssetTag.Text = CPU.AssetTag;
            }
            catch (Exception ex)
            {
                textBoxCPUAssetTag.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.Availability = (ushort)cpu["Availability"];
                textBoxCPUAvailability.Text = $"{CPU.Availability} - {cpuHelper.GetAvailability(CPU.Availability)}";
            }
            catch (Exception ex)
            {
                textBoxCPUAvailability.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.Caption = (string)cpu["Caption"];
                textBoxCPUCaption.Text = CPU.Caption;
            }
            catch (Exception ex)
            {
                textBoxCPUCaption.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.Characteristics = (uint)cpu["Characteristics"];
                textBoxCPUCharacteristics.Text = $"{CPU.Characteristics}";
                textBoxCPUCharacteristicsMeaning.Text += $"{cpuHelper.GetCharacteristics(CPU.Characteristics)}";
            }
            catch (Exception ex)
            {
                textBoxCPUCharacteristics.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
                textBoxCPUCharacteristicsMeaning.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            
            try
            {
                CPU.ConfigManagerErrorCode = (uint)cpu["ConfigManagerErrorCode"];
                textBoxCPUConfigManagerErrorCode.Text = $"{CPU.ConfigManagerErrorCode} - {cpuHelper.GetConfigManagerErrorCode(CPU.ConfigManagerErrorCode)}";
            }
            catch (Exception ex)
            {
                textBoxCPUConfigManagerErrorCode.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.ConfigManagerUserConfig = (bool)cpu["ConfigManagerUserConfig"];
                textBoxCPUConfigManagerUserConfig.Text = CPU.ConfigManagerUserConfig.ToString();
            }
            catch (Exception ex)
            {
                textBoxCPUConfigManagerUserConfig.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.CreationClassName = (string)cpu["CreationClassName"];
                textBoxCPUCreationClassName.Text = CPU.CreationClassName;
            }
            catch (Exception ex)
            {
                textBoxCPUCreationClassName.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.DataWidth = (ushort)cpu["DataWidth"];
                textBoxCPUDataWidth.Text = CPU.DataWidth.ToString();
            }
            catch (Exception ex)
            {
                textBoxCPUDataWidth.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.Description = (string)cpu["Description"];
                textBoxCPUDescription.Text = CPU.Description;
            }
            catch (Exception ex)
            {
                textBoxCPUDescription.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.DeviceID = (string)cpu["DeviceID"];
                textBoxCPUDeviceID.Text = CPU.DeviceID;
            }
            catch (Exception ex)
            {
                textBoxCPUDeviceID.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.ErrorCleared = (bool)cpu["ErrorCleared"];
                textBoxCPUErrorCleared.Text = CPU.ErrorCleared.ToString();
            }
            catch (Exception ex)
            {
                textBoxCPUErrorCleared.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.ErrorDescription = (string)cpu["ErrorDescription"];
                textBoxCPUErrorDescription.Text = !string.IsNullOrEmpty(CPU.ErrorDescription) ? CPU.ErrorDescription : CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                textBoxCPUErrorDescription.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.Family = (ushort)cpu["Family"];
                textBoxCPUFamily.Text = $"{CPU.Family} - {cpuHelper.GetFamily(CPU.Family)}";
            }
            catch (Exception ex)
            {
                textBoxCPUFamily.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            
            try
            {
                CPU.InstallDate = (DateTime)cpu["InstallDate"];
                if (CPU.InstallDate == DateTime.MinValue)
                {
                    textBoxCPUInstallDate.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
                }
                else
                {
                    textBoxCPUInstallDate.Text = CPU.InstallDate.ToString();
                }
            }
            catch (Exception ex)
            {
                textBoxCPUInstallDate.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.L2CacheSize = (uint)cpu["L2CacheSize"];
                textBoxCPUL2CacheSize.Text = $"{CPU.L2CacheSize.ToString()} / {cpuHelper.GetCacheSizeFull(CPU.L2CacheSize)}";
            }
            catch (Exception ex)
            {
                textBoxCPUL2CacheSize.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.L2CacheSpeed = (uint)cpu["L2CacheSpeed"];
                textBoxCPUL2CacheSpeed.Text = CPU.L2CacheSpeed.ToString();
            }
            catch (Exception ex)
            {
                textBoxCPUL2CacheSpeed.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.L3CacheSize = (uint)cpu["L3CacheSize"];
                textBoxCPUL3CacheSize.Text = $"{CPU.L3CacheSize.ToString()} / {cpuHelper.GetCacheSizeFull(CPU.L3CacheSize)}";
            }
            catch (Exception ex)
            {
                textBoxCPUL3CacheSize.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.L3CacheSpeed = (uint)cpu["L3CacheSpeed"];
                textBoxCPUL3CacheSpeed.Text = CPU.L3CacheSpeed.ToString();
            }
            catch (Exception ex)
            {
                textBoxCPUL3CacheSpeed.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.LastErrorCode = (uint)cpu["LastErrorCode"];
                textBoxCPULastErrorCode.Text = CPU.LastErrorCode.ToString();
            }
            catch (Exception ex)
            {
                textBoxCPULastErrorCode.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.Level = (ushort)cpu["Level"];
                textBoxCPULevel.Text = CPU.Level.ToString();
            }
            catch (Exception ex)
            {
                textBoxCPULevel.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.Manufacturer = (string)cpu["Manufacturer"];
                textBoxCPUManufacturer.Text = CPU.Manufacturer;
            }
            catch (Exception ex)
            {
                textBoxCPUManufacturer.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.Name = (string)cpu["Name"];
                textBoxCPUName.Text = CPU.Name;
            }
            catch (Exception ex)
            {
                textBoxCPUName.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.NumberOfCores = (uint)cpu["NumberOfCores"];
                textBoxCPUNumberOfCores.Text = CPU.NumberOfCores.ToString();
            }
            catch (Exception ex)
            {
                textBoxCPUNumberOfCores.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.NumberOfEnabledCore = (uint)cpu["NumberOfEnabledCore"];
                textBoxCPUNumberOfEnabledCore.Text = CPU.NumberOfEnabledCore.ToString();
            }
            catch (Exception ex)
            {
                textBoxCPUNumberOfEnabledCore.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.NumberOfLogicalProcessors = (uint)cpu["NumberOfLogicalProcessors"];
                textBoxCPUNumberOfLogicalProcessors.Text = CPU.NumberOfLogicalProcessors.ToString();
            }
            catch (Exception ex)
            {
                textBoxCPUNumberOfLogicalProcessors.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.OtherFamilyDescription = (string)cpu["OtherFamilyDescription"];
                textBoxCPUOtherFamilyDescription.Text = !string.IsNullOrEmpty(CPU.OtherFamilyDescription) ? CPU.OtherFamilyDescription : CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                textBoxCPUOtherFamilyDescription.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.PartNumber = (string)cpu["PartNumber"];
                textBoxCPUPartNumber.Text = CPU.PartNumber;
            }
            catch (Exception ex)
            {
                textBoxCPUPartNumber.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.PNPDeviceID = (string)cpu["PNPDeviceID"];
                textBoxCPUPNPDeviceID.Text = CPU.DeviceID;
            }
            catch (Exception ex)
            {
                textBoxCPUPNPDeviceID.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.PowerManagementCapabilities = (ushort[])cpu["PowerManagementCapabilities"];
                if ((null != CPU.PowerManagementCapabilities))
                {
                    foreach (ushort capability in CPU.PowerManagementCapabilities)
                    {
                        textBoxCPUPowerManagementCapabilities.Text += capability.ToString() + " - " + cpuHelper.GetPowerManagementCapabilities(capability) + ", ";
                    }

                }
                else
                {
                    textBoxCPUPowerManagementCapabilities.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
                }
            }
            catch (Exception ex)
            {
                textBoxCPUPowerManagementCapabilities.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.PowerManagementSupported = (bool)cpu["PowerManagementSupported"];
                textBoxCPUPowerManagementSupported.Text = CPU.PowerManagementSupported.ToString();
            }
            catch (Exception ex)
            {
                textBoxCPUPowerManagementSupported.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.ProcessorId = (string)cpu["ProcessorId"];
                textBoxCPUProcessorId.Text = CPU.ProcessorId;
            }
            catch (Exception ex)
            {
                textBoxCPUProcessorId.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.ProcessorType = (ushort)cpu["ProcessorType"];
                textBoxCPUProcessorType.Text = $"{CPU.ProcessorType} - {cpuHelper.GetProcessorType(CPU.ProcessorType)}";
            }
            catch (Exception ex)
            {
                textBoxCPUProcessorType.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.Revision = (ushort)cpu["Revision"];
                textBoxCPURevision.Text = CPU.Revision.ToString();
            }
            catch (Exception ex)
            {
                textBoxCPURevision.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.Role = (string)cpu["Role"];
                textBoxCPURole.Text = CPU.Role;
            }
            catch (Exception ex)
            {
                textBoxCPURole.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.SecondLevelAddressTranslationExtensions = (bool)cpu["SecondLevelAddressTranslationExtensions"];
                textBoxCPUSecondLevelAddressTranslationExtensions.Text = CPU.SecondLevelAddressTranslationExtensions.ToString();
            }
            catch (Exception ex)
            {
                textBoxCPUSecondLevelAddressTranslationExtensions.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.SerialNumber = (string)cpu["SerialNumber"];
                textBoxCPUSerialNumber.Text = CPU.SerialNumber;
            }
            catch (Exception ex)
            {
                textBoxCPUSerialNumber.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.SocketDesignation = (string)cpu["SocketDesignation"];
                textBoxCPUSocketDesignation.Text = CPU.SocketDesignation;
            }
            catch (Exception ex)
            {
                textBoxCPUSocketDesignation.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.Status = (string)cpu["Status"];
                textBoxCPUStatus.Text = CPU.Status;
            }
            catch (Exception ex)
            {
                textBoxCPUStatus.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.StatusInfo = (ushort)cpu["StatusInfo"];
                textBoxCPUStatusInfo.Text = $"{CPU.StatusInfo} - {cpuHelper.GetStatusInfo(CPU.StatusInfo)}";
            }
            catch (Exception ex)
            {
                textBoxCPUStatusInfo.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.Stepping = (string)cpu["Stepping"];
                textBoxCPUStepping.Text = CPU.StatusInfo.ToString();
            }
            catch (Exception ex)
            {
                textBoxCPUStepping.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.SystemCreationClassName = (string)cpu["SystemCreationClassName"];
                textBoxCPUSystemCreationClassName.Text = CPU.SystemCreationClassName;
            }
            catch (Exception ex)
            {
                textBoxCPUSystemCreationClassName.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.SystemName = (string)cpu["SystemName"];
                textBoxCPUSystemName.Text = CPU.SystemName;
            }
            catch (Exception ex)
            {
                textBoxCPUSystemName.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.ThreadCount = (uint)cpu["ThreadCount"];
                textBoxCPUThreadCount.Text = CPU.ThreadCount.ToString();
            }
            catch (Exception ex)
            {
                textBoxCPUThreadCount.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.UniqueId = (string)cpu["UniqueId"];
                textBoxCPUUniqueId.Text = !string.IsNullOrEmpty(CPU.UniqueId) ? CPU.UniqueId : CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                textBoxCPUUniqueId.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.UpgradeMethod = (ushort)cpu["UpgradeMethod"];
                textBoxCPUUpgradeMethod.Text = $"{CPU.UpgradeMethod} - {cpuHelper.GetUpgradeMethod(CPU.UpgradeMethod)}";
            }
            catch (Exception ex)
            {
                textBoxCPUUpgradeMethod.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.Version = (string)cpu["Version"];
                textBoxCPUVersion.Text = !string.IsNullOrEmpty(CPU.UniqueId) ? CPU.Version : CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                textBoxCPUVersion.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.VirtualizationFirmwareEnabled = (bool)cpu["VirtualizationFirmwareEnabled"];
                textBoxCPUVirtualizationFirmwareEnabled.Text = CPU.VirtualizationFirmwareEnabled.ToString();
            }
            catch (Exception ex)
            {
                textBoxCPUVirtualizationFirmwareEnabled.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            try
            {
                CPU.VMMonitorModeExtensions = (bool)cpu["VMMonitorModeExtensions"];
                textBoxCPUVMMonitorModeExtensions.Text = CPU.VMMonitorModeExtensions.ToString();
            }
            catch (Exception ex)
            {
                textBoxCPUVMMonitorModeExtensions.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            

            try
            {
                CPU.VoltageCaps = (uint)cpu["VoltageCaps"];
                textBoxCPUVoltageCaps.Text = CPU.VoltageCaps.ToString();
            }
            catch (Exception ex)
            {
                textBoxCPUVoltageCaps.Text = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }

            // @TODO: Add to user interface to display this information
            /*
            bool isAvx2Supported = cpuHelper.IsAvx2SupportedX();
            Console.WriteLine($"AVX2 Supported: {isAvx2Supported}");
            */

            string cpuIdEAX0EAX = cpuHelper.GetEAX0EAXX();
            Console.WriteLine($"EAX0EAX: {cpuIdEAX0EAX}");

            string cpuIdEAX0EBX = cpuHelper.GetEAX0EBXX();
            Console.WriteLine($"EAX0EBX: {cpuIdEAX0EBX}");

            string cpuIdEAX0ECX = cpuHelper.GetEAX0ECXX();
            Console.WriteLine($"EAX0ECX: {cpuIdEAX0ECX}");

            string cpuIdEAX0EDX = cpuHelper.GetEAX0EDXX();
            Console.WriteLine($"EAX0EDX: {cpuIdEAX0EDX}");

            string cpuIdEAX0EAXHightestFunctionParameter = cpuHelper.GetEAX0EAXHightestFunctionParameterX();
            Console.WriteLine($"EAX0EAX Highest Function Parameter: {cpuIdEAX0EAXHightestFunctionParameter}");

            string cpuIdEAX0EBXEDXECXCpuVendor = cpuHelper.GetEAX0EBXEDXECXCpuVendorX();
            Console.WriteLine($"CPU Vendor: {cpuIdEAX0EBXEDXECXCpuVendor}");

            string cpuIdEAX1EAX = cpuHelper.GetEAX1EAXX();
            Console.WriteLine($"EAX1EAX: {cpuIdEAX1EAX}");

            string cpuIdEAX1EBX = cpuHelper.GetEAX1EBXX();
            Console.WriteLine($"EAX1EBX: {cpuIdEAX1EBX}");

            string cpuIdEAX1ECX = cpuHelper.GetEAX1ECXX();
            Console.WriteLine($"EAX1ECX: {cpuIdEAX1ECX}");

            string cpuIdEAX1EDX = cpuHelper.GetEAX1EDXX();
            Console.WriteLine($"EAX1EDX: {cpuIdEAX1EDX}");

            string cpuIdEAX1EAX0_3_SteppingId = cpuHelper.GetEAX1EAX0_3_SteppingIdX();
            Console.WriteLine($"EAX1EAX0_3_SteppingId: {cpuIdEAX1EAX0_3_SteppingId}");

            string cpuIdEAX1EAX4_7_ModelId = cpuHelper.GetEAX1EAX4_7_ModelIdX();
            Console.WriteLine($"EAX1EAX4_7_ModelId: {cpuIdEAX1EAX4_7_ModelId}");

            string cpuIdEAX1EAX8_11_FamilyId = cpuHelper.GetEAX1EAX8_11_FamilyIdX();
            Console.WriteLine($"EAX1EAX8_11_FamilyId: {cpuIdEAX1EAX8_11_FamilyId}");

            string cpuIdEAX1EAX12_13_ProcessorType = cpuHelper.GetEAX1EAX12_13_ProcessorTypeX();
            Console.WriteLine($"EAX1EAX12_13_ProcessorType: {cpuIdEAX1EAX12_13_ProcessorType}");

            string cpuIdEAX1EAX14_15_Reserved = cpuHelper.GetEAX1EAX14_15_ReservedX();
            Console.WriteLine($"EAX1EAX14_15_Reserved: {cpuIdEAX1EAX14_15_Reserved}");

            string cpuIdEAX1EAX16_19_ExtendedModelId = cpuHelper.GetEAX1EAX16_19_ExtendedModelIdX();
            Console.WriteLine($"EAX1EAX16_19_ExtendedModelId: {cpuIdEAX1EAX16_19_ExtendedModelId}");

            string cpuIdEAX1EAX16_19_ExtendedModelIdLeftShifted = cpuHelper.GetEAX1EAX16_19_ExtendedModelIdLeftShiftedX();
            Console.WriteLine($"EAX1EAX16_19_ExtendedModelIdLeftShifted: {cpuIdEAX1EAX16_19_ExtendedModelIdLeftShifted}");
            
            string cpuIdEAX1EAX20_27_ExtendedFamilyId = cpuHelper.GetEAX1EAX20_27_ExtendedFamilyIdX();
            Console.WriteLine($"EAX1EAX20_27_ExtendedFamilyId: {cpuIdEAX1EAX20_27_ExtendedFamilyId}");

            string cpuIdEAX1EAX28_31_Reserved = cpuHelper.GetEAX1EAX28_31_ReservedX();
            Console.WriteLine($"EAX1EAX28_31_Reserved: {cpuIdEAX1EAX28_31_Reserved}");

            string cpuIdEAX1EBX0_7_BrandIndex = cpuHelper.GetEAX1EBX0_7_BrandIndexX();
            Console.WriteLine($"EAX1EBX0_7_BrandIndex: {cpuIdEAX1EBX0_7_BrandIndex}");

            string cpuIdEAX1EBX8_15_CLFLUSHLineSize = cpuHelper.GetEAX1EBX8_15_CLFLUSHLineSizeX();
            Console.WriteLine($"EAX1EBX8_15_CLFLUSHLineSize: {cpuIdEAX1EBX8_15_CLFLUSHLineSize}");

            string cpuIdEAX1EBX16_23_MaxNumAddrIdsLogProcsInPhyPckg = cpuHelper.GetEAX1EBX16_23_MaxNumAddrIdsLogProcsInPhyPckgX();
            Console.WriteLine($"EAX1EBX16_23_MaxNumAddrIdsLogProcsInPhyPckg: {cpuIdEAX1EBX16_23_MaxNumAddrIdsLogProcsInPhyPckg}");
            
            string cpuIdEAX1EBX24_31_LocalAPICID = cpuHelper.GetEAX1EBX24_31_LocalAPICIDX();
            Console.WriteLine($"EAX1EBX24_31_LocalAPICID: {cpuIdEAX1EBX24_31_LocalAPICID}");

            bool cpuIdEAX1ECX0_SSE3IsSupported = cpuHelper.GetEAX1ECX0_SSE3IsSupportedX();
            Console.WriteLine($"EAX1ECX0_SSE3IsSupported: {cpuIdEAX1ECX0_SSE3IsSupported}");

            bool cpuIdEAX1ECX1_PCLMULQDQIsSupported = cpuHelper.GetEAX1ECX1_PCLMULQDQIsSupportedX();
            Console.WriteLine($"EAX1ECX1_PCLMULQDQIsSupported: {cpuIdEAX1ECX1_PCLMULQDQIsSupported}");

            bool cpuIdEAX1ECX2_DTES64IsSupported = cpuHelper.GetEAX1ECX2_DTES64IsSupportedX();
            Console.WriteLine($"EAX1ECX2_DTES64IsSupported: {cpuIdEAX1ECX2_DTES64IsSupported}");
        }

        private void comboBoxCPU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cpu != null)
            {
                cpu = cpus.OfType<ManagementObject>().ElementAt(comboBoxCPU.SelectedIndex);
                GetCPUInfo();
            }
            
        }

        private void FormCPUS_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer.Dispose();
            Dispose();
        }
    }
}
