/*
    File           EAX0000001A.cs
    Brief          Form for displaying EAX=0x0000001A CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           11/09/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX0000001A : Form
    {
        private CPUHelper cpuHelper;

        public EAX0000001A()
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

            #region EAX=0x0000001A: Core Model Information

            textBoxEAX.Text = cpuHelper.GetEAX0000001AEAXX();
            textBoxEBX.Text = cpuHelper.GetEAX0000001AEBXX();
            textBoxECX.Text = cpuHelper.GetEAX0000001AECXX();
            textBoxEDX.Text = cpuHelper.GetEAX0000001AEDXX();

            #endregion
        }
    }
}
