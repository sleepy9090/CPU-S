/*
    File           Form1.cs
    Brief          Main form for CPU information display.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           05/29/2026
    Author         Shawn M. Crawford [sleepy]
*/
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

            #region EAX = 0x0: Highest Function Parameter and Manufacturer ID

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

            #endregion

            #region EAX=0x1: Processor Info and Feature Bits

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

            bool cpuIdEAX1ECX3_MONITORIsSupported = cpuHelper.GetEAX1ECX3_MONITORIsSupportedX();
            Console.WriteLine($"EAX1ECX3_MONITORIsSupported: {cpuIdEAX1ECX3_MONITORIsSupported}");

            bool cpuIdEAX1ECX4_DSCPLIsSupported = cpuHelper.GetEAX1ECX4_DSCPLIsSupportedX();
            Console.WriteLine($"EAX1ECX4_DSCPLIsSupported: {cpuIdEAX1ECX4_DSCPLIsSupported}");

            bool cpuIdEAX1ECX5_VMXIsSupported = cpuHelper.GetEAX1ECX5_VMXIsSupportedX();
            Console.WriteLine($"EAX1ECX5_VMXIsSupported: {cpuIdEAX1ECX5_VMXIsSupported}");

            bool cpuIdEAX1ECX6_SMXIsSupported = cpuHelper.GetEAX1ECX6_SMXIsSupportedX();
            Console.WriteLine($"EAX1ECX6_SMXIsSupported: {cpuIdEAX1ECX6_SMXIsSupported}");

            bool cpuIdEAX1ECX7_ESTIsSupported = cpuHelper.GetEAX1ECX7_ESTIsSupportedX();
            Console.WriteLine($"EAX1ECX7_ESTIsSupported: {cpuIdEAX1ECX7_ESTIsSupported}");

            bool cpuIdEAX1ECX8_TM2IsSupported = cpuHelper.GetEAX1ECX8_TM2IsSupportedX();
            Console.WriteLine($"EAX1ECX8_TM2IsSupported: {cpuIdEAX1ECX8_TM2IsSupported}");

            bool cpuIdEAX1ECX9_SSSE3IsSupported = cpuHelper.GetEAX1ECX9_SSSE3IsSupportedX();
            Console.WriteLine($"EAX1ECX9_SSSE3IsSupported: {cpuIdEAX1ECX9_SSSE3IsSupported}");

            bool cpuIdEAX1ECX10_CNXTIDIsSupported = cpuHelper.GetEAX1ECX10_CNXTIDIsSupportedX();
            Console.WriteLine($"EAX1ECX10_CNXTIDIsSupported: {cpuIdEAX1ECX10_CNXTIDIsSupported}");

            bool cpuIdEAX1ECX11_SDBGIsSupported = cpuHelper.GetEAX1ECX11_SDBGIsSupportedX();
            Console.WriteLine($"EAX1ECX11_SDBGIsSupported: {cpuIdEAX1ECX11_SDBGIsSupported}");

            bool cpuIdEAX1ECX12_FMAIsSupported = cpuHelper.GetEAX1ECX12_FMAIsSupportedX();
            Console.WriteLine($"EAX1ECX12_FMAIsSupported: {cpuIdEAX1ECX12_FMAIsSupported}");

            bool cpuIdEAX1ECX13_CMPXCHG16BIsSupported = cpuHelper.GetEAX1ECX13_CMPXCHG16BIsSupportedX();
            Console.WriteLine($"EAX1ECX13_CMPXCHG16BIsSupported: {cpuIdEAX1ECX13_CMPXCHG16BIsSupported}");

            bool cpuIdEAX1ECX14_xTPRUpdateControlIsSupported = cpuHelper.GetEAX1ECX14_xTPRUpdateControlIsSupportedX();
            Console.WriteLine($"EAX1ECX14_xTPRUpdateControlIsSupported: {cpuIdEAX1ECX14_xTPRUpdateControlIsSupported}");

            bool cpuIdEAX1ECX15_PDCMIsSupported = cpuHelper.GetEAX1ECX15_PDCMIsSupportedX();
            Console.WriteLine($"EAX1ECX15_PDCMIsSupported: {cpuIdEAX1ECX15_PDCMIsSupported}");

            bool cpuIdEAX1ECX16_ReservedIsSupported = cpuHelper.GetEAX1ECX16_ReservedIsSupportedX();
            Console.WriteLine($"EAX1ECX16_ReservedIsSupported: {cpuIdEAX1ECX16_ReservedIsSupported}");

            bool cpuIdEAX1ECX17_PCIDIsSupported = cpuHelper.GetEAX1ECX17_PCIDIsSupportedX();
            Console.WriteLine($"EAX1ECX17_PCIDIsSupported: {cpuIdEAX1ECX17_PCIDIsSupported}");

            bool cpuIdEAX1ECX18_DCAIsSupported = cpuHelper.GetEAX1ECX18_DCAIsSupportedX();
            Console.WriteLine($"EAX1ECX18_DCAIsSupported: {cpuIdEAX1ECX18_DCAIsSupported}");

            bool cpuIdEAX1ECX19_SSE41IsSupported = cpuHelper.GetEAX1ECX19_SSE41IsSupportedX();
            Console.WriteLine($"EAX1ECX19_SSE41IsSupported: {cpuIdEAX1ECX19_SSE41IsSupported}");

            bool cpuIdEAX1ECX20_SSE42IsSupported = cpuHelper.GetEAX1ECX20_SSE42IsSupportedX();
            Console.WriteLine($"EAX1ECX20_SSE42IsSupported: {cpuIdEAX1ECX20_SSE42IsSupported}");

            bool cpuIdEAX1ECX21_X2APICIsSupported = cpuHelper.GetEAX1ECX21_X2APICIsSupportedX();
            Console.WriteLine($"EAX1ECX21_X2APICIsSupported: {cpuIdEAX1ECX21_X2APICIsSupported}");

            bool cpuIdEAX1ECX22_MOVBEIsSupported = cpuHelper.GetEAX1ECX22_MOVBEIsSupportedX();
            Console.WriteLine($"EAX1ECX22_MOVBEIsSupported: {cpuIdEAX1ECX22_MOVBEIsSupported}");

            bool cpuIdEAX1ECX23_POPCNTIsSupported = cpuHelper.GetEAX1ECX23_POPCNTIsSupportedX();
            Console.WriteLine($"EAX1ECX23_POPCNTIsSupported: {cpuIdEAX1ECX23_POPCNTIsSupported}");

            bool cpuIdEAX1ECX24_TSCDeadlineIsSupported = cpuHelper.GetEAX1ECX24_TSCDeadlineIsSupportedX();
            Console.WriteLine($"EAX1ECX24_TSCDeadlineIsSupported: {cpuIdEAX1ECX24_TSCDeadlineIsSupported}");

            bool cpuIdEAX1ECX25_AESNIIsSupported = cpuHelper.GetEAX1ECX25_AESNIIsSupportedX();
            Console.WriteLine($"EAX1ECX25_AESNIIsSupported: {cpuIdEAX1ECX25_AESNIIsSupported}");

            bool cpuIdEAX1ECX26_XSAVEIsSupported = cpuHelper.GetEAX1ECX26_XSAVEIsSupportedX();
            Console.WriteLine($"EAX1ECX26_XSAVEIsSupported: {cpuIdEAX1ECX26_XSAVEIsSupported}");

            bool cpuIdEAX1ECX27_OSXSAVEIsSupported = cpuHelper.GetEAX1ECX27_OSXSAVEIsSupportedX();
            Console.WriteLine($"EAX1ECX27_OSXSAVEIsSupported: {cpuIdEAX1ECX27_OSXSAVEIsSupported}");

            bool cpuIdEAX1ECX28_AVXIsSupported = cpuHelper.GetEAX1ECX28_AVXIsSupportedX();
            Console.WriteLine($"EAX1ECX28_AVXIsSupported: {cpuIdEAX1ECX28_AVXIsSupported}");

            bool cpuIdEAX1ECX29_F16CIsSupported = cpuHelper.GetEAX1ECX29_F16CIsSupportedX();
            Console.WriteLine($"EAX1ECX29_F16CIsSupported: {cpuIdEAX1ECX29_F16CIsSupported}");

            bool cpuIdEAX1ECX30_RDRANDIsSupported = cpuHelper.GetEAX1ECX30_RDRANDIsSupportedX();
            Console.WriteLine($"EAX1ECX30_RDRANDIsSupported: {cpuIdEAX1ECX30_RDRANDIsSupported}");

            bool cpuIdEAX1ECX31_HypervisorIsSupported = cpuHelper.GetEAX1ECX31_HypervisorIsSupportedX();
            Console.WriteLine($"EAX1ECX31_HypervisorIsSupported: {cpuIdEAX1ECX31_HypervisorIsSupported}");

            bool cpuIdEAX1EDX0_FPUIsSupported = cpuHelper.GetEAX1EDX0_FPUIsSupportedX();
            Console.WriteLine($"EAX1EDX0_FPUIsSupported: {cpuIdEAX1EDX0_FPUIsSupported}");

            bool cpuIdEAX1EDX1_VMEIsSupported = cpuHelper.GetEAX1EDX1_VMEIsSupportedX();
            Console.WriteLine($"EAX1EDX1_VMEIsSupported: {cpuIdEAX1EDX1_VMEIsSupported}");

            bool cpuIdEAX1EDX2_DEIsSupported = cpuHelper.GetEAX1EDX2_DEIsSupportedX();
            Console.WriteLine($"EAX1EDX2_DEIsSupported: {cpuIdEAX1EDX2_DEIsSupported}");

            bool cpuIdEAX1EDX3_PSEIsSupported = cpuHelper.GetEAX1EDX3_PSEIsSupportedX();
            Console.WriteLine($"EAX1EDX3_PSEIsSupported: {cpuIdEAX1EDX3_PSEIsSupported}");

            bool cpuIdEAX1EDX4_TSCIsSupported = cpuHelper.GetEAX1EDX4_TSCIsSupportedX();
            Console.WriteLine($"EAX1EDX4_TSCIsSupported: {cpuIdEAX1EDX4_TSCIsSupported}");

            bool cpuIdEAX1EDX5_MSRIsSupported = cpuHelper.GetEAX1EDX5_MSRIsSupportedX();
            Console.WriteLine($"EAX1EDX5_MSRIsSupported: {cpuIdEAX1EDX5_MSRIsSupported}");

            bool cpuIdEAX1EDX6_PAEIsSupported = cpuHelper.GetEAX1EDX6_PAEIsSupportedX();
            Console.WriteLine($"EAX1EDX6_PAEIsSupported: {cpuIdEAX1EDX6_PAEIsSupported}");

            bool cpuIdEAX1EDX7_MCEIsSupported = cpuHelper.GetEAX1EDX7_MCEIsSupportedX();
            Console.WriteLine($"EAX1EDX7_MCEIsSupported: {cpuIdEAX1EDX7_MCEIsSupported}");

            bool cpuIdEAX1EDX8_CX8IsSupported = cpuHelper.GetEAX1EDX8_CX8IsSupportedX();
            Console.WriteLine($"EAX1EDX8_CX8IsSupported: {cpuIdEAX1EDX8_CX8IsSupported}");

            bool cpuIdEAX1EDX9_APICIsSupported = cpuHelper.GetEAX1EDX9_APICIsSupportedX();
            Console.WriteLine($"EAX1EDX9_APICIsSupported: {cpuIdEAX1EDX9_APICIsSupported}");

            bool cpuIdEAX1EDX10_ReservedIsSupported = cpuHelper.GetEAX1EDX10_ReservedIsSupportedX();
            Console.WriteLine($"EAX1EDX10_ReservedIsSupported: {cpuIdEAX1EDX10_ReservedIsSupported}");

            bool cpuIdEAX1EDX11_SEPIsSupported = cpuHelper.GetEAX1EDX11_SEPIsSupportedX();
            Console.WriteLine($"EAX1EDX11_SEPIsSupported: {cpuIdEAX1EDX11_SEPIsSupported}");

            bool cpuIdEAX1EDX12_MTRRIsSupported = cpuHelper.GetEAX1EDX12_MTRRIsSupportedX();
            Console.WriteLine($"EAX1EDX12_MTRRIsSupported: {cpuIdEAX1EDX12_MTRRIsSupported}");

            bool cpuIdEAX1EDX13_PGEIsSupported = cpuHelper.GetEAX1EDX13_PGEIsSupportedX();
            Console.WriteLine($"EAX1EDX13_PGEIsSupported: {cpuIdEAX1EDX13_PGEIsSupported}");

            bool cpuIdEAX1EDX14_MCAIsSupported = cpuHelper.GetEAX1EDX14_MCAIsSupportedX();
            Console.WriteLine($"EAX1EDX14_MCAIsSupported: {cpuIdEAX1EDX14_MCAIsSupported}");

            bool cpuIdEAX1EDX15_CMOVIsSupported = cpuHelper.GetEAX1EDX15_CMOVIsSupportedX();
            Console.WriteLine($"EAX1EDX15_CMOVIsSupported: {cpuIdEAX1EDX15_CMOVIsSupported}");

            bool cpuIdEAX1EDX16_PATIsSupported = cpuHelper.GetEAX1EDX16_PATIsSupportedX();
            Console.WriteLine($"EAX1EDX16_PATIsSupported: {cpuIdEAX1EDX16_PATIsSupported}");

            bool cpuIdEAX1EDX17_PSE36IsSupported = cpuHelper.GetEAX1EDX17_PSE36IsSupportedX();
            Console.WriteLine($"EAX1EDX17_PSE36IsSupported: {cpuIdEAX1EDX17_PSE36IsSupported}");

            bool cpuIdEAX1EDX18_PSNIsSupported = cpuHelper.GetEAX1EDX18_PSNIsSupportedX();
            Console.WriteLine($"EAX1EDX18_PSNIsSupported: {cpuIdEAX1EDX18_PSNIsSupported}");

            bool cpuIdEAX1EDX19_CLFSHIsSupported = cpuHelper.GetEAX1EDX19_CLFSHIsSupportedX();
            Console.WriteLine($"EAX1EDX19_CLFSHIsSupported: {cpuIdEAX1EDX19_CLFSHIsSupported}");

            bool cpuIdEAX1EDX20_NXIsSupported = cpuHelper.GetEAX1EDX20_NXIsSupportedX();
            Console.WriteLine($"EAX1EDX20_NXIsSupported: {cpuIdEAX1EDX20_NXIsSupported}");

            bool cpuIdEAX1EDX21_DSIsSupported = cpuHelper.GetEAX1EDX21_DSIsSupportedX();
            Console.WriteLine($"EAX1EDX21_DSIsSupported: {cpuIdEAX1EDX21_DSIsSupported}");

            bool cpuIdEAX1EDX22_ACPIIsSupported = cpuHelper.GetEAX1EDX22_ACPIIsSupportedX();
            Console.WriteLine($"EAX1EDX22_ACPIIsSupported: {cpuIdEAX1EDX22_ACPIIsSupported}");

            bool cpuIdEAX1EDX23_MMXIsSupported = cpuHelper.GetEAX1EDX23_MMXIsSupportedX();
            Console.WriteLine($"EAX1EDX23_MMXIsSupported: {cpuIdEAX1EDX23_MMXIsSupported}");

            bool cpuIdEAX1EDX24_FXSRIsSupported = cpuHelper.GetEAX1EDX24_FXSRIsSupportedX();
            Console.WriteLine($"EAX1EDX24_FXSRIsSupported: {cpuIdEAX1EDX24_FXSRIsSupported}");

            bool cpuIdEAX1EDX25_SSEIsSupported = cpuHelper.GetEAX1EDX25_SSEIsSupportedX();
            Console.WriteLine($"EAX1EDX25_SSEIsSupported: {cpuIdEAX1EDX25_SSEIsSupported}");

            bool cpuIdEAX1EDX26_SSE2IsSupported = cpuHelper.GetEAX1EDX26_SSE2IsSupportedX();
            Console.WriteLine($"EAX1EDX26_SSE2IsSupported: {cpuIdEAX1EDX26_SSE2IsSupported}");

            bool cpuIdEAX1EDX27_SSIsSupported = cpuHelper.GetEAX1EDX27_SSIsSupportedX();
            Console.WriteLine($"EAX1EDX27_SSIsSupported: {cpuIdEAX1EDX27_SSIsSupported}");
            
            bool cpuIdEAX1EDX28_HTTIsSupported = cpuHelper.GetEAX1EDX28_HTTIsSupportedX();
            Console.WriteLine($"EAX1EDX28_HTTIsSupported: {cpuIdEAX1EDX28_HTTIsSupported}");

            bool cpuIdEAX1EDX29_TMIsSupported = cpuHelper.GetEAX1EDX29_TMIsSupportedX();
            Console.WriteLine($"EAX1EDX29_TMIsSupported: {cpuIdEAX1EDX29_TMIsSupported}");

            bool cpuIdEAX1EDX30_IA64IsSupported = cpuHelper.GetEAX1EDX30_IA64IsSupportedX();
            Console.WriteLine($"EAX1EDX30_IA64IsSupported: {cpuIdEAX1EDX30_IA64IsSupported}");

            bool cpuIdEAX1EDX31_PBEIsSupported = cpuHelper.GetEAX1EDX31_PBEIsSupportedX();
            Console.WriteLine($"EAX1EDX31_PBEIsSupported: {cpuIdEAX1EDX31_PBEIsSupported}");

            #endregion

            #region EAX=0x2: Cache and TLB Descriptor Information

            string cpuIdEAX2EAX = cpuHelper.GetEAX2EAXX();
            Console.WriteLine($"EAX2EAX: {cpuIdEAX2EAX}");

            string cpuIdEAX2EBX = cpuHelper.GetEAX2EBXX();
            Console.WriteLine($"EAX2EBX: {cpuIdEAX2EBX}");

            string cpuIdEAX2ECX = cpuHelper.GetEAX2ECXX();
            Console.WriteLine($"EAX2ECX: {cpuIdEAX2ECX}");

            string cpuIdEAX2EDX = cpuHelper.GetEAX2EDXX();
            Console.WriteLine($"EAX2EDX: {cpuIdEAX2EDX}");

            string cpuIdEAX2_EAX31_IsInvalidCacheAndTblDescriptorsEAX = cpuHelper.GetEAX2_EAX31_IsInvalidCacheAndTblDescriptorsEAXX();
            Console.WriteLine($"EAX2_EAX31_IsInvalidCacheAndTblDescriptorsEAX: {cpuIdEAX2_EAX31_IsInvalidCacheAndTblDescriptorsEAX}");

            string cpuIdEAX2_EAX0_7_NumberOfTimeToQueryCPUIDWithEAX2 = cpuHelper.GetEAX2_EAX0_7_NumberOfTimeToQueryCPUIDWithEAX2X();
            Console.WriteLine($"EAX2_EAX0_7_NumberOfTimeToQueryCPUIDWithEAX2: {cpuIdEAX2_EAX0_7_NumberOfTimeToQueryCPUIDWithEAX2}");

            string cpuIdEAX2_EAX8_15_CacheAndTLBDescriptorInformation1 = cpuHelper.GetEAX2_EAX8_15_CacheAndTLBDescriptorInformation1X();
            Console.WriteLine($"EAX2_EAX8_15_CacheAndTLBDescriptorInformation1: {cpuIdEAX2_EAX8_15_CacheAndTLBDescriptorInformation1}");

            string cpuIdEAX2_EAX16_23_CacheAndTLBDescriptorInformation2 = cpuHelper.GetEAX2_EAX16_23_CacheAndTLBDescriptorInformation2X();
            Console.WriteLine($"EAX2_EAX16_23_CacheAndTLBDescriptorInformation2: {cpuIdEAX2_EAX16_23_CacheAndTLBDescriptorInformation2}");

            string cpuIdEAX2_EAX24_31_CacheAndTLBDescriptorInformation3 = cpuHelper.GetEAX2_EAX24_31_CacheAndTLBDescriptorInformation3X();
            Console.WriteLine($"EAX2_EAX24_31_CacheAndTLBDescriptorInformation3: {cpuIdEAX2_EAX24_31_CacheAndTLBDescriptorInformation3}");

            string cpuIdEAX2_EBX31_IsInvalidCacheAndTblDescriptorsEBX = cpuHelper.GetEAX2_EBX31_IsInvalidCacheAndTblDescriptorsEBXX();
            Console.WriteLine($"EAX2_EBX31_IsInvalidCacheAndTblDescriptorsEBX: {cpuIdEAX2_EBX31_IsInvalidCacheAndTblDescriptorsEBX}");

            string cpuIdEAX2_EBX8_15_CacheAndTLBDescriptorInformation1 = cpuHelper.GetEAX2_EBX8_15_CacheAndTLBDescriptorInformation1X();
            Console.WriteLine($"EAX2_EBX8_15_CacheAndTLBDescriptorInformation1: {cpuIdEAX2_EBX8_15_CacheAndTLBDescriptorInformation1}");

            string cpuIdEAX2_EBX16_23_CacheAndTLBDescriptorInformation2 = cpuHelper.GetEAX2_EBX16_23_CacheAndTLBDescriptorInformation2X();
            Console.WriteLine($"EAX2_EBX16_23_CacheAndTLBDescriptorInformation2: {cpuIdEAX2_EBX16_23_CacheAndTLBDescriptorInformation2}");

            string cpuIdEAX2_EBX24_31_CacheAndTLBDescriptorInformation3 = cpuHelper.GetEAX2_EBX24_31_CacheAndTLBDescriptorInformation3X();
            Console.WriteLine($"EAX2_EBX24_31_CacheAndTLBDescriptorInformation3: {cpuIdEAX2_EBX24_31_CacheAndTLBDescriptorInformation3}");

            string cpuIdEAX2_ECX31_IsInvalidCacheAndTblDescriptorsECX = cpuHelper.GetEAX2_ECX31_IsInvalidCacheAndTblDescriptorsECXX();
            Console.WriteLine($"EAX2_ECX31_IsInvalidCacheAndTblDescriptorsECX: {cpuIdEAX2_ECX31_IsInvalidCacheAndTblDescriptorsECX}");

            string cpuIdEAX2_ECX8_15_CacheAndTLBDescriptorInformation1 = cpuHelper.GetEAX2_ECX8_15_CacheAndTLBDescriptorInformation1X();
            Console.WriteLine($"EAX2_ECX8_15_CacheAndTLBDescriptorInformation1: {cpuIdEAX2_ECX8_15_CacheAndTLBDescriptorInformation1}");

            string cpuIdEAX2_ECX16_23_CacheAndTLBDescriptorInformation2 = cpuHelper.GetEAX2_ECX16_23_CacheAndTLBDescriptorInformation2X();
            Console.WriteLine($"EAX2_ECX16_23_CacheAndTLBDescriptorInformation2: {cpuIdEAX2_ECX16_23_CacheAndTLBDescriptorInformation2}");

            string cpuIdEAX2_ECX24_31_CacheAndTLBDescriptorInformation3 = cpuHelper.GetEAX2_ECX24_31_CacheAndTLBDescriptorInformation3X();
            Console.WriteLine($"EAX2_ECX24_31_CacheAndTLBDescriptorInformation3: {cpuIdEAX2_ECX24_31_CacheAndTLBDescriptorInformation3}");

            string cpuIdEAX2_EDX31_IsInvalidCacheAndTblDescriptorsEDX = cpuHelper.GetEAX2_EDX31_IsInvalidCacheAndTblDescriptorsEDXX();
            Console.WriteLine($"EAX2_EDX31_IsInvalidCacheAndTblDescriptorsEDX: {cpuIdEAX2_EDX31_IsInvalidCacheAndTblDescriptorsEDX}");

            string cpuIdEAX2_EDX8_15_CacheAndTLBDescriptorInformation1 = cpuHelper.GetEAX2_EDX8_15_CacheAndTLBDescriptorInformation1X();
            Console.WriteLine($"EAX2_EDX8_15_CacheAndTLBDescriptorInformation1: {cpuIdEAX2_EDX8_15_CacheAndTLBDescriptorInformation1}");

            string cpuIdEAX2_EDX16_23_CacheAndTLBDescriptorInformation2 = cpuHelper.GetEAX2_EDX16_23_CacheAndTLBDescriptorInformation2X();
            Console.WriteLine($"EAX2_EDX16_23_CacheAndTLBDescriptorInformation2: {cpuIdEAX2_EDX16_23_CacheAndTLBDescriptorInformation2}");

            string cpuIdEAX2_EDX24_31_CacheAndTLBDescriptorInformation3 = cpuHelper.GetEAX2_EDX24_31_CacheAndTLBDescriptorInformation3X();
            Console.WriteLine($"EAX2_EDX24_31_CacheAndTLBDescriptorInformation3: {cpuIdEAX2_EDX24_31_CacheAndTLBDescriptorInformation3}");

            #endregion

            #region EAX=0x3: Processor Serial Number

            string cpuIdEAX3EAX = cpuHelper.GetEAX3EAXX();
            Console.WriteLine($"EAX3EAX: {cpuIdEAX3EAX}");

            string cpuIdEAX3EBX = cpuHelper.GetEAX3EBXX();
            Console.WriteLine($"EAX3EBX: {cpuIdEAX3EBX}");

            string cpuIdEAX3ECX = cpuHelper.GetEAX3ECXX();
            Console.WriteLine($"EAX3ECX: {cpuIdEAX3ECX}");

            string cpuIdEAX3EDX = cpuHelper.GetEAX3EDXX();
            Console.WriteLine($"EAX3EDX: {cpuIdEAX3EDX}");

            string cpuIdeAX3_EAX_EDX_ECX_Pentium3CPU96BitSerialNumberString = cpuHelper.GetEAX3_EAX_EDX_ECX_Pentium3CPU96BitSerialNumberX();
            Console.WriteLine($"Pentium 3 CPU 96-Bit Serial Number: {cpuIdeAX3_EAX_EDX_ECX_Pentium3CPU96BitSerialNumberString}");

            string cpuIdeAX3_EAX_EDX_ECX_TransmetaCrusoeAndEfficeonCPU128BitSerialNumberString = cpuHelper.GetEAX3_EAX_EDX_ECX_TransmetaCrusoeAndEfficeonCPU128BitSerialNumberX();
            Console.WriteLine($"Transmeta Crusoe and Efficeon CPU 128-Bit Serial Number: {cpuIdeAX3_EAX_EDX_ECX_TransmetaCrusoeAndEfficeonCPU128BitSerialNumberString}");

            #endregion

            #region EAX=0x4 and EAX=0x8000001D: Cache Hierarchy and Topology

            string cpuIdEAX4EAX = cpuHelper.GetEAX4EAXX();
            Console.WriteLine($"EAX4EAX: {cpuIdEAX4EAX}");

            string cpuIdEAX4EBX = cpuHelper.GetEAX4EBXX();
            Console.WriteLine($"EAX4EBX: {cpuIdEAX4EBX}");

            string cpuIdEAX4ECX = cpuHelper.GetEAX4ECXX();
            Console.WriteLine($"EAX4ECX: {cpuIdEAX4ECX}");

            string cpuIdEAX4EDX = cpuHelper.GetEAX4EDXX();
            Console.WriteLine($"EAX4EDX: {cpuIdEAX4EDX}");

            string cpuIdEAX8000001DEAX = cpuHelper.GetEAX8000001DEAXX();
            Console.WriteLine($"EAX8000001DEAX: {cpuIdEAX8000001DEAX}");

            string cpuIdEAX8000001DEBX = cpuHelper.GetEAX8000001DEBXX();
            Console.WriteLine($"EAX8000001DEBX: {cpuIdEAX8000001DEBX}");

            string cpuIdEAX8000001DECX = cpuHelper.GetEAX8000001DECXX();
            Console.WriteLine($"EAX8000001DECX: {cpuIdEAX8000001DECX}");

            string cpuIdEAX8000001DEDX = cpuHelper.GetEAX8000001DEDXX();
            Console.WriteLine($"EAX8000001DEDX: {cpuIdEAX8000001DEDX}");

            #endregion

            #region EAX=0x4 and EAX=0xB: Intel Thread/Core and Cache Topology

            string cpuIdEAXBEAX = cpuHelper.GetEAXBEAXX();
            Console.WriteLine($"EAXBEAX: {cpuIdEAXBEAX}");

            string cpuIdEAXBEBX = cpuHelper.GetEAXBEBXX();
            Console.WriteLine($"EAXBEBX: {cpuIdEAXBEBX}");

            string cpuIdEAXBEECX = cpuHelper.GetEAXBECXX();
            Console.WriteLine($"EAXBECX: {cpuIdEAXBEECX}");

            string cpuIdEAXBEDX = cpuHelper.GetEAXBEDXX();
            Console.WriteLine($"EAXBEDX: {cpuIdEAXBEDX}");

            #endregion

            #region EAX=0x5: MONITOR/MWAIT Features

            string cpuIdEAX5EAX = cpuHelper.GetEAX5EAXX();
            Console.WriteLine($"EAX5EAX: {cpuIdEAX5EAX}");

            string cpuIdEAX5EBX = cpuHelper.GetEAX5EBXX();
            Console.WriteLine($"EAX5EBX: {cpuIdEAX5EBX}");

            string cpuIdEAX5ECX = cpuHelper.GetEAX5ECXX();
            Console.WriteLine($"EAX5ECX: {cpuIdEAX5ECX}");

            string cpuIdEAX5EDX = cpuHelper.GetEAX5EDXX();
            Console.WriteLine($"EAX5EDX: {cpuIdEAX5EDX}");

            string cpuIdEAX5_EAX0_15_SmallestMonitorLineSize = cpuHelper.GetEAX5_EAX0_15_SmallestMonitorLineSizeX();
            Console.WriteLine($"EAX5EAX0_15_SmallestMonitorLineSize: {cpuIdEAX5_EAX0_15_SmallestMonitorLineSize}");

            string cpuIdEAX5_EAX16_31_Reserved = cpuHelper.GetEAX5_EAX16_31_ReservedX();
            Console.WriteLine($"EAX5EAX16_31_Reserved: {cpuIdEAX5_EAX16_31_Reserved}");

            string cpuIdEAX5_EBX0_15_LargestMonitorLineSize = cpuHelper.GetEAX5_EBX0_15_LargestMonitorLineSizeX();
            Console.WriteLine($"EAX5EBX0_15_LargestMonitorLineSize: {cpuIdEAX5_EBX0_15_LargestMonitorLineSize}");

            string cpuIdEAX5_EBX16_31_Reserved = cpuHelper.GetEAX5_EBX16_31_ReservedX();
            Console.WriteLine($"EAX5EBX16_31_Reserved: {cpuIdEAX5_EBX16_31_Reserved}");

            string cpuIdEAX5_ECX0_EnumOfMonitorMWAITExtensionsInECXAndEDXSupported_EMX = cpuHelper.GetEAX5_ECX0_EnumOfMonitorMWAITExtensionsInECXAndEDXSupported_EMXX();
            Console.WriteLine($"EAX5ECX0_EnumOfMonitorMWAITExtensionsInECXAndEDXSupported_EMX: {cpuIdEAX5_ECX0_EnumOfMonitorMWAITExtensionsInECXAndEDXSupported_EMX}");

            string cpuIdEAX5_ECX1_SupportsTreatingInterruptsAsBreakEventsForMWAITEvenWhenInterruptsAreDisabled_IBE = cpuHelper.GetEAX5_ECX1_SupportsTreatingInterruptsAsBreakEventsForMWAITEvenWhenInterruptsAreDisabled_IBEX();
            Console.WriteLine($"EAX5ECX1_SupportsTreatingInterruptsAsBreakEventsForMWAITEvenWhenInterruptsAreDisabled_IBE: {cpuIdEAX5_ECX1_SupportsTreatingInterruptsAsBreakEventsForMWAITEvenWhenInterruptsAreDisabled_IBE}");

            string cpuIdEAX5_ECX2_Reserved = cpuHelper.GetEAX5_ECX2_ReservedX();
            Console.WriteLine($"EAX5ECX2_Reserved: {cpuIdEAX5_ECX2_Reserved}");

            string cpuIdEAX5_ECX3_AllowMWAITToBeUsedForPowerManagementWithoutSettingUpMemoryMonitoringWithMONITOR_Monitorless_MWAIT = cpuHelper.GetEAX5_ECX3_AllowMWAITToBeUsedForPowerManagementWithoutSettingUpMemoryMonitoringWithMONITOR_Monitorless_MWAITX();
            Console.WriteLine($"EAX5ECX3_AllowMWAITToBeUsedForPowerManagementWithoutSettingUpMemoryMonitoringWithMONITOR_Monitorless_MWAIT: {cpuIdEAX5_ECX3_AllowMWAITToBeUsedForPowerManagementWithoutSettingUpMemoryMonitoringWithMONITOR_Monitorless_MWAIT}");

            string cpuIdEAX5_ECX4_31_Reserved = cpuHelper.GetEAX5_ECX4_31_ReservedX();
            Console.WriteLine($"EAX5ECX4_31_Reserved: {cpuIdEAX5_ECX4_31_Reserved}");

            string cpuIdEAX5_EDX0_3_NumberOfC0SubStatesSupportedForMWAIT = cpuHelper.GetEAX5_EDX0_3_NumberOfC0SubStatesSupportedForMWAITX();
            Console.WriteLine($"EAX5EDX0_3_NumberOfC0SubStatesSupportedForMWAIT: {cpuIdEAX5_EDX0_3_NumberOfC0SubStatesSupportedForMWAIT}");

            string cpuIdEAX5_EDX4_7_NumberOfC1SubStatesSupportedForMWAIT = cpuHelper.GetEAX5_EDX4_7_NumberOfC1SubStatesSupportedForMWAITX();
            Console.WriteLine($"EAX5EDX4_7_NumberOfC1SubStatesSupportedForMWAIT: {cpuIdEAX5_EDX4_7_NumberOfC1SubStatesSupportedForMWAIT}");

            string cpuIdEAX5_EDX8_11_NumberOfC2SubStatesSupportedForMWAIT = cpuHelper.GetEAX5_EDX8_11_NumberOfC2SubStatesSupportedForMWAITX();
            Console.WriteLine($"EAX5EDX8_11_NumberOfC2SubStatesSupportedForMWAIT: {cpuIdEAX5_EDX8_11_NumberOfC2SubStatesSupportedForMWAIT}");

            string cpuIdEAX5_EDX12_15_NumberOfC3SubStatesSupportedForMWAIT = cpuHelper.GetEAX5_EDX12_15_NumberOfC3SubStatesSupportedForMWAITX();
            Console.WriteLine($"EAX5EDX12_15_NumberOfC3SubStatesSupportedForMWAIT: {cpuIdEAX5_EDX12_15_NumberOfC3SubStatesSupportedForMWAIT}");

            string cpuIdEAX5_EDX16_19_NumberOfC4SubStatesSupportedForMWAIT = cpuHelper.GetEAX5_EDX16_19_NumberOfC4SubStatesSupportedForMWAITX();
            Console.WriteLine($"EAX5EDX16_19_NumberOfC4SubStatesSupportedForMWAIT: {cpuIdEAX5_EDX16_19_NumberOfC4SubStatesSupportedForMWAIT}");

            string cpuIdEAX5_EDX20_23_NumberOfC5SubStatesSupportedForMWAIT = cpuHelper.GetEAX5_EDX20_23_NumberOfC5SubStatesSupportedForMWAITX();
            Console.WriteLine($"EAX5EDX20_23_NumberOfC5SubStatesSupportedForMWAIT: {cpuIdEAX5_EDX20_23_NumberOfC5SubStatesSupportedForMWAIT}");

            string cpuIdEAX5_EDX24_27_NumberOfC6SubStatesSupportedForMWAIT = cpuHelper.GetEAX5_EDX24_27_NumberOfC6SubStatesSupportedForMWAITX();
            Console.WriteLine($"EAX5EDX24_27_NumberOfC6SubStatesSupportedForMWAIT: {cpuIdEAX5_EDX24_27_NumberOfC6SubStatesSupportedForMWAIT}");

            string cpuIdEAX5_EDX28_31_NumberOfC7SubStatesSupportedForMWAIT = cpuHelper.GetEAX5_EDX28_31_NumberOfC7SubStatesSupportedForMWAITX();
            Console.WriteLine($"EAX5EDX28_31_NumberOfC7SubStatesSupportedForMWAIT: {cpuIdEAX5_EDX28_31_NumberOfC7SubStatesSupportedForMWAIT}");

            #endregion

            #region region EAX=0x6: Thermal and Power Management

            string cpuIdEAX6EAX = cpuHelper.GetEAX6EAXX();
            Console.WriteLine($"EAX6EAX: {cpuIdEAX6EAX}");

            string cpuIdEAX6EBX = cpuHelper.GetEAX6EBXX();
            Console.WriteLine($"EAX6EBX: {cpuIdEAX6EBX}");

            string cpuIdEAX6ECX = cpuHelper.GetEAX6ECXX();
            Console.WriteLine($"EAX6ECX: {cpuIdEAX6ECX}");

            string cpuIdEAX6EDX = cpuHelper.GetEAX6EDXX();
            Console.WriteLine($"EAX6EDX: {cpuIdEAX6EDX}");

            bool cpuIdEAX6EAX0_DTSIsSupported = cpuHelper.GetEAX6EAX0_DTSIsSupportedX();
            Console.WriteLine($"EAX6EAX0_DTSIsSupported: {cpuIdEAX6EAX0_DTSIsSupported}");

            bool cpuIdEAX6EAX1_TURBO_BOOSTIsSupported = cpuHelper.GetEAX6EAX1_TURBO_BOOSTIsSupportedX();
            Console.WriteLine($"EAX6EAX1_TURBO_BOOSTIsSupported: {cpuIdEAX6EAX1_TURBO_BOOSTIsSupported}");

            bool cpuIdEAX6EAX2_ARATIsSupported = cpuHelper.GetEAX6EAX2_ARATIsSupportedX();
            Console.WriteLine($"EAX6EAX2_ARATIsSupported: {cpuIdEAX6EAX2_ARATIsSupported}");

            bool cpuIdEAX6EAX3_ReservedIsSupported = cpuHelper.GetEAX6EAX3_ReservedIsSupportedX();
            Console.WriteLine($"EAX6EAX3_ReservedIsSupported: {cpuIdEAX6EAX3_ReservedIsSupported}");

            bool cpuIdEAX6EAX4_PowerLimitNotificationCapability_PLNIsSupported = cpuHelper.GetEAX6EAX4_PowerLimitNotificationCapability_PLNIsSupportedX();
            Console.WriteLine($"EAX6EAX4_PowerLimitNotificationCapability_PLNIsSupported: {cpuIdEAX6EAX4_PowerLimitNotificationCapability_PLNIsSupported}");

            bool cpuIdEAX6EAX5_ExtendedClockModulationDutyCapability_ECMDIsSupported = cpuHelper.GetEAX6EAX5_ExtendedClockModulationDutyCapability_ECMDIsSupportedX();
            Console.WriteLine($"EAX6EAX5_ExtendedClockModulationDutyCapability_ECMDIsSupported: {cpuIdEAX6EAX5_ExtendedClockModulationDutyCapability_ECMDIsSupported}");

            bool cpuIdEAX6EAX6_PackageThermalManagementCapability_PTMIsSupported = cpuHelper.GetEAX6EAX6_PackageThermalManagementCapability_PTMIsSupportedX();
            Console.WriteLine($"EAX6EAX6_PackageThermalManagementCapability_PTMIsSupported: {cpuIdEAX6EAX6_PackageThermalManagementCapability_PTMIsSupported}");

            bool cpuIdEAX6EAX7_HardwareControlledPerformanceStatesCapability_HWPIsSupported = cpuHelper.GetEAX6EAX7_HardwareControlledPerformanceStatesCapability_HWPIsSupportedX();
            Console.WriteLine($"EAX6EAX7_HardwareControlledPerformanceStatesCapability_HWPIsSupported: {cpuIdEAX6EAX7_HardwareControlledPerformanceStatesCapability_HWPIsSupported}");

            bool cpuIdEAX6EAX8_HWPNotificationCapability_HWP_NotificationIsSupported = cpuHelper.GetEAX6EAX8_HWPNotificationCapability_HWP_NotificationIsSupportedX();
            Console.WriteLine($"EAX6EAX8_HWPNotificationCapability_HWP_NotificationIsSupported: {cpuIdEAX6EAX8_HWPNotificationCapability_HWP_NotificationIsSupported}");

            bool cpuIdEAX6EAX9_HWPActivityWindowCapability_HWP_Activity_WindowIsSupported = cpuHelper.GetEAX6EAX9_HWPActivityWindowCapability_HWP_Activity_WindowIsSupportedX();
            Console.WriteLine($"EAX6EAX9_HWPActivityWindowCapability_HWP_Activity_WindowIsSupported: {cpuIdEAX6EAX9_HWPActivityWindowCapability_HWP_Activity_WindowIsSupported}");

            bool cpuIdEAX6EAX10_HWPEnergyPerformancePreferenceCapability_HWP_Energy_Performance_PreferenceIsSupported = cpuHelper.GetEAX6EAX10_HWPEnergyPerformancePreferenceCapability_HWP_Energy_Performance_PreferenceIsSupportedX();
            Console.WriteLine($"EAX6EAX10_HWPEnergyPerformancePreferenceCapability_HWP_Energy_Performance_PreferenceIsSupported: {cpuIdEAX6EAX10_HWPEnergyPerformancePreferenceCapability_HWP_Energy_Performance_PreferenceIsSupported}");

            bool cpuIdEAX6EAX11_HWPPackageLevelRequestCapability_HWP_Package_Level_RequestIsSupported = cpuHelper.GetEAX6EAX11_HWPPackageLevelRequestCapability_HWP_Package_Level_RequestIsSupportedX();
            Console.WriteLine($"EAX6EAX11_HWPPackageLevelRequestCapability_HWP_Package_Level_RequestIsSupported: {cpuIdEAX6EAX11_HWPPackageLevelRequestCapability_HWP_Package_Level_RequestIsSupported}");

            bool cpuIdEAX6EAX12_ReservedIsSupported = cpuHelper.GetEAX6EAX12_ReservedIsSupportedX();
            Console.WriteLine($"EAX6EAX12_ReservedIsSupported: {cpuIdEAX6EAX12_ReservedIsSupported}");

            bool cpuIdEAX6EAX13_HardwareDutyCyclingCapability_HDCIsSupported = cpuHelper.GetEAX6EAX13_HardwareDutyCyclingCapability_HDCIsSupportedX();
            Console.WriteLine($"EAX6EAX13_HardwareDutyCyclingCapability_HDCIsSupported: {cpuIdEAX6EAX13_HardwareDutyCyclingCapability_HDCIsSupported}");

            bool cpuIdEAX6EAX14_IntelTurboBoostMaxTechnology30Availability_TURBO_BOOST_MAXIsSupported = cpuHelper.GetEAX6EAX14_IntelTurboBoostMaxTechnology30Availability_TURBO_BOOST_MAXIsSupportedX();
            Console.WriteLine($"EAX6EAX14_IntelTurboBoostMaxTechnology30Availability_TURBO_BOOST_MAXIsSupported: {cpuIdEAX6EAX14_IntelTurboBoostMaxTechnology30Availability_TURBO_BOOST_MAXIsSupported}");

            bool cpuIdEAX6EAX15_HWP_CAPIsSupported = cpuHelper.GetEAX6EAX15_HWP_CAPIsSupportedX();
            Console.WriteLine($"EAX6EAX15_HWP_CAPIsSupported: {cpuIdEAX6EAX15_HWP_CAPIsSupported}");

            bool cpuIdEAX6EAX16_HWP_PECI_OVERRIDEIsSupported = cpuHelper.GetEAX6EAX16_HWP_PECI_OVERRIDEIsSupportedX();
            Console.WriteLine($"EAX6EAX16_HWP_PECI_OVERRIDEIsSupported: {cpuIdEAX6EAX16_HWP_PECI_OVERRIDEIsSupported}");

            bool cpuIdEAX6EAX17_FlexibleHWPIsSupported = cpuHelper.GetEAX6EAX17_FlexibleHWPIsSupportedX();
            Console.WriteLine($"EAX6EAX17_FlexibleHWPIsSupported: {cpuIdEAX6EAX17_FlexibleHWPIsSupported}");

            bool cpuIdEAX6EAX18_HWP_REQUEST_FAST_ACCESSIsSupported = cpuHelper.GetEAX6EAX18_HWP_REQUEST_FAST_ACCESSIsSupportedX();
            Console.WriteLine($"EAX6EAX18_HWP_REQUEST_FAST_ACCESSIsSupported: {cpuIdEAX6EAX18_HWP_REQUEST_FAST_ACCESSIsSupported}");

            bool cpuIdEAX6EAX19_HW_FEEDBACKIsSupported = cpuHelper.GetEAX6EAX19_HW_FEEDBACKIsSupportedX();
            Console.WriteLine($"EAX6EAX19_HW_FEEDBACKIsSupported: {cpuIdEAX6EAX19_HW_FEEDBACKIsSupported}");

            bool cpuIdEAX6EAX20_HWP_REQUEST_IGNORE_IDLEIsSupported = cpuHelper.GetEAX6EAX20_HWP_REQUEST_IGNORE_IDLEIsSupportedX();
            Console.WriteLine($"EAX6EAX20_HWP_REQUEST_IGNORE_IDLEIsSupported: {cpuIdEAX6EAX20_HWP_REQUEST_IGNORE_IDLEIsSupported}");

            bool cpuIdEAX6EAX21_ReservedIsSupported = cpuHelper.GetEAX6EAX21_ReservedIsSupportedX();
            Console.WriteLine($"EAX6EAX21_ReservedIsSupported: {cpuIdEAX6EAX21_ReservedIsSupported}");

            bool cpuIdEAX6EAX22_HWP_CTLIsSupported = cpuHelper.GetEAX6EAX22_HWP_CTLIsSupportedX();
            Console.WriteLine($"EAX6EAX22_HWP_CTLIsSupported: {cpuIdEAX6EAX22_HWP_CTLIsSupported}");

            bool cpuIdEAX6EAX23_THREAD_DIRECTORIsSupported = cpuHelper.GetEAX6EAX23_THREAD_DIRECTORIsSupportedX();
            Console.WriteLine($"EAX6EAX23_THREAD_DIRECTORIsSupported: {cpuIdEAX6EAX23_THREAD_DIRECTORIsSupported}");

            bool cpuIdEAX6EAX24_IA32_THERM_INTERRUPTIsSupported = cpuHelper.GetEAX6EAX24_IA32_THERM_INTERRUPTIsSupportedX();
            Console.WriteLine($"EAX6EAX24_IA32_THERM_INTERRUPTIsSupported: {cpuIdEAX6EAX24_IA32_THERM_INTERRUPTIsSupported}");

            bool cpuIdEAX6EAX25_ReservedIsSupported = cpuHelper.GetEAX6EAX25_ReservedIsSupportedX();
            Console.WriteLine($"EAX6EAX25_ReservedIsSupported: {cpuIdEAX6EAX25_ReservedIsSupported}");

            bool cpuIdEAX6EAX26_ReservedIsSupported = cpuHelper.GetEAX6EAX26_ReservedIsSupportedX();
            Console.WriteLine($"EAX6EAX26_ReservedIsSupported: {cpuIdEAX6EAX26_ReservedIsSupported}");

            bool cpuIdEAX6EAX27_ReservedIsSupported = cpuHelper.GetEAX6EAX27_ReservedIsSupportedX();
            Console.WriteLine($"EAX6EAX27_ReservedIsSupported: {cpuIdEAX6EAX27_ReservedIsSupported}");

            bool cpuIdEAX6EAX28_ReservedIsSupported = cpuHelper.GetEAX6EAX28_ReservedIsSupportedX();
            Console.WriteLine($"EAX6EAX28_ReservedIsSupported: {cpuIdEAX6EAX28_ReservedIsSupported}");

            bool cpuIdEAX6EAX29_ReservedIsSupported = cpuHelper.GetEAX6EAX29_ReservedIsSupportedX();
            Console.WriteLine($"EAX6EAX29_ReservedIsSupported: {cpuIdEAX6EAX29_ReservedIsSupported}");

            bool cpuIdEAX6EAX30_ReservedIsSupported = cpuHelper.GetEAX6EAX30_ReservedIsSupportedX();
            Console.WriteLine($"EAX6EAX30_ReservedIsSupported: {cpuIdEAX6EAX30_ReservedIsSupported}");

            bool cpuIdEAX6EAX31_ReservedIsSupported = cpuHelper.GetEAX6EAX31_ReservedIsSupportedX();
            Console.WriteLine($"EAX6EAX31_ReservedIsSupported: {cpuIdEAX6EAX31_ReservedIsSupported}");

            string spuIdEAX6_EBX0_3_NumberOfInterruptThresholdsInDigitalThermalSensorString = cpuHelper.GetEAX6_EBX0_3_NumberOfInterruptThresholdsInDigitalThermalSensorX();
            Console.WriteLine($"EAX6_EBX0_3_NumberOfInterruptThresholdsInDigitalThermalSensor: {spuIdEAX6_EBX0_3_NumberOfInterruptThresholdsInDigitalThermalSensorString}");

            string spuIdEAX6_EBX4_31_ReservedString = cpuHelper.GetEAX6_EBX4_31_ReservedX();
            Console.WriteLine($"EAX6_EBX4_31_Reserved: {spuIdEAX6_EBX4_31_ReservedString}");

            bool spuIdEAX6ECX0_EffectiveFrequencyInterfaceString = cpuHelper.GetEAX6ECX0_EffectiveFrequencyInterfaceIsSupportedX();
            Console.WriteLine($"EAX6ECX0_EffectiveFrequencyInterfaceIsSupported: {spuIdEAX6ECX0_EffectiveFrequencyInterfaceString}");

            bool spuIdEAX6ECX1_ACNT2CapabilityString = cpuHelper.GetEAX6ECX1_ACNT2CapabilityIsSupportedX();
            Console.WriteLine($"EAX6ECX1_ACNT2CapabilityIsSupported: {spuIdEAX6ECX1_ACNT2CapabilityString}");

            bool spuIdEAX6ECX2_ReservedString = cpuHelper.GetEAX6ECX2_ReservedIsSupportedX();
            Console.WriteLine($"EAX6ECX2_ReservedIsSupported: {spuIdEAX6ECX2_ReservedString}");

            bool spuIdEAX6ECX3_PerformanceEnergyBiasCapabilityMSRString = cpuHelper.GetEAX6ECX3_PerformanceEnergyBiasCapabilityMSRIsSupportedX();
            Console.WriteLine($"EAX6ECX3_PerformanceEnergyBiasCapabilityMSRIsSupported: {spuIdEAX6ECX3_PerformanceEnergyBiasCapabilityMSRString}");

            string spuIdEAX6ECX4_7_ReservedString = cpuHelper.GetEAX6ECX4_7_ReservedX();
            Console.WriteLine($"EAX6ECX4_7_Reserved: {spuIdEAX6ECX4_7_ReservedString}");

            string spuIdEAX6ECX8_15_NumberOfIntelThreadDirectorClassesString = cpuHelper.GetEAX6ECX8_15_NumberOfIntelThreadDirectorClassesX();
            Console.WriteLine($"EAX6ECX8_15_NumberOfIntelThreadDirectorClasses: {spuIdEAX6ECX8_15_NumberOfIntelThreadDirectorClassesString}");

            string spuIdEAX6ECX16_31_ReservedString = cpuHelper.GetEAX6ECX16_31_ReservedX();
            Console.WriteLine($"EAX6ECX16_31_Reserved: {spuIdEAX6ECX16_31_ReservedString}");

            bool spuIdEAX6EDX0_HardwareFeedbackReportingPerformanceCapabilityReportingIsSupportedString = cpuHelper.GetEAX6EDX0_HardwareFeedbackReportingPerformanceCapabilityReportingIsSupportedX();
            Console.WriteLine($"EAX6EDX0_HardwareFeedbackReportingPerformanceCapabilityReportingIsSupported: {spuIdEAX6EDX0_HardwareFeedbackReportingPerformanceCapabilityReportingIsSupportedString}");

            bool spuIdEAX6EDX1_HardwareFeedbackReportingEfficiencyCapabilityReportingIsSupportedString = cpuHelper.GetEAX6EDX1_HardwareFeedbackReportingEfficiencyCapabilityReportingIsSupportedX();
            Console.WriteLine($"EAX6EDX1_HardwareFeedbackReportingEfficiencyCapabilityReportingIsSupported: {spuIdEAX6EDX1_HardwareFeedbackReportingEfficiencyCapabilityReportingIsSupportedString}");

            string spuIdEAX6EDX2_7_ReservedString = cpuHelper.GetEAX6EDX2_7_ReservedX();
            Console.WriteLine($"EAX6EDX2_7_Reserved: {spuIdEAX6EDX2_7_ReservedString}");

            string spuIdEAX6EDX8_11_SizeOfHardwareFeedbackInterfaceStructureString = cpuHelper.GetEAX6EDX8_11_SizeOfHardwareFeedbackInterfaceStructureX();
            Console.WriteLine($"EAX6EDX8_11_SizeOfHardwareFeedbackInterfaceStructure: {spuIdEAX6EDX8_11_SizeOfHardwareFeedbackInterfaceStructureString}");

            string spuIdEAX6EDX12_15_ReservedString = cpuHelper.GetEAX6EDX12_15_ReservedX();
            Console.WriteLine($"EAX6EDX12_15_Reserved: {spuIdEAX6EDX12_15_ReservedString}");

            string spuIdEAX6EDX16_31_IndexOfThisLogicalProcessorsRowInHardwareFeedbackInterfaceStructureString = cpuHelper.GetEAX6EDX16_31_IndexOfThisLogicalProcessorsRowInHardwareFeedbackInterfaceStructureX();
            Console.WriteLine($"EAX6EDX16_31_IndexOfThisLogicalProcessorsRowInHardwareFeedbackInterfaceStructure: {spuIdEAX6EDX16_31_IndexOfThisLogicalProcessorsRowInHardwareFeedbackInterfaceStructureString}");

            #endregion

            #region region EAX=0x7, ECX=0x0: Extended Features

            string cpuIdEAX7ECX0EAX = cpuHelper.GetEAX7ECX0EAXX();
            Console.WriteLine($"EAX7ECX0EAX: {cpuIdEAX7ECX0EAX}");

            string cpuIdEAX7ECX0EBX = cpuHelper.GetEAX7ECX0EBXX();
            Console.WriteLine($"EAX7ECX0EBX: {cpuIdEAX7ECX0EBX}");

            string cpuIdEAX7ECX0ECX = cpuHelper.GetEAX7ECX0ECXX();
            Console.WriteLine($"EAX7ECX0ECX: {cpuIdEAX7ECX0ECX}");

            string cpuIdEAX7ECX0EDX = cpuHelper.GetEAX7ECX0EDXX();
            Console.WriteLine($"EAX7ECX0EDX: {cpuIdEAX7ECX0EDX}");

            bool cpuIdEAX7ECX0_EBX0_FSGSBaseIsSupported = cpuHelper.GetEAX7ECX0_EBX0_FSGSBaseIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX0_FSGSBaseIsSupported: {cpuIdEAX7ECX0_EBX0_FSGSBaseIsSupported}");

            bool cpuIdEAX7ECX0_EBX1_TSCAdjustIsSupported = cpuHelper.GetEAX7ECX0_EBX1_TSCAdjustIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX1_TSCAdjustIsSupported: {cpuIdEAX7ECX0_EBX1_TSCAdjustIsSupported}");

            bool cpuIdEAX7ECX0_EBX2_SGXIsSupported = cpuHelper.GetEAX7ECX0_EBX2_SGXIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX2_SGXIsSupported: {cpuIdEAX7ECX0_EBX2_SGXIsSupported}");

            bool cpuIdEAX7ECX0_EBX3_BMI1IsSupported = cpuHelper.GetEAX7ECX0_EBX3_BMI1IsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX3_BMI1IsSupported: {cpuIdEAX7ECX0_EBX3_BMI1IsSupported}");

            bool cpuIdEAX7ECX0_EBX4_HLEIsSupported = cpuHelper.GetEAX7ECX0_EBX4_HLEIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX4_HLEIsSupported: {cpuIdEAX7ECX0_EBX4_HLEIsSupported}");

            bool cpuIdEAX7ECX0_EBX5_AVX2IsSupported = cpuHelper.GetEAX7ECX0_EBX5_AVX2IsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX5_AVX2IsSupported: {cpuIdEAX7ECX0_EBX5_AVX2IsSupported}");

            bool cpuIdEAX7ECX0_EBX6_FDPExcptnOnlyIsSupported = cpuHelper.GetEAX7ECX0_EBX6_FDPExcptnOnlyIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX6_FDPExcptnOnlyIsSupported: {cpuIdEAX7ECX0_EBX6_FDPExcptnOnlyIsSupported}");

            bool cpuIdEAX7ECX0_EBX7_SMEPIsSupported = cpuHelper.GetEAX7ECX0_EBX7_SMEPIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX7_SMEPIsSupported: {cpuIdEAX7ECX0_EBX7_SMEPIsSupported}");

            bool cpuIdEAX7ECX0_EBX8_BMI2IsSupported = cpuHelper.GetEAX7ECX0_EBX8_BMI2IsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX8_BMI2IsSupported: {cpuIdEAX7ECX0_EBX8_BMI2IsSupported}");

            bool cpuIdEAX7ECX0_EBX9_ERMSIsSupported = cpuHelper.GetEAX7ECX0_EBX9_ERMSIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX9_ERMSIsSupported: {cpuIdEAX7ECX0_EBX9_ERMSIsSupported}");

            bool cpuIdEAX7ECX0_EBX10_INVPCIDIsSupported = cpuHelper.GetEAX7ECX0_EBX10_INVPCIDIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX10_INVPCIDIsSupported: {cpuIdEAX7ECX0_EBX10_INVPCIDIsSupported}");

            bool cpuIdEAX7ECX0_EBX11_RTMIsSupported = cpuHelper.GetEAX7ECX0_EBX11_RTMIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX11_RTMIsSupported: {cpuIdEAX7ECX0_EBX11_RTMIsSupported}");

            bool cpuIdEAX7ECX0_EBX12_RDTMIsSupported = cpuHelper.GetEAX7ECX0_EBX12_RDTMIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX12_RDTMIsSupported: {cpuIdEAX7ECX0_EBX12_RDTMIsSupported}");

            bool cpuIdEAX7ECX0_EBX13_FCSFDSDeprecationIsSupported = cpuHelper.GetEAX7ECX0_EBX13_FCSFDSDeprecationIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX13_FCSFDSDeprecationIsSupported: {cpuIdEAX7ECX0_EBX13_FCSFDSDeprecationIsSupported}");

            bool cpuIdEAX7ECX0_EBX14_MPXIsSupported = cpuHelper.GetEAX7ECX0_EBX14_MPXIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX14_MPXIsSupported: {cpuIdEAX7ECX0_EBX14_MPXIsSupported}");

            bool cpuIdEAX7ECX0_EBX15_RDTAIsSupported = cpuHelper.GetEAX7ECX0_EBX15_RDTAIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX15_RDTAIsSupported: {cpuIdEAX7ECX0_EBX15_RDTAIsSupported}");

            bool cpuIdEAX7ECX0_EBX16_AVX512FIsSupported = cpuHelper.GetEAX7ECX0_EBX16_AVX512FIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX16_AVX512FIsSupported: {cpuIdEAX7ECX0_EBX16_AVX512FIsSupported}");

            bool cpuIdEAX7ECX0_EBX17_AVX512DQIsSupported = cpuHelper.GetEAX7ECX0_EBX17_AVX512DQIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX17_AVX512DQIsSupported: {cpuIdEAX7ECX0_EBX17_AVX512DQIsSupported}");

            bool cpuIdEAX7ECX0_EBX18_RDSEEDIsSupported = cpuHelper.GetEAX7ECX0_EBX18_RDSEEDIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX18_RDSEEDIsSupported: {cpuIdEAX7ECX0_EBX18_RDSEEDIsSupported}");

            bool cpuIdEAX7ECX0_EBX19_ADXIsSupported = cpuHelper.GetEAX7ECX0_EBX19_ADXIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX19_ADXIsSupported: {cpuIdEAX7ECX0_EBX19_ADXIsSupported}");

            bool cpuIdEAX7ECX0_EBX20_SMAPIsSupported = cpuHelper.GetEAX7ECX0_EBX20_SMAPIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX20_SMAPIsSupported: {cpuIdEAX7ECX0_EBX20_SMAPIsSupported}");

            bool cpuIdEAX7ECX0_EBX21_AVX512IFMAIsSupported = cpuHelper.GetEAX7ECX0_EBX21_AVX512IFMAIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX21_AVX512IFMAIsSupported: {cpuIdEAX7ECX0_EBX21_AVX512IFMAIsSupported}");

            bool cpuIdEAX7ECX0_EBX22_PCOMMITIsSupported = cpuHelper.GetEAX7ECX0_EBX22_PCOMMITIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX22_PCOMMITIsSupported: {cpuIdEAX7ECX0_EBX22_PCOMMITIsSupported}");

            bool cpuIdEAX7ECX0_EBX23_CLFLUSHOPTIsSupported = cpuHelper.GetEAX7ECX0_EBX23_CLFLUSHOPTIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX23_CLFLUSHOPTIsSupported: {cpuIdEAX7ECX0_EBX23_CLFLUSHOPTIsSupported}");

            bool cpuIdEAX7ECX0_EBX24_CLWBIsSupported = cpuHelper.GetEAX7ECX0_EBX24_CLWBIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX24_CLWBIsSupported: {cpuIdEAX7ECX0_EBX24_CLWBIsSupported}");

            bool cpuIdEAX7ECX0_EBX25_PTIsSupported = cpuHelper.GetEAX7ECX0_EBX25_PTIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX25_PTIsSupported: {cpuIdEAX7ECX0_EBX25_PTIsSupported}");

            bool cpuIdEAX7ECX0_EBX26_AVX512PFIsSupported = cpuHelper.GetEAX7ECX0_EBX26_AVX512PFIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX26_AVX512PFIsSupported: {cpuIdEAX7ECX0_EBX26_AVX512PFIsSupported}");

            bool cpuIdEAX7ECX0_EBX27_AVX512ERIsSupported = cpuHelper.GetEAX7ECX0_EBX27_AVX512ERIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX27_AVX512ERIsSupported: {cpuIdEAX7ECX0_EBX27_AVX512ERIsSupported}");

            bool cpuIdEAX7ECX0_EBX28_AVX512CDIsSupported = cpuHelper.GetEAX7ECX0_EBX28_AVX512CDIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX28_AVX512CDIsSupported: {cpuIdEAX7ECX0_EBX28_AVX512CDIsSupported}");

            bool cpuIdEAX7ECX0_EBX29_SHAIsSupported = cpuHelper.GetEAX7ECX0_EBX29_SHAIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX29_SHAIsSupported: {cpuIdEAX7ECX0_EBX29_SHAIsSupported}");

            bool cpuIdEAX7ECX0_EBX30_AVX512BWIsSupported = cpuHelper.GetEAX7ECX0_EBX30_AVX512BWIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX30_AVX512BWIsSupported: {cpuIdEAX7ECX0_EBX30_AVX512BWIsSupported}");

            bool cpuIdEAX7ECX0_EBX31_AVX512VLIsSupported = cpuHelper.GetEAX7ECX0_EBX31_AVX512VLIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EBX31_AVX512VLIsSupported: {cpuIdEAX7ECX0_EBX31_AVX512VLIsSupported}");

            bool cpuIdEAX7ECX0_ECX0_PREFETCHWT1IsSupported = cpuHelper.GetEAX7ECX0_ECX0_PREFETCHWT1IsSupportedX();
            Console.WriteLine($"EAX7ECX0_ECX0_PREFETCHWT1IsSupported: {cpuIdEAX7ECX0_ECX0_PREFETCHWT1IsSupported}");

            bool cpuIdEAX7ECX0_ECX1_AVX512VBMIIsSupported = cpuHelper.GetEAX7ECX0_ECX1_AVX512VBMIIsSupportedX();
            Console.WriteLine($"EAX7ECX0_ECX1_AVX512VBMIIsSupported: {cpuIdEAX7ECX0_ECX1_AVX512VBMIIsSupported}");

            bool cpuIdEAX7ECX0_ECX2_UMIPIsSupported = cpuHelper.GetEAX7ECX0_ECX2_UMIPIsSupportedX();
            Console.WriteLine($"EAX7ECX0_ECX2_UMIPIsSupported: {cpuIdEAX7ECX0_ECX2_UMIPIsSupported}");

            bool cpuIdEAX7ECX0_ECX3_PKUIsSupported = cpuHelper.GetEAX7ECX0_ECX3_PKUIsSupportedX();
            Console.WriteLine($"EAX7ECX0_ECX3_PKUIsSupported: {cpuIdEAX7ECX0_ECX3_PKUIsSupported}");

            bool cpuIdEAX7ECX0_ECX4_OSPKEIsSupported = cpuHelper.GetEAX7ECX0_ECX4_OSPKEIsSupportedX();
            Console.WriteLine($"EAX7ECX0_ECX4_OSPKEIsSupported: {cpuIdEAX7ECX0_ECX4_OSPKEIsSupported}");

            bool cpuIdEAX7ECX0_ECX5_WAITPKGIsSupported = cpuHelper.GetEAX7ECX0_ECX5_WAITPKGIsSupportedX();
            Console.WriteLine($"EAX7ECX0_ECX5_WAITPKGIsSupported: {cpuIdEAX7ECX0_ECX5_WAITPKGIsSupported}");

            bool cpuIdEAX7ECX0_ECX6_AVX512VBMI2IsSupported = cpuHelper.GetEAX7ECX0_ECX6_AVX512VBMI2IsSupportedX();
            Console.WriteLine($"EAX7ECX0_ECX6_AVX512VBMI2IsSupported: {cpuIdEAX7ECX0_ECX6_AVX512VBMI2IsSupported}");

            bool cpuIdEAX7ECX0_ECX7_CETSSIsSupported = cpuHelper.GetEAX7ECX0_ECX7_CETSSIsSupportedX();
            Console.WriteLine($"EAX7ECX0_ECX7_CETSSIsSupported: {cpuIdEAX7ECX0_ECX7_CETSSIsSupported}");

            bool cpuIdEAX7ECX0_ECX8_GFNIIsSupported = cpuHelper.GetEAX7ECX0_ECX8_GFNIIsSupportedX();
            Console.WriteLine($"EAX7ECX0_ECX8_GFNIIsSupported: {cpuIdEAX7ECX0_ECX8_GFNIIsSupported}");

            bool cpuIdEAX7ECX0_ECX9_VAESIsSupported = cpuHelper.GetEAX7ECX0_ECX9_VAESIsSupportedX();
            Console.WriteLine($"EAX7ECX0_ECX9_VAESIsSupported: {cpuIdEAX7ECX0_ECX9_VAESIsSupported}");

            bool cpuIdEAX7ECX0_ECX10_VPCLMULQDQIsSupported = cpuHelper.GetEAX7ECX0_ECX10_VPCLMULQDQIsSupportedX();
            Console.WriteLine($"EAX7ECX0_ECX10_VPCLMULQDQIsSupported: {cpuIdEAX7ECX0_ECX10_VPCLMULQDQIsSupported}");

            bool cpuIdEAX7ECX0_ECX11_AVX512VNNIIsSupported = cpuHelper.GetEAX7ECX0_ECX11_AVX512VNNIIsSupportedX();
            Console.WriteLine($"EAX7ECX0_ECX11_AVX512VNNIIsSupported: {cpuIdEAX7ECX0_ECX11_AVX512VNNIIsSupported}");

            bool cpuIdEAX7ECX0_ECX12_AVX512BITALGIsSupported = cpuHelper.GetEAX7ECX0_ECX12_AVX512BITALGIsSupportedX();
            Console.WriteLine($"EAX7ECX0_ECX12_AVX512BITALGIsSupported: {cpuIdEAX7ECX0_ECX12_AVX512BITALGIsSupported}");

            bool cpuIdEAX7ECX0_ECX13_TME_ENIsSupported = cpuHelper.GetEAX7ECX0_ECX13_TME_ENIsSupportedX();
            Console.WriteLine($"EAX7ECX0_ECX13_TME_ENIsSupported: {cpuIdEAX7ECX0_ECX13_TME_ENIsSupported}");

            bool cpuIdEAX7ECX0_ECX14_AVX512VPOPCNTDQIsSupported = cpuHelper.GetEAX7ECX0_ECX14_AVX512VPOPCNTDQIsSupportedX();
            Console.WriteLine($"EAX7ECX0_ECX14_AVX512VPOPCNTDQIsSupported: {cpuIdEAX7ECX0_ECX14_AVX512VPOPCNTDQIsSupported}");

            bool cpuIdEAX7ECX0_ECX15_FZMIsSupported = cpuHelper.GetEAX7ECX0_ECX15_FZMIsSupportedX();
            Console.WriteLine($"EAX7ECX0_ECX15_FZMIsSupported: {cpuIdEAX7ECX0_ECX15_FZMIsSupported}");

            bool cpuIdEAX7ECX0_ECX16_LA57IsSupported = cpuHelper.GetEAX7ECX0_ECX16_LA57IsSupportedX();
            Console.WriteLine($"EAX7ECX0_ECX16_LA57IsSupported: {cpuIdEAX7ECX0_ECX16_LA57IsSupported}");

            bool cpuIdEAX7ECX0_ECX17_MAWAUIsSupported1 = cpuHelper.GetEAX7ECX0_ECX17_MAWAUIsSupported1X();
            Console.WriteLine($"EAX7ECX0_ECX17_MAWAUIsSupported1: {cpuIdEAX7ECX0_ECX17_MAWAUIsSupported1}");

            bool cpuIdEAX7ECX0_ECX18_MAWAUIsSupported2 = cpuHelper.GetEAX7ECX0_ECX18_MAWAUIsSupported2X();
            Console.WriteLine($"EAX7ECX0_ECX18_MAWAUIsSupported2: {cpuIdEAX7ECX0_ECX18_MAWAUIsSupported2}");

            bool cpuIdEAX7ECX0_ECX19_MAWAUIsSupported3 = cpuHelper.GetEAX7ECX0_ECX19_MAWAUIsSupported3X();
            Console.WriteLine($"EAX7ECX0_ECX19_MAWAUIsSupported3: {cpuIdEAX7ECX0_ECX19_MAWAUIsSupported3}");

            bool cpuIdEAX7ECX0_ECX20_MAWAUIsSupported4 = cpuHelper.GetEAX7ECX0_ECX20_MAWAUIsSupported4X();
            Console.WriteLine($"EAX7ECX0_ECX20_MAWAUIsSupported4: {cpuIdEAX7ECX0_ECX20_MAWAUIsSupported4}");

            bool cpuIdEAX7ECX0_ECX21_MAWAUIsSupported5 = cpuHelper.GetEAX7ECX0_ECX21_MAWAUIsSupported5X();
            Console.WriteLine($"EAX7ECX0_ECX21_MAWAUIsSupported5: {cpuIdEAX7ECX0_ECX21_MAWAUIsSupported5}");

            bool cpuIdEAX7ECX0_ECX22_RDPIDIsSupported = cpuHelper.GetEAX7ECX0_ECX22_RDPIDIsSupportedX();
            Console.WriteLine($"EAX7ECX0_ECX22_RDPIDIsSupported: {cpuIdEAX7ECX0_ECX22_RDPIDIsSupported}");

            bool cpuIdEAX7ECX0_ECX23_KLIsSupported = cpuHelper.GetEAX7ECX0_ECX23_KLIsSupportedX();
            Console.WriteLine($"EAX7ECX0_ECX23_KLIsSupported: {cpuIdEAX7ECX0_ECX23_KLIsSupported}");

            bool cpuIdEAX7ECX0_ECX24_BusLockDetectIsSupported = cpuHelper.GetEAX7ECX0_ECX24_BusLockDetectIsSupportedX();
            Console.WriteLine($"EAX7ECX0_ECX24_BusLockDetectIsSupported: {cpuIdEAX7ECX0_ECX24_BusLockDetectIsSupported}");

            bool cpuIdEAX7ECX0_ECX25_CLDEMOTEIsSupported = cpuHelper.GetEAX7ECX0_ECX25_CLDEMOTEIsSupportedX();
            Console.WriteLine($"EAX7ECX0_ECX25_CLDEMOTEIsSupported: {cpuIdEAX7ECX0_ECX25_CLDEMOTEIsSupported}");

            bool cpuIdEAX7ECX0_ECX26_MPRRIsSupported = cpuHelper.GetEAX7ECX0_ECX26_MPRRIsSupportedX();
            Console.WriteLine($"EAX7ECX0_ECX26_MPRRIsSupported: {cpuIdEAX7ECX0_ECX26_MPRRIsSupported}");

            bool cpuIdEAX7ECX0_ECX27_MOVDIRIIsSupported = cpuHelper.GetEAX7ECX0_ECX27_MOVDIRIIsSupportedX();
            Console.WriteLine($"EAX7ECX0_ECX27_MOVDIRIIsSupported: {cpuIdEAX7ECX0_ECX27_MOVDIRIIsSupported}");

            bool cpuIdEAX7ECX0_ECX28_MOVDIR64BIsSupported = cpuHelper.GetEAX7ECX0_ECX28_MOVDIR64BIsSupportedX();
            Console.WriteLine($"EAX7ECX0_ECX28_MOVDIR64BIsSupported: {cpuIdEAX7ECX0_ECX28_MOVDIR64BIsSupported}");

            bool cpuIdEAX7ECX0_ECX29_ENQCMDIsSupported = cpuHelper.GetEAX7ECX0_ECX29_ENQCMDIsSupportedX();
            Console.WriteLine($"EAX7ECX0_ECX29_ENQCMDIsSupported: {cpuIdEAX7ECX0_ECX29_ENQCMDIsSupported}");

            bool cpuIdEAX7ECX0_ECX30_SGXLcIsSupported = cpuHelper.GetEAX7ECX0_ECX30_SGXLcIsSupportedX();
            Console.WriteLine($"EAX7ECX0_ECX30_SGXLcIsSupported: {cpuIdEAX7ECX0_ECX30_SGXLcIsSupported}");

            bool cpuIdEAX7ECX0_ECX31_PKSIsSupported = cpuHelper.GetEAX7ECX0_ECX31_PKSIsSupportedX();
            Console.WriteLine($"EAX7ECX0_ECX31_PKSIsSupported: {cpuIdEAX7ECX0_ECX31_PKSIsSupported}");

            bool cpuIdEAX7ECX0_EDX0_SGXTEMIsSupported = cpuHelper.GetEAX7ECX0_EDX0_SGXTEMIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EDX0_SGXTEMIsSupported: {cpuIdEAX7ECX0_EDX0_SGXTEMIsSupported}");

            bool cpuIdEAX7ECX0_EDX1_SGXKEYIsSupported = cpuHelper.GetEAX7ECX0_EDX1_SGXKEYIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EDX1_SGXKEYIsSupported: {cpuIdEAX7ECX0_EDX1_SGXKEYIsSupported}");

            bool cpuIdEAX7ECX0_EDX2_AVX5124VNNIIsSupported = cpuHelper.GetEAX7ECX0_EDX2_AVX5124VNNIIsSupportedX();
            Console.WriteLine($"EAX7ECX0_EDX2_AVX5124VNNIIsSupported: {cpuIdEAX7ECX0_EDX2_AVX5124VNNIIsSupported}");

            bool cpuIdEAX7ECX0_EDX3_AVX5124FMAPSIsSupported = cpuHelper.GetEAX7ECX0_EDX3_AVX5124FMAPSIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX0_EDX3_AVX5124FMAPSIsSupported: {cpuIdEAX7ECX0_EDX3_AVX5124FMAPSIsSupported}");

            bool cpuIdEAX7ECX0_EDX4_FSRMIsSupported = cpuHelper.GetEAX7ECX0_EDX4_FSRMIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX0_EDX4_FSRMIsSupported: {cpuIdEAX7ECX0_EDX4_FSRMIsSupported}");

            bool cpuIdEAX7ECX0_EDX5_UINTRIsSupported = cpuHelper.GetEAX7ECX0_EDX5_UINTRIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX0_EDX5_UINTRIsSupported: {cpuIdEAX7ECX0_EDX5_UINTRIsSupported}");

            bool cpuIdEAX7ECX0_EDX6_ReservedIsSupported = cpuHelper.GetEAX7ECX0_EDX6_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX0_EDX6_ReservedIsSupported: {cpuIdEAX7ECX0_EDX6_ReservedIsSupported}");

            bool cpuIdEAX7ECX0_EDX7_ReservedIsSupported = cpuHelper.GetEAX7ECX0_EDX7_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX0_EDX7_ReservedIsSupported: {cpuIdEAX7ECX0_EDX7_ReservedIsSupported}");

            bool cpuIdEAX7ECX0_EDX8_AVX512VP2INTERSECTIsSupported = cpuHelper.GetEAX7ECX0_EDX8_AVX512VP2INTERSECTIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX0_EDX8_AVX512VP2INTERSECTIsSupported: {cpuIdEAX7ECX0_EDX8_AVX512VP2INTERSECTIsSupported}");

            bool cpuIdEAX7ECX0_EDX9_SRBDSCtrlIsSupported = cpuHelper.GetEAX7ECX0_EDX9_SRBDSCtrlIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX0_EDX9_SRBDSCtrlIsSupported: {cpuIdEAX7ECX0_EDX9_SRBDSCtrlIsSupported}");

            bool cpuIdEAX7ECX0_EDX10_MDClearIsSupported = cpuHelper.GetEAX7ECX0_EDX10_MDClearIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX0_EDX10_MDClearIsSupported: {cpuIdEAX7ECX0_EDX10_MDClearIsSupported}");

            bool cpuIdEAX7ECX0_EDX11_RTMAlwaysAbortIsSupported = cpuHelper.GetEAX7ECX0_EDX11_RTMAlwaysAbortIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX0_EDX11_RTMAlwaysAbortIsSupported: {cpuIdEAX7ECX0_EDX11_RTMAlwaysAbortIsSupported}");

            bool cpuIdEAX7ECX0_EDX12_ReservedIsSupported = cpuHelper.GetEAX7ECX0_EDX12_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX0_EDX12_ReservedIsSupported: {cpuIdEAX7ECX0_EDX12_ReservedIsSupported}");

            bool cpuIdEAX7ECX0_EDX13_RTMForceAbortIsSupported = cpuHelper.GetEAX7ECX0_EDX13_RTMForceAbortIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX0_EDX13_RTMForceAbortIsSupported: {cpuIdEAX7ECX0_EDX13_RTMForceAbortIsSupported}");

            bool cpuIdEAX7ECX0_EDX14_SERIALIZEIsSupported = cpuHelper.GetEAX7ECX0_EDX14_SERIALIZEIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX0_EDX14_SERIALIZEIsSupported: {cpuIdEAX7ECX0_EDX14_SERIALIZEIsSupported}");

            bool cpuIdEAX7ECX0_EDX15_HYBRIDIsSupported = cpuHelper.GetEAX7ECX0_EDX15_HYBRIDIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX0_EDX15_HYBRIDIsSupported: {cpuIdEAX7ECX0_EDX15_HYBRIDIsSupported}");

            bool cpuIdEAX7ECX0_EDX16_TSXLDTRKIsSupported = cpuHelper.GetEAX7ECX0_EDX16_TSXLDTRKIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX0_EDX16_TSXLDTRKIsSupported: {cpuIdEAX7ECX0_EDX16_TSXLDTRKIsSupported}");

            bool cpuIdEAX7ECX0_EDX17_ReservedIsSupported = cpuHelper.GetEAX7ECX0_EDX17_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX0_EDX17_ReservedIsSupported: {cpuIdEAX7ECX0_EDX17_ReservedIsSupported}");

            bool cpuIdEAX7ECX0_EDX18_PCONFIGIsSupported = cpuHelper.GetEAX7ECX0_EDX18_PCONFIGIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX0_EDX18_PCONFIGIsSupported: {cpuIdEAX7ECX0_EDX18_PCONFIGIsSupported}");

            bool cpuIdEAX7ECX0_EDX19_LBRIsSupported = cpuHelper.GetEAX7ECX0_EDX19_LBRIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX0_EDX19_LBRIsSupported: {cpuIdEAX7ECX0_EDX19_LBRIsSupported}");

            bool cpuIdEAX7ECX0_EDX20_CETIBTIsSupported = cpuHelper.GetEAX7ECX0_EDX20_CETIBTIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX0_EDX20_CETIBTIsSupported: {cpuIdEAX7ECX0_EDX20_CETIBTIsSupported}");

            bool cpuIdEAX7ECX0_EDX21_ReservedIsSupported = cpuHelper.GetEAX7ECX0_EDX21_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX0_EDX21_ReservedIsSupported: {cpuIdEAX7ECX0_EDX21_ReservedIsSupported}");

            bool cpuIdEAX7ECX0_EDX22_AMXBF16IsSupported = cpuHelper.GetEAX7ECX0_EDX22_AMXBF16IsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX0_EDX22_AMXBF16IsSupported: {cpuIdEAX7ECX0_EDX22_AMXBF16IsSupported}");

            bool cpuIdEAX7ECX0_EDX23_AVX512FP16IsSupported = cpuHelper.GetEAX7ECX0_EDX23_AVX512FP16IsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX0_EDX23_AVX512FP16IsSupported: {cpuIdEAX7ECX0_EDX23_AVX512FP16IsSupported}");

            bool cpuIdEAX7ECX0_EDX24_AMXTILEIsSupported = cpuHelper.GetEAX7ECX0_EDX24_AMXTILEIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX0_EDX24_AMXTILEIsSupported: {cpuIdEAX7ECX0_EDX24_AMXTILEIsSupported}");

            bool cpuIdEAX7ECX0_EDX25_AMXINT8IsSupported = cpuHelper.GetEAX7ECX0_EDX25_AMXINT8IsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX0_EDX25_AMXINT8IsSupported: {cpuIdEAX7ECX0_EDX25_AMXINT8IsSupported}");

            bool cpuIdEAX7ECX0_EDX26_SPEC_CTRLIsSupported = cpuHelper.GetEAX7ECX0_EDX26_SPEC_CTRLIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX0_EDX26_SPEC_CTRLIsSupported: {cpuIdEAX7ECX0_EDX26_SPEC_CTRLIsSupported}");

            bool cpuIdEAX7ECX0_EDX27_STIBPIsSupported = cpuHelper.GetEAX7ECX0_EDX27_STIBPIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX0_EDX27_STIBPIsSupported: {cpuIdEAX7ECX0_EDX27_STIBPIsSupported}");

            bool cpuIdEAX7ECX0_EDX28_L1D_FLUSHIsSupported = cpuHelper.GetEAX7ECX0_EDX28_L1D_FLUSHIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX0_EDX28_L1D_FLUSHIsSupported: {cpuIdEAX7ECX0_EDX28_L1D_FLUSHIsSupported}");

            bool cpuIdEAX7ECX0_EDX29_ARCH_CAPABILITIESIsSupported = cpuHelper.GetEAX7ECX0_EDX29_ARCH_CAPABILITIESIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX0_EDX29_ARCH_CAPABILITIESIsSupported: {cpuIdEAX7ECX0_EDX29_ARCH_CAPABILITIESIsSupported}");

            bool cpuIdEAX7ECX0_EDX30_CORE_CAPABILITIESIsSupported = cpuHelper.GetEAX7ECX0_EDX30_CORE_CAPABILITIESIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX0_EDX30_CORE_CAPABILITIESIsSupported: {cpuIdEAX7ECX0_EDX30_CORE_CAPABILITIESIsSupported}");

            bool cpuIdEAX7ECX0_EDX31_SSBDIsSupported = cpuHelper.GetEAX7ECX0_EDX31_SSBDIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX0_EDX31_SSBDIsSupported: {cpuIdEAX7ECX0_EDX31_SSBDIsSupported}");

            string cpuIdEAX7ECX1EAX = cpuHelper.GetEAX7ECX1EAXX();
            Console.WriteLine($"EAX7ECX1EAX: {cpuIdEAX7ECX1EAX}");

            string cpuIdEAX7ECX1EBX = cpuHelper.GetEAX7ECX1EBXX();
            Console.WriteLine($"EAX7ECX1EBX: {cpuIdEAX7ECX1EBX}");

            string cpuIdEAX7ECX1ECX = cpuHelper.GetEAX7ECX1ECXX();
            Console.WriteLine($"EAX7ECX1ECX: {cpuIdEAX7ECX1ECX}");

            string cpuIdEAX7ECX1EDX = cpuHelper.GetEAX7ECX1EDXX();
            Console.WriteLine($"EAX7ECX1EDX: {cpuIdEAX7ECX1EDX}");

            bool cpuIdEAX7ECX1_EAX0_SHA512IsSupported = cpuHelper.GetEAX7ECX1_EAX0_SHA512IsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX0_SHA512IsSupported: {cpuIdEAX7ECX1_EAX0_SHA512IsSupported}");

            bool cpuIdEAX7ECX1_EAX1_SM3IsSupported = cpuHelper.GetEAX7ECX1_EAX1_SM3IsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX1_SM3IsSupported: {cpuIdEAX7ECX1_EAX1_SM3IsSupported}");

            bool cpuIdEAX7ECX1_EAX2_SM4IsSupported = cpuHelper.GetEAX7ECX1_EAX2_SM4IsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX2_SM4IsSupported: {cpuIdEAX7ECX1_EAX2_SM4IsSupported}");

            bool cpuIdEAX7ECX1_EAX3_RAO_INTIsSupported = cpuHelper.GetEAX7ECX1_EAX3_RAO_INTIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX3_RAO_INTIsSupported: {cpuIdEAX7ECX1_EAX3_RAO_INTIsSupported}");

            bool cpuIdEAX7ECX1_EAX4_AVX_VNNIIsSupported = cpuHelper.GetEAX7ECX1_EAX4_AVX_VNNIIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX4_AVX_VNNIIsSupported: {cpuIdEAX7ECX1_EAX4_AVX_VNNIIsSupported}");

            bool cpuIdEAX7ECX1_EAX5_AVX512_BF16IsSupported = cpuHelper.GetEAX7ECX1_EAX5_AVX512_BF16IsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX5_AVX512_BF16IsSupported: {cpuIdEAX7ECX1_EAX5_AVX512_BF16IsSupported}");

            bool cpuIdEAX7ECX1_EAX6_LASSIsSupported = cpuHelper.GetEAX7ECX1_EAX6_LASSIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX6_LASSIsSupported: {cpuIdEAX7ECX1_EAX6_LASSIsSupported}");

            bool cpuIdEAX7ECX1_EAX7_CMPCCXADDIsSupported = cpuHelper.GetEAX7ECX1_EAX7_CMPCCXADDIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX7_CMPCCXADDIsSupported: {cpuIdEAX7ECX1_EAX7_CMPCCXADDIsSupported}");

            bool cpuIdEAX7ECX1_EAX8_ARCHPERFMONEXTIsSupported = cpuHelper.GetEAX7ECX1_EAX8_ARCHPERFMONEXTIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX8_ARCHPERFMONEXTIsSupported: {cpuIdEAX7ECX1_EAX8_ARCHPERFMONEXTIsSupported}");

            bool cpuIdEAX7ECX1_EAX9_DEDUPIsSupported = cpuHelper.GetEAX7ECX1_EAX9_DEDUPIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX9_DEDUPIsSupported: {cpuIdEAX7ECX1_EAX9_DEDUPIsSupported}");

            bool cpuIdEAX7ECX1_EAX10_FZRMIsSupported = cpuHelper.GetEAX7ECX1_EAX10_FZRMIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX10_FZRMIsSupported: {cpuIdEAX7ECX1_EAX10_FZRMIsSupported}");

            bool cpuIdEAX7ECX1_EAX11_FSRSIsSupported = cpuHelper.GetEAX7ECX1_EAX11_FSRSIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX11_FSRSIsSupported: {cpuIdEAX7ECX1_EAX11_FSRSIsSupported}");

            bool cpuIdEAX7ECX1_EAX12_RSRCSIsSupported = cpuHelper.GetEAX7ECX1_EAX12_RSRCSIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX12_RSRCSIsSupported: {cpuIdEAX7ECX1_EAX12_RSRCSIsSupported}");

            bool cpuIdEAX7ECX1_EAX13_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EAX13_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX13_ReservedIsSupported: {cpuIdEAX7ECX1_EAX13_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EAX14_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EAX14_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX14_ReservedIsSupported: {cpuIdEAX7ECX1_EAX14_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EAX15_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EAX15_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX15_ReservedIsSupported: {cpuIdEAX7ECX1_EAX15_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EAX16_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EAX16_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX16_ReservedIsSupported: {cpuIdEAX7ECX1_EAX16_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EAX17_FREDIsSupported = cpuHelper.GetEAX7ECX1_EAX17_FREDIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX17_FREDIsSupported: {cpuIdEAX7ECX1_EAX17_FREDIsSupported}");

            bool cpuIdEAX7ECX1_EAX18_LKGSIsSupported = cpuHelper.GetEAX7ECX1_EAX18_LKGSIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX18_LKGSIsSupported: {cpuIdEAX7ECX1_EAX18_LKGSIsSupported}");

            bool cpuIdEAX7ECX1_EAX19_WRMSRNSIsSupported = cpuHelper.GetEAX7ECX1_EAX19_WRMSRNSIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX19_WRMSRNSIsSupported: {cpuIdEAX7ECX1_EAX19_WRMSRNSIsSupported}");

            bool cpuIdEAX7ECX1_EAX20_NMI_SRCIsSupported = cpuHelper.GetEAX7ECX1_EAX20_NMI_SRCIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX20_NMI_SRCIsSupported: {cpuIdEAX7ECX1_EAX20_NMI_SRCIsSupported}");

            bool cpuIdEAX7ECX1_EAX21_AMX_FP16IsSupported = cpuHelper.GetEAX7ECX1_EAX21_AMX_FP16IsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX21_AMX_FP16IsSupported: {cpuIdEAX7ECX1_EAX21_AMX_FP16IsSupported}");

            bool cpuIdEAX7ECX1_EAX22_HRESETIsSupported = cpuHelper.GetEAX7ECX1_EAX22_HRESETIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX22_HRESETIsSupported: {cpuIdEAX7ECX1_EAX22_HRESETIsSupported}");

            bool cpuIdEAX7ECX1_EAX23_AVX_IFMAIsSupported = cpuHelper.GetEAX7ECX1_EAX23_AVX_IFMAIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX23_AVX_IFMAIsSupported: {cpuIdEAX7ECX1_EAX23_AVX_IFMAIsSupported}");

            bool cpuIdEAX7ECX1_EAX24_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EAX24_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX24_ReservedIsSupported: {cpuIdEAX7ECX1_EAX24_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EAX25_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EAX25_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX25_ReservedIsSupported: {cpuIdEAX7ECX1_EAX25_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EAX26_LAMIsSupported = cpuHelper.GetEAX7ECX1_EAX26_LAMIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX26_LAMIsSupported: {cpuIdEAX7ECX1_EAX26_LAMIsSupported}");

            bool cpuIdEAX7ECX1_EAX27_MSRListIsSupported = cpuHelper.GetEAX7ECX1_EAX27_MSRListIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX27_MSRListIsSupported: {cpuIdEAX7ECX1_EAX27_MSRListIsSupported}");

            bool cpuIdEAX7ECX1_EAX28_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EAX28_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX28_ReservedIsSupported: {cpuIdEAX7ECX1_EAX28_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EAX29_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EAX29_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX29_ReservedIsSupported: {cpuIdEAX7ECX1_EAX29_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EAX30_INVD_DISABLE_POST_BIOS_DONEIsSupported = cpuHelper.GetEAX7ECX1_EAX30_INVD_DISABLE_POST_BIOS_DONEIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX30_INVD_DISABLE_POST_BIOS_DONEIsSupported: {cpuIdEAX7ECX1_EAX30_INVD_DISABLE_POST_BIOS_DONEIsSupported}");

            bool cpuIdEAX7ECX1_EAX31_MOVRSIsSupported = cpuHelper.GetEAX7ECX1_EAX31_MOVRSIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EAX31_MOVRSIsSupported: {cpuIdEAX7ECX1_EAX31_MOVRSIsSupported}");

            bool cpuIdEAX7ECX1_EBX0_PPINIsSupported = cpuHelper.GetEAX7ECX1_EBX0_PPINIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX0_PPINIsSupported: {cpuIdEAX7ECX1_EBX0_PPINIsSupported}");

            bool cpuIdEAX7ECX1_EBX1_PBNDKBIsSupported = cpuHelper.GetEAX7ECX1_EBX1_PBNDKBIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX1_PBNDKBIsSupported: {cpuIdEAX7ECX1_EBX1_PBNDKBIsSupported}");

            bool cpuIdEAX7ECX1_EBX2_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EBX2_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX2_ReservedIsSupported: {cpuIdEAX7ECX1_EBX2_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EBX3_CPUID­MAXVAL_­LIM_RMVIsSupported = cpuHelper.GetEAX7ECX1_EBX3_CPUID­MAXVAL_­LIM_RMVIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX3_CPUID­MAXVAL_­LIM_RMVIsSupported: {cpuIdEAX7ECX1_EBX3_CPUID­MAXVAL_­LIM_RMVIsSupported}");

            bool cpuIdEAX7ECX1_EBX4_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EBX4_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX4_ReservedIsSupported: {cpuIdEAX7ECX1_EBX4_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EBX5_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EBX5_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX5_ReservedIsSupported: {cpuIdEAX7ECX1_EBX5_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EBX6_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EBX6_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX6_ReservedIsSupported: {cpuIdEAX7ECX1_EBX6_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EBX7_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EBX7_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX7_ReservedIsSupported: {cpuIdEAX7ECX1_EBX7_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EBX8_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EBX8_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX8_ReservedIsSupported: {cpuIdEAX7ECX1_EBX8_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EBX9_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EBX9_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX9_ReservedIsSupported: {cpuIdEAX7ECX1_EBX9_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EBX10_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EBX10_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX10_ReservedIsSupported: {cpuIdEAX7ECX1_EBX10_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EBX11_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EBX11_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX11_ReservedIsSupported: {cpuIdEAX7ECX1_EBX11_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EBX12_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EBX12_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX12_ReservedIsSupported: {cpuIdEAX7ECX1_EBX12_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EBX13_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EBX13_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX13_ReservedIsSupported: {cpuIdEAX7ECX1_EBX13_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EBX14_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EBX14_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX14_ReservedIsSupported: {cpuIdEAX7ECX1_EBX14_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EBX15_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EBX15_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX15_ReservedIsSupported: {cpuIdEAX7ECX1_EBX15_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EBX16_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EBX16_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX16_ReservedIsSupported: {cpuIdEAX7ECX1_EBX16_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EBX17_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EBX17_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX17_ReservedIsSupported: {cpuIdEAX7ECX1_EBX17_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EBX18_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EBX18_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX18_ReservedIsSupported: {cpuIdEAX7ECX1_EBX18_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EBX19_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EBX19_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX19_ReservedIsSupported: {cpuIdEAX7ECX1_EBX19_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EBX20_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EBX20_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX20_ReservedIsSupported: {cpuIdEAX7ECX1_EBX20_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EBX21_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EBX21_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX21_ReservedIsSupported: {cpuIdEAX7ECX1_EBX21_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EBX22_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EBX22_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX22_ReservedIsSupported: {cpuIdEAX7ECX1_EBX22_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EBX23_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EBX23_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX23_ReservedIsSupported: {cpuIdEAX7ECX1_EBX23_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EBX24_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EBX24_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX24_ReservedIsSupported: {cpuIdEAX7ECX1_EBX24_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EBX25_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EBX25_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX25_ReservedIsSupported: {cpuIdEAX7ECX1_EBX25_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EBX26_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EBX26_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX26_ReservedIsSupported: {cpuIdEAX7ECX1_EBX26_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EBX27_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EBX27_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX27_ReservedIsSupported: {cpuIdEAX7ECX1_EBX27_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EBX28_Reserved_MPSADBW_512IsSupported = cpuHelper.GetEAX7ECX1_EBX28_Reserved_MPSADBW_512IsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX28_Reserved_MPSADBW_512IsSupported: {cpuIdEAX7ECX1_EBX28_Reserved_MPSADBW_512IsSupported}");

            bool cpuIdEAX7ECX1_EBX29_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EBX29_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX29_ReservedIsSupported: {cpuIdEAX7ECX1_EBX29_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EBX30_Reserved_AVX512_RAO_FPIsSupported = cpuHelper.GetEAX7ECX1_EBX30_Reserved_AVX512_RAO_FPIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX30_Reserved_AVX512_RAO_FPIsSupported: {cpuIdEAX7ECX1_EBX30_Reserved_AVX512_RAO_FPIsSupported}");

            bool cpuIdEAX7ECX1_EBX31_Reserved_AVX512_RAO_FPIsSupported = cpuHelper.GetEAX7ECX1_EBX31_Reserved_AVX512_RAO_FPIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EBX31_Reserved_AVX512_RAO_FPIsSupported: {cpuIdEAX7ECX1_EBX31_Reserved_AVX512_RAO_FPIsSupported}");

            bool cpuIdEAX7ECX1_ECX0_RDT_M_­ASYMIsSupported = cpuHelper.GetEAX7ECX1_ECX0_RDT_M_­ASYMIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX0_RDT_M_­ASYMIsSupported­ASYMIsSupported: {cpuIdEAX7ECX1_ECX0_RDT_M_­ASYMIsSupported}");

            bool cpuIdEAX7ECX1_ECX1_RDT_M_­ASYMIsSupported = cpuHelper.GetEAX7ECX1_ECX1_RDT_M_­ASYMIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX1_RDT_M_­ASYMIsSupported­ASYMIsSupported: {cpuIdEAX7ECX1_ECX1_RDT_M_­ASYMIsSupported}");

            bool cpuIdEAX7ECX1_ECX2_Reserved_LEGACY_REDUCED_ISAIsSupported = cpuHelper.GetEAX7ECX1_ECX2_Reserved_LEGACY_REDUCED_ISAIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX2_Reserved_LEGACY_REDUCED_ISAIsSupported: {cpuIdEAX7ECX1_ECX2_Reserved_LEGACY_REDUCED_ISAIsSupported}");

            bool cpuIdEAX7ECX1_ECX3_ReservedIsSupported = cpuHelper.GetEAX7ECX1_ECX3_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX3_ReservedIsSupported: {cpuIdEAX7ECX1_ECX3_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_ECX4_SIPI64IsSupported = cpuHelper.GetEAX7ECX1_ECX4_SIPI64IsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX4_SIPI64IsSupported: {cpuIdEAX7ECX1_ECX4_SIPI64IsSupported}");

            bool cpuIdEAX7ECX1_ECX5_MSR_IMMIsSupported = cpuHelper.GetEAX7ECX1_ECX5_MSR_IMMIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX5_MSR_IMMIsSupported: {cpuIdEAX7ECX1_ECX5_MSR_IMMIsSupported}");

            bool cpuIdEAX7ECX1_ECX6_ReservedIsSupported = cpuHelper.GetEAX7ECX1_ECX6_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX6_ReservedIsSupported: {cpuIdEAX7ECX1_ECX6_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_ECX7_ReservedIsSupported = cpuHelper.GetEAX7ECX1_ECX7_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX7_ReservedIsSupported: {cpuIdEAX7ECX1_ECX7_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_ECX8_ReservedIsSupported = cpuHelper.GetEAX7ECX1_ECX8_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX8_ReservedIsSupported: {cpuIdEAX7ECX1_ECX8_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_ECX9_ReservedIsSupported = cpuHelper.GetEAX7ECX1_ECX9_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX9_ReservedIsSupported: {cpuIdEAX7ECX1_ECX9_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_ECX10_ReservedIsSupported = cpuHelper.GetEAX7ECX1_ECX10_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX10_ReservedIsSupported: {cpuIdEAX7ECX1_ECX10_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_ECX11_ReservedIsSupported = cpuHelper.GetEAX7ECX1_ECX11_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX11_ReservedIsSupported: {cpuIdEAX7ECX1_ECX11_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_ECX12_ReservedIsSupported = cpuHelper.GetEAX7ECX1_ECX12_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX12_ReservedIsSupported: {cpuIdEAX7ECX1_ECX12_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_ECX13_ReservedIsSupported = cpuHelper.GetEAX7ECX1_ECX13_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX13_ReservedIsSupported: {cpuIdEAX7ECX1_ECX13_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_ECX14_ReservedIsSupported = cpuHelper.GetEAX7ECX1_ECX14_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX14_ReservedIsSupported: {cpuIdEAX7ECX1_ECX14_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_ECX15_ReservedIsSupported = cpuHelper.GetEAX7ECX1_ECX15_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX15_ReservedIsSupported: {cpuIdEAX7ECX1_ECX15_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_ECX16_ReservedIsSupported = cpuHelper.GetEAX7ECX1_ECX16_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX16_ReservedIsSupported: {cpuIdEAX7ECX1_ECX16_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_ECX17_ReservedIsSupported = cpuHelper.GetEAX7ECX1_ECX17_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX17_ReservedIsSupported: {cpuIdEAX7ECX1_ECX17_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_ECX18_ReservedIsSupported = cpuHelper.GetEAX7ECX1_ECX18_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX18_ReservedIsSupported: {cpuIdEAX7ECX1_ECX18_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_ECX19_ReservedIsSupported = cpuHelper.GetEAX7ECX1_ECX19_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX19_ReservedIsSupported: {cpuIdEAX7ECX1_ECX19_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_ECX20_ReservedIsSupported = cpuHelper.GetEAX7ECX1_ECX20_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX20_ReservedIsSupported: {cpuIdEAX7ECX1_ECX20_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_ECX21_ReservedIsSupported = cpuHelper.GetEAX7ECX1_ECX21_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX21_ReservedIsSupported: {cpuIdEAX7ECX1_ECX21_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_ECX22_ReservedIsSupported = cpuHelper.GetEAX7ECX1_ECX22_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX22_ReservedIsSupported: {cpuIdEAX7ECX1_ECX22_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_ECX23_ReservedIsSupported = cpuHelper.GetEAX7ECX1_ECX23_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX23_ReservedIsSupported: {cpuIdEAX7ECX1_ECX23_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_ECX24_ReservedIsSupported = cpuHelper.GetEAX7ECX1_ECX24_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX24_ReservedIsSupported: {cpuIdEAX7ECX1_ECX24_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_ECX25_ReservedIsSupported = cpuHelper.GetEAX7ECX1_ECX25_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX25_ReservedIsSupported: {cpuIdEAX7ECX1_ECX25_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_ECX26_ReservedIsSupported = cpuHelper.GetEAX7ECX1_ECX26_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX26_ReservedIsSupported: {cpuIdEAX7ECX1_ECX26_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_ECX27_ReservedIsSupported = cpuHelper.GetEAX7ECX1_ECX27_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX27_ReservedIsSupported: {cpuIdEAX7ECX1_ECX27_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_ECX28_ReservedIsSupported = cpuHelper.GetEAX7ECX1_ECX28_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX28_ReservedIsSupported: {cpuIdEAX7ECX1_ECX28_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_ECX29_ReservedIsSupported = cpuHelper.GetEAX7ECX1_ECX29_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX29_ReservedIsSupported: {cpuIdEAX7ECX1_ECX29_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_ECX30_ReservedIsSupported = cpuHelper.GetEAX7ECX1_ECX30_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX30_ReservedIsSupported: {cpuIdEAX7ECX1_ECX30_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_ECX31_ReservedIsSupported = cpuHelper.GetEAX7ECX1_ECX31_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_ECX31_ReservedIsSupported: {cpuIdEAX7ECX1_ECX31_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EDX0_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EDX0_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX0_ReservedIsSupported: {cpuIdEAX7ECX1_EDX0_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EDX1_Reserved_AVX512_VNNI_FP16IsSupported = cpuHelper.GetEAX7ECX1_EDX1_Reserved_AVX512_VNNI_FP16IsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX1_Reserved_AVX512_VNNI_FP16IsSupported: {cpuIdEAX7ECX1_EDX1_Reserved_AVX512_VNNI_FP16IsSupported}");

            bool cpuIdEAX7ECX1_EDX2_Reserved_AVX512_VNNI_INT8IsSupported = cpuHelper.GetEAX7ECX1_EDX2_Reserved_AVX512_VNNI_INT8IsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX2_Reserved_AVX512_VNNI_INT8IsSupported: {cpuIdEAX7ECX1_EDX2_Reserved_AVX512_VNNI_INT8IsSupported}");

            bool cpuIdEAX7ECX1_EDX3_Reserved_AVX512_NE_CONVERTIsSupported = cpuHelper.GetEAX7ECX1_EDX3_Reserved_AVX512_NE_CONVERTIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX3_Reserved_AVX512_NE_CONVERTIsSupported: {cpuIdEAX7ECX1_EDX3_Reserved_AVX512_NE_CONVERTIsSupported}");

            bool cpuIdEAX7ECX1_EDX4_AVX_VNNI_INT8IsSupported = cpuHelper.GetEAX7ECX1_EDX4_AVX_VNNI_INT8IsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX4_AVX_VNNI_INT8IsSupported: {cpuIdEAX7ECX1_EDX4_AVX_VNNI_INT8IsSupported}");

            bool cpuIdEAX7ECX1_EDX5_AVX_NE_CONVERTIsSupported = cpuHelper.GetEAX7ECX1_EDX5_AVX_NE_CONVERTIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX5_AVX_NE_CONVERTIsSupported: {cpuIdEAX7ECX1_EDX5_AVX_NE_CONVERTIsSupported}");

            bool cpuIdEAX7ECX1_EDX6_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EDX6_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX6_ReservedIsSupported: {cpuIdEAX7ECX1_EDX6_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EDX7_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EDX7_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX7_ReservedIsSupported: {cpuIdEAX7ECX1_EDX7_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EDX8_AMX_COMPLEXIsSupported = cpuHelper.GetEAX7ECX1_EDX8_AMX_COMPLEXIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX8_AMX_COMPLEXIsSupported: {cpuIdEAX7ECX1_EDX8_AMX_COMPLEXIsSupported}");

            bool cpuIdEAX7ECX1_EDX9_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EDX9_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX9_ReservedIsSupported: {cpuIdEAX7ECX1_EDX9_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EDX10_AVX_VNNI_INT16IsSupported = cpuHelper.GetEAX7ECX1_EDX10_AVX_VNNI_INT16IsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX10_AVX_VNNI_INT16IsSupported: {cpuIdEAX7ECX1_EDX10_AVX_VNNI_INT16IsSupported}");

            bool cpuIdEAX7ECX1_EDX11_Reserved_AVX512_VNNI_INT16IsSupported = cpuHelper.GetEAX7ECX1_EDX11_Reserved_AVX512_VNNI_INT16IsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX11_Reserved_AVX512_VNNI_INT16IsSupported: {cpuIdEAX7ECX1_EDX11_Reserved_AVX512_VNNI_INT16IsSupported}");

            bool cpuIdEAX7ECX1_EDX12_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EDX12_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX12_ReservedIsSupported: {cpuIdEAX7ECX1_EDX12_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EDX13_UTMRIsSupported = cpuHelper.GetEAX7ECX1_EDX13_UTMRIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX13_UTMRIsSupported: {cpuIdEAX7ECX1_EDX13_UTMRIsSupported}");

            bool cpuIdEAX7ECX1_EDX14_PREFETCHIIsSupported = cpuHelper.GetEAX7ECX1_EDX14_PREFETCHIIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX14_PREFETCHIIsSupported: {cpuIdEAX7ECX1_EDX14_PREFETCHIIsSupported}");

            bool cpuIdEAX7ECX1_EDX15_USER_MSRIsSupported = cpuHelper.GetEAX7ECX1_EDX15_USER_MSRIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX15_USER_MSRIsSupported: {cpuIdEAX7ECX1_EDX15_USER_MSRIsSupported}");

            bool cpuIdEAX7ECX1_EDX16_Reserved_AVX512_BF16_NEIsSupported = cpuHelper.GetEAX7ECX1_EDX16_Reserved_AVX512_BF16_NEIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX16_Reserved_AVX512_BF16_NEIsSupported: {cpuIdEAX7ECX1_EDX16_Reserved_AVX512_BF16_NEIsSupported}");

            bool cpuIdEAX7ECX1_EDX17_UIRET_UIF_FROM_RFLAGSIsSupported = cpuHelper.GetEAX7ECX1_EDX17_UIRET_UIF_FROM_RFLAGSIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX17_UIRET_UIF_FROM_RFLAGSIsSupported: {cpuIdEAX7ECX1_EDX17_UIRET_UIF_FROM_RFLAGSIsSupported}");

            bool cpuIdEAX7ECX1_EDX18_CET_SSSIsSupported = cpuHelper.GetEAX7ECX1_EDX18_CET_SSSIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX18_CET_SSSIsSupported: {cpuIdEAX7ECX1_EDX18_CET_SSSIsSupported}");

            bool cpuIdEAX7ECX1_EDX19_AVX10IsSupported = cpuHelper.GetEAX7ECX1_EDX19_AVX10IsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX19_AVX10IsSupported: {cpuIdEAX7ECX1_EDX19_AVX10IsSupported}");

            bool cpuIdEAX7ECX1_EDX20_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EDX20_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX20_ReservedIsSupported: {cpuIdEAX7ECX1_EDX20_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EDX21_APX_FIsSupported = cpuHelper.GetEAX7ECX1_EDX21_APX_FIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX21_APX_FIsSupported: {cpuIdEAX7ECX1_EDX21_APX_FIsSupported}");

            bool cpuIdEAX7ECX1_EDX22_SEC_TEE_ATTESTATIONIsSupported = cpuHelper.GetEAX7ECX1_EDX22_SEC_TEE_ATTESTATIONIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX22_SEC_TEE_ATTESTATIONIsSupported: {cpuIdEAX7ECX1_EDX22_SEC_TEE_ATTESTATIONIsSupported}");

            bool cpuIdEAX7ECX1_EDX23_MWAITIsSupported = cpuHelper.GetEAX7ECX1_EDX23_MWAITIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX23_MWAITIsSupported: {cpuIdEAX7ECX1_EDX23_MWAITIsSupported}");

            bool cpuIdEAX7ECX1_EDX24_SLSMIsSupported = cpuHelper.GetEAX7ECX1_EDX24_SLSMIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX24_SLSMIsSupported: {cpuIdEAX7ECX1_EDX24_SLSMIsSupported}");

            bool cpuIdEAX7ECX1_EDX25_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EDX25_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX25_ReservedIsSupported: {cpuIdEAX7ECX1_EDX25_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EDX26_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EDX26_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX26_ReservedIsSupported: {cpuIdEAX7ECX1_EDX26_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EDX27_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EDX27_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX27_ReservedIsSupported: {cpuIdEAX7ECX1_EDX27_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EDX28_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EDX28_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX28_ReservedIsSupported: {cpuIdEAX7ECX1_EDX28_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EDX29_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EDX29_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX29_ReservedIsSupported: {cpuIdEAX7ECX1_EDX29_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EDX30_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EDX30_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX30_ReservedIsSupported: {cpuIdEAX7ECX1_EDX30_ReservedIsSupported}");

            bool cpuIdEAX7ECX1_EDX31_ReservedIsSupported = cpuHelper.GetEAX7ECX1_EDX31_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX1_EDX31_ReservedIsSupported: {cpuIdEAX7ECX1_EDX31_ReservedIsSupported}");

            string cpuIdEAX7ECX2EAX = cpuHelper.GetEAX7ECX2EAXX();
            Console.WriteLine($"EAX7ECX2EAX: {cpuIdEAX7ECX2EAX}");

            string cpuIdEAX7ECX2EBX = cpuHelper.GetEAX7ECX2EBXX();
            Console.WriteLine($"EAX7ECX2EBX: {cpuIdEAX7ECX2EBX}");

            string cpuIdEAX7ECX2ECX = cpuHelper.GetEAX7ECX2ECXX();
            Console.WriteLine($"EAX7ECX2ECX: {cpuIdEAX7ECX2ECX}");

            string cpuIdEAX7ECX2EDX = cpuHelper.GetEAX7ECX2EDXX();
            Console.WriteLine($"EAX7ECX2EDX: {cpuIdEAX7ECX2EDX}");

            bool cpuIdEAX7ECX2_EDX0_PSFDIsSupported = cpuHelper.GetEAX7ECX2_EDX0_PSFDIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX0_PSFDIsSupported: {cpuIdEAX7ECX2_EDX0_PSFDIsSupported}");

            bool cpuIdEAX7ECX2_EDX1_IPREDIsSupported = cpuHelper.GetEAX7ECX2_EDX1_IPREDIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX1_IPREDIsSupported: {cpuIdEAX7ECX2_EDX1_IPREDIsSupported}");

            bool cpuIdEAX7ECX2_EDX2_RRSBA_CTRLIsSupported = cpuHelper.GetEAX7ECX2_EDX2_RRSBA_CTRLIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX2_RRSBA_CTRLIsSupported: {cpuIdEAX7ECX2_EDX2_RRSBA_CTRLIsSupported}");

            bool cpuIdEAX7ECX2_EDX3_DDPD_UIsSupported = cpuHelper.GetEAX7ECX2_EDX3_DDPD_UIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX3_DDPD_UIsSupported: {cpuIdEAX7ECX2_EDX3_DDPD_UIsSupported}");

            bool cpuIdEAX7ECX2_EDX4_BHI_CTRLIsSupported = cpuHelper.GetEAX7ECX2_EDX4_BHI_CTRLIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX4_BHI_CTRLIsSupported: {cpuIdEAX7ECX2_EDX4_BHI_CTRLIsSupported}");

            bool cpuIdEAX7ECX2_EDX5_MCDT_NOIsSupported = cpuHelper.GetEAX7ECX2_EDX5_MCDT_NOIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX5_MCDT_NOIsSupported: {cpuIdEAX7ECX2_EDX5_MCDT_NOIsSupported}");

            bool cpuIdEAX7ECX2_EDX6_UC_LOCK_DISABLEIsSupported = cpuHelper.GetEAX7ECX2_EDX6_UC_LOCK_DISABLEIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX6_UC_LOCK_DISABLEIsSupported: {cpuIdEAX7ECX2_EDX6_UC_LOCK_DISABLEIsSupported}");

            bool cpuIdEAX7ECX2_EDX7_MONITOR_MITG_NOIsSupported = cpuHelper.GetEAX7ECX2_EDX7_MONITOR_MITG_NOIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX7_MONITOR_MITG_NOIsSupported: {cpuIdEAX7ECX2_EDX7_MONITOR_MITG_NOIsSupported}");

            bool cpuIdEAX7ECX2_EDX8_ReservedIsSupported = cpuHelper.GetEAX7ECX2_EDX8_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX8_ReservedIsSupported: {cpuIdEAX7ECX2_EDX8_ReservedIsSupported}");

            bool cpuIdEAX7ECX2_EDX9_ReservedIsSupported = cpuHelper.GetEAX7ECX2_EDX9_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX9_ReservedIsSupported: {cpuIdEAX7ECX2_EDX9_ReservedIsSupported}");

            bool cpuIdEAX7ECX2_EDX10_ReservedIsSupported = cpuHelper.GetEAX7ECX2_EDX10_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX10_ReservedIsSupported: {cpuIdEAX7ECX2_EDX10_ReservedIsSupported}");

            bool cpuIdEAX7ECX2_EDX11_ReservedIsSupported = cpuHelper.GetEAX7ECX2_EDX11_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX11_ReservedIsSupported: {cpuIdEAX7ECX2_EDX11_ReservedIsSupported}");

            bool cpuIdEAX7ECX2_EDX12_ReservedIsSupported = cpuHelper.GetEAX7ECX2_EDX12_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX12_ReservedIsSupported: {cpuIdEAX7ECX2_EDX12_ReservedIsSupported}");

            bool cpuIdEAX7ECX2_EDX13_ReservedIsSupported = cpuHelper.GetEAX7ECX2_EDX13_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX13_ReservedIsSupported: {cpuIdEAX7ECX2_EDX13_ReservedIsSupported}");

            bool cpuIdEAX7ECX2_EDX14_ReservedIsSupported = cpuHelper.GetEAX7ECX2_EDX14_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX14_ReservedIsSupported: {cpuIdEAX7ECX2_EDX14_ReservedIsSupported}");

            bool cpuIdEAX7ECX2_EDX15_ReservedIsSupported = cpuHelper.GetEAX7ECX2_EDX15_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX15_ReservedIsSupported: {cpuIdEAX7ECX2_EDX15_ReservedIsSupported}");

            bool cpuIdEAX7ECX2_EDX16_ReservedIsSupported = cpuHelper.GetEAX7ECX2_EDX16_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX16_ReservedIsSupported: {cpuIdEAX7ECX2_EDX16_ReservedIsSupported}");

            bool cpuIdEAX7ECX2_EDX17_ReservedIsSupported = cpuHelper.GetEAX7ECX2_EDX17_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX17_ReservedIsSupported: {cpuIdEAX7ECX2_EDX17_ReservedIsSupported}");

            bool cpuIdEAX7ECX2_EDX18_ReservedIsSupported = cpuHelper.GetEAX7ECX2_EDX18_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX18_ReservedIsSupported: {cpuIdEAX7ECX2_EDX18_ReservedIsSupported}");

            bool cpuIdEAX7ECX2_EDX19_ReservedIsSupported = cpuHelper.GetEAX7ECX2_EDX19_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX19_ReservedIsSupported: {cpuIdEAX7ECX2_EDX19_ReservedIsSupported}");

            bool cpuIdEAX7ECX2_EDX20_ReservedIsSupported = cpuHelper.GetEAX7ECX2_EDX20_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX20_ReservedIsSupported: {cpuIdEAX7ECX2_EDX20_ReservedIsSupported}");

            bool cpuIdEAX7ECX2_EDX21_ReservedIsSupported = cpuHelper.GetEAX7ECX2_EDX21_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX21_ReservedIsSupported: {cpuIdEAX7ECX2_EDX21_ReservedIsSupported}");

            bool cpuIdEAX7ECX2_EDX22_ReservedIsSupported = cpuHelper.GetEAX7ECX2_EDX22_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX22_ReservedIsSupported: {cpuIdEAX7ECX2_EDX22_ReservedIsSupported}");

            bool cpuIdEAX7ECX2_EDX23_ReservedIsSupported = cpuHelper.GetEAX7ECX2_EDX23_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX23_ReservedIsSupported: {cpuIdEAX7ECX2_EDX23_ReservedIsSupported}");

            bool cpuIdEAX7ECX2_EDX24_ReservedIsSupported = cpuHelper.GetEAX7ECX2_EDX24_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX24_ReservedIsSupported: {cpuIdEAX7ECX2_EDX24_ReservedIsSupported}");

            bool cpuIdEAX7ECX2_EDX25_ReservedIsSupported = cpuHelper.GetEAX7ECX2_EDX25_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX25_ReservedIsSupported: {cpuIdEAX7ECX2_EDX25_ReservedIsSupported}");

            bool cpuIdEAX7ECX2_EDX26_ReservedIsSupported = cpuHelper.GetEAX7ECX2_EDX26_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX26_ReservedIsSupported: {cpuIdEAX7ECX2_EDX26_ReservedIsSupported}");

            bool cpuIdEAX7ECX2_EDX27_ReservedIsSupported = cpuHelper.GetEAX7ECX2_EDX27_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX27_ReservedIsSupported: {cpuIdEAX7ECX2_EDX27_ReservedIsSupported}");

            bool cpuIdEAX7ECX2_EDX28_ReservedIsSupported = cpuHelper.GetEAX7ECX2_EDX28_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX28_ReservedIsSupported: {cpuIdEAX7ECX2_EDX28_ReservedIsSupported}");

            bool cpuIdEAX7ECX2_EDX29_ReservedIsSupported = cpuHelper.GetEAX7ECX2_EDX29_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX29_ReservedIsSupported: {cpuIdEAX7ECX2_EDX29_ReservedIsSupported}");

            bool cpuIdEAX7ECX2_EDX30_ReservedIsSupported = cpuHelper.GetEAX7ECX2_EDX30_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX30_ReservedIsSupported: {cpuIdEAX7ECX2_EDX30_ReservedIsSupported}");

            bool cpuIdEAX7ECX2_EDX31_ReservedIsSupported = cpuHelper.GetEAX7ECX2_EDX31_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX7ECX2_EDX31_ReservedIsSupported: {cpuIdEAX7ECX2_EDX31_ReservedIsSupported}");

            #endregion

            #region EAX=0x0D: XSAVE Features and State Components

            string cpuIdEAXDEAX = cpuHelper.GetEAXDEAXX();
            Console.WriteLine($"EAXDEAX: {cpuIdEAXDEAX}");

            string cpuIdEAXDEBX = cpuHelper.GetEAXDEBXX();
            Console.WriteLine($"EAXDEBX: {cpuIdEAXDEBX}");

            string cpuIdEAXDECX = cpuHelper.GetEAXDECXX();
            Console.WriteLine($"EAXDECX: {cpuIdEAXDECX}");

            string cpuIdEAXDEDX = cpuHelper.GetEAXDEDXX();
            Console.WriteLine($"EAXDEDX: {cpuIdEAXDEDX}");

            #endregion

            #region EAX=0x12: SGX Capabilities

            string cpuIdEAX12EAX = cpuHelper.GetEAX12EAXX();
            Console.WriteLine($"EAX12EAX: {cpuIdEAX12EAX}");

            string cpuIdEAX12EBX = cpuHelper.GetEAX12EBXX();
            Console.WriteLine($"EAX12EBX: {cpuIdEAX12EBX}");

            string cpuIdEAX12ECX = cpuHelper.GetEAX12ECXX();
            Console.WriteLine($"EAX12ECX: {cpuIdEAX12ECX}");

            string cpuIdEAX12EDX = cpuHelper.GetEAX12EDXX();
            Console.WriteLine($"EAX12EDX: {cpuIdEAX12EDX}");

            #endregion

            #region EAX=0x14, ECX=0x0: Processor Trace feature bits in EBX and ECX

            string cpuIdEAX14ECX0EAX = cpuHelper.GetEAX14ECX0EAXX();
            Console.WriteLine($"EAX14ECX0EAX: {cpuIdEAX14ECX0EAX}");

            string cpuIdEAX14ECX0EBX = cpuHelper.GetEAX14ECX0EBXX();
            Console.WriteLine($"EAX14ECX0EBX: {cpuIdEAX14ECX0EBX}");

            string cpuIdEAX14ECX0ECX = cpuHelper.GetEAX14ECX0ECXX();
            Console.WriteLine($"EAX14ECX0ECX: {cpuIdEAX14ECX0ECX}");

            string cpuIdEAX14ECX0EDX = cpuHelper.GetEAX14ECX0EDXX();
            Console.WriteLine($"EAX14ECX0EDX: {cpuIdEAX14ECX0EDX}");

            bool cpuIdEAX14ECX0_EBX0_Cr3FilterIsSupported = cpuHelper.GetEAX14ECX0_EBX0_Cr3FilterIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX0_Cr3FilterIsSupported: {cpuIdEAX14ECX0_EBX0_Cr3FilterIsSupported}");

            bool cpuIdEAX14ECX0_EBX1_ConfigurablePSBIsSupported = cpuHelper.GetEAX14ECX0_EBX1_ConfigurablePSBIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX1_ConfigurablePSBIsSupported: {cpuIdEAX14ECX0_EBX1_ConfigurablePSBIsSupported}");

            bool cpuIdEAX14ECX0_EBX2_IPFilterIsSupported = cpuHelper.GetEAX14ECX0_EBX2_IPFilterIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX2_IPFilterIsSupported: {cpuIdEAX14ECX0_EBX2_IPFilterIsSupported}");

            bool cpuIdEAX14ECX0_EBX3_MtcIsSupported = cpuHelper.GetEAX14ECX0_EBX3_MtcIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX3_MtcIsSupported: {cpuIdEAX14ECX0_EBX3_MtcIsSupported}");

            bool cpuIdEAX14ECX0_EBX4_PtwriteIsSupported = cpuHelper.GetEAX14ECX0_EBX4_PtwriteIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX4_PtwriteIsSupported: {cpuIdEAX14ECX0_EBX4_PtwriteIsSupported}");

            bool cpuIdEAX14ECX0_EBX5_PwrEvtTraceIsSupported = cpuHelper.GetEAX14ECX0_EBX5_PwrEvtTraceIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX5_PwrEvtTraceIsSupported: {cpuIdEAX14ECX0_EBX5_PwrEvtTraceIsSupported}");

            bool cpuIdEAX14ECX0_EBX6_PmiPreserveIsSupported = cpuHelper.GetEAX14ECX0_EBX6_PmiPreserveIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX6_PmiPreserveIsSupported: {cpuIdEAX14ECX0_EBX6_PmiPreserveIsSupported}");

            bool cpuIdEAX14ECX0_EBX7_EventTraceIsSupported = cpuHelper.GetEAX14ECX0_EBX7_EventTraceIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX7_EventTraceIsSupported: {cpuIdEAX14ECX0_EBX7_EventTraceIsSupported}");

            bool cpuIdEAX14ECX0_EBX8_TntDisIsSupported = cpuHelper.GetEAX14ECX0_EBX8_TntDisIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX8_TntDisIsSupported: {cpuIdEAX14ECX0_EBX8_TntDisIsSupported}");

            bool cpuIdEAX14ECX0_EBX9_PtttIsSupported = cpuHelper.GetEAX14ECX0_EBX9_PtttIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX9_PtttIsSupported: {cpuIdEAX14ECX0_EBX9_PtttIsSupported}");

            bool cpuIdEAX14ECX0_EBX10_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX10_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX10_ReservedIsSupported: {cpuIdEAX14ECX0_EBX10_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_EBX11_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX11_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX11_ReservedIsSupported: {cpuIdEAX14ECX0_EBX11_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_EBX12_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX12_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX12_ReservedIsSupported: {cpuIdEAX14ECX0_EBX12_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_EBX13_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX13_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX13_ReservedIsSupported: {cpuIdEAX14ECX0_EBX13_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_EBX14_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX14_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX14_ReservedIsSupported: {cpuIdEAX14ECX0_EBX14_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_EBX15_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX15_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX15_ReservedIsSupported: {cpuIdEAX14ECX0_EBX15_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_EBX16_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX16_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX16_ReservedIsSupported: {cpuIdEAX14ECX0_EBX16_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_EBX17_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX17_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX17_ReservedIsSupported: {cpuIdEAX14ECX0_EBX17_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_EBX18_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX18_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX18_ReservedIsSupported: {cpuIdEAX14ECX0_EBX18_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_EBX19_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX19_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX19_ReservedIsSupported: {cpuIdEAX14ECX0_EBX19_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_EBX20_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX20_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX20_ReservedIsSupported: {cpuIdEAX14ECX0_EBX20_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_EBX21_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX21_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX21_ReservedIsSupported: {cpuIdEAX14ECX0_EBX21_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_EBX22_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX22_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX22_ReservedIsSupported: {cpuIdEAX14ECX0_EBX22_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_EBX23_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX23_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX23_ReservedIsSupported: {cpuIdEAX14ECX0_EBX23_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_EBX24_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX24_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX24_ReservedIsSupported: {cpuIdEAX14ECX0_EBX24_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_EBX25_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX25_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX25_ReservedIsSupported: {cpuIdEAX14ECX0_EBX25_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_EBX26_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX26_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX26_ReservedIsSupported: {cpuIdEAX14ECX0_EBX26_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_EBX27_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX27_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX27_ReservedIsSupported: {cpuIdEAX14ECX0_EBX27_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_EBX28_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX28_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX28_ReservedIsSupported: {cpuIdEAX14ECX0_EBX28_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_EBX29_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX29_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX29_ReservedIsSupported: {cpuIdEAX14ECX0_EBX29_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_EBX30_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX30_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX30_ReservedIsSupported: {cpuIdEAX14ECX0_EBX30_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_EBX31_ReservedIsSupported = cpuHelper.GetEAX14ECX0_EBX31_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_EBX31_ReservedIsSupported: {cpuIdEAX14ECX0_EBX31_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_ECX0_TopaOutIsSupported = cpuHelper.GetEAX14ECX0_ECX0_TopaOutIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX0_TopaOutIsSupported: {cpuIdEAX14ECX0_ECX0_TopaOutIsSupported}");

            bool cpuIdEAX14ECX0_ECX1_MentryIsSupported = cpuHelper.GetEAX14ECX0_ECX1_MentryIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX1_MentryIsSupported: {cpuIdEAX14ECX0_ECX1_MentryIsSupported}");

            bool cpuIdEAX14ECX0_ECX2_SnglRngOutIsSupported = cpuHelper.GetEAX14ECX0_ECX2_SnglRngOutIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX2_SnglRngOutIsSupported: {cpuIdEAX14ECX0_ECX2_SnglRngOutIsSupported}");

            bool cpuIdEAX14ECX0_ECX3_TraceTransportSubsystemIsSupported = cpuHelper.GetEAX14ECX0_ECX3_TraceTransportSubsystemIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX3_TraceTransportSubsystemIsSupported: {cpuIdEAX14ECX0_ECX3_TraceTransportSubsystemIsSupported}");

            bool cpuIdEAX14ECX0_ECX4_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX4_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX4_ReservedIsSupported: {cpuIdEAX14ECX0_ECX4_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_ECX5_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX5_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX5_ReservedIsSupported: {cpuIdEAX14ECX0_ECX5_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_ECX6_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX6_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX6_ReservedIsSupported: {cpuIdEAX14ECX0_ECX6_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_ECX7_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX7_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX7_ReservedIsSupported: {cpuIdEAX14ECX0_ECX7_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_ECX8_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX8_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX8_ReservedIsSupported: {cpuIdEAX14ECX0_ECX8_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_ECX9_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX9_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX9_ReservedIsSupported: {cpuIdEAX14ECX0_ECX9_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_ECX10_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX10_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX10_ReservedIsSupported: {cpuIdEAX14ECX0_ECX10_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_ECX11_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX11_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX11_ReservedIsSupported: {cpuIdEAX14ECX0_ECX11_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_ECX12_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX12_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX12_ReservedIsSupported: {cpuIdEAX14ECX0_ECX12_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_ECX13_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX13_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX13_ReservedIsSupported: {cpuIdEAX14ECX0_ECX13_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_ECX14_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX14_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX14_ReservedIsSupported: {cpuIdEAX14ECX0_ECX14_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_ECX15_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX15_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX15_ReservedIsSupported: {cpuIdEAX14ECX0_ECX15_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_ECX16_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX16_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX16_ReservedIsSupported: {cpuIdEAX14ECX0_ECX16_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_ECX17_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX17_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX17_ReservedIsSupported: {cpuIdEAX14ECX0_ECX17_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_ECX18_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX18_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX18_ReservedIsSupported: {cpuIdEAX14ECX0_ECX18_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_ECX19_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX19_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX19_ReservedIsSupported: {cpuIdEAX14ECX0_ECX19_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_ECX20_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX20_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX20_ReservedIsSupported: {cpuIdEAX14ECX0_ECX20_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_ECX21_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX21_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX21_ReservedIsSupported: {cpuIdEAX14ECX0_ECX21_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_ECX22_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX22_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX22_ReservedIsSupported: {cpuIdEAX14ECX0_ECX22_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_ECX23_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX23_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX23_ReservedIsSupported: {cpuIdEAX14ECX0_ECX23_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_ECX24_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX24_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX24_ReservedIsSupported: {cpuIdEAX14ECX0_ECX24_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_ECX25_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX25_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX25_ReservedIsSupported: {cpuIdEAX14ECX0_ECX25_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_ECX26_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX26_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX26_ReservedIsSupported: {cpuIdEAX14ECX0_ECX26_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_ECX27_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX27_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX27_ReservedIsSupported: {cpuIdEAX14ECX0_ECX27_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_ECX28_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX28_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX28_ReservedIsSupported: {cpuIdEAX14ECX0_ECX28_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_ECX29_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX29_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX29_ReservedIsSupported: {cpuIdEAX14ECX0_ECX29_ReservedIsSupported}");

            bool cpuIdEAX14ECX0_ECX30_ReservedIsSupported = cpuHelper.GetEAX14ECX0_ECX30_ReservedIsSupportedX();
            Console.WriteLine($"cpuIdEAX14ECX0_ECX30_ReservedIsSupported: {cpuIdEAX14ECX0_ECX30_ReservedIsSupported}");

            #endregion

            #region EAX=0x14, ECX=0x1: Processor Trace packet generation information in EAX, EBX and ECX

            string cpuIdEAX14ECX1EAX = cpuHelper.GetEAX14ECX1EAXX();
            Console.WriteLine($"EAX14ECX1EAX: {cpuIdEAX14ECX1EAX}");

            string cpuIdEAX14ECX1EBX = cpuHelper.GetEAX14ECX1EBXX();
            Console.WriteLine($"EAX14ECX1EBX: {cpuIdEAX14ECX1EBX}");

            string cpuIdEAX14ECX1ECX = cpuHelper.GetEAX14ECX1ECXX();
            Console.WriteLine($"EAX14ECX1ECX: {cpuIdEAX14ECX1ECX}");

            string cpuIdEAX14ECX1EDX = cpuHelper.GetEAX14ECX1EDXX();
            Console.WriteLine($"EAX14ECX1EDX: {cpuIdEAX14ECX1EDX}");

            string cpuIdEAX14ECX1EAX0_2_Rangecnt = cpuHelper.GetEAX14ECX1EAX0_2_RangecntX();
            Console.WriteLine($"EAX14ECX1EAX0_2_Rangecnt: {cpuIdEAX14ECX1EAX0_2_Rangecnt}");

            string cpuIdEAX14ECX1EAX3_5_Reserved = cpuHelper.GetEAX14ECX1EAX3_5_ReservedX();
            Console.WriteLine($"EAX14ECX1EAX3_5_Reserved: {cpuIdEAX14ECX1EAX3_5_Reserved}");

            string cpuIdEAX14ECX1EAX8_10_TriggerConfigCount = cpuHelper.GetEAX14ECX1EAX8_10_TriggerConfigCountX();
            Console.WriteLine($"EAX14ECX1EAX8_10_TriggerConfigCount: {cpuIdEAX14ECX1EAX8_10_TriggerConfigCount}");

            string cpuIdEAX14ECX1EAX11_14_Reserved = cpuHelper.GetEAX14ECX1EAX11_14_ReservedX();
            Console.WriteLine($"EAX14ECX1EAX11_14_Reserved: {cpuIdEAX14ECX1EAX11_14_Reserved}");

            string cpuIdEAX14ECX1EAX15_Reserved = cpuHelper.GetEAX14ECX1EAX15_ReservedX();
            Console.WriteLine($"EAX14ECX1EAX15_Reserved: {cpuIdEAX14ECX1EAX15_Reserved}");

            string cpuIdEAX14ECX1EAX16_31_MtcRate = cpuHelper.GetEAX14ECX1EAX16_31_MtcRateX();
            Console.WriteLine($"EAX14ECX1EAX16_31_MtcRate: {cpuIdEAX14ECX1EAX16_31_MtcRate}");

            string cpuIdEAX14ECX1EBX0_15_CycThresholds = cpuHelper.GetEAX14ECX1EBX0_15_CycThresholdsX();
            Console.WriteLine($"EAX14ECX1EBX0_15_CycThresholds: {cpuIdEAX14ECX1EBX0_15_CycThresholds}");

            string cpuIdEAX14ECX1EBX16_31_PsbRate = cpuHelper.GetEAX14ECX1EBX16_31_PsbRateX();
            Console.WriteLine($"EAX14ECX1EBX16_31_PsbRate: {cpuIdEAX14ECX1EBX16_31_PsbRate}");

            string cpuIdEAX14ECX1ECX0_Icnt = cpuHelper.GetEAX14ECX1ECX0_IcntX();
            Console.WriteLine($"EAX14ECX1ECX0_Icnt: {cpuIdEAX14ECX1ECX0_Icnt}");

            string cpuIdEAX14ECX1ECX1_TriggerPause = cpuHelper.GetEAX14ECX1ECX1_TriggerPauseX();
            Console.WriteLine($"EAX14ECX1ECX1_TriggerPause: {cpuIdEAX14ECX1ECX1_TriggerPause}");

            string cpuIdEAX14ECX1ECX2_Reserved = cpuHelper.GetEAX14ECX1ECX2_ReservedX();
            Console.WriteLine($"EAX14ECX1ECX2_Reserved: {cpuIdEAX14ECX1ECX2_Reserved}");

            string cpuIdEAX14ECX1ECX3_7_Reserved = cpuHelper.GetEAX14ECX1ECX3_7_ReservedX();
            Console.WriteLine($"EAX14ECX1ECX3_7_Reserved: {cpuIdEAX14ECX1ECX3_7_Reserved}");

            string cpuIdEAX14ECX1ECX8_10_Reserved = cpuHelper.GetEAX14ECX1ECX8_10_ReservedX();
            Console.WriteLine($"EAX14ECX1ECX8_10_Reserved: {cpuIdEAX14ECX1ECX8_10_Reserved}");

            string cpuIdEAX14ECX1ECX11_14_Reserved = cpuHelper.GetEAX14ECX1ECX11_14_ReservedX();
            Console.WriteLine($"EAX14ECX1ECX11_14_Reserved: {cpuIdEAX14ECX1ECX11_14_Reserved}");

            string cpuIdEAX14ECX1ECX15_TriggerDrMatch = cpuHelper.GetEAX14ECX1ECX15_TriggerDrMatchX();
            Console.WriteLine($"EAX14ECX1ECX15_TriggerDrMatch: {cpuIdEAX14ECX1ECX15_TriggerDrMatch}");

            string cpuIdEAX14ECX1ECX16_31_Reserved = cpuHelper.GetEAX14ECX1ECX16_31_ReservedX();
            Console.WriteLine($"EAX14ECX1ECX16_31_Reserved: {cpuIdEAX14ECX1ECX16_31_Reserved}");

            #endregion

            #region EAX=0x15: TSC and Core Crystal frequency information

            string cpuIdEAX15EAX = cpuHelper.GetEAX15EAXX();
            Console.WriteLine($"EAX15EAX: {cpuIdEAX15EAX}");

            string cpuIdEAX15EBX = cpuHelper.GetEAX15EBXX();
            Console.WriteLine($"EAX15EBX: {cpuIdEAX15EBX}");

            string cpuIdEAX15ECX = cpuHelper.GetEAX15ECXX();
            Console.WriteLine($"EAX15ECX: {cpuIdEAX15ECX}");

            string cpuIdEAX15EDX = cpuHelper.GetEAX15EDXX();
            Console.WriteLine($"EAX15EDX: {cpuIdEAX15EDX}");

            string cpuIdEAX15EAX_RatioOfTSCFrequencyToCoreCrystalClockFrequency_Denominator = cpuHelper.GetEAX15EAX_RatioOfTSCFrequencyToCoreCrystalClockFrequency_DenominatorX();
            Console.WriteLine($"EAX15EAX_RatioOfTSCFrequencyToCoreCrystalClockFrequency_Denominator: {cpuIdEAX15EAX_RatioOfTSCFrequencyToCoreCrystalClockFrequency_Denominator}");

            string cpuIdEAX15EBX_RatioOfTSCFrequencyToCoreCrystalClockFrequency_Numerator = cpuHelper.GetEAX15EBX_RatioOfTSCFrequencyToCoreCrystalClockFrequency_NumeratorX();
            Console.WriteLine($"EAX15EBX_RatioOfTSCFrequencyToCoreCrystalClockFrequency_Numerator: {cpuIdEAX15EBX_RatioOfTSCFrequencyToCoreCrystalClockFrequency_Numerator}");

            string cpuIdEAX15ECX_CoreCrystalClockFrequencyInHz = cpuHelper.GetEAX15ECX_CoreCrystalClockFrequencyInHzX();
            Console.WriteLine($"EAX15ECX_CoreCrystalClockFrequencyInHz: {cpuIdEAX15ECX_CoreCrystalClockFrequencyInHz}");

            string cpuIdEAX15EDX_TSCFrequencyInUnitsOfHz = cpuHelper.GetEAX15EDX_TSCFrequencyInUnitsOfHzX();
            Console.WriteLine($"EAX15EDX_TSCFrequencyInUnitsOfHz: {cpuIdEAX15EDX_TSCFrequencyInUnitsOfHz}");

            #endregion

            #region EAX=0x16: Processor and Bus specification frequencies

            string cpuIdEAX16EAX = cpuHelper.GetEAX16EAXX();
            Console.WriteLine($"EAX16EAX: {cpuIdEAX16EAX}");

            string cpuIdEAX16EBX = cpuHelper.GetEAX16EBXX();
            Console.WriteLine($"EAX16EBX: {cpuIdEAX16EBX}");

            string cpuIdEAX16ECX = cpuHelper.GetEAX16ECXX();
            Console.WriteLine($"EAX16ECX: {cpuIdEAX16ECX}");

            string cpuIdEAX16EDX = cpuHelper.GetEAX16EDXX();
            Console.WriteLine($"EAX16EDX: {cpuIdEAX16EDX}");

            string cpuIdEAX16EAX0_15_ProcessorBaseFrequencyInMHz = cpuHelper.GetEAX16EAX0_15_ProcessorBaseFrequencyInMHzX();
            Console.WriteLine($"EAX16EAX0_15_ProcessorBaseFrequencyInMHz: {cpuIdEAX16EAX0_15_ProcessorBaseFrequencyInMHz}");

            string GetEAX16EBX0_15_ProcessorMaxFrequencyInMHz = cpuHelper.GetEAX16EBX0_15_ProcessorMaxFrequencyInMHzX();
            Console.WriteLine($"GetEAX16EBX0_15_ProcessorMaxFrequencyInMHz: {GetEAX16EBX0_15_ProcessorMaxFrequencyInMHz}");

            string GetEAX16EBX16_31_Reserved = cpuHelper.GetEAX16EBX16_31_ReservedX();
            Console.WriteLine($"GetEAX16EBX16_31_Reserved: {GetEAX16EBX16_31_Reserved}");

            string GetEAX16ECX0_15_BusReferenceFrequencyInMHz = cpuHelper.GetEAX16ECX0_15_BusReferenceFrequencyInMHzX();
            Console.WriteLine($"GetEAX16ECX0_15_BusReferenceFrequencyInMHz: {GetEAX16ECX0_15_BusReferenceFrequencyInMHz}");

            string GetEAX16ECX16_31_Reserved = cpuHelper.GetEAX16ECX16_31_ReservedX();
            Console.WriteLine($"GetEAX16ECX16_31_Reserved: {GetEAX16ECX16_31_Reserved}");

            string GetEAX16EDX0_31_Reserved = cpuHelper.GetEAX16EDX0_31_ReservedX();
            Console.WriteLine($"GetEAX16EDX0_31_Reserved: {GetEAX16EDX0_31_Reserved}");

            #endregion

            #region EAX=0x17: SoC Vendor Attribute Enumeration

            string cpuIdEAX17EAX = cpuHelper.GetEAX17EAXX();
            Console.WriteLine($"EAX17EAX: {cpuIdEAX17EAX}");

            string cpuIdEAX17EBX = cpuHelper.GetEAX17EBXX();
            Console.WriteLine($"EAX17EBX: {cpuIdEAX17EBX}");

            string cpuIdEAX17ECX = cpuHelper.GetEAX17ECXX();
            Console.WriteLine($"EAX17ECX: {cpuIdEAX17ECX}");

            string cpuIdEAX17EDX = cpuHelper.GetEAX17EDXX();
            Console.WriteLine($"EAX17EDX: {cpuIdEAX17EDX}");

            #endregion

            #region EAX=0x18: TLB Hierarchy and Topology

            string cpuIdEAX18EAX = cpuHelper.GetEAX18EAXX();
            Console.WriteLine($"EAX18EAX: {cpuIdEAX18EAX}");

            string cpuIdEAX18EBX = cpuHelper.GetEAX18EBXX();
            Console.WriteLine($"EAX18EBX: {cpuIdEAX18EBX}");

            string cpuIdEAX18ECX = cpuHelper.GetEAX18ECXX();
            Console.WriteLine($"EAX18ECX: {cpuIdEAX18ECX}");

            string cpuIdEAX18EDX = cpuHelper.GetEAX18EDXX();
            Console.WriteLine($"EAX18EDX: {cpuIdEAX18EDX}");

            #endregion

            #region EAX=0x19: Intel Key Locker Features

            string cpuIdEAX19EAX = cpuHelper.GetEAX19EAXX();
            Console.WriteLine($"EAX19EAX: {cpuIdEAX19EAX}");

            string cpuIdEAX19EBX = cpuHelper.GetEAX19EBXX();
            Console.WriteLine($"EAX19EBX: {cpuIdEAX19EBX}");

            string cpuIdEAX19ECX = cpuHelper.GetEAX19ECXX();
            Console.WriteLine($"EAX19ECX: {cpuIdEAX19ECX}");

            string cpuIdEAX19EDX = cpuHelper.GetEAX19EDXX();
            Console.WriteLine($"EAX19EDX: {cpuIdEAX19EDX}");

            #endregion

            #region EAX=0x1D: Intel AMX Tile Information

            string cpuIdEAX1DEAX = cpuHelper.GetEAX1DEAXX();
            Console.WriteLine($"EAX1DEAX: {cpuIdEAX1DEAX}");

            string cpuIdEAX1DEBX = cpuHelper.GetEAX1DEBXX();
            Console.WriteLine($"EAX1DEBX: {cpuIdEAX1DEBX}");

            string cpuIdEAX1DECX = cpuHelper.GetEAX1DECXX();
            Console.WriteLine($"EAX1DECX: {cpuIdEAX1DECX}");

            string cpuIdEAX1DEDX = cpuHelper.GetEAX1DEDXX();
            Console.WriteLine($"EAX1DEDX: {cpuIdEAX1DEDX}");

            #endregion

            #region EAX=0x1E: Intel AMX Tile Multiplier (TMUL) Information

            string cpuIdEAX1EEAX = cpuHelper.GetEAX1EEAXX();
            Console.WriteLine($"EAX1EEAX: {cpuIdEAX1EEAX}");

            string cpuIdEAX1EEBX = cpuHelper.GetEAX1EEBXX();
            Console.WriteLine($"EAX1EEBX: {cpuIdEAX1EEBX}");

            string cpuIdEAX1EECX = cpuHelper.GetEAX1EECXX();
            Console.WriteLine($"EAX1EECX: {cpuIdEAX1EECX}");

            string cpuIdEAX1EEDX = cpuHelper.GetEAX1EEDXX();
            Console.WriteLine($"EAX1EEDX: {cpuIdEAX1EEDX}");

            #endregion

            #region EAX=0x21: Reserved for TDX enumeration

            string cpuIdEAX21EAX = cpuHelper.GetEAX21EAXX();
            Console.WriteLine($"EAX21EAX: {cpuIdEAX21EAX}");

            string cpuIdEAX21EBX = cpuHelper.GetEAX21EBXX();
            Console.WriteLine($"EAX21EBX: {cpuIdEAX21EBX}");

            string cpuIdEAX21ECX = cpuHelper.GetEAX21ECXX();
            Console.WriteLine($"EAX21ECX: {cpuIdEAX21ECX}");

            string cpuIdEAX21EDX = cpuHelper.GetEAX21EDXX();
            Console.WriteLine($"EAX21EDX: {cpuIdEAX21EDX}");

            #endregion

            #region EAX=0x24, ECX=0x0: AVX10 Converged Vector ISA

            string cpuIdEAX24ECX0EAX = cpuHelper.GetEAX24ECX0EAXX();
            Console.WriteLine($"EAX24ECX0EAX: {cpuIdEAX24ECX0EAX}");

            string cpuIdEAX24ECX0EBX = cpuHelper.GetEAX24ECX0EBXX();
            Console.WriteLine($"EAX24ECX0EBX: {cpuIdEAX24ECX0EBX}");

            string cpuIdEAX24ECX0ECX = cpuHelper.GetEAX24ECX0ECXX();
            Console.WriteLine($"EAX24ECX0ECX: {cpuIdEAX24ECX0ECX}");

            string cpuIdEAX24ECX0EDX = cpuHelper.GetEAX24ECX0EDXX();
            Console.WriteLine($"EAX24ECX0EDX: {cpuIdEAX24ECX0EDX}");

            #endregion

            #region EAX=0x24, ECX=0x1: Discrete AVX10 Features

            string cpuIdEAX24ECX1EAX = cpuHelper.GetEAX24ECX1EAXX();
            Console.WriteLine($"EAX24ECX1EAX: {cpuIdEAX24ECX1EAX}");

            string cpuIdEAX24ECX1EBX = cpuHelper.GetEAX24ECX1EBXX();
            Console.WriteLine($"EAX24ECX1EBX: {cpuIdEAX24ECX1EBX}");

            string cpuIdEAX24ECX1ECX = cpuHelper.GetEAX24ECX1ECXX();
            Console.WriteLine($"EAX24ECX1ECX: {cpuIdEAX24ECX1ECX}");

            string cpuIdEAX24ECX1EDX = cpuHelper.GetEAX24ECX1EDXX();
            Console.WriteLine($"EAX24ECX1EDX: {cpuIdEAX24ECX1EDX}");

            #endregion

            #region EAX=0x20000000: Highest Xeon Phi Function Implemented

            string cpuIdEAX20000000EAX = cpuHelper.GetEAX20000000EAXX();
            Console.WriteLine($"EAX20000000EAX: {cpuIdEAX20000000EAX}");

            string cpuIdEAX20000000EBX = cpuHelper.GetEAX20000000EBXX();
            Console.WriteLine($"EAX20000000EBX: {cpuIdEAX20000000EBX}");

            string cpuIdEAX20000000ECX = cpuHelper.GetEAX20000000ECXX();
            Console.WriteLine($"EAX20000000ECX: {cpuIdEAX20000000ECX}");

            string cpuIdEAX20000000EDX = cpuHelper.GetEAX20000000EDXX();
            Console.WriteLine($"EAX20000000EDX: {cpuIdEAX20000000EDX}");

            string cpuIdEAX20000000EAX_HighestXeonPhiFunctionImplemented = cpuHelper.GetEAX20000000EAX_HighestXeonPhiFunctionImplementedX();
            Console.WriteLine($"EAX20000000EAX_HighestXeonPhiFunctionImplemented: {cpuIdEAX20000000EAX_HighestXeonPhiFunctionImplemented}");

            #endregion

            #region EAX=0x20000001: Xeon Phi Feature Bits

            string cpuIdEAX20000001EAX = cpuHelper.GetEAX20000001EAXX();
            Console.WriteLine($"EAX20000001EAX: {cpuIdEAX20000001EAX}");

            string cpuIdEAX20000001EBX = cpuHelper.GetEAX20000001EBXX();
            Console.WriteLine($"EAX20000001EBX: {cpuIdEAX20000001EBX}");

            string cpuIdEAX20000001ECX = cpuHelper.GetEAX20000001ECXX();
            Console.WriteLine($"EAX20000001ECX: {cpuIdEAX20000001ECX}");

            string cpuIdEAX20000001EDX = cpuHelper.GetEAX20000001EDXX();
            Console.WriteLine($"EAX20000001EDX: {cpuIdEAX20000001EDX}");

            #endregion

            #region EAX=0x40000000h-0x4FFFFFFFh: Reserved for Hypervisors

            string cpuIdEAX40000000EAX = cpuHelper.GetEAX40000000EAXX();
            Console.WriteLine($"EAX40000000EAX: {cpuIdEAX40000000EAX}");

            string cpuIdEAX40000000EBX = cpuHelper.GetEAX40000000EBXX();
            Console.WriteLine($"EAX40000000EBX: {cpuIdEAX40000000EBX}");

            string cpuIdEAX40000000ECX = cpuHelper.GetEAX40000000ECXX();
            Console.WriteLine($"EAX40000000ECX: {cpuIdEAX40000000ECX}");

            string cpuIdEAX40000000EDX = cpuHelper.GetEAX40000000EDXX();
            Console.WriteLine($"EAX40000000EDX: {cpuIdEAX40000000EDX}");

            #endregion

            #region EAX=0x80000000: Highest Extended Function Implemented

            string cpuIdEAX80000000EAX = cpuHelper.GetEAX80000000EAXX();
            Console.WriteLine($"EAX80000000EAX: {cpuIdEAX80000000EAX}");

            string cpuIdEAX80000000EBX = cpuHelper.GetEAX80000000EBXX();
            Console.WriteLine($"EAX80000000EBX: {cpuIdEAX80000000EBX}");

            string cpuIdEAX80000000ECX = cpuHelper.GetEAX80000000ECXX();
            Console.WriteLine($"EAX80000000ECX: {cpuIdEAX80000000ECX}");

            string cpuIdEAX80000000EDX = cpuHelper.GetEAX80000000EDXX();
            Console.WriteLine($"EAX80000000EDX: {cpuIdEAX80000000EDX}");

            string cpuIdEAX80000000EAX_HighestExtendedFunctionImplemented = cpuHelper.GetEAX80000000EAX_HighestExtendedFunctionImplementedX();
            Console.WriteLine($"EAX80000000EAX_HighestExtendedFunctionImplemented: {cpuIdEAX80000000EAX_HighestExtendedFunctionImplemented}");

            #endregion

            #region EAX=0x80000001: Extended Processor Info and Feature Bits

            string cpuIdEAX80000001EAX = cpuHelper.GetEAX80000001EAXX();
            Console.WriteLine($"EAX80000001EAX: {cpuIdEAX80000001EAX}");

            string cpuIdEAX80000001EBX = cpuHelper.GetEAX80000001EBXX();
            Console.WriteLine($"EAX80000001EBX: {cpuIdEAX80000001EBX}");

            string cpuIdEAX80000001ECX = cpuHelper.GetEAX80000001ECXX();
            Console.WriteLine($"EAX80000001ECX: {cpuIdEAX80000001ECX}");

            string cpuIdEAX80000001EDX = cpuHelper.GetEAX80000001EDXX();
            Console.WriteLine($"EAX80000001EDX: {cpuIdEAX80000001EDX}");

            #endregion

            #region EAX=0x80000002,0x80000003,0x80000004: Processor Brand String

            string cpuIdEAX80000002EAX = cpuHelper.GetEAX80000002EAXX();
            Console.WriteLine($"EAX80000002EAX: {cpuIdEAX80000002EAX}");

            string cpuIdEAX80000002EBX = cpuHelper.GetEAX80000002EBXX();
            Console.WriteLine($"EAX80000002EBX: {cpuIdEAX80000002EBX}");

            string cpuIdEAX80000002ECX = cpuHelper.GetEAX80000002ECXX();
            Console.WriteLine($"EAX80000002ECX: {cpuIdEAX80000002ECX}");

            string cpuIdEAX80000002EDX = cpuHelper.GetEAX80000002EDXX();
            Console.WriteLine($"EAX80000002EDX: {cpuIdEAX80000002EDX}");

            string cpuIdEAX80000003EAX = cpuHelper.GetEAX80000003EAXX();
            Console.WriteLine($"EAX80000003EAX: {cpuIdEAX80000003EAX}");

            string cpuIdEAX80000003EBX = cpuHelper.GetEAX80000003EBXX();
            Console.WriteLine($"EAX80000003EBX: {cpuIdEAX80000003EBX}");

            string cpuIdEAX80000003ECX = cpuHelper.GetEAX80000003ECXX();
            Console.WriteLine($"EAX80000003ECX: {cpuIdEAX80000003ECX}");

            string cpuIdEAX80000003EDX = cpuHelper.GetEAX80000003EDXX();
            Console.WriteLine($"EAX80000003EDX: {cpuIdEAX80000003EDX}");

            string cpuIdEAX80000004EAX = cpuHelper.GetEAX80000004EAXX();
            Console.WriteLine($"EAX80000004EAX: {cpuIdEAX80000004EAX}");

            string cpuIdEAX80000004EBX = cpuHelper.GetEAX80000004EBXX();
            Console.WriteLine($"EAX80000004EBX: {cpuIdEAX80000004EBX}");

            string cpuIdEAX80000004ECX = cpuHelper.GetEAX80000004ECXX();
            Console.WriteLine($"EAX80000004ECX: {cpuIdEAX80000004ECX}");

            string cpuIdEAX80000004EDX = cpuHelper.GetEAX80000004EDXX();
            Console.WriteLine($"EAX80000004EDX: {cpuIdEAX80000004EDX}");

            string cpuIdEAX80000002_3_4EAXEBXECXEDXProcessorBrandString = cpuHelper.GetEAX80000002_3_4EAXEBXECXEDXProcessorBrandStringX();
            Console.WriteLine($"EAX80000002_3_4EAXEBXECXEDXProcessorBrandString: {cpuIdEAX80000002_3_4EAXEBXECXEDXProcessorBrandString}");

            #endregion

            #region EAX=0x80000005: L1 Cache and TLB Identifiers

            string cpuIdEAX80000005EAX = cpuHelper.GetEAX80000005EAXX();
            Console.WriteLine($"EAX80000005EAX: {cpuIdEAX80000005EAX}");

            string cpuIdEAX80000005EBX = cpuHelper.GetEAX80000005EBXX();
            Console.WriteLine($"EAX80000005EBX: {cpuIdEAX80000005EBX}");

            string cpuIdEAX80000005ECX = cpuHelper.GetEAX80000005ECXX();
            Console.WriteLine($"EAX80000005ECX: {cpuIdEAX80000005ECX}");

            string cpuIdEAX80000005EDX = cpuHelper.GetEAX80000005EDXX();
            Console.WriteLine($"EAX80000005EDX: {cpuIdEAX80000005EDX}");

            string cpuIdEAX80000005EAX0_7_NumberOfInstructionTLBEntriesString = cpuHelper.GetEAX80000005EAX0_7_NumberOfInstructionTLBEntriesX();
            Console.WriteLine($"EAX80000005EAX0_7_NumberOfInstructionTLBEntries: {cpuIdEAX80000005EAX0_7_NumberOfInstructionTLBEntriesString}");

            string cpuIdEAX80000005EAX8_15_InstructionTLBAssociativityString = cpuHelper.GetEAX80000005EAX8_15_InstructionTLBAssociativityX();
            Console.WriteLine($"EAX80000005EAX8_15_InstructionTLBAssociativity: {cpuIdEAX80000005EAX8_15_InstructionTLBAssociativityString}");

            string cpuIdEAX80000005EAX16_23_DataTLBEntriesString = cpuHelper.GetEAX80000005EAX16_23_DataTLBEntriesX();
            Console.WriteLine($"EAX80000005EAX16_23_DataTLBEntries: {cpuIdEAX80000005EAX16_23_DataTLBEntriesString}");

            string cpuIdEAX80000005EAX24_31_DataTLBAssociativityString = cpuHelper.GetEAX80000005EAX24_31_DataTLBAssociativityX();
            Console.WriteLine($"EAX80000005EAX24_31_DataTLBAssociativity: {cpuIdEAX80000005EAX24_31_DataTLBAssociativityString}");

            string cpuIdEAX80000005EBX0_7_NumberOfInstructionTLBEntriesString = cpuHelper.GetEAX80000005EBX0_7_NumberOfInstructionTLBEntriesX();
            Console.WriteLine($"EAX80000005EBX0_7_NumberOfInstructionTLBEntries: {cpuIdEAX80000005EBX0_7_NumberOfInstructionTLBEntriesString}");

            string cpuIdEAX80000005ECX8_15_NumberOfCacheLinesPerTagString = cpuHelper.GetEAX80000005ECX8_15_NumberOfCacheLinesPerTagX();
            Console.WriteLine($"EAX80000005ECX8_15_NumberOfCacheLinesPerTag: {cpuIdEAX80000005ECX8_15_NumberOfCacheLinesPerTagString}");

            string cpuIdEAX80000005ECX16_23_CacheAssociativityString = cpuHelper.GetEAX80000005ECX16_23_CacheAssociativityX();
            Console.WriteLine($"EAX80000005ECX16_23_CacheAssociativity: {cpuIdEAX80000005ECX16_23_CacheAssociativityString}");

            string cpuIdEAX80000005ECX24_31_CacheSizeString = cpuHelper.GetEAX80000005ECX24_31_CacheSizeX();
            Console.WriteLine($"EAX80000005ECX24_31_CacheSize: {cpuIdEAX80000005ECX24_31_CacheSizeString}");

            string cpuIdEAX80000005EDX0_7_CacheLineSizeInBytesString = cpuHelper.GetEAX80000005EDX0_7_CacheLineSizeInBytesX();
            Console.WriteLine($"EAX80000005EDX0_7_CacheLineSizeInBytes: {cpuIdEAX80000005EDX0_7_CacheLineSizeInBytesString}");

            string cpuIdEAX80000005EDX8_15_NumberOfCacheLinesPerTagString = cpuHelper.GetEAX80000005EDX8_15_NumberOfCacheLinesPerTagX();
            Console.WriteLine($"EAX80000005EDX8_15_NumberOfCacheLinesPerTag: {cpuIdEAX80000005EDX8_15_NumberOfCacheLinesPerTagString}");

            string cpuIdEAX80000005EDX16_23_CacheAssociativityString = cpuHelper.GetEAX80000005EDX16_23_CacheAssociativityX();
            Console.WriteLine($"EAX80000005EDX16_23_CacheAssociativity: {cpuIdEAX80000005EDX16_23_CacheAssociativityString}");

            string cpuIdEAX80000005EDX24_31_CacheSizeString = cpuHelper.GetEAX80000005EDX24_31_CacheSizeX();
            Console.WriteLine($"EAX80000005EDX24_31_CacheSize: {cpuIdEAX80000005EDX24_31_CacheSizeString}");

            #endregion

            #region EAX=0x80000006: Extended L2 Cache Features

            string cpuIdEAX80000006EAX = cpuHelper.GetEAX80000006EAXX();
            Console.WriteLine($"EAX80000006EAX: {cpuIdEAX80000006EAX}");

            string cpuIdEAX80000006EBX = cpuHelper.GetEAX80000006EBXX();
            Console.WriteLine($"EAX80000006EBX: {cpuIdEAX80000006EBX}");

            string cpuIdEAX80000006ECX = cpuHelper.GetEAX80000006ECXX();
            Console.WriteLine($"EAX80000006ECX: {cpuIdEAX80000006ECX}");

            string cpuIdEAX80000006EDX = cpuHelper.GetEAX80000006EDXX();
            Console.WriteLine($"EAX80000006EDX: {cpuIdEAX80000006EDX}");

            string cpuIdEAX80000006ECX_LineSizeString = cpuHelper.GetEAX80000006ECX_LineSizeX();
            Console.WriteLine($"EAX80000006ECX_LineSize: {cpuIdEAX80000006ECX_LineSizeString}");

            string cpuIdEAX80000006ECX_AssociativityString = cpuHelper.GetEAX80000006ECX_AssociativityX();
            Console.WriteLine($"EAX80000006ECX_Associativity: {cpuIdEAX80000006ECX_AssociativityString}");

            string cpuIdEAX80000006ECX_CacheSizeString = cpuHelper.GetEAX80000006ECX_CacheSizeX();
            Console.WriteLine($"EAX80000006ECX_CacheSize: {cpuIdEAX80000006ECX_CacheSizeString}");

            #endregion

            #region EAX=0x80000007: Processor Power Management Information and RAS Capabilities

            string cpuIdEAX80000007EAX = cpuHelper.GetEAX80000007EAXX();
            Console.WriteLine($"EAX80000007EAX: {cpuIdEAX80000007EAX}");

            string cpuIdEAX80000007EBX = cpuHelper.GetEAX80000007EBXX();
            Console.WriteLine($"EAX80000007EBX: {cpuIdEAX80000007EBX}");

            string cpuIdEAX80000007ECX = cpuHelper.GetEAX80000007ECXX();
            Console.WriteLine($"EAX80000007ECX: {cpuIdEAX80000007ECX}");

            string cpuIdEAX80000007EDX = cpuHelper.GetEAX80000007EDXX();
            Console.WriteLine($"EAX80000007EDX: {cpuIdEAX80000007EDX}");

            #endregion

            #region EAX=0x80000008: Virtual and Physical Address Sizes

            string cpuIdEAX80000008EAX = cpuHelper.GetEAX80000008EAXX();
            Console.WriteLine($"EAX80000008EAX: {cpuIdEAX80000008EAX}");

            string cpuIdEAX80000008EBX = cpuHelper.GetEAX80000008EBXX();
            Console.WriteLine($"EAX80000008EBX: {cpuIdEAX80000008EBX}");

            string cpuIdEAX80000008ECX = cpuHelper.GetEAX80000008ECXX();
            Console.WriteLine($"EAX80000008ECX: {cpuIdEAX80000008ECX}");

            string cpuIdEAX80000008EDX = cpuHelper.GetEAX80000008EDXX();
            Console.WriteLine($"EAX80000008EDX: {cpuIdEAX80000008EDX}");

            string cpuIdEAX80000008EAX0_7_NumberOfPhysicalAddressBitsString = cpuHelper.GetEAX80000008EAX0_7_NumberOfPhysicalAddressBitsX();
            Console.WriteLine($"EAX80000008EAX0_7_NumberOfPhysicalAddressBits: {cpuIdEAX80000008EAX0_7_NumberOfPhysicalAddressBitsString}");

            string cpuIdEAX80000008EAX8_15_NumberOfLinearAddressBitsString = cpuHelper.GetEAX80000008EAX8_15_NumberOfLinearAddressBitsX();
            Console.WriteLine($"EAX80000008EAX8_15_NumberOfLinearAddressBits: {cpuIdEAX80000008EAX8_15_NumberOfLinearAddressBitsString}");

            string cpuIdEAX80000008EAX16_23_GuestPhysicalAddressSizeString = cpuHelper.GetEAX80000008EAX16_23_GuestPhysicalAddressSizeX();
            Console.WriteLine($"EAX80000008EAX16_23_GuestPhysicalAddressSize: {cpuIdEAX80000008EAX16_23_GuestPhysicalAddressSizeString}");

            string cpuIdEAX80000008EAX24_31_ReservedString = cpuHelper.GetEAX80000008EAX24_31_ReservedX();
            Console.WriteLine($"EAX80000008EAX24_31_Reserved: {cpuIdEAX80000008EAX24_31_ReservedString}");

            bool cpuIdEAX80000008EBX0_CLZERO_IsSupported = cpuHelper.GetEAX80000008EBX0_CLZERO_IsSupportedX();
            Console.WriteLine($"EAX80000008EBX0_CLZERO_IsSupported: {cpuIdEAX80000008EBX0_CLZERO_IsSupported}");

            bool cpuIdEAX80000008EBX1_RetiredInstr_IsSupported = cpuHelper.GetEAX80000008EBX1_RetiredInstr_IsSupportedX();
            Console.WriteLine($"EAX80000008EBX1_RetiredInstr_IsSupported: {cpuIdEAX80000008EBX1_RetiredInstr_IsSupported}");

            bool cpuIdEAX80000008EBX2_XRSTOR_FP_ERR_IsSupported = cpuHelper.GetEAX80000008EBX2_XRSTOR_FP_ERR_IsSupportedX();
            Console.WriteLine($"EAX80000008EBX2_XRSTOR_FP_ERR_IsSupported: {cpuIdEAX80000008EBX2_XRSTOR_FP_ERR_IsSupported}");

            bool cpuIdEAX80000008EBX3_INVLPGB_TLBSYNC_IsSupported = cpuHelper.GetEAX80000008EBX3_INVLPGB_TLBSYNC_IsSupportedX();
            Console.WriteLine($"EAX80000008EBX3_INVLPGB_TLBSYNC_IsSupported: {cpuIdEAX80000008EBX3_INVLPGB_TLBSYNC_IsSupported}");

            bool cpuIdEAX80000008EBX4_RDPRU_IsSupported = cpuHelper.GetEAX80000008EBX4_RDPRU_IsSupportedX();
            Console.WriteLine($"EAX80000008EBX4_RDPRU_IsSupported: {cpuIdEAX80000008EBX4_RDPRU_IsSupported}");

            bool cpuIdEAX80000008EBX5_XOTEXT_IsSupported = cpuHelper.GetEAX80000008EBX5_XOTEXT_IsSupportedX();
            Console.WriteLine($"EAX80000008EBX5_XOTEXT_IsSupported: {cpuIdEAX80000008EBX5_XOTEXT_IsSupported}");

            bool cpuIdEAX80000008EBX6_MBE_IsSupported = cpuHelper.GetEAX80000008EBX6_MBE_IsSupportedX();
            Console.WriteLine($"EAX80000008EBX6_MBE_IsSupported: {cpuIdEAX80000008EBX6_MBE_IsSupported}");

            bool cpuIdEAX80000008EBX7_ReservedIsSupported = cpuHelper.GetEAX80000008EBX7_ReservedIsSupportedX();
            Console.WriteLine($"EAX80000008EBX7_ReservedIsSupported: {cpuIdEAX80000008EBX7_ReservedIsSupported}");

            bool cpuIdEAX80000008EBX8_MCOMMIT_IsSupported = cpuHelper.GetEAX80000008EBX8_MCOMMIT_IsSupportedX();
            Console.WriteLine($"EAX80000008EBX8_MCOMMIT_IsSupported: {cpuIdEAX80000008EBX8_MCOMMIT_IsSupported}");

            bool cpuIdEAX80000008EBX9_WBNOINVD_IsSupported = cpuHelper.GetEAX80000008EBX9_WBNOINVD_IsSupportedX();
            Console.WriteLine($"EAX80000008EBX9_WBNOINVD_IsSupported: {cpuIdEAX80000008EBX9_WBNOINVD_IsSupported}");

            bool cpuIdEAX80000008EBX10_LBR_EXT_V1_IsSupported = cpuHelper.GetEAX80000008EBX10_LBR_EXT_V1_IsSupportedX();
            Console.WriteLine($"EAX80000008EBX10_LBR_EXT_V1_IsSupported: {cpuIdEAX80000008EBX10_LBR_EXT_V1_IsSupported}");

            bool cpuIdEAX80000008EBX11_ReservedIsSupported = cpuHelper.GetEAX80000008EBX11_ReservedIsSupportedX();
            Console.WriteLine($"EAX80000008EBX11_ReservedIsSupported: {cpuIdEAX80000008EBX11_ReservedIsSupported}");

            bool cpuIdEAX80000008EBX12_IBPB_IsSupported = cpuHelper.GetEAX80000008EBX12_IBPB_IsSupportedX();
            Console.WriteLine($"EAX80000008EBX12_IBPB_IsSupported: {cpuIdEAX80000008EBX12_IBPB_IsSupported}");

            bool cpuIdEAX80000008EBX13_WBINVD_INT_IsSupported = cpuHelper.GetEAX80000008EBX13_WBINVD_INT_IsSupportedX();
            Console.WriteLine($"EAX80000008EBX13_WBINVD_INT_IsSupported: {cpuIdEAX80000008EBX13_WBINVD_INT_IsSupported}");

            bool cpuIdEAX80000008EBX14_IBRS_IsSupported = cpuHelper.GetEAX80000008EBX14_IBRS_IsSupportedX();
            Console.WriteLine($"EAX80000008EBX14_IBRS_IsSupported: {cpuIdEAX80000008EBX14_IBRS_IsSupported}");

            bool cpuIdEAX80000008EBX15_STIBP_IsSupported = cpuHelper.GetEAX80000008EBX15_STIBP_IsSupportedX();
            Console.WriteLine($"EAX80000008EBX15_STIBP_IsSupported: {cpuIdEAX80000008EBX15_STIBP_IsSupported}");

            bool cpuIdEAX80000008EBX16_IBRS_ALWAYS_ON_IsSupported = cpuHelper.GetEAX80000008EBX16_IBRS_ALWAYS_ON_IsSupportedX();
            Console.WriteLine($"EAX80000008EBX16_IBRS_ALWAYS_ON_IsSupported: {cpuIdEAX80000008EBX16_IBRS_ALWAYS_ON_IsSupported}");

            bool cpuIdEAX80000008EBX17_STIBP_ALWAYS_ON_IsSupported = cpuHelper.GetEAX80000008EBX17_STIBP_ALWAYS_ON_IsSupportedX();
            Console.WriteLine($"EAX80000008EBX17_STIBP_ALWAYS_ON_IsSupported: {cpuIdEAX80000008EBX17_STIBP_ALWAYS_ON_IsSupported}");

            bool cpuIdEAX80000008EBX18_IBRS_PREFERRED_IsSupported = cpuHelper.GetEAX80000008EBX18_IBRS_PREFERRED_IsSupportedX();
            Console.WriteLine($"EAX80000008EBX18_IBRS_PREFERRED_IsSupported: {cpuIdEAX80000008EBX18_IBRS_PREFERRED_IsSupported}");

            bool cpuIdEAX80000008EBX19_IBRS_SAME_MODE_PROTECTION_IsSupported = cpuHelper.GetEAX80000008EBX19_IBRS_SAME_MODE_PROTECTION_IsSupportedX();
            Console.WriteLine($"EAX80000008EBX19_IBRS_SAME_MODE_PROTECTION_IsSupported: {cpuIdEAX80000008EBX19_IBRS_SAME_MODE_PROTECTION_IsSupported}");

            bool cpuIdEAX80000008EBX20_NO_EFER_LMSLE_IsSupported = cpuHelper.GetEAX80000008EBX20_NO_EFER_LMSLE_IsSupportedX();
            Console.WriteLine($"EAX80000008EBX20_NO_EFER_LMSLE_IsSupported: {cpuIdEAX80000008EBX20_NO_EFER_LMSLE_IsSupported}");

            bool cpuIdEAX80000008EBX21_INVLPGB_NESTED_IsSupported = cpuHelper.GetEAX80000008EBX21_INVLPGB_NESTED_IsSupportedX();
            Console.WriteLine($"EAX80000008EBX21_INVLPGB_NESTED_IsSupported: {cpuIdEAX80000008EBX21_INVLPGB_NESTED_IsSupported}");

            bool cpuIdEAX80000008EBX22_LBR_TSX_IsSupported = cpuHelper.GetEAX80000008EBX22_LBR_TSX_IsSupportedX();
            Console.WriteLine($"EAX80000008EBX22_LBR_TSX_IsSupported: {cpuIdEAX80000008EBX22_LBR_TSX_IsSupported}");

            bool cpuIdEAX80000008EBX23_PPIN_IsSupported = cpuHelper.GetEAX80000008EBX23_PPIN_IsSupportedX();
            Console.WriteLine($"EAX80000008EBX23_PPIN_IsSupported: {cpuIdEAX80000008EBX23_PPIN_IsSupported}");

            bool cpuIdEAX80000008EBX24_SSBD_IsSupported = cpuHelper.GetEAX80000008EBX24_SSBD_IsSupportedX();
            Console.WriteLine($"EAX80000008EBX24_SSBD_IsSupported: {cpuIdEAX80000008EBX24_SSBD_IsSupported}");

            bool cpuIdEAX80000008EBX25_SSBD_LEGACY_IsSupported = cpuHelper.GetEAX80000008EBX25_SSBD_LEGACY_IsSupportedX();
            Console.WriteLine($"EAX80000008EBX25_SSBD_LEGACY_IsSupported: {cpuIdEAX80000008EBX25_SSBD_LEGACY_IsSupported}");

            bool cpuIdEAX80000008EBX26_SSBD_NO_IsSupported = cpuHelper.GetEAX80000008EBX26_SSBD_NO_IsSupportedX();
            Console.WriteLine($"EAX80000008EBX26_SSBD_NO_IsSupported: {cpuIdEAX80000008EBX26_SSBD_NO_IsSupported}");

            bool cpuIdEAX80000008EBX27_CPPC_IsSupported = cpuHelper.GetEAX80000008EBX27_CPPC_IsSupportedX();
            Console.WriteLine($"EAX80000008EBX27_CPPC_IsSupported: {cpuIdEAX80000008EBX27_CPPC_IsSupported}");

            bool cpuIdEAX80000008EBX28_PSFD_IsSupported = cpuHelper.GetEAX80000008EBX28_PSFD_IsSupportedX();
            Console.WriteLine($"EAX80000008EBX28_PSFD_IsSupported: {cpuIdEAX80000008EBX28_PSFD_IsSupported}");

            bool cpuIdEAX80000008EBX29_BTC_NO_IsSupported = cpuHelper.GetEAX80000008EBX29_BTC_NO_IsSupportedX();
            Console.WriteLine($"EAX80000008EBX29_BTC_NO_IsSupported: {cpuIdEAX80000008EBX29_BTC_NO_IsSupported}");

            bool cpuIdEAX80000008EBX30_IBPB_RET_IsSupported = cpuHelper.GetEAX80000008EBX30_IBPB_RET_IsSupportedX();
            Console.WriteLine($"EAX80000008EBX30_IBPB_RET_IsSupported: {cpuIdEAX80000008EBX30_IBPB_RET_IsSupported}");

            bool cpuIdEAX80000008EBX31_BRANCH_SAMPLING_IsSupported = cpuHelper.GetEAX80000008EBX31_BRANCH_SAMPLING_IsSupportedX();
            Console.WriteLine($"EAX80000008EBX31_BRANCH_SAMPLING_IsSupported: {cpuIdEAX80000008EBX31_BRANCH_SAMPLING_IsSupported}");

            string cpuIdEAX80000008ECX0_7_NumberOfPhysicalThreadsInProcessorMinus1String = cpuHelper.GetEAX80000008ECX0_7_NumberOfPhysicalThreadsInProcessorMinus1X();
            Console.WriteLine($"EAX80000008ECX0_7_NumberOfPhysicalThreadsInProcessorMinus1: {cpuIdEAX80000008ECX0_7_NumberOfPhysicalThreadsInProcessorMinus1String}");

            string cpuIdEAX80000008ECX8_11_ReservedString = cpuHelper.GetEAX80000008ECX8_11_ReservedX();
            Console.WriteLine($"EAX80000008ECX8_11_Reserved: {cpuIdEAX80000008ECX8_11_ReservedString}");

            string cpuIdEAX80000008ECX12_15_APIC_IDSizeString = cpuHelper.GetEAX80000008ECX12_15_APIC_IDSizeX();
            Console.WriteLine($"EAX80000008ECX12_15_APIC_IDSize: {cpuIdEAX80000008ECX12_15_APIC_IDSizeString}");

            string cpuIdEAX80000008ECX16_17_PerformanceTimestampCounterSizeString = cpuHelper.GetEAX80000008ECX16_17_PerformanceTimestampCounterSizeX();
            Console.WriteLine($"EAX80000008ECX16_17_PerformanceTimestampCounterSize: {cpuIdEAX80000008ECX16_17_PerformanceTimestampCounterSizeString}");

            string cpuIdEAX80000008ECX18_31_ReserverdString = cpuHelper.GetEAX80000008ECX18_31_ReserverdX();
            Console.WriteLine($"EAX80000008ECX18_31_Reserverd: {cpuIdEAX80000008ECX18_31_ReserverdString}");

            string cpuIdEAX80000008EDX0_15_MaximumPageCountForINVLPGBInstructionString = cpuHelper.GetEAX80000008EDX0_15_MaximumPageCountForINVLPGBInstructionX();
            Console.WriteLine($"EAX80000008EDX0_15_MaximumPageCountForINVLPGBInstruction: {cpuIdEAX80000008EDX0_15_MaximumPageCountForINVLPGBInstructionString}");

            string cpuIdEAX80000008EDX16_31_MaximumECXValueForRDPRUInstructionString = cpuHelper.GetEAX80000008EDX16_31_MaximumECXValueForRDPRUInstructionX();
            Console.WriteLine($"EAX80000008EDX16_31_MaximumECXValueForRDPRUInstruction: {cpuIdEAX80000008EDX16_31_MaximumECXValueForRDPRUInstructionString}");

            #endregion

            #region EAX=0x8000000A: SVM features

            string cpuIdEAX8000000AEAX = cpuHelper.GetEAX8000000AEAXX();
            Console.WriteLine($"EAX8000000AEAX: {cpuIdEAX8000000AEAX}");

            string cpuIdEAX8000000AEBX = cpuHelper.GetEAX8000000AEBXX();
            Console.WriteLine($"EAX8000000AEBX: {cpuIdEAX8000000AEBX}");

            string cpuIdEAX8000000AECX = cpuHelper.GetEAX8000000AECXX();
            Console.WriteLine($"EAX8000000AECX: {cpuIdEAX8000000AECX}");

            string cpuIdEAX8000000AEDX = cpuHelper.GetEAX8000000AEDXX();
            Console.WriteLine($"EAX8000000AEDX: {cpuIdEAX8000000AEDX}");

            #endregion

            #region EAX=0x8000001F: Encrypted Memory Capabilities

            string cpuIdEAX8000001FEAX = cpuHelper.GetEAX8000001FEAXX();
            Console.WriteLine($"EAX8000001FEAX: {cpuIdEAX8000001FEAX}");

            string cpuIdEAX8000001FEBX = cpuHelper.GetEAX8000001FEBXX();
            Console.WriteLine($"EAX8000001FEBX: {cpuIdEAX8000001FEBX}");

            string cpuIdEAX8000001FECX = cpuHelper.GetEAX8000001FECXX();
            Console.WriteLine($"EAX8000001FECX: {cpuIdEAX8000001FECX}");

            string cpuIdEAX8000001FEDX = cpuHelper.GetEAX8000001FEDXX();
            Console.WriteLine($"EAX8000001FEDX: {cpuIdEAX8000001FEDX}");

            #endregion

            #region EAX=0x80000021: Extended Feature Identification

            string cpuIdEAX80000021EAX = cpuHelper.GetEAX80000021EAXX();
            Console.WriteLine($"EAX80000021EAX: {cpuIdEAX80000021EAX}");

            string cpuIdEAX80000021EBX = cpuHelper.GetEAX80000021EBXX();
            Console.WriteLine($"EAX80000021EBX: {cpuIdEAX80000021EBX}");

            string cpuIdEAX80000021ECX = cpuHelper.GetEAX80000021ECXX();
            Console.WriteLine($"EAX80000021ECX: {cpuIdEAX80000021ECX}");

            string cpuIdEAX80000021EDX = cpuHelper.GetEAX80000021EDXX();
            Console.WriteLine($"EAX80000021EDX: {cpuIdEAX80000021EDX}");

            #endregion

            #region EAX=0x80000025: Encrypted Memory Capabilities 2

            string cpuIdEAX80000025EAX = cpuHelper.GetEAX80000025EAXX();
            Console.WriteLine($"EAX80000025EAX: {cpuIdEAX80000025EAX}");

            string cpuIdEAX80000025EBX = cpuHelper.GetEAX80000025EBXX();
            Console.WriteLine($"EAX80000025EBX: {cpuIdEAX80000025EBX}");

            string cpuIdEAX80000025ECX = cpuHelper.GetEAX80000025ECXX();
            Console.WriteLine($"EAX80000025ECX: {cpuIdEAX80000025ECX}");

            string cpuIdEAX80000025EDX = cpuHelper.GetEAX80000025EDXX();
            Console.WriteLine($"EAX80000025EDX: {cpuIdEAX80000025EDX}");

            #endregion

            #region EAX=0x8C860000: Hygon Extended Feature Flags

            string cpuIdEAX8C860000EAX = cpuHelper.GetEAX8C860000EAXX();
            Console.WriteLine($"EAX8C860000EAX: {cpuIdEAX8C860000EAX}");

            string cpuIdEAX8C860000EBX = cpuHelper.GetEAX8C860000EBXX();
            Console.WriteLine($"EAX8C860000EBX: {cpuIdEAX8C860000EBX}");

            string cpuIdEAX8C860000ECX = cpuHelper.GetEAX8C860000ECXX();
            Console.WriteLine($"EAX8C860000ECX: {cpuIdEAX8C860000ECX}");

            string cpuIdEAX8C860000EDX = cpuHelper.GetEAX8C860000EDXX();
            Console.WriteLine($"EAX8C860000EDX: {cpuIdEAX8C860000EDX}");

            #endregion

            #region EAX=0x8FFFFFFE: AMD Easter Eggs

            string cpuIdEAX8FFFFFFEEAX = cpuHelper.GetEAX8FFFFFFEEAXX();
            Console.WriteLine($"EAX8FFFFFFEEAX: {cpuIdEAX8FFFFFFEEAX}");

            string cpuIdEAX8FFFFFFEEBX = cpuHelper.GetEAX8FFFFFFEEBXX();
            Console.WriteLine($"EAX8FFFFFFEEBX: {cpuIdEAX8FFFFFFEEBX}");

            string cpuIdEAX8FFFFFFEECX = cpuHelper.GetEAX8FFFFFFEECXX();
            Console.WriteLine($"EAX8FFFFFFEECX: {cpuIdEAX8FFFFFFEECX}");

            string cpuIdEAX8FFFFFFEEDX = cpuHelper.GetEAX8FFFFFFEEDXX();
            Console.WriteLine($"EAX8FFFFFFEEDX: {cpuIdEAX8FFFFFFEEDX}");

            #endregion

            #region EAX=0x8FFFFFFF: AMD Easter Eggs

            string cpuIdEAX8FFFFFFFEAX = cpuHelper.GetEAX8FFFFFFFEAXX();
            Console.WriteLine($"EAX8FFFFFFFEAX: {cpuIdEAX8FFFFFFFEAX}");

            string cpuIdEAX8FFFFFFFEBX = cpuHelper.GetEAX8FFFFFFFEBXX();
            Console.WriteLine($"EAX8FFFFFFFEBX: {cpuIdEAX8FFFFFFFEBX}");

            string cpuIdEAX8FFFFFFFECX = cpuHelper.GetEAX8FFFFFFFECXX();
            Console.WriteLine($"EAX8FFFFFFFECX: {cpuIdEAX8FFFFFFFECX}");

            string cpuIdEAX8FFFFFFFEDX = cpuHelper.GetEAX8FFFFFFFEDXX();
            Console.WriteLine($"EAX8FFFFFFFEDX: {cpuIdEAX8FFFFFFFEDX}");

            #endregion

            #region EAX=0xC0000000: Highest Centaur Extended Function

            string cpuIdEAXC0000000EAX = cpuHelper.GetEAXC0000000EAXX();
            Console.WriteLine($"EAXC0000000EAX: {cpuIdEAXC0000000EAX}");

            string cpuIdEAXC0000000EBX = cpuHelper.GetEAXC0000000EBXX();
            Console.WriteLine($"EAXC0000000EBX: {cpuIdEAXC0000000EBX}");

            string cpuIdEAXC0000000ECX = cpuHelper.GetEAXC0000000ECXX();
            Console.WriteLine($"EAXC0000000ECX: {cpuIdEAXC0000000ECX}");

            string cpuIdEAXC0000000EDX = cpuHelper.GetEAXC0000000EDXX();
            Console.WriteLine($"EAXC0000000EDX: {cpuIdEAXC0000000EDX}");

            #endregion

            #region EAX=0xC0000001: Centaur Feature Information

            string cpuIdEAXC0000001EAX = cpuHelper.GetEAXC0000001EAXX();
            Console.WriteLine($"EAXC0000001EAX: {cpuIdEAXC0000001EAX}");

            string cpuIdEAXC0000001EBX = cpuHelper.GetEAXC0000001EBXX();
            Console.WriteLine($"EAXC0000001EBX: {cpuIdEAXC0000001EBX}");

            string cpuIdEAXC0000001ECX = cpuHelper.GetEAXC0000001ECXX();
            Console.WriteLine($"EAXC0000001ECX: {cpuIdEAXC0000001ECX}");

            string cpuIdEAXC0000001EDX = cpuHelper.GetEAXC0000001EDXX();
            Console.WriteLine($"EAXC0000001EDX: {cpuIdEAXC0000001EDX}");

            #endregion

            #region EAX=0xC0000002: Centaur Extended CPUID Performance Data

            string cpuIdEAXC0000002EAX = cpuHelper.GetEAXC0000002EAXX();
            Console.WriteLine($"EAXC0000002EAX: {cpuIdEAXC0000002EAX}");

            string cpuIdEAXC0000002EBX = cpuHelper.GetEAXC0000002EBXX();
            Console.WriteLine($"EAXC0000002EBX: {cpuIdEAXC0000002EBX}");

            string cpuIdEAXC0000002ECX = cpuHelper.GetEAXC0000002ECXX();
            Console.WriteLine($"EAXC0000002ECX: {cpuIdEAXC0000002ECX}");

            string cpuIdEAXC0000002EDX = cpuHelper.GetEAXC0000002EDXX();
            Console.WriteLine($"EAXC0000002EDX: {cpuIdEAXC0000002EDX}");

            #endregion

            #region EAX=0xC0000006, ECX=0: Zhaoxin Feature Information

            string cpuIdEAXC0000006ECX0EAX = cpuHelper.GetEAXC0000006ECX0EAXX();
            Console.WriteLine($"EAXC0000006ECX0EAX: {cpuIdEAXC0000006ECX0EAX}");

            string cpuIdEAXC0000006ECX0EBX = cpuHelper.GetEAXC0000006ECX0EBXX();
            Console.WriteLine($"EAXC0000006ECX0EBX: {cpuIdEAXC0000006ECX0EBX}");

            string cpuIdEAXC0000006ECX0ECX = cpuHelper.GetEAXC0000006ECX0ECXX();
            Console.WriteLine($"EAXC0000006ECX0ECX: {cpuIdEAXC0000006ECX0ECX}");

            string cpuIdEAXC0000006ECX0EDX = cpuHelper.GetEAXC0000006ECX0EDXX();
            Console.WriteLine($"EAXC0000006ECX0EDX: {cpuIdEAXC0000006ECX0EDX}");

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
            EAX0 eax0Form = new EAX0();
            eax0Form.Show();
        }

        private void eAX0x1ProcessorInfoAndFeatureBitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EAX1 eax1Form = new EAX1();
            eax1Form.Show();
        }
    }
}
