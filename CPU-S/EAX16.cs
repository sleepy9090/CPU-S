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
    public partial class EAX16 : Form
    {

        private CPUHelper cpuHelper;

        public EAX16()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x16: Processor and Bus specification frequencies

            string cpuIdEAX16EAX = cpuHelper.GetEAX16EAXX();
            textBoxEAX16EAX.Text = cpuIdEAX16EAX;

            string cpuIdEAX16EBX = cpuHelper.GetEAX16EBXX();
            textBoxEAX16EBX.Text = cpuIdEAX16EBX;

            string cpuIdEAX16ECX = cpuHelper.GetEAX16ECXX();
            textBoxEAX16ECX.Text = cpuIdEAX16ECX;

            string cpuIdEAX16EDX = cpuHelper.GetEAX16EDXX();
            textBoxEAX16EDX.Text = cpuIdEAX16EDX;

            #endregion
        }
    }
}
