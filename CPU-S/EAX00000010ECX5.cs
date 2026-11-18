/*
    File           EAX00000010ECX5.cs
    Brief          Form for displaying EAX=0x00000010, ECX=0x00000005 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           11/14/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX00000010ECX5 : Form
    {
        private CPUHelper cpuHelper;

        public EAX00000010ECX5()
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

            #region EAX=0x00000010, ECX=0x00000005: RDT-A (QoS allocation) enumeration, (5 = CBA)

            textBoxEAX.Text = cpuHelper.GetEAX00000010ECX5EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX00000010ECX5EBXX();
            textBoxECX.Text = cpuHelper.GetEAX00000010ECX5ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX00000010ECX5EDXX();

            textBoxEAX0_7_MaximumCBAThrottlingForResourceN.Text = cpuHelper.GetEAX00000010ECX5EAX_0_7_MaximumCBAThrottlingValueForResourceX();
            textBoxEAX8_11_ScopeOfCBAQoS_Core_BW_Thrtl_nMSRsIsLogicalProcessor.Text = cpuHelper.GetEAX00000010ECX5EAX_8_11_ScopeOfCBAQoS_Core_BW_Thrtl_nMSRsIsLogicalProcessorX();
            textBoxEAX12_31_Reserved.Text = cpuHelper.GetEAX00000010ECX5EAX_12_31_ReservedX();
            textBoxEBXReserved.Text = cpuHelper.GetEAX00000010ECX5EBX_0_31_ReservedX();
            textBoxECX0_2_Reserved.Text = cpuHelper.GetEAX00000010ECX5ECX_0_2_ReservedX();
            checkBoxECX3ApproximatelyLinearResponse.Checked = cpuHelper.GetEAX00000010ECX5ECX3_ApproximatelyLinearResponseIsSupportedX();
            textBoxECX4_31_Reserved.Text = cpuHelper.GetEAX00000010ECX5ECX_4_31_ReservedX();
            textBoxEDX0_15_HighestCOSNumberSupportedForResourceN.Text = cpuHelper.GetEAX00000010ECX5EDX_0_15_HighestCOSNumberSupportedForResourceNX();
            textBoxEDX16_31_Reserved.Text = cpuHelper.GetEAX00000010ECX5EDX_16_31_ReservedX();

            #endregion
        }
    }
}
