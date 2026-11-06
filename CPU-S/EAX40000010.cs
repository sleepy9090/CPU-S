/*
    File           EAX40000010.cs
    Brief          Form for displaying EAX=0x40000010 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           09/22/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX40000010 : Form
    {
        private CPUHelper cpuHelper;

        public EAX40000010()
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

            #region EAX=0x40000010: Reserved for Hypervisors - Frequency

            textBoxEAX.Text = cpuHelper.GetEAX40000010EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX40000010EBXX();
            textBoxECX.Text = cpuHelper.GetEAX40000010ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX40000010EDXX();

            #endregion
        }
    }
}
