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
    public partial class EAXC0000006ECX0 : Form
    {

        private CPUHelper cpuHelper;

        public EAXC0000006ECX0()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0xC0000006, ECX=0: Zhaoxin Feature Information

            string cpuIdEAXC0000006ECX0EAX = cpuHelper.GetEAXC0000006ECX0EAXX();
            textBoxEAXC0000006ECX0EAX.Text = cpuIdEAXC0000006ECX0EAX;

            string cpuIdEAXC0000006ECX0EBX = cpuHelper.GetEAXC0000006ECX0EBXX();
            textBoxEAXC0000006ECX0EBX.Text = cpuIdEAXC0000006ECX0EBX;

            string cpuIdEAXC0000006ECX0ECX = cpuHelper.GetEAXC0000006ECX0ECXX();
            textBoxEAXC0000006ECX0ECX.Text = cpuIdEAXC0000006ECX0ECX;

            string cpuIdEAXC0000006ECX0EDX = cpuHelper.GetEAXC0000006ECX0EDXX();
            textBoxEAXC0000006ECX0EDX.Text = cpuIdEAXC0000006ECX0EDX;

            #endregion
        }
    }
}
