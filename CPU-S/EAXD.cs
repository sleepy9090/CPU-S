/*
    File           EAXD.cs
    Brief          Form for displaying EAX=0xD CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAXD : Form
    {

        private CPUHelper cpuHelper;

        public EAXD()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0xD: XSAVE Features and State Components

            string cpuIdEAXDEAX = cpuHelper.GetEAXDEAXX();
            textBoxEAXDEAX.Text = cpuIdEAXDEAX;

            string cpuIdEAXDEBX = cpuHelper.GetEAXDEBXX();
            textBoxEAXDEBX.Text = cpuIdEAXDEBX;

            string cpuIdEAXDECX = cpuHelper.GetEAXDECXX();
            textBoxEAXDECX.Text = cpuIdEAXDECX;

            string cpuIdEAXDEDX = cpuHelper.GetEAXDEDXX();
            textBoxEAXDEDX.Text = cpuIdEAXDEDX;

            #endregion
        }
    }
}
