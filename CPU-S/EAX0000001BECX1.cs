/*
    File           EAX0000001BECX1.cs
    Brief          Form for displaying EAX=0x0000001B, ECX=0x00000001 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           11/11/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX0000001BECX1 : Form
    {

        private CPUHelper cpuHelper;

        public EAX0000001BECX1()
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

            #region EAX=0x0000001B: ECX=0x00000001, 1=target ID - PCONFIG Information

            textBoxEAX.Text = cpuHelper.GetEAX0000001BECX1EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX0000001BECX1EBXX();
            textBoxECX.Text = cpuHelper.GetEAX0000001BECX1ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX0000001BECX1EDXX();

            textBoxSubleaf1TargetId.Text = cpuHelper.GetEAX0000001BECX1EAX0_11_Subleaf1TargetIdX();
            textBoxEAXReserved.Text = cpuHelper.GetEAX0000001BEAX12_31_ReservedX();

            textBoxEBXTargetId1.Text = cpuHelper.GetEAX0000001BECX1EBX0_31_TargetId1X();

            textBoxECXTargetId2.Text = cpuHelper.GetEAX0000001BECX1ECX0_31_TargetId2X();

            textBoxEDXTargetId3.Text = cpuHelper.GetEAX0000001BECX1EDX0_31_TargetId3X();

            #endregion
        }
    }
}
