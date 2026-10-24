/*
    File           EAX8FFFFFFE_8FFFFFFF.cs
    Brief          Form for displaying EAX=0x8FFFFFFE-0x8FFFFFFF CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX8FFFFFFE : Form
    {

        private CPUHelper cpuHelper;

        public EAX8FFFFFFE()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x8FFFFFFE: AMD Easter Eggs / DEI

            string cpuIdEAX8FFFFFFEEAX = cpuHelper.GetEAX8FFFFFFEEAXX();
            textBoxEAX.Text = cpuIdEAX8FFFFFFEEAX;

            string cpuIdEAX8FFFFFFEEBX = cpuHelper.GetEAX8FFFFFFEEBXX();
            textBoxEBX.Text = cpuIdEAX8FFFFFFEEBX;

            string cpuIdEAX8FFFFFFEECX = cpuHelper.GetEAX8FFFFFFEECXX();
            textBoxECX.Text = cpuIdEAX8FFFFFFEECX;

            string cpuIdEAX8FFFFFFEEDX = cpuHelper.GetEAX8FFFFFFEEDXX();
            textBoxEDX.Text = cpuIdEAX8FFFFFFEEDX;

            #endregion
        }
    }
}
