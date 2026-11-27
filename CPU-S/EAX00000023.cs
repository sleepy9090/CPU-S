/*
    File           EAX00000023.cs
    Brief          Form for displaying EAX=0x00000023 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/25/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX00000023 : Form
    {

        private CPUHelper cpuHelper;

        public EAX00000023()
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

            #region EAX=0x00000023: Architectural perf mon extended information - (sub 0)

            textBoxEAX.Text = cpuHelper.GetEAX00000023EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX00000023EBXX();
            textBoxECX.Text = cpuHelper.GetEAX00000023ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX00000023EDXX();

            #endregion
        }
    }
}
