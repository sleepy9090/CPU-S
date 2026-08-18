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
    public partial class EAX14ECX0 : Form
    {

        private CPUHelper cpuHelper;

        public EAX14ECX0()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x14, ECX=0x0: Processor Trace feature bits in EBX and ECX

            string cpuIdEAX14ECX0EAXX = cpuHelper.GetEAX14ECX0EAXX();
            textBoxEAX14ECX0EAX.Text = cpuIdEAX14ECX0EAXX;

            string cpuIdEAX14ECX0EBX = cpuHelper.GetEAX14ECX0EBXX();
            textBoxEAX14ECX0EBX.Text = cpuIdEAX14ECX0EBX;

            string cpuIdEAX14ECX0ECX = cpuHelper.GetEAX14ECX0ECXX();
            textBoxEAX14ECX0ECX.Text = cpuIdEAX14ECX0ECX;

            string cpuIdEAX14ECX0EDX = cpuHelper.GetEAX14ECX0EDXX();
            textBoxEAX14ECX0EDX.Text = cpuIdEAX14ECX0EDX;

            #endregion
        }
    }
}
