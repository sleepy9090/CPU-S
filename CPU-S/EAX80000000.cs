/*
    File           EAX80000000.cs
    Brief          Form for displaying EAX=0x80000000 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
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

            textBoxEAX.Text = cpuHelper.GetEAX80000000EAXX();
            string cpuIdEBX = cpuHelper.GetEAX80000000EBXX();
            textBoxEBX.Text = cpuIdEBX;
            string cpuIdECX = cpuHelper.GetEAX80000000ECXX();
            textBoxECX.Text = cpuIdECX;
            string cpuIdEDX = cpuHelper.GetEAX80000000EDXX();
            textBoxEDX.Text = cpuIdEDX;

            string cpuIdHightestFunctionParameter = cpuHelper.GetEAX80000000EAXHightestFunctionParameterX();
            textBoxHightestFunctionParameter.Text = cpuIdHightestFunctionParameter;

            textBoxCpuVendorId.Text = cpuHelper.GetEAX80000000EBXEDXECXCpuVendorX();

            string cpuIdHexEAX0EAXHightestFunctionParameter = cpuHelper.BinaryStringToHexString(cpuIdHightestFunctionParameter);
            textBoxHightestFunctionParameterHex.Text = "0x" + cpuIdHexEAX0EAXHightestFunctionParameter;

            textBoxHightestFunctionParameterDec.Text = cpuHelper.BinaryStringToDecimalString(cpuIdHightestFunctionParameter);

            string cpuIdEBXCpuVendor = cpuHelper.GetEAX80000000EBXCpuVendorX();
            textBoxID1.Text = cpuIdEBXCpuVendor;
            textBoxID1Hex.Text = "0x" + cpuHelper.BinaryStringToHexString(cpuIdEBX);

            string cpuIdECXCpuVendor = cpuHelper.GetEAX80000000ECXCpuVendorX();
            textBoxID2.Text = cpuIdECXCpuVendor;
            textBoxID2Hex.Text = "0x" + cpuHelper.BinaryStringToHexString(cpuIdECX);

            string cpuIdEDXCpuVendor = cpuHelper.GetEAX80000000EDXCpuVendorX();
            textBoxID3.Text = cpuIdEDXCpuVendor;
            textBoxID3Hex.Text = "0x" + cpuHelper.BinaryStringToHexString(cpuIdEDX);

            #endregion
        }
    }
}
