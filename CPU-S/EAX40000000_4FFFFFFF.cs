/*
    File           EAX40000000_4FFFFFFF.cs
    Brief          Form for displaying EAX=0x40000000-0x4FFFFFFF CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX40000000_4FFFFFFF : Form
    {

        private CPUHelper cpuHelper;

        public EAX40000000_4FFFFFFF()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x40000000-0x4FFFFFFF: Reserved for Hypervisors

            string cpuIdEAX40000000_4FFFFFFFEAX = cpuHelper.GetEAX40000000EAXX();
            textBoxEAX40000000_4FFFFFFFEAX.Text = cpuIdEAX40000000_4FFFFFFFEAX;

            string cpuIdEAX40000000_4FFFFFFFEBX = cpuHelper.GetEAX40000000EBXX();
            textBoxEAX40000000_4FFFFFFFEBX.Text = cpuIdEAX40000000_4FFFFFFFEBX;

            string cpuIdEAX40000000_4FFFFFFFECX = cpuHelper.GetEAX40000000ECXX();
            textBoxEAX40000000_4FFFFFFFECX.Text = cpuIdEAX40000000_4FFFFFFFECX;

            string cpuIdEAX40000000_4FFFFFFFEDX = cpuHelper.GetEAX40000000EDXX();
            textBoxEAX40000000_4FFFFFFFEDX.Text = cpuIdEAX40000000_4FFFFFFFEDX;

            string cpuIdEAX40000000HightestFunctionParameter = cpuHelper.GetEAX40000000EAXHightestFunctionParameterX();
            textBoxEAX40000000EAXHightestFunctionParameter.Text = cpuIdEAX40000000HightestFunctionParameter;

            string cpuIdHexEAX40000000_4FFFFFFFEAXHightestFunctionParameter = cpuHelper.BinaryStringToHexString(cpuIdEAX40000000HightestFunctionParameter);
            textBoxEAX40000000Basic.Text = "0x" + cpuIdHexEAX40000000_4FFFFFFFEAXHightestFunctionParameter;

            string cpuIdEAX40000000_4FFFFFFFEBXCpuVendor = cpuHelper.GetEAX40000000EBXCpuVendorX();
            textBoxEAX40000000ID1.Text = cpuIdEAX40000000_4FFFFFFFEBXCpuVendor;

            string cpuIdEAX40000000_4FFFFFFFECXCpuVendor = cpuHelper.GetEAX40000000ECXCpuVendorX();
            textBoxEAX40000000ID2.Text = cpuIdEAX40000000_4FFFFFFFECXCpuVendor;

            string cpuIdEAX40000000_4FFFFFFFEDXCpuVendor = cpuHelper.GetEAX40000000EDXCpuVendorX();
            textBoxEAX40000000ID3.Text = cpuIdEAX40000000_4FFFFFFFEDXCpuVendor;

            textBox40000000CpuVendor.Text = cpuIdEAX40000000_4FFFFFFFEBXCpuVendor + cpuIdEAX40000000_4FFFFFFFECXCpuVendor + cpuIdEAX40000000_4FFFFFFFEDXCpuVendor;

            #endregion
        }
    }
}
