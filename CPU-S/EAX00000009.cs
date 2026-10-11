/*
    File           EAX00000009.cs
    Brief          Form for displaying EAX=0x00000009 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
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
    public partial class EAX00000009 : Form
    {
        private CPUHelper cpuHelper;

        public EAX00000009()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x00000009: DCA Parameters

            textBoxEAX00000009EAX.Text = cpuHelper.GetEAX00000009EAXX();
            textBoxEAX00000009EBX.Text = cpuHelper.GetEAX00000009EBXX();
            textBoxEAX00000009ECX.Text = cpuHelper.GetEAX00000009ECXX();
            textBoxEAX00000009EDX.Text = cpuHelper.GetEAX00000009EDXX();

            textBoxValueOfPlatformDcaCapMsr.Text = cpuHelper.GetEAX00000009EAX0_31_ValueOfPlatformDcaCapMsrX();

            #endregion
        }
    }
}
