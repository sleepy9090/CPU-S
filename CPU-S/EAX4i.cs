/*
    File           EAX4i.cs
    Brief          Form for displaying EAX=0x4i CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX4i : Form
    {

        private CPUHelper cpuHelper;

        public EAX4i()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x4: Intel Thread/Core and Cache Topology

            string cpuIdEAX4EAX = cpuHelper.GetEAX4EAXX();
            textBoxEAX4EAX.Text = cpuIdEAX4EAX;

            string cpuIdEAX4EBX = cpuHelper.GetEAX4EBXX();
            textBoxEAX4EBX.Text = cpuIdEAX4EBX;

            string cpuIdEAX4ECX = cpuHelper.GetEAX4ECXX();
            textBoxEAX4ECX.Text = cpuIdEAX4ECX;

            string cpuIdEAX4EDX = cpuHelper.GetEAX4EDXX();
            textBoxEAX4EDX.Text = cpuIdEAX4EDX;

            #endregion
        }
    }
}
