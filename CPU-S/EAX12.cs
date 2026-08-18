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
    public partial class EAX12 : Form
    {

        private CPUHelper cpuHelper;

        public EAX12()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x12: SGX Capabilities

            string cpuIdEAX12EAX = cpuHelper.GetEAX12EAXX();
            textBoxEAX12EAX.Text = cpuIdEAX12EAX;

            string cpuIdEAX12EBX = cpuHelper.GetEAX12EBXX();
            textBoxEAX12EBX.Text = cpuIdEAX12EBX;

            string cpuIdEAX12ECX = cpuHelper.GetEAX12ECXX();
            textBoxEAX12ECX.Text = cpuIdEAX12ECX;

            string cpuIdEAX12EDX = cpuHelper.GetEAX12EDXX();
            textBoxEAX12EDX.Text = cpuIdEAX12EDX;

            #endregion
        }
    }
}
