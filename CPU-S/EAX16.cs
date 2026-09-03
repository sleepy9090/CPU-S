/*
    File           EAX16.cs
    Brief          Form for displaying EAX=0x16 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX16 : Form
    {

        private CPUHelper cpuHelper;

        public EAX16()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x16: Processor and Bus specification frequencies

            string cpuIdEAX16EAX = cpuHelper.GetEAX16EAXX();
            textBoxEAX16EAX.Text = cpuIdEAX16EAX;

            string cpuIdEAX16EBX = cpuHelper.GetEAX16EBXX();
            textBoxEAX16EBX.Text = cpuIdEAX16EBX;

            string cpuIdEAX16ECX = cpuHelper.GetEAX16ECXX();
            textBoxEAX16ECX.Text = cpuIdEAX16ECX;

            string cpuIdEAX16EDX = cpuHelper.GetEAX16EDXX();
            textBoxEAX16EDX.Text = cpuIdEAX16EDX;

            string cpuIdEAX16EAX0_15_ProcessorBaseFrequencyInMHz = cpuHelper.GetEAX16EAX0_15_ProcessorBaseFrequencyInMHzX();
            textBoxProcBaseFreqMHz.Text = cpuIdEAX16EAX0_15_ProcessorBaseFrequencyInMHz;

            string cpuIdEAX16EAX16_31_Reserved = cpuHelper.GetEAX16EAX16_31_ReservedX();
            textBoxEAXReserved.Text = cpuIdEAX16EAX16_31_Reserved;

            string cpuIdEAX16EBX0_15_ProcessorMaxFrequencyInMHz = cpuHelper.GetEAX16EBX0_15_ProcessorMaxFrequencyInMHzX();
            textBoxProcMaxFreqMHz.Text = cpuIdEAX16EBX0_15_ProcessorMaxFrequencyInMHz;

            string cpuIdEAX16EBX16_31_Reserved = cpuHelper.GetEAX16EBX16_31_ReservedX();
            textBoxEBXReserved.Text = cpuIdEAX16EBX16_31_Reserved;

            string cpuIdEAX16ECX0_15_BusReferenceFrequencyInMHz = cpuHelper.GetEAX16ECX0_15_BusReferenceFrequencyInMHzX();
            textBoxBusFreqMHz.Text = cpuIdEAX16ECX0_15_BusReferenceFrequencyInMHz;

            string cpuIdEAX16ECX16_31_Reserved = cpuHelper.GetEAX16ECX16_31_ReservedX();
            textBoxECXReserved.Text = cpuIdEAX16ECX16_31_Reserved;

            string cpuIdEAX16EDX0_31_Reserved = cpuHelper.GetEAX16EDX0_31_ReservedX();
            textBoxEDXReserved.Text = cpuIdEAX16EDX0_31_Reserved;

            #endregion
        }
    }
}
