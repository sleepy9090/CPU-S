/*
    File           EAX80860007.cs
    Brief          Form for displaying EAX=0x80860007 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/26/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX80860007 : Form
    {
        private CPUHelper cpuHelper;

        public EAX80860007()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x80860007: Vendor leaves - Transmeta - Processor information - MHz + mV

            textBoxEAX.Text = cpuHelper.GetEAX80860007EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX80860007EBXX();
            textBoxECX.Text = cpuHelper.GetEAX80860007ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX80860007EDXX();

            #endregion
        }
    }
}
