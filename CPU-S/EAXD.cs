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
    public partial class EAXD : Form
    {

        private CPUHelper cpuHelper;

        public EAXD()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0xD: XSAVE Features and State Components

            string cpuIdEAXDEAX = cpuHelper.GetEAXDEAXX();
            textBoxEAXDEAX.Text = cpuIdEAXDEAX;

            string cpuIdEAXDEBX = cpuHelper.GetEAXDEBXX();
            textBoxEAXDEBX.Text = cpuIdEAXDEBX;

            string cpuIdEAXDECX = cpuHelper.GetEAXDECXX();
            textBoxEAXDECX.Text = cpuIdEAXDECX;

            string cpuIdEAXDEDX = cpuHelper.GetEAXDEDXX();
            textBoxEAXDEDX.Text = cpuIdEAXDEDX;

            #endregion
        }
    }
}
