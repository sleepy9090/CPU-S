/*
    File           EAX0000000D.cs
    Brief          Form for displaying EAX=0x0000000D, ECX=0x0000000N CPU information.
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
    public partial class EAX0000000DECXN : Form
    {

        private CPUHelper cpuHelper;
        private int currentSubLeafIndex;

        public EAX0000000DECXN(int subLeafIndex)
        {
            InitializeComponent();
            currentSubLeafIndex = subLeafIndex;
            textBoxCurrentN.Text = subLeafIndex.ToString();

            cpuHelper = new CPUHelper();

            #region EAX=0x0000000D: XSAVE Features and State Components (ECX=2 to 62), (Sub n) (2 to 62) (comp)

            textBoxEAX0000000DEAX.Text = cpuHelper.GetEAX0000000DEAX_ECXNX(subLeafIndex);
            textBoxEAX0000000DEBX.Text = cpuHelper.GetEAX0000000DEBX_ECXNX(subLeafIndex);
            textBoxEAX0000000DECX.Text = cpuHelper.GetEAX0000000DECX_ECXNX(subLeafIndex);
            textBoxEAX0000000DEDX.Text = cpuHelper.GetEAX0000000DEDX_ECXNX(subLeafIndex);

            textBoxSizeInBytesInXSAVE_SRSTORAreaForXCR0N.Text = cpuHelper.GetEAX0000000DEDX_ECXN_SizeInBytesInXSAVE_SRSTORAreaForXCR0NX(subLeafIndex);

            textBoxOffsetInBytesInXSAVE_SRSTORAreaForXCR0N.Text = cpuHelper.GetEAX0000000DEDX_ECXN_OffsetInBytesInXSAVE_SRSTORAreaForXCR0NX(subLeafIndex);

            checkBoxZeroIfComponentIsValidInXCR0.Checked = !cpuHelper.GetEAX0000000DEDX_ECXN_ECX0_ZeroIfComponentIsValidInXCR0_OneIfComponentIsValidInXSSX(subLeafIndex);
            checkBoxOneIfComponentIsValidInXSS.Checked = cpuHelper.GetEAX0000000DEDX_ECXN_ECX0_ZeroIfComponentIsValidInXCR0_OneIfComponentIsValidInXSSX(subLeafIndex);
            checkBoxZeroIfComponentImmediatelyFollowsPreviousComponent.Checked = !cpuHelper.GetEAX0000000DEDX_ECXN_ECX1_ZeroIfComponentImmediatelyFollowsPreviousComponent_OneIfComponentIsAlignedToNext64ByteBoundaryX(subLeafIndex);
            checkBoxOneIfComponentIsAlignedToNext64ByteBoundary.Checked = cpuHelper.GetEAX0000000DEDX_ECXN_ECX1_ZeroIfComponentImmediatelyFollowsPreviousComponent_OneIfComponentIsAlignedToNext64ByteBoundaryX(subLeafIndex);
            checkBoxXFDAndXFD_ERR.Checked = cpuHelper.GetEAX0000000A_ECXN_ECX2_XFDAndXFD_ERRX(subLeafIndex);

            #endregion

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            currentSubLeafIndex++;
            // output (sub n) (2..62) (comp)
            if (currentSubLeafIndex < 63)
            {
                EAX0000000DECXN nextForm = new EAX0000000DECXN(currentSubLeafIndex);
                nextForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No more sub-leaves available.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
