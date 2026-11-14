/*
    File           EAX00000010ECX5.cs
    Brief          Form for displaying EAX=0x00000010, ECX=0x00000005 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           11/14/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX00000010ECX5 : Form
    {
        private CPUHelper cpuHelper;

        public EAX00000010ECX5()
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

            #region EAX=0x00000010, ECX=0x00000005: RDT-A (QoS allocation) enumeration, (5 = CBA)

            textBoxEAX.Text = cpuHelper.GetEAX00000010ECX5EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX00000010ECX5EBXX();
            textBoxECX.Text = cpuHelper.GetEAX00000010ECX5ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX00000010ECX5EDXX();

            #endregion
        }
    }
}
