/*
    File           EAX80000006_AMD.cs
    Brief          Form for displaying EAX=0x80000006 AMD CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           11/04/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX80000006_AMD : Form
    {

        private CPUHelper cpuHelper;

        public EAX80000006_AMD()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x80000006: Extended L2 Cache Features (AMD)

            string cpuIdEAX80000006EAX = cpuHelper.GetEAX80000006EAXX();
            textBoxEAX80000006EAX.Text = cpuIdEAX80000006EAX;

            string cpuIdEAX80000006EBX = cpuHelper.GetEAX80000006EBXX();
            textBoxEAX80000006EBX.Text = cpuIdEAX80000006EBX;

            string cpuIdEAX80000006ECX = cpuHelper.GetEAX80000006ECXX();
            textBoxEAX80000006ECX.Text = cpuIdEAX80000006ECX;

            string cpuIdEAX80000006EDX = cpuHelper.GetEAX80000006EDXX();
            textBoxEAX80000006EDX.Text = cpuIdEAX80000006EDX;

            textBoxEAXITE.Text = cpuHelper.GetEAX80000006EAX0_11_L2TableParameters2M4MPagesInstructionTableEntriesX();
            textBoxEAXITA.Text = cpuHelper.GetEAX80000006EAX12_15_L2TableParameters2M4MPagesInstructionTableAssociativityX();
            textBoxEAXDTE.Text = cpuHelper.GetEAX80000006EAX16_27_L2TableParameters2M4MPagesDataTableEntriesX();
            textBoxEAXDTA.Text = cpuHelper.GetEAX80000006EAX28_31_L2TableParameters2M4MPagesDataTableAssociativityX();

            textBoxEBXITE.Text = cpuHelper.GetEAX80000006EBX0_11_L2TableParameters4KPagesInstructionTableEntriesX();
            textBoxEBXITA.Text = cpuHelper.GetEAX80000006EBX12_15_L2TableParameters4KPagesInstructionTableAssociativityX();
            textBoxEBXDTE.Text = cpuHelper.GetEAX80000006EBX16_27_L2TableParameters4KPagesDataTableEntriesX();
            textBoxEBXDTA.Text = cpuHelper.GetEAX80000006EBX28_31_L2TableParameters4KPagesDataTableAssociativityX();

            textBoxLineSize.Text = cpuHelper.GetEAX80000006ECX0_7_CacheLineSizeX();
            textBoxLinesPerTag.Text = cpuHelper.GetEAX80000006ECX8_11_LPTX();
            string associativityType = cpuHelper.GetEAX80000006ECX12_15_L2AssociativityX();

            textBoxAssociativityType.Text = associativityType;

            int cpuIdEAX80000006ECX_AssociativityValue = int.TryParse(associativityType, out int associativityValue) ? associativityValue : -1;

            switch (cpuIdEAX80000006ECX_AssociativityValue)
            {
                case 0x0:
                    textBoxAssociativityTypeHuman.Text = "Disabled";
                    break;
                case 0x1:
                    textBoxAssociativityTypeHuman.Text = "Direct mapped";
                    break;
                case 0x2:
                    textBoxAssociativityTypeHuman.Text = "2-way associative";
                    break;
                case 0x4:
                    textBoxAssociativityTypeHuman.Text = "4-way associative";
                    break;
                case 0x6:
                    textBoxAssociativityTypeHuman.Text = "8-way associative";
                    break;
                case 0x8:
                    textBoxAssociativityTypeHuman.Text = "16-way associative";
                    break;
                case 0xF:
                    textBoxAssociativityTypeHuman.Text = "Fully associative";
                    break;
                default:
                    textBoxAssociativityTypeHuman.Text = "Reserved/Unknown";
                    break;
            }

            textBoxCacheSize.Text = cpuHelper.GetEAX80000006ECX16_31_CacheSizeX();

            textBoxReservedEDX.Text = cpuHelper.GetEAX80000006EDX0_31_ReservedX();

            #endregion
        }
    }
}
