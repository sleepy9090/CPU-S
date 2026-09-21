/*
    File           EAX1E.cs
    Brief          Form for displaying EAX=0x1E CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX1E : Form
    {

        private CPUHelper cpuHelper;

        public EAX1E()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x1E: Intel AMX Tile Multiplier (TMUL) Information

            string cpuIdEAX1EEAX = cpuHelper.GetEAX1EEAXX();
            textBoxEAX1EAX.Text = cpuIdEAX1EEAX;

            string cpuIdEAX1EEBX = cpuHelper.GetEAX1EEBXX();
            textBoxEAX1EBX.Text = cpuIdEAX1EEBX;

            string cpuIdEAX1EECX = cpuHelper.GetEAX1EECXX();
            textBoxEAX1ECX.Text = cpuIdEAX1EECX;

            string cpuIdEAX1EEDX = cpuHelper.GetEAX1EEDXX();
            textBoxEAX1EDX.Text = cpuIdEAX1EEDX;

            string cpuIdEAX1EEAX0_7_MaxNumRowsOrCols = cpuHelper.GetEAX1EEAX0_7_MaxNumRowsOrColsX();
            textBoxTmulMaxk.Text = cpuIdEAX1EEAX0_7_MaxNumRowsOrCols;

            string cpuIdEAX1EEAX8_23_MaxNumBytesPerCol = cpuHelper.GetEAX1EEAX8_23_MaxNumBytesPerColX();
            textBoxTmulMaxn.Text = cpuIdEAX1EEAX8_23_MaxNumBytesPerCol;

            bool cpuIdEAX1EECX1_EAX0_AMXINT8IsSupported = cpuHelper.GetEAX1EECX1_EAX0_AMXINT8IsSupportedX();
            checkBoxAmxInt8.Checked = cpuIdEAX1EECX1_EAX0_AMXINT8IsSupported;

            bool cpuIdEAX1EECX1_EAX0_AMXBF16IsSupported = cpuHelper.GetEAX1EECX1_EAX0_AMXBF16IsSupportedX();
            checkBoxAmxBf16.Checked = cpuIdEAX1EECX1_EAX0_AMXBF16IsSupported;

            bool cpuIdEAX1EECX1_EAX0_AMXComplexIsSupported = cpuHelper.GetEAX1EECX1_EAX0_AMXComplexIsSupportedX();
            checkBoxAmxComplex.Checked = cpuIdEAX1EECX1_EAX0_AMXComplexIsSupported;

            bool cpuIdEAX1EECX1_EAX0_AMXFP16IsSupported = cpuHelper.GetEAX1EECX1_EAX0_AMXFP16IsSupportedX();
            checkBoxAmxFp16.Checked = cpuIdEAX1EECX1_EAX0_AMXFP16IsSupported;

            bool cpuIdEAX1EECX1_EAX0_AMXFP8IsSupported = cpuHelper.GetEAX1EECX1_EAX0_AMXFP8IsSupportedX();
            checkBoxAmxFp8.Checked = cpuIdEAX1EECX1_EAX0_AMXFP8IsSupported;

            bool cpuIdEAX1EECX1_EAX0_AMXTransposeIsSupported = cpuHelper.GetEAX1EECX1_EAX0_AMXTransposeIsSupportedX();
            checkBoxAmxTranspose.Checked = cpuIdEAX1EECX1_EAX0_AMXTransposeIsSupported;

            bool cpuIdEAX1EECX1_EAX0_AMXTF32IsSupported = cpuHelper.GetEAX1EECX1_EAX0_AMXTF32IsSupportedX();
            checkBoxAmxTf32.Checked = cpuIdEAX1EECX1_EAX0_AMXTF32IsSupported;

            bool cpuIdEAX1EECX1_EAX0_AMXAVX512IsSupported = cpuHelper.GetEAX1EECX1_EAX0_AMXAVX512IsSupportedX();
            checkBoxAmxAvx512.Checked = cpuIdEAX1EECX1_EAX0_AMXAVX512IsSupported;

            bool cpuIdEAX1EECX1_EAX0_AMXMOVRSIsSupported = cpuHelper.GetEAX1EECX1_EAX0_AMXMOVRSIsSupportedX();
            checkBoxAmxMovrs.Checked = cpuIdEAX1EECX1_EAX0_AMXMOVRSIsSupported;

            #endregion
        }
    }
}
