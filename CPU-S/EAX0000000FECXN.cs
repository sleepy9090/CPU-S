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
    public partial class EAX0000000FECXN : Form
    {

        private CPUHelper cpuHelper;

        public EAX0000000FECXN(int subLeafIndex)
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x0000000F: RDT-M (QoS monitoring) enumeration, ECX=1..n - 1=L3

            textBoxEAX0000000FEAX.Text = cpuHelper.GetEAX0000000FEAX_ECXX(subLeafIndex);
            textBoxEAX0000000FEBX.Text = cpuHelper.GetEAX0000000FEBX_ECXX(subLeafIndex);
            textBoxEAX0000000FECX.Text = cpuHelper.GetEAX0000000FECX_ECXX(subLeafIndex);
            textBoxEAX0000000FEDX.Text = cpuHelper.GetEAX0000000FEDX_ECXX(subLeafIndex);

            #endregion
        }
    }
}
