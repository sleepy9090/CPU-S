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

            #region L2/L3 cache and L2 TLB configuration descriptors

            string cpuIdEAX80000006EAX = cpuHelper.GetEAX80000006EAXX();
            textBoxEAX.Text = cpuIdEAX80000006EAX;

            string cpuIdEAX80000006EBX = cpuHelper.GetEAX80000006EBXX();
            textBoxEBX.Text = cpuIdEAX80000006EBX;

            string cpuIdEAX80000006ECX = cpuHelper.GetEAX80000006ECXX();
            textBoxECX.Text = cpuIdEAX80000006ECX;

            string cpuIdEAX80000006EDX = cpuHelper.GetEAX80000006EDXX();
            textBoxEDX.Text = cpuIdEAX80000006EDX;

            #endregion
        }
    }
}
