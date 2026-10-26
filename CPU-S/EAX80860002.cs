/*
    File           EAX80860002.cs
    Brief          Form for displaying EAX=0x80860002 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/26/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX80860002 : Form
    {
        private CPUHelper cpuHelper;

        public EAX80860002()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x80860002: Vendor leaves - Transmeta - Processor information - HW/SW Revision

            textBoxEAX.Text = cpuHelper.GetEAX80860002EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX80860002EBXX();
            textBoxECX.Text = cpuHelper.GetEAX80860002ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX80860002EDXX();

            #endregion
        }
    }
}
