/*
    File           EAX14ECX1.cs
    Brief          Form for displaying EAX=0x14, ECX=0x1 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX14ECX1 : Form
    {

        private CPUHelper cpuHelper;

        public EAX14ECX1()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x14, ECX=0x1: Processor Trace packet generation information in EAX, EBX and ECX

            string cpuIdEAX14ECX1EAXX = cpuHelper.GetEAX14ECX1EAXX();
            textBoxEAX14ECX1EAX.Text = cpuIdEAX14ECX1EAXX;

            string cpuIdEAX14ECX1EBX = cpuHelper.GetEAX14ECX1EBXX();
            textBoxEAX14ECX1EBX.Text = cpuIdEAX14ECX1EBX;

            string cpuIdEAX14ECX1ECX = cpuHelper.GetEAX14ECX1ECXX();
            textBoxEAX14ECX1ECX.Text = cpuIdEAX14ECX1ECX;

            string cpuIdEAX14ECX1EDX = cpuHelper.GetEAX14ECX1EDXX();
            textBoxEAX14ECX1EDX.Text = cpuIdEAX14ECX1EDX;

            #endregion
        }
    }
}
