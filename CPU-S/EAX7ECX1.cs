/*
    File           EAX7ECX1.cs
    Brief          Form for displaying EAX=0x7, ECX=0x1 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX7ECX1 : Form
    {

        private CPUHelper cpuHelper;

        public EAX7ECX1()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x7, ECX=0x1: Extended Features

            string cpuIdEAX7ECX1EAX = cpuHelper.GetEAX7ECX1EAXX();
            textBoxEAX7ECX1EAX.Text = cpuIdEAX7ECX1EAX;

            string cpuIdEAX7ECX1EBX = cpuHelper.GetEAX7ECX1EBXX();
            textBoxEAX7ECX1EBX.Text = cpuIdEAX7ECX1EBX;

            string cpuIdEAX7ECX1ECX = cpuHelper.GetEAX7ECX1ECXX();
            textBoxEAX7ECX1ECX.Text = cpuIdEAX7ECX1ECX;

            string cpuIdEAX7ECX1EDX = cpuHelper.GetEAX7ECX1EDXX();
            textBoxEAX7ECX1EDX.Text = cpuIdEAX7ECX1EDX;

            #endregion
        }
    }
}
