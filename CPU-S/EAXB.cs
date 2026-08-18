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
    public partial class EAXB : Form
    {

        private CPUHelper cpuHelper;

        public EAXB()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x4: Intel Thread/Core and Cache Topology

            string cpuIdEAXBEAX = cpuHelper.GetEAXBEAXX();
            textBoxEAXBEAX.Text = cpuIdEAXBEAX;

            string cpuIdEAXBEBX = cpuHelper.GetEAXBEBXX();
            textBoxEAXBEBX.Text = cpuIdEAXBEBX;

            string cpuIdEAXBECX = cpuHelper.GetEAXBECXX();
            textBoxEAXBECX.Text = cpuIdEAXBECX;

            string cpuIdEAXBEDX = cpuHelper.GetEAXBEDXX();
            textBoxEAXBEDX.Text = cpuIdEAXBEDX;

            #endregion
        }
    }
}
