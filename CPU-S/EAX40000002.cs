/*
    File           EAX40000002.cs
    Brief          Form for displaying EAX=0x40000002 CPU information.
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
    public partial class EAX40000002 : Form
    {

        private CPUHelper cpuHelper;

        public EAX40000002()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x40000002: Reserved for Hypervisors - version information

            string cpuIdEAX40000002_EAX = cpuHelper.GetEAX40000002EAXX();
            textBoxEAX40000002EAX.Text = cpuIdEAX40000002_EAX;

            string cpuIdEAX40000002_EBX = cpuHelper.GetEAX40000002EBXX();
            textBoxEAX40000002EBX.Text = cpuIdEAX40000002_EBX;

            string cpuIdEAX40000002_ECX = cpuHelper.GetEAX40000002ECXX();
            textBoxEAX40000002ECX.Text = cpuIdEAX40000002_ECX;

            string cpuIdEAX40000002_EDX = cpuHelper.GetEAX40000002EDXX();
            textBoxEAX40000002EDX.Text = cpuIdEAX40000002_EDX;


            string cpuIdEAX40000002_EAX_0_31_BuildNumber = cpuHelper.GetEAX40000002_EAX_0_31_BuildNumberX();
            textBoxBuildNumber.Text = cpuIdEAX40000002_EAX_0_31_BuildNumber;

            string cpuIdEAX40000002_EBX_0_15_MinorVersion = cpuHelper.GetEAX40000002_EBX_0_15_MinorVersionX();
            textBoxMinorVersion.Text = cpuIdEAX40000002_EBX_0_15_MinorVersion;

            string cpuIdEAX40000002_EBX_16_31_MajorVersion = cpuHelper.GetEAX40000002_EBX_16_31_MajorVersionX();
            textBoxMajorVersion.Text = cpuIdEAX40000002_EBX_16_31_MajorVersion;

            string cpuIdEAX40000002_ECX_0_31_ServicePack = cpuHelper.GetEAX40000002_ECX_0_31_ServicePackX();
            textBoxServicePack.Text = cpuIdEAX40000002_ECX_0_31_ServicePack;

            string cpuIdEAX40000002_EDX_0_23_ServiceNumber = cpuHelper.GetEAX40000002_EDX_0_23_ServiceNumberX();
            textBoxServiceNumber.Text = cpuIdEAX40000002_EDX_0_23_ServiceNumber;

            string cpuIdEAX40000002_EDX_24_31_ServiceBranch = cpuHelper.GetEAX40000002_EDX_24_31_ServiceBranchX();
            textBoxServiceBranch.Text = cpuIdEAX40000002_EDX_24_31_ServiceBranch;

            #endregion
        }
    }
}
