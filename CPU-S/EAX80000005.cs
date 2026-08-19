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
    public partial class EAX80000005 : Form
    {

        private CPUHelper cpuHelper;

        public EAX80000005()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x80000005: L1 Cache and TLB Identifiers

            string cpuIdEAX80000005EAX = cpuHelper.GetEAX80000005EAXX();
            textBoxEAX80000005EAX.Text = cpuIdEAX80000005EAX;

            string cpuIdEAX80000005EBX = cpuHelper.GetEAX80000005EBXX();
            textBoxEAX80000005EBX.Text = cpuIdEAX80000005EBX;

            string cpuIdEAX80000005ECX = cpuHelper.GetEAX80000005ECXX();
            textBoxEAX80000005ECX.Text = cpuIdEAX80000005ECX;

            string cpuIdEAX80000005EDX = cpuHelper.GetEAX80000005EDXX();
            textBoxEAX80000005EDX.Text = cpuIdEAX80000005EDX;

            #endregion
        }
    }
}
