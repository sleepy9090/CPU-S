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
    public partial class EAX80000021 : Form
    {

        private CPUHelper cpuHelper;

        public EAX80000021()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x80000021: Extended Feature Identification

            string cpuIdEAX80000021EAX = cpuHelper.GetEAX80000021EAXX();
            textBoxEAX80000021EAX.Text = cpuIdEAX80000021EAX;

            string cpuIdEAX80000021EBX = cpuHelper.GetEAX80000021EBXX();
            textBoxEAX80000021EBX.Text = cpuIdEAX80000021EBX;

            string cpuIdEAX80000021ECX = cpuHelper.GetEAX80000021ECXX();
            textBoxEAX80000021ECX.Text = cpuIdEAX80000021ECX;

            string cpuIdEAX80000021EDX = cpuHelper.GetEAX80000021EDXX();
            textBoxEAX80000021EDX.Text = cpuIdEAX80000021EDX;

            #endregion
        }
    }
}
