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
    public partial class EAX8000000A : Form
    {

        private CPUHelper cpuHelper;

        public EAX8000000A()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x8000000A: SVM features

            string cpuIdEAX8000000AEAX = cpuHelper.GetEAX8000000AEAXX();
            textBoxEAX8000000AEAX.Text = cpuIdEAX8000000AEAX;

            string cpuIdEAX8000000AEBX = cpuHelper.GetEAX8000000AEBXX();
            textBoxEAX8000000AEBX.Text = cpuIdEAX8000000AEBX;

            string cpuIdEAX8000000AECX = cpuHelper.GetEAX8000000AECXX();
            textBoxEAX8000000AECX.Text = cpuIdEAX8000000AECX;

            string cpuIdEAX8000000AEDX = cpuHelper.GetEAX8000000AEDXX();
            textBoxEAX8000000AEDX.Text = cpuIdEAX8000000AEDX;

            #endregion
        }
    }
}
