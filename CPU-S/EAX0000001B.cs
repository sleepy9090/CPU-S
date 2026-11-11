/*
    File           EAX0000001B.cs
    Brief          Form for displaying EAX=0x0000001B CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           11/09/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX0000001B : Form
    {
        private CPUHelper cpuHelper;

        public EAX0000001B()
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

            #region EAX=0x0000001B: PCONFIG Information

            textBoxEAX.Text = cpuHelper.GetEAX0000001BEAXX();
            textBoxEBX.Text = cpuHelper.GetEAX0000001BEBXX();
            textBoxECX.Text = cpuHelper.GetEAX0000001BECXX();
            textBoxEDX.Text = cpuHelper.GetEAX0000001BEDXX();

            textBoxSubleaf0Invalid.Text = cpuHelper.GetEAX0000001BEAX0_11_Subleaf0InvalidX();
            textBoxEAXReserved.Text = cpuHelper.GetEAX0000001BEAX12_31_ReservedX();

            textBoxEBXReserved.Text = cpuHelper.GetEAX0000001BEBX0_31_ReservedX();

            textBoxECXReserved.Text = cpuHelper.GetEAX0000001BECX0_31_ReservedX();

            textBoxEDXReserved.Text = cpuHelper.GetEAX0000001BEDX0_31_ReservedX();

            #endregion
        }
    }
}
