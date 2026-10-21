/*
    File           EAX0000000D.cs
    Brief          Form for displaying EAX=0x0000000D CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/21/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX0000000D : Form
    {

        private CPUHelper cpuHelper;

        public EAX0000000D()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x0000000D: XSAVE Features and State Components

            string cpuIdEAX0000000DEAX = cpuHelper.GetEAX0000000DEAXX();
            textBoxEAX0000000DEAX.Text = cpuIdEAX0000000DEAX;

            string cpuIdEAX0000000DEBX = cpuHelper.GetEAX0000000DEBXX();
            textBoxEAX0000000DEBX.Text = cpuIdEAX0000000DEBX;

            string cpuIdEAX0000000DECX = cpuHelper.GetEAX0000000DECXX();
            textBoxEAX0000000DECX.Text = cpuIdEAX0000000DECX;

            string cpuIdEAX0000000DEDX = cpuHelper.GetEAX0000000DEDXX();
            textBoxEAX0000000DEDX.Text = cpuIdEAX0000000DEDX;

            #endregion
        }
    }
}
