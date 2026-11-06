/*
    File           EAX4000000B.cs
    Brief          Form for displaying EAX=0x4000000B CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           09/22/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX4000000B : Form
    {
        private CPUHelper cpuHelper;

        public EAX4000000B()
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

            #region EAX=0x4000000B: Reserved for Hypervisors - Unknown/Undocumented

            textBoxEAX.Text = cpuHelper.GetEAX4000000BEAXX();
            textBoxEBX.Text = cpuHelper.GetEAX4000000BEBXX();
            textBoxECX.Text = cpuHelper.GetEAX4000000BECXX();
            textBoxEDX.Text = cpuHelper.GetEAX4000000BEDXX();

            #endregion
        }
    }
}
