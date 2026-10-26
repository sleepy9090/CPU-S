/*
    File           EAX80860000.cs
    Brief          Form for displaying EAX=0x80860000 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/26/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX80860000 : Form
    {
        private CPUHelper cpuHelper;

        public EAX80860000()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x80860000: Vendor leaves - Transmeta - Maximum supported leaf and vendor ID string

            textBoxEAX.Text = cpuHelper.GetEAX80860000EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX80860000EBXX();
            textBoxECX.Text = cpuHelper.GetEAX80860000ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX80860000EDXX();

            #endregion
        }
    }
}
