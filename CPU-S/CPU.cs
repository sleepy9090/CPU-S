using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_S
{
    internal class CPU
    {
        

        public CPU() 
        { 
        
        }

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

        public static uint Availability { get; internal set; }

        public static uint ExtClock { get; internal set; }

        public static string Caption { get; internal set; }

        public static uint Characteristics { get; internal set; }

        public static uint ConfigManagerErrorCode { get; internal set; }

        public static bool ConfigManagerUserConfig { get; internal set; }

        public static uint CpuStatus { get; internal set; }

        public static string CreationClassName { get; internal set; }

        public static uint CurrentClockSpeed { get; internal set; }

        public static uint NumberOfCores { get; internal set; }

        public static ushort DataWidth { get; internal set; }

        public static string Description { get; internal set; }

        public static string ProcessorId { get; internal set; }

        public static ulong L2CacheSize { get; internal set; }

        public static ulong L3CacheSize { get; internal set; }

        public static string Name { get; internal set; }

        public static string SocketDesignation { get; internal set; }

        public static uint MaxClockSpeed { get; internal set; }

        public static uint NumberOfLogicalProcessors { get; internal set; }


    }
}
