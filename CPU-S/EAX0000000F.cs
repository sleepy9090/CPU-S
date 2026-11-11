/*
    File           EAX0000000F.cs
    Brief          Form for displaying EAX=0x0000000F CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/21/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX0000000F : Form
    {

        private CPUHelper cpuHelper;

        public EAX0000000F()
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

            #region EAX=0x0000000F: RDT-M (QoS monitoring) enumeration, ECX=0 - resources: 0=main

            textBoxEAX0000000FEAX.Text = cpuHelper.GetEAX0000000FEAXX();
            textBoxEAX0000000FEBX.Text = cpuHelper.GetEAX0000000FEBXX();
            textBoxEAX0000000FECX.Text = cpuHelper.GetEAX0000000FECXX();
            textBoxEAX0000000FEDX.Text = cpuHelper.GetEAX0000000FEDXX();

            textBoxEAXReserved.Text = cpuHelper.GetEAX0000000FEAX_ReservedX();
            textBoxMaxRangeOfRMIDWithinThisPhysProcessorOfAllTypes.Text = cpuHelper.GetEAX0000000FEBX_MaxRangeOfRMIDWithinThisPhysProcessorOfAllTypesX();
            textBoxECXReserved.Text = cpuHelper.GetEAX0000000FECX_ReservedX();
            textBoxReserved0.Text = cpuHelper.GetEAX0000000FEDX_0_ReservedX();
            textBoxL3CacheQoSMonitoring.Text = cpuHelper.GetEAX0000000FEDX_1_L3CacheQoSMonitoringX();
            textBoxReserved2_31.Text = cpuHelper.GetEAX0000000FEDX_2_31_ReservedX();

            #endregion
        }
    }
}
