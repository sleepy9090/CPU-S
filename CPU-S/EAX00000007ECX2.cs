/*
    File           EAX00000007ECX2.cs
    Brief          Form for displaying EAX=0x00000007, ECX=0x00000002 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           11/07/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX00000007ECX2 : Form
    {

        private CPUHelper cpuHelper;

        public EAX00000007ECX2()
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

            #region EAX=0x7, ECX=0x2: Extended Features

            textBoxEAX7ECX2EAX.Text = cpuHelper.GetEAX00000007ECX2EAXX();
            textBoxEAX7ECX2EBX.Text = cpuHelper.GetEAX00000007ECX2EBXX();
            textBoxEAX7ECX2ECX.Text = cpuHelper.GetEAX00000007ECX2ECXX();
            textBoxEAX7ECX2EDX.Text = cpuHelper.GetEAX00000007ECX2EDXX();

            textBoxEAXReserved.Text = cpuHelper.GetEAX00000007ECX2_EAX0_31_ReservedX();

            textBoxEBXReserved.Text = cpuHelper.GetEAX00000007ECX2_EBX0_31_ReservedX();

            textBoxECXReserved.Text = cpuHelper.GetEAX00000007ECX2_ECX0_31_ReservedX();

            checkBoxPSFD.Checked = cpuHelper.GetEAX00000007ECX2_EDX0_PSFDIsSupportedX();
            checkBoxIPRED_CTRL.Checked = cpuHelper.GetEAX00000007ECX2_EDX1_IPREDIsSupportedX();
            checkBoxRRSBA_CTRL.Checked = cpuHelper.GetEAX00000007ECX2_EDX2_RRSBA_CTRLIsSupportedX();
            checkBoxDDP_CTRL.Checked = cpuHelper.GetEAX00000007ECX2_EDX3_DDPD_UIsSupportedX();
            checkBoxBHI_CTRL.Checked = cpuHelper.GetEAX00000007ECX2_EDX4_BHI_CTRLIsSupportedX();
            checkBoxMCDT_NO.Checked = cpuHelper.GetEAX00000007ECX2_EDX5_MCDT_NOIsSupportedX();
            checkBoxUC_LOCK_DIS.Checked = cpuHelper.GetEAX00000007ECX2_EDX6_UC_LOCK_DISABLEIsSupportedX();
            checkBoxMON_MITG_NO.Checked = cpuHelper.GetEAX00000007ECX2_EDX7_MONITOR_MITG_NOIsSupportedX();
            checkBoxReserved8.Checked = cpuHelper.GetEAX00000007ECX2_EDX8_ReservedIsSupportedX();
            checkBoxReserved9.Checked = cpuHelper.GetEAX00000007ECX2_EDX9_ReservedIsSupportedX();
            checkBoxReserved10.Checked = cpuHelper.GetEAX00000007ECX2_EDX10_ReservedIsSupportedX();
            checkBoxReserved11.Checked = cpuHelper.GetEAX00000007ECX2_EDX11_ReservedIsSupportedX();
            checkBoxReserved12.Checked = cpuHelper.GetEAX00000007ECX2_EDX12_ReservedIsSupportedX();
            checkBoxReserved13.Checked = cpuHelper.GetEAX00000007ECX2_EDX13_ReservedIsSupportedX();
            checkBoxReserved14.Checked = cpuHelper.GetEAX00000007ECX2_EDX14_ReservedIsSupportedX();
            checkBoxReserved15.Checked = cpuHelper.GetEAX00000007ECX2_EDX15_ReservedIsSupportedX();
            checkBoxReserved16.Checked = cpuHelper.GetEAX00000007ECX2_EDX16_ReservedIsSupportedX();
            checkBoxReserved17.Checked = cpuHelper.GetEAX00000007ECX2_EDX17_ReservedIsSupportedX();
            checkBoxReserved18.Checked = cpuHelper.GetEAX00000007ECX2_EDX18_ReservedIsSupportedX();
            checkBoxReserved19.Checked = cpuHelper.GetEAX00000007ECX2_EDX19_ReservedIsSupportedX();
            checkBoxReserved20.Checked = cpuHelper.GetEAX00000007ECX2_EDX20_ReservedIsSupportedX();
            checkBoxReserved21.Checked = cpuHelper.GetEAX00000007ECX2_EDX21_ReservedIsSupportedX();
            checkBoxReserved22.Checked = cpuHelper.GetEAX00000007ECX2_EDX22_ReservedIsSupportedX();
            checkBoxReserved23.Checked = cpuHelper.GetEAX00000007ECX2_EDX23_ReservedIsSupportedX();
            checkBoxReserved24.Checked = cpuHelper.GetEAX00000007ECX2_EDX24_ReservedIsSupportedX();
            checkBoxReserved25.Checked = cpuHelper.GetEAX00000007ECX2_EDX25_ReservedIsSupportedX();
            checkBoxReserved26.Checked = cpuHelper.GetEAX00000007ECX2_EDX26_ReservedIsSupportedX();
            checkBoxReserved27.Checked = cpuHelper.GetEAX00000007ECX2_EDX27_ReservedIsSupportedX();
            checkBoxReserved28.Checked = cpuHelper.GetEAX00000007ECX2_EDX28_ReservedIsSupportedX();
            checkBoxReserved29.Checked = cpuHelper.GetEAX00000007ECX2_EDX29_ReservedIsSupportedX();
            checkBoxReserved30.Checked = cpuHelper.GetEAX00000007ECX2_EDX30_ReservedIsSupportedX();
            checkBoxReserved31.Checked = cpuHelper.GetEAX00000007ECX2_EDX31_ReservedIsSupportedX();

            #endregion
        }
    }
}
