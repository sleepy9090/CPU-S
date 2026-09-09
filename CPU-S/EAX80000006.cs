/*
    File           EAX80000006.cs
    Brief          Form for displaying EAX=0x80000006 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
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

            #region EAX=0x80000006: Extended L2 Cache Features

            string cpuIdEAX80000006EAX = cpuHelper.GetEAX80000006EAXX();
            textBoxEAX80000006EAX.Text = cpuIdEAX80000006EAX;

            string cpuIdEAX80000006EBX = cpuHelper.GetEAX80000006EBXX();
            textBoxEAX80000006EBX.Text = cpuIdEAX80000006EBX;

            string cpuIdEAX80000006ECX = cpuHelper.GetEAX80000006ECXX();
            textBoxEAX80000006ECX.Text = cpuIdEAX80000006ECX;

            string cpuIdEAX80000006EDX = cpuHelper.GetEAX80000006EDXX();
            textBoxEAX80000006EDX.Text = cpuIdEAX80000006EDX;

            string cpuIdEAX80000006ECX_LineSize = cpuHelper.GetEAX80000006ECX_LineSizeX();
            textBoxLineSize.Text = cpuIdEAX80000006ECX_LineSize;

            string cpuIdEAX80000006ECX_Associativity = cpuHelper.GetEAX80000006ECX_AssociativityX();
            textBoxAssociativityType.Text = cpuIdEAX80000006ECX_Associativity;

            int cpuIdEAX80000006ECX_AssociativityValue = int.TryParse(cpuIdEAX80000006ECX_Associativity, out int associativityValue) ? associativityValue : -1;

            switch(cpuIdEAX80000006ECX_AssociativityValue)
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

            string cpuIdEAX80000006ECX_CacheSize = cpuHelper.GetEAX80000006ECX_CacheSizeX();
            textBoxCacheSize.Text = cpuIdEAX80000006ECX_CacheSize;

            #endregion
        }
    }
}
