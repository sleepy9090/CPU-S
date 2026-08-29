/*
    File           EAX8000001D.cs
    Brief          Form for displaying EAX=0x1D CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX8000001D : Form
    {

        private CPUHelper cpuHelper;

        public EAX8000001D(int i)
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x8000001D: Cache Hierarchy and Topology

            string cpuIdEAX8000001DEAX = cpuHelper.GetEAX8000001DEAXX(i);
            textBoxEAX8000001DEAX.Text = cpuIdEAX8000001DEAX;

            string cpuIdEAX8000001DEBX = cpuHelper.GetEAX8000001DEBXX(i);
            textBoxEAX8000001DEBX.Text = cpuIdEAX8000001DEBX;

            string cpuIdEAX8000001DECX = cpuHelper.GetEAX8000001DECXX(i);
            textBoxEAX8000001DECX.Text = cpuIdEAX8000001DECX;

            string cpuIdEAX8000001DEDX = cpuHelper.GetEAX8000001DEDXX(i);
            textBoxEAX8000001DEDX.Text = cpuIdEAX8000001DEDX;

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

            string cpuIdEAX8000001DEAX5_7_CacheLevel = cpuHelper.GetEAX8000001DEAX5_7_CacheLevelX(i);
            textBoxCacheLevel.Text = cpuIdEAX8000001DEAX5_7_CacheLevel;

            string cpuIdEAX8000001DEAX8_SelfInitCacheLevel = cpuHelper.GetEAX8000001DEAX8_SelfInitCacheLevelX(i);
            textBoxSelfInitializingCacheLevel.Text = cpuIdEAX8000001DEAX8_SelfInitCacheLevel;

            string cpuIdEAX8000001DEAX9_FullyAssociativeCache = cpuHelper.GetEAX8000001DEAX9_FullyAssociativeCacheX(i);
            textBoxFullyAssociativeCache.Text = cpuIdEAX8000001DEAX9_FullyAssociativeCache;

            string cpuIdEAX8000001DEAX10_WBINVDCacheInvalidationExecutionScope = cpuHelper.GetEAX8000001DEAX10_WBINVDCacheInvalidationExecutionScopeX(i);
            textBoxWBINVDCacheInvalidationExecutionScopeEAX.Text = cpuIdEAX8000001DEAX10_WBINVDCacheInvalidationExecutionScope;

            string cpuIdEAX8000001DEAX11_CacheInclusiveness = cpuHelper.GetEAX8000001DEAX11_CacheInclusivenessX(i);
            textBoxCacheInclusivenessEAX.Text = cpuIdEAX8000001DEAX11_CacheInclusiveness;

            string cpuIdEAX8000001DEAX12_13_Reserved = cpuHelper.GetEAX8000001DEAX12_13_ReservedX(i);
            textBoxReserved.Text = cpuIdEAX8000001DEAX12_13_Reserved;

            string cpuIdEAX8000001DEAX14_25_MaxNumAddrIDsForLogicalProcsSharingThisCacheMinusOne = cpuHelper.GetEAX8000001DEAX14_25_MaxNumAddrIDsForLogicalProcsSharingThisCacheMinusOneX(i);
            textBoxMaxNumAddrIDsForLogProcSharingThisCacheMinusOne.Text = cpuIdEAX8000001DEAX14_25_MaxNumAddrIDsForLogicalProcsSharingThisCacheMinusOne;

            string cpuIdEAX8000001DEAX26_31_MaxNumAddrIDsForProcCoresInPhysicalPackageMinusOne = cpuHelper.GetEAX8000001DEAX26_31_MaxNumAddrIDsForProcCoresInPhysicalPackageMinusOneX(i);
            textBoxMaxNumAddrIDsForProcCoresInPhysicalPackageMinusOne.Text = cpuIdEAX8000001DEAX26_31_MaxNumAddrIDsForProcCoresInPhysicalPackageMinusOne;

            string cpuIdEAX8000001DEBX0_11_SystemCoherencyLineSizeInBytesMinusOne = cpuHelper.GetEAX8000001DEBX0_11_SystemCoherencyLineSizeInBytesMinusOneX(i);
            textBoxSystemCoherencyLineSizeInBytesMinusOne.Text = cpuIdEAX8000001DEBX0_11_SystemCoherencyLineSizeInBytesMinusOne;

            string cpuIdEAX8000001DEBX12_21_PhysicalLinePartitionsMinusOne = cpuHelper.GetEAX8000001DEBX12_21_PhysicalLinePartitionsMinusOneX(i);
            textBoxPhysicalLinePartitionsMinusOne.Text = cpuIdEAX8000001DEBX12_21_PhysicalLinePartitionsMinusOne;

            string cpuIdEAX8000001DEBX22_31_WaysOfCacheAssociativityMinusOne = cpuHelper.GetEAX8000001DEBX22_31_WaysOfCacheAssociativityMinusOneX(i);
            textBoxWaysOfCacheAssociativityMinusOne.Text = cpuIdEAX8000001DEBX22_31_WaysOfCacheAssociativityMinusOne;

            string cpuIdEAX8000001DECX0_31_NumberOfSetsInCacheMinusOne = cpuHelper.GetEAX8000001DECX0_31_NumberOfSetsInCacheMinusOneX(i);
            textBoxNumberOfSetsInCacheMinusOne.Text = cpuIdEAX8000001DECX0_31_NumberOfSetsInCacheMinusOne;

            string cpuIdEAX8000001DEDX0_WBINVDCacheInvalidationExecutionScope = cpuHelper.GetEAX8000001D_EDX0_WBINVDCacheInvalidationExecutionScopeX(i);
            textBoxWBINVDCacheInvalidationExecutionScopeEDX.Text = cpuIdEAX8000001DEDX0_WBINVDCacheInvalidationExecutionScope;

            string cpuIdEAX8000001DEDX1_CacheInclusiveness = cpuHelper.GetEAX8000001D_EDX1_CacheInclusivenessX(i);
            textBoxCacheInclusivenessEDX.Text = cpuIdEAX8000001DEDX1_CacheInclusiveness;

            string cpuIdEAX8000001DEDX2_ComplexCacheIndexing = cpuHelper.GetEAX8000001D_EDX2_ComplexCacheIndexingX(i);
            textBoxComplexCacheIndexing.Text = cpuIdEAX8000001DEDX2_ComplexCacheIndexing;

            string cpuIdEAX8000001DEDX3_Reserved = cpuHelper.GetEAX8000001D_EDX3_ReservedX(i);
            textBoxReserved3.Text = cpuIdEAX8000001DEDX3_Reserved;

            string cpuIdEAX8000001DEDX4_Reserved = cpuHelper.GetEAX8000001D_EDX4_ReservedX(i);
            textBoxReserved4.Text = cpuIdEAX8000001DEDX4_Reserved;

            string cpuIdEAX8000001DEDX5_7_Reserved = cpuHelper.GetEAX8000001D_EDX5_7_ReservedX(i);
            textBoxReserved5_7.Text = cpuIdEAX8000001DEDX5_7_Reserved;

            string cpuIdEAX8000001DEDX8_Reserved = cpuHelper.GetEAX8000001D_EDX8_ReservedX(i);
            textBoxReserved8.Text = cpuIdEAX8000001DEDX8_Reserved;

            string cpuIdEAX8000001DEDX9_Reserved = cpuHelper.GetEAX8000001D_EDX9_ReservedX(i);
            textBoxReserved9.Text = cpuIdEAX8000001DEDX9_Reserved;

            string cpuIdEAX8000001DEDX10_Reserved = cpuHelper.GetEAX8000001D_EDX10_ReservedX(i);
            textBoxReserved10.Text = cpuIdEAX8000001DEDX10_Reserved;

            string cpuIdEAX8000001DEDX11_Reserved = cpuHelper.GetEAX8000001D_EDX11_ReservedX(i);
            textBoxReserved11.Text = cpuIdEAX8000001DEDX11_Reserved;

            string cpuIdEAX8000001DEDX12_13_Reserved = cpuHelper.GetEAX8000001D_EDX12_13_ReservedX(i);
            textBoxReserved12_13.Text = cpuIdEAX8000001DEDX12_13_Reserved;

            string cpuIdEAX8000001DEDX14_21_Reserved = cpuHelper.GetEAX8000001D_EDX14_21_ReservedX(i);
            textBoxReserved14_21.Text = cpuIdEAX8000001DEDX14_21_Reserved;

            string cpuIdEAX8000001DEDX22_25_Reserved = cpuHelper.GetEAX8000001D_EDX22_25_ReservedX(i);
            textBoxReserved22_25.Text = cpuIdEAX8000001DEDX22_25_Reserved;

            string cpuIdEAX8000001DEDX26_31_Reserved = cpuHelper.GetEAX8000001D_EDX26_31_ReservedX(i);
            textBoxReserved26_31.Text = cpuIdEAX8000001DEDX26_31_Reserved;

            #endregion
        }
    }
}
