/*
    File           EAX00000010ECX3.cs
    Brief          Form for displaying EAX=0x00000010, ECX=0x00000003 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           11/14/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX00000010ECX3 : Form
    {
        private CPUHelper cpuHelper;

        public EAX00000010ECX3()
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

            #region EAX=0x00000010, ECX=0x00000003: RDT-A (QoS allocation) enumeration, (3 = MBA)

            textBoxEAX.Text = cpuHelper.GetEAX00000010ECX3EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX00000010ECX3EBXX();
            textBoxECX.Text = cpuHelper.GetEAX00000010ECX3ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX00000010ECX3EDXX();

            textBoxEAX0_11_MaximumMBAThrottlingForResourceN.Text = cpuHelper.GetEAX00000010ECX3EAX_0_11_MaximumMBAThrottlingValueForResourceX();
            textBoxEAX12_31_Reserved.Text = cpuHelper.GetEAX00000010ECX3EAX_12_31_ReservedX();
            textBoxEBXReserved.Text = cpuHelper.GetEAX00000010ECX3EBX_0_31_ReservedX();
            checkBoxECX0PerThreadMBAControls.Checked = cpuHelper.GetEAX00000010ECX3ECX0_PerThreadMBAControlsIsSupportedX();
            checkBoxECX1Reserved.Checked = cpuHelper.GetEAX00000010ECX3ECX1_ReservedIsSupportedX();
            checkBoxECX2ResponseToDelayValueIsLinear.Checked = cpuHelper.GetEAX00000010ECX3ECX2_ResponseToDelayValueIsLinearIsSupportedX();
            textBoxECX3_31_Reserved.Text = cpuHelper.GetEAX00000010ECX3ECX_3_31_ReservedX();
            textBoxEDX0_15_HighestCOSNumberSupportedForResourceN.Text = cpuHelper.GetEAX00000010ECX3EDX_0_15_HighestCOSNumberSupportedForResourceNX();
            textBoxEDX16_31_Reserved.Text = cpuHelper.GetEAX00000010ECX3EDX_16_31_ReservedX();

            #endregion
        }
    }
}
