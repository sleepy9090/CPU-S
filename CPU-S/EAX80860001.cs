/*
    File           EAX80860001.cs
    Brief          Form for displaying EAX=0x80860001 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/26/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX80860001 : Form
    {
        private CPUHelper cpuHelper;

        public EAX80860001()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x80860001: Vendor leaves - Transmeta - Processor information - FMS + Flags

            textBoxEAX.Text = cpuHelper.GetEAX80860001EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX80860001EBXX();
            textBoxECX.Text = cpuHelper.GetEAX80860001ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX80860001EDXX();

            #endregion
        }
    }
}
