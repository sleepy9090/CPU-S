/*
    File           EAX17.cs
    Brief          Form for displaying EAX=0x17 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX17 : Form
    {

        private CPUHelper cpuHelper;

        public EAX17()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x17: SoC Vendor Attribute Enumeration

            string cpuIdEAX17EAX = cpuHelper.GetEAX17EAXX();
            textBoxEAX17EAX.Text = cpuIdEAX17EAX;

            string cpuIdEAX17EBX = cpuHelper.GetEAX17EBXX();
            textBoxEAX17EBX.Text = cpuIdEAX17EBX;

            string cpuIdEAX17ECX = cpuHelper.GetEAX17ECXX();
            textBoxEAX17ECX.Text = cpuIdEAX17ECX;

            string cpuIdEAX17EDX = cpuHelper.GetEAX17EDXX();
            textBoxEAX17EDX.Text = cpuIdEAX17EDX;

            #endregion
        }
    }
}
