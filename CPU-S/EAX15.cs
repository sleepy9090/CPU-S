/*
    File           EAX15.cs
    Brief          Form for displaying EAX=0x15 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX15 : Form
    {

        private CPUHelper cpuHelper;

        public EAX15()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x15: TSC and Core Crystal frequency information

            string cpuIdEAX15EAX = cpuHelper.GetEAX15EAXX();
            textBoxEAX15EAX.Text = cpuIdEAX15EAX;

            string cpuIdEAX15EBX = cpuHelper.GetEAX15EBXX();
            textBoxEAX15EBX.Text = cpuIdEAX15EBX;

            string cpuIdEAX15ECX = cpuHelper.GetEAX15ECXX();
            textBoxEAX15ECX.Text = cpuIdEAX15ECX;

            string cpuIdEAX15EDX = cpuHelper.GetEAX15EDXX();
            textBoxEAX15EDX.Text = cpuIdEAX15EDX;

            #endregion
        }
    }
}
