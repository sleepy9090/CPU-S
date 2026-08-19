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
    public partial class EAX80000008 : Form
    {

        private CPUHelper cpuHelper;

        public EAX80000008()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x80000008: Virtual and Physical Address Sizes

            string cpuIdEAX80000008EAX = cpuHelper.GetEAX80000008EAXX();
            textBoxEAX80000008EAX.Text = cpuIdEAX80000008EAX;

            string cpuIdEAX80000008EBX = cpuHelper.GetEAX80000008EBXX();
            textBoxEAX80000008EBX.Text = cpuIdEAX80000008EBX;

            string cpuIdEAX80000008ECX = cpuHelper.GetEAX80000008ECXX();
            textBoxEAX80000008ECX.Text = cpuIdEAX80000008ECX;

            string cpuIdEAX80000008EDX = cpuHelper.GetEAX80000008EDXX();
            textBoxEAX80000008EDX.Text = cpuIdEAX80000008EDX;

            #endregion
        }
    }
}
