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
    public partial class EAX0 : Form
    {

        private CPUHelper cpuHelper;

        public EAX0()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX = 0x0: Highest Function Parameter and Manufacturer ID

            string cpuIdEAX0EAX = cpuHelper.GetEAX0EAXX();
            textBoxEAX0EAX.Text = cpuIdEAX0EAX;

            string cpuIdEAX0EBX = cpuHelper.GetEAX0EBXX();
            textBoxEAX0EBX.Text = cpuIdEAX0EBX;

            string cpuIdEAX0ECX = cpuHelper.GetEAX0ECXX();
            textBoxEAX0ECX.Text = cpuIdEAX0ECX;

            string cpuIdEAX0EDX = cpuHelper.GetEAX0EDXX();
            textBoxEAX0EDX.Text = cpuIdEAX0EDX;

            string cpuIdEAX0EAXHightestFunctionParameter = cpuHelper.GetEAX0EAXHightestFunctionParameterX();
            textBoxEAX0EAXHightestFunctionParameter.Text = cpuIdEAX0EAXHightestFunctionParameter;

            string cpuIdEAX0EBXEDXECXCpuVendor = cpuHelper.GetEAX0EBXEDXECXCpuVendorX();
            textBoxEAX0EBXEDXECXCpuVendor.Text = cpuIdEAX0EBXEDXECXCpuVendor;

            string cpuIdHexEAX0EAXHightestFunctionParameter = cpuHelper.BinaryStringToHexString(cpuIdEAX0EAXHightestFunctionParameter);
            textBoxEAX0Basic.Text = "0x" + cpuIdHexEAX0EAXHightestFunctionParameter;

            string cpuIdEAX0EBXCpuVendor = cpuHelper.GetEAX0EBXCpuVendorX();
            textBoxEAX0ID1.Text = cpuIdEAX0EBXCpuVendor;

            string cpuIdEAX0ECXCpuVendor = cpuHelper.GetEAX0ECXCpuVendorX();
            textBoxEAX0ID2.Text = cpuIdEAX0ECXCpuVendor;

            string cpuIdEAX0EDXCpuVendor = cpuHelper.GetEAX0EDXCpuVendorX();
            textBoxEAX0ID3.Text = cpuIdEAX0EDXCpuVendor;

            #endregion
        }
    }
}
