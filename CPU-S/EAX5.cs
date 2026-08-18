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
    public partial class EAX5 : Form
    {

        private CPUHelper cpuHelper;

        public EAX5()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x5: MONITOR/MWAIT Features

            string cpuIdEAX5EAX = cpuHelper.GetEAX5EAXX();
            textBoxEAX5EAX.Text = cpuIdEAX5EAX;

            string cpuIdEAX5EBX = cpuHelper.GetEAX5EBXX();
            textBoxEAX5EBX.Text = cpuIdEAX5EBX;

            string cpuIdEAX5ECX = cpuHelper.GetEAX5ECXX();
            textBoxEAX5ECX.Text = cpuIdEAX5ECX;

            string cpuIdEAX5EDX = cpuHelper.GetEAX5EDXX();
            textBoxEAX5EDX.Text = cpuIdEAX5EDX;

            #endregion
        }
    }
}
