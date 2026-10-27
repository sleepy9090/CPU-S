/*
    File           EAX0000000D.cs
    Brief          Form for displaying EAX=0x0000000D CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/21/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX0000000D : Form
    {

        private CPUHelper cpuHelper;

        public EAX0000000D()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x0000000D: XSAVE Features and State Components (ECX=0x00000000), (Sub 0) (main) (XCR0)

            textBoxEAX0000000DEAX.Text = cpuHelper.GetEAX0000000DEAXX();
            textBoxEAX0000000DEBX.Text = cpuHelper.GetEAX0000000DEBXX();
            textBoxEAX0000000DECX.Text = cpuHelper.GetEAX0000000DECXX();
            textBoxEAX0000000DEDX.Text = cpuHelper.GetEAX0000000DEDXX();

            textBoxValidXCR0Bits.Text = cpuHelper.GetEAX0000000DEAX0_31_ValidXCR0BitsX();

            textBoxCurrentSizeInBytesOfXSAVE_XRSTORAreaAsPerCurrentXCR0.Text = cpuHelper.GetEAX0000000DEBX0_31_CurrentSizeInBytesOfXSAVE_XRSTORAreaAsPerCurrentXCR0X();

            textBoxMaxSizeInBytesOfXSAVE_XRSTORAreaInclXSAVEHEADER.Text = cpuHelper.GetEAX0000000DECX0_31_MaxSizeInBytesOfXSAVE_XRSTORAreaInclXSAVEHEADERX();

            textBoxValidXCR0Bits63_32Bits.Text = cpuHelper.GetEAX0000000DEDX0_31_ValidXCR0Bits63_32BitsX();

            #endregion
        }
    }
}
