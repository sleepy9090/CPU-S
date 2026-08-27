/*
    File           EAX80000000.cs
    Brief          Form for displaying EAX=0x80000000 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX80000000 : Form
    {

        private CPUHelper cpuHelper;

        public EAX80000000()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x80000000: Highest Extended Function Implemented

            string cpuIdEAX80000000EAX = cpuHelper.GetEAX80000000EAXX();
            textBoxEAX80000000EAX.Text = cpuIdEAX80000000EAX;

            string cpuIdEAX80000000EBX = cpuHelper.GetEAX80000000EBXX();
            textBoxEAX80000000EBX.Text = cpuIdEAX80000000EBX;

            string cpuIdEAX80000000ECX = cpuHelper.GetEAX80000000ECXX();
            textBoxEAX80000000ECX.Text = cpuIdEAX80000000ECX;

            string cpuIdEAX80000000EDX = cpuHelper.GetEAX80000000EDXX();
            textBoxEAX80000000EDX.Text = cpuIdEAX80000000EDX;

            string cpuIdEAX80000000EAX_HighestExtendedFunctionImplemented = cpuHelper.GetEAX80000000EAX_HighestExtendedFunctionImplementedX();
            textBoxEAX80000000EAX_HighestExtendedFunctionImplemented.Text = cpuIdEAX80000000EAX_HighestExtendedFunctionImplemented;

            #endregion
        }
    }
}
