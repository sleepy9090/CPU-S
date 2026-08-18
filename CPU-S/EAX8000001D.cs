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
    public partial class EAX8000001D : Form
    {

        private CPUHelper cpuHelper;

        public EAX8000001D()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x8000001D: Cache Hierarchy and Topology

            string cpuIdEAX8000001DEAX = cpuHelper.GetEAX8000001DEAXX();
            textBoxEAX8000001DEAX.Text = cpuIdEAX8000001DEAX;

            string cpuIdEAX8000001DEBX = cpuHelper.GetEAX8000001DEBXX();
            textBoxEAX8000001DEBX.Text = cpuIdEAX8000001DEBX;

            string cpuIdEAX8000001DECX = cpuHelper.GetEAX8000001DECXX();
            textBoxEAX8000001DECX.Text = cpuIdEAX8000001DECX;

            string cpuIdEAX8000001DEDX = cpuHelper.GetEAX8000001DEDXX();
            textBoxEAX8000001DEDX.Text = cpuIdEAX8000001DEDX;

            #endregion
        }
    }
}
