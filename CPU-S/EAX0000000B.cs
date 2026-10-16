/*
    File           EAXB.cs
    Brief          Form for displaying EAX=0xB CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX0000000B : Form
    {

        private CPUHelper cpuHelper;

        public EAX0000000B()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x0000000B: Topology enumeration information



            #endregion
        }
    }
}
