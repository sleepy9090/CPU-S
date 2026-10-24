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
    public partial class EAX8FFFFFFF : Form
    {

        private CPUHelper cpuHelper;

        public EAX8FFFFFFF()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x8FFFFFFF: AMD Easter Eggs / AMD Prank Leaf

            string cpuIdEAX8FFFFFFFEAX = cpuHelper.GetEAX8FFFFFFFEAXX();
            textBoxEAX.Text = cpuIdEAX8FFFFFFFEAX;

            string cpuIdEAX8FFFFFFFEBX = cpuHelper.GetEAX8FFFFFFFEBXX();
            textBoxEBX.Text = cpuIdEAX8FFFFFFFEBX;

            string cpuIdEAX8FFFFFFFECX = cpuHelper.GetEAX8FFFFFFFECXX();
            textBoxECX.Text = cpuIdEAX8FFFFFFFECX;

            string cpuIdEAX8FFFFFFFEDX = cpuHelper.GetEAX8FFFFFFFEDXX();
            textBoxEDX.Text = cpuIdEAX8FFFFFFFEDX;

            #endregion

        }
    }
}
