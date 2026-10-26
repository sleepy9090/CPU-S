/*
    File           EAX80860003_80860004_80860005_80860006.cs
    Brief          Form for displaying EAX=0x80860003, 0x80860004, 0x80860005, and 0x80860006 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/26/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX80860003_80860004_80860005_80860006 : Form
    {
        private CPUHelper cpuHelper;

        public EAX80860003_80860004_80860005_80860006()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x80860003-EAX=0x80860006: Vendor leaves - Transmeta - CMS Info String

            textBox80860003EAX.Text = cpuHelper.GetEAX80860003EAXX();
            textBox80860003EBX.Text = cpuHelper.GetEAX80860003EBXX();
            textBox80860003ECX.Text = cpuHelper.GetEAX80860003ECXX();
            textBox80860003EDX.Text = cpuHelper.GetEAX80860003EDXX();

            textBox80860004EAX.Text = cpuHelper.GetEAX80860004EAXX();
            textBox80860004EBX.Text = cpuHelper.GetEAX80860004EBXX();
            textBox80860004ECX.Text = cpuHelper.GetEAX80860004ECXX();
            textBox80860004EDX.Text = cpuHelper.GetEAX80860004EDXX();

            textBox80860005EAX.Text = cpuHelper.GetEAX80860005EAXX();
            textBox80860005EBX.Text = cpuHelper.GetEAX80860005EBXX();
            textBox80860005ECX.Text = cpuHelper.GetEAX80860005ECXX();
            textBox80860005EDX.Text = cpuHelper.GetEAX80860005EDXX();

            textBox80860006EAX.Text = cpuHelper.GetEAX80860006EAXX();
            textBox80860006EBX.Text = cpuHelper.GetEAX80860006EBXX();
            textBox80860006ECX.Text = cpuHelper.GetEAX80860006ECXX();
            textBox80860006EDX.Text = cpuHelper.GetEAX80860006EDXX();

            #endregion
        }
    }
}
