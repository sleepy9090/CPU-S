using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_S
{
    internal static class CPU
    {
        /*
          uint16   AddressWidth;
          uint16   Architecture;
          string   AssetTag;
          uint16   Availability;
          string   Caption;
          uint32   Characteristics;
          uint32   ConfigManagerErrorCode;
          boolean  ConfigManagerUserConfig;
          uint16   CpuStatus;
          string   CreationClassName;
          uint32   CurrentClockSpeed;
          uint16   CurrentVoltage;
          uint16   DataWidth;
          string   Description;
          string   DeviceID;
          boolean  ErrorCleared;
          string   ErrorDescription;
          uint32   ExtClock;
          uint16   Family;
          datetime InstallDate;
          uint32   L2CacheSize;
          uint32   L2CacheSpeed;
          uint32   L3CacheSize;
          uint32   L3CacheSpeed;
          uint32   LastErrorCode;
          uint16   Level;
          uint16   LoadPercentage;
          string   Manufacturer;
          uint32   MaxClockSpeed;
          string   Name;
          uint32   NumberOfCores;
          uint32   NumberOfEnabledCore;
          uint32   NumberOfLogicalProcessors;
          string   OtherFamilyDescription;
          string   PartNumber;
          string   PNPDeviceID;
          uint16   PowerManagementCapabilities[];
          boolean  PowerManagementSupported;
          string   ProcessorId;
          uint16   ProcessorType;
          uint16   Revision;
          string   Role;
          boolean  SecondLevelAddressTranslationExtensions;
          string   SerialNumber;
          string   SocketDesignation;
          string   Status;
          uint16   StatusInfo;
          string   Stepping;
          string   SystemCreationClassName;
          string   SystemName;
          uint32   ThreadCount;
          string   UniqueId;
          uint16   UpgradeMethod;
          string   Version;
          boolean  VirtualizationFirmwareEnabled;
          boolean  VMMonitorModeExtensions;
          uint32   VoltageCaps;
        */

        public static ushort AddressWidth { get; internal set; }

        public static ushort Architecture { get; internal set; }

        public static string AssetTag { get; internal set; }

        public static ushort Availability { get; internal set; }

        public static string Caption { get; internal set; }

        public static uint Characteristics { get; internal set; }

        public static uint ConfigManagerErrorCode { get; internal set; }

        public static bool ConfigManagerUserConfig { get; internal set; }

        public static ushort CpuStatus { get; internal set; }

        public static string CreationClassName { get; internal set; }

        public static uint CurrentClockSpeed { get; internal set; }

        public static ushort CurrentVoltage { get; internal set; }

        public static ushort DataWidth { get; internal set; }

        public static string Description { get; internal set; }

        public static string DeviceID { get; internal set; }

        public static bool ErrorCleared { get; internal set; }

        public static string ErrorDescription { get; internal set; }

        public static uint ExtClock { get; internal set; }

        public static uint Family {  get; internal set; }

        public static DateTime InstallDate { get; internal set; }

        public static uint L2CacheSize { get; internal set; }

        public static uint L2CacheSpeed { get; internal set; }

        public static uint L3CacheSize { get; internal set; }

        public static uint L3CacheSpeed { get; internal set; }

        public static uint LastErrorCode { get; internal set; }

        public static ushort Level {  get; internal set; }

        public static ushort LoadPercentage { get; internal set; }

        public static string Manufacturer { get; internal set; }

        public static uint MaxClockSpeed { get; internal set; }

        public static string Name { get; internal set; }

        public static uint NumberOfCores { get; internal set; }

        public static uint NumberOfEnabledCore { get; internal set; }

        public static uint NumberOfLogicalProcessors { get; internal set; }

        public static string OtherFamilyDescription { get; internal set; }

        public static string PartNumber { get; internal set; }

        public static string PNPDeviceID { get; internal set; }

        public static ushort[] PowerManagementCapabilities { get; internal set; }

        public static bool PowerManagementSupported { get; internal set; }

        public static string ProcessorId { get; internal set; }

        public static ushort ProcessorType { get; internal set; }

        public static ushort Revision { get; internal set; }

        public static string Role { get; internal set; }

        public static bool SecondLevelAddressTranslationExtensions { get; internal set; }

        public static string SerialNumber { get; internal set; }

        public static string SocketDesignation { get; internal set; }

        public static string Status { get; internal set; }

        public static ushort StatusInfo { get; internal set; }

        public static string Stepping {  get; internal set; }

        public static string SystemCreationClassName { get; internal set; }

        public static string SystemName { get; internal set; }

        public static uint ThreadCount { get; internal set; }

        public static string UniqueId { get; internal set; }

        public static ushort UpgradeMethod { get; internal set; }

        public static string Version { get; internal set; }

        public static bool VirtualizationFirmwareEnabled { get; internal set; }

        public static bool VMMonitorModeExtensions { get; internal set; }

        public static uint VoltageCaps { get; internal set; }

        public static bool SSEx64Supported { get; internal set; }
    }
}
