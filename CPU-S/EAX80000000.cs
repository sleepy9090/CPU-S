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
    public partial class EAX80000000 : Form
    {

        private CPUHelper cpuHelper;

        public EAX80000000()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x80000000: Highest Extended Function Implemented

            string cpuIdEAX80000000EAX = cpuHelper.GetEAX80000000EAXX();
            textBoxEAX80000000EAX.Text = cpuIdEAX80000000EAX;

            string cpuIdEAX80000000EBX = cpuHelper.GetEAX80000000EBXX();
            textBoxEAX80000000EBX.Text = cpuIdEAX80000000EBX;

            string cpuIdEAX80000000ECX = cpuHelper.GetEAX80000000ECXX();
            textBoxEAX80000000ECX.Text = cpuIdEAX80000000ECX;

            string cpuIdEAX80000000EDX = cpuHelper.GetEAX80000000EDXX();
            textBoxEAX80000000EDX.Text = cpuIdEAX80000000EDX;

            string cpuIdEAX80000000EAX_HighestExtendedFunctionImplemented = cpuHelper.GetEAX80000000EAX_HighestExtendedFunctionImplementedX();
            textBoxEAX80000000EAX_HighestExtendedFunctionImplemented.Text = cpuIdEAX80000000EAX_HighestExtendedFunctionImplemented;

            #endregion
        }
    }
}
