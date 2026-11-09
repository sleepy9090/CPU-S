/*
    File           EAX0000001F.cs
    Brief          Form for displaying EAX=0x0000001F CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           11/09/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX0000001F : Form
    {
        private CPUHelper cpuHelper;

        public EAX0000001F()
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

            #region EAX=0x0000001F: Topology Enumeration Information

            textBoxEAX.Text = cpuHelper.GetEAX0000001FEAXX();
            textBoxEBX.Text = cpuHelper.GetEAX0000001FEBXX();
            textBoxECX.Text = cpuHelper.GetEAX0000001FECXX();
            textBoxEDX.Text = cpuHelper.GetEAX0000001FEDXX();

            #endregion
        }
    }
}
