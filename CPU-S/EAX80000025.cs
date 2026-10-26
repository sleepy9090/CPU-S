/*
    File           EAX80000025.cs
    Brief          Form for displaying EAX=0x80000025 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/26/2026
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

            #region EAX=0x80000025: Encrypted Memory Capabilities 2 / RMP information

            textBoxEAX80000025EAX.Text = cpuHelper.GetEAX80000025EAXX();
            textBoxEAX80000025EBX.Text = cpuHelper.GetEAX80000025EBXX();
            textBoxEAX80000025ECX.Text = cpuHelper.GetEAX80000025ECXX();
            textBoxEAX80000025EDX.Text = cpuHelper.GetEAX80000025EDXX();

            #endregion
        }
    }
}
