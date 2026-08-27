/*
    File           EAX80000025.cs
    Brief          Form for displaying EAX=0x80000025 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX80000025 : Form
    {

        private CPUHelper cpuHelper;

        public EAX80000025()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x80000025: Encrypted Memory Capabilities 2

            string cpuIdEAX80000025EAX = cpuHelper.GetEAX80000025EAXX();
            textBoxEAX80000025EAX.Text = cpuIdEAX80000025EAX;

            string cpuIdEAX80000025EBX = cpuHelper.GetEAX80000025EBXX();
            textBoxEAX80000025EBX.Text = cpuIdEAX80000025EBX;

            string cpuIdEAX80000025ECX = cpuHelper.GetEAX80000025ECXX();
            textBoxEAX80000025ECX.Text = cpuIdEAX80000025ECX;

            string cpuIdEAX80000025EDX = cpuHelper.GetEAX80000025EDXX();
            textBoxEAX80000025EDX.Text = cpuIdEAX80000025EDX;

            #endregion
        }
    }
}
