/*
    File           EAX00000010ECX1.cs
    Brief          Form for displaying EAX=0x00000010, ECX=0x00000001 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           11/14/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX00000010ECX1 : Form
    {
        private CPUHelper cpuHelper;

        public EAX00000010ECX1()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            foreach (TextBox textBox in this.GetAllControlsOfType<TextBox>())
            {
                textBox.ReadOnly = true;
            }

            foreach (CheckBox checkBox in this.GetAllControlsOfType<CheckBox>())
            {
                checkBox.AutoCheck = false;
            }

            #region EAX=0x00000010, ECX=0x00000001: RDT-A (QoS allocation) enumeration, (1 = L3)

            textBoxEAX.Text = cpuHelper.GetEAX00000010ECX1EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX00000010ECX1EBXX();
            textBoxECX.Text = cpuHelper.GetEAX00000010ECX1ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX00000010ECX1EDXX();

            textBoxEAX0_4_LengthOfCapacityBitMaskForResourceN.Text = cpuHelper.GetEAX00000010ECX1EAX_0_4_LengthOfCapacityBitMaskForResourceX();
            textBoxEAX5_31_Reserved.Text = cpuHelper.GetEAX00000010ECX1EAX_5_31_ReservedX();
            textBoxEBX0_31_BitGranularMapOfIsolationContentionOfAllocationUnits.Text = cpuHelper.GetEAX00000010ECX1EBX_BitGranularMapOfIsolationContentionOfAllocationUnitsX();
            checkBoxECX0Reserved.Checked = cpuHelper.GetEAX00000010ECX1ECX0_ReservedIsSupportedX();
            checkBoxECX1ISE049_ISE050.Checked = cpuHelper.GetEAX00000010ECX1ECX1_ISE049_ISE050_IsSupportedX();
            checkBoxECX2CodeDataPrioritization.Checked = cpuHelper.GetEAX00000010ECX1ECX2_CodeDataPrioritizationIsSupportedX();
            checkBoxECX3NonContiguousCapacityBitmasks.Checked = cpuHelper.GetEAX00000010ECX1ECX3_NonContiguousCapacityBitmasksIsSupportedX();
            textBoxECX4_31_Reserved.Text = cpuHelper.GetEAX00000010ECX1ECX_4_31_ReservedX();
            textBoxEDX0_15_HighestCOSNumberSupportedForResourceN.Text = cpuHelper.GetEAX00000010ECX1EDX_0_15_HighestCOSNumberSupportedForResourceNX();
            textBoxEDX16_31_Reserved.Text = cpuHelper.GetEAX00000010ECX1EDX_16_31_ReservedX();

            #endregion
        }
    }
}
