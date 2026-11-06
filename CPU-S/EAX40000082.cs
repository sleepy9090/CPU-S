/*
    File           EAX4000000F.cs
    Brief          Form for displaying EAX=0x4000000F CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           09/22/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX40000082 : Form
    {
        private CPUHelper cpuHelper;

        public EAX40000082()
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

            #region EAX=0x40000082: SYNDBG platform capabilities (deprecated) / undocumented/Virtual Stack Properties

            textBoxEAX.Text = cpuHelper.GetEAX40000082EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX40000082EBXX();
            textBoxECX.Text = cpuHelper.GetEAX40000082ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX40000082EDXX();

            #endregion
        }
    }
}
