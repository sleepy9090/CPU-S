/*
    File           EAX20000001.cs
    Brief          Form for displaying EAX=0x20000001 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX20000001 : Form
    {

        private CPUHelper cpuHelper;

        public EAX20000001()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x20000001: Xeon Phi Feature Bits

            string cpuIdEAX20000001EAX = cpuHelper.GetEAX20000001EAXX();
            textBoxEAX20000001EAX.Text = cpuIdEAX20000001EAX;

            string cpuIdEAX20000001EBX = cpuHelper.GetEAX20000001EBXX();
            textBoxEAX20000001EBX.Text = cpuIdEAX20000001EBX;

            string cpuIdEAX20000001ECX = cpuHelper.GetEAX20000001ECXX();
            textBoxEAX20000001ECX.Text = cpuIdEAX20000001ECX;

            string cpuIdEAX20000001EDX = cpuHelper.GetEAX20000001EDXX();
            textBoxEAX20000001EDX.Text = cpuIdEAX20000001EDX;

            #endregion
        }
    }
}
