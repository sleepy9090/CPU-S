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
    public partial class EAX7ECX0 : Form
    {

        private CPUHelper cpuHelper;

        public EAX7ECX0()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x7, ECX=0x0: Extended Features

            string cpuIdEAX7EAX = cpuHelper.GetEAX7ECX0EAXX();
            textBoxEAX7EAX.Text = cpuIdEAX7EAX;

            string cpuIdEAX7EBX = cpuHelper.GetEAX7ECX0EBXX();
            textBoxEAX7EBX.Text = cpuIdEAX7EBX;

            string cpuIdEAX7ECX = cpuHelper.GetEAX7ECX0ECXX();
            textBoxEAX7ECX.Text = cpuIdEAX7ECX;

            string cpuIdEAX7EDX = cpuHelper.GetEAX7ECX0EDXX();
            textBoxEAX7EDX.Text = cpuIdEAX7EDX;

            #endregion
        }
    }
}
