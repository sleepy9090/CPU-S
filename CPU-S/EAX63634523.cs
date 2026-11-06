/*
    File           EAX63634523.cs
    Brief          Form for displaying EAX=0x63634523 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/26/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX63634523 : Form
    {
        private CPUHelper cpuHelper;

        public EAX63634523()
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

            #region EAX=0x63634523: Config Leaves - Rise mP6 - Config

            textBoxEAX.Text = cpuHelper.GetEAX63634523EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX63634523EBXX();
            textBoxECX.Text = cpuHelper.GetEAX63634523ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX63634523EDXX();

            #endregion
        }
    }
}
