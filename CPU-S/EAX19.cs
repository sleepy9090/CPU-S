/*
    File           EAX19.cs
    Brief          Form for displaying EAX=0x19 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX19 : Form
    {

        private CPUHelper cpuHelper;

        public EAX19()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x19: Intel Key Locker Features

            string cpuIdEAX19EAX = cpuHelper.GetEAX19EAXX();
            textBoxEAX19EAX.Text = cpuIdEAX19EAX;

            string cpuIdEAX19EBX = cpuHelper.GetEAX19EBXX();
            textBoxEAX19EBX.Text = cpuIdEAX19EBX;

            string cpuIdEAX19ECX = cpuHelper.GetEAX19ECXX();
            textBoxEAX19ECX.Text = cpuIdEAX19ECX;

            string cpuIdEAX19EDX = cpuHelper.GetEAX19EDXX();
            textBoxEAX19EDX.Text = cpuIdEAX19EDX;

            #endregion
        }
    }
}
