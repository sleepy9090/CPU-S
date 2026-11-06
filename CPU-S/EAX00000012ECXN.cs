/*
    File           EAX00000012ECXN.cs
    Brief          Form for displaying EAX=0x00000012, ECX=0x00000002..N CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/26/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX00000012ECXN : Form
    {
        private CPUHelper cpuHelper;

        private int currentSubLeafIndex;

        public EAX00000012ECXN(int subLeafIndex)
        {
            InitializeComponent();

            currentSubLeafIndex = subLeafIndex;
            textBoxCurrentN.Text = subLeafIndex.ToString();

            cpuHelper = new CPUHelper();

            foreach (TextBox textBox in this.GetAllControlsOfType<TextBox>())
            {
                textBox.ReadOnly = true;
            }

            foreach (CheckBox checkBox in this.GetAllControlsOfType<CheckBox>())
            {
                checkBox.AutoCheck = false;
            }

            #region EAX=0x00000012, ECX=0x00000002 to n: SGX Capabilities (2...n=EPC)

            textBoxEAX00000012EAX.Text = cpuHelper.GetEAX00000012ECXNEAXX(subLeafIndex);
            textBoxEAX00000012EBX.Text = cpuHelper.GetEAX00000012ECXNEBXX(subLeafIndex);
            textBoxEAX00000012ECX.Text = cpuHelper.GetEAX00000012ECXNECXX(subLeafIndex);
            textBoxEAX00000012EDX.Text = cpuHelper.GetEAX00000012ECXNEDXX(subLeafIndex);

            string eAX00000012ECXN_EAX0_3_LeafValid_NotValid_ReservedString = cpuHelper.GetEAX00000012ECXN_EAX0_3_LeafValid_NotValid_ReservedX(subLeafIndex);
            int eAX00000012ECXN_EAX0_3_LeafValid_NotValid_ReservedValue = int.Parse(eAX00000012ECXN_EAX0_3_LeafValid_NotValid_ReservedString);
            switch(eAX00000012ECXN_EAX0_3_LeafValid_NotValid_ReservedValue)
            {
                case 0:
                    textBoxLeafValid_NotValid_Reserved.Text = eAX00000012ECXN_EAX0_3_LeafValid_NotValid_ReservedString + " - Not Valid";
                    break;
                case 1:
                    textBoxLeafValid_NotValid_Reserved.Text = eAX00000012ECXN_EAX0_3_LeafValid_NotValid_ReservedString + " - Valid";
                    break;
                default:
                    textBoxLeafValid_NotValid_Reserved.Text = eAX00000012ECXN_EAX0_3_LeafValid_NotValid_ReservedString + " - Reserved";
                    break;
            }


            textBoxEAX4_11_Reserved.Text = cpuHelper.GetEAX00000012ECXN_EAX4_11_ReservedX(subLeafIndex);
            textBoxEPCBaseBits_31_12.Text = cpuHelper.GetEAX00000012ECXN_EAX12_31_EPCBaseBits_31_12X(subLeafIndex);
            textBoxEPCBaseBits_51_32.Text = cpuHelper.GetEAX00000012ECXN_EBX0_19_EPCBaseBits_51_32X(subLeafIndex);
            textBoxEBX20_31_Reserved.Text = cpuHelper.GetEAX00000012ECXN_EBX20_31_ReservedX(subLeafIndex);

            string eAX00000012ECXN_ECX0_3_EPCSectionProtectionString = cpuHelper.GetEAX00000012ECXN_ECX0_3_EPCSectionProtectionX(subLeafIndex);
            int eAX00000012ECXN_ECX0_3_EPCSectionProtectionValue = int.Parse(eAX00000012ECXN_ECX0_3_EPCSectionProtectionString);
            switch(eAX00000012ECXN_ECX0_3_EPCSectionProtectionValue)
            {
                case 0:
                    textBoxEPCSectionProtection.Text = eAX00000012ECXN_ECX0_3_EPCSectionProtectionString + " - Not Valid";
                    break;
                case 1:
                    textBoxEPCSectionProtection.Text = eAX00000012ECXN_ECX0_3_EPCSectionProtectionString + " - Confidentiality + Integrity + Replay";
                    break;
                case 2:
                    textBoxEPCSectionProtection.Text = eAX00000012ECXN_ECX0_3_EPCSectionProtectionString + " - Confidentiality";
                    break;
                case 3:
                    textBoxEPCSectionProtection.Text = eAX00000012ECXN_ECX0_3_EPCSectionProtectionString + " - Confidentiality + Integrity";
                    break;
                default:
                    textBoxEPCSectionProtection.Text = eAX00000012ECXN_ECX0_3_EPCSectionProtectionString + " - Reserved";
                    break;
            }

            textBoxECX4_11_Reserved.Text = cpuHelper.GetEAX00000012ECXN_ECX4_11_ReservedX(subLeafIndex);
            textBoxEPCSizeBits_31_12.Text = cpuHelper.GetEAX00000012ECXN_ECX12_31_EPCSizeBits_31_12X(subLeafIndex);
            textBoxEPCSizeBits_51_32.Text = cpuHelper.GetEAX00000012ECXN_EDX0_19_EPCSizeBits_51_32X(subLeafIndex);
            textBox20_31_Reserved.Text = cpuHelper.GetEAX00000012ECXN_EDX20_31_ReservedX(subLeafIndex);

            #endregion
        }

        private void buttonNext_Click(object sender, System.EventArgs e)
        {
            currentSubLeafIndex++;
            // 2...n=EPC
            EAX00000012ECXN nextForm = new EAX00000012ECXN(currentSubLeafIndex);
            nextForm.ShowDialog();
        }
    }
}
