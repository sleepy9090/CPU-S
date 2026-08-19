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
    public partial class EAX80000002_80000003_80000004 : Form
    {

        private CPUHelper cpuHelper;

        public EAX80000002_80000003_80000004()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x80000002,0x80000003,0x80000004: Processor Brand String

            string cpuIdEAX80000002EAX = cpuHelper.GetEAX80000002EAXX();
            textBoxEAX80000002EAX.Text = cpuIdEAX80000002EAX;

            string cpuIdEAX80000002EBX = cpuHelper.GetEAX80000002EBXX();
            textBoxEAX80000002EBX.Text = cpuIdEAX80000002EBX;

            string cpuIdEAX80000002ECX = cpuHelper.GetEAX80000002ECXX();
            textBoxEAX80000002ECX.Text = cpuIdEAX80000002ECX;

            string cpuIdEAX80000002EDX = cpuHelper.GetEAX80000002EDXX();
            textBoxEAX80000002EDX.Text = cpuIdEAX80000002EDX;

            string cpuIdEAX80000003EAX = cpuHelper.GetEAX80000003EAXX();
            textBoxEAX80000003EAX.Text = cpuIdEAX80000003EAX;

            string cpuIdEAX80000003EBX = cpuHelper.GetEAX80000003EBXX();
            textBoxEAX80000003EBX.Text = cpuIdEAX80000003EBX;

            string cpuIdEAX80000003ECX = cpuHelper.GetEAX80000003ECXX();
            textBoxEAX80000003ECX.Text = cpuIdEAX80000003ECX;

            string cpuIdEAX80000003EDX = cpuHelper.GetEAX80000003EDXX();
            textBoxEAX80000003EDX.Text = cpuIdEAX80000003EDX;

            string cpuIdEAX80000004EAX = cpuHelper.GetEAX80000004EAXX();
            textBoxEAX80000004EAX.Text = cpuIdEAX80000004EAX;

            string cpuIdEAX80000004EBX = cpuHelper.GetEAX80000004EBXX();
            textBoxEAX80000004EBX.Text = cpuIdEAX80000004EBX;

            string cpuIdEAX80000004ECX = cpuHelper.GetEAX80000004ECXX();
            textBoxEAX80000004ECX.Text = cpuIdEAX80000004ECX;

            string cpuIdEAX80000004EDX = cpuHelper.GetEAX80000004EDXX();
            textBoxEAX80000004EDX.Text = cpuIdEAX80000004EDX;

            string cpuIdEAX80000002_3_4EAXEBXECXEDXProcessorBrandString = cpuHelper.GetEAX80000002_3_4EAXEBXECXEDXProcessorBrandStringX();
            textBoxProcessorBrandString.Text = cpuIdEAX80000002_3_4EAXEBXECXEDXProcessorBrandString;

            #endregion
        }
    }
}
