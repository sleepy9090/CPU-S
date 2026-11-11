/*
    File           EAX00000009.cs
    Brief          Form for displaying EAX=0x00000009 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           11/10/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX00000009 : Form
    {
        private CPUHelper cpuHelper;

        public EAX00000009()
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

            #region EAX=0x00000009: DCA Parameters

            textBoxEAX00000009EAX.Text = cpuHelper.GetEAX00000009EAXX();
            textBoxEAX00000009EBX.Text = cpuHelper.GetEAX00000009EBXX();
            textBoxEAX00000009ECX.Text = cpuHelper.GetEAX00000009ECXX();
            textBoxEAX00000009EDX.Text = cpuHelper.GetEAX00000009EDXX();

            textBoxValueOfPlatformDcaCapMsr.Text = cpuHelper.GetEAX00000009EAX0_31_ValueOfPlatformDcaCapMsrX();

            textBoxEBXReserved.Text = cpuHelper.GetEAX00000009EBX0_31_ReservedX();

            textBoxECXReserved.Text = cpuHelper.GetEAX00000009ECX0_31_ReservedX();

            textBoxEDXReserved.Text = cpuHelper.GetEAX00000009EDX0_31_ReservedX();

            #endregion
        }
    }
}
