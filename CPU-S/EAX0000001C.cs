/*
    File           EAX0000001C.cs
    Brief          Form for displaying EAX=0x0000001C CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           11/09/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX0000001C : Form
    {
        private CPUHelper cpuHelper;

        public EAX0000001C()
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

            #region EAX=0x0000001C: LBR Information

            textBoxEAX.Text = cpuHelper.GetEAX0000001CEAXX();
            textBoxEBX.Text = cpuHelper.GetEAX0000001CEBXX();
            textBoxECX.Text = cpuHelper.GetEAX0000001CECXX();
            textBoxEDX.Text = cpuHelper.GetEAX0000001CEDXX();

            #endregion
        }
    }
}
