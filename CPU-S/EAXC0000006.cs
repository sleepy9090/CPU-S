/*
    File           EAXC0000006.cs
    Brief          Form for displaying EAX=0xC0000006 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/25/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAXC0000006 : Form
    {

        private CPUHelper cpuHelper;

        public EAXC0000006()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0xC0000006: Zhaoxin - Processor Information

            textBoxEAX.Text = cpuHelper.GetEAXC0000006EAXX();
            textBoxEBX.Text = cpuHelper.GetEAXC0000006EBXX();
            textBoxECX.Text = cpuHelper.GetEAXC0000006ECXX();
            textBoxEDX.Text = cpuHelper.GetEAXC0000006EDXX();

            #endregion
        }
    }
}
