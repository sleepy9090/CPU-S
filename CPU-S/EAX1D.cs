/*
    File           EAX1D.cs
    Brief          Form for displaying EAX=0x1D CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX1D : Form
    {

        private CPUHelper cpuHelper;

        public EAX1D()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x1D: Intel AMX Tile Information

            string cpuIdEAX1DEAX = cpuHelper.GetEAX1DEAXX();
            textBoxEAX1DEAX.Text = cpuIdEAX1DEAX;

            string cpuIdEAX1DEBX = cpuHelper.GetEAX1DEBXX();
            textBoxEAX1DEBX.Text = cpuIdEAX1DEBX;

            string cpuIdEAX1DECX = cpuHelper.GetEAX1DECXX();
            textBoxEAX1DECX.Text = cpuIdEAX1DECX;

            string cpuIdEAX1DEDX = cpuHelper.GetEAX1DEDXX();
            textBoxEAX1DEDX.Text = cpuIdEAX1DEDX;

            #endregion
        }
    }
}
