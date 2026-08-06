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
    public partial class EAX1 : Form
    {

        private CPUHelper cpuHelper;

        public EAX1()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region

            string cpuIdEAX1EAX = cpuHelper.GetEAX1EAXX();
            textBoxEAX1EAX.Text = cpuIdEAX1EAX;

            string cpuIdEAX1EBX = cpuHelper.GetEAX1EBXX();
            textBoxEAX1EBX.Text = cpuIdEAX1EBX;

            string cpuIdEAX1ECX = cpuHelper.GetEAX1ECXX();
            textBoxEAX1ECX.Text = cpuIdEAX1ECX;

            string cpuIdEAX1EDX = cpuHelper.GetEAX1EDXX();
            textBoxEAX1EDX.Text = cpuIdEAX1EDX;

            string cpuIdEAX1EAX0_3_SteppingId = cpuHelper.GetEAX1EAX0_3_SteppingIdX();
            textBoxEAX1EAX0_3_SteppingId.Text = cpuIdEAX1EAX0_3_SteppingId;

            #endregion
        }
    }
}
