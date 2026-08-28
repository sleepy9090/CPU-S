/*
    File           EAX8000001D.cs
    Brief          Form for displaying EAX=0x1D CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX8000001D : Form
    {

        private CPUHelper cpuHelper;

        public EAX8000001D(int i)
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x8000001D: Cache Hierarchy and Topology

            string cpuIdEAX8000001DEAX = cpuHelper.GetEAX8000001DEAXX(i);
            textBoxEAX8000001DEAX.Text = cpuIdEAX8000001DEAX;

            string cpuIdEAX8000001DEBX = cpuHelper.GetEAX8000001DEBXX(i);
            textBoxEAX8000001DEBX.Text = cpuIdEAX8000001DEBX;

            string cpuIdEAX8000001DECX = cpuHelper.GetEAX8000001DECXX(i);
            textBoxEAX8000001DECX.Text = cpuIdEAX8000001DECX;

            string cpuIdEAX8000001DEDX = cpuHelper.GetEAX8000001DEDXX(i);
            textBoxEAX8000001DEDX.Text = cpuIdEAX8000001DEDX;

            #endregion
        }
    }
}
