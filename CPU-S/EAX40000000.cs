/*
    File           EAX40000000.cs
    Brief          Form for displaying EAX=0x40000000 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX40000000 : Form
    {

        private CPUHelper cpuHelper;

        public EAX40000000()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x40000000: Reserved for Hypervisors

            string cpuIdEAX40000000_EAX = cpuHelper.GetEAX40000000EAXX();
            textBoxEAX40000000_EAX.Text = cpuIdEAX40000000_EAX;

            string cpuIdEAX40000000_EBX = cpuHelper.GetEAX40000000EBXX();
            textBoxEAX40000000_EBX.Text = cpuIdEAX40000000_EBX;

            string cpuIdEAX40000000_ECX = cpuHelper.GetEAX40000000ECXX();
            textBoxEAX40000000_ECX.Text = cpuIdEAX40000000_ECX;

            string cpuIdEAX40000000_EDX = cpuHelper.GetEAX40000000EDXX();
            textBoxEAX40000000_EDX.Text = cpuIdEAX40000000_EDX;

            string cpuIdEAX40000000HightestFunctionParameter = cpuHelper.GetEAX40000000EAXHightestFunctionParameterX();
            textBoxEAX40000000EAXHightestFunctionParameter.Text = cpuIdEAX40000000HightestFunctionParameter;

            string cpuIdHexEAX40000000_EAXHightestFunctionParameter = cpuHelper.BinaryStringToHexString(cpuIdEAX40000000HightestFunctionParameter);
            textBoxEAX40000000Basic.Text = "0x" + cpuIdHexEAX40000000_EAXHightestFunctionParameter;

            string cpuIdEAX40000000_EBXCpuVendor = cpuHelper.GetEAX40000000EBXCpuVendorX();
            textBoxEAX40000000ID1.Text = cpuIdEAX40000000_EBXCpuVendor;

            string cpuIdEAX40000000_ECXCpuVendor = cpuHelper.GetEAX40000000ECXCpuVendorX();
            textBoxEAX40000000ID2.Text = cpuIdEAX40000000_ECXCpuVendor;

            string cpuIdEAX40000000_EDXCpuVendor = cpuHelper.GetEAX40000000EDXCpuVendorX();
            textBoxEAX40000000ID3.Text = cpuIdEAX40000000_EDXCpuVendor;

            textBox40000000CpuVendor.Text = cpuIdEAX40000000_EBXCpuVendor + cpuIdEAX40000000_ECXCpuVendor + cpuIdEAX40000000_EDXCpuVendor;

            #endregion
        }
    }
}
