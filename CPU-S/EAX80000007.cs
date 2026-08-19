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
    public partial class EAX80000007 : Form
    {

        private CPUHelper cpuHelper;

        public EAX80000007()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x80000007: Processor Power Management Information and RAS Capabilities

            string cpuIdEAX80000007EAX = cpuHelper.GetEAX80000007EAXX();
            textBoxEAX80000007EAX.Text = cpuIdEAX80000007EAX;

            string cpuIdEAX80000007EBX = cpuHelper.GetEAX80000007EBXX();
            textBoxEAX80000007EBX.Text = cpuIdEAX80000007EBX;

            string cpuIdEAX80000007ECX = cpuHelper.GetEAX80000007ECXX();
            textBoxEAX80000007ECX.Text = cpuIdEAX80000007ECX;

            string cpuIdEAX80000007EDX = cpuHelper.GetEAX80000007EDXX();
            textBoxEAX80000007EDX.Text = cpuIdEAX80000007EDX;

            #endregion
        }
    }
}
