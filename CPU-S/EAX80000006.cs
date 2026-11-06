/*
    File           EAX80000006.cs
    Brief          Form for displaying EAX=0x80000006 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           11/04/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX80000006 : Form
    {
        private CPUHelper cpuHelper;

        public EAX80000006()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            foreach (TextBox textBox in this.GetAllControlsOfType<TextBox>())
            {
                textBox.ReadOnly = true;
            }

            foreach (CheckBox checkBox in this.GetAllControlsOfType<CheckBox>())
            {
                checkBox.AutoCheck = false;
            }

            #region L2/L3 cache and L2 TLB configuration descriptors

            string cpuIdEAX80000006EAX = cpuHelper.GetEAX80000006EAXX();
            textBoxEAX.Text = cpuIdEAX80000006EAX;

            string cpuIdEAX80000006EBX = cpuHelper.GetEAX80000006EBXX();
            textBoxEBX.Text = cpuIdEAX80000006EBX;

            string cpuIdEAX80000006ECX = cpuHelper.GetEAX80000006ECXX();
            textBoxECX.Text = cpuIdEAX80000006ECX;

            string cpuIdEAX80000006EDX = cpuHelper.GetEAX80000006EDXX();
            textBoxEDX.Text = cpuIdEAX80000006EDX;

            textBoxEAXCodeTableEntries.Text = cpuHelper.GetEAX80000006EAX0_11_CodeTableEntriesX();
            textBoxEAXCodeTableAssociativity.Text = cpuHelper.GetEAX80000006EAX12_15_CodeTableAssociativityX();
            textBoxEAXDataTableEntries.Text = cpuHelper.GetEAX80000006EAX16_27_DataTableEntriesX();
            textBoxEAXDataTableAssociativity.Text = cpuHelper.GetEAX80000006EAX28_31_DataTableAssociativityX();

            textBoxEBXCodeTableEntries.Text = cpuHelper.GetEAX80000006EBX0_11_CodeTableEntriesX();
            textBoxEBXCodeTableAssociativity.Text = cpuHelper.GetEAX80000006EBX12_15_CodeTableAssociativityX();
            textBoxEBXDataTableEntries.Text = cpuHelper.GetEAX80000006EBX16_27_DataTableEntriesX();
            textBoxEBXDataTableAssociativity.Text = cpuHelper.GetEAX80000006EBX28_31_DataTableAssociativityX();

            textBoxECXUnifiedL2CacheLinaSizeInBytes.Text = cpuHelper.GetEAX80000006ECX0_7_UnifiedL2CacheLineSizeX();
            textBoxECXUnifiedL2CacheLinesPerTag.Text = cpuHelper.GetEAX80000006ECX8_11_UnifiedL2CacheLinesPerTagX();
            textBoxECXUnifiedL2CacheAssociativity.Text = cpuHelper.GetEAX80000006ECX12_15_UnifiedL2CacheAssociativityX();
            textBoxECXUnifiedL2CacheSizeInKBs.Text = cpuHelper.GetEAX80000006ECX16_31_UnifiedL2CacheSizeX();

            textBoxEDXUnifiedL3CacheLinaSizeInBytes.Text = cpuHelper.GetEAX80000006EDX0_7_UnifiedL3CacheLineSizeX();
            textBoxEDXUnifiedL3CacheLinesPerTag.Text = cpuHelper.GetEAX80000006EDX8_11_UnifiedL3CacheLinesPerTagX();
            textBoxEDXUnifiedL3CacheAssociativity.Text = cpuHelper.GetEAX80000006EDX12_15_UnifiedL3CacheAssociativityX();
            textBoxEDXReserved.Text = cpuHelper.GetEAX80000006EDX16_17_ReservedX();
            textBoxEDXUnifiedL3CacheSizeIn512KBChunks.Text = cpuHelper.GetEAX80000006EDX18_31_UnifiedL3CacheSizeX();

            #endregion
        }
    }
}
