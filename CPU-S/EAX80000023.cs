/*
    File           EAX80000023.cs
    Brief          Form for displaying EAX=0x80000023 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/26/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX80000023 : Form
    {
        private CPUHelper cpuHelper;

        public EAX80000023()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x80000023: Secure host multi-key memory encryption information

            textBoxEAX.Text = cpuHelper.GetEAX80000023EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX80000023EBXX();
            textBoxECX.Text = cpuHelper.GetEAX80000023ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX80000023EDXX();

            #endregion
        }
    }
}
