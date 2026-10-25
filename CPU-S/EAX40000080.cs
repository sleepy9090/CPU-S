/*
    File           EAX4000000D.cs
    Brief          Form for displaying EAX=0x4000000D CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           09/22/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX40000080 : Form
    {
        private CPUHelper cpuHelper;

        public EAX40000080()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x40000080: SYNDBG vendor plus max (deprecated) / unknown/undocumented

            textBoxEAX.Text = cpuHelper.GetEAX40000080EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX40000080EBXX();
            textBoxECX.Text = cpuHelper.GetEAX40000080ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX40000080EDXX();

            #endregion
        }
    }
}
