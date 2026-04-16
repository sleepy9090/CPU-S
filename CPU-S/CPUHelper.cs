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
                    architecture = CPUConstants.NOT_FOUND;
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
                    availability = CPUConstants.NOT_FOUND;
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
                    configManagerErrorMessage = CPUConstants.NOT_FOUND;
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
                    status = CPUConstants.NOT_FOUND;
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
                default:
                    family = CPUConstants.NOT_FOUND;
                    break;

            }
            return family;
        }
    }
}
