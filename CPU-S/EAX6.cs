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
    public partial class EAX6 : Form
    {

        private CPUHelper cpuHelper;

        public EAX6()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x6: Thermal and Power Management

            string cpuIdEAX6EAX = cpuHelper.GetEAX6EAXX();
            textBoxEAX6EAX.Text = cpuIdEAX6EAX;

            string cpuIdEAX6EBX = cpuHelper.GetEAX6EBXX();
            textBoxEAX6EBX.Text = cpuIdEAX6EBX;

            string cpuIdEAX6ECX = cpuHelper.GetEAX6ECXX();
            textBoxEAX6ECX.Text = cpuIdEAX6ECX;

            string cpuIdEAX6EDX = cpuHelper.GetEAX6EDXX();
            textBoxEAX6EDX.Text = cpuIdEAX6EDX;

            #endregion
        }
    }
}
