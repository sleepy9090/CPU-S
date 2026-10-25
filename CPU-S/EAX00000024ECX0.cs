/*
    File           EAX00000024ECX0.cs
    Brief          Form for displaying EAX=0x00000024, ECX=0x00000000 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/25/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX00000024ECX0 : Form
    {

        private CPUHelper cpuHelper;

        public EAX00000024ECX0()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x00000024, ECX=0x00000000: AVX10 Converged Vector ISA

            textBoxEAX24ECX0EAX.Text = cpuHelper.GetEAX00000024EAXX();
            textBoxEAX24ECX0EBX.Text = cpuHelper.GetEAX00000024EBXX();
            textBoxEAX24ECX0ECX.Text = cpuHelper.GetEAX00000024ECXX();
            textBoxEAX24ECX0EDX.Text = cpuHelper.GetEAX00000024EDXX();

            #endregion
        }
    }
}
