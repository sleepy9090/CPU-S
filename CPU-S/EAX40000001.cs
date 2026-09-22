/*
    File           EAX40000001.cs
    Brief          Form for displaying EAX=0x40000001 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           09/22/2026
    Author         Shawn M. Crawford [sleepy]
*/
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
    public partial class EAX40000001 : Form
    {

        private CPUHelper cpuHelper;

        public EAX40000001()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x40000001: Reserved for Hypervisors

            string cpuIdEAX40000001_EAX = cpuHelper.GetEAX40000001EAXX();
            textBoxEAX40000001EAX.Text = cpuIdEAX40000001_EAX;

            string cpuIdEAX40000001_EBX = cpuHelper.GetEAX40000001EBXX();
            textBoxEAX40000001EBX.Text = cpuIdEAX40000001_EBX;

            string cpuIdEAX40000001_ECX = cpuHelper.GetEAX40000001ECXX();
            textBoxEAX40000001ECX.Text = cpuIdEAX40000001_ECX;

            string cpuIdEAX40000001_EDX = cpuHelper.GetEAX40000001EDXX();
            textBoxEAX40000001EDX.Text = cpuIdEAX40000001_EDX;

            textBoxEAX40000001InterfaceSignature.Text = cpuIdEAX40000001_EAX;

            string cpuIdEAX40000001EAX_InterfaceSignature = cpuHelper.BinaryStringToHexString(cpuIdEAX40000001_EAX);
            textBoxEAX40000001InterfaceSignatureHex.Text = "0x" + cpuIdEAX40000001EAX_InterfaceSignature;

            #endregion
        }
    }
}
