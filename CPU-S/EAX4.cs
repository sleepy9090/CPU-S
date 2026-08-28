/*
    File           EAX4.cs
    Brief          Form for displaying EAX=0x4 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX4 : Form
    {

        private CPUHelper cpuHelper;

        public EAX4(int i)
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x4: Cache Hierarchy and Topology

            string cpuIdEAX4EAX = cpuHelper.GetEAX4EAXX(i);
            textBoxEAX4EAX.Text = cpuIdEAX4EAX;

            string cpuIdEAX4EBX = cpuHelper.GetEAX4EBXX(i);
            textBoxEAX4EBX.Text = cpuIdEAX4EBX;

            string cpuIdEAX4ECX = cpuHelper.GetEAX4ECXX(i);
            textBoxEAX4ECX.Text = cpuIdEAX4ECX;

            string cpuIdEAX4EDX = cpuHelper.GetEAX4EDXX(i);
            textBoxEAX4EDX.Text = cpuIdEAX4EDX;

            string cpuIdEAX4EAX0_4_CacheType = cpuHelper.GetEAX4EAX0_4_CacheTypeX(i);
            textBoxCacheType.Text = cpuIdEAX4EAX0_4_CacheType;

            switch (int.Parse(cpuIdEAX4EAX0_4_CacheType))
            {
                case 0:
                    textBoxCacheTypeHuman.Text = "(No more caches)";
                    break;
                case 1:
                    textBoxCacheTypeHuman.Text = "Data Cache";
                    break;
                case 2:
                    textBoxCacheTypeHuman.Text = "Instruction Cache";
                    break;
                case 3:
                    textBoxCacheTypeHuman.Text = "Unified Cache";
                    break;
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                case 26:
                case 27:
                case 28:
                case 29:
                case 30:
                case 31:
                    textBoxCacheTypeHuman.Text = "Unknown";
                    break;
                default:
                    textBoxCacheTypeHuman.Text = "(reserved)";
                    break;
            }

            string cpuIdEAX4EAX5_7_CacheLevel = cpuHelper.GetEAX4EAX5_7_CacheLevelX(i);
            textBoxCacheLevel.Text = cpuIdEAX4EAX5_7_CacheLevel;

            string cpuIdEAX4EAX8_SelfInitCacheLevel = cpuHelper.GetEAX4EAX8_SelfInitCacheLevelX(i);
            textBoxSelfInitializingCacheLevel.Text = cpuIdEAX4EAX8_SelfInitCacheLevel;

            string cpuIdEAX4EAX9_FullyAssociativeCache = cpuHelper.GetEAX4EAX9_FullyAssociativeCacheX(i);
            textBoxFullyAssociativeCache.Text = cpuIdEAX4EAX9_FullyAssociativeCache;

            string cpuIdEAX4EAX10_WBINVDCacheInvalidationExecutionScope = cpuHelper.GetEAX4EAX10_WBINVDCacheInvalidationExecutionScopeX(i);
            textBoxWBINVDCacheInvalidationExecutionScopeEAX.Text = cpuIdEAX4EAX10_WBINVDCacheInvalidationExecutionScope;

            string cpuIdEAX4EAX11_CacheInclusiveness = cpuHelper.GetEAX4EAX11_CacheInclusivenessX(i);
            textBoxCacheInclusivenessEAX.Text = cpuIdEAX4EAX11_CacheInclusiveness;

            string cpuIdEAX4EAX12_13_Reserved = cpuHelper.GetEAX4EAX12_13_ReservedX(i);
            textBoxReserved.Text = cpuIdEAX4EAX12_13_Reserved;

            string cpuIdEAX4EAX14_25_MaxNumAddrIDsForLogicalProcsSharingThisCacheMinusOne = cpuHelper.GetEAX4EAX14_25_MaxNumAddrIDsForLogicalProcsSharingThisCacheMinusOneX(i);
            textBoxMaxNumAddrIDsForLogProcSharingThisCacheMinusOne.Text = cpuIdEAX4EAX14_25_MaxNumAddrIDsForLogicalProcsSharingThisCacheMinusOne;

            string cpuIdEAX4EAX26_31_MaxNumAddrIDsForProcCoresInPhysicalPackageMinusOne = cpuHelper.GetEAX4EAX26_31_MaxNumAddrIDsForProcCoresInPhysicalPackageMinusOneX(i);
            textBoxMaxNumAddrIDsForProcCoresInPhysicalPackageMinusOne.Text = cpuIdEAX4EAX26_31_MaxNumAddrIDsForProcCoresInPhysicalPackageMinusOne;

            string cpuIdEAX4EBX0_11_SystemCoherencyLineSizeInBytesMinusOne = cpuHelper.GetEAX4EBX0_11_SystemCoherencyLineSizeInBytesMinusOneX(i);
            textBoxSystemCoherencyLineSizeInBytesMinusOne.Text = cpuIdEAX4EBX0_11_SystemCoherencyLineSizeInBytesMinusOne;

            string cpuIdEAX4EBX12_21_PhysicalLinePartitionsMinusOne = cpuHelper.GetEAX4EBX12_21_PhysicalLinePartitionsMinusOneX(i);
            textBoxPhysicalLinePartitionsMinusOne.Text = cpuIdEAX4EBX12_21_PhysicalLinePartitionsMinusOne;

            string cpuIdEAX4EBX22_31_WaysOfCacheAssociativityMinusOne = cpuHelper.GetEAX4EBX22_31_WaysOfCacheAssociativityMinusOneX(i);
            textBoxWaysOfCacheAssociativityMinusOne.Text = cpuIdEAX4EBX22_31_WaysOfCacheAssociativityMinusOne;

            string cpuIdEAX4ECX0_31_NumberOfSetsInCacheMinusOne = cpuHelper.GetEAX4ECX0_31_NumberOfSetsInCacheMinusOneX(i);
            textBoxNumberOfSetsInCacheMinusOne.Text = cpuIdEAX4ECX0_31_NumberOfSetsInCacheMinusOne;

            string cpuIdEAX4TotalCacheSizeInBytes = cpuHelper.GetEAX4TotalCacheSizeInBytesX(i);
            textBoxTotalCacheSizeInBytes.Text = cpuIdEAX4TotalCacheSizeInBytes;

            string cpuIdEAX4EDX0_WBINVDCacheInvalidationExecutionScope = cpuHelper.GetEAX4EDX0_WBINVDCacheInvalidationExecutionScopeX(i);
            textBoxWBINVDCacheInvalidationExecutionScopeEDX.Text = cpuIdEAX4EDX0_WBINVDCacheInvalidationExecutionScope;

            string cpuIdEAX4EDX1_CacheInclusiveness = cpuHelper.GetEAX4EDX1_CacheInclusivenessX(i);
            textBoxCacheInclusivenessEDX.Text = cpuIdEAX4EDX1_CacheInclusiveness;

            string cpuIdEAX4EDX2_ComplexCacheIndexing = cpuHelper.GetEAX4EDX2_ComplexCacheIndexingX(i);
            textBoxComplexCacheIndexing.Text = cpuIdEAX4EDX2_ComplexCacheIndexing;

            string cpuIdEAX4EDX3_Reserved = cpuHelper.GetEAX4EDX3_ReservedX(i);
            textBoxReserved3.Text = cpuIdEAX4EDX3_Reserved;

            string cpuIdEAX4EDX4_Reserved = cpuHelper.GetEAX4EDX4_ReservedX(i);
            textBoxReserved4.Text = cpuIdEAX4EDX4_Reserved;

            string cpuIdEAX4EDX5_7_Reserved = cpuHelper.GetEAX4EDX5_7_ReservedX(i);
            textBoxReserved5_7.Text = cpuIdEAX4EDX5_7_Reserved;

            string cpuIdEAX4EDX8_Reserved = cpuHelper.GetEAX4EDX8_ReservedX(i);
            textBoxReserved8.Text = cpuIdEAX4EDX8_Reserved;

            string cpuIdEAX4EDX9_Reserved = cpuHelper.GetEAX4EDX9_ReservedX(i);
            textBoxReserved9.Text = cpuIdEAX4EDX9_Reserved;

            string cpuIdEAX4EDX10_Reserved = cpuHelper.GetEAX4EDX10_ReservedX(i);
            textBoxReserved10.Text = cpuIdEAX4EDX10_Reserved;

            string cpuIdEAX4EDX11_Reserved = cpuHelper.GetEAX4EDX11_ReservedX(i);
            textBoxReserved11.Text = cpuIdEAX4EDX11_Reserved;

            string cpuIdEAX4EDX12_13_Reserved = cpuHelper.GetEAX4EDX12_13_ReservedX(i);
            textBoxReserved12_13.Text = cpuIdEAX4EDX12_13_Reserved;

            string cpuIdEAX4EDX14_21_Reserved = cpuHelper.GetEAX4EDX14_21_ReservedX(i);
            textBoxReserved14_21.Text = cpuIdEAX4EDX14_21_Reserved;

            string cpuIdEAX4EDX22_25_Reserved = cpuHelper.GetEAX4EDX22_25_ReservedX(i);
            textBoxReserved22_25.Text = cpuIdEAX4EDX22_25_Reserved;

            string cpuIdEAX4EDX26_31_Reserved = cpuHelper.GetEAX4EDX26_31_ReservedX(i);
            textBoxReserved26_31.Text = cpuIdEAX4EDX26_31_Reserved;

            #endregion
        }
    }
}
