/*
    File           EAX00000017.cs
    Brief          Form for displaying EAX=0x00000017 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           11/23/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX00000017 : Form
    {

        private CPUHelper cpuHelper;

        public EAX00000017()
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

            #region EAX=0x00000017, ECX=0x00000000: SoC Vendor Attribute Enumeration - (main)

            textBoxEAX00000017EAX.Text = cpuHelper.GetEAX00000017EAXX();
            textBoxEAX00000017EBX.Text = cpuHelper.GetEAX00000017EBXX();
            textBoxEAX00000017ECX.Text = cpuHelper.GetEAX00000017ECXX();
            textBoxEAX00000017EDX.Text = cpuHelper.GetEAX00000017EDXX();

            textBoxEAXMaxSubleaf.Text = cpuHelper.GetEAX00000017EAX0_31_MaxSubleafX();

            textBoxEBX0_15_VendorID.Text = cpuHelper.GetEAX00000017EBX0_15_VendorIdX();
            checkBoxVendorIDUsesIndustryStandardEnumerationScheme.Checked = cpuHelper.GetEAX00000017EBX16_VendorIDUsesIndustryStandardEnumerationSchemeX();
            textBoxEBX17_31_Reserved.Text = cpuHelper.GetEAX00000017EBX17_31_ReservedX();

            textBoxECXProjectID.Text = cpuHelper.GetEAX00000017ECX0_31_ProjectIdX();

            textBoxEDXSteppingID.Text = cpuHelper.GetEAX00000017EDX0_31_SteppingIdX();

            #endregion
        }
    }
}
