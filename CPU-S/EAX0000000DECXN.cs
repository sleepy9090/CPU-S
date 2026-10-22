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

        public EAX0000000DECXN(int subLeafIndex)
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x0000000D: XSAVE Features and State Components (ECX=2 to 62), (Sub n) (2 to 62) (comp)

            textBoxEAX0000000DEAX.Text = cpuHelper.GetEAX0000000DEAX_ECXNX(subLeafIndex);
            textBoxEAX0000000DEBX.Text = cpuHelper.GetEAX0000000DEBX_ECXNX(subLeafIndex);
            textBoxEAX0000000DECX.Text = cpuHelper.GetEAX0000000DECX_ECXNX(subLeafIndex);
            textBoxEAX0000000DEDX.Text = cpuHelper.GetEAX0000000DEDX_ECXNX(subLeafIndex);

            #endregion

        }
    }
}
