/*
    File           EAXC0000002.cs
    Brief          Form for displaying EAX=0xC0000002 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/25/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAXC0000002 : Form
    {

        private CPUHelper cpuHelper;

        public EAXC0000002()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0xC0000002: Centaur - Performance Information - Centaur C5J (Esther)

            textBoxEAXC0000002EAX.Text = cpuHelper.GetEAXC0000002EAXX();
            textBoxEAXC0000002EBX.Text = cpuHelper.GetEAXC0000002EBXX();
            textBoxEAXC0000002ECX.Text = cpuHelper.GetEAXC0000002ECXX();
            textBoxEAXC0000002EDX.Text = cpuHelper.GetEAXC0000002EDXX();

            #endregion
        }
    }
}
