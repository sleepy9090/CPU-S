/*
    File           EAX24ECX1.cs
    Brief          Form for displaying EAX=0x24, ECX=0x1 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX24ECX1 : Form
    {

        private CPUHelper cpuHelper;

        public EAX24ECX1()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x24, ECX=0x1: Discrete AVX10 Features

            string cpuIdEAX24ECX1EAX = cpuHelper.GetEAX24ECX1EAXX();
            textBoxEAX24ECX1EAX.Text = cpuIdEAX24ECX1EAX;

            string cpuIdEAX24ECX1EBX = cpuHelper.GetEAX24ECX1EBXX();
            textBoxEAX24ECX1EBX.Text = cpuIdEAX24ECX1EBX;

            string cpuIdEAX24ECX1ECX = cpuHelper.GetEAX24ECX1ECXX();
            textBoxEAX24ECX1ECX.Text = cpuIdEAX24ECX1ECX;

            string cpuIdEAX24ECX1EDX = cpuHelper.GetEAX24ECX1EDXX();
            textBoxEAX24ECX1EDX.Text = cpuIdEAX24ECX1EDX;

            #endregion
        }
    }
}
