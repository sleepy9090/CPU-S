/*
    File           EAX80000019.cs
    Brief          Form for displaying EAX=0x80000019 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/26/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX80000019 : Form
    {
        private CPUHelper cpuHelper;

        public EAX80000019()
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

            #region EAX=0x80000019: TLB configuration descriptors

            textBoxEAX.Text = cpuHelper.GetEAX80000019EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX80000019EBXX();
            textBoxECX.Text = cpuHelper.GetEAX80000019ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX80000019EDXX();

            #endregion
        }
    }
}
