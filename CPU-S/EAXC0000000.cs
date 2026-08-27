/*
    File           EAXC0000000.cs
    Brief          Form for displaying EAX=0xC0000000 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAXC0000000 : Form
    {

        private CPUHelper cpuHelper;

        public EAXC0000000()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0xC0000000: Highest Centaur Extended Function

            string cpuIdEAXC0000000EAX = cpuHelper.GetEAXC0000000EAXX();
            textBoxEAXC0000000EAX.Text = cpuIdEAXC0000000EAX;

            string cpuIdEAXC0000000EBX = cpuHelper.GetEAXC0000000EBXX();
            textBoxEAXC0000000EBX.Text = cpuIdEAXC0000000EBX;

            string cpuIdEAXC0000000ECX = cpuHelper.GetEAXC0000000ECXX();
            textBoxEAXC0000000ECX.Text = cpuIdEAXC0000000ECX;

            string cpuIdEAXC0000000EDX = cpuHelper.GetEAXC0000000EDXX();
            textBoxEAXC0000000EDX.Text = cpuIdEAXC0000000EDX;

            #endregion

        }
    }
}
