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
    public partial class EAX18 : Form
    {

        private CPUHelper cpuHelper;

        public EAX18()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x18: TLB Hierarchy and Topology

            string cpuIdEAX18EAX = cpuHelper.GetEAX18EAXX();
            textBoxEAX18EAX.Text = cpuIdEAX18EAX;

            string cpuIdEAX18EBX = cpuHelper.GetEAX18EBXX();
            textBoxEAX18EBX.Text = cpuIdEAX18EBX;

            string cpuIdEAX18ECX = cpuHelper.GetEAX18ECXX();
            textBoxEAX18ECX.Text = cpuIdEAX18ECX;

            string cpuIdEAX18EDX = cpuHelper.GetEAX18EDXX();
            textBoxEAX18EDX.Text = cpuIdEAX18EDX;

            #endregion
        }
    }
}
