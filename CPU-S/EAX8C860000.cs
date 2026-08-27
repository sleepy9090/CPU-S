/*
    File           EAX8C860000.cs
    Brief          Form for displaying EAX=0x8C860000 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX8C860000 : Form
    {

        private CPUHelper cpuHelper;

        public EAX8C860000()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x8C860000: Hygon Extended Feature Flags

            string cpuIdEAX8C860000EAX = cpuHelper.GetEAX8C860000EAXX();
            textBoxEAX8C860000EAX.Text = cpuIdEAX8C860000EAX;

            string cpuIdEAX8C860000EBX = cpuHelper.GetEAX8C860000EBXX();
            textBoxEAX8C860000EBX.Text = cpuIdEAX8C860000EBX;

            string cpuIdEAX8C860000ECX = cpuHelper.GetEAX8C860000ECXX();
            textBoxEAX8C860000ECX.Text = cpuIdEAX8C860000ECX;

            string cpuIdEAX8C860000EDX = cpuHelper.GetEAX8C860000EDXX();
            textBoxEAX8C860000EDX.Text = cpuIdEAX8C860000EDX;

            #endregion
        }
    }
}
