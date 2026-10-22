/*
    File           EAX0000000D.cs
    Brief          Form for displaying EAX=0x0000000D, ECX=0x00000001 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           10/22/2026
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
    public partial class EAX0000000DECX1 : Form
    {

        private CPUHelper cpuHelper;

        public EAX0000000DECX1()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x0000000D: XSAVE Features and State Components (ECX=0x00000001), (Sub 1) (feat) (XSS)

            textBoxEAX0000000DEAX.Text = cpuHelper.GetEAX0000000DEAX_ECX1X();
            textBoxEAX0000000DEBX.Text = cpuHelper.GetEAX0000000DEBX_ECX1X();
            textBoxEAX0000000DECX.Text = cpuHelper.GetEAX0000000DECX_ECX1X();
            textBoxEAX0000000DEDX.Text = cpuHelper.GetEAX0000000DEDX_ECX1X();

            checkBoxXSAVEOPT.Checked = cpuHelper.GetEAX0000000D_ECX1_EAX0_XSAVEOPTX();
            checkBoxXSAVECAndCompactedFormOfXRSTOR.Checked = cpuHelper.GetEAX0000000D_ECX1_EAX1_XSAVECAndCompactedFormOfXRSTORX();
            checkBoxXGETBVWithECX1.Checked = cpuHelper.GetEAX0000000D_ECX1_EAX2_XGETBVWithECX1X();
            checkBoxXSAVES_XRSTORSAndXSS.Checked = cpuHelper.GetEAX0000000D_ECX1_EAX3_XSAVES_XRSTORSAndXSSX();
            checkBoxXFDAndXFD_ERR.Checked = cpuHelper.GetEAX0000000D_ECX1_EAX4_XFDAndXFD_ERRX();

            textBoxSizeInBytesInXSAVEAreaForXCR0_XSS.Text = cpuHelper.GetEAX0000000D_ECX1_EBX0_31_SizeInBytesInXSAVEAreaForXCR0_XSSX();

            textBox0_31_ValidXSSBits.Text = cpuHelper.GetEAX0000000D_ECX1_ECX0_31_ValidXSSBitsX();

            textBox32_63_ValidXSSBits.Text = cpuHelper.GetEAX0000000D_ECX1_EDX32_63_ValidXSSBitsX();

            #endregion
        }
    }
}
