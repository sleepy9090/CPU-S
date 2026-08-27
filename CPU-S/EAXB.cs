/*
    File           EAXB.cs
    Brief          Form for displaying EAX=0xB CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAXB : Form
    {

        private CPUHelper cpuHelper;

        public EAXB()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x4: Intel Thread/Core and Cache Topology

            string cpuIdEAXBEAX = cpuHelper.GetEAXBEAXX();
            textBoxEAXBEAX.Text = cpuIdEAXBEAX;

            string cpuIdEAXBEBX = cpuHelper.GetEAXBEBXX();
            textBoxEAXBEBX.Text = cpuIdEAXBEBX;

            string cpuIdEAXBECX = cpuHelper.GetEAXBECXX();
            textBoxEAXBECX.Text = cpuIdEAXBECX;

            string cpuIdEAXBEDX = cpuHelper.GetEAXBEDXX();
            textBoxEAXBEDX.Text = cpuIdEAXBEDX;

            #endregion
        }
    }
}
