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
    public partial class EAX4 : Form
    {

        private CPUHelper cpuHelper;

        public EAX4()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x4: Cache Hierarchy and Topology

            string cpuIdEAX4EAX = cpuHelper.GetEAX4EAXX();
            textBoxEAX4EAX.Text = cpuIdEAX4EAX;

            string cpuIdEAX4EBX = cpuHelper.GetEAX4EBXX();
            textBoxEAX4EBX.Text = cpuIdEAX4EBX;

            string cpuIdEAX4ECX = cpuHelper.GetEAX4ECXX();
            textBoxEAX4ECX.Text = cpuIdEAX4ECX;

            string cpuIdEAX4EDX = cpuHelper.GetEAX4EDXX();
            textBoxEAX4EDX.Text = cpuIdEAX4EDX;

            #endregion
        }
    }
}
