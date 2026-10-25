/*
    File           EAX00000021.cs
    Brief          Form for displaying EAX=0x00000021 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/25/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX00000021 : Form
    {

        private CPUHelper cpuHelper;

        public EAX00000021()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x00000021: Reserved for TDX enumeration

            textBoxEAX.Text = cpuHelper.GetEAX00000021EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX00000021EBXX();
            textBoxECX.Text = cpuHelper.GetEAX00000021ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX00000021EDXX();

            #endregion
        }
    }
}
