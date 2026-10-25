/*
    File           EAX00005A4E.cs
    Brief          Form for displaying EAX=0x00005A4E CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/25/2026
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
    public partial class EAX00005A4E : Form
    {
        private CPUHelper cpuHelper;

        public EAX00005A4E()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x00005A4E: Rise mP6 prank leaf

            textBoxEAX.Text = cpuHelper.GetEAX00005A4EEAXX();
            textBoxEBX.Text = cpuHelper.GetEAX00005A4EEBXX();
            textBoxECX.Text = cpuHelper.GetEAX00005A4EECXX();
            textBoxEDX.Text = cpuHelper.GetEAX00005A4EEDXX();

            #endregion
        }
    }
}
