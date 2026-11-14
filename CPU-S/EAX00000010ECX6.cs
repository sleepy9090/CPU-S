/*
    File           EAX00000010ECX6.cs
    Brief          Form for displaying EAX=0x00000010, ECX=0x00000006 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           11/14/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX00000010ECX6 : Form
    {
        private CPUHelper cpuHelper;

        public EAX00000010ECX6()
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

            #region EAX=0x00000010, ECX=0x00000006: RDT-A (QoS allocation) enumeration, (6 = RP)

            textBoxEAX.Text = cpuHelper.GetEAX00000010ECX6EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX00000010ECX6EBXX();
            textBoxECX.Text = cpuHelper.GetEAX00000010ECX6ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX00000010ECX6EDXX();

            #endregion
        }
    }
}
