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
    public partial class EAX24ECX0 : Form
    {

        private CPUHelper cpuHelper;

        public EAX24ECX0()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x24, ECX=0x0: AVX10 Converged Vector ISA

            string cpuIdEAX24ECX0EAX = cpuHelper.GetEAX24ECX0EAXX();
            textBoxEAX24ECX0EAX.Text = cpuIdEAX24ECX0EAX;

            string cpuIdEAX24ECX0EBX = cpuHelper.GetEAX24ECX0EBXX();
            textBoxEAX24ECX0EBX.Text = cpuIdEAX24ECX0EBX;

            string cpuIdEAX24ECX0ECX = cpuHelper.GetEAX24ECX0ECXX();
            textBoxEAX24ECX0ECX.Text = cpuIdEAX24ECX0ECX;

            string cpuIdEAX24ECX0EDX = cpuHelper.GetEAX24ECX0EDXX();
            textBoxEAX24ECX0EDX.Text = cpuIdEAX24ECX0EDX;

            #endregion
        }
    }
}
