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
    public partial class EAX8000001F : Form
    {

        private CPUHelper cpuHelper;

        public EAX8000001F()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x8000001F: Encrypted Memory Capabilities

            string cpuIdEAX8000001FEAX = cpuHelper.GetEAX8000001FEAXX();
            textBoxEAX8000001FEAX.Text = cpuIdEAX8000001FEAX;

            string cpuIdEAX8000001FEBX = cpuHelper.GetEAX8000001FEBXX();
            textBoxEAX8000001FEBX.Text = cpuIdEAX8000001FEBX;

            string cpuIdEAX8000001FECX = cpuHelper.GetEAX8000001FECXX();
            textBoxEAX8000001FECX.Text = cpuIdEAX8000001FECX;

            string cpuIdEAX8000001FEDX = cpuHelper.GetEAX8000001FEDXX();
            textBoxEAX8000001FEDX.Text = cpuIdEAX8000001FEDX;

            #endregion
        }
    }
}
