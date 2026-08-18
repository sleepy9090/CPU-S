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
    public partial class EAX17 : Form
    {

        private CPUHelper cpuHelper;

        public EAX17()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x17: SoC Vendor Attribute Enumeration

            string cpuIdEAX17EAX = cpuHelper.GetEAX17EAXX();
            textBoxEAX17EAX.Text = cpuIdEAX17EAX;

            string cpuIdEAX17EBX = cpuHelper.GetEAX17EBXX();
            textBoxEAX17EBX.Text = cpuIdEAX17EBX;

            string cpuIdEAX17ECX = cpuHelper.GetEAX17ECXX();
            textBoxEAX17ECX.Text = cpuIdEAX17ECX;

            string cpuIdEAX17EDX = cpuHelper.GetEAX17EDXX();
            textBoxEAX17EDX.Text = cpuIdEAX17EDX;

            #endregion
        }
    }
}
