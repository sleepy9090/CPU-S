/*
    File           EAX00000010ECX3.cs
    Brief          Form for displaying EAX=0x00000010, ECX=0x00000003 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           11/14/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX00000010ECX3 : Form
    {
        private CPUHelper cpuHelper;

        public EAX00000010ECX3()
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

            #region EAX=0x00000010, ECX=0x00000003: RDT-A (QoS allocation) enumeration, (3 = MBA)

            textBoxEAX.Text = cpuHelper.GetEAX00000010ECX3EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX00000010ECX3EBXX();
            textBoxECX.Text = cpuHelper.GetEAX00000010ECX3ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX00000010ECX3EDXX();

            #endregion
        }
    }
}
