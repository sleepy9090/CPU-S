/*
    File           EAX00000012ECXN.cs
    Brief          Form for displaying EAX=0x00000012, ECX=0x00000002..N CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/26/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX00000012ECXN : Form
    {
        private CPUHelper cpuHelper;

        public EAX00000012ECXN()
        {
            InitializeComponent();
        }
    }
}
