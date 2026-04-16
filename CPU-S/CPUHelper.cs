using System;
using System.Collections.Generic;
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
                    architecture = "Architecture Unknown";
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
                    availability = "Other";
                    break;
                case 2:
                    availability = "Unknown";
                    break;
                case 3:
                    availability = "Running / Full Power";
                    break;
                case 4:
                    availability = "Warning";
                    break;
                case 5:
                    availability = "In Test";
                    break;
                case 6:
                    availability = "Not Applicable";
                    break;
                case 7:
                    availability = "Power Off";
                    break;
                case 8:
                    availability = "Off Line";
                    break;
                case 9:
                    availability = "Off Duty";
                    break;
                case 10:
                    availability = "Degraded";
                    break;
                case 11:
                    availability = "Not Installed";
                    break;
                case 12:
                    availability = "Install Error";
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
                    availability = "Power Cycle";
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
                    availability = "Availability unknown.";
                    break;
            }

            return availability;
        }

        public string GetCharacteristics(uint value)
        {
            string characteristics;
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

            characteristics = "";

            return characteristics;
        }
    }
}
