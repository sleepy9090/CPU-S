/*
    File           EAX6363452A.cs
    Brief          Form for displaying EAX=0x6363452A CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/26/2026
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
    public partial class EAX6363452A : Form
    {
        private CPUHelper cpuHelper;

        public EAX6363452A()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x6363452A: Config Leaves - Rise mP6 - Config

            textBoxEAX.Text = cpuHelper.GetEAX6363452AEAXX();
            textBoxEBX.Text = cpuHelper.GetEAX6363452AEBXX();
            textBoxECX.Text = cpuHelper.GetEAX6363452AECXX();
            textBoxEDX.Text = cpuHelper.GetEAX6363452AEDXX();

            #endregion
        }
    }
}
