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
    public partial class EAX8C860000 : Form
    {

        private CPUHelper cpuHelper;

        public EAX8C860000()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x8C860000: Hygon Extended Feature Flags

            string cpuIdEAX8C860000EAX = cpuHelper.GetEAX8C860000EAXX();
            textBoxEAX8C860000EAX.Text = cpuIdEAX8C860000EAX;

            string cpuIdEAX8C860000EBX = cpuHelper.GetEAX8C860000EBXX();
            textBoxEAX8C860000EBX.Text = cpuIdEAX8C860000EBX;

            string cpuIdEAX8C860000ECX = cpuHelper.GetEAX8C860000ECXX();
            textBoxEAX8C860000ECX.Text = cpuIdEAX8C860000ECX;

            string cpuIdEAX8C860000EDX = cpuHelper.GetEAX8C860000EDXX();
            textBoxEAX8C860000EDX.Text = cpuIdEAX8C860000EDX;

            #endregion
        }
    }
}
