/*
    File           EAX0000000B.cs
    Brief          Form for displaying EAX=0x0000000B CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/17/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX0000000B : Form
    {

        private CPUHelper cpuHelper;

        public EAX0000000B(int subLeafIndex)
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x0000000B: Topology enumeration information

            textBoxEAX0000000BEAX.Text = cpuHelper.GetEAX0000000BEAXX(subLeafIndex);
            textBoxEAX0000000BEBX.Text = cpuHelper.GetEAX0000000BEBXX(subLeafIndex);
            textBoxEAX0000000BECX.Text = cpuHelper.GetEAX0000000BECXX(subLeafIndex);
            textBoxEAX0000000BEDX.Text = cpuHelper.GetEAX0000000BEDXX(subLeafIndex);

            textBoxEAX0000000BEAX0_4_NumberOfBitsThatX2APICIDMustBeShiftedToRightForNextDomain.Text = cpuHelper.GetEAX0000000BEAX0_4_NumberOfBitsThatX2APICIDMustBeShiftedToRightForNextDomainX(subLeafIndex);
            textBoxEAX0000000BEAX5_31_Reserved.Text = cpuHelper.GetEAX0000000BEAX5_31_ReservedX(subLeafIndex);

            textBoxEAX0000000BEBX0_15_NumberOfLogicalProcessors.Text = cpuHelper.GetEAX0000000BEBX0_15_NumberOfLogicalProcessorsX(subLeafIndex);
            textBoxEAX0000000BEBX16_31_Reserved.Text = cpuHelper.GetEAX0000000BEBX16_31_ReservedX(subLeafIndex);

            textBoxEAX0000000BECX0_7_InputECXSubLeafIndex.Text = cpuHelper.GetEAX0000000BECX0_7_InputECXSubLeafIndexX(subLeafIndex);
            string domainType = cpuHelper.GetEAX0000000BECX8_15_DomainTypeX(subLeafIndex);
            textBoxEAX0000000BECX8_15_DomainType.Text = domainType;
            switch (domainType)
            {
                case "0":
                    textBoxDomainType.Text = "Invalid";
                    break;
                case "1":
                    textBoxDomainType.Text = "Thread";
                    break;
                case "2":
                    textBoxDomainType.Text = "Core, implied=package/socket";
                    break;
                default:
                    textBoxDomainType.Text = "Reserved";
                    break;
            }

            textBoxEAX0000000BECX16_31_Reserved.Text = cpuHelper.GetEAX0000000BECX16_31_ReservedX(subLeafIndex);

            textBoxEAX0000000BEDX0_31_X2APICIDAlwaysValidDoesNotVaryWithSubLeafIndex.Text = cpuHelper.GetEAX0000000BEDX0_31_X2APICIDAlwaysValidDoesNotVaryWithSubLeafIndexX(subLeafIndex);

            #endregion
        }
    }
}
