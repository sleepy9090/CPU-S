using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX2 : Form
    {
        private CPUHelper cpuHelper;

        public EAX2()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x2: Cache and TLB Descriptor Information

            string cpuIdEAX2EAX = cpuHelper.GetEAX2EAXX();
            textBoxEAX2EAX.Text = cpuIdEAX2EAX;

            string cpuIdEAX2EBX = cpuHelper.GetEAX2EBXX();
            textBoxEAX2EBX.Text = cpuIdEAX2EBX;

            string cpuIdEAX2ECX = cpuHelper.GetEAX2ECXX();
            textBoxEAX2ECX.Text = cpuIdEAX2ECX;

            string cpuIdEAX2EDX = cpuHelper.GetEAX2EDXX();
            textBoxEAX2EDX.Text = cpuIdEAX2EDX;

            bool cpuIdEAX2_EAX31_IsInvalidCacheAndTLBDescriptors = cpuHelper.GetEAX2_EAX31_IsInvalidCacheAndTblDescriptorsEAXX();
            checkBoxEAX2_EAX31_IsInvalidCacheAndTLBDescriptors.Checked = cpuIdEAX2_EAX31_IsInvalidCacheAndTLBDescriptors;

            string cpuIdEAX2_EAX0_7_NumberOfTimeToQueryCPUIDWithEAX = cpuHelper.GetEAX2_EAX0_7_NumberOfTimeToQueryCPUIDWithEAXX();
            textBoxEAX2_EAX0_7_NumberOfTimeToQueryCPUIDWithEAX.Text = cpuIdEAX2_EAX0_7_NumberOfTimeToQueryCPUIDWithEAX;

            string cpuIdEAX2_EAX8_15_CacheAndTLBDescriptorInformation1 = cpuHelper.GetEAX2_EAX8_15_CacheAndTLBDescriptorInformation1X();
            textBoxEAX2_EAX8_15_CacheAndTLBDescriptorInformation1.Text = cpuIdEAX2_EAX8_15_CacheAndTLBDescriptorInformation1;

            textBoxEAX2_EAX8_15_CacheAndTLBDescriptorInformation1Desc.Text = GetCacheAndTableDescriptor(int.TryParse(cpuIdEAX2_EAX8_15_CacheAndTLBDescriptorInformation1, out int cacheDescriptor) ? cacheDescriptor : 0);

            string cpuIdEAX2_EAX16_23_CacheAndTLBDescriptorInformation2 = cpuHelper.GetEAX2_EAX16_23_CacheAndTLBDescriptorInformation2X();
            textBoxEAX2_EAX16_23_CacheAndTLBDescriptorInformation2.Text = cpuIdEAX2_EAX16_23_CacheAndTLBDescriptorInformation2;

            textBoxEAX2_EAX16_23_CacheAndTLBDescriptorInformation2Desc.Text = GetCacheAndTableDescriptor(int.TryParse(cpuIdEAX2_EAX16_23_CacheAndTLBDescriptorInformation2, out int cacheDescriptor2) ? cacheDescriptor2 : 0);

            string cpuIdEAX2_EAX24_31_CacheAndTLBDescriptorInformation3 = cpuHelper.GetEAX2_EAX24_31_CacheAndTLBDescriptorInformation3X();
            textBoxEAX2_EAX24_31_CacheAndTLBDescriptorInformation3.Text = cpuIdEAX2_EAX24_31_CacheAndTLBDescriptorInformation3;

            textBoxEAX2_EAX24_31_CacheAndTLBDescriptorInformation3Desc.Text = GetCacheAndTableDescriptor(int.TryParse(cpuIdEAX2_EAX24_31_CacheAndTLBDescriptorInformation3, out int cacheDescriptor3) ? cacheDescriptor3 : 0);

            bool cpuIdEAX2_EBX31_IsInvalidCacheAndTLBDescriptors = cpuHelper.GetEAX2_EBX31_IsInvalidCacheAndTblDescriptorsEBXX();
            checkBoxEAX2_EBX31_IsInvalidCacheAndTLBDescriptors.Checked = cpuIdEAX2_EBX31_IsInvalidCacheAndTLBDescriptors;

            string cpuIdEAX2_EBX8_15_CacheAndTLBDescriptorInformation1 = cpuHelper.GetEAX2_EBX8_15_CacheAndTLBDescriptorInformation1X();
            textBoxEAX2_EBX8_15_CacheAndTLBDescriptorInformation1.Text = cpuIdEAX2_EBX8_15_CacheAndTLBDescriptorInformation1;

            textBoxEAX2_EBX8_15_CacheAndTLBDescriptorInformation1Desc.Text = GetCacheAndTableDescriptor(int.TryParse(cpuIdEAX2_EBX8_15_CacheAndTLBDescriptorInformation1, out int cacheDescriptor4) ? cacheDescriptor4 : 0);

            string cpuIdEAX2_EBX16_23_CacheAndTLBDescriptorInformation2 = cpuHelper.GetEAX2_EBX16_23_CacheAndTLBDescriptorInformation2X();
            textBoxEAX2_EBX16_23_CacheAndTLBDescriptorInformation2.Text = cpuIdEAX2_EBX16_23_CacheAndTLBDescriptorInformation2;

            textBoxEAX2_EBX16_23_CacheAndTLBDescriptorInformation2Desc.Text = GetCacheAndTableDescriptor(int.TryParse(cpuIdEAX2_EBX16_23_CacheAndTLBDescriptorInformation2, out int cacheDescriptor5) ? cacheDescriptor5 : 0);

            string cpuIdEAX2_EBX24_31_CacheAndTLBDescriptorInformation3 = cpuHelper.GetEAX2_EBX24_31_CacheAndTLBDescriptorInformation3X();
            textBoxEAX2_EBX24_31_CacheAndTLBDescriptorInformation3.Text = cpuIdEAX2_EBX24_31_CacheAndTLBDescriptorInformation3;

            textBoxEAX2_EBX24_31_CacheAndTLBDescriptorInformation3Desc.Text = GetCacheAndTableDescriptor(int.TryParse(cpuIdEAX2_EBX24_31_CacheAndTLBDescriptorInformation3, out int cacheDescriptor6) ? cacheDescriptor6 : 0);

            bool cpuIdEAX2_ECX31_IsInvalidCacheAndTLBDescriptors = cpuHelper.GetEAX2_ECX31_IsInvalidCacheAndTblDescriptorsECXX();
            checkBoxEAX2_ECX31_IsInvalidCacheAndTLBDescriptors.Checked = cpuIdEAX2_ECX31_IsInvalidCacheAndTLBDescriptors;

            string cpuIdEAX2_ECX8_15_CacheAndTLBDescriptorInformation1 = cpuHelper.GetEAX2_ECX8_15_CacheAndTLBDescriptorInformation1X();
            textBoxEAX2_ECX8_15_CacheAndTLBDescriptorInformation1.Text = cpuIdEAX2_ECX8_15_CacheAndTLBDescriptorInformation1;

            textBoxEAX2_ECX8_15_CacheAndTLBDescriptorInformation1Desc.Text = GetCacheAndTableDescriptor(int.TryParse(cpuIdEAX2_ECX8_15_CacheAndTLBDescriptorInformation1, out int cacheDescriptor7) ? cacheDescriptor7 : 0);

            string cpuIdEAX2_ECX16_23_CacheAndTLBDescriptorInformation2 = cpuHelper.GetEAX2_ECX16_23_CacheAndTLBDescriptorInformation2X();
            textBoxEAX2_ECX16_23_CacheAndTLBDescriptorInformation2.Text = cpuIdEAX2_ECX16_23_CacheAndTLBDescriptorInformation2;

            textBoxEAX2_ECX16_23_CacheAndTLBDescriptorInformation2Desc.Text = GetCacheAndTableDescriptor(int.TryParse(cpuIdEAX2_ECX16_23_CacheAndTLBDescriptorInformation2, out int cacheDescriptor8) ? cacheDescriptor8 : 0);

            string cpuIdEAX2_ECX24_31_CacheAndTLBDescriptorInformation3 = cpuHelper.GetEAX2_ECX24_31_CacheAndTLBDescriptorInformation3X();
            textBoxEAX2_ECX24_31_CacheAndTLBDescriptorInformation3.Text = cpuIdEAX2_ECX24_31_CacheAndTLBDescriptorInformation3;

            textBoxEAX2_ECX24_31_CacheAndTLBDescriptorInformation3Desc.Text = GetCacheAndTableDescriptor(int.TryParse(cpuIdEAX2_ECX24_31_CacheAndTLBDescriptorInformation3, out int cacheDescriptor9) ? cacheDescriptor9 : 0);

            bool cpuIdEAX2_EDX31_IsInvalidCacheAndTLBDescriptors = cpuHelper.GetEAX2_EDX31_IsInvalidCacheAndTblDescriptorsEDXX();
            checkBoxEAX2_EDX31_IsInvalidCacheAndTLBDescriptors.Checked = cpuIdEAX2_EDX31_IsInvalidCacheAndTLBDescriptors;

            string cpuIdEAX2_EDX8_15_CacheAndTLBDescriptorInformation1 = cpuHelper.GetEAX2_EDX8_15_CacheAndTLBDescriptorInformation1X();
            textBoxEAX2_EDX8_15_CacheAndTLBDescriptorInformation1.Text = cpuIdEAX2_EDX8_15_CacheAndTLBDescriptorInformation1;

            textBoxEAX2_EDX8_15_CacheAndTLBDescriptorInformation1Desc.Text = GetCacheAndTableDescriptor(int.TryParse(cpuIdEAX2_EDX8_15_CacheAndTLBDescriptorInformation1, out int cacheDescriptor10) ? cacheDescriptor10 : 0);

            string cpuIdEAX2_EDX16_23_CacheAndTLBDescriptorInformation2 = cpuHelper.GetEAX2_EDX16_23_CacheAndTLBDescriptorInformation2X();
            textBoxEAX2_EDX16_23_CacheAndTLBDescriptorInformation2.Text = cpuIdEAX2_EDX16_23_CacheAndTLBDescriptorInformation2;

            textBoxEAX2_EDX16_23_CacheAndTLBDescriptorInformation2Desc.Text = GetCacheAndTableDescriptor(int.TryParse(cpuIdEAX2_EDX16_23_CacheAndTLBDescriptorInformation2, out int cacheDescriptor11) ? cacheDescriptor11 : 0);

            string cpuIdEAX2_EDX24_31_CacheAndTLBDescriptorInformation3 = cpuHelper.GetEAX2_EDX24_31_CacheAndTLBDescriptorInformation3X();
            textBoxEAX2_EDX24_31_CacheAndTLBDescriptorInformation3.Text = cpuIdEAX2_EDX24_31_CacheAndTLBDescriptorInformation3;

            textBoxEAX2_EDX24_31_CacheAndTLBDescriptorInformation3Desc.Text = GetCacheAndTableDescriptor(int.TryParse(cpuIdEAX2_EDX24_31_CacheAndTLBDescriptorInformation3, out int cacheDescriptor12) ? cacheDescriptor12 : 0);

            #endregion

            #region 

            string GetCacheType(int cacheType)
            {
                string type;
                switch (cacheType)
                {
                    case 0:
                        type = "No more caches";
                        break;
                    case 1:
                        type = "Data Cache";
                        break;
                    case 2:
                        type = "Instruction Cache";
                        break;
                    case 3:
                        type = "Unified Cache";
                        break;
                    default:
                        // 4 - 31 are reserved
                        type = "Reserved";
                        break;
                }
                return type;
            }

            string GetCacheAndTableDescriptor(int descriptor)
            {
                string description;

                switch (descriptor)
                {
                    case 0x00:
                        description = "Other information: null descriptor";
                        break;
                    case 0x01:
                        description = "Instruction TLB: 4 KByte pages, 4-way set associative, 32 entries";
                        break;
                    case 0x02:
                        description = "Instruction TLB: 2 MByte pages, fully associative, 2 entries";
                        break;
                    case 0x03:
                        description = "Data TLB: 4 KByte pages, 4-way set associative, 64 entries";
                        break;
                    case 0x04:
                        description = "Data TLB: 4 MByte pages, 4-way set associative, 8 entries";
                        break;
                    case 0x05:
                        description = "Data TLB: 4 MByte pages, fully associative, 32 entries";
                        break;
                    case 0x06:
                        description = "Level-1 instruction cache: 8 KBytes, 4-way set associative, 32 byte line size";
                        break;
                    case 0x08:
                        description = "Level-1 instruction cache: 16 KBytes, 4-way set associative, 32 byte line size";
                        break;
                    case 0x09:
                        description = "Level-1 instruction cache: 32 KBytes, 4-way set associative, 64 byte line size";
                        break;
                    case 0x0A:
                        description = "Level-1 data cache: 8 KBytes, 2-way set associative, 32 byte line size";
                        break;
                    case 0x0B:
                        description = "Instruction TLB: 4 MByte pages, fully associative, 4 entries";
                        break;
                    case 0x0C:
                        description = "Level-1 data cache: 16 KBytes, 4-way set associative, 32 byte line size";
                        break;
                    case 0x0D:
                        description = "Level-1 data cache: 16 KBytes, 4-way set associative, 64 byte line size";
                        break;
                    case 0x0E:
                        description = "Level-1 data cache: 24 KBytes, 6-way set associative, 64 byte line size";
                        break;
                    case 0x0F:
                        description = "Reserved";
                        break;
                    case 0x11:
                        description = "Level-1 data cache: 16 KBytes, 4-way set associative, 32 byte line size";
                        break;
                    case 0x12:
                    case 0x13:
                    case 0x14:
                        description = "Reserved";
                        break;
                    case 0x15:
                        description = "Level-1 instruction cache: 16 KBytes, 2-way set associative, 32 byte line size";
                        break;
                    case 0x16:
                    case 0x17:
                    case 0x18:
                    case 0x19:
                        description = "Reserved";
                        break;
                    case 0x1A:
                        description = "Level-2 cache: 96 KBytes, 6-way set associative, 64 byte line size";
                        break;
                    case 0x1B:
                    case 0x1C:
                        description = "Reserved";
                        break;
                    case 0x1D:
                        description = "Level-2 cache: 128 KBytes, 2-way set associative, 64 byte line size";
                        break;
                    case 0x1E:
                    case 0x1F:
                    case 0x20:
                        description = "Reserved";
                        break;
                    case 0x21:
                        description = "Level-2 cache: 256 KBytes, 8-way set associative, 64 byte line size";
                        break;
                    case 0x22:
                        description = "Level-3 cache: 512 KBytes, 4-way set associative, 64 byte line size, cache uses sectors of 2 cache-lines each";
                        break;
                    case 0x23:
                        description = "Level-3 cache: 1 MByte, 8-way set associative, 64 byte line size, cache uses sectors of 2 cache-lines each";
                        break;
                    case 0x24:
                        description = "Level-2 cache: 1 MByte, 16-way set associative, 64 byte line size";
                        break;
                    case 0x25:
                        description = "Level-3 cache: 2 MBytes, 8-way set associative, 64 byte line size, cache uses sectors of 2 cache-lines each";
                        break;
                    case 0x26:
                    case 0x27:
                    case 0x28:
                        description = "(128-byte prefetch), Unused in any known CPU.";
                        break;
                    case 0x29:
                        description = "Level-3 cache: 4 MBytes, 8-way set associative, 64 byte line size, cache uses sectors of 2 cache-lines each";
                        break;
                    case 0x2A:
                    case 0x2B:
                        description = "Reserved";
                        break;
                    case 0x2C:
                        description = "Level-1 data cache: 32 KBytes, 8-way set associative, 64 byte line size";
                        break;
                    case 0x2D:
                    case 0x2E:
                    case 0x2F:
                        description = "Reserved";
                        break;
                    case 0x30:
                        description = "Level-1 instruction cache: 32 KBytes, 8-way set associative, 64 byte line size";
                        break;
                    case 0x31:
                    case 0x32:
                    case 0x33:
                    case 0x34:
                    case 0x35:
                    case 0x36:
                    case 0x37:
                    case 0x38:
                        description = "Reserved";
                        break;
                    case 0x39:
                        description = "Level-2 cache: 128 KBytes, 4-way set associative, 64 byte line size, cache uses sectors of 2 cache-lines each";
                        break;
                    case 0x3A:
                        description = "Level-2 cache: 192 KBytes, 6-way set associative, 64 byte line size, cache uses sectors of 2 cache-lines each";
                        break;
                    case 0x3B:
                        description = "Level-2 cache: 128 KBytes, 2-way set associative, 64 byte line size, cache uses sectors of 2 cache-lines each";
                        break;
                    case 0x3C:
                        description = "Level-2 cache: 256 KBytes, 4-way set associative, 64 byte line size, cache uses sectors of 2 cache-lines each";
                        break;
                    case 0x3D:
                        description = "Level-2 cache: 384 KBytes, 6-way set associative, 64 byte line size, cache uses sectors of 2 cache-lines each";
                        break;
                    case 0x3E:
                        description = "Level-2 cache: 512 KBytes, 4-way set associative, 64 byte line size, cache uses sectors of 2 cache-lines each";
                        break;
                    case 0x3F:
                        description = "Level-2 cache: 256 KBytes, 2-way set associative, 64 byte line size";
                        break;
                    case 0x40:
                        description = "Other information: no L3 cache present";
                        break;
                    case 0x41:
                        description = "Level-2 cache: 128 KBytes, 4-way set associative, 32 byte line size";
                        break;
                    case 0x42:
                        description = "Level-2 cache: 256 KBytes, 4-way set associative, 32 byte line size";
                        break;
                    case 0x43:
                        description = "Level-2 cache: 512 KBytes, 4-way set associative, 32 byte line size";
                        break;
                    case 0x44:
                        description = "Level-2 cache: 1 MByte, 4-way set associative, 32 byte line size";
                        break;
                    case 0x45:
                        description = "Level-2 cache: 2 MBytes, 4-way set associative, 32 byte line size";
                        break;
                    case 0x46:
                        description = "Level-3 cache: 4 MBytes, 4-way set associative, 64 byte line size";
                        break;
                    case 0x47:
                        description = "Level-3 cache: 8 MBytes, 8-way set associative, 64 byte line size";
                        break;
                    case 0x48:
                        description = "Level-2 cache: 3 MBytes, 12-way set associative, 64 byte line size";
                        break;
                    case 0x49:
                        description = "Level-2/Level-3 cache: 4 MBytes, 16-way set associative, 64 byte line size";
                        break;
                    case 0x4A:
                        description = "Level-3 cache: 6 MBytes, 12-way set associative, 64 byte line size";
                        break;
                    case 0x4B:
                        description = "Level-3 cache: 8 MBytes, 16-way set associative, 64 byte line size";
                        break;
                    case 0x4C:
                        description = "Level-3 cache: 12 MBytes, 12-way set associative, 64 byte line size";
                        break;
                    case 0x4D:
                        description = "Level-3 cache: 16 MBytes, 16-way set associative, 64 byte line size";
                        break;
                    case 0x4E:
                        description = "Level-2 cache: 6 MBytes, 24-way set associative, 64 byte line size";
                        break;
                    case 0x4F:
                        description = "Instruction TLB: 4 KByte pages, 32 entries";
                        break;
                    case 0x50:
                        description = "Instruction TLB: 4 KByte/2 MByte/4 MByte pages, fully associative, 64 entries";
                        break;
                    case 0x51:
                        description = "Instruction TLB: 4 KByte/2 MByte/4 MByte pages, fully associative, 128 entries";
                        break;
                    case 0x52:
                        description = "Instruction TLB: 4 KByte/2 MByte/4 MByte pages, fully associative, 256 entries";
                        break;
                    case 0x53:
                    case 0x54:
                        description = "Reserved";
                        break;
                    case 0x55:
                        description = "Instruction TLB: 2 MByte/4 MByte pages, fully associative, 7 entries";
                        break;
                    case 0x56:
                        description = "Data TLB: 4 MByte pages, 4-way set associative, 16 entries";
                        break;
                    case 0x57:
                        description = "Data TLB: 4 KByte pages, 4-way set associative, 16 entries";
                        break;
                    case 0x58:
                        description = "Reserved";
                        break;
                    case 0x59:
                        description = "Data TLB: 4 KByte pages, fully associative, 16 entries";
                        break;
                    case 0x5A:
                        description = "Data TLB: 2 MByte/4 MByte pages, 4-way set associative, 32 entries";
                        break;
                    case 0x5B:
                        description = "Data TLB: 4 KByte/4 MByte pages, fully associative, 64 entries";
                        break;
                    case 0x5C:
                        description = "Data TLB: 4 KByte/4 MByte pages, fully associative, 128 entries";
                        break;
                    case 0x5D:
                        description = "Data TLB: 4 KByte/4 MByte pages, fully associative, 256 entries";
                        break;
                    case 0x5E:
                    case 0x5F:
                        description = "Reserved";
                        break;
                    case 0x60:
                        description = "Level-1 data cache: 16 KBytes, 8-way set associative, 64 byte line size";
                        break;
                    case 0x61:
                        description = "Instruction TLB: 4 KByte pages, fully associative, 48 entries";
                        break;
                    case 0x62:
                        description = "Reserved";
                        break;
                    case 0x63:
                        description = "2 Data TLBs: Table 1: 2 MByte/4 MByte pages, 4-way set associative, 4 entries and Table 2: 1 GByte pages, fully associative, 32 entries";
                        break;
                    case 0x64:
                        description = "Data TLB: 4 KByte pages, 4-way set associative, 512 entries";
                        break;
                    case 0x65:
                        description = "Reserved";
                        break;
                    case 0x66:
                        description = "Level-1 data cache: 8 KBytes, 4-way set associative, 64 byte line size";
                        break;
                    case 0x67:
                        description = "Level-1 data cache: 16 KBytes, 4-way set associative, 64 byte line size";
                        break;
                    case 0x68:
                        description = "Level-1 data cache: 32 KBytes, 4-way set associative, 64 byte line size";
                        break;
                    case 0x69:
                        description = "Reserved";
                        break;
                    case 0x6A:
                        description = "Data TLB: 4 KByte pages, 8-way set associative, 64 entries";
                        break;
                    case 0x6B:
                        description = "Data TLB: 4 KByte pages, 8-way set associative, 256 entries";
                        break;
                    case 0x6C:
                        description = "Data TLB: 2 MByte/4 MByte pages, 8-way set associative, 128 entries";
                        break;
                    case 0x6D:
                        description = "Data TLB: 1 GByte pages, fully associative, 16 entries";
                        break;
                    case 0x6E:
                    case 0x6F:
                        description = "Reserved";
                        break;
                    case 0x70:
                        description = "Trace cache: 12 K-μop, 8-way set associative";
                        break;
                    case 0x71:
                        description = "Trace cache: 16 K-μop, 8-way set associative";
                        break;
                    case 0x72:
                        description = "Trace cache: 32 K-μop, 8-way set associative";
                        break;
                    case 0x73:
                        description = "Trace cache: 64 K-μop, 8-way set associative";
                        break;
                    case 0x74:
                    case 0x75:
                        description = "Reserved";
                        break;
                    case 0x76:
                        description = "Instruction TLB: 2 MByte/4 MByte pages, fully associative, 8 entries";
                        break;
                    case 0x77:
                        description = "Level-1 instruction cache: 16 KBytes, 4-way set associative, 64 byte line size";
                        break;
                    case 0x78:
                        description = "Level-2 cache: 1 MByte, 4-way set associative, 64 byte line size";
                        break;
                    case 0x79:
                        description = "Level-2 cache: 128 KBytes, 8-way set associative, 64 byte line size, cache uses sectors of 2 cache-lines each";
                        break;
                    case 0x7A:
                        description = "Level-2 cache: 256 KBytes, 8-way set associative, 64 byte line size, cache uses sectors of 2 cache-lines each";
                        break;
                    case 0x7B:
                        description = "Level-2 cache: 512 KBytes, 8-way set associative, 64 byte line size, cache uses sectors of 2 cache-lines each";
                        break;
                    case 0x7C:
                        description = "Level-2 cache: 1 MByte, 8-way set associative, 64 byte line size, cache uses sectors of 2 cache-lines each";
                        break;
                    case 0x7D:
                        description = "Level-2 cache: 2 MBytes, 8-way set associative, 64 byte line size";
                        break;
                    case 0x7E:
                        description = "Level-2 cache: 256 KBytes, 8-way set associative, 128 byte line size";
                        break;
                    case 0x7F:
                        description = "Level-2 cache: 512 KBytes, 2-way set associative, 64 byte line size";
                        break;
                    case 0x80:
                        description = "Level-2 cache: 512 KBytes, 8-way set associative, 64 byte line size";
                        break;
                    case 0x81:
                        description = "Level-2 cache: 128 KBytes, 8-way set associative, 32 byte line size";
                        break;
                    case 0x82:
                        description = "Level-2 cache: 256 KBytes, 8-way set associative, 32 byte line size";
                        break;
                    case 0x83:
                        description = "Level-2 cache: 512 KBytes, 8-way set associative, 32 byte line size";
                        break;
                    case 0x84:
                        description = "Level-2 cache: 1 MByte, 8-way set associative, 32 byte line size";
                        break;
                    case 0x85:
                        description = "Level-2 cache: 2 MBytes, 8-way set associative, 32 byte line size";
                        break;
                    case 0x86:
                        description = "Level-2 cache: 512 KBytes, 4-way set associative, 64 byte line size";
                        break;
                    case 0x87:
                        description = "Level-2 cache: 1 MByte, 8-way set associative, 64 byte line size";
                        break;
                    case 0x88:
                        description = "Level-3 cache: 2 MBytes, 4-way set associative, 64 byte line size";
                        break;
                    case 0x89:
                        description = "Level-3 cache: 4 MBytes, 4-way set associative, 64 byte line size";
                        break;
                    case 0x8A:
                        description = "Level-3 cache: 8 MBytes, 4-way set associative, 64 byte line size";
                        break;
                    case 0x8B:
                    case 0x8C:
                        description = "Reserved";
                        break;
                    case 0x8D:
                        description = "Level-3 cache: 3 MBytes, 12-way set associative, 128 byte line size";
                        break;
                    case 0x8E:
                    case 0x8F:
                        description = "Reserved";
                        break;
                    case 0x90:
                        description = "Instruction TLB: 4 KByte - 256 MByte pages, fully associative, 64 entries";
                        break;
                    case 0x91:
                    case 0x92:
                    case 0x93:
                    case 0x94:
                    case 0x95:
                        description = "Reserved";
                        break;
                    case 0x96:
                        description = "Data TLB: 4 KByte - 256 MByte pages, fully associative, 32 entries";
                        break;
                    case 0x97:
                    case 0x98:
                    case 0x99:
                    case 0x9A:
                        description = "Reserved";
                        break;
                    case 0x9B:
                        description = "Data TLB: 4 KByte - 256 MByte pages, fully associative, 96 entries";
                        break;
                    case 0x9C:
                    case 0x9D:
                    case 0x9E:
                    case 0x9F:
                        description = "Reserved";
                        break;
                    case 0xA0:
                        description = "Data TLB: 4 KByte pages, fully associative, 32 entries";
                        break;
                    case 0xA1:
                    case 0xA2:
                    case 0xA3:
                    case 0xA4:
                    case 0xA5:
                    case 0xA6:
                    case 0xA7:
                    case 0xA8:
                    case 0xA9:
                    case 0xAA:
                    case 0xAB:
                    case 0xAC:
                    case 0xAD:
                    case 0xAE:
                    case 0xAF:
                        description = "Reserved";
                        break;
                    case 0xB0:
                        description = "Instruction TLB: 4 KByte pages, 4-way set associative, 128 entries";
                        break;
                    case 0xB1:
                        description = "Instruction TLB: 2 MByte / 4 MByte pages, 4-way set associative, 8 entries";
                        break;
                    case 0xB2:
                        description = "Instruction TLB: 4 MByte pages, 4-way set associative, 64 entries";
                        break;
                    case 0xB3:
                        description = "Data TLB: 4 KByte pages, 4-way set associative, 128 entries";
                        break;
                    case 0xB4:
                        description = "Data TLB: 4 KByte pages, 4-way set associative, 256 entries";
                        break;
                    case 0xB5:
                        description = "Instruction TLB: 4 KByte pages, 8-way set associative, 64 entries";
                        break;
                    case 0xB6:
                        description = "Instruction TLB: 4 KByte pages, 8-way set associative, 128 entries";
                        break;
                    case 0xB7:
                    case 0xB8:
                    case 0xB9:
                        description = "Reserved";
                        break;
                    case 0xBA:
                        description = "Data TLB: 4 KByte pages, 4-way set associative, 64 entries";
                        break;
                    case 0xBB:
                    case 0xBC:
                    case 0xBD:
                    case 0xBE:
                    case 0xBF:
                        description = "Reserved";
                        break;
                    case 0xC0:
                        description = "Data TLB: 4 KByte / 4 MByte pages, 4-way set associative, 8 entries";
                        break;
                    case 0xC1:
                        description = "Level-2 shared TLB: 4 KByte / 2 MByte pages, 8-way set associative, 1024 entries";
                        break;
                    case 0xC2:
                        description = "Data TLB: 2 MByte / 4 MByte pages, 4-way set associative, 16 entries";
                        break;
                    case 0xC3:
                        description = "Two Level-2 shared TLBs: Table 1: 4 KByte / 2 MByte pages, 6-way set associative, 1536 entries and Table 2: 1 GByte pages, 4-way set associative, 16 entries";
                        break;
                    case 0xC4:
                        description = "Data TLB: 2 MByte / 4 MByte pages, 4-way set associative, 32 entries";
                        break;
                    case 0xC5:
                    case 0xC6:
                    case 0xC7:
                    case 0xC8:
                    case 0xC9:
                        description = "Reserved";
                        break;
                    case 0xCA:
                        description = "Level-2 shared TLB: 4 KByte pages, 4-way set associative, 512 entries";
                        break;
                    case 0xCB:
                    case 0xCC:
                    case 0xCD:
                    case 0xCE:
                    case 0xCF:
                        description = "Reserved";
                        break;
                    case 0xD0:
                        description = "Level-3 cache: 512 KBytes, 4-way set associative, 64 byte line size";
                        break;
                    case 0xD1:
                        description = "Level-3 cache: 1 MByte, 4-way set associative, 64 byte line size";
                        break;
                    case 0xD2:
                        description = "Level-3 cache: 2 MBytes, 4-way set associative, 64 byte line size";
                        break;
                    case 0xD3:
                    case 0xD4:
                    case 0xD5:
                        description = "Reserved";
                        break;
                    case 0xD6:
                        description = "Level-3 cache: 1 MByte, 8-way set associative, 64 byte line size";
                        break;
                    case 0xD7:
                        description = "Level-3 cache: 2 MBytes, 8-way set associative, 64 byte line size";
                        break;
                    case 0xD8:
                        description = "Level-3 cache: 4 MBytes, 8-way set associative, 64 byte line size";
                        break;
                    case 0xD9:
                    case 0xDA:
                    case 0xDB:
                        description = "Reserved";
                        break;
                    case 0xDC:
                        description = "Level-3 cache: 1.5 MBytes, 12-way set associative, 64 byte line size";
                        break;
                    case 0xDD:
                        description = "Level-3 cache: 3 MBytes, 12-way set associative, 64 byte line size";
                        break;
                    case 0xDE:
                        description = "Level-3 cache: 6 MBytes, 12-way set associative, 64 byte line size";
                        break;
                    case 0xDF:
                    case 0xE0:
                    case 0xE1:
                        description = "Reserved";
                        break;
                    case 0xE2:
                        description = "Level-3 cache: 2 MBytes, 16-way set associative, 64 byte line size";
                        break;
                    case 0xE3:
                        description = "Level-3 cache: 4 MBytes, 16-way set associative, 64 byte line size";
                        break;
                    case 0xE4:
                        description = "Level-3 cache: 8 MBytes, 16-way set associative, 64 byte line size";
                        break;
                    case 0xE5:
                    case 0xE6:
                    case 0xE7:
                    case 0xE8:
                    case 0xE9:
                        description = "Reserved";
                        break;
                    case 0xEA:
                        description = "Level-3 cache: 12 MBytes, 24-way set associative, 64 byte line size";
                        break;
                    case 0xEB:
                        description = "Level-3 cache: 18 MBytes, 24-way set associative, 64 byte line size";
                        break;
                    case 0xEC:
                        description = "Level-3 cache: 24 MBytes, 24-way set associative, 64 byte line size";
                        break;
                    case 0xED:
                    case 0xEE:
                    case 0xEF:
                        description = "Reserved";
                        break;
                    case 0xF0:
                        description = "Other information: 64-byte prefetch";
                        break;
                    case 0xF1:
                        description = "Other information: 128-byte prefetch";
                        break;
                    case 0xF2:
                    case 0xF3:
                    case 0xF4:
                    case 0xF5:
                    case 0xF6:
                    case 0xF7:
                    case 0xF8:
                    case 0xF9:
                    case 0xFA:
                    case 0xFB:
                    case 0xFC:
                    case 0xFD:
                        description = "Reserved";
                        break;
                    case 0xFE:
                        description = "Other information: Leaf 2 has no TLB info, use leaf 18h";
                        break;
                    case 0xFF:
                        description = "Other information: Leaf 2 has no cache info, use leaf 4";
                        break;
                    default:
                        description = "Unknown descriptor";
                        break;
                }

                return description;
            }

            #endregion
        }
    }
}
