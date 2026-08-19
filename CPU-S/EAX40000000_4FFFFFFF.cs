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
    public partial class EAX40000000_4FFFFFFF : Form
    {

        private CPUHelper cpuHelper;

        public EAX40000000_4FFFFFFF()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x40000000-0x4FFFFFFF: Reserved for Hypervisors

            string cpuIdEAX40000000_4FFFFFFFEAX = cpuHelper.GetEAX40000000EAXX();
            textBoxEAX40000000_4FFFFFFFEAX.Text = cpuIdEAX40000000_4FFFFFFFEAX;

            string cpuIdEAX40000000_4FFFFFFFEBX = cpuHelper.GetEAX40000000EBXX();
            textBoxEAX40000000_4FFFFFFFEBX.Text = cpuIdEAX40000000_4FFFFFFFEBX;

            string cpuIdEAX40000000_4FFFFFFFECX = cpuHelper.GetEAX40000000ECXX();
            textBoxEAX40000000_4FFFFFFFECX.Text = cpuIdEAX40000000_4FFFFFFFECX;

            string cpuIdEAX40000000_4FFFFFFFEDX = cpuHelper.GetEAX40000000EDXX();
            textBoxEAX40000000_4FFFFFFFEDX.Text = cpuIdEAX40000000_4FFFFFFFEDX;

            #endregion
        }
    }
}
