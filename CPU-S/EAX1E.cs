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
    public partial class EAX1E : Form
    {

        private CPUHelper cpuHelper;

        public EAX1E()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x1E: Intel AMX Tile Multiplier (TMUL) Information

            string cpuIdEAX1EEAX = cpuHelper.GetEAX1EEAXX();
            textBoxEAX1EAX.Text = cpuIdEAX1EEAX;

            string cpuIdEAX1EEBX = cpuHelper.GetEAX1EEBXX();
            textBoxEAX1EBX.Text = cpuIdEAX1EEBX;

            string cpuIdEAX1EECX = cpuHelper.GetEAX1EECXX();
            textBoxEAX1ECX.Text = cpuIdEAX1EECX;

            string cpuIdEAX1EEDX = cpuHelper.GetEAX1EEDXX();
            textBoxEAX1EDX.Text = cpuIdEAX1EEDX;

            #endregion
        }
    }
}
