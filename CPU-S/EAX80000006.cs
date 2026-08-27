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

            #endregion
        }
    }
}
