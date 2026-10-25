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
    public partial class EAX00000010 : Form
    {

        private CPUHelper cpuHelper;

        public EAX00000010()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x00000010: RDT-A (QoS allocation) enumeration

            textBoxEAX.Text = cpuHelper.GetEAX00000010EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX00000010EBXX();
            textBoxECX.Text = cpuHelper.GetEAX00000010ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX00000010EDXX();

            #endregion

        }
    }
}
