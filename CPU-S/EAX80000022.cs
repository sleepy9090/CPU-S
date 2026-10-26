/*
    File           EAX80000022.cs
    Brief          Form for displaying EAX=0x80000022 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/26/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX80000022 : Form
    {
        private CPUHelper cpuHelper;

        public EAX80000022()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x80000022: Extended performance monitoring and debug information

            textBoxEAX.Text = cpuHelper.GetEAX80000022EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX80000022EBXX();
            textBoxECX.Text = cpuHelper.GetEAX80000022ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX80000022EDXX();

            #endregion
        }
    }
}
