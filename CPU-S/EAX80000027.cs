/*
    File           EAX80000027.cs
    Brief          Form for displaying EAX=0x80000027 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/26/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX80000027 : Form
    {
        private CPUHelper cpuHelper;

        public EAX80000027()
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

            #region EAX=0x80000027: Workload class information

            textBoxEAX.Text = cpuHelper.GetEAX80000027EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX80000027EBXX();
            textBoxECX.Text = cpuHelper.GetEAX80000027ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX80000027EDXX();

            #endregion
        }
    }
}
