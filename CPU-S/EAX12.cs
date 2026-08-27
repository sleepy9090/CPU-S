/*
    File           EAX12.cs
    Brief          Form for displaying EAX=0x12 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX12 : Form
    {

        private CPUHelper cpuHelper;

        public EAX12()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x12: SGX Capabilities

            string cpuIdEAX12EAX = cpuHelper.GetEAX12EAXX();
            textBoxEAX12EAX.Text = cpuIdEAX12EAX;

            string cpuIdEAX12EBX = cpuHelper.GetEAX12EBXX();
            textBoxEAX12EBX.Text = cpuIdEAX12EBX;

            string cpuIdEAX12ECX = cpuHelper.GetEAX12ECXX();
            textBoxEAX12ECX.Text = cpuIdEAX12ECX;

            string cpuIdEAX12EDX = cpuHelper.GetEAX12EDXX();
            textBoxEAX12EDX.Text = cpuIdEAX12EDX;

            #endregion
        }
    }
}
