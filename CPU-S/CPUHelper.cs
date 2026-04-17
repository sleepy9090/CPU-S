using System;
using System.Collections.Generic;
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
                characteristics += "Reserved, ";
            }
            if (IsBitSet(bitmask, 1))
            {
                characteristics += "Unknown, ";
            }
            if (IsBitSet(bitmask, 2))
            {
                characteristics += "64-bit Capable, ";
            }
            if (IsBitSet(bitmask, 3))
            {
                characteristics += "Multi-Core, ";
            }
            if (IsBitSet(bitmask, 4))
            {
                characteristics += "Hardware Thread - (Hyper-threading), ";
            }
            if (IsBitSet(bitmask, 5))
            {
                characteristics += "Execute Protection - (NX bit), ";
            }
            if (IsBitSet(bitmask, 6))
            {
                characteristics += "Enhanced Virtualization - (VT-x/AMD-V), ";
            }
            if (IsBitSet(bitmask, 7))
            {
                characteristics += "Power/Performance Control, ";
            }
            if (IsBitSet(bitmask, 8))
            {
                characteristics += "128-bit Capable, ";
            }
            if (IsBitSet(bitmask, 9))
            {
                characteristics += "Arm64 SoC ID, ";
            }
            if (IsBitSet(bitmask, 10))
            {
                characteristics += "Reserved, ";
            }
            if (IsBitSet(bitmask, 11))
            {
                characteristics += "Reserved, ";
            }
            if (IsBitSet(bitmask, 12))
            {
                characteristics += "Reserved, ";
            }
            if (IsBitSet(bitmask, 13))
            {
                characteristics += "Reserved, ";
            }
            if (IsBitSet(bitmask, 14))
            {
                characteristics += "Reserved, ";
            }
            if (IsBitSet(bitmask, 15))
            {
                characteristics += "Reserved, ";
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
    }
}
