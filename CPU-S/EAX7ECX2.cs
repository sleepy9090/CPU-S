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
    public partial class EAX7ECX2 : Form
    {

        private CPUHelper cpuHelper;

        public EAX7ECX2()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x7, ECX=0x2: Extended Features

            string cpuIdEAX7ECX2EAX = cpuHelper.GetEAX7ECX2EAXX();
            textBoxEAX7ECX2EAX.Text = cpuIdEAX7ECX2EAX;

            string cpuIdEAX7ECX2EBX = cpuHelper.GetEAX7ECX2EBXX();
            textBoxEAX7ECX2EBX.Text = cpuIdEAX7ECX2EBX;

            string cpuIdEAX7ECX2ECX = cpuHelper.GetEAX7ECX2ECXX();
            textBoxEAX7ECX2ECX.Text = cpuIdEAX7ECX2ECX;

            string cpuIdEAX7ECX2EDX = cpuHelper.GetEAX7ECX2EDXX();
            textBoxEAX7ECX2EDX.Text = cpuIdEAX7ECX2EDX;

            #endregion
        }
    }
}
