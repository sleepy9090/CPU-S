/*
    File           EAX00000012.cs
    Brief          Form for displaying EAX=0x00000012 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/26/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX00000012 : Form
    {

        private CPUHelper cpuHelper;

        public EAX00000012()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x00000012: SGX Capabilities

            textBoxEAX00000012EAX.Text = cpuHelper.GetEAX00000012EAXX();
            textBoxEAX00000012EBX.Text = cpuHelper.GetEAX00000012EBXX();
            textBoxEAX00000012ECX.Text = cpuHelper.GetEAX00000012ECXX();
            textBoxEAX00000012EDX.Text = cpuHelper.GetEAX00000012EDXX();

            #endregion
        }
    }
}
