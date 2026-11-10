/*
    File           EAX19.cs
    Brief          Form for displaying EAX=0x19 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
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

            #region EAX=0x19: Intel Key Locker Features

            string cpuIdEAX19EAX = cpuHelper.GetEAX00000019EAXX();
            textBoxEAX19EAX.Text = cpuIdEAX19EAX;

            string cpuIdEAX19EBX = cpuHelper.GetEAX00000019EBXX();
            textBoxEAX19EBX.Text = cpuIdEAX19EBX;

            string cpuIdEAX19ECX = cpuHelper.GetEAX00000019ECXX();
            textBoxEAX19ECX.Text = cpuIdEAX19ECX;

            string cpuIdEAX19EDX = cpuHelper.GetEAX00000019EDXX();
            textBoxEAX19EDX.Text = cpuIdEAX19EDX;

            #endregion
        }
    }
}
