/*
    File           EAX8000001E.cs
    Brief          Form for displaying EAX=0x8000001E CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/27/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX8000001E : Form
    {
        private CPUHelper cpuHelper;

        public EAX8000001E()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x8000001E: APIC/unit/node information

            textBoxEAX.Text = cpuHelper.GetEAX8000001EEAXX();
            textBoxEBX.Text = cpuHelper.GetEAX8000001EEBXX();
            textBoxECX.Text = cpuHelper.GetEAX8000001EECXX();
            textBoxEDX.Text = cpuHelper.GetEAX8000001EEDXX();

            #endregion
        }
    }
}
