/*
    File           CPUHelper.cs
    Brief          CPU Helper class.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           05/29/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CPU_S
{
    internal class CPUHelper
    {
        public CPUHelper()
        {

        }

        public string GetArchitecture(ushort value)
        {
            string architecture;

            switch (value)
            {
                case 0:
                    architecture = "x86";
                    break;
                case 1:
                    architecture = "MIPS";
                    break;
                case 2:
                    architecture = "Alpha";
                    break;
                case 3:
                    architecture = "PowerPC";
                    break;
                case 5:
                    architecture = "ARM";
                    break;
                case 6:
                    architecture = "ia64";
                    break;
                case 9:
                    architecture = "x64";
                    break;
                case 12:
                    architecture = "ARM64";
                    break;
                default:
                    architecture = CPUConstants.NOT_FOUND_OR_UNKNOWN;
                    break;
            }

            return architecture;
        }

        public string GetAvailability(ushort value)
        {
            string availability;

            switch (value)
            {
                case 1:
                    availability = "Other.";
                    break;
                case 2:
                    availability = "Unknown.";
                    break;
                case 3:
                    availability = "Running / Full Power.";
                    break;
                case 4:
                    availability = "Warning.";
                    break;
                case 5:
                    availability = "In Test.";
                    break;
                case 6:
                    availability = "Not Applicable.";
                    break;
                case 7:
                    availability = "Power Off.";
                    break;
                case 8:
                    availability = "Off Line.";
                    break;
                case 9:
                    availability = "Off Duty.";
                    break;
                case 10:
                    availability = "Degraded.";
                    break;
                case 11:
                    availability = "Not Installed.";
                    break;
                case 12:
                    availability = "Install Error.";
                    break;
                case 13:
                    availability = "Power Save - Unknown. The device is known to be in a power save state, but its exact status is unknown.";
                    break;
                case 14:
                    availability = "Power Save - Low Power Mode. The device is in a power save state, but is still functioning, and may exhibit decreased performance.";
                    break;
                case 15:
                    availability = "Power Save - Standby. The device is not functioning, but can be brought to full power quickly.";
                    break;
                case 16:
                    availability = "Power Cycle.";
                    break;
                case 17:
                    availability = "Power Save - Warning. The device is in a warning state, though also in a power save state.";
                    break;
                case 18:
                    availability = "Paused. The device is paused.";
                    break;
                case 19:
                    availability = "Not Ready. The device is not ready.";
                    break;
                case 20:
                    availability = "Not Configured. The device is not configured.";
                    break;
                case 21:
                    availability = "Quiesced. The device is quiet.";
                    break;
                default:
                    availability = CPUConstants.NOT_FOUND_OR_UNKNOWN;
                    break;
            }

            return availability;
        }

        public string GetCharacteristics(uint value)
        {
            uint bitmask = value;
            string characteristics = "";
            /* As of DSP0134 	3.9.0 	SMBIOS Specification 	19 Aug 2025
             * Bitmask:
             * 0 (0x0000): Reserved
             * 1 (0x0001): Unknown
             * 2 (0x0002): 64-bit Capable
             * 3 (0x0004): Multi-Core
             * 4 (0x0008): Hardware Thread - (Hyper-threading)
             * 5 (0x0010): Execute Protection - (NX bit)
             * 6 (0x0020): Enhanced Virtualization - (VT-x/AMD-V)
             * 7 (0x0040): Power/Performance Control
             * 8 (0x0080): 128-bit Capable
             * 9 (0x0100): Arm64 SoC ID
             * 10 (0x0200): Reserved
             * 11 (0x0400): Reserved
             * 12 (0x0800): Reserved
             * 13 (0x1000): Reserved
             * 14 (0x2000): Reserved
             * 15 (0x4000): Reserved
             */
            if (IsBitSet(bitmask, 0))
            {
                characteristics += "Reserved" + Environment.NewLine;
            }
            if (IsBitSet(bitmask, 1))
            {
                characteristics += "Unknown" + Environment.NewLine;
            }
            if (IsBitSet(bitmask, 2))
            {
                characteristics += "64-bit Capable" + Environment.NewLine;
            }
            if (IsBitSet(bitmask, 3))
            {
                characteristics += "Multi-Core" + Environment.NewLine;
            }
            if (IsBitSet(bitmask, 4))
            {
                characteristics += "Hardware Thread - (Hyper-threading)" + Environment.NewLine;
            }
            if (IsBitSet(bitmask, 5))
            {
                characteristics += "Execute Protection - (NX bit)" + Environment.NewLine;
            }
            if (IsBitSet(bitmask, 6))
            {
                characteristics += "Enhanced Virtualization - (VT-x/AMD-V)" + Environment.NewLine;
            }
            if (IsBitSet(bitmask, 7))
            {
                characteristics += "Power/Performance Control" + Environment.NewLine;
            }
            if (IsBitSet(bitmask, 8))
            {
                characteristics += "128-bit Capable" + Environment.NewLine;
            }
            if (IsBitSet(bitmask, 9))
            {
                characteristics += "Arm64 SoC ID" + Environment.NewLine;
            }
            if (IsBitSet(bitmask, 10))
            {
                characteristics += "Reserved" + Environment.NewLine;
            }
            if (IsBitSet(bitmask, 11))
            {
                characteristics += "Reserved" + Environment.NewLine;
            }
            if (IsBitSet(bitmask, 12))
            {
                characteristics += "Reserved" + Environment.NewLine;
            }
            if (IsBitSet(bitmask, 13))
            {
                characteristics += "Reserved" + Environment.NewLine;
            }
            if (IsBitSet(bitmask, 14))
            {
                characteristics += "Reserved" + Environment.NewLine;
            }
            if (IsBitSet(bitmask, 15))
            {
                characteristics += "Reserved" + Environment.NewLine;
            }

            return characteristics;
        }

        private bool IsBitSet(uint value, int bitPosition)
        {
            // Create a bitmask with only the bit at the specified position set.
            int mask = 1 << bitPosition;

            // Perform bitwise AND operation, if the result is not zero, the bit is set.
            return (value & mask) != 0;
        }

        public string GetConfigManagerErrorCode(uint value)
        {
            string configManagerErrorMessage;

            switch (value)
            {
                case 0:
                    configManagerErrorMessage = "This device is working properly.";
                    break;
                case 1:
                    configManagerErrorMessage = "This device is not configured correctly.";
                    break;
                case 2:
                    configManagerErrorMessage = "Windows cannot load the driver for this device.";
                    break;
                case 3:
                    configManagerErrorMessage = "The driver for this device might be corrupted, or your system may be running low on memory or other resources.";
                    break;
                case 4:
                    configManagerErrorMessage = "This device is not working properly. One of its drivers or your registry might be corrupted.";
                    break;
                case 5:
                    configManagerErrorMessage = "The driver for this device needs a resource that Windows cannot manage.";
                    break;
                case 6:
                    configManagerErrorMessage = "The boot configuration for this device conflicts with other devices.";
                    break;
                case 7:
                    configManagerErrorMessage = "Cannot filter.";
                    break;
                case 8:
                    configManagerErrorMessage = "The driver loader for the device is missing.";
                    break;
                case 9:
                    configManagerErrorMessage = "This device is not working properly because the controlling firmware is reporting the resources for the device incorrectly.";
                    break;
                case 10:
                    configManagerErrorMessage = "This device cannot start.";
                    break;
                case 11:
                    configManagerErrorMessage = "This device failed.";
                    break;
                case 12:
                    configManagerErrorMessage = "This device cannot find enough free resources that it can use.";
                    break;
                case 13:
                    configManagerErrorMessage = "Windows cannot verify this device's resources.";
                    break;
                case 14:
                    configManagerErrorMessage = "This device cannot work properly until you restart your computer.";
                    break;
                case 15:
                    configManagerErrorMessage = "This device is not working properly because there is probably a re-enumeration problem.";
                    break;
                case 16:
                    configManagerErrorMessage = "Windows cannot identify all the resources this device uses.";
                    break;
                case 17:
                    configManagerErrorMessage = "This device is asking for an unknown resource type.";
                    break;
                case 18:
                    configManagerErrorMessage = "Reinstall the drivers for this device.";
                    break;
                case 19:
                    configManagerErrorMessage = "Failure using the VxD loader.";
                    break;
                case 20:
                    configManagerErrorMessage = "Your registry might be corrupted.";
                    break;
                case 21:
                    configManagerErrorMessage = "System failure: Try changing the driver for this device. If that does not work, see your hardware documentation. Windows is removing this device.";
                    break;
                case 22:
                    configManagerErrorMessage = "This device is disabled.";
                    break;
                case 23:
                    configManagerErrorMessage = "System failure: Try changing the driver for this device. If that doesn't work, see your hardware documentation.";
                    break;
                case 24:
                    configManagerErrorMessage = "This device is not present, is not working properly, or does not have all its drivers installed.";
                    break;
                case 25:
                    configManagerErrorMessage = "Windows is still setting up this device.";
                    break;
                case 26:
                    configManagerErrorMessage = "Windows is still setting up this device.";
                    break;
                case 27:
                    configManagerErrorMessage = "This device does not have valid log configuration.";
                    break;
                case 28:
                    configManagerErrorMessage = "The drivers for this device are not installed.";
                    break;
                case 29:
                    configManagerErrorMessage = "This device is disabled because the firmware of the device did not give it the required resources.";
                    break;
                case 30:
                    configManagerErrorMessage = "This device is using an Interrupt Request (IRQ) resource that another device is using.";
                    break;
                case 31:
                    configManagerErrorMessage = "This device is not working properly because Windows cannot load the drivers required for this device.";
                    break;
                default:
                    configManagerErrorMessage = CPUConstants.NOT_FOUND_OR_UNKNOWN;
                    break;
            }
            return configManagerErrorMessage;
        }

        public string GetStatus(ushort value)
        {
            string status;

            switch (value)
            {
                case 0:
                    status = "Unknown.";
                    break;
                case 1:
                    status = "CPU Enabled.";
                    break;
                case 2:
                    status = "CPU Disabled by User via BIOS Setup.";
                    break;
                case 3:
                    status = "CPU Disabled By BIOS (POST Error).";
                    break;
                case 4:
                    status = "CPU is Idle.";
                    break;
                case 5:
                    status = "Reserved.";
                    break;
                case 6:
                    status = "Reserved.";
                    break;
                case 7:
                    status = "Other .";
                    break;
                default:
                    status = CPUConstants.NOT_FOUND_OR_UNKNOWN;
                    break;
            }

            return status;
        }

        public uint GetCacheSizeFull(uint value)
        {
            return value * 1024;
        }

        public double GetCurrentVoltage(ushort value)
        {
            double currentVoltage = value / 10.0;


            return currentVoltage;
        }

        public string GetFamily(uint value)
        {
            string family;
            switch (value)
            {
                case 1:
                    family = "Other";
                    break;
                case 2:
                    family = "Unknown";
                    break;
                case 3:
                    family = "8086";
                    break;
                case 4:
                    family = "80286";
                    break;
                case 5:
                    family = "Intel386™ processor";
                    break;
                case 6:
                    family = "Intel486™ processor";
                    break;
                case 7:
                    family = "8087";
                    break;
                case 8:
                    family = "80287";
                    break;
                case 9:
                    family = "80387";
                    break;
                case 10:
                    family = "80487";
                    break;
                case 11:
                    family = "Intel® Pentium® processor";
                    break;
                case 12:
                    family = "Pentium® Pro processor";
                    break;
                case 13:
                    family = "Pentium® II processor";
                    break;
                case 14:
                    family = "Pentium® processor with MMX™ technology";
                    break;
                case 15:
                    family = "Intel® Celeron® processor";
                    break;
                case 16:
                    family = "Pentium® II Xeon® processor";
                    break;
                case 17:
                    family = "Pentium® III processor";
                    break;
                case 18:
                    family = "M1 Family";
                    break;
                case 19:
                    family = "M2 Family";
                    break;
                case 20:
                    family = "Intel® Celeron® M processor";
                    break;
                case 21:
                    family = "Intel® Pentium® 4 HT processor";
                    break;
                case 22:
                    family = "Intel® Processor";
                    break;
                case 24:
                    family = "AMD Duron™ Processor Family";
                    break;
                case 25:
                    family = "K5 Family";
                    break;
                case 26:
                    family = "K6 Family";
                    break;
                case 27:
                    family = "K6-2";
                    break;
                case 28:
                    family = "K6-3";
                    break;
                case 29:
                    family = "AMD Athlon™ Processor Family";
                    break;
                case 30:
                    family = "AMD29000 Family";
                    break;
                case 31:
                    family = "K6-2+";
                    break;
                case 32:
                    family = "Power PC Family";
                    break;
                case 33:
                    family = "Power PC 601";
                    break;
                case 34:
                    family = "Power PC 603";
                    break;
                case 35:
                    family = "Power PC 603+";
                    break;
                case 36:
                    family = "Power PC 604";
                    break;
                case 37:
                    family = "Power PC 620";
                    break;
                case 38:
                    family = "Power PC x704";
                    break;
                case 39:
                    family = "Power PC 750";
                    break;
                case 40:
                    family = "Intel® Core™ Duo processor";
                    break;
                case 41:
                    family = "Intel® Core™ Duo mobile processor";
                    break;
                case 42:
                    family = "Intel® Core™ Solo mobile processor";
                    break;
                case 43:
                    family = "Intel® Atom™ processor";
                    break;
                case 44:
                    family = "Intel® Core™ M processor";
                    break;
                case 45:
                    family = "Intel® Core™ m3 processor";
                    break;
                case 46:
                    family = "Intel® Core™ m5 processor";
                    break;
                case 47:
                    family = "Intel® Core™ m7 processor";
                    break;
                case 48:
                    family = "Alpha Family (version 3.9.0 specifications) or Pentium® Pro processor (version 2.0 specifications)";
                    break;
                case 49:
                    family = "Alpha 21064";
                    break;
                case 50:
                    family = "Alpha 21066";
                    break;
                case 51:
                    family = "Alpha 21164";
                    break;
                case 52:
                    family = "Alpha 21164PC";
                    break;
                case 53:
                    family = "Alpha 21164a";
                    break;
                case 54:
                    family = "Alpha 21264";
                    break;
                case 55:
                    family = "Alpha 21364";
                    break;
                case 56:
                    family = "AMD Turion™ II Ultra Dual-Core Mobile M Processor Family";
                    break;
                case 57:
                    family = "AMD Turion™ II Dual-Core Mobile M Processor Family";
                    break;
                case 58:
                    family = "AMD Athlon™ II Dual-Core M Processor Family";
                    break;
                case 59:
                    family = "AMD Opteron™ 6100 Series Processor";
                    break;
                case 60:
                    family = "AMD Opteron™ 4100 Series Processor";
                    break;
                case 61:
                    family = "AMD Opteron™ 6200 Series Processor";
                    break;
                case 62:
                    family = "AMD Opteron™ 4200 Series Processor";
                    break;
                case 63:
                    family = "AMD FX™ Series Processor";
                    break;
                case 64:
                    family = "MIPS Family";
                    break;
                case 65:
                    family = "MIPS R4000";
                    break;
                case 66:
                    family = "MIPS R4200";
                    break;
                case 67:
                    family = "MIPS R4400";
                    break;
                case 68:
                    family = "MIPS R4600";
                    break;
                case 69:
                    family = "MIPS R10000";
                    break;
                case 70:
                    family = "AMD C-Series Processor";
                    break;
                case 71:
                    family = "AMD E-Series Processor";
                    break;
                case 72:
                    family = "AMD A-Series Processor";
                    break;
                case 73:
                    family = "AMD G-Series Processor";
                    break;
                case 74:
                    family = "AMD Z-Series Processor";
                    break;
                case 75:
                    family = "AMD R-Series Processor";
                    break;
                case 76:
                    family = "AMD Opteron™ 4300 Series Processor";
                    break;
                case 77:
                    family = "AMD Opteron™ 6300 Series Processor";
                    break;
                case 78:
                    family = "AMD Opteron™ 3300 Series Processor";
                    break;
                case 79:
                    family = "AMD FirePro™ Series Processor";
                    break;
                case 80:
                    family = "SPARC Family";
                    break;
                case 81:
                    family = "SuperSPARC";
                    break;
                case 82:
                    family = "microSPARC II";
                    break;
                case 83:
                    family = "microSPARC IIep";
                    break;
                case 84:
                    family = "UltraSPARC";
                    break;
                case 85:
                    family = "UltraSPARC II";
                    break;
                case 86:
                    family = "UltraSPARC Iii";
                    break;
                case 87:
                    family = "UltraSPARC III";
                    break;
                case 88:
                    family = "UltraSPARC IIIi";
                    break;
                case 96:
                    family = "68040 Family";
                    break;
                case 97:
                    family = "68xxx";
                    break;
                case 98:
                    family = "68000";
                    break;
                case 99:
                    family = "68010";
                    break;
                case 100:
                    family = "68020";
                    break;
                case 101:
                    family = "68030";
                    break;
                case 102:
                    family = "AMD Athlon(TM) X4 Quad-Core Processor Family";
                    break;
                case 103:
                    family = "AMD Opteron(TM) X1000 Series Processor";
                    break;
                case 104:
                    family = "AMD Opteron(TM) X2000 Series APU";
                    break;
                case 105:
                    family = "AMD Opteron(TM) A-Series Processor";
                    break;
                case 106:
                    family = "AMD Opteron(TM) X3000 Series APU";
                    break;
                case 107:
                    family = "AMD Zen Processor Family";
                    break;
                case 112:
                    family = "Hobbit Family";
                    break;
                case 120:
                    family = "Crusoe™ TM5000 Family";
                    break;
                case 121:
                    family = "Crusoe™ TM3000 Family";
                    break;
                case 122:
                    family = "Efficeon™ TM8000 Family";
                    break;
                case 128:
                    family = "Weitek";
                    break;
                case 130:
                    family = "Itanium™ processor";
                    break;
                case 131:
                    family = "AMD Athlon™ 64 Processor Family";
                    break;
                case 132:
                    family = "AMD Opteron™ Processor Family";
                    break;
                case 133:
                    family = "AMD Sempron™ Processor Family";
                    break;
                case 134:
                    family = "AMD Turion™ 64 Mobile Technology";
                    break;
                case 135:
                    family = "Dual-Core AMD Opteron™ Processor Family";
                    break;
                case 136:
                    family = "AMD Athlon™ 64 X2 Dual-Core Processor Family";
                    break;
                case 137:
                    family = "AMD Turion™ 64 X2 Mobile Technology";
                    break;
                case 138:
                    family = "Quad-Core AMD Opteron™ Processor Family";
                    break;
                case 139:
                    family = "Third-Generation AMD Opteron™ Processor Family";
                    break;
                case 140:
                    family = "AMD Phenom™ FX Quad-Core Processor Family";
                    break;
                case 141:
                    family = "AMD Phenom™ X4 Quad-Core Processor Family";
                    break;
                case 142:
                    family = "AMD Phenom™ X2 Dual-Core Processor Family";
                    break;
                case 143:
                    family = "AMD Athlon™ X2 Dual-Core Processor Family";
                    break;
                case 144:
                    family = "PA-RISC Family";
                    break;
                case 145:
                    family = "PA-RISC 8500";
                    break;
                case 146:
                    family = "PA-RISC 8000";
                    break;
                case 147:
                    family = "PA-RISC 7300LC";
                    break;
                case 148:
                    family = "PA-RISC 7200";
                    break;
                case 149:
                    family = "PA-RISC 7100LC";
                    break;
                case 150:
                    family = "PA-RISC 7100";
                    break;
                case 160:
                    family = "V30 Family";
                    break;
                case 161:
                    family = "Quad-Core Intel® Xeon® processor 3200 Series";
                    break;
                case 162:
                    family = "Dual-Core Intel® Xeon® processor 3000 Series";
                    break;
                case 163:
                    family = "Quad-Core Intel® Xeon® processor 5300 Series";
                    break;
                case 164:
                    family = "Dual-Core Intel® Xeon® processor 5100 Series";
                    break;
                case 165:
                    family = "Dual-Core Intel® Xeon® processor 5000 Series";
                    break;
                case 166:
                    family = "Dual-Core Intel® Xeon® processor LV";
                    break;
                case 167:
                    family = "Dual-Core Intel® Xeon® processor ULV";
                    break;
                case 168:
                    family = "Dual-Core Intel® Xeon® processor 7100 Series";
                    break;
                case 169:
                    family = "Quad-Core Intel® Xeon® processor 5400 Series";
                    break;
                case 170:
                    family = "Quad-Core Intel® Xeon® processor";
                    break;
                case 171:
                    family = "Dual-Core Intel® Xeon® processor 5200 Series";
                    break;
                case 172:
                    family = "Dual-Core Intel® Xeon® processor 7200 Series";
                    break;
                case 173:
                    family = "Quad-Core Intel® Xeon® processor 7300 Series";
                    break;
                case 174:
                    family = "Quad-Core Intel® Xeon® processor 7400 Series";
                    break;
                case 175:
                    family = "Multi-Core Intel® Xeon® processor 7400 Series";
                    break;
                case 176:
                    family = "Pentium® III Xeon® processor";
                    break;
                case 177:
                    family = "Pentium® III Processor with Intel® SpeedStep™ Technology";
                    break;
                case 178:
                    family = "Pentium® 4 Processor";
                    break;
                case 179:
                    family = "Intel® Xeon® processor";
                    break;
                case 180:
                    family = "AS400 Family";
                    break;
                case 181:
                    family = "Intel® Xeon® processor MP";
                    break;
                case 182:
                    family = "AMD Athlon™ XP Processor Family";
                    break;
                case 183:
                    family = "AMD Athlon™ MP Processor Family";
                    break;
                case 184:
                    family = "Intel® Itanium® 2 processor";
                    break;
                case 185:
                    family = "Intel® Pentium® M processor";
                    break;
                case 186:
                    family = "Intel® Celeron® D processor";
                    break;
                case 187:
                    family = "Intel® Pentium® D processor";
                    break;
                case 188:
                    family = "Intel® Pentium® Processor Extreme Edition";
                    break;
                case 189:
                    family = "Intel® Core™ Solo Processor";
                    break;
                case 190:
                    family = "Reserved (AMD K7 or Intel Core 2 as of SMBIOS version 2.5)";
                    break;
                case 191:
                    family = "Intel® Core™ 2 Duo Processor";
                    break;
                case 192:
                    family = "Intel® Core™ 2 Solo processor";
                    break;
                case 193:
                    family = "Intel® Core™ 2 Extreme processor";
                    break;
                case 194:
                    family = "Intel® Core™ 2 Quad processor";
                    break;
                case 195:
                    family = "Intel® Core™ 2 Extreme mobile processor";
                    break;
                case 196:
                    family = "Intel® Core™ 2 Duo mobile processor";
                    break;
                case 197:
                    family = "Intel® Core™ 2 Solo mobile processor";
                    break;
                case 198:
                    family = "Intel® Core™ i7 processor";
                    break;
                case 199:
                    family = "Dual-Core Intel® Celeron® processor";
                    break;
                case 200:
                    family = "IBM390 Family";
                    break;
                case 201:
                    family = "G4";
                    break;
                case 202:
                    family = "G5";
                    break;
                case 203:
                    family = "ESA/390 G6";
                    break;
                case 204:
                    family = "z/Architecture base";
                    break;
                case 205:
                    family = "Intel® Core™ i5 processor";
                    break;
                case 206:
                    family = "Intel® Core™ i3 processor";
                    break;
                case 207:
                    family = "Intel® Core™ i9 processor";
                    break;
                case 208:
                    family = "Intel® Xeon® D Processor family";
                    break;
                case 210:
                    family = "VIA C7™-M Processor Family";
                    break;
                case 211:
                    family = "VIA C7™-D Processor Family";
                    break;
                case 212:
                    family = "VIA C7™ Processor Family";
                    break;
                case 213:
                    family = "VIA Eden™ Processor Family";
                    break;
                case 214:
                    family = "Multi-Core Intel® Xeon® processor";
                    break;
                case 215:
                    family = "Dual-Core Intel® Xeon® processor 3xxx Series";
                    break;
                case 216:
                    family = "Quad-Core Intel® Xeon® processor 3xxx Series";
                    break;
                case 217:
                    family = "VIA Nano™ Processor Family";
                    break;
                case 218:
                    family = "Dual-Core Intel® Xeon® processor 5xxx Series";
                    break;
                case 219:
                    family = "Quad-Core Intel® Xeon® processor 5xxx Series";
                    break;
                case 221:
                    family = "Dual-Core Intel® Xeon® processor 7xxx Series";
                    break;
                case 222:
                    family = "Quad-Core Intel® Xeon® processor 7xxx Series";
                    break;
                case 223:
                    family = "Multi-Core Intel® Xeon® processor 7xxx Series";
                    break;
                case 224:
                    family = "Multi-Core Intel® Xeon® processor 3400 Series";
                    break;
                case 228:
                    family = "AMD Opteron™ 3000 Series Processor";
                    break;
                case 229:
                    family = "AMD Sempron™ II Processor";
                    break;
                case 230:
                    family = "Embedded AMD Opteron™ Quad-Core Processor Family";
                    break;
                case 231:
                    family = "AMD Phenom™ Triple-Core Processor Family";
                    break;
                case 232:
                    family = "AMD Turion™ Ultra Dual-Core Mobile Processor Family";
                    break;
                case 233:
                    family = "AMD Turion™ Dual-Core Mobile Processor Family";
                    break;
                case 234:
                    family = "AMD Athlon™ Dual-Core Processor Family";
                    break;
                case 235:
                    family = "AMD Sempron™ SI Processor Family";
                    break;
                case 236:
                    family = "AMD Phenom™ II Processor Family";
                    break;
                case 237:
                    family = "AMD Athlon™ II Processor Family";
                    break;
                case 238:
                    family = "Six-Core AMD Opteron™ Processor Family";
                    break;
                case 239:
                    family = "AMD Sempron™ M Processor Family";
                    break;
                case 250:
                    family = "i860";
                    break;
                case 251:
                    family = "i960";
                    break;
                case 254:
                    family = "Indicator to obtain the processor family from the Processor Family 2 field";
                    break;
                case 255:
                    family = "Reserved";
                    break;
                case 256:
                    family = "ARMv7";
                    break;
                case 257:
                    family = "ARMv8";
                    break;
                case 258:
                    family = "ARMv9";
                    break;
                case 259:
                    family = "Reserved for future use by ARM";
                    break;
                case 260:
                    family = "SH-3";
                    break;
                case 261:
                    family = "SH-4";
                    break;
                case 280:
                    family = "ARM";
                    break;
                case 281:
                    family = "StrongARM";
                    break;
                case 300:
                    family = "6x86";
                    break;
                case 301:
                    family = "MediaGX";
                    break;
                case 302:
                    family = "MII";
                    break;
                case 320:
                    family = "WinChip";
                    break;
                case 350:
                    family = "DSP";
                    break;
                case 500:
                    family = "Video Processor";
                    break;
                case 512:
                    family = "RISC-V RV32";
                    break;
                case 513:
                    family = "RISC-V RV64";
                    break;
                case 514:
                    family = "RISC-V RV128";
                    break;
                case 600:
                    family = "LoongArch";
                    break;
                case 601:
                    family = "Loongson™ 1 Processor Family";
                    break;
                case 602:
                    family = "Loongson™ 2 Processor Family";
                    break;
                case 603:
                    family = "Loongson™ 3 Processor Family";
                    break;
                case 604:
                    family = "Loongson™ 2K Processor Family";
                    break;
                case 605:
                    family = "Loongson™ 3A Processor Family";
                    break;
                case 606:
                    family = "Loongson™ 3B Processor Family";
                    break;
                case 607:
                    family = "Loongson™ 3C Processor Family";
                    break;
                case 608:
                    family = "Loongson™ 3D Processor Family";
                    break;
                case 609:
                    family = "Loongson™ 3E Processor Family";
                    break;
                case 610:
                    family = "Dual-Core Loongson™ 2K Processor 2xxx Series";
                    break;
                case 620:
                    family = "Quad-Core Loongson™ 3A Processor 5xxx Series";
                    break;
                case 621:
                    family = "Multi-Core Loongson™ 3A Processor 5xxx Series";
                    break;
                case 622:
                    family = "Quad-Core Loongson™ 3B Processor 5xxx Series";
                    break;
                case 623:
                    family = "Multi-Core Loongson™ 3B Processor 5xxx Series";
                    break;
                case 624:
                    family = "Multi-Core Loongson™ 3C Processor 5xxx Series";
                    break;
                case 625:
                    family = "Multi-Core Loongson™ 3D Processor 5xxx Series";
                    break;
                case 768:
                    family = "Intel® Core™ 3";
                    break;
                case 769:
                    family = "Intel® Core™ 5";
                    break;
                case 770:
                    family = "Intel® Core™ 7";
                    break;
                case 771:
                    family = "Intel® Core™ 9";
                    break;
                case 772:
                    family = "Intel® Core™ Ultra 3";
                    break;
                case 773:
                    family = "Intel® Core™ Ultra 5";
                    break;
                case 774:
                    family = "Intel® Core™ Ultra 7";
                    break;
                case 775:
                    family = "Intel® Core™ Ultra 9";
                    break;
                case 65534:
                    family = "Reserved";
                    break;
                case 65535:
                    family = "Reserved";
                    break;
                default:
                    family = CPUConstants.AVAILABLE_FOR_ASSIGNMENT;
                    break;

            }
            return family;
        }

        public string GetPowerManagementCapabilities(ushort value)
        {
            string powerManagementCapability;
            switch(value)
            {
                case 0:
                    powerManagementCapability = "Unknown";
                    break;
                case 1:
                    powerManagementCapability = "Not Supported";
                    break;
                case 2:
                    powerManagementCapability = "Disabled";
                    break;
                case 3:
                    powerManagementCapability = "Enabled";
                    break;
                case 4:
                    powerManagementCapability = "Power Saving Modes Entered Automatically";
                    break;
                case 5:
                    powerManagementCapability = "Power State Settable";
                    break;
                case 6:
                    powerManagementCapability = "Power Cycling Supported";
                    break;
                case 7:
                    powerManagementCapability = "Timed Power On Supported";
                    break;
                default:
                    powerManagementCapability = CPUConstants.NOT_FOUND_OR_UNKNOWN;
                    break;
            }
            return powerManagementCapability;
        }

        public string GetProcessorType(ushort value)
        {
            string processorType;

            switch (value)
            {
                case 1:
                    processorType = "Other";
                    break;
                case 2:
                    processorType = "Unknown";
                    break;
                case 3:
                    processorType = "Central Processor";
                    break;
                case 4:
                    processorType = "Math Processor";
                    break;
                case 5:
                    processorType = "DSP Processor";
                    break;
                case 6:
                    processorType = "Video Processor";
                    break;
                default:
                    processorType = CPUConstants.NOT_FOUND_OR_UNKNOWN;
                    break;
            }

            return processorType;
        }

        public string GetStatusInfo(ushort value)
        {
            string statusInfo;

            switch (value)
            {
                case 1:
                    statusInfo = "Other";
                    break;
                case 2:
                    statusInfo = "Unknown";
                    break;
                case 3:
                    statusInfo = "Enabled";
                    break;
                case 4:
                    statusInfo = "Disabled";
                    break;
                case 5:
                    statusInfo = "Not Applicable";
                    break;
                default:
                    statusInfo = CPUConstants.NOT_FOUND_OR_UNKNOWN;
                    break;
            }

            return statusInfo;
        }

        public string GetUpgradeMethod(ushort value)
        {
            string upgradeMethod;

            switch (value)
            {
                case 1:
                    upgradeMethod = "Other";
                    break;
                case 2:
                    upgradeMethod = "Unknown";
                    break;
                case 3:
                    upgradeMethod = "Daughter Board";
                    break;
                case 4:
                    upgradeMethod = "ZIF Socket";
                    break;
                case 5:
                    upgradeMethod = "Replaceable Piggy Back";
                    break;
                case 6:
                    upgradeMethod = "None";
                    break;
                case 7:
                    upgradeMethod = "LIF Socket";
                    break;
                case 8:
                    upgradeMethod = "Slot 1";
                    break;
                case 9:
                    upgradeMethod = "Slot 2";
                    break;
                case 10:
                    upgradeMethod = "370-pin socket";
                    break;
                case 11:
                    upgradeMethod = "Slot A";
                    break;
                case 12:
                    upgradeMethod = "Slot M";
                    break;
                case 13:
                    upgradeMethod = "Socket 423";
                    break;
                case 14:
                    upgradeMethod = "Socket A (Socket 462)";
                    break;
                case 15:
                    upgradeMethod = "Socket 478";
                    break;
                case 16:
                    upgradeMethod = "Socket 754";
                    break;
                case 17:
                    upgradeMethod = "Socket 940";
                    break;
                case 18:
                    upgradeMethod = "Socket 939";
                    break;
                case 19:
                    upgradeMethod = "Socket mPGA604";
                    break;
                case 20:
                    upgradeMethod = "Socket LGA771";
                    break;
                case 21:
                    upgradeMethod = "Socket LGA775";
                    break;
                case 22:
                    upgradeMethod = "Socket S1";
                    break;
                case 23:
                    upgradeMethod = "Socket AM2";
                    break;
                case 24:
                    upgradeMethod = "Socket F (1207)";
                    break;
                case 25:
                    upgradeMethod = "Socket LGA1366";
                    break;
                case 26:
                    upgradeMethod = "Socket G34";
                    break;
                case 27:
                    upgradeMethod = "Socket AM3";
                    break;
                case 28:
                    upgradeMethod = "Socket C32";
                    break;
                case 29:
                    upgradeMethod = "Socket LGA1156";
                    break;
                case 30:
                    upgradeMethod = "Socket LGA1567";
                    break;
                case 31:
                    upgradeMethod = "Socket PGA988A";
                    break;
                case 32:
                    upgradeMethod = "Socket BGA1288";
                    break;
                case 33:
                    upgradeMethod = "Socket rPGA988B";
                    break;
                case 34:
                    upgradeMethod = "Socket BGA1023";
                    break;
                case 35:
                    upgradeMethod = "Socket BGA1224";
                    break;
                case 36:
                    upgradeMethod = "Socket LGA1155";
                    break;
                case 37:
                    upgradeMethod = "Socket LGA1356";
                    break;
                case 38:
                    upgradeMethod = "Socket LGA2011";
                    break;
                case 39:
                    upgradeMethod = "Socket FS1";
                    break;
                case 40:
                    upgradeMethod = "Socket FS2";
                    break;
                case 41:
                    upgradeMethod = "Socket FM1";
                    break;
                case 42:
                    upgradeMethod = "Socket FM2";
                    break;
                case 43:
                    upgradeMethod = "Socket LGA2011-3";
                    break;
                case 44:
                    upgradeMethod = "Socket LGA1356-3";
                    break;
                case 45:
                    upgradeMethod = "Socket LGA1150";
                    break;
                case 46:
                    upgradeMethod = "Socket BGA1168";
                    break;
                case 47:
                    upgradeMethod = "Socket BGA1234";
                    break;
                case 48:
                    upgradeMethod = "Socket BGA1364";
                    break;
                case 49:
                    upgradeMethod = "Socket AM4";
                    break;
                case 50:
                    upgradeMethod = "Socket LGA1151";
                    break;
                case 51:
                    upgradeMethod = "Socket BGA1356";
                    break;
                case 52:
                    upgradeMethod = "Socket BGA1440";
                    break;
                case 53:
                    upgradeMethod = "Socket BGA1515";
                    break;
                case 54:
                    upgradeMethod = "Socket LGA3647-1";
                    break;
                case 55:
                    upgradeMethod = "Socket SP3";
                    break;
                case 56:
                    upgradeMethod = "Socket SP3r2";
                    break;
                case 57:
                    upgradeMethod = "Socket LGA2066";
                    break;
                case 58:
                    upgradeMethod = "Socket BGA1392";
                    break;
                case 59:
                    upgradeMethod = "Socket BGA1510";
                    break;
                case 60:
                    upgradeMethod = "Socket BGA1528";
                    break;
                case 61:
                    upgradeMethod = "Socket LGA4189";
                    break;
                case 62:
                    upgradeMethod = "Socket LGA1200";
                    break;
                case 63:
                    upgradeMethod = "Socket LGA4677";
                    break;
                case 64:
                    upgradeMethod = "Socket LGA1700";
                    break;
                case 65:
                    upgradeMethod = "Socket BGA1744";
                    break;
                case 66:
                    upgradeMethod = "Socket BGA1781";
                    break;
                case 67:
                    upgradeMethod = "Socket BGA1211";
                    break;
                case 68:
                    upgradeMethod = "Socket BGA2422";
                    break;
                case 69:
                    upgradeMethod = "Socket LGA1211";
                    break;
                case 70:
                    upgradeMethod = "Socket LGA2422";
                    break;
                case 71:
                    upgradeMethod = "Socket LGA5773";
                    break;
                case 72:
                    upgradeMethod = "Socket BGA5773";
                    break;
                case 73:
                    upgradeMethod = "Socket AM5";
                    break;
                case 74:
                    upgradeMethod = "Socket SP5";
                    break;
                case 75:
                    upgradeMethod = "Socket SP6";
                    break;
                case 76:
                    upgradeMethod = "Socket BGA883";
                    break;
                case 77:
                    upgradeMethod = "Socket BGA1190";
                    break;
                case 78:
                    upgradeMethod = "Socket BGA4129";
                    break;
                case 79:
                    upgradeMethod = "Socket LGA4710";
                    break;
                case 80:
                    upgradeMethod = "Socket LGA7529";
                    break;
                case 81:
                    upgradeMethod = "Socket BGA1964";
                    break;
                case 82:
                    upgradeMethod = "Socket BGA1792";
                    break;
                case 83:
                    upgradeMethod = "Socket BGA2049";
                    break;
                case 84:
                    upgradeMethod = "Socket BGA2551";
                    break;
                case 85:
                    upgradeMethod = "Socket LGA1851";
                    break;
                case 86:
                    upgradeMethod = "Socket BGA2114";
                    break;
                case 87:
                    upgradeMethod = "Socket BGA2833";
                    break;
                default:
                    upgradeMethod = CPUConstants.NOT_FOUND_OR_UNKNOWN;
                    break;
            }

            return upgradeMethod;
        }

        /*
        [DllImport("AvxDetect.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int IsAvx2Supported(); // Native();

        public bool IsAvx2SupportedX()
        {
            try
            {
                return IsAvx2Supported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. AVX2 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AVX2 support: " + ex.Message);
                return false;
            }
        }
        */

        #region EAX = 0x0: Highest Function Parameter and Manufacturer ID

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX0EAX();

        public string GetEAX0EAXX()
        {
            try
            {
                IntPtr eAX0EAXPtr = GetEAX0EAX();
                string eAX0EAXString = Marshal.PtrToStringAnsi(eAX0EAXPtr);

                return eAX0EAXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX0EBX();

        public string GetEAX0EBXX()
        {
            try
            {
                IntPtr eAX0EBXPtr = GetEAX0EBX();
                string eAX0EBXString = Marshal.PtrToStringAnsi(eAX0EBXPtr);

                return eAX0EBXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX0ECX();

        public string GetEAX0ECXX()
        {
            try
            {
                IntPtr eAX0ECXPtr = GetEAX0ECX();
                string eAX0ECXString = Marshal.PtrToStringAnsi(eAX0ECXPtr);

                return eAX0ECXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX0EDX();

        public string GetEAX0EDXX()
        {
            try
            {
                IntPtr eAX0EDXPtr = GetEAX0EDX();
                string eAX0EDXString = Marshal.PtrToStringAnsi(eAX0EDXPtr);

                return eAX0EDXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX0EAXHightestFunctionParameter();

        public string GetEAX0EAXHightestFunctionParameterX()
        {
            try
            {
                IntPtr eAX0EAXHightestFunctionParameterPtr = GetEAX0EAXHightestFunctionParameter();
                string eAX0EAXHightestFunctionParameterString = Marshal.PtrToStringAnsi(eAX0EAXHightestFunctionParameterPtr);

                return eAX0EAXHightestFunctionParameterString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX0EBXEDXECXCpuVendor();

        public string GetEAX0EBXEDXECXCpuVendorX()
        {
            try
            {
                IntPtr vendorPtr = GetEAX0EBXEDXECXCpuVendor();
                string vendorString = Marshal.PtrToStringAnsi(vendorPtr);

                return vendorString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        #endregion

        #region EAX=0x1: Processor Info and Feature Bits

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX1EAX();

        public string GetEAX1EAXX()
        {
            try
            {
                IntPtr eAX1EAXPtr = GetEAX1EAX();
                string eAX1EAXString = Marshal.PtrToStringAnsi(eAX1EAXPtr);

                return eAX1EAXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX1EBX();

        public string GetEAX1EBXX()
        {
            try
            {
                IntPtr eAX1EBXPtr = GetEAX1EBX();
                string eAX1EBXString = Marshal.PtrToStringAnsi(eAX1EBXPtr);

                return eAX1EBXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX1ECX();

        public string GetEAX1ECXX()
        {
            try
            {
                IntPtr eAX1ECXPtr = GetEAX1ECX();
                string eAX1ECXString = Marshal.PtrToStringAnsi(eAX1ECXPtr);

                return eAX1ECXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX1EDX();

        public string GetEAX1EDXX()
        {
            try
            {
                IntPtr eAX1EDXPtr = GetEAX1EDX();
                string eAX1EDXString = Marshal.PtrToStringAnsi(eAX1EDXPtr);

                return eAX1EDXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX1EAX0_3_SteppingId();

        public string GetEAX1EAX0_3_SteppingIdX()
        {
            try
            {
                int eAX1EAX0_3_SteppingIdValue = GetEAX1EAX0_3_SteppingId();
                string eAX1EAX0_3_SteppingIdString = eAX1EAX0_3_SteppingIdValue.ToString();

                return eAX1EAX0_3_SteppingIdString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX1EAX4_7_ModelId();

        public string GetEAX1EAX4_7_ModelIdX()
        {
            try
            {
                int eAX1EAX4_7_ModelIdValue = GetEAX1EAX4_7_ModelId();
                string eAX1EAX4_7_ModelIdString = eAX1EAX4_7_ModelIdValue.ToString();

                return eAX1EAX4_7_ModelIdString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX1EAX8_11_FamilyId();

        public string GetEAX1EAX8_11_FamilyIdX()
        {
            try
            {
                int eAX1EAX8_11_FamilyIdValue = GetEAX1EAX8_11_FamilyId();
                string eAX1EAX8_11_FamilyIdString = eAX1EAX8_11_FamilyIdValue.ToString();

                return eAX1EAX8_11_FamilyIdString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX1EAX12_13_ProcessorType();

        public string GetEAX1EAX12_13_ProcessorTypeX()
        {
            try
            {
                int eAX1EAX12_13_ProcessorTypeValue = GetEAX1EAX12_13_ProcessorType();
                string eAX1EAX12_13_ProcessorTypeString = eAX1EAX12_13_ProcessorTypeValue.ToString();

                return eAX1EAX12_13_ProcessorTypeString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX1EAX14_15_Reserved();

        public string GetEAX1EAX14_15_ReservedX()
        {
            try
            {
                int eAX1EAX14_15_ReservedValue = GetEAX1EAX14_15_Reserved();
                string eAX1EAX14_15_ReservedString = eAX1EAX14_15_ReservedValue.ToString();

                return eAX1EAX14_15_ReservedString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX1EAX16_19_ExtendedModelId();

        public string GetEAX1EAX16_19_ExtendedModelIdX()
        {
            try
            {
                int eAX1EAX16_19_ExtendedModelIdValue = GetEAX1EAX16_19_ExtendedModelId();
                string eAX1EAX16_19_ExtendedModelIdString = eAX1EAX16_19_ExtendedModelIdValue.ToString();

                return eAX1EAX16_19_ExtendedModelIdString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX1EAX16_19_ExtendedModelIdLeftShifted();

        public string GetEAX1EAX16_19_ExtendedModelIdLeftShiftedX()
        {
            try
            {
                int eAX1EAX16_19_ExtendedModelIdLeftShiftedValue = GetEAX1EAX16_19_ExtendedModelIdLeftShifted();
                string eAX1EAX16_19_ExtendedModelIdLeftShiftedString = eAX1EAX16_19_ExtendedModelIdLeftShiftedValue.ToString();

                return eAX1EAX16_19_ExtendedModelIdLeftShiftedString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX1EAX20_27_ExtendedFamilyId();

        public string GetEAX1EAX20_27_ExtendedFamilyIdX()
        {
            try
            {
                int eAX1EAX20_27_ExtendedFamilyIdValue = GetEAX1EAX20_27_ExtendedFamilyId();
                string eAX1EAX20_27_ExtendedFamilyIdString = eAX1EAX20_27_ExtendedFamilyIdValue.ToString();

                return eAX1EAX20_27_ExtendedFamilyIdString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX1EAX28_31_Reserved();

        public string GetEAX1EAX28_31_ReservedX()
        {
            try
            {
                int eAX1EAX28_31_ReservedValue = GetEAX1EAX28_31_Reserved();
                string eAX1EAX28_31_ReservedString = eAX1EAX28_31_ReservedValue.ToString();

                return eAX1EAX28_31_ReservedString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX1EBX0_7_BrandIndex();

        public string GetEAX1EBX0_7_BrandIndexX()
        {
            try
            {
                int eAX1EBX0_7_BrandIndexValue = GetEAX1EBX0_7_BrandIndex();
                string eAX1EBX0_7_BrandIndexString = eAX1EBX0_7_BrandIndexValue.ToString();

                return eAX1EBX0_7_BrandIndexString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX1EBX8_15_CLFLUSHLineSize();

        public string GetEAX1EBX8_15_CLFLUSHLineSizeX()
        {
            try
            {
                int eAX1EBX8_15_CLFLUSHLineSizeValue = GetEAX1EBX8_15_CLFLUSHLineSize();
                string eAX1EBX8_15_CLFLUSHLineSizeString = eAX1EBX8_15_CLFLUSHLineSizeValue.ToString();

                return eAX1EBX8_15_CLFLUSHLineSizeString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX1EBX16_23_MaxNumAddrIdsLogProcsInPhyPckg();

        public string GetEAX1EBX16_23_MaxNumAddrIdsLogProcsInPhyPckgX()
        {
            try
            {
                int eAX1EBX16_23_MaxNumAddrIdsLogProcsInPhyPckgValue = GetEAX1EBX16_23_MaxNumAddrIdsLogProcsInPhyPckg();
                string eAX1EBX16_23_MaxNumAddrIdsLogProcsInPhyPckgString = eAX1EBX16_23_MaxNumAddrIdsLogProcsInPhyPckgValue.ToString();

                return eAX1EBX16_23_MaxNumAddrIdsLogProcsInPhyPckgString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX1EBX24_31_LocalAPICID();

        public string GetEAX1EBX24_31_LocalAPICIDX()
        {
            try
            {
                int eAX1EBX24_31_LocalAPICIDValue = GetEAX1EBX24_31_LocalAPICID();
                string eAX1EBX24_31_LocalAPICIDString = eAX1EBX24_31_LocalAPICIDValue.ToString();

                return eAX1EBX24_31_LocalAPICIDString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        #region ECX feature bits

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX0_SSE3IsSupported();

        public bool GetEAX1ECX0_SSE3IsSupportedX()
        {
            try
            {
                return GetEAX1ECX0_SSE3IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. SSE3 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for SSE3 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX1_PCLMULQDQIsSupported();

        public bool GetEAX1ECX1_PCLMULQDQIsSupportedX()
        {
            try
            {
                return GetEAX1ECX1_PCLMULQDQIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. PCLMULQDQ support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for PCLMULQDQ support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX2_DTES64IsSupported();

        public bool GetEAX1ECX2_DTES64IsSupportedX()
        {
            try
            {
                return GetEAX1ECX2_DTES64IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. DTES64 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for DTES64 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX3_MONITORIsSupported();

        public bool GetEAX1ECX3_MONITORIsSupportedX()
        {
            try
            {
                return GetEAX1ECX3_MONITORIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. MONITOR support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for MONITOR support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX4_DSCPLIsSupported();

        public bool GetEAX1ECX4_DSCPLIsSupportedX()
        {
            try
            {
                return GetEAX1ECX4_DSCPLIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. DSCPL support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for DSCPL support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX5_VMXIsSupported();

        public bool GetEAX1ECX5_VMXIsSupportedX()
        {
            try
            {
                return GetEAX1ECX5_VMXIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. VMX support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for VMX support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX6_SMXIsSupported();

        public bool GetEAX1ECX6_SMXIsSupportedX()
        {
            try
            {
                return GetEAX1ECX6_SMXIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. SMX support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for SMX support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX7_ESTIsSupported();

        public bool GetEAX1ECX7_ESTIsSupportedX()
        {
            try
            {
                return GetEAX1ECX7_ESTIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. EST support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for EST support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX8_TM2IsSupported();

        public bool GetEAX1ECX8_TM2IsSupportedX()
        {
            try
            {
                return GetEAX1ECX8_TM2IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. TM2 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for TM2 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX9_SSSE3IsSupported();

        public bool GetEAX1ECX9_SSSE3IsSupportedX()
        {
            try
            {
                return GetEAX1ECX9_SSSE3IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. SSSE3 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for SSSE3 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX10_CNXTIDIsSupported();

        public bool GetEAX1ECX10_CNXTIDIsSupportedX()
        {
            try
            {
                return GetEAX1ECX10_CNXTIDIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. CNXTID support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CNXTID support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX11_SDBGIsSupported();

        public bool GetEAX1ECX11_SDBGIsSupportedX()
        {
            try
            {
                return GetEAX1ECX11_SDBGIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. SDBG support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for SDBG support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX12_FMAIsSupported();

        public bool GetEAX1ECX12_FMAIsSupportedX()
        {
            try
            {
                return GetEAX1ECX12_FMAIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. FMA support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for FMA support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX13_CMPXCHG16BIsSupported();

        public bool GetEAX1ECX13_CMPXCHG16BIsSupportedX()
        {
            try
            {
                return GetEAX1ECX13_CMPXCHG16BIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. CMPXCHG16B support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CMPXCHG16B support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX14_xTPRUpdateControlIsSupported();

        public bool GetEAX1ECX14_xTPRUpdateControlIsSupportedX()
        {
            try
            {
                return GetEAX1ECX14_xTPRUpdateControlIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. xTPRUpdateControl support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for xTPRUpdateControl support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX15_PDCMIsSupported();

        public bool GetEAX1ECX15_PDCMIsSupportedX()
        {
            try
            {
                return GetEAX1ECX15_PDCMIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. PDCM support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for PDCM support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX16_ReservedIsSupported();

        public bool GetEAX1ECX16_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX1ECX16_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX17_PCIDIsSupported();

        public bool GetEAX1ECX17_PCIDIsSupportedX()
        {
            try
            {
                return GetEAX1ECX17_PCIDIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. PCID support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for PCID support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX18_DCAIsSupported();

        public bool GetEAX1ECX18_DCAIsSupportedX()
        {
            try
            {
                return GetEAX1ECX18_DCAIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. DCA support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for DCA support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX19_SSE41IsSupported();

        public bool GetEAX1ECX19_SSE41IsSupportedX()
        {
            try
            {
                return GetEAX1ECX19_SSE41IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. SSE4.1 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for SSE4.1 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX20_SSE42IsSupported();

        public bool GetEAX1ECX20_SSE42IsSupportedX()
        {
            try
            {
                return GetEAX1ECX20_SSE42IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. SSE4.2 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for SSE4.2 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX21_X2APICIsSupported();

        public bool GetEAX1ECX21_X2APICIsSupportedX()
        {
            try
            {
                return GetEAX1ECX21_X2APICIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. X2APIC support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for X2APIC support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX22_MOVBEIsSupported();

        public bool GetEAX1ECX22_MOVBEIsSupportedX()
        {
            try
            {
                return GetEAX1ECX22_MOVBEIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. MOVBE support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for MOVBE support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX23_POPCNTIsSupported();

        public bool GetEAX1ECX23_POPCNTIsSupportedX()
        {
            try
            {
                return GetEAX1ECX23_POPCNTIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. POPCNT support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for POPCNT support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX24_TSCDeadlineIsSupported();

        public bool GetEAX1ECX24_TSCDeadlineIsSupportedX()
        {
            try
            {
                return GetEAX1ECX24_TSCDeadlineIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. TSC Deadline support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for TSC Deadline support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX25_AESNIIsSupported();

        public bool GetEAX1ECX25_AESNIIsSupportedX()
        {
            try
            {
                return GetEAX1ECX25_AESNIIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. AES-NI support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AES-NI support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX26_XSAVEIsSupported();

        public bool GetEAX1ECX26_XSAVEIsSupportedX()
        {
            try
            {
                return GetEAX1ECX26_XSAVEIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. XSAVE support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for XSAVE support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX27_OSXSAVEIsSupported();

        public bool GetEAX1ECX27_OSXSAVEIsSupportedX()
        {
            try
            {
                return GetEAX1ECX27_OSXSAVEIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. OSXSAVE support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for OSXSAVE support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX28_AVXIsSupported();

        public bool GetEAX1ECX28_AVXIsSupportedX()
        {
            try
            {
                return GetEAX1ECX28_AVXIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. AVX support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AVX support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX29_F16CIsSupported();

        public bool GetEAX1ECX29_F16CIsSupportedX()
        {
            try
            {
                return GetEAX1ECX29_F16CIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. F16C support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for F16C support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX30_RDRANDIsSupported();

        public bool GetEAX1ECX30_RDRANDIsSupportedX()
        {
            try
            {
                return GetEAX1ECX30_RDRANDIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. RDRAND support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for RDRAND support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1ECX31_HypervisorIsSupported();

        public bool GetEAX1ECX31_HypervisorIsSupportedX()
        {
            try
            {
                return GetEAX1ECX31_HypervisorIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. Hypervisor support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Hypervisor support: " + ex.Message);
                return false;
            }
        }

        #endregion

        #region EDX feature bits

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX0_FPUIsSupported();

        public bool GetEAX1EDX0_FPUIsSupportedX()
        {
            try
            {
                return GetEAX1EDX0_FPUIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. FPU support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for FPU support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX1_VMEIsSupported();

        public bool GetEAX1EDX1_VMEIsSupportedX()
        {
            try
            {
                return GetEAX1EDX1_VMEIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. VME support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for VME support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX2_DEIsSupported();

        public bool GetEAX1EDX2_DEIsSupportedX()
        {
            try
            {
                return GetEAX1EDX2_DEIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. DE support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for DE support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX3_PSEIsSupported();

        public bool GetEAX1EDX3_PSEIsSupportedX()
        {
            try
            {
                return GetEAX1EDX3_PSEIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. PSE support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for PSE support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX4_TSCIsSupported();

        public bool GetEAX1EDX4_TSCIsSupportedX()
        {
            try
            {
                return GetEAX1EDX4_TSCIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. TSC support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for TSC support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX5_MSRIsSupported();

        public bool GetEAX1EDX5_MSRIsSupportedX()
        {
            try
            {
                return GetEAX1EDX5_MSRIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. MSR support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for MSR support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX6_PAEIsSupported();

        public bool GetEAX1EDX6_PAEIsSupportedX()
        {
            try
            {
                return GetEAX1EDX6_PAEIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. PAE support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for PAE support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX7_MCEIsSupported();

        public bool GetEAX1EDX7_MCEIsSupportedX()
        {
            try
            {
                return GetEAX1EDX7_MCEIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. MCE support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for MCE support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX8_CX8IsSupported();

        public bool GetEAX1EDX8_CX8IsSupportedX()
        {
            try
            {
                return GetEAX1EDX8_CX8IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. CX8 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CX8 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX9_APICIsSupported();

        public bool GetEAX1EDX9_APICIsSupportedX()
        {
            try
            {
                return GetEAX1EDX9_APICIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. APIC support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for APIC support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX10_ReservedIsSupported();

        public bool GetEAX1EDX10_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX1EDX10_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX11_SEPIsSupported();

        public bool GetEAX1EDX11_SEPIsSupportedX()
        {
            try
            {
                return GetEAX1EDX11_SEPIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. SEP support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for SEP support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX12_MTRRIsSupported();

        public bool GetEAX1EDX12_MTRRIsSupportedX()
        {
            try
            {
                return GetEAX1EDX12_MTRRIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. MTRR support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for MTRR support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX13_PGEIsSupported();

        public bool GetEAX1EDX13_PGEIsSupportedX()
        {
            try
            {
                return GetEAX1EDX13_PGEIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. PGE support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for PGE support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX14_MCAIsSupported();

        public bool GetEAX1EDX14_MCAIsSupportedX()
        {
            try
            {
                return GetEAX1EDX14_MCAIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. MCA support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for MCA support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX15_CMOVIsSupported();

        public bool GetEAX1EDX15_CMOVIsSupportedX()
        {
            try
            {
                return GetEAX1EDX15_CMOVIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. CMOV support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CMOV support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX16_PATIsSupported();

        public bool GetEAX1EDX16_PATIsSupportedX()
        {
            try
            {
                return GetEAX1EDX16_PATIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. PAT support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for PAT support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX17_PSE36IsSupported();

        public bool GetEAX1EDX17_PSE36IsSupportedX()
        {
            try
            {
                return GetEAX1EDX17_PSE36IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. PSE36 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for PSE36 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX18_PSNIsSupported();

        public bool GetEAX1EDX18_PSNIsSupportedX()
        {
            try
            {
                return GetEAX1EDX18_PSNIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. PSN support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for PSN support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX19_CLFSHIsSupported();

        public bool GetEAX1EDX19_CLFSHIsSupportedX()
        {
            try
            {
                return GetEAX1EDX19_CLFSHIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. CLFSH support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CLFSH support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX20_NXIsSupported();

        public bool GetEAX1EDX20_NXIsSupportedX()
        {
            try
            {
                return GetEAX1EDX20_NXIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. NX support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for NX support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX21_DSIsSupported();

        public bool GetEAX1EDX21_DSIsSupportedX()
        {
            try
            {
                return GetEAX1EDX21_DSIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. DS support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for DS support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX22_ACPIIsSupported();

        public bool GetEAX1EDX22_ACPIIsSupportedX()
        {
            try
            {
                return GetEAX1EDX22_ACPIIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. ACPI support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for ACPI support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX23_MMXIsSupported();

        public bool GetEAX1EDX23_MMXIsSupportedX()
        {
            try
            {
                return GetEAX1EDX23_MMXIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. MMX support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for MMX support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX24_FXSRIsSupported();

        public bool GetEAX1EDX24_FXSRIsSupportedX()
        {
            try
            {
                return GetEAX1EDX24_FXSRIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. FXSR support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for FXSR support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX25_SSEIsSupported();

        public bool GetEAX1EDX25_SSEIsSupportedX()
        {
            try
            {
                return GetEAX1EDX25_SSEIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. SSE support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for SSE support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX26_SSE2IsSupported();

        public bool GetEAX1EDX26_SSE2IsSupportedX()
        {
            try
            {
                return GetEAX1EDX26_SSE2IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. SSE2 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for SSE2 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX27_SSIsSupported();

        public bool GetEAX1EDX27_SSIsSupportedX()
        {
            try
            {
                return GetEAX1EDX27_SSIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. SS support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for SS support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX28_HTTIsSupported();

        public bool GetEAX1EDX28_HTTIsSupportedX()
        {
            try
            {
                return GetEAX1EDX28_HTTIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. HTT support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for HTT support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX29_TMIsSupported();

        public bool GetEAX1EDX29_TMIsSupportedX()
        {
            try
            {
                return GetEAX1EDX29_TMIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. TM support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for TM support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX30_IA64IsSupported();

        public bool GetEAX1EDX30_IA64IsSupportedX()
        {
            try
            {
                return GetEAX1EDX30_IA64IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. IA64 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for IA64 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX1EDX31_PBEIsSupported();

        public bool GetEAX1EDX31_PBEIsSupportedX()
        {
            try
            {
                return GetEAX1EDX31_PBEIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: AvxDetect.dll not found. PBE support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for PBE support: " + ex.Message);
                return false;
            }
        }

        #endregion

        #endregion

        #region EAX=0x2: Cache and TLB Descriptor Information

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX2EAX();

        public string GetEAX2EAXX()
        {
            try
            {
                IntPtr eAX2EAXPtr = GetEAX2EAX();
                string eAX2EAXString = Marshal.PtrToStringAnsi(eAX2EAXPtr);

                return eAX2EAXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX2EBX();

        public string GetEAX2EBXX()
        {
            try
            {
                IntPtr eAX2EBXPtr = GetEAX2EBX();
                string eAX2EBXString = Marshal.PtrToStringAnsi(eAX2EBXPtr);

                return eAX2EBXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX2ECX();

        public string GetEAX2ECXX()
        {
            try
            {
                IntPtr eAX2ECXPtr = GetEAX2ECX();
                string eAX2ECXString = Marshal.PtrToStringAnsi(eAX2ECXPtr);

                return eAX2ECXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX2EDX();

        public string GetEAX2EDXX()
        {
            try
            {
                IntPtr eAX2EDXPtr = GetEAX2EDX();
                string eAX2EDXString = Marshal.PtrToStringAnsi(eAX2EDXPtr);

                return eAX2EDXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX2_EAX31_IsInvalidCacheAndTblDescriptorsEAX();

        public string GetEAX2_EAX31_IsInvalidCacheAndTblDescriptorsEAXX()
        {
            try
            {
                int eAX2_EAX31_IsInvalidCacheAndTblDescriptorsEAXValue = GetEAX2_EAX31_IsInvalidCacheAndTblDescriptorsEAX();
                string eAX2_EAX31_IsInvalidCacheAndTblDescriptorsEAXString = eAX2_EAX31_IsInvalidCacheAndTblDescriptorsEAXValue.ToString();

                return eAX2_EAX31_IsInvalidCacheAndTblDescriptorsEAXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX2_EAX0_7_NumberOfTimeToQueryCPUIDWithEAX2();

        public string GetEAX2_EAX0_7_NumberOfTimeToQueryCPUIDWithEAX2X()
        {
            try
            {
                int eAX2_EAX0_7_NumberOfTimeToQueryCPUIDWithEAX2Value = GetEAX2_EAX0_7_NumberOfTimeToQueryCPUIDWithEAX2();
                string eAX2_EAX0_7_NumberOfTimeToQueryCPUIDWithEAX2String = eAX2_EAX0_7_NumberOfTimeToQueryCPUIDWithEAX2Value.ToString();

                return eAX2_EAX0_7_NumberOfTimeToQueryCPUIDWithEAX2String;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX2_EAX8_15_CacheAndTLBDescriptorInformation1();

        public string GetEAX2_EAX8_15_CacheAndTLBDescriptorInformation1X()
        {
            try
            {
                int eAX2_EAX8_15_CacheAndTLBDescriptorInformation1Value = GetEAX2_EAX8_15_CacheAndTLBDescriptorInformation1();
                string eAX2_EAX8_15_CacheAndTLBDescriptorInformation1String = eAX2_EAX8_15_CacheAndTLBDescriptorInformation1Value.ToString();

                return eAX2_EAX8_15_CacheAndTLBDescriptorInformation1String;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX2_EAX16_23_CacheAndTLBDescriptorInformation2();

        public string GetEAX2_EAX16_23_CacheAndTLBDescriptorInformation2X()
        {
            try
            {
                int eAX2_EAX16_23_CacheAndTLBDescriptorInformation2Value = GetEAX2_EAX16_23_CacheAndTLBDescriptorInformation2();
                string eAX2_EAX16_23_CacheAndTLBDescriptorInformation2String = eAX2_EAX16_23_CacheAndTLBDescriptorInformation2Value.ToString();

                return eAX2_EAX16_23_CacheAndTLBDescriptorInformation2String;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX2_EAX24_31_CacheAndTLBDescriptorInformation3();

        public string GetEAX2_EAX24_31_CacheAndTLBDescriptorInformation3X()
        {
            try
            {
                int eAX2_EAX24_31_CacheAndTLBDescriptorInformation3Value = GetEAX2_EAX24_31_CacheAndTLBDescriptorInformation3();
                string eAX2_EAX24_31_CacheAndTLBDescriptorInformation3String = eAX2_EAX24_31_CacheAndTLBDescriptorInformation3Value.ToString();

                return eAX2_EAX24_31_CacheAndTLBDescriptorInformation3String;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX2_EBX31_IsInvalidCacheAndTblDescriptorsEBX();

        public string GetEAX2_EBX31_IsInvalidCacheAndTblDescriptorsEBXX()
        {
            try
            {
                int eAX2_EBX31_IsInvalidCacheAndTblDescriptorsEBXValue = GetEAX2_EBX31_IsInvalidCacheAndTblDescriptorsEBX();
                string eAX2_EBX31_IsInvalidCacheAndTblDescriptorsEBXString = eAX2_EBX31_IsInvalidCacheAndTblDescriptorsEBXValue.ToString();

                return eAX2_EBX31_IsInvalidCacheAndTblDescriptorsEBXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX2_EBX8_15_CacheAndTLBDescriptorInformation1();

        public string GetEAX2_EBX8_15_CacheAndTLBDescriptorInformation1X()
        {
            try
            {
                int eAX2_EBX8_15_CacheAndTLBDescriptorInformation1Value = GetEAX2_EBX8_15_CacheAndTLBDescriptorInformation1();
                string eAX2_EBX8_15_CacheAndTLBDescriptorInformation1String = eAX2_EBX8_15_CacheAndTLBDescriptorInformation1Value.ToString();

                return eAX2_EBX8_15_CacheAndTLBDescriptorInformation1String;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX2_EBX16_23_CacheAndTLBDescriptorInformation2();

        public string GetEAX2_EBX16_23_CacheAndTLBDescriptorInformation2X()
        {
            try
            {
                int eAX2_EBX16_23_CacheAndTLBDescriptorInformation2Value = GetEAX2_EBX16_23_CacheAndTLBDescriptorInformation2();
                string eAX2_EBX16_23_CacheAndTLBDescriptorInformation2String = eAX2_EBX16_23_CacheAndTLBDescriptorInformation2Value.ToString();

                return eAX2_EBX16_23_CacheAndTLBDescriptorInformation2String;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX2_EBX24_31_CacheAndTLBDescriptorInformation3();

        public string GetEAX2_EBX24_31_CacheAndTLBDescriptorInformation3X()
        {
            try
            {
                int eAX2_EBX24_31_CacheAndTLBDescriptorInformation3Value = GetEAX2_EBX24_31_CacheAndTLBDescriptorInformation3();
                string eAX2_EBX24_31_CacheAndTLBDescriptorInformation3String = eAX2_EBX24_31_CacheAndTLBDescriptorInformation3Value.ToString();

                return eAX2_EBX24_31_CacheAndTLBDescriptorInformation3String;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX2_ECX31_IsInvalidCacheAndTblDescriptorsECX();

        public string GetEAX2_ECX31_IsInvalidCacheAndTblDescriptorsECXX()
        {
            try
            {
                int eAX2_ECX31_IsInvalidCacheAndTblDescriptorsECXValue = GetEAX2_ECX31_IsInvalidCacheAndTblDescriptorsECX();
                string eAX2_ECX31_IsInvalidCacheAndTblDescriptorsECXString = eAX2_ECX31_IsInvalidCacheAndTblDescriptorsECXValue.ToString();

                return eAX2_ECX31_IsInvalidCacheAndTblDescriptorsECXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX2_ECX8_15_CacheAndTLBDescriptorInformation1();

        public string GetEAX2_ECX8_15_CacheAndTLBDescriptorInformation1X()
        {
            try
            {
                int eAX2_ECX8_15_CacheAndTLBDescriptorInformation1Value = GetEAX2_ECX8_15_CacheAndTLBDescriptorInformation1();
                string eAX2_ECX8_15_CacheAndTLBDescriptorInformation1String = eAX2_ECX8_15_CacheAndTLBDescriptorInformation1Value.ToString();

                return eAX2_ECX8_15_CacheAndTLBDescriptorInformation1String;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX2_ECX16_23_CacheAndTLBDescriptorInformation2();

        public string GetEAX2_ECX16_23_CacheAndTLBDescriptorInformation2X()
        {
            try
            {
                int eAX2_ECX16_23_CacheAndTLBDescriptorInformation2Value = GetEAX2_ECX16_23_CacheAndTLBDescriptorInformation2();
                string eAX2_ECX16_23_CacheAndTLBDescriptorInformation2String = eAX2_ECX16_23_CacheAndTLBDescriptorInformation2Value.ToString();

                return eAX2_ECX16_23_CacheAndTLBDescriptorInformation2String;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX2_ECX24_31_CacheAndTLBDescriptorInformation3();

        public string GetEAX2_ECX24_31_CacheAndTLBDescriptorInformation3X()
        {
            try
            {
                int eAX2_ECX24_31_CacheAndTLBDescriptorInformation3Value = GetEAX2_ECX24_31_CacheAndTLBDescriptorInformation3();
                string eAX2_ECX24_31_CacheAndTLBDescriptorInformation3String = eAX2_ECX24_31_CacheAndTLBDescriptorInformation3Value.ToString();

                return eAX2_ECX24_31_CacheAndTLBDescriptorInformation3String;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX2_EDX31_IsInvalidCacheAndTblDescriptorsEDX();

        public string GetEAX2_EDX31_IsInvalidCacheAndTblDescriptorsEDXX()
        {
            try
            {
                int eAX2_EDX31_IsInvalidCacheAndTblDescriptorsEDXValue = GetEAX2_EDX31_IsInvalidCacheAndTblDescriptorsEDX();
                string eAX2_EDX31_IsInvalidCacheAndTblDescriptorsEDXString = eAX2_EDX31_IsInvalidCacheAndTblDescriptorsEDXValue.ToString();

                return eAX2_EDX31_IsInvalidCacheAndTblDescriptorsEDXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX2_EDX8_15_CacheAndTLBDescriptorInformation1();

        public string GetEAX2_EDX8_15_CacheAndTLBDescriptorInformation1X()
        {
            try
            {
                int eAX2_EDX8_15_CacheAndTLBDescriptorInformation1Value = GetEAX2_EDX8_15_CacheAndTLBDescriptorInformation1();
                string eAX2_EDX8_15_CacheAndTLBDescriptorInformation1String = eAX2_EDX8_15_CacheAndTLBDescriptorInformation1Value.ToString();

                return eAX2_EDX8_15_CacheAndTLBDescriptorInformation1String;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX2_EDX16_23_CacheAndTLBDescriptorInformation2();

        public string GetEAX2_EDX16_23_CacheAndTLBDescriptorInformation2X()
        {
            try
            {
                int eAX2_EDX16_23_CacheAndTLBDescriptorInformation2Value = GetEAX2_EDX16_23_CacheAndTLBDescriptorInformation2();
                string eAX2_EDX16_23_CacheAndTLBDescriptorInformation2String = eAX2_EDX16_23_CacheAndTLBDescriptorInformation2Value.ToString();

                return eAX2_EDX16_23_CacheAndTLBDescriptorInformation2String;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX2_EDX24_31_CacheAndTLBDescriptorInformation3();

        public string GetEAX2_EDX24_31_CacheAndTLBDescriptorInformation3X()
        {
            try
            {
                int eAX2_EDX24_31_CacheAndTLBDescriptorInformation3Value = GetEAX2_EDX24_31_CacheAndTLBDescriptorInformation3();
                string eAX2_EDX24_31_CacheAndTLBDescriptorInformation3String = eAX2_EDX24_31_CacheAndTLBDescriptorInformation3Value.ToString();

                return eAX2_EDX24_31_CacheAndTLBDescriptorInformation3String;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        #endregion

        #region EAX=0x3: Processor Serial Number

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX3EAX();

        public string GetEAX3EAXX()
        {
            try
            {
                IntPtr eAX3EAXPtr = GetEAX3EAX();
                string eAX3EAXString = Marshal.PtrToStringAnsi(eAX3EAXPtr);

                return eAX3EAXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX3EBX();

        public string GetEAX3EBXX()
        {
            try
            {
                IntPtr eAX3EBXPtr = GetEAX3EBX();
                string eAX3EBXString = Marshal.PtrToStringAnsi(eAX3EBXPtr);

                return eAX3EBXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX3ECX();

        public string GetEAX3ECXX()
        {
            try
            {
                IntPtr eAX3ECXPtr = GetEAX3ECX();
                string eAX3ECXString = Marshal.PtrToStringAnsi(eAX3ECXPtr);

                return eAX3ECXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX3EDX();

        public string GetEAX3EDXX()
        {
            try
            {
                IntPtr eAX3EDXPtr = GetEAX3EDX();
                string eAX3EDXString = Marshal.PtrToStringAnsi(eAX3EDXPtr);

                return eAX3EDXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX3_EAX_EDX_ECX_Pentium3CPU96BitSerialNumber();

        public string GetEAX3_EAX_EDX_ECX_Pentium3CPU96BitSerialNumberX()
        {
            try
            {
                IntPtr eAX3_EAX_EDX_ECX_Pentium3CPU96BitSerialNumberPtr = GetEAX3_EAX_EDX_ECX_Pentium3CPU96BitSerialNumber();
                string eAX3_EAX_EDX_ECX_Pentium3CPU96BitSerialNumberString = Marshal.PtrToStringAnsi(eAX3_EAX_EDX_ECX_Pentium3CPU96BitSerialNumberPtr);

                return eAX3_EAX_EDX_ECX_Pentium3CPU96BitSerialNumberString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX3_EAX_EDX_ECX_TransmetaCrusoeAndEfficeonCPU128BitSerialNumber();

        public string GetEAX3_EAX_EDX_ECX_TransmetaCrusoeAndEfficeonCPU128BitSerialNumberX()
        {
            try
            {
                IntPtr eAX3_EAX_EDX_ECX_TransmetaCrusoeAndEfficeonCPU128BitSerialNumberPtr = GetEAX3_EAX_EDX_ECX_TransmetaCrusoeAndEfficeonCPU128BitSerialNumber();
                string eAX3_EAX_EDX_ECX_TransmetaCrusoeAndEfficeonCPU128BitSerialNumberString = Marshal.PtrToStringAnsi(eAX3_EAX_EDX_ECX_TransmetaCrusoeAndEfficeonCPU128BitSerialNumberPtr);

                return eAX3_EAX_EDX_ECX_TransmetaCrusoeAndEfficeonCPU128BitSerialNumberString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        #endregion

        #region EAX=0x4 and EAX=0x8000001D: Cache Hierarchy and Topology

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX4EAX();

        public string GetEAX4EAXX()
        {
            try
            {
                IntPtr eAX4EAXPtr = GetEAX4EAX();
                string eAX4EAXString = Marshal.PtrToStringAnsi(eAX4EAXPtr);

                return eAX4EAXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX4EBX();

        public string GetEAX4EBXX()
        {
            try
            {
                IntPtr eAX4EBXPtr = GetEAX4EBX();
                string eAX4EBXString = Marshal.PtrToStringAnsi(eAX4EBXPtr);

                return eAX4EBXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX4ECX();

        public string GetEAX4ECXX()
        {
            try
            {
                IntPtr eAX4ECXPtr = GetEAX4ECX();
                string eAX4ECXString = Marshal.PtrToStringAnsi(eAX4ECXPtr);

                return eAX4ECXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX4EDX();

        public string GetEAX4EDXX()
        {
            try
            {
                IntPtr eAX4EDXPtr = GetEAX4EDX();
                string eAX4EDXString = Marshal.PtrToStringAnsi(eAX4EDXPtr);

                return eAX4EDXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX8000001DEAX();

        public string GetEAX8000001DEAXX()
        {
            try
            {
                IntPtr eAX8000001DEAXPtr = GetEAX8000001DEAX();
                string eAX8000001DEAXString = Marshal.PtrToStringAnsi(eAX8000001DEAXPtr);

                return eAX8000001DEAXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX8000001DEBX();

        public string GetEAX8000001DEBXX()
        {
            try
            {
                IntPtr eAX8000001DEBXPtr = GetEAX8000001DEBX();
                string eAX8000001DEBXString = Marshal.PtrToStringAnsi(eAX8000001DEBXPtr);

                return eAX8000001DEBXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX8000001DECX();

        public string GetEAX8000001DECXX()
        {
            try
            {
                IntPtr eAX8000001DECXPtr = GetEAX8000001DECX();
                string eAX8000001DECXString = Marshal.PtrToStringAnsi(eAX8000001DECXPtr);

                return eAX8000001DECXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX8000001DEDX();

        public string GetEAX8000001DEDXX()
        {
            try
            {
                IntPtr eAX8000001DEDXPtr = GetEAX8000001DEDX();
                string eAX8000001DEDXString = Marshal.PtrToStringAnsi(eAX8000001DEDXPtr);

                return eAX8000001DEDXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        #endregion

        #region EAX=0x4 and EAX=0xB: Intel Thread/Core and Cache Topology

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAXBEAX();

        public string GetEAXBEAXX()
        {
            try
            {
                IntPtr eAXBEAXPtr = GetEAXBEAX();
                string eAXBEAXString = Marshal.PtrToStringAnsi(eAXBEAXPtr);

                return eAXBEAXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAXBEBX();

        public string GetEAXBEBXX()
        {
            try
            {
                IntPtr eAXBEBXPtr = GetEAXBEBX();
                string eAXBEBXString = Marshal.PtrToStringAnsi(eAXBEBXPtr);

                return eAXBEBXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAXBECX();

        public string GetEAXBECXX()
        {
            try
            {
                IntPtr eAXBECXPtr = GetEAXBECX();
                string eAXBECXString = Marshal.PtrToStringAnsi(eAXBECXPtr);

                return eAXBECXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAXBEDX();

        public string GetEAXBEDXX()
        {
            try
            {
                IntPtr eAXBEDXPtr = GetEAXBEDX();
                string eAXBEDXString = Marshal.PtrToStringAnsi(eAXBEDXPtr);

                return eAXBEDXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        #endregion

        #region EAX=0x5: MONITOR/MWAIT Features

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX5EAX();

        public string GetEAX5EAXX()
        {
            try
            {
                IntPtr eAX5EAXPtr = GetEAX5EAX();
                string eAX5EAXString = Marshal.PtrToStringAnsi(eAX5EAXPtr);

                return eAX5EAXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX5EBX();

        public string GetEAX5EBXX()
        {
            try
            {
                IntPtr eAX5EBXPtr = GetEAX5EBX();
                string eAX5EBXString = Marshal.PtrToStringAnsi(eAX5EBXPtr);

                return eAX5EBXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX5ECX();

        public string GetEAX5ECXX()
        {
            try
            {
                IntPtr eAX5ECXPtr = GetEAX5ECX();
                string eAX5ECXString = Marshal.PtrToStringAnsi(eAX5ECXPtr);

                return eAX5ECXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX5EDX();

        public string GetEAX5EDXX()
        {
            try
            {
                IntPtr eAX5EDXPtr = GetEAX5EDX();
                string eAX5EDXString = Marshal.PtrToStringAnsi(eAX5EDXPtr);

                return eAX5EDXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX5_EAX0_15_SmallestMonitorLineSize();

        public string GetEAX5_EAX0_15_SmallestMonitorLineSizeX()
        {
            try
            {
                int eAX5_EAX0_15_SmallestMonitorLineSizeValue = GetEAX5_EAX0_15_SmallestMonitorLineSize();
                string eAX5_EAX0_15_SmallestMonitorLineSizeString = eAX5_EAX0_15_SmallestMonitorLineSizeValue.ToString();

                return eAX5_EAX0_15_SmallestMonitorLineSizeString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX5_EAX16_31_Reserved();

        public string GetEAX5_EAX16_31_ReservedX()
        {
            try
            {
                int eAX5_EAX16_31_ReservedValue = GetEAX5_EAX16_31_Reserved();
                string eAX5_EAX16_31_ReservedString = eAX5_EAX16_31_ReservedValue.ToString();

                return eAX5_EAX16_31_ReservedString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX5_EBX0_15_LargestMonitorLineSize();

        public string GetEAX5_EBX0_15_LargestMonitorLineSizeX()
        {
            try
            {
                int eAX5_EBX0_15_LargestMonitorLineSizeValue = GetEAX5_EBX0_15_LargestMonitorLineSize();
                string eAX5_EBX0_15_LargestMonitorLineSizeString = eAX5_EBX0_15_LargestMonitorLineSizeValue.ToString();

                return eAX5_EBX0_15_LargestMonitorLineSizeString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX5_EBX16_31_Reserved();

        public string GetEAX5_EBX16_31_ReservedX()
        {
            try
            {
                int eAX5_EBX16_31_ReservedValue = GetEAX5_EBX16_31_Reserved();
                string eAX5_EBX16_31_ReservedString = eAX5_EBX16_31_ReservedValue.ToString();

                return eAX5_EBX16_31_ReservedString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX5_ECX0_EnumOfMonitorMWAITExtensionsInECXAndEDXSupported_EMX();

        public string GetEAX5_ECX0_EnumOfMonitorMWAITExtensionsInECXAndEDXSupported_EMXX()
        {
            try
            {
                int eAX5_ECX0_EnumOfMonitorMWAITExtensionsInECXAndEDXSupported_EMXValue = GetEAX5_ECX0_EnumOfMonitorMWAITExtensionsInECXAndEDXSupported_EMX();
                string eAX5_ECX0_EnumOfMonitorMWAITExtensionsInECXAndEDXSupported_EMXString = eAX5_ECX0_EnumOfMonitorMWAITExtensionsInECXAndEDXSupported_EMXValue.ToString();

                return eAX5_ECX0_EnumOfMonitorMWAITExtensionsInECXAndEDXSupported_EMXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX5_ECX1_SupportsTreatingInterruptsAsBreakEventsForMWAITEvenWhenInterruptsAreDisabled_IBE();

        public string GetEAX5_ECX1_SupportsTreatingInterruptsAsBreakEventsForMWAITEvenWhenInterruptsAreDisabled_IBEX()
        {
            try
            {
                int eAX5_ECX1_SupportsTreatingInterruptsAsBreakEventsForMWAITEvenWhenInterruptsAreDisabled_IBEValue = GetEAX5_ECX1_SupportsTreatingInterruptsAsBreakEventsForMWAITEvenWhenInterruptsAreDisabled_IBE();
                string eAX5_ECX1_SupportsTreatingInterruptsAsBreakEventsForMWAITEvenWhenInterruptsAreDisabled_IBEString = eAX5_ECX1_SupportsTreatingInterruptsAsBreakEventsForMWAITEvenWhenInterruptsAreDisabled_IBEValue.ToString();

                return eAX5_ECX1_SupportsTreatingInterruptsAsBreakEventsForMWAITEvenWhenInterruptsAreDisabled_IBEString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX5_ECX2_Reserved();

        public string GetEAX5_ECX2_ReservedX()
        {
            try
            {
                int eAX5_ECX2_ReservedValue = GetEAX5_ECX2_Reserved();
                string eAX5_ECX2_ReservedString = eAX5_ECX2_ReservedValue.ToString();

                return eAX5_ECX2_ReservedString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX5_ECX3_AllowMWAITToBeUsedForPowerManagementWithoutSettingUpMemoryMonitoringWithMONITOR_Monitorless_MWAIT();

        public string GetEAX5_ECX3_AllowMWAITToBeUsedForPowerManagementWithoutSettingUpMemoryMonitoringWithMONITOR_Monitorless_MWAITX()
        {
            try
            {
                int eAX5_ECX3_AllowMWAITToBeUsedForPowerManagementWithoutSettingUpMemoryMonitoringWithMONITOR_Monitorless_MWAITValue = GetEAX5_ECX3_AllowMWAITToBeUsedForPowerManagementWithoutSettingUpMemoryMonitoringWithMONITOR_Monitorless_MWAIT();
                string eAX5_ECX3_AllowMWAITToBeUsedForPowerManagementWithoutSettingUpMemoryMonitoringWithMONITOR_Monitorless_MWAITString = eAX5_ECX3_AllowMWAITToBeUsedForPowerManagementWithoutSettingUpMemoryMonitoringWithMONITOR_Monitorless_MWAITValue.ToString();

                return eAX5_ECX3_AllowMWAITToBeUsedForPowerManagementWithoutSettingUpMemoryMonitoringWithMONITOR_Monitorless_MWAITString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX5_ECX4_31_Reserved();

        public string GetEAX5_ECX4_31_ReservedX()
        {
            try
            {
                int eAX5_ECX4_31_ReservedValue = GetEAX5_ECX4_31_Reserved();
                string eAX5_ECX4_31_ReservedString = eAX5_ECX4_31_ReservedValue.ToString();

                return eAX5_ECX4_31_ReservedString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX5_EDX0_3_NumberOfC0SubStatesSupportedForMWAIT();

        public string GetEAX5_EDX0_3_NumberOfC0SubStatesSupportedForMWAITX()
        {
            try
            {
                int eAX5_EDX0_3_NumberOfC0SubStatesSupportedForMWAITValue = GetEAX5_EDX0_3_NumberOfC0SubStatesSupportedForMWAIT();
                string eAX5_EDX0_3_NumberOfC0SubStatesSupportedForMWAITString = eAX5_EDX0_3_NumberOfC0SubStatesSupportedForMWAITValue.ToString();

                return eAX5_EDX0_3_NumberOfC0SubStatesSupportedForMWAITString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX5_EDX4_7_NumberOfC1SubStatesSupportedForMWAIT();

        public string GetEAX5_EDX4_7_NumberOfC1SubStatesSupportedForMWAITX()
        {
            try
            {
                int eAX5_EDX4_7_NumberOfC1SubStatesSupportedForMWAITValue = GetEAX5_EDX4_7_NumberOfC1SubStatesSupportedForMWAIT();
                string eAX5_EDX4_7_NumberOfC1SubStatesSupportedForMWAITString = eAX5_EDX4_7_NumberOfC1SubStatesSupportedForMWAITValue.ToString();

                return eAX5_EDX4_7_NumberOfC1SubStatesSupportedForMWAITString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX5_EDX8_11_NumberOfC2SubStatesSupportedForMWAIT();

        public string GetEAX5_EDX8_11_NumberOfC2SubStatesSupportedForMWAITX()
        {
            try
            {
                int eAX5_EDX8_11_NumberOfC2SubStatesSupportedForMWAITValue = GetEAX5_EDX8_11_NumberOfC2SubStatesSupportedForMWAIT();
                string eAX5_EDX8_11_NumberOfC2SubStatesSupportedForMWAITString = eAX5_EDX8_11_NumberOfC2SubStatesSupportedForMWAITValue.ToString();

                return eAX5_EDX8_11_NumberOfC2SubStatesSupportedForMWAITString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX5_EDX12_15_NumberOfC3SubStatesSupportedForMWAIT();

        public string GetEAX5_EDX12_15_NumberOfC3SubStatesSupportedForMWAITX()
        {
            try
            {
                int eAX5_EDX12_15_NumberOfC3SubStatesSupportedForMWAITValue = GetEAX5_EDX12_15_NumberOfC3SubStatesSupportedForMWAIT();
                string eAX5_EDX12_15_NumberOfC3SubStatesSupportedForMWAITString = eAX5_EDX12_15_NumberOfC3SubStatesSupportedForMWAITValue.ToString();

                return eAX5_EDX12_15_NumberOfC3SubStatesSupportedForMWAITString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX5_EDX16_19_NumberOfC4SubStatesSupportedForMWAIT();

        public string GetEAX5_EDX16_19_NumberOfC4SubStatesSupportedForMWAITX()
        {
            try
            {
                int eAX5_EDX16_19_NumberOfC4SubStatesSupportedForMWAITValue = GetEAX5_EDX16_19_NumberOfC4SubStatesSupportedForMWAIT();
                string eAX5_EDX16_19_NumberOfC4SubStatesSupportedForMWAITString = eAX5_EDX16_19_NumberOfC4SubStatesSupportedForMWAITValue.ToString();

                return eAX5_EDX16_19_NumberOfC4SubStatesSupportedForMWAITString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX5_EDX20_23_NumberOfC5SubStatesSupportedForMWAIT();

        public string GetEAX5_EDX20_23_NumberOfC5SubStatesSupportedForMWAITX()
        {
            try
            {
                int eAX5_EDX20_23_NumberOfC5SubStatesSupportedForMWAITValue = GetEAX5_EDX20_23_NumberOfC5SubStatesSupportedForMWAIT();
                string eAX5_EDX20_23_NumberOfC5SubStatesSupportedForMWAITString = eAX5_EDX20_23_NumberOfC5SubStatesSupportedForMWAITValue.ToString();

                return eAX5_EDX20_23_NumberOfC5SubStatesSupportedForMWAITString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX5_EDX24_27_NumberOfC6SubStatesSupportedForMWAIT();

        public string GetEAX5_EDX24_27_NumberOfC6SubStatesSupportedForMWAITX()
        {
            try
            {
                int eAX5_EDX24_27_NumberOfC6SubStatesSupportedForMWAITValue = GetEAX5_EDX24_27_NumberOfC6SubStatesSupportedForMWAIT();
                string eAX5_EDX24_27_NumberOfC6SubStatesSupportedForMWAITString = eAX5_EDX24_27_NumberOfC6SubStatesSupportedForMWAITValue.ToString();

                return eAX5_EDX24_27_NumberOfC6SubStatesSupportedForMWAITString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX5_EDX28_31_NumberOfC7SubStatesSupportedForMWAIT();

        public string GetEAX5_EDX28_31_NumberOfC7SubStatesSupportedForMWAITX()
        {
            try
            {
                int eAX5_EDX28_31_NumberOfC7SubStatesSupportedForMWAITValue = GetEAX5_EDX28_31_NumberOfC7SubStatesSupportedForMWAIT();
                string eAX5_EDX28_31_NumberOfC7SubStatesSupportedForMWAITString = eAX5_EDX28_31_NumberOfC7SubStatesSupportedForMWAITValue.ToString();

                return eAX5_EDX28_31_NumberOfC7SubStatesSupportedForMWAITString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        #endregion

        #region region EAX=0x6: Thermal and Power Management

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX6EAX();

        public string GetEAX6EAXX()
        {
            try
            {
                IntPtr eAX6EAXPtr = GetEAX6EAX();
                string eAX6EAXString = Marshal.PtrToStringAnsi(eAX6EAXPtr);

                return eAX6EAXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX6EBX();

        public string GetEAX6EBXX()
        {
            try
            {
                IntPtr eAX6EBXPtr = GetEAX6EBX();
                string eAX6EBXString = Marshal.PtrToStringAnsi(eAX6EBXPtr);

                return eAX6EBXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX6ECX();

        public string GetEAX6ECXX()
        {
            try
            {
                IntPtr eAX6ECXPtr = GetEAX6ECX();
                string eAX6ECXString = Marshal.PtrToStringAnsi(eAX6ECXPtr);

                return eAX6ECXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX6EDX();

        public string GetEAX6EDXX()
        {
            try
            {
                IntPtr eAX6EDXPtr = GetEAX6EDX();
                string eAX6EDXString = Marshal.PtrToStringAnsi(eAX6EDXPtr);

                return eAX6EDXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX0_DTSIsSupported();

        public bool GetEAX6EAX0_DTSIsSupportedX()
        {
            try
            {
                return GetEAX6EAX0_DTSIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. DTS support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for DTS support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX1_TURBO_BOOSTIsSupported();

        public bool GetEAX6EAX1_TURBO_BOOSTIsSupportedX()
        {
            try
            {
                return GetEAX6EAX1_TURBO_BOOSTIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. TURBO BOOST support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for TURBO BOOST support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX2_ARATIsSupported();

        public bool GetEAX6EAX2_ARATIsSupportedX()
        {
            try
            {
                return GetEAX6EAX2_ARATIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. ARAT support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for ARAT support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX3_ReservedIsSupported();

        public bool GetEAX6EAX3_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX6EAX3_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX4_PowerLimitNotificationCapability_PLNIsSupported();

        public bool GetEAX6EAX4_PowerLimitNotificationCapability_PLNIsSupportedX()
        {
            try
            {
                return GetEAX6EAX4_PowerLimitNotificationCapability_PLNIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Power Limit Notification capability (PLN) support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Power Limit Notification capability (PLN) support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX5_ExtendedClockModulationDutyCapability_ECMDIsSupported();

        public bool GetEAX6EAX5_ExtendedClockModulationDutyCapability_ECMDIsSupportedX()
        {
            try
            {
                return GetEAX6EAX5_ExtendedClockModulationDutyCapability_ECMDIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Extended Clock Modulation Duty capability (ECMD) support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Extended Clock Modulation Duty capability (ECMD) support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX6_PackageThermalManagementCapability_PTMIsSupported();

        public bool GetEAX6EAX6_PackageThermalManagementCapability_PTMIsSupportedX()
        {
            try
            {
                return GetEAX6EAX6_PackageThermalManagementCapability_PTMIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Package Thermal Management capability (PTM) support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Package Thermal Management capability (PTM) support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX7_HardwareControlledPerformanceStatesCapability_HWPIsSupported();

        public bool GetEAX6EAX7_HardwareControlledPerformanceStatesCapability_HWPIsSupportedX()
        {
            try
            {
                return GetEAX6EAX7_HardwareControlledPerformanceStatesCapability_HWPIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Hardware Controlled Performance States capability (HWP) support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Hardware Controlled Performance States capability (HWP) support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX8_HWPNotificationCapability_HWP_NotificationIsSupported();

        public bool GetEAX6EAX8_HWPNotificationCapability_HWP_NotificationIsSupportedX()
        {
            try
            {
                return GetEAX6EAX8_HWPNotificationCapability_HWP_NotificationIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Hardware Controlled Performance States capability (HWP) notification support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Hardware Controlled Performance States capability (HWP) notification support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX9_HWPActivityWindowCapability_HWP_Activity_WindowIsSupported();

        public bool GetEAX6EAX9_HWPActivityWindowCapability_HWP_Activity_WindowIsSupportedX()
        {
            try
            {
                return GetEAX6EAX9_HWPActivityWindowCapability_HWP_Activity_WindowIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Hardware Controlled Performance States capability (HWP) activity window support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Hardware Controlled Performance States capability (HWP) activity window support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX10_HWPEnergyPerformancePreferenceCapability_HWP_Energy_Performance_PreferenceIsSupported();

        public bool GetEAX6EAX10_HWPEnergyPerformancePreferenceCapability_HWP_Energy_Performance_PreferenceIsSupportedX()
        {
            try
            {
                return GetEAX6EAX10_HWPEnergyPerformancePreferenceCapability_HWP_Energy_Performance_PreferenceIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Hardware Controlled Performance States capability (HWP) energy performance preference support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Hardware Controlled Performance States capability (HWP) energy performance preference support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX11_HWPPackageLevelRequestCapability_HWP_Package_Level_RequestIsSupported();

        public bool GetEAX6EAX11_HWPPackageLevelRequestCapability_HWP_Package_Level_RequestIsSupportedX()
        {
            try
            {
                return GetEAX6EAX11_HWPPackageLevelRequestCapability_HWP_Package_Level_RequestIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Hardware Controlled Performance States capability (HWP) package level request support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Hardware Controlled Performance States capability (HWP) package level request support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX12_ReservedIsSupported();

        public bool GetEAX6EAX12_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX6EAX12_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX13_HardwareDutyCyclingCapability_HDCIsSupported();

        public bool GetEAX6EAX13_HardwareDutyCyclingCapability_HDCIsSupportedX()
        {
            try
            {
                return GetEAX6EAX13_HardwareDutyCyclingCapability_HDCIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Hardware Duty Cycling capability (HDC) support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Hardware Duty Cycling capability (HDC) support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX14_IntelTurboBoostMaxTechnology30Availability_TURBO_BOOST_MAXIsSupported();

        public bool GetEAX6EAX14_IntelTurboBoostMaxTechnology30Availability_TURBO_BOOST_MAXIsSupportedX()
        {
            try
            {
                return GetEAX6EAX14_IntelTurboBoostMaxTechnology30Availability_TURBO_BOOST_MAXIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Intel Turbo Boost Max Technology 3.0 availability (TURBO_BOOST_MAX) support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Intel Turbo Boost Max Technology 3.0 availability (TURBO_BOOST_MAX) support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX15_HWP_CAPIsSupported();

        public bool GetEAX6EAX15_HWP_CAPIsSupportedX()
        {
            try
            {
                return GetEAX6EAX15_HWP_CAPIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. HWP_CAP support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for HWP_CAP support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX16_HWP_PECI_OVERRIDEIsSupported();

        public bool GetEAX6EAX16_HWP_PECI_OVERRIDEIsSupportedX()
        {
            try
            {
                return GetEAX6EAX16_HWP_PECI_OVERRIDEIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. HWP_PECI_OVERRIDE support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for HWP_PECI_OVERRIDE support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX17_FlexibleHWPIsSupported();

        public bool GetEAX6EAX17_FlexibleHWPIsSupportedX()
        {
            try
            {
                return GetEAX6EAX17_FlexibleHWPIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Flexible HWP support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Flexible HWP support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX18_HWP_REQUEST_FAST_ACCESSIsSupported();

        public bool GetEAX6EAX18_HWP_REQUEST_FAST_ACCESSIsSupportedX()
        {
            try
            {
                return GetEAX6EAX18_HWP_REQUEST_FAST_ACCESSIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. HWP_REQUEST_FAST_ACCESS support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for HWP_REQUEST_FAST_ACCESS support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX19_HW_FEEDBACKIsSupported();

        public bool GetEAX6EAX19_HW_FEEDBACKIsSupportedX()
        {
            try
            {
                return GetEAX6EAX19_HW_FEEDBACKIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. HW_FEEDBACK support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for HW_FEEDBACK support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX20_HWP_REQUEST_IGNORE_IDLEIsSupported();

        public bool GetEAX6EAX20_HWP_REQUEST_IGNORE_IDLEIsSupportedX()
        {
            try
            {
                return GetEAX6EAX20_HWP_REQUEST_IGNORE_IDLEIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. HWP_REQUEST_IGNORE_IDLE support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for HWP_REQUEST_IGNORE_IDLE support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX21_ReservedIsSupported();

        public bool GetEAX6EAX21_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX6EAX21_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX22_HWP_CTLIsSupported();

        public bool GetEAX6EAX22_HWP_CTLIsSupportedX()
        {
            try
            {
                return GetEAX6EAX22_HWP_CTLIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. HWP_CTL support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for HWP_CTL support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX23_THREAD_DIRECTORIsSupported();

        public bool GetEAX6EAX23_THREAD_DIRECTORIsSupportedX()
        {
            try
            {
                return GetEAX6EAX23_THREAD_DIRECTORIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. THREAD_DIRECTOR support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for THREAD_DIRECTOR support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX24_IA32_THERM_INTERRUPTIsSupported();

        public bool GetEAX6EAX24_IA32_THERM_INTERRUPTIsSupportedX()
        {
            try
            {
                return GetEAX6EAX24_IA32_THERM_INTERRUPTIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. IA32_THERM_INTERRUPT support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for IA32_THERM_INTERRUPT support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX25_ReservedIsSupported();

        public bool GetEAX6EAX25_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX6EAX25_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX26_ReservedIsSupported();

        public bool GetEAX6EAX26_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX6EAX26_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX27_ReservedIsSupported();

        public bool GetEAX6EAX27_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX6EAX27_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX28_ReservedIsSupported();

        public bool GetEAX6EAX28_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX6EAX28_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX29_ReservedIsSupported();

        public bool GetEAX6EAX29_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX6EAX29_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX30_ReservedIsSupported();

        public bool GetEAX6EAX30_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX6EAX30_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EAX31_ReservedIsSupported();

        public bool GetEAX6EAX31_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX6EAX31_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        #region Thermal / power management feature fields in EBX, ECX and EDX.

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX6_EBX0_3_NumberOfInterruptThresholdsInDigitalThermalSensor();

        public string GetEAX6_EBX0_3_NumberOfInterruptThresholdsInDigitalThermalSensorX()
        {
            try
            {
                int eAX6_EBX0_3_NumberOfInterruptThresholdsInDigitalThermalSensorValue = GetEAX6_EBX0_3_NumberOfInterruptThresholdsInDigitalThermalSensor();
                string eAX6_EBX0_3_NumberOfInterruptThresholdsInDigitalThermalSensorString = eAX6_EBX0_3_NumberOfInterruptThresholdsInDigitalThermalSensorValue.ToString();

                return eAX6_EBX0_3_NumberOfInterruptThresholdsInDigitalThermalSensorString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX6_EBX4_31_Reserved();

        public string GetEAX6_EBX4_31_ReservedX()
        {
            try
            {
                int eAX6_EBX4_31_ReservedValue = GetEAX6_EBX4_31_Reserved();
                string eAX6_EBX4_31_ReservedString = eAX6_EBX4_31_ReservedValue.ToString();

                return eAX6_EBX4_31_ReservedString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6ECX0_EffectiveFrequencyInterfaceIsSupported();

        public bool GetEAX6ECX0_EffectiveFrequencyInterfaceIsSupportedX()
        {
            try
            {
                return GetEAX6ECX0_EffectiveFrequencyInterfaceIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Effective Frequency Interface support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Effective Frequency Interface support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6ECX1_ACNT2CapabilityIsSupported();

        public bool GetEAX6ECX1_ACNT2CapabilityIsSupportedX()
        {
            try
            {
                return GetEAX6ECX1_ACNT2CapabilityIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. ACNT2 Capability support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for ACNT2 Capability support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6ECX2_ReservedIsSupported();

        public bool GetEAX6ECX2_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX6ECX2_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved feature support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved feature support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6ECX3_PerformanceEnergyBiasCapabilityMSRIsSupported();

        public bool GetEAX6ECX3_PerformanceEnergyBiasCapabilityMSRIsSupportedX()
        {
            try
            {
                return GetEAX6ECX3_PerformanceEnergyBiasCapabilityMSRIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Performance Energy Bias Capability MSR support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Performance Energy Bias Capability MSR support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX6ECX4_7_Reserved();

        public string GetEAX6ECX4_7_ReservedX()
        {
            try
            {
                int eAX6ECX4_7_ReservedValue = GetEAX6ECX4_7_Reserved();
                string eAX6ECX4_7_ReservedString = eAX6ECX4_7_ReservedValue.ToString();

                return eAX6ECX4_7_ReservedString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX6ECX8_15_NumberOfIntelThreadDirectorClasses();

        public string GetEAX6ECX8_15_NumberOfIntelThreadDirectorClassesX()
        {
            try
            {
                int eAX6ECX8_15_NumberOfIntelThreadDirectorClassesValue = GetEAX6ECX8_15_NumberOfIntelThreadDirectorClasses();
                string eAX6ECX8_15_NumberOfIntelThreadDirectorClassesString = eAX6ECX8_15_NumberOfIntelThreadDirectorClassesValue.ToString();

                return eAX6ECX8_15_NumberOfIntelThreadDirectorClassesString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX6ECX16_31_Reserved();

        public string GetEAX6ECX16_31_ReservedX()
        {
            try
            {
                int eAX6ECX16_31_ReservedValue = GetEAX6ECX16_31_Reserved();
                string eAX6ECX16_31_ReservedString = eAX6ECX16_31_ReservedValue.ToString();

                return eAX6ECX16_31_ReservedString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EDX0_HardwareFeedbackReportingPerformanceCapabilityReportingIsSupported();

        public bool GetEAX6EDX0_HardwareFeedbackReportingPerformanceCapabilityReportingIsSupportedX()
        {
            try
            {
                return GetEAX6EDX0_HardwareFeedbackReportingPerformanceCapabilityReportingIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Hardware Feedback Reporting Performance Capability Reporting support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Hardware Feedback Reporting Performance Capability Reporting support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX6EDX1_HardwareFeedbackReportingEfficiencyCapabilityReportingIsSupported();

        public bool GetEAX6EDX1_HardwareFeedbackReportingEfficiencyCapabilityReportingIsSupportedX()
        {
            try
            {
                return GetEAX6EDX1_HardwareFeedbackReportingEfficiencyCapabilityReportingIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Hardware Feedback Reporting Efficiency Capability Reporting support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Hardware Feedback Reporting Efficiency Capability Reporting support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX6EDX2_7_Reserved();

        public string GetEAX6EDX2_7_ReservedX()
        {
            try
            {
                int eAX6EDX2_7_ReservedValue = GetEAX6EDX2_7_Reserved();
                string eAX6EDX2_7_ReservedString = eAX6EDX2_7_ReservedValue.ToString();

                return eAX6EDX2_7_ReservedString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX6EDX8_11_SizeOfHardwareFeedbackInterfaceStructure();

        public string GetEAX6EDX8_11_SizeOfHardwareFeedbackInterfaceStructureX()
        {
            try
            {
                int eAX6EDX8_11_SizeOfHardwareFeedbackInterfaceStructureValue = GetEAX6EDX8_11_SizeOfHardwareFeedbackInterfaceStructure();
                string eAX6EDX8_11_SizeOfHardwareFeedbackInterfaceStructureString = eAX6EDX8_11_SizeOfHardwareFeedbackInterfaceStructureValue.ToString();

                return eAX6EDX8_11_SizeOfHardwareFeedbackInterfaceStructureString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX6EDX12_15_Reserved();

        public string GetEAX6EDX12_15_ReservedX()
        {
            try
            {
                int eAX6EDX12_15_ReservedValue = GetEAX6EDX12_15_Reserved();
                string eAX6EDX12_15_ReservedString = eAX6EDX12_15_ReservedValue.ToString();

                return eAX6EDX12_15_ReservedString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEAX6EDX16_31_IndexOfThisLogicalProcessorsRowInHardwareFeedbackInterfaceStructure();

        public string GetEAX6EDX16_31_IndexOfThisLogicalProcessorsRowInHardwareFeedbackInterfaceStructureX()
        {
            try
            {
                int eAX6EDX16_31_IndexOfThisLogicalProcessorsRowInHardwareFeedbackInterfaceStructureValue = GetEAX6EDX16_31_IndexOfThisLogicalProcessorsRowInHardwareFeedbackInterfaceStructure();
                string eAX6EDX16_31_IndexOfThisLogicalProcessorsRowInHardwareFeedbackInterfaceStructureString = eAX6EDX16_31_IndexOfThisLogicalProcessorsRowInHardwareFeedbackInterfaceStructureValue.ToString();

                return eAX6EDX16_31_IndexOfThisLogicalProcessorsRowInHardwareFeedbackInterfaceStructureString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        #endregion
        #endregion

        #region region EAX=0x7, ECX=0x0: Extended Features

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX7ECX0EAX();

        public string GetEAX7ECX0EAXX()
        {
            try
            {
                IntPtr eAX7ECX0EAXPtr = GetEAX7ECX0EAX();
                string eAX7ECX0EAXString = Marshal.PtrToStringAnsi(eAX7ECX0EAXPtr);

                return eAX7ECX0EAXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX7ECX0EBX();

        public string GetEAX7ECX0EBXX()
        {
            try
            {
                IntPtr eAX7ECX0EBXPtr = GetEAX7ECX0EBX();
                string eAX7ECX0EBXString = Marshal.PtrToStringAnsi(eAX7ECX0EBXPtr);

                return eAX7ECX0EBXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX7ECX0ECX();

        public string GetEAX7ECX0ECXX()
        {
            try
            {
                IntPtr eAX7ECX0ECXPtr = GetEAX7ECX0ECX();
                string eAX7ECX0ECXString = Marshal.PtrToStringAnsi(eAX7ECX0ECXPtr);

                return eAX7ECX0ECXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX7ECX0EDX();

        public string GetEAX7ECX0EDXX()
        {
            try
            {
                IntPtr eAX7ECX0EDXPtr = GetEAX7ECX0EDX();
                string eAX7ECX0EDXString = Marshal.PtrToStringAnsi(eAX7ECX0EDXPtr);

                return eAX7ECX0EDXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX0_FSGSBaseIsSupported();

        public bool GetEAX7ECX0_EBX0_FSGSBaseIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX0_FSGSBaseIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. FSGSBase support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for FSGSBase support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX1_TSCAdjustIsSupported();

        public bool GetEAX7ECX0_EBX1_TSCAdjustIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX1_TSCAdjustIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. TSC Adjust support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for TSC Adjust support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX2_SGXIsSupported();

        public bool GetEAX7ECX0_EBX2_SGXIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX2_SGXIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. SGX support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for SGX support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX3_BMI1IsSupported();

        public bool GetEAX7ECX0_EBX3_BMI1IsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX3_BMI1IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. BMI1 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for BMI1 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX4_HLEIsSupported();

        public bool GetEAX7ECX0_EBX4_HLEIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX4_HLEIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. HLE support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for HLE support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX5_AVX2IsSupported();

        public bool GetEAX7ECX0_EBX5_AVX2IsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX5_AVX2IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. AVX2 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AVX2 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX6_FDPExcptnOnlyIsSupported();

        public bool GetEAX7ECX0_EBX6_FDPExcptnOnlyIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX6_FDPExcptnOnlyIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. FDP exception-only support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for FDP exception-only support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX7_SMEPIsSupported();

        public bool GetEAX7ECX0_EBX7_SMEPIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX7_SMEPIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. SMEP support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for SMEP support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX8_BMI2IsSupported();

        public bool GetEAX7ECX0_EBX8_BMI2IsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX8_BMI2IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. BMI2 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for BMI2 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX9_ERMSIsSupported();

        public bool GetEAX7ECX0_EBX9_ERMSIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX9_ERMSIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. ERMS support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for ERMS support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX10_INVPCIDIsSupported();

        public bool GetEAX7ECX0_EBX10_INVPCIDIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX10_INVPCIDIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. INVPCID support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for INVPCID support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX11_RTMIsSupported();

        public bool GetEAX7ECX0_EBX11_RTMIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX11_RTMIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. RTM support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for RTM support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX12_RDTMIsSupported();

        public bool GetEAX7ECX0_EBX12_RDTMIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX12_RDTMIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. RDTM support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for RDTM support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX13_FCSFDSDeprecationIsSupported();

        public bool GetEAX7ECX0_EBX13_FCSFDSDeprecationIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX13_FCSFDSDeprecationIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. FCSFDSDeprecation support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for FCSFDSDeprecation support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX14_MPXIsSupported();

        public bool GetEAX7ECX0_EBX14_MPXIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX14_MPXIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. MPX support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for MPX support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX15_RDTAIsSupported();

        public bool GetEAX7ECX0_EBX15_RDTAIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX15_RDTAIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. RDTA support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for RDTA support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX16_AVX512FIsSupported();

        public bool GetEAX7ECX0_EBX16_AVX512FIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX16_AVX512FIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. AVX512F support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AVX512F support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX17_AVX512DQIsSupported();

        public bool GetEAX7ECX0_EBX17_AVX512DQIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX17_AVX512DQIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. AVX512DQ support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AVX512DQ support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX18_RDSEEDIsSupported();

        public bool GetEAX7ECX0_EBX18_RDSEEDIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX18_RDSEEDIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. RDSEED support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for RDSEED support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX19_ADXIsSupported();

        public bool GetEAX7ECX0_EBX19_ADXIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX19_ADXIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. ADX support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for ADX support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX20_SMAPIsSupported();

        public bool GetEAX7ECX0_EBX20_SMAPIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX20_SMAPIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. SMAPIsSupported support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for SMAPIsSupported support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX21_AVX512IFMAIsSupported();

        public bool GetEAX7ECX0_EBX21_AVX512IFMAIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX21_AVX512IFMAIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. AVX512IFMA support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AVX512IFMA support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX22_PCOMMITIsSupported();

        public bool GetEAX7ECX0_EBX22_PCOMMITIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX22_PCOMMITIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. PCOMMIT support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for PCOMMIT support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX23_CLFLUSHOPTIsSupported();

        public bool GetEAX7ECX0_EBX23_CLFLUSHOPTIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX23_CLFLUSHOPTIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CLFLUSHOPT support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CLFLUSHOPT support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX24_CLWBIsSupported();

        public bool GetEAX7ECX0_EBX24_CLWBIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX24_CLWBIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CLWB support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CLWB support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX25_PTIsSupported();

        public bool GetEAX7ECX0_EBX25_PTIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX25_PTIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. PT support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for PT support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX26_AVX512PFIsSupported();

        public bool GetEAX7ECX0_EBX26_AVX512PFIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX26_AVX512PFIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. AVX512PF support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AVX512PF support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX27_AVX512ERIsSupported();

        public bool GetEAX7ECX0_EBX27_AVX512ERIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX27_AVX512ERIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. AVX512ER support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AVX512ER support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX28_AVX512CDIsSupported();

        public bool GetEAX7ECX0_EBX28_AVX512CDIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX28_AVX512CDIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. AVX512CD support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AVX512CD support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX29_SHAIsSupported();

        public bool GetEAX7ECX0_EBX29_SHAIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX29_SHAIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. SHA support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for SHA support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX30_AVX512BWIsSupported();

        public bool GetEAX7ECX0_EBX30_AVX512BWIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX30_AVX512BWIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. AVX512BW support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AVX512BW support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EBX31_AVX512VLIsSupported();

        public bool GetEAX7ECX0_EBX31_AVX512VLIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EBX31_AVX512VLIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. AVX512VL support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AVX512VL support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX0_PREFETCHWT1IsSupported();

        public bool GetEAX7ECX0_ECX0_PREFETCHWT1IsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_ECX0_PREFETCHWT1IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. PREFETCHWT1 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for PREFETCHWT1 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX1_AVX512VBMIIsSupported();

        public bool GetEAX7ECX0_ECX1_AVX512VBMIIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_ECX1_AVX512VBMIIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. AVX512VBMI support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AVX512VBMI support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX2_UMIPIsSupported();

        public bool GetEAX7ECX0_ECX2_UMIPIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_ECX2_UMIPIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. UMPI support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for UMPI support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX3_PKUIsSupported();

        public bool GetEAX7ECX0_ECX3_PKUIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_ECX3_PKUIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. PCK support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for PCK support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX4_OSPKEIsSupported();

        public bool GetEAX7ECX0_ECX4_OSPKEIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_ECX4_OSPKEIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. OSPKE support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for OSPKE support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX5_WAITPKGIsSupported();

        public bool GetEAX7ECX0_ECX5_WAITPKGIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_ECX5_WAITPKGIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. WAITPKG support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for WAITPKG support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX6_AVX512VBMI2IsSupported();

        public bool GetEAX7ECX0_ECX6_AVX512VBMI2IsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_ECX6_AVX512VBMI2IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. AVX512VBMI2 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AVX512VBMI2 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX7_CETSSIsSupported();

        public bool GetEAX7ECX0_ECX7_CETSSIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_ECX7_CETSSIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CETSS support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CETSS support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX8_GFNIIsSupported();

        public bool GetEAX7ECX0_ECX8_GFNIIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_ECX8_GFNIIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. GFNI support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for GFNI support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX9_VAESIsSupported();

        public bool GetEAX7ECX0_ECX9_VAESIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_ECX9_VAESIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. VAES support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for VAES support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX10_VPCLMULQDQIsSupported();

        public bool GetEAX7ECX0_ECX10_VPCLMULQDQIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_ECX10_VPCLMULQDQIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. VPCLMULQDQ support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for VPCLMULQDQ support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX11_AVX512VNNIIsSupported();

        public bool GetEAX7ECX0_ECX11_AVX512VNNIIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_ECX11_AVX512VNNIIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. AVX512VNNI support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AVX512VNNI support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX12_AVX512BITALGIsSupported();

        public bool GetEAX7ECX0_ECX12_AVX512BITALGIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_ECX12_AVX512BITALGIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. AVX512BITALG support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AVX512BITALG support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX13_TME_ENIsSupported();

        public bool GetEAX7ECX0_ECX13_TME_ENIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_ECX13_TME_ENIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. TME_EN support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for TME_EN support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX14_AVX512VPOPCNTDQIsSupported();

        public bool GetEAX7ECX0_ECX14_AVX512VPOPCNTDQIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_ECX14_AVX512VPOPCNTDQIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. AVX512VPOPCNTDQ support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AVX512VPOPCNTDQ support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX15_FZMIsSupported();

        public bool GetEAX7ECX0_ECX15_FZMIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_ECX15_FZMIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. FZM support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for FZM support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX16_LA57IsSupported();

        public bool GetEAX7ECX0_ECX16_LA57IsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_ECX16_LA57IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. LA57 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for LA57 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX17_MAWAUIsSupported1();

        public bool GetEAX7ECX0_ECX17_MAWAUIsSupported1X()
        {
            try
            {
                return GetEAX7ECX0_ECX17_MAWAUIsSupported1() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. MAWAU support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for MAWAU support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX18_MAWAUIsSupported2();

        public bool GetEAX7ECX0_ECX18_MAWAUIsSupported2X()
        {
            try
            {
                return GetEAX7ECX0_ECX18_MAWAUIsSupported2() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. MAWAU support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for MAWAU support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX19_MAWAUIsSupported3();

        public bool GetEAX7ECX0_ECX19_MAWAUIsSupported3X()
        {
            try
            {
                return GetEAX7ECX0_ECX19_MAWAUIsSupported3() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. MAWAU support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for MAWAU support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX20_MAWAUIsSupported4();

        public bool GetEAX7ECX0_ECX20_MAWAUIsSupported4X()
        {
            try
            {
                return GetEAX7ECX0_ECX20_MAWAUIsSupported4() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. MAWAU support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for MAWAU support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX21_MAWAUIsSupported5();

        public bool GetEAX7ECX0_ECX21_MAWAUIsSupported5X()
        {
            try
            {
                return GetEAX7ECX0_ECX21_MAWAUIsSupported5() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. MAWAU support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for MAWAU support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX22_RDPIDIsSupported();

        public bool GetEAX7ECX0_ECX22_RDPIDIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_ECX22_RDPIDIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. RDPID support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for RDPID support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX23_KLIsSupported();

        public bool GetEAX7ECX0_ECX23_KLIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_ECX23_KLIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. KL support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for KL support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX24_BusLockDetectIsSupported();

        public bool GetEAX7ECX0_ECX24_BusLockDetectIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_ECX24_BusLockDetectIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Bus Lock Detect support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Bus Lock Detect support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX25_CLDEMOTEIsSupported();

        public bool GetEAX7ECX0_ECX25_CLDEMOTEIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_ECX25_CLDEMOTEIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CLDEMOTE support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CLDEMOTE support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX26_MPRRIsSupported();

        public bool GetEAX7ECX0_ECX26_MPRRIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_ECX26_MPRRIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. MPRR support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for MPRR support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX27_MOVDIRIIsSupported();

        public bool GetEAX7ECX0_ECX27_MOVDIRIIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_ECX27_MOVDIRIIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. MOVDIRI support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for MOVDIRI support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX28_MOVDIR64BIsSupported();

        public bool GetEAX7ECX0_ECX28_MOVDIR64BIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_ECX28_MOVDIR64BIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. MOVDIR64B support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for MOVDIR64B support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX29_ENQCMDIsSupported();

        public bool GetEAX7ECX0_ECX29_ENQCMDIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_ECX29_ENQCMDIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. ENQCMD support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for ENQCMD support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX30_SGXLcIsSupported();

        public bool GetEAX7ECX0_ECX30_SGXLcIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_ECX30_SGXLcIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. SGXLc support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for SGXLc support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_ECX31_PKSIsSupported();

        public bool GetEAX7ECX0_ECX31_PKSIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_ECX31_PKSIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. PKS support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for PKS support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX0_SGXTEMIsSupported();

        public bool GetEAX7ECX0_EDX0_SGXTEMIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX0_SGXTEMIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. SGXTEM support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for SGXTEM support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX1_SGXKEYIsSupported();

        public bool GetEAX7ECX0_EDX1_SGXKEYIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX1_SGXKEYIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. SGXKEY support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for SGXKEY support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX2_AVX5124VNNIIsSupported();

        public bool GetEAX7ECX0_EDX2_AVX5124VNNIIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX2_AVX5124VNNIIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. AVX5124VNNI support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AVX5124VNNI support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX3_AVX5124FMAPSIsSupported();

        public bool GetEAX7ECX0_EDX3_AVX5124FMAPSIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX3_AVX5124FMAPSIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. AVX5124FMAPS support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AVX5124FMAPS support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX4_FSRMIsSupported();

        public bool GetEAX7ECX0_EDX4_FSRMIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX4_FSRMIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. FSRM support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for FSRM support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX5_UINTRIsSupported();

        public bool GetEAX7ECX0_EDX5_UINTRIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX5_UINTRIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. UINTR support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for UINTR support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX6_ReservedIsSupported();

        public bool GetEAX7ECX0_EDX6_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX6_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX7_ReservedIsSupported();

        public bool GetEAX7ECX0_EDX7_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX7_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX8_AVX512VP2INTERSECTIsSupported();

        public bool GetEAX7ECX0_EDX8_AVX512VP2INTERSECTIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX8_AVX512VP2INTERSECTIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX9_SRBDSCtrlIsSupported();

        public bool GetEAX7ECX0_EDX9_SRBDSCtrlIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX9_SRBDSCtrlIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX10_MDClearIsSupported();

        public bool GetEAX7ECX0_EDX10_MDClearIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX10_MDClearIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. MDClear support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for MDClear support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX11_RTMAlwaysAbortIsSupported();

        public bool GetEAX7ECX0_EDX11_RTMAlwaysAbortIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX11_RTMAlwaysAbortIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. RTMAlwaysAbort support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for RTMAlwaysAbort support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX12_ReservedIsSupported();

        public bool GetEAX7ECX0_EDX12_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX12_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX13_RTMForceAbortIsSupported();

        public bool GetEAX7ECX0_EDX13_RTMForceAbortIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX13_RTMForceAbortIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. RTMForceAbort support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for RTMForceAbort support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX14_SERIALIZEIsSupported();

        public bool GetEAX7ECX0_EDX14_SERIALIZEIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX14_SERIALIZEIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. SERIALIZE support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for SERIALIZE support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX15_HYBRIDIsSupported();

        public bool GetEAX7ECX0_EDX15_HYBRIDIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX15_HYBRIDIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. HYBRID support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for HYBRID support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX16_TSXLDTRKIsSupported();

        public bool GetEAX7ECX0_EDX16_TSXLDTRKIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX16_TSXLDTRKIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. TSXLDTRK support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for TSXLDTRK support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX17_ReservedIsSupported();

        public bool GetEAX7ECX0_EDX17_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX17_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX18_PCONFIGIsSupported();

        public bool GetEAX7ECX0_EDX18_PCONFIGIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX18_PCONFIGIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. PCONFIG support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for PCONFIG support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX19_LBRIsSupported();

        public bool GetEAX7ECX0_EDX19_LBRIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX19_LBRIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. LBR support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for LBR support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX20_CETIBTIsSupported();

        public bool GetEAX7ECX0_EDX20_CETIBTIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX20_CETIBTIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CETIBT support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CETIBT support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX21_ReservedIsSupported();

        public bool GetEAX7ECX0_EDX21_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX21_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX22_AMXBF16IsSupported();

        public bool GetEAX7ECX0_EDX22_AMXBF16IsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX22_AMXBF16IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. AMXBF16 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AMXBF16 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX23_AVX512FP16IsSupported();

        public bool GetEAX7ECX0_EDX23_AVX512FP16IsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX23_AVX512FP16IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. AVX512FP16 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AVX512FP16 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX24_AMXTILEIsSupported();

        public bool GetEAX7ECX0_EDX24_AMXTILEIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX24_AMXTILEIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. AMXTILE support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AMXTILE support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX25_AMXINT8IsSupported();

        public bool GetEAX7ECX0_EDX25_AMXINT8IsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX25_AMXINT8IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. AMXINT8 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AMXINT8 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX26_SPEC_CTRLIsSupported();

        public bool GetEAX7ECX0_EDX26_SPEC_CTRLIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX26_SPEC_CTRLIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. SPEC_CTRL support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for SPEC_CTRL support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX27_STIBPIsSupported();

        public bool GetEAX7ECX0_EDX27_STIBPIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX27_STIBPIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. STIBP support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for STIBP support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX28_L1D_FLUSHIsSupported();

        public bool GetEAX7ECX0_EDX28_L1D_FLUSHIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX28_L1D_FLUSHIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. L1D_FLUSH support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for L1D_FLUSH support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX29_ARCH_CAPABILITIESIsSupported();

        public bool GetEAX7ECX0_EDX29_ARCH_CAPABILITIESIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX29_ARCH_CAPABILITIESIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. ARCH_CAPABILITIES support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for ARCH_CAPABILITIES support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX30_CORE_CAPABILITIESIsSupported();

        public bool GetEAX7ECX0_EDX30_CORE_CAPABILITIESIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX30_CORE_CAPABILITIESIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CORE_CAPABILITIES support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CORE_CAPABILITIES support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX0_EDX31_SSBDIsSupported();

        public bool GetEAX7ECX0_EDX31_SSBDIsSupportedX()
        {
            try
            {
                return GetEAX7ECX0_EDX31_SSBDIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. SSBD support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for SSBD support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX7ECX1EAX();

        public string GetEAX7ECX1EAXX()
        {
            try
            {
                IntPtr eAX7ECX1EAXPtr = GetEAX7ECX1EAX();
                string eAX7ECX1EAXString = Marshal.PtrToStringAnsi(eAX7ECX1EAXPtr);

                return eAX7ECX1EAXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX7ECX1EBX();

        public string GetEAX7ECX1EBXX()
        {
            try
            {
                IntPtr eAX7ECX1EBXPtr = GetEAX7ECX1EBX();
                string eAX7ECX1EBXString = Marshal.PtrToStringAnsi(eAX7ECX1EBXPtr);

                return eAX7ECX1EBXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX7ECX1ECX();

        public string GetEAX7ECX1ECXX()
        {
            try
            {
                IntPtr eAX7ECX1ECXPtr = GetEAX7ECX1ECX();
                string eAX7ECX1ECXString = Marshal.PtrToStringAnsi(eAX7ECX1ECXPtr);

                return eAX7ECX1ECXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX7ECX1EDX();

        public string GetEAX7ECX1EDXX()
        {
            try
            {
                IntPtr eAX7ECX1EDXPtr = GetEAX7ECX1EDX();
                string eAX7ECX1EDXString = Marshal.PtrToStringAnsi(eAX7ECX1EDXPtr);

                return eAX7ECX1EDXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX0_SHA512IsSupported();

        public bool GetEAX7ECX1_EAX0_SHA512IsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX0_SHA512IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. SHA512 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for SHA512 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX1_SM3IsSupported();

        public bool GetEAX7ECX1_EAX1_SM3IsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX1_SM3IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. SM3 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for SM3 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX2_SM4IsSupported();

        public bool GetEAX7ECX1_EAX2_SM4IsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX2_SM4IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. SM4 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for SM4 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX3_RAO_INTIsSupported();

        public bool GetEAX7ECX1_EAX3_RAO_INTIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX3_RAO_INTIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. RAO_INT support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for RAO_INT support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX4_AVX_VNNIIsSupported();

        public bool GetEAX7ECX1_EAX4_AVX_VNNIIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX4_AVX_VNNIIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. AVX_VNNI support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AVX_VNNI support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX5_AVX512_BF16IsSupported();

        public bool GetEAX7ECX1_EAX5_AVX512_BF16IsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX5_AVX512_BF16IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. AVX512_BF16 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AVX512_BF16 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX6_LASSIsSupported();

        public bool GetEAX7ECX1_EAX6_LASSIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX6_LASSIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. LASS support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for LASS support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX7_CMPCCXADDIsSupported();

        public bool GetEAX7ECX1_EAX7_CMPCCXADDIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX7_CMPCCXADDIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CMPCCXADD support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CMPCCXADD support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX8_ARCHPERFMONEXTIsSupported();

        public bool GetEAX7ECX1_EAX8_ARCHPERFMONEXTIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX8_ARCHPERFMONEXTIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. ARCHPERFMONEXT support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for ARCHPERFMONEXT support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX9_DEDUPIsSupported();

        public bool GetEAX7ECX1_EAX9_DEDUPIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX9_DEDUPIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. DEDUP support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for DEDUP support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX10_FZRMIsSupported();

        public bool GetEAX7ECX1_EAX10_FZRMIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX10_FZRMIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. FZRM support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for FZRM support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX11_FSRSIsSupported();

        public bool GetEAX7ECX1_EAX11_FSRSIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX11_FSRSIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. FSRS support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for FSRS support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX12_RSRCSIsSupported();

        public bool GetEAX7ECX1_EAX12_RSRCSIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX12_RSRCSIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. RSRCS support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for RSRCS support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX13_ReservedIsSupported();

        public bool GetEAX7ECX1_EAX13_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX13_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX14_ReservedIsSupported();

        public bool GetEAX7ECX1_EAX14_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX14_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX15_ReservedIsSupported();

        public bool GetEAX7ECX1_EAX15_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX15_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX16_ReservedIsSupported();

        public bool GetEAX7ECX1_EAX16_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX16_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX17_FREDIsSupported();

        public bool GetEAX7ECX1_EAX17_FREDIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX17_FREDIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. FRED support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for FRED support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX18_LKGSIsSupported();

        public bool GetEAX7ECX1_EAX18_LKGSIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX18_LKGSIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. LKGS support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for LKGS support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX19_WRMSRNSIsSupported();

        public bool GetEAX7ECX1_EAX19_WRMSRNSIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX19_WRMSRNSIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. WRMSRNS support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for WRMSRNS support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX20_NMI_SRCIsSupported();

        public bool GetEAX7ECX1_EAX20_NMI_SRCIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX20_NMI_SRCIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. NMI_SRC support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for NMI_SRC support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX21_AMX_FP16IsSupported();

        public bool GetEAX7ECX1_EAX21_AMX_FP16IsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX21_AMX_FP16IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. AMX_FP16 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AMX_FP16 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX22_HRESETIsSupported();

        public bool GetEAX7ECX1_EAX22_HRESETIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX22_HRESETIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. HRESET support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for HRESET support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX23_AVX_IFMAIsSupported();

        public bool GetEAX7ECX1_EAX23_AVX_IFMAIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX23_AVX_IFMAIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. AVX_IFMA support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AVX_IFMA support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX24_ReservedIsSupported();

        public bool GetEAX7ECX1_EAX24_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX24_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX25_ReservedIsSupported();

        public bool GetEAX7ECX1_EAX25_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX25_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX26_LAMIsSupported();

        public bool GetEAX7ECX1_EAX26_LAMIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX26_LAMIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. LAM support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for LAM support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX27_MSRListIsSupported();

        public bool GetEAX7ECX1_EAX27_MSRListIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX27_MSRListIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. MSR List support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for MSR List support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX28_ReservedIsSupported();

        public bool GetEAX7ECX1_EAX28_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX28_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX29_ReservedIsSupported();

        public bool GetEAX7ECX1_EAX29_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX29_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX30_INVD_DISABLE_POST_BIOS_DONEIsSupported();

        public bool GetEAX7ECX1_EAX30_INVD_DISABLE_POST_BIOS_DONEIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX30_INVD_DISABLE_POST_BIOS_DONEIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. INVD_DISABLE_POST_BIOS_DONE support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for INVD_DISABLE_POST_BIOS_DONE support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EAX31_MOVRSIsSupported();

        public bool GetEAX7ECX1_EAX31_MOVRSIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EAX31_MOVRSIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. MOVRS support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for MOVRS support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX0_PPINIsSupported();

        public bool GetEAX7ECX1_EBX0_PPINIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX0_PPINIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. PPIN support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for PPIN support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX1_PBNDKBIsSupported();

        public bool GetEAX7ECX1_EBX1_PBNDKBIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX1_PBNDKBIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. PBNDKB support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for PBNDKB support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX2_ReservedIsSupported();

        public bool GetEAX7ECX1_EBX2_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX2_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX3_CPUID­MAXVAL_­LIM_RMVIsSupported();

        public bool GetEAX7ECX1_EBX3_CPUID­MAXVAL_­LIM_RMVIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX3_CPUID­MAXVAL_­LIM_RMVIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPUID­MAXVAL_­LIM_RMV support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPUID­MAXVAL_­LIM_RMV support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX4_ReservedIsSupported();

        public bool GetEAX7ECX1_EBX4_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX4_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX5_ReservedIsSupported();

        public bool GetEAX7ECX1_EBX5_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX5_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX6_ReservedIsSupported();

        public bool GetEAX7ECX1_EBX6_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX6_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX7_ReservedIsSupported();

        public bool GetEAX7ECX1_EBX7_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX7_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX8_ReservedIsSupported();

        public bool GetEAX7ECX1_EBX8_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX8_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX9_ReservedIsSupported();

        public bool GetEAX7ECX1_EBX9_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX9_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX10_ReservedIsSupported();

        public bool GetEAX7ECX1_EBX10_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX10_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX11_ReservedIsSupported();

        public bool GetEAX7ECX1_EBX11_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX11_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX12_ReservedIsSupported();

        public bool GetEAX7ECX1_EBX12_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX12_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX13_ReservedIsSupported();

        public bool GetEAX7ECX1_EBX13_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX13_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX14_ReservedIsSupported();

        public bool GetEAX7ECX1_EBX14_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX14_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX15_ReservedIsSupported();

        public bool GetEAX7ECX1_EBX15_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX15_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX16_ReservedIsSupported();

        public bool GetEAX7ECX1_EBX16_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX16_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX17_ReservedIsSupported();

        public bool GetEAX7ECX1_EBX17_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX17_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX18_ReservedIsSupported();

        public bool GetEAX7ECX1_EBX18_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX18_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX19_ReservedIsSupported();

        public bool GetEAX7ECX1_EBX19_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX19_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX20_ReservedIsSupported();

        public bool GetEAX7ECX1_EBX20_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX20_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX21_ReservedIsSupported();

        public bool GetEAX7ECX1_EBX21_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX21_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX22_ReservedIsSupported();

        public bool GetEAX7ECX1_EBX22_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX22_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX23_ReservedIsSupported();

        public bool GetEAX7ECX1_EBX23_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX23_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX24_ReservedIsSupported();

        public bool GetEAX7ECX1_EBX24_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX24_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX25_ReservedIsSupported();

        public bool GetEAX7ECX1_EBX25_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX25_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX26_ReservedIsSupported();

        public bool GetEAX7ECX1_EBX26_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX26_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX27_ReservedIsSupported();

        public bool GetEAX7ECX1_EBX27_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX27_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX28_Reserved_MPSADBW_512IsSupported();

        public bool GetEAX7ECX1_EBX28_Reserved_MPSADBW_512IsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX28_Reserved_MPSADBW_512IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved_MPSADBW_512 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved_MPSADBW_512 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX29_ReservedIsSupported();

        public bool GetEAX7ECX1_EBX29_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX29_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX30_Reserved_AVX512_RAO_FPIsSupported();

        public bool GetEAX7ECX1_EBX30_Reserved_AVX512_RAO_FPIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX30_Reserved_AVX512_RAO_FPIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved AVX512_RAO_FP support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved AVX512_RAO_FP support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EBX31_Reserved_AVX512_RAO_FPIsSupported();

        public bool GetEAX7ECX1_EBX31_Reserved_AVX512_RAO_FPIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EBX31_Reserved_AVX512_RAO_FPIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved AVX512_RAO_FP support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved AVX512_RAO_FP support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX0_RDT_M_­ASYMIsSupported();

        public bool GetEAX7ECX1_ECX0_RDT_M_­ASYMIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX0_RDT_M_­ASYMIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. RDT_M_­ASYM support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for RDT_M_­ASYM support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX1_RDT_M_­ASYMIsSupported();

        public bool GetEAX7ECX1_ECX1_RDT_M_­ASYMIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX1_RDT_M_­ASYMIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. RDT_M_­ASYM support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for RDT_M_­ASYM support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX2_Reserved_LEGACY_REDUCED_ISAIsSupported();

        public bool GetEAX7ECX1_ECX2_Reserved_LEGACY_REDUCED_ISAIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX2_Reserved_LEGACY_REDUCED_ISAIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved LEGACY_REDUCED_ISA support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved LEGACY_REDUCED_ISA support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX3_ReservedIsSupported();

        public bool GetEAX7ECX1_ECX3_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX3_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX4_SIPI64IsSupported();

        public bool GetEAX7ECX1_ECX4_SIPI64IsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX4_SIPI64IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. SIPI64 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for SIPI64 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX5_MSR_IMMIsSupported();

        public bool GetEAX7ECX1_ECX5_MSR_IMMIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX5_MSR_IMMIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. MSR_IMM support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for MSR_IMM support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX6_ReservedIsSupported();

        public bool GetEAX7ECX1_ECX6_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX6_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX7_ReservedIsSupported();

        public bool GetEAX7ECX1_ECX7_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX7_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX8_ReservedIsSupported();

        public bool GetEAX7ECX1_ECX8_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX8_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX9_ReservedIsSupported();

        public bool GetEAX7ECX1_ECX9_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX9_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX10_ReservedIsSupported();

        public bool GetEAX7ECX1_ECX10_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX10_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX11_ReservedIsSupported();

        public bool GetEAX7ECX1_ECX11_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX11_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX12_ReservedIsSupported();

        public bool GetEAX7ECX1_ECX12_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX12_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX13_ReservedIsSupported();

        public bool GetEAX7ECX1_ECX13_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX13_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX14_ReservedIsSupported();

        public bool GetEAX7ECX1_ECX14_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX14_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX15_ReservedIsSupported();

        public bool GetEAX7ECX1_ECX15_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX15_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX16_ReservedIsSupported();

        public bool GetEAX7ECX1_ECX16_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX16_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX17_ReservedIsSupported();

        public bool GetEAX7ECX1_ECX17_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX17_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX18_ReservedIsSupported();

        public bool GetEAX7ECX1_ECX18_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX18_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX19_ReservedIsSupported();

        public bool GetEAX7ECX1_ECX19_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX19_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX20_ReservedIsSupported();

        public bool GetEAX7ECX1_ECX20_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX20_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX21_ReservedIsSupported();

        public bool GetEAX7ECX1_ECX21_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX21_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX22_ReservedIsSupported();

        public bool GetEAX7ECX1_ECX22_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX22_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX23_ReservedIsSupported();

        public bool GetEAX7ECX1_ECX23_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX23_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX24_ReservedIsSupported();

        public bool GetEAX7ECX1_ECX24_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX24_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX25_ReservedIsSupported();

        public bool GetEAX7ECX1_ECX25_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX25_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX26_ReservedIsSupported();

        public bool GetEAX7ECX1_ECX26_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX26_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX27_ReservedIsSupported();

        public bool GetEAX7ECX1_ECX27_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX27_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX28_ReservedIsSupported();

        public bool GetEAX7ECX1_ECX28_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX28_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX29_ReservedIsSupported();

        public bool GetEAX7ECX1_ECX29_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX29_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX30_ReservedIsSupported();

        public bool GetEAX7ECX1_ECX30_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX30_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_ECX31_ReservedIsSupported();

        public bool GetEAX7ECX1_ECX31_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_ECX31_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX0_ReservedIsSupported();

        public bool GetEAX7ECX1_EDX0_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX0_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX1_Reserved_AVX512_VNNI_FP16IsSupported();

        public bool GetEAX7ECX1_EDX1_Reserved_AVX512_VNNI_FP16IsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX1_Reserved_AVX512_VNNI_FP16IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved_AVX512_VNNI_FP16 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved_AVX512_VNNI_FP16 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX2_Reserved_AVX512_VNNI_INT8IsSupported();

        public bool GetEAX7ECX1_EDX2_Reserved_AVX512_VNNI_INT8IsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX2_Reserved_AVX512_VNNI_INT8IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved_AVX512_VNNI_INT8 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved_AVX512_VNNI_INT8 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX3_Reserved_AVX512_NE_CONVERTIsSupported();

        public bool GetEAX7ECX1_EDX3_Reserved_AVX512_NE_CONVERTIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX3_Reserved_AVX512_NE_CONVERTIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved_AVX512_NE_CONVERT support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved_AVX512_NE_CONVERT support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX4_AVX_VNNI_INT8IsSupported();

        public bool GetEAX7ECX1_EDX4_AVX_VNNI_INT8IsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX4_AVX_VNNI_INT8IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. AVX_VNNI_INT8 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AVX_VNNI_INT8 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX5_AVX_NE_CONVERTIsSupported();

        public bool GetEAX7ECX1_EDX5_AVX_NE_CONVERTIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX5_AVX_NE_CONVERTIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. AVX_NE_CONVERT support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AVX_NE_CONVERT support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX6_ReservedIsSupported();

        public bool GetEAX7ECX1_EDX6_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX6_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX7_ReservedIsSupported();

        public bool GetEAX7ECX1_EDX7_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX7_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX8_AMX_COMPLEXIsSupported();

        public bool GetEAX7ECX1_EDX8_AMX_COMPLEXIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX8_AMX_COMPLEXIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. AMX_COMPLEX support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AMX_COMPLEX support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX9_ReservedIsSupported();

        public bool GetEAX7ECX1_EDX9_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX9_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX10_AVX_VNNI_INT16IsSupported();

        public bool GetEAX7ECX1_EDX10_AVX_VNNI_INT16IsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX10_AVX_VNNI_INT16IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. AVX_VNNI_INT16 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AVX_VNNI_INT16 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX11_Reserved_AVX512_VNNI_INT16IsSupported();

        public bool GetEAX7ECX1_EDX11_Reserved_AVX512_VNNI_INT16IsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX11_Reserved_AVX512_VNNI_INT16IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved_AVX512_VNNI_INT16 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved_AVX512_VNNI_INT16 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX12_ReservedIsSupported();

        public bool GetEAX7ECX1_EDX12_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX12_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX13_UTMRIsSupported();

        public bool GetEAX7ECX1_EDX13_UTMRIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX13_UTMRIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. UTMR support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for UTMR support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX14_PREFETCHIIsSupported();

        public bool GetEAX7ECX1_EDX14_PREFETCHIIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX14_PREFETCHIIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. PREFETCHI support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for PREFETCHI support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX15_USER_MSRIsSupported();

        public bool GetEAX7ECX1_EDX15_USER_MSRIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX15_USER_MSRIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. USER_MSRI support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for USER_MSRI support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX16_Reserved_AVX512_BF16_NEIsSupported();

        public bool GetEAX7ECX1_EDX16_Reserved_AVX512_BF16_NEIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX16_Reserved_AVX512_BF16_NEIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved_AVX512_BF16_NE support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved_AVX512_BF16_NE support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX17_UIRET_UIF_FROM_RFLAGSIsSupported();

        public bool GetEAX7ECX1_EDX17_UIRET_UIF_FROM_RFLAGSIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX17_UIRET_UIF_FROM_RFLAGSIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. UIRET_UIF_FROM_RFLAGS support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for UIRET_UIF_FROM_RFLAGS support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX18_CET_SSSIsSupported();

        public bool GetEAX7ECX1_EDX18_CET_SSSIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX18_CET_SSSIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CET_SSS support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CET_SSS support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX19_AVX10IsSupported();

        public bool GetEAX7ECX1_EDX19_AVX10IsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX19_AVX10IsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. AVX10 support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for AVX10 support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX20_ReservedIsSupported();

        public bool GetEAX7ECX1_EDX20_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX20_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX21_APX_FIsSupported();

        public bool GetEAX7ECX1_EDX21_APX_FIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX21_APX_FIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. APX_F support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for APX_F support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX22_SEC_TEE_ATTESTATIONIsSupported();

        public bool GetEAX7ECX1_EDX22_SEC_TEE_ATTESTATIONIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX22_SEC_TEE_ATTESTATIONIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. SEC_TEE_ATTESTATION support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for SEC_TEE_ATTESTATION support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX23_MWAITIsSupported();

        public bool GetEAX7ECX1_EDX23_MWAITIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX23_MWAITIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. MWAIT support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for MWAIT support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX24_SLSMIsSupported();

        public bool GetEAX7ECX1_EDX24_SLSMIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX24_SLSMIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. SLSM support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for SLSM support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX25_ReservedIsSupported();

        public bool GetEAX7ECX1_EDX25_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX25_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX26_ReservedIsSupported();

        public bool GetEAX7ECX1_EDX26_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX26_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX27_ReservedIsSupported();

        public bool GetEAX7ECX1_EDX27_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX27_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX28_ReservedIsSupported();

        public bool GetEAX7ECX1_EDX28_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX28_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX29_ReservedIsSupported();

        public bool GetEAX7ECX1_EDX29_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX29_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX30_ReservedIsSupported();

        public bool GetEAX7ECX1_EDX30_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX30_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX1_EDX31_ReservedIsSupported();

        public bool GetEAX7ECX1_EDX31_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX1_EDX31_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX7ECX2EAX();

        public string GetEAX7ECX2EAXX()
        {
            try
            {
                IntPtr eAX7ECX2EAXPtr = GetEAX7ECX2EAX();
                string eAX7ECX2EAXString = Marshal.PtrToStringAnsi(eAX7ECX2EAXPtr);

                return eAX7ECX2EAXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX7ECX2EBX();

        public string GetEAX7ECX2EBXX()
        {
            try
            {
                IntPtr eAX7ECX2EBXPtr = GetEAX7ECX2EBX();
                string eAX7ECX2EBXString = Marshal.PtrToStringAnsi(eAX7ECX2EBXPtr);

                return eAX7ECX2EBXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX7ECX2ECX();

        public string GetEAX7ECX2ECXX()
        {
            try
            {
                IntPtr eAX7ECX2ECXPtr = GetEAX7ECX2ECX();
                string eAX7ECX2ECXString = Marshal.PtrToStringAnsi(eAX7ECX2ECXPtr);

                return eAX7ECX2ECXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetEAX7ECX2EDX();

        public string GetEAX7ECX2EDXX()
        {
            try
            {
                IntPtr eAX7ECX2EDXPtr = GetEAX7ECX2EDX();
                string eAX7ECX2EDXString = Marshal.PtrToStringAnsi(eAX7ECX2EDXPtr);

                return eAX7ECX2EDXString;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. CPU ID information cannot be determined. " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for CPU ID information: " + ex.Message);
                return CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX0_PSFDIsSupported();

        public bool GetEAX7ECX2_EDX0_PSFDIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX0_PSFDIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. PSFD support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for PSFD support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX1_IPREDIsSupported();

        public bool GetEAX7ECX2_EDX1_IPREDIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX1_IPREDIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. IPRED support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for IPRED support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX2_RRSBA_CTRLIsSupported();

        public bool GetEAX7ECX2_EDX2_RRSBA_CTRLIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX2_RRSBA_CTRLIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. RRSBA_CTRL support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for RRSBA_CTRL support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX3_DDPD_UIsSupported();

        public bool GetEAX7ECX2_EDX3_DDPD_UIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX3_DDPD_UIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. DDPD_U support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for DDPD_U support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX4_BHI_CTRLIsSupported();

        public bool GetEAX7ECX2_EDX4_BHI_CTRLIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX4_BHI_CTRLIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. BHI_CTRL support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for BHI_CTRL support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX5_MCDT_NOIsSupported();

        public bool GetEAX7ECX2_EDX5_MCDT_NOIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX5_MCDT_NOIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. MCDT_NO support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for MCDT_NO support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX6_UC_LOCK_DISABLEIsSupported();

        public bool GetEAX7ECX2_EDX6_UC_LOCK_DISABLEIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX6_UC_LOCK_DISABLEIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. UC_LOCK_DISABLE support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for UC_LOCK_DISABLE support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX7_MONITOR_MITG_NOIsSupported();

        public bool GetEAX7ECX2_EDX7_MONITOR_MITG_NOIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX7_MONITOR_MITG_NOIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. MONITOR_MITG_NO support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for MONITOR_MITG_NO support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX8_ReservedIsSupported();

        public bool GetEAX7ECX2_EDX8_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX8_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX9_ReservedIsSupported();

        public bool GetEAX7ECX2_EDX9_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX9_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX10_ReservedIsSupported();

        public bool GetEAX7ECX2_EDX10_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX10_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX11_ReservedIsSupported();

        public bool GetEAX7ECX2_EDX11_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX11_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX12_ReservedIsSupported();

        public bool GetEAX7ECX2_EDX12_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX12_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX13_ReservedIsSupported();

        public bool GetEAX7ECX2_EDX13_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX13_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX14_ReservedIsSupported();

        public bool GetEAX7ECX2_EDX14_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX14_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX15_ReservedIsSupported();

        public bool GetEAX7ECX2_EDX15_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX15_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX16_ReservedIsSupported();

        public bool GetEAX7ECX2_EDX16_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX16_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX17_ReservedIsSupported();

        public bool GetEAX7ECX2_EDX17_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX17_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX18_ReservedIsSupported();

        public bool GetEAX7ECX2_EDX18_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX18_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX19_ReservedIsSupported();

        public bool GetEAX7ECX2_EDX19_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX19_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX20_ReservedIsSupported();

        public bool GetEAX7ECX2_EDX20_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX20_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX21_ReservedIsSupported();

        public bool GetEAX7ECX2_EDX21_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX21_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX22_ReservedIsSupported();

        public bool GetEAX7ECX2_EDX22_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX22_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX23_ReservedIsSupported();

        public bool GetEAX7ECX2_EDX23_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX23_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX24_ReservedIsSupported();

        public bool GetEAX7ECX2_EDX24_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX24_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX25_ReservedIsSupported();

        public bool GetEAX7ECX2_EDX25_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX25_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX26_ReservedIsSupported();

        public bool GetEAX7ECX2_EDX26_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX26_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX27_ReservedIsSupported();

        public bool GetEAX7ECX2_EDX27_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX27_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX28_ReservedIsSupported();

        public bool GetEAX7ECX2_EDX28_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX28_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX29_ReservedIsSupported();

        public bool GetEAX7ECX2_EDX29_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX29_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX30_ReservedIsSupported();

        public bool GetEAX7ECX2_EDX30_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX30_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        [DllImport("CPUIDBE.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int GetEAX7ECX2_EDX31_ReservedIsSupported();

        public bool GetEAX7ECX2_EDX31_ReservedIsSupportedX()
        {
            try
            {
                return GetEAX7ECX2_EDX31_ReservedIsSupported() != 0;
            }
            catch (DllNotFoundException ex)
            {
                Console.WriteLine("Error: CPUIDBE.dll not found. Reserved support cannot be determined. " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking for Reserved support: " + ex.Message);
                return false;
            }
        }

        #endregion

        #region EAX=0x0D: XSAVE Features and State Components



        #endregion

        #region EAX=0x12: SGX Capabilities



        #endregion

        #region region EAX=0x14, ECX=0x0: Processor Trace feature bits in EBX and ECX



        #endregion

        #region EAX=0x14, ECX=0x1: Processor Trace packet generation information in EAX, EBX and ECX



        #endregion

        #region EAX=0x15: TSC and Core Crystal frequency information



        #endregion

        #region EAX=0x16: Processor and Bus specification frequencies



        #endregion

        #region EAX=0x17: SoC Vendor Attribute Enumeration



        #endregion

        #region EAX=0x18: TLB Hierarchy and Topology



        #endregion

        #region EAX=0x19: Intel Key Locker Features



        #endregion

        #region EAX=0x1D: Intel AMX Tile Information



        #endregion

        #region EAX=0x1E: Intel AMX Tile Multiplier (TMUL) Information



        #endregion

        #region EAX=0x21: Reserved for TDX enumeration



        #endregion

        #region EAX=0x24, ECX=0x0: AVX10 Converged Vector ISA



        #endregion

        #region EAX=0x24, ECX=0x1: Discrete AVX10 Features



        #endregion

        #region EAX=0x20000000: Highest Xeon Phi Function Implemented



        #endregion

        #region EAX=0x20000001: Xeon Phi Feature Bits



        #endregion

        #region EAX=0x40000000h-0x4FFFFFFFh: Reserved for Hypervisors



        #endregion

        #region EAX=0x80000000: Highest Extended Function Implemented



        #endregion

        #region EAX=0x80000001: Extended Processor Info and Feature Bits



        #endregion

        #region EAX=0x80000002,0x80000003,0x80000004: Processor Brand String



        #endregion

        #region EAX=0x80000005: L1 Cache and TLB Identifiers



        #endregion

        #region EAX=0x80000006: Extended L2 Cache Features



        #endregion

        #region EAX=0x80000007: Processor Power Management Information and RAS Capabilities



        #endregion

        #region EAX=0x80000008: Virtual and Physical Address Sizes



        #endregion

        #region EAX=0x8000000A: SVM features



        #endregion

        #region EAX=0x8000001F: Encrypted Memory Capabilities



        #endregion

        #region EAX=0x80000021: Extended Feature Identification



        #endregion

        #region EAX=0x80000025: Encrypted Memory Capabilities 2



        #endregion

        #region EAX=0x8C860000: Hygon Extended Feature Flags



        #endregion

        #region EAX=0x8FFFFFFE: AMD Easter Eggs



        #endregion

        #region EAX=0x8FFFFFFF: AMD Easter Eggs



        #endregion

        #region EAX=0xC0000000: Highest Centaur Extended Function



        #endregion

        #region EAX=0xC0000001: Centaur Feature Information



        #endregion

        #region EAX=0xC0000002: Centaur Extended CPUID Performance Data



        #endregion

        #region EAX=0xC0000006, ECX=0: Zhaoxin Feature Information



        #endregion



    }
}
