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
    public partial class EAX80000001 : Form
    {

        private CPUHelper cpuHelper;

        public EAX80000001()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x80000001: Extended Processor Info and Feature Bits

            string cpuIdEAX80000001EAX = cpuHelper.GetEAX80000001EAXX();
            textBoxEAX80000001EAX.Text = cpuIdEAX80000001EAX;

            string cpuIdEAX80000001EBX = cpuHelper.GetEAX80000001EBXX();
            textBoxEAX80000001EBX.Text = cpuIdEAX80000001EBX;

            string cpuIdEAX80000001ECX = cpuHelper.GetEAX80000001ECXX();
            textBoxEAX80000001ECX.Text = cpuIdEAX80000001ECX;

            string cpuIdEAX80000001EDX = cpuHelper.GetEAX80000001EDXX();
            textBoxEAX80000001EDX.Text = cpuIdEAX80000001EDX;

            #endregion
        }
    }
}
