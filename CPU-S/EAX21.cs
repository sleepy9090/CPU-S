/*
    File           EAX21.cs
    Brief          Form for displaying EAX=0x21 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX21 : Form
    {

        private CPUHelper cpuHelper;

        public EAX21()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x21: Reserved for TDX enumeration

            string cpuIdEAX21EAX = cpuHelper.GetEAX21EAXX();
            textBoxEAX21EAX.Text = cpuIdEAX21EAX;

            string cpuIdEAX21EBX = cpuHelper.GetEAX21EBXX();
            textBoxEAX21EBX.Text = cpuIdEAX21EBX;

            string cpuIdEAX21ECX = cpuHelper.GetEAX21ECXX();
            textBoxEAX21ECX.Text = cpuIdEAX21ECX;

            string cpuIdEAX21EDX = cpuHelper.GetEAX21EDXX();
            textBoxEAX21EDX.Text = cpuIdEAX21EDX;

            #endregion
        }
    }
}
