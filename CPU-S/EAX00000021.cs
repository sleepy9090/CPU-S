/*
    File           EAX00000021.cs
    Brief          Form for displaying EAX=0x00000021 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/25/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System;
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

            foreach (TextBox textBox in this.GetAllControlsOfType<TextBox>())
            {
                textBox.ReadOnly = true;
            }

            foreach (CheckBox checkBox in this.GetAllControlsOfType<CheckBox>())
            {
                checkBox.AutoCheck = false;
            }

            #region EAX=0x00000021: Reserved for TDX enumeration

            string eax = cpuHelper.GetEAX00000021EAXX();
            textBoxEAX.Text = eax;
            string ebx = cpuHelper.GetEAX00000021EBXX();
            textBoxEBX.Text = ebx;
            string ecx = cpuHelper.GetEAX00000021ECXX();
            textBoxECX.Text = ecx;
            string edx = cpuHelper.GetEAX00000021EDXX();
            textBoxEDX.Text = edx;

            string maxSubleafBin = cpuHelper.GetEAX00000021EAXHightestFunctionParameterX();
            string maxSubleafDec = cpuHelper.BinaryStringToDecimalString(cpuHelper.GetEAX00000021EAXHightestFunctionParameterX());
            textBoxMaxSubleaf.Text = maxSubleafDec;
            textBoxMaxSubleafHex.Text = "0x" + cpuHelper.BinaryStringToHexString(maxSubleafBin);

            string ebxEcxEdxVendorIdString = cpuHelper.GetEAX00000021EBXEDXECXCpuVendorX();
            if (String.IsNullOrWhiteSpace(ebxEcxEdxVendorIdString))
            {
                ebxEcxEdxVendorIdString = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            textBoxEBXECXEDXVendorId.Text = ebxEcxEdxVendorIdString;

            string cpuIdEAX00000021EBXCpuVendor = cpuHelper.GetEAX00000021EBXCpuVendorX();
            if (String.IsNullOrWhiteSpace(cpuIdEAX00000021EBXCpuVendor))
            {
                cpuIdEAX00000021EBXCpuVendor = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            textBoxEBXVendorId.Text = cpuIdEAX00000021EBXCpuVendor;
            textBoxEBXVendorIdHex.Text = "0x" + cpuHelper.BinaryStringToHexString(ebx);

            string cpuIdEAX00000021ECXCpuVendor = cpuHelper.GetEAX00000021ECXCpuVendorX();
            if (String.IsNullOrWhiteSpace(cpuIdEAX00000021ECXCpuVendor))
            {
                cpuIdEAX00000021ECXCpuVendor = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            textBoxECXVendorId.Text = cpuIdEAX00000021ECXCpuVendor;
            textBoxECXVendorIdHex.Text = "0x" + cpuHelper.BinaryStringToHexString(ecx);

            string cpuIdEAX00000021EDXCpuVendor = cpuHelper.GetEAX00000021EDXCpuVendorX();
            if (String.IsNullOrWhiteSpace(cpuIdEAX00000021EDXCpuVendor))
            {
                cpuIdEAX00000021EDXCpuVendor = CPUConstants.NOT_FOUND_OR_UNKNOWN;
            }
            textBoxEDXVendorId.Text = cpuIdEAX00000021EDXCpuVendor;
            textBoxEDXVendorIdHex.Text = "0x" + cpuHelper.BinaryStringToHexString(edx);

            #endregion
        }
    }
}
