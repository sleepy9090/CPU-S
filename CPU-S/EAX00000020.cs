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
    public partial class EAX00000020 : Form
    {

        private CPUHelper cpuHelper;

        public EAX00000020()
        {
            InitializeComponent();
            
            cpuHelper = new CPUHelper();

            #region EAX=0x00000020: HRESET Information

            textBoxEAX.Text = cpuHelper.GetEAX00000020EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX00000020EBXX();
            textBoxECX.Text = cpuHelper.GetEAX00000020ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX00000020EDXX();

            #endregion
        }
    }
}
