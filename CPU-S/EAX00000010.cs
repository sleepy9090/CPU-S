/*
    File           EAX00000010.cs
    Brief          Form for displaying EAX=0x00000010 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           11/14/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX00000010 : Form
    {

        private CPUHelper cpuHelper;

        public EAX00000010()
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

            #region EAX=0x00000010: RDT-A (QoS allocation) enumeration

            textBoxEAX.Text = cpuHelper.GetEAX00000010EAXX();
            textBoxEBX.Text = cpuHelper.GetEAX00000010EBXX();
            textBoxECX.Text = cpuHelper.GetEAX00000010ECXX();
            textBoxEDX.Text = cpuHelper.GetEAX00000010EDXX();

            textBoxEAXReserved.Text = cpuHelper.GetEAX00000010EAX_ReservedX();
            checkBoxEBX0Reserved.Checked = cpuHelper.GetEAX00000010EBX0_ReservedIsSupportedX();
            checkBoxEBX1L3CacheQoSEnforcement.Checked = cpuHelper.GetEAX00000010EBX1_L3CacheQoSEnforcementIsSupportedX();
            checkBoxEBX2L2CacheQoSEnforcement.Checked = cpuHelper.GetEAX00000010EBX2_L2CacheQoSEnforcementIsSupportedX();
            checkBoxEBX3MBAMemoryBandwidthAllocation.Checked = cpuHelper.GetEAX00000010EBX3_MBAMemoryBandwidthAllocationIsSupportedX();
            checkBoxEBX4Reserved.Checked = cpuHelper.GetEAX00000010EBX4_ReservedIsSupportedX();
            checkBoxEBX5CBACacheBandwidthAllocation.Checked = cpuHelper.GetEAX00000010EBX5_CBACacheBandwidthAllocationIsSupportedX();
            checkBoxEBX6RPResourcePriority.Checked = cpuHelper.GetEAX00000010EBX6_RPResourcePriorityIsSupportedX();
            textBoxEBX7_31_Reserved.Text = cpuHelper.GetEAX00000010EBX_7_31_ReservedX();
            textBoxECXReserved.Text = cpuHelper.GetEAX00000010ECX_ReservedX();
            checkBoxEDX0Reserved.Checked = cpuHelper.GetEAX00000010EDX0_ReservedIsSupportedX();
            checkBoxEDX1AMDAPM.Checked = cpuHelper.GetEAX00000010EDX1_AMDAPMIsSupportedX();
            textBoxEDX2_31_Reserved.Text = cpuHelper.GetEAX00000010EDX_2_31_ReservedX();

            #endregion

        }
    }
}
