/*
    File           CPUS.cs
    Brief          Main form for CPU information display.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           05/29/2026
    Author         Shawn M. Crawford [sleepy]
*/
using CPU_S.Properties;
using System;
using System.Data;
using System.Linq;
using System.Management;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace CPU_S
{
    public partial class FormCPUS : Form
    {
        private CPUHelper cpuHelper;

        private Timer timer;

        ManagementObject cpu;

        ManagementObjectCollection cpus;

        ManagementObjectSearcher managementObjectSearcher;

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

            managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_PerfFormattedData_PerfOS_Processor");

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
            

            foreach (ManagementObject managementObject in managementObjectSearcher.Get())
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

            #region x86 SIMD Instructions

            checkBoxMMX.Checked = cpuHelper.GetEAX1EDX23_MMXIsSupportedX();
            checkBoxSSE.Checked = cpuHelper.GetEAX1EDX25_SSEIsSupportedX();
            checkBoxSSE2.Checked = cpuHelper.GetEAX1EDX26_SSE2IsSupportedX();
            checkBoxSSE3.Checked = cpuHelper.GetEAX1ECX0_SSE3IsSupportedX();
            checkBoxSSSE3.Checked = cpuHelper.GetEAX1ECX9_SSSE3IsSupportedX();
            checkBoxSSE4a.Checked = cpuHelper.GetEAX80000001ECX6_SSE4AIsSupportedX();
            checkBoxSSE41.Checked = cpuHelper.GetEAX1ECX19_SSE41IsSupportedX();
            checkBoxSSE42.Checked = cpuHelper.GetEAX1ECX20_SSE42IsSupportedX();
            checkBoxAVX.Checked = cpuHelper.GetEAX1ECX28_AVXIsSupportedX();
            checkBoxFMA3.Checked = cpuHelper.GetEAX1ECX12_FMAIsSupportedX();
            checkBoxAVX2.Checked = cpuHelper.GetEAX7ECX0_EBX5_AVX2IsSupportedX();
            checkBoxAVX512F.Checked = cpuHelper.GetEAX7ECX0_EBX16_AVX512FIsSupportedX();
            checkBoxAVX512CD.Checked = cpuHelper.GetEAX7ECX0_EBX28_AVX512CDIsSupportedX();
            checkBoxAVX512ER.Checked = cpuHelper.GetEAX7ECX0_EBX27_AVX512ERIsSupportedX();
            checkBoxAVX512PF.Checked = cpuHelper.GetEAX7ECX0_EBX26_AVX512PFIsSupportedX();
            checkBoxAVX5124VNNIW.Checked = cpuHelper.GetEAX7ECX0_EDX2_AVX5124VNNIIsSupportedX();
            checkBoxAVX5124FMAPS.Checked = cpuHelper.GetEAX7ECX0_EDX3_AVX5124FMAPSIsSupportedX();
            checkBoxAVX512VL.Checked = cpuHelper.GetEAX7ECX0_EBX31_AVX512VLIsSupportedX();
            checkBoxAVX512DQ.Checked = cpuHelper.GetEAX7ECX0_EBX17_AVX512DQIsSupportedX();
            checkBoxAVX512BW.Checked = cpuHelper.GetEAX7ECX0_EBX30_AVX512BWIsSupportedX();
            checkBoxAVX512IFMA.Checked = cpuHelper.GetEAX7ECX0_EBX21_AVX512IFMAIsSupportedX();
            checkBoxAVX512VBMI.Checked = cpuHelper.GetEAX7ECX0_ECX1_AVX512VBMIIsSupportedX();
            checkBoxAVX512VNNI.Checked = cpuHelper.GetEAX7ECX0_ECX11_AVX512VNNIIsSupportedX();
            checkBoxAVX512VPOPCNTDQ.Checked = cpuHelper.GetEAX7ECX0_ECX14_AVX512VPOPCNTDQIsSupportedX();
            checkBoxAVX512VBMI2.Checked = cpuHelper.GetEAX7ECX0_ECX6_AVX512VBMI2IsSupportedX();
            checkBoxAVX512BITALG.Checked = cpuHelper.GetEAX7ECX0_ECX12_AVX512BITALGIsSupportedX();
            checkBoxAVX512VP2INTERSECT.Checked = cpuHelper.GetEAX7ECX0_EDX8_AVX512VP2INTERSECTIsSupportedX();
            //checkBoxAVX512BMM.Checked = cpuHelper. //80000021 EAX 23 AVX512_BMM
            //checkBoxAMX.Checked = cpuHelper. // Several different AMX features, check the specific CPUID bits for each
            //checkBoxAVX101.Checked = cpuHelper. // Several different AVX10 features, check the specific CPUID bits for each (EAX24, ECX0)
            //checkBoxAVX102.Checked = cpuHelper. // Several different AVX10 features, check the specific CPUID bits for each (EAX24, ECX1)

            #endregion

            #region x86 Cryptographic Instructions

            checkBoxAES.Checked = cpuHelper.GetEAX1ECX25_AESNIIsSupportedX();
            checkBoxCLMUL.Checked = cpuHelper.GetEAX1ECX1_PCLMULQDQIsSupportedX();
            checkBoxRDSEED.Checked = cpuHelper.GetEAX7ECX0_EBX18_RDSEEDIsSupportedX();
            checkBoxRDRAND.Checked = cpuHelper.GetEAX1ECX30_RDRANDIsSupportedX();
            checkBoxSHA.Checked = cpuHelper.GetEAX7ECX0_EBX29_SHAIsSupportedX();
            checkBoxSM3.Checked = cpuHelper.GetEAX7ECX1_EAX1_SM3IsSupportedX();
            checkBoxSM4.Checked = cpuHelper.GetEAX7ECX1_EAX2_SM4IsSupportedX();
            checkBoxKL.Checked = cpuHelper.GetEAX7ECX0_ECX23_KLIsSupportedX();
            //checkBoxPadLock.Checked = cpuHelper. //EAX=C0000001, various
            checkBoxMPX.Checked = cpuHelper.GetEAX7ECX0_EBX14_MPXIsSupportedX();
            checkBoxSGX.Checked = cpuHelper.GetEAX7ECX0_EBX2_SGXIsSupportedX();
            //checkBoxTDX.Checked = cpuHelper. //EAX=21h ?

            #endregion

            #region x86 Virtualization Instructions

            //checkBoxAMDV.Checked = cpuHelper. // EAX=40000000h-4FFFFFFFh
            //checkBoxIntelVTX.Checked = cpuHelper. // EAX=40000000h-4FFFFFFFh
            //checkBoxVIAVT.Checked = cpuHelper. // ?
            checkBoxV8086M.Checked = cpuHelper.GetEAX1EDX1_VMEIsSupportedX();

            #endregion

            #region Transactional Memory Instructions

            checkBoxTSX.Checked = cpuHelper.GetEAX7ECX0_EBX11_RTMIsSupportedX(); // RTM - TSX Restricted Transactional Memory ???
            //checkBoxASF.Checked = cpuHelper.; // Advanced Sycnhronization Facility (ASF) - Intel only, AMD has no ASF support

            #endregion

            #region Bit Manipulation Instructions

            checkBoxADX.Checked = cpuHelper.GetEAX7ECX0_EBX19_ADXIsSupportedX();
            checkBoxBMI1.Checked = cpuHelper.GetEAX7ECX0_EBX3_BMI1IsSupportedX();
            checkBoxBMI2.Checked = cpuHelper.GetEAX7ECX0_EBX8_BMI2IsSupportedX();
            checkBoxTBM.Checked = cpuHelper.GetEAX80000001ECX21_TBMIsSupportedX();
            checkBoxABM.Checked = cpuHelper.GetEAX80000001ECX5_ABMIsSupportedX();

            #endregion

            #region x86 Instructions

            //checkBoxI386.Checked = cpuHelper. //?
            //checkBoxItanium.Checked = cpuHelper. //?
            checkBoxHLE.Checked = cpuHelper.GetEAX7ECX0_EBX4_HLEIsSupportedX();
            //checkBoxKNC.Checked = cpuHelper. //? Knights Corner
            //checkBoxKLKM.Checked = cpuHelper. //? Knights Landing & Knights Mill

            //checkBoxAM386SMM.Checked = cpuHelper. //? Am386 SMM (System Management Mode Instructions)
            checkBox3DNow.Checked = cpuHelper.GetEAX80000001EDX31_3DNOWIsSupportedX();
            checkBox3DNowPlus.Checked = cpuHelper.GetEAX80000001EDX30_3DNOWEXTIsSupportedX();
            checkBoxXOP.Checked = cpuHelper.GetEAX80000001ECX11_XOPIsSupportedX(); // SSE5 is not a standard name, but it refers to AMD's XOP (eXtended Operations) instruction set
            checkBoxFMA4.Checked = cpuHelper.GetEAX80000001ECX16_FMA4IsSupportedX();
            checkBoxLWP.Checked = cpuHelper.GetEAX80000001ECX15_LWPIsSupportedX();

            //checkBoxNECV.Checked = cpuHelper. //? NEC V-series
            //checkBoxCyrixGeode.Checked = cpuHelper. //? Cyrix Geode
            //checkBoxCyrixEMMi.Checked = cpuHelper. //? Cyrix EMMI (Extended Multi-Media Instructions)
            //checkBoxVIAAIS.Checked = cpuHelper. //? VIA Advanced Intelligent Instruction Set (AIIS)
            //checkBoxCAndT.Checked = cpuHelper. //? C&T (Cyrix & Texas Instruments) - C&T 486SLC, 486DLC, 5x86, 6x86, M1, M2
            //checkBox387Clones.Checked = cpuHelper. //? 387 Clones - Cyrix 387S, UMC 387S, IIT 387S, Chips & Technologies 387S, Weitek 387S, etc.

            #endregion

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

        private void eAX0x0HighestFunctionParameterAndManufacturerIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX00000000 eAX00000000 = new EAX00000000();
            eAX00000000.ShowDialog();
        }

        private void eAX0x1ProcessorInfoAndFeatureBitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX00000001 eAX00000001 = new EAX00000001();
            eAX00000001.ShowDialog();
        }

        private void eAX0x2CacheAndTLBDescriptorInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX00000002 eAX00000002 = new EAX00000002();
            eAX00000002.ShowDialog();
        }

        private void eAX0x3ProcessorSerialNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX00000003 eAX00000003 = new EAX00000003();
            eAX00000003.ShowDialog();
        }

        private void eAX0x4CacheHierarchyAndTopologyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (int.Parse(cpuHelper.GetEAX4EAX0_4_CacheTypeX(i)) == 0)
            {
                MessageBox.Show("No cache information available for this CPU at EAX=0x4.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                while (int.Parse(cpuHelper.GetEAX4EAX0_4_CacheTypeX(i)) != 0)
                {
                    EAX00000004 eAX00000004 = new EAX00000004(i);
                    eAX00000004.Show();
                    i++;
                }
            }
        }

        private void eAX0x8000001DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (int.Parse(cpuHelper.GetEAX8000001DEAX0_4_CacheTypeX(i)) == 0)
            {
                MessageBox.Show("No cache information available for this CPU at EAX=0x8000001D.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                while (int.Parse(cpuHelper.GetEAX8000001DEAX0_4_CacheTypeX(i)) != 0)
                {
                    EAX8000001D eax8000001D = new EAX8000001D(i);
                    eax8000001D.Show();
                    i++;
                }
            }
        }

        private void eAX0xBIntelThreadCoreAndCacheTopologyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Sub-leaf to query (0...n until EBX[15...0] = 0).
            if (int.Parse(cpuHelper.GetEAX0000000BEBX0_15_NumberOfLogicalProcessorsX(0)) == 0)
            {
                MessageBox.Show("No Discrete AVX10 Features information available for this CPU at EAX=0x00000024.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int i = 0;
                while (int.Parse(cpuHelper.GetEAX0000000BEBX0_15_NumberOfLogicalProcessorsX(i)) != 0)
                {
                    //Console.WriteLine($"EAX0000000B - Sub-leaf {i} - EBX[15:0] = {cpuHelper.GetEAX0000000BEBX0_15_NumberOfLogicalProcessorsX(i)}");
                    EAX0000000B eAX0000000B = new EAX0000000B(i);
                    eAX0000000B.Show();
                    i++;
                }
            }
        }

        private void eAX0x5MONITORMWAITFeaturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX00000005 eAX00000005 = new EAX00000005();
            eAX00000005.ShowDialog();
        }

        private void eAX0x6ThermalAndPowerManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX00000006 eAX00000006 = new EAX00000006();
            eAX00000006.ShowDialog();
        }

        private void eAX0x7ECX0x0ExtendedFeaturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX00000007ECX0 eAX00000007ECX0 = new EAX00000007ECX0();
            eAX00000007ECX0.ShowDialog();
        }

        private void eAX0xDXSAVEFeaturesAndStateComponentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX0000000D eAX0000000D = new EAX0000000D();
            eAX0000000D.ShowDialog();
        }

        private void eAX0x12SGXCapabilitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX00000012 eAX00000012 = new EAX00000012();
            eAX00000012.ShowDialog();
        }

        private void eAX0x14ECX0x0ProcessorTraceFeatureBitsInEBXAndECXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX00000014ECX0 eAX00000014ECX0 = new EAX00000014ECX0();
            eAX00000014ECX0.ShowDialog();
        }

        private void eAX0x14ECX0x1ProcessorTracePacketGenerationInformationInEAXEBXAndECXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ECX = 0000_00xxh sub-leaf to query(0 = resources, 1...31 as per EAX reported by sub-leaf 0)
            int i = 0;
            int j = int.Parse(cpuHelper.GetEAX00000014EAX_0_31_MaxSubleafX());
            if (j == 0)
            {
                MessageBox.Show("No sub-leaf available for this CPU at EAX=0x00000014 - Processor Trace (details).", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                while (j > i)
                {
                    EAX00000014ECXN eAX00000014ECXN = new EAX00000014ECXN(i);
                    eAX00000014ECXN.Show();
                    i++;
                }
            }
        }

        private void eAX0x15TSCAndCoreCrystalFrequencyInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX00000015 eAX00000015 = new EAX00000015();
            eAX00000015.ShowDialog();
        }

        private void eAX0x16ProcessorAndBusSpecificationFrequenciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX00000016 eAX00000016 = new EAX00000016();
            eAX00000016.ShowDialog();
        }

        private void eAX0x17SoCVendorAttributeEnumerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX00000017 eAX00000017 = new EAX00000017();
            eAX00000017.ShowDialog();
        }

        private void eAX0x18TLBHierarchyAndTopologyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX00000018 eAX00000018 = new EAX00000018();
            eAX00000018.ShowDialog();
        }

        private void eAX0x19IntelKeyLockerFeaturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX00000019 eAX00000019 = new EAX00000019();
            eAX00000019.ShowDialog();
        }

        private void eAX0x1DIntelAMXTileInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX0000001D eAX0000001D = new EAX0000001D();
            eAX0000001D.ShowDialog();
        }

        private void eAX0x1EIntelAMXTileMultiplierTMULInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX0000001E eAX0000001E = new EAX0000001E();
            eAX0000001E.ShowDialog();
        }

        private void eAX0x21ReservedForTDXEnumerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX00000021 eAX00000021 = new EAX00000021();
            eAX00000021.ShowDialog();
        }

        private void eAX0x24ECX0x0AVX10ConvergedVectorISAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX00000024ECX0 eAX00000024ECX0 = new EAX00000024ECX0();
            eAX00000024ECX0.ShowDialog();
        }

        private void eAX0x24ECX0xNDiscreteAVX10FeaturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Sub-leaf to query (0...n as per EAX reported by sub-leaf 0).
            if (int.Parse(cpuHelper.GetEAX00000024EAXX()) == 0)
            {
                MessageBox.Show("No Discrete AVX10 Features information available for this CPU at EAX=0x00000024.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int i = 0;
                while (int.Parse(cpuHelper.GetEAX0000000BEBXX(i)) != 0)
                {
                    EAX00000024ECXN eAX00000024ECXN = new EAX00000024ECXN(i);
                    eAX00000024ECXN.Show();
                    i++;
                }
            }
        }

        private void eAX0x20000000HighestXeonPhiFunctionImplementedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX20000000 eAX20000000 = new EAX20000000();
            eAX20000000.ShowDialog();
        }

        private void eAX0x20000001XeonPhiFeatureBitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX20000001 eAX20000001 = new EAX20000001();
            eAX20000001.ShowDialog();
        }

        private void eAX0x400000000ReservedForHypervisorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX40000000 eAX40000000 = new EAX40000000();
            eAX40000000.ShowDialog();
        }

        private void eAX0x80000000HighestExtendedFunctionImplementedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX80000000 eAX80000000 = new EAX80000000();
            eAX80000000.ShowDialog();
        }

        private void eAX0x80000001ExtendedProcessorInfoAndFeatureBitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX80000001 eAX80000001 = new EAX80000001();
            eAX80000001.ShowDialog();
        }

        private void eAX0x800000020x800000030x80000004ProcessorBrandStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX80000002_80000003_80000004 eAX80000002_80000003_80000004 = new EAX80000002_80000003_80000004();
            eAX80000002_80000003_80000004.ShowDialog();
        }

        private void eAX0x80000005L1CacheAndTLBIdentifiersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX80000005 eAX80000005 = new EAX80000005();
            eAX80000005.ShowDialog();
        }

        private void eAX0x80000006ExtendedL2CacheFeaturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX80000006_Intel eAX80000006 = new EAX80000006_Intel();
            eAX80000006.ShowDialog();
        }

        private void eAX0x80000006ExtendedL2CacheFeaturesAMDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX80000006_AMD eAX80000006 = new EAX80000006_AMD();
            eAX80000006.ShowDialog();
        }

        private void eAX0x80000007ProcessorPowerManagementInformationAndRASCapabilitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX80000007 eAX80000007 = new EAX80000007();
            eAX80000007.ShowDialog();
        }

        private void eAX0x80000008VirtualAndPhysicalAddressSizesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX80000008 eAX80000008 = new EAX80000008();
            eAX80000008.ShowDialog();
        }

        private void eAX0x8000000ASVMFeaturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX8000000A eAX8000000A = new EAX8000000A();
            eAX8000000A.ShowDialog();
        }

        private void eAX0x8000001FEncryptedMemoryCapabilitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX8000001F eAX8000001F = new EAX8000001F();
            eAX8000001F.ShowDialog();
        }

        private void eAX0x80000021ExtendedFeatureIdentificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX80000021 eAX80000021 = new EAX80000021();
            eAX80000021.ShowDialog();
        }

        private void eAX0x80000025EncryptedMemoryCapabilities2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX80000025 eAX80000025 = new EAX80000025();
            eAX80000025.ShowDialog();
        }

        private void eAX0x8C860000HygonExtendedFeatureFlagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX8C860000 eAX8C860000 = new EAX8C860000();
            eAX8C860000.ShowDialog();
        }

        private void eAX0x8FFFFFFE0x8FFFFFFFAMDEasterEggsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX8FFFFFFE eAX8FFFFFFE = new EAX8FFFFFFE();
            eAX8FFFFFFE.ShowDialog();
        }

        private void eAX0xC0000000HighestCentaurExtendedFunctionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAXC0000000 eAXC0000000 = new EAXC0000000();
            eAXC0000000.ShowDialog();
        }

        private void eAX0xC0000001CentaurFeatureInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAXC0000001 eAXC0000001 = new EAXC0000001();
            eAXC0000001.ShowDialog();
        }

        private void eAX0xC0000002CentaurExtendedCPUIDPerformanceDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAXC0000002 eAXC0000002 = new EAXC0000002();
            eAXC0000002.ShowDialog();
        }

        private void eAX0xC0000006ZhaoxinFeatureInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAXC0000006 eAXC0000006ECX0 = new EAXC0000006();
            eAXC0000006ECX0.ShowDialog();
        }

        private void eAX0x7ECX0x1ExtendedFeaturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX00000007ECX1 eAX00000007ECX1 = new EAX00000007ECX1();
            eAX00000007ECX1.ShowDialog();
        }

        private void eAX0x7ECX0x2ExtendedFeaturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX00000007ECX2 eAX00000007ECX2 = new EAX00000007ECX2();
            eAX00000007ECX2.ShowDialog();
        }

        private void CustomRegisterCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Custom custom = new Custom();
            custom.ShowDialog();
        }

        private void eAX0x400000001ReservedForHypervisorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX40000001 eAX40000001 = new EAX40000001();
            eAX40000001.ShowDialog();
        }

        private void eAX0x400000002ReservedForHypervisorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX40000002 eAX40000002 = new EAX40000002();
            eAX40000002.ShowDialog();
        }

        private void eAX0x400000003ReservedForHypervisorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX40000003 eAX40000003 = new EAX40000003();
            eAX40000003.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CPU-S v1.0b\n\nCopyright © 2024 Shawn M. Crawford\n\nAll rights reserved.\n\nThis software is provided \"as-is\", without any express or implied warranty.",
                "About CPU-S",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void eax0x00000009DCAParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX00000009 eAX00000009 = new EAX00000009();
            eAX00000009.ShowDialog();
        }

        private void eax0x0000000AArchitecturalPerfMonInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX0000000A eAX0000000A = new EAX0000000A();
            eAX0000000A.ShowDialog();
        }

        private void eAX0x0000000F_RDTMQoSMonitoringEnumerationECX0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX0000000FECX0 eAX0000000FECX0 = new EAX0000000FECX0();
            eAX0000000FECX0.ShowDialog();
        }

        private void eAX0x0000000F_RDTMQoSMonitoringEnumerationECXNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ECX = 0000_00xxh sub-leaf to query(0 = resources, 1...n as per EDX reported by sub-leaf 0)
            int i = 0;
            int j = int.Parse(cpuHelper.GetEAX0000000FEDXX());
            if (j == 0)
            {
                MessageBox.Show("No sub-leaf available for this CPU at EAX=0x0000000F - RDT-M (QoS monitoring) (Resources).", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                while (j > i)
                {
                    EAX0000000FECXN eAX0000000FECXN = new EAX0000000FECXN(i);
                    eAX0000000FECXN.Show();
                    i++;
                }
            }

        }

        private void eAX0x0000000DXSAVEFeaturesAndStateComponentsSub1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX0000000DECX1 eAX0000000DECX1 = new EAX0000000DECX1();
            eAX0000000DECX1.ShowDialog();
        }

        private void eAX0x0000000DXSAVEFeaturesAndStateComponentsSub2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX0000000DECXN eAX0000000DECXN = new EAX0000000DECXN(2);
            eAX0000000DECXN.ShowDialog();
        }

        private void eAX0x00000010_RDTAQoSAllocationEnumerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX00000010 eAX00000010 = new EAX00000010();
            eAX00000010.ShowDialog();
        }

        private void eAX0x0000001ACoreModelInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX0000001A eAX0000001A = new EAX0000001A();
            eAX0000001A.ShowDialog();
        }

        private void eAX0x0000001BPCONFIGInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX0000001B eAX0000001B = new EAX0000001B();
            eAX0000001B.ShowDialog();
        }

        private void eAX0x0000001CLBRInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX0000001C eAX0000001C = new EAX0000001C();
            eAX0000001C.ShowDialog();
        }

        private void eAX0x0000001FTopologyEnumerationInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX0000001F eAX0000001F = new EAX0000001F();
            eAX0000001F.ShowDialog();
        }

        private void eAX0x00000020HRESETInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX00000020 eAX00000020 = new EAX00000020();
            eAX00000020.ShowDialog();
        }

        private void eAX0x00000023ArchitecturalPerfMonExtendedInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX00000023 eAX00000023 = new EAX00000023();
            eAX00000023.ShowDialog();
        }

        private void eAX0x00000027AsymmetricRDTMQoSMonitoringEnumerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX00000027 eAX00000027 = new EAX00000027();
            eAX00000027.ShowDialog();
        }

        private void eAX0x00000028AsymmetricRDTAQoSAllocationEnumerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX00000028 eAX00000028 = new EAX00000028();
            eAX00000028.ShowDialog();
        }

        private void eAX0x00000029APXInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX00000029 eAX00000029 = new EAX00000029();
            eAX00000029.ShowDialog();
        }

        private void eAX0x00005A4ERiseMP6PrankLeafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX00005A4E eAX00005A4E = new EAX00005A4E();
            eAX00005A4E.ShowDialog();
        }

        private void eAX0x40000004ReservedForHypervisorsRecommendationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX40000004 eAX40000004 = new EAX40000004();
            eAX40000004.ShowDialog();
        }

        private void eAX0x40000005ReservedForHypervisorsLimitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX40000005 eAX40000005 = new EAX40000005();
            eAX40000005.ShowDialog();
        }

        private void eAX0x40000006ReservedForHypervisorsHardwareFeaturesDetectedAndInUseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX40000006 eAX40000006 = new EAX40000006();
            eAX40000006.ShowDialog();
        }

        private void eAX0x40000008ReservedForHypervisorsHypervisorSVMFeaturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX40000008 eAX40000008 = new EAX40000008();
            eAX40000008.ShowDialog();
        }

        private void eAX0x40000007ReservedForHypervisorsHypervisorCPUManagementFeaturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX40000007 eAX40000007 = new EAX40000007();
            eAX40000007.ShowDialog();
        }

        private void eAX0x40000009ReservedForHypervisorsNestedHypervisorFeatureIdentificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX40000009 eAX40000009 = new EAX40000009();
            eAX40000009.ShowDialog();
        }

        private void eAX0x4000000AReservedForHypervisorsHypervisorNestedVirtualizationFeaturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX4000000A eAX4000000A = new EAX4000000A();
            eAX4000000A.ShowDialog();
        }

        private void eAX0x4000000BReservedForHypervisorsUnknownUndocumentedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX4000000B eAX4000000B = new EAX4000000B();
            eAX4000000B.ShowDialog();
        }

        private void eAX0x4000000CReservedForHypervisorsIsolationConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX4000000C eAX4000000C = new EAX4000000C();
            eAX4000000C.ShowDialog();
        }

        private void eAX0x4C780001GetSupervisorInformationLinuxFlagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX4C780001 eAX4C780001 = new EAX4C780001();
            eAX4C780001.ShowDialog();
        }

        private void eAX0x4C780002GetSupervisorInformationLinuxBugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX4C780002 eAX4C780002 = new EAX4C780002();
            eAX4C780002.ShowDialog();
        }

        private void eAX0x40000010ReservedForHypervisorsFrequencyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX40000010 eAX40000010 = new EAX40000010();
            eAX40000010.ShowDialog();
        }

        private void eAX0x40000080SYNDBGVendorPlusMaxdeprecatedUnknownundocumentedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX40000080 eAX40000080 = new EAX40000080();
            eAX40000080.ShowDialog();
        }

        private void eAX0x40000081SYNDBGInterfacedeprecatedUndocumentedVirtualStackInterfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX40000081 eAX40000081 = new EAX40000081();
            eAX40000081.ShowDialog();
        }

        private void eAX0x40000082SYNDBGPlatformCapabilitiesdeprecatedUndocumentedVirtualStackPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX40000082 eAX40000082 = new EAX40000082();
            eAX40000082.ShowDialog();
        }

        private void eAX0x63634523ConfigLeavesRiseMP6ConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX63634523 eAX63634523 = new EAX63634523();
            eAX63634523.ShowDialog();
        }

        private void eAX0x6363452AConfigLeavesRiseMP6ConfigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX6363452A eAX6363452A = new EAX6363452A();
            eAX6363452A.ShowDialog();
        }

        private void eAX0x80000019TLBConfigurationDescriptorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX80000019 eAX80000019 = new EAX80000019();
            eAX80000019.ShowDialog();
        }

        private void eAX0x8000001APerformanceOptimizationIdentifiersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX8000001A eAX8000001A = new EAX8000001A();
            eAX8000001A.ShowDialog();
        }

        private void eAX0x8000001BIBSInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX8000001B eAX8000001B = new EAX8000001B();
            eAX8000001B.ShowDialog();
        }

        private void eAX0x8000001CLWPInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX8000001C eAX8000001C = new EAX8000001C();
            eAX8000001C.ShowDialog();
        }

        private void eAX0x8000001EAPICUnitNodeInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX8000001E eAX8000001E = new EAX8000001E();
            eAX8000001E.ShowDialog();
        }

        private void eAX0x80000020PlatformQoSEnumerationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX80000020 eAX80000020 = new EAX80000020();
            eAX80000020.ShowDialog();
        }

        private void eAX0x80000022ExtendedPerformanceMonitoringAndDebugInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX80000022 eAX80000022 = new EAX80000022();
            eAX80000022.ShowDialog();
        }

        private void eAX0x80000023SecureHostMultikeyMemoryEncryptionInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX80000023 eAX80000023 = new EAX80000023();
            eAX80000023.ShowDialog();
        }

        private void eAX0x80000026TopologyEnumerationInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX80000026 eAX80000026 = new EAX80000026();
            eAX80000026.ShowDialog();
        }

        private void eAX0x80000027WorkloadClassInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX80000027 eAX80000027 = new EAX80000027();
            eAX80000027.ShowDialog();
        }

        private void eAX0x80860000VendorLeavesTransmetaMaximumSupportedLeafAndVendorIDStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX80860000 eAX80860000 = new EAX80860000();
            eAX80860000.ShowDialog();
        }

        private void eAX0x80860001VendorLeavesTransmetaProcessorInformationFMSFlagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX80860001 eAX80860001 = new EAX80860001();
            eAX80860001.ShowDialog();
        }

        private void eAX0x80860002VendorLeavesTransmetaProcessorInformationHWSWRevisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX80860002 eAX80860002 = new EAX80860002();
            eAX80860002.ShowDialog();
        }

        private void eAX0x80860003EAX0x80860006VendorLeavesTransmetaCMSInfoStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX80860003_80860004_80860005_80860006 eAX80860003_80860004_80860005_80860006 = new EAX80860003_80860004_80860005_80860006();
            eAX80860003_80860004_80860005_80860006.ShowDialog();
        }

        private void eAX0x80860007VendorLeavesTransmetaProcessorInformationMHzMVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX80860007 eAX80860007 = new EAX80860007();
            eAX80860007.ShowDialog();
        }

        private void eAX0x80860008VendorLeavesTransmetaHypervisorInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX80860008 eAX80860008 = new EAX80860008();
            eAX80860008.ShowDialog();
        }

        private void eAX0x8FFFFFFEAMDEasterEggsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX8FFFFFFE eAX8FFFFFFE = new EAX8FFFFFFE();
            eAX8FFFFFFE.ShowDialog();
        }

        private void eAX0x8FFFFFFFAMDEasterEggsAMDPrankLeafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX8FFFFFFF eAX8FFFFFFF = new EAX8FFFFFFF();
            eAX8FFFFFFF.ShowDialog();
        }

        private void eAX0xC0000003CentaurProcessorSerialNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAXC0000003 eAXC0000003 = new EAXC0000003();
            eAXC0000003.ShowDialog();
        }

        private void eAX0xC0000004CentaurAndZhaoxinPerformanceInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAXC0000004 eAXC0000004 = new EAXC0000004();
            eAXC0000004.ShowDialog();
        }

        private void eAX0xC0000005ZhaoxinIsolationInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAXC0000005 eAXC0000005 = new EAXC0000005();
            eAXC0000005.ShowDialog();
        }

        private void eAX0x00000012SGXSECSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX00000012ECX1 eAX00000012ECX1 = new EAX00000012ECX1();
            eAX00000012ECX1.ShowDialog();
        }

        private void eAX0x00000012SGXEPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX00000012ECXN eAX00000012ECXN = new EAX00000012ECXN(2);
            eAX00000012ECXN.ShowDialog();
        }
    }
}
