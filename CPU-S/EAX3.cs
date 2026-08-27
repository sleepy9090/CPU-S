/*
    File           EAX3.cs
    Brief          Form for displaying EAX=0x3 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX3 : Form
    {
        private CPUHelper cpuHelper;

        public EAX3()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x3: Processor Serial Number

            string cpuIdEAX3EAX = cpuHelper.GetEAX3EAXX();
            textBoxEAX3EAX.Text = cpuIdEAX3EAX;

            string cpuIdEAX3EBX = cpuHelper.GetEAX3EBXX();
            textBoxEAX3EBX.Text = cpuIdEAX3EBX;

            string cpuIdEAX3ECX = cpuHelper.GetEAX3ECXX();
            textBoxEAX3ECX.Text = cpuIdEAX3ECX;

            string cpuIdEAX3EDX = cpuHelper.GetEAX3EDXX();
            textBoxEAX3EDX.Text = cpuIdEAX3EDX;

            string cpuIdEAX3_EAX_EDX_ECX_Pentium3CPU96BitSerialNumber = cpuHelper.GetEAX3_EAX_EDX_ECX_Pentium3CPU96BitSerialNumberX();
            textBoxEAX3_EAX_EDX_ECX_Pentium3CPU96BitSerialNumber.Text = cpuIdEAX3_EAX_EDX_ECX_Pentium3CPU96BitSerialNumber;

            string cpuIdEAX3_EAX_EDX_ECX_TransmetaCrusoeAndEfficeonCPU128BitSerialNumber = cpuHelper.GetEAX3_EAX_EDX_ECX_TransmetaCrusoeAndEfficeonCPU128BitSerialNumberX();
            textBoxEAX3_EAX_EDX_ECX_TransmetaCrusoeAndEfficeonCPU128BitSerialNumber.Text = cpuIdEAX3_EAX_EDX_ECX_TransmetaCrusoeAndEfficeonCPU128BitSerialNumber;

            #endregion
        }
    }
}
