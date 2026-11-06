/*
    File           EAX4C780002.cs
    Brief          Form for displaying EAX=0x4C780002 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/25/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX4C780002 : Form
    {
        private CPUHelper cpuHelper;

        public EAX4C780002()
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

            #region EAX=0x4C780002: Get supervisor information - Linux bugs

            textBoxEAX.Text = cpuHelper.GetEAX4C780002EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX4C780002EBXX();
            textBoxECX.Text = cpuHelper.GetEAX4C780002ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX4C780002EDXX();

            #endregion
        }
    }
}
