/*
    File           EAX8000001C.cs
    Brief          Form for displaying EAX=0x8000001C CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/27/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX8000001C : Form
    {
        private CPUHelper cpuHelper;

        public EAX8000001C()
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

            #region EAX=0x8000001C: LWP Information

            textBoxEAX.Text = cpuHelper.GetEAX8000001CEAXX();
            textBoxEBX.Text = cpuHelper.GetEAX8000001CEBXX();
            textBoxECX.Text = cpuHelper.GetEAX8000001CECXX();
            textBoxEDX.Text = cpuHelper.GetEAX8000001CEDXX();

            #endregion
        }
    }
}
