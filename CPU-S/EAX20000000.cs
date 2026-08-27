/*
    File           EAX20000000.cs
    Brief          Form for displaying EAX=0x20000000 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX20000000 : Form
    {

        private CPUHelper cpuHelper;

        public EAX20000000()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x20000000: Highest Xeon Phi Function Implemented

            string cpuIdEAX20000000EAX = cpuHelper.GetEAX20000000EAXX();
            textBoxEAX20000000EAX.Text = cpuIdEAX20000000EAX;

            string cpuIdEAX20000000EBX = cpuHelper.GetEAX20000000EBXX();
            textBoxEAX20000000EBX.Text = cpuIdEAX20000000EBX;

            string cpuIdEAX20000000ECX = cpuHelper.GetEAX20000000ECXX();
            textBoxEAX20000000ECX.Text = cpuIdEAX20000000ECX;

            string cpuIdEAX20000000EDX = cpuHelper.GetEAX20000000EDXX();
            textBoxEAX20000000EDX.Text = cpuIdEAX20000000EDX;

            string cpuIdEAX20000000EAX_HighestXeonPhiFunctionImplemented = cpuHelper.GetEAX20000000EAX_HighestXeonPhiFunctionImplementedX();
            textBoxEAX20000000EAX_HighestXeonPhiFunctionImplemented.Text = cpuIdEAX20000000EAX_HighestXeonPhiFunctionImplemented;

            #endregion
        }
    }
}
