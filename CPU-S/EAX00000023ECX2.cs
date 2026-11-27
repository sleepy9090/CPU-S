/*
    File           EAX00000023ECX2.cs
    Brief          Form for displaying EAX=0x00000023, ECX=0x00000002 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           11/27/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX00000023ECX2 : Form
    {
        private CPUHelper cpuHelper;

        public EAX00000023ECX2()
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

            #region EAX=0x00000023, ECX=0x00000002: Architectural perf mon extended information - (sub 2)



            #endregion
        }
    }
}
