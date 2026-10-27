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

            #region EAX=0x00000012, ECX=0x00000002 to n: SGX Capabilities (2...n=EPC)

            textBoxEAX00000012EAX.Text = cpuHelper.GetEAX00000012ECXNEAXX(subLeafIndex);
            textBoxEAX00000012EBX.Text = cpuHelper.GetEAX00000012ECXNEBXX(subLeafIndex);
            textBoxEAX00000012ECX.Text = cpuHelper.GetEAX00000012ECXNECXX(subLeafIndex);
            textBoxEAX00000012EDX.Text = cpuHelper.GetEAX00000012ECXNEDXX(subLeafIndex);

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
