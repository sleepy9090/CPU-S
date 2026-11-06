/*
    File           EAX00000024ECXN.cs
    Brief          Form for displaying EAX=0x00000024, ECX=0x00000001..n CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/25/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX00000024ECXN : Form
    {

        private CPUHelper cpuHelper;

        public EAX00000024ECXN(int subLeafIndex)
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

            #region EAX=0x00000024, ECX=0x00000001..n: Discrete AVX10 Features

            textBoxEAX.Text = cpuHelper.GetEAX00000024ECXNEAXX(subLeafIndex);
            textBoxEBX.Text = cpuHelper.GetEAX00000024ECXNEBXX(subLeafIndex);
            textBoxECX.Text = cpuHelper.GetEAX00000024ECXNECXX(subLeafIndex);
            textBoxEDX.Text = cpuHelper.GetEAX00000024ECXNEDXX(subLeafIndex);

            #endregion
        }
    }
}
