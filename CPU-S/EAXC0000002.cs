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
    public partial class EAXC0000002 : Form
    {

        private CPUHelper cpuHelper;

        public EAXC0000002()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0xC0000002: Centaur Extended CPUID Performance Data

            string cpuIdEAXC0000002EAX = cpuHelper.GetEAXC0000002EAXX();
            textBoxEAXC0000002EAX.Text = cpuIdEAXC0000002EAX;

            string cpuIdEAXC0000002EBX = cpuHelper.GetEAXC0000002EBXX();
            textBoxEAXC0000002EBX.Text = cpuIdEAXC0000002EBX;

            string cpuIdEAXC0000002ECX = cpuHelper.GetEAXC0000002ECXX();
            textBoxEAXC0000002ECX.Text = cpuIdEAXC0000002ECX;

            string cpuIdEAXC0000002EDX = cpuHelper.GetEAXC0000002EDXX();
            textBoxEAXC0000002EDX.Text = cpuIdEAXC0000002EDX;

            #endregion
        }
    }
}
