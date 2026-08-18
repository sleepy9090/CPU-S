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

            string cpuIdEAX7ECX0EAX = cpuHelper.GetEAX7ECX0EAXX();
            textBoxEAX7ECX0EAX.Text = cpuIdEAX7ECX0EAX;

            string cpuIdEAX7ECX0EBX = cpuHelper.GetEAX7ECX0EBXX();
            textBoxEAX7ECX0EBX.Text = cpuIdEAX7ECX0EBX;

            string cpuIdEAX7ECX0ECX = cpuHelper.GetEAX7ECX0ECXX();
            textBoxEAX7ECX0ECX.Text = cpuIdEAX7ECX0ECX;

            string cpuIdEAX7ECX0EDX = cpuHelper.GetEAX7ECX0EDXX();
            textBoxEAX7ECX0EDX.Text = cpuIdEAX7ECX0EDX;

            #endregion
        }
    }
}
