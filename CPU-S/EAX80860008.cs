/*
    File           EAX80860008.cs
    Brief          Form for displaying EAX=0x80860008 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/26/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX80860008 : Form
    {
        private CPUHelper cpuHelper;

        public EAX80860008()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x80860008: Vendor leaves - Transmeta - Hypervisor Information

            textBoxEAX.Text = cpuHelper.GetEAX80860008EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX80860008EBXX();
            textBoxECX.Text = cpuHelper.GetEAX80860008ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX80860008EDXX();

            #endregion
        }
    }
}
