/*
    File           EAX80000026.cs
    Brief          Form for displaying EAX=0x80000026 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/26/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX80000026 : Form
    {
        private CPUHelper cpuHelper;

        public EAX80000026()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x80000026: Topology enumeration information

            textBoxEAX.Text = cpuHelper.GetEAX80000026EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX80000026EBXX();
            textBoxECX.Text = cpuHelper.GetEAX80000026ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX80000026EDXX();

            #endregion
        }
    }
}
