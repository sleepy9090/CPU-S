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
    public partial class EAXC0000001 : Form
    {

        private CPUHelper cpuHelper;

        public EAXC0000001()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0xC0000001: Centaur Feature Information

            string cpuIdEAXC0000001EAX = cpuHelper.GetEAXC0000001EAXX();
            textBoxEAXC0000001EAX.Text = cpuIdEAXC0000001EAX;

            string cpuIdEAXC0000001EBX = cpuHelper.GetEAXC0000001EBXX();
            textBoxEAXC0000001EBX.Text = cpuIdEAXC0000001EBX;

            string cpuIdEAXC0000001ECX = cpuHelper.GetEAXC0000001ECXX();
            textBoxEAXC0000001ECX.Text = cpuIdEAXC0000001ECX;

            string cpuIdEAXC0000001EDX = cpuHelper.GetEAXC0000001EDXX();
            textBoxEAXC0000001EDX.Text = cpuIdEAXC0000001EDX;

            #endregion
        }
    }
}
