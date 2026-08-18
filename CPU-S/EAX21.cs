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
    public partial class EAX21 : Form
    {

        private CPUHelper cpuHelper;

        public EAX21()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x21: Reserved for TDX enumeration

            string cpuIdEAX21EAX = cpuHelper.GetEAX21EAXX();
            textBoxEAX21EAX.Text = cpuIdEAX21EAX;

            string cpuIdEAX21EBX = cpuHelper.GetEAX21EBXX();
            textBoxEAX21EBX.Text = cpuIdEAX21EBX;

            string cpuIdEAX21ECX = cpuHelper.GetEAX21ECXX();
            textBoxEAX21ECX.Text = cpuIdEAX21ECX;

            string cpuIdEAX21EDX = cpuHelper.GetEAX21EDXX();
            textBoxEAX21EDX.Text = cpuIdEAX21EDX;

            #endregion
        }
    }
}
