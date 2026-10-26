/*
    File           EAX80000020.cs
    Brief          Form for displaying EAX=0x80000020 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/26/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX80000020 : Form
    {
        private CPUHelper cpuHelper;

        public EAX80000020()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x80000020: Platform QoS enumeration

            textBoxEAX.Text = cpuHelper.GetEAX80000020EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX80000020EBXX();
            textBoxECX.Text = cpuHelper.GetEAX80000020ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX80000020EDXX();

            #endregion
        }
    }
}
