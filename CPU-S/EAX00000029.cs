/*
    File           EAX00000029.cs
    Brief          Form for displaying EAX=0x00000029 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/25/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System;
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX00000029 : Form
    {
        private CPUHelper cpuHelper;

        private int currentSubLeafIndex;

        public EAX00000029(int subLeafIndex)
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

            #region EAX=0x00000029: APX Information

            textBoxEAX.Text = cpuHelper.GetEAX00000029_ECXN_EAXX(subLeafIndex);
            textBoxEBX.Text = cpuHelper.GetEAX00000029_ECXN_EBXX(subLeafIndex);
            textBoxECX.Text = cpuHelper.GetEAX00000029_ECXN_ECXX(subLeafIndex);
            textBoxEDX.Text = cpuHelper.GetEAX00000029_ECXN_EDXX(subLeafIndex);

            textBoxEAXMaxSubleaf.Text = cpuHelper.GetEAX00000029_ECXN_EAX_0_31_MaxSubleafX(subLeafIndex);
            checkBoxEBX0_APX_NCI_NDD_NF.Checked = cpuHelper.GetEAX00000029_ECXN_EBX0_APX_NCI_NDD_NFIsSupportedX(subLeafIndex);
            textBoxEBX1_31_Reserved.Text = cpuHelper.GetEAX00000029_ECXN_EBX1_31_ReservedX(subLeafIndex);
            textBoxECXReserved.Text = cpuHelper.GetEAX00000029_ECXN_ECX_0_31_ReservedX(subLeafIndex);
            textBoxEDXReserved.Text = cpuHelper.GetEAX00000029_ECXN_EDX_0_31_ReservedX(subLeafIndex);

            #endregion
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            currentSubLeafIndex++;

            EAX00000029 nextForm = new EAX00000029(currentSubLeafIndex);
            nextForm.ShowDialog();

        }
    }
}
