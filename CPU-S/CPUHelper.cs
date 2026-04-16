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
                    family = "Alpha Family";
                    break;
                case 49:
                    family = "Alpha 21064";
                    break;
                case 50:
                    family = "Alpha 21066";
                    break;
                case 51:
                    family = "";
                    break;
                case 52:
                    family = "";
                    break;
                case 53:
                    family = "";
                    break;
                case 54:
                    family = "";
                    break;
                case 55:
                    family = "";
                    break;
                case 56:
                    family = "";
                    break;
                case 57:
                    family = "";
                    break;
                case 58:
                    family = "";
                    break;
                case 59:
                    family = "";
                    break;
                case 60:
                    family = "";
                    break;
                case 61:
                    family = "";
                    break;
                case 62:
                    family = "";
                    break;
                case 63:
                    family = "";
                    break;
                case 64:
                    family = "";
                    break;
                case 65:
                    family = "";
                    break;
                case 66:
                    family = "";
                    break;
                case 67:
                    family = "";
                    break;
                case 68:
                    family = "";
                    break;
                case 69:
                    family = "";
                    break;
                case 70:
                    family = "";
                    break;
                case 71:
                    family = "";
                    break;
                case 72:
                    family = "";
                    break;
                case 73:
                    family = "";
                    break;
                case 74:
                    family = "";
                    break;
                case 75:
                    family = "";
                    break;
                case 76:
                    family = "";
                    break;
                case 77:
                    family = "";
                    break;
                case 78:
                    family = "";
                    break;
                case 79:
                    family = "";
                    break;
                case 80:
                    family = "";
                    break;
                case 81:
                    family = "";
                    break;
                case 82:
                    family = "";
                    break;
                case 83:
                    family = "";
                    break;
                case 84:
                    family = "";
                    break;
                case 85:
                    family = "";
                    break;
                case 86:
                    family = "";
                    break;
                case 87:
                    family = "";
                    break;
                case 88:
                    family = "";
                    break;
                case 96:
                    family = "";
                    break;
                case 97:
                    family = "";
                    break;
                case 98:
                    family = "";
                    break;
                case 99:
                    family = "";
                    break;
                case 100:
                    family = "";
                    break;
                case 101:
                    family = "";
                    break;
                case 102:
                    family = "";
                    break;
                case 103:
                    family = "";
                    break;
                case 104:
                    family = "";
                    break;
                case 105:
                    family = "";
                    break;
                case 106:
                    family = "";
                    break;
                case 107:
                    family = "";
                    break;
                case 112:
                    family = "";
                    break;
                case 120:
                    family = "";
                    break;
                case 121:
                    family = "";
                    break;
                case 122:
                    family = "";
                    break;
                case 128:
                    family = "";
                    break;
                case 130:
                    family = "";
                    break;
                case 131:
                    family = "";
                    break;
                case 132:
                    family = "";
                    break;
                case 133:
                    family = "";
                    break;
                case 134:
                    family = "";
                    break;
                case 135:
                    family = "";
                    break;
                case 136:
                    family = "";
                    break;
                case 137:
                    family = "";
                    break;
                case 138:
                    family = "";
                    break;
                case 139:
                    family = "";
                    break;
                case 140:
                    family = "";
                    break;
                case 141:
                    family = "";
                    break;
                case 142:
                    family = "";
                    break;
                case 143:
                    family = "";
                    break;
                case 144:
                    family = "";
                    break;
                case 145:
                    family = "";
                    break;
                case 146:
                    family = "";
                    break;
                case 147:
                    family = "";
                    break;
                case 148:
                    family = "";
                    break;
                case 149:
                    family = "";
                    break;
                case 150:
                    family = "";
                    break;
                case 160:
                    family = "";
                    break;
                case 161:
                    family = "";
                    break;
                case 162:
                    family = "";
                    break;
                case 163:
                    family = "";
                    break;
                case 164:
                    family = "";
                    break;
                case 165:
                    family = "";
                    break;
                case 166:
                    family = "";
                    break;
                case 167:
                    family = "";
                    break;
                case 168:
                    family = "";
                    break;
                case 169:
                    family = "";
                    break;
                case 170:
                    family = "";
                    break;
                case 171:
                    family = "";
                    break;
                case 172:
                    family = "";
                    break;
                case 173:
                    family = "";
                    break;
                case 174:
                    family = "";
                    break;
                case 175:
                    family = "";
                    break;
                case 176:
                    family = "";
                    break;
                case 177:
                    family = "";
                    break;
                case 178:
                    family = "";
                    break;
                case 179:
                    family = "";
                    break;
                case 180:
                    family = "";
                    break;
                case 181:
                    family = "";
                    break;
                case 182:
                    family = "";
                    break;
                case 183:
                    family = "";
                    break;
                case 184:
                    family = "";
                    break;
                case 185:
                    family = "";
                    break;
                case 186:
                    family = "";
                    break;
                case 187:
                    family = "";
                    break;
                case 188:
                    family = "";
                    break;
                case 189:
                    family = "";
                    break;
                case 190:
                    family = "";
                    break;
                case 191:
                    family = "";
                    break;
                case 192:
                    family = "";
                    break;
                case 193:
                    family = "";
                    break;
                case 194:
                    family = "";
                    break;
                case 195:
                    family = "";
                    break;
                case 196:
                    family = "";
                    break;
                case 197:
                    family = "";
                    break;
                case 198:
                    family = "";
                    break;
                case 199:
                    family = "";
                    break;
                case 200:
                    family = "";
                    break;
                case 201:
                    family = "";
                    break;
                case 202:
                    family = "";
                    break;
                case 203:
                    family = "";
                    break;
                case 204:
                    family = "";
                    break;
                case 205:
                    family = "";
                    break;
                case 206:
                    family = "";
                    break;
                case 207:
                    family = "";
                    break;
                case 208:
                    family = "";
                    break;
                case 210:
                    family = "";
                    break;
                case 211:
                    family = "";
                    break;
                case 212:
                    family = "";
                    break;
                case 213:
                    family = "";
                    break;
                case 214:
                    family = "";
                    break;
                case 215:
                    family = "";
                    break;
                case 216:
                    family = "";
                    break;
                case 217:
                    family = "";
                    break;
                case 218:
                    family = "";
                    break;
                case 219:
                    family = "";
                    break;
                case 221:
                    family = "";
                    break;
                case 222:
                    family = "";
                    break;
                case 223:
                    family = "";
                    break;
                case 224:
                    family = "";
                    break;
                case 228:
                    family = "";
                    break;
                case 229:
                    family = "";
                    break;
                case 230:
                    family = "80487";
                    break;
                case 231:
                    family = "";
                    break;
                case 232:
                    family = "";
                    break;
                case 233:
                    family = "";
                    break;
                case 234:
                    family = "";
                    break;
                case 235:
                    family = "";
                    break;
                case 236:
                    family = "";
                    break;
                case 237:
                    family = "";
                    break;
                case 238:
                    family = "";
                    break;
                case 239:
                    family = "";
                    break;
                case 250:
                    family = "80487";
                    break;
                case 251:
                    family = "";
                    break;
                case 254:
                    family = "";
                    break;
                case 255:
                    family = "";
                    break;
                case 256:
                    family = "";
                    break;
                case 257:
                    family = "";
                    break;
                case 258:
                    family = "";
                    break;
                case 259:
                    family = "";
                    break;
                case 260:
                    family = "80487";
                    break;
                case 261:
                    family = "";
                    break;
                case 280:
                    family = "80487";
                    break;
                case 281:
                    family = "";
                    break;
                case 300:
                    family = "";
                    break;
                case 301:
                    family = "";
                    break;
                case 302:
                    family = "";
                    break;
                case 320:
                    family = "";
                    break;
                case 350:
                    family = "";
                    break;
                case 500:
                    family = "";
                    break;
                case 512:
                    family = "";
                    break;
                case 513:
                    family = "";
                    break;
                case 514:
                    family = "";
                    break;
                case 600:
                    family = "";
                    break;
                case 601:
                    family = "";
                    break;
                case 602:
                    family = "";
                    break;
                case 603:
                    family = "";
                    break;
                case 604:
                    family = "";
                    break;
                case 605:
                    family = "";
                    break;
                case 606:
                    family = "";
                    break;
                case 607:
                    family = "";
                    break;
                case 608:
                    family = "";
                    break;
                case 609:
                    family = "";
                    break;
                case 610:
                    family = "";
                    break;
                case 620:
                    family = "";
                    break;
                case 621:
                    family = "";
                    break;
                case 622:
                    family = "";
                    break;
                case 623:
                    family = "";
                    break;
                case 624:
                    family = "";
                    break;
                case 625:
                    family = "";
                    break;
                case 768:
                    family = "";
                    break;
                case 769:
                    family = "";
                    break;
                case 770:
                    family = "";
                    break;
                case 771:
                    family = "";
                    break;
                case 772:
                    family = "";
                    break;
                case 773:
                    family = "";
                    break;
                case 774:
                    family = "";
                    break;
                case 775:
                    family = "";
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
    }
}
