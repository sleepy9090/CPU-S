/*
    File           EAX00000019.cs
    Brief          Form for displaying EAX=0x00000019 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           11/10/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX00000019 : Form
    {

        private CPUHelper cpuHelper;

        public EAX00000019()
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

            #region EAX=0x00000019: Intel Key Locker Features

            textBoxEAX19EAX.Text = cpuHelper.GetEAX00000019EAXX();
            textBoxEAX19EBX.Text = cpuHelper.GetEAX00000019EBXX();
            textBoxEAX19ECX.Text = cpuHelper.GetEAX00000019ECXX();
            textBoxEAX19EDX.Text = cpuHelper.GetEAX00000019EDXX();

            checkBoxCPL0.Checked = cpuHelper.GetEAX00000019_EAX0_CPL0X();
            checkBoxNO_ENC.Checked = cpuHelper.GetEAX00000019_EAX1_NO_ENCX();
            checkBoxNO_DEC.Checked = cpuHelper.GetEAX00000019_EAX2_NO_DECX();
            textBoxEAX3_31_Reserved.Text = cpuHelper.GetEAX00000019EAX3_31_ReservedX();

            checkBoxAES_KL_E.Checked = cpuHelper.GetEAX00000019_EBX0_AES_KL_EX();
            checkBoxEBX_1_Reserved.Checked = cpuHelper.GetEAX00000019_EBX1_ReservedX();
            checkBoxAES_WIDE.Checked = cpuHelper.GetEAX00000019_EBX2_AES_WIDEX();
            checkBoxEBX_3_Reserved.Checked = cpuHelper.GetEAX00000019_EBX3_ReservedX();
            checkBoxIWKEYBACKUP.Checked = cpuHelper.GetEAX00000019_EBX4_IWKEYBACKUPX();
            textBoxEBX5_31_Reserved.Text = cpuHelper.GetEAX00000019EBX5_31_ReservedX();

            checkBoxNO_BACKUP.Checked = cpuHelper.GetEAX00000019_ECX0_NO_BACKUPX();
            checkBoxRAND_IW_KEY.Checked = cpuHelper.GetEAX00000019_ECX1_RAND_IW_KEYX();
            textBoxECX_2_31_Reserved.Text = cpuHelper.GetEAX00000019ECX2_31_ReservedX();

            textBoxEDX_0_31_Reserved.Text = cpuHelper.GetEAX00000019EDX0_31_ReservedX();

            #endregion
        }
    }
}
