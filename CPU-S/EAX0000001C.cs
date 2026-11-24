/*
    File           EAX0000001C.cs
    Brief          Form for displaying EAX=0x0000001C CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           11/09/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX0000001C : Form
    {
        private CPUHelper cpuHelper;

        public EAX0000001C()
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

            #region EAX=0x0000001C: LBR Information

            textBoxEAX.Text = cpuHelper.GetEAX0000001CEAXX();
            textBoxEBX.Text = cpuHelper.GetEAX0000001CEBXX();
            textBoxECX.Text = cpuHelper.GetEAX0000001CECXX();
            textBoxEDX.Text = cpuHelper.GetEAX0000001CEDXX();

            textBoxEAX0_7_DEPTH.Text = cpuHelper.GetEAX0000001CEAX0_7_LBR_DEPTHX();
            textBoxEAX8_29_Reserved.Text = cpuHelper.GetEAX0000001CEAX8_29_ReservedX();
            checkBoxEAX30_LBRClearedOnMWAITGreaterThanC1.Checked = cpuHelper.GetEAX0000001C_EAX30_LBRClearedOnMWAITGreaterThanC1X();
            textBoxEAX31_LBR_IP_ValueType.Text = cpuHelper.GetEAX0000001CEAX31_LBRIPValueTypeX();
            int value = -1;
            int.TryParse(cpuHelper.GetEAX0000001CEAX31_LBRIPValueTypeX(), out value);
            switch (value)
            {
                case 0:
                    textBoxEAX31_LBR_IP_ValueTypeValue.Text = "EIP";
                    break;
                case 1:
                    textBoxEAX31_LBR_IP_ValueTypeValue.Text = "LIP";
                    break;
                default:
                    textBoxEAX31_LBR_IP_ValueTypeValue.Text = "Unknown";
                    break;
            }

            checkBoxEBX0_LBR_CTL_2_1.Checked = cpuHelper.GetEAX0000001C_EBX0_LBRCTLForCPLFilteringX();
            checkBoxEBX1_LBR_CTL_16_22.Checked = cpuHelper.GetEAX0000001C_EBX1_LBRCTLForBranchFilteringX();
            checkBoxEBX2_LBR_CTL_3.Checked = cpuHelper.GetEAX0000001C_EBX2_LBRCTLForCallStackModeX();
            textBoxEBX3_31_Reserved.Text = cpuHelper.GetEAX0000001CEBX3_31_ReservedX();

            checkBoxECX0_LBR_x_INFO_63.Checked = cpuHelper.GetEAX0000001C_ECX0_LBRxINFOIndicatesBranchMispredictionX();
            checkBoxECX1_LBR_x_INFO_0_15_60.Checked = cpuHelper.GetEAX0000001C_ECX1_LBRxINFOIndicatesCyclesX();
            checkBoxECX2_LBR_x_INFO_56_59.Checked = cpuHelper.GetEAX0000001C_ECX2_LBRxINFOIndicatesBranchTypeX();
            textBoxECX3_15_Reserved.Text = cpuHelper.GetEAX0000001CECX3_15_ReservedX();
            textBoxECX16_19_EventLoggingBitmap.Text = cpuHelper.GetEAX0000001CECX16_19_EventLoggingBitmapX();
            textBoxECX_20_31_Reserved.Text = cpuHelper.GetEAX0000001CECX20_31_ReservedX();

            textBoxEDXReserved.Text = cpuHelper.GetEAX0000001CEDX0_31_ReservedX();

            #endregion
        }
    }
}
