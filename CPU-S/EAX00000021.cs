/*
    File           EAX00000021.cs
    Brief          Form for displaying EAX=0x00000021 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/25/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX00000021 : Form
    {

        private CPUHelper cpuHelper;

        public EAX00000021()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x00000021: Reserved for TDX enumeration

            textBoxEAX.Text = cpuHelper.GetEAX00000021EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX00000021EBXX();
            textBoxECX.Text = cpuHelper.GetEAX00000021ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX00000021EDXX();

            string maxSubleafBin = cpuHelper.GetEAX00000021EAXHightestFunctionParameterX();
            string maxSubleafDec = cpuHelper.BinaryStringToDecimalString(cpuHelper.GetEAX00000021EAXHightestFunctionParameterX());
            textBoxMaxSubleaf.Text = maxSubleafDec;
            textBoxMaxSubleafHex.Text = "0x" + cpuHelper.BinaryStringToHexString(maxSubleafBin);

            textBoxVendorId.Text = cpuHelper.GetEAX00000021EBXEDXECXCpuVendorX();

            string cpuIdEAX00000021EBXCpuVendor = cpuHelper.GetEAX00000021EBXCpuVendorX();
            textBoxEBXVendorId.Text = cpuIdEAX00000021EBXCpuVendor;
            textBoxEBXVendorIdHex.Text = "0x" + cpuHelper.BinaryStringToHexString(cpuIdEAX00000021EBXCpuVendor);

            string cpuIdEAX00000021ECXCpuVendor = cpuHelper.GetEAX00000021ECXCpuVendorX();
            textBoxECXVendorId.Text = cpuIdEAX00000021ECXCpuVendor;
            textBoxECXVendorIdHex.Text = "0x" + cpuHelper.BinaryStringToHexString(cpuIdEAX00000021ECXCpuVendor);

            string cpuIdEAX00000021EDXCpuVendor = cpuHelper.GetEAX00000021EDXCpuVendorX();
            textBoxEDXVendorId.Text = cpuIdEAX00000021EDXCpuVendor;
            textBoxEDXVendorIdHex.Text = "0x" + cpuHelper.BinaryStringToHexString(cpuIdEAX00000021EDXCpuVendor);

            #endregion
        }
    }
}
