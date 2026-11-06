/*
    File           EAX4000000C.cs
    Brief          Form for displaying EAX=0x4000000C CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           09/22/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX4000000C : Form
    {
        private CPUHelper cpuHelper;

        public EAX4000000C()
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

            #region EAX=0x4000000C: Reserved for Hypervisors - Isolation configuration

            textBoxEAX.Text = cpuHelper.GetEAX4000000CEAXX();
            textBoxEBX.Text = cpuHelper.GetEAX4000000CEBXX();
            textBoxECX.Text = cpuHelper.GetEAX4000000CECXX();
            textBoxEDX.Text = cpuHelper.GetEAX4000000CEDXX();

            #endregion
        }
    }
}
