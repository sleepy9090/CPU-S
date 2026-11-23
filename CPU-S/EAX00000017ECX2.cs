/*
    File           EAX00000017ECX2.cs
    Brief          Form for displaying EAX=0x00000017, ECX=0x00000002 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           11/23/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX00000017ECX2 : Form
    {
        private CPUHelper cpuHelper;

        public EAX00000017ECX2()
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

            #region EAX=0x00000017, ECX=0x00000002: SoC Vendor Attribute Enumeration - (output 2 of 3)

            textBoxEAX00000017EAX.Text = cpuHelper.GetEAX00000017ECX2EAXX();
            textBoxEAX00000017EBX.Text = cpuHelper.GetEAX00000017ECX2EBXX();
            textBoxEAX00000017ECX.Text = cpuHelper.GetEAX00000017ECX2ECXX();
            textBoxEAX00000017EDX.Text = cpuHelper.GetEAX00000017ECX2EDXX();

            textBoxEAXUTF8EncodedVendorBrandStringPart5.Text = cpuHelper.GetEAX00000017ECX2EAX0_31_UTF8EncodedVendorBrandStringPart5X();
            textBoxEBXUTF8EncodedVendorBrandStringPart6.Text = cpuHelper.GetEAX00000017ECX2EBX0_31_UTF8EncodedVendorBrandStringPart6X();
            textBoxECXUTF8EncodedVendorBrandStringPart7.Text = cpuHelper.GetEAX00000017ECX2ECX0_31_UTF8EncodedVendorBrandStringPart7X();
            textBoxEDXUTF8EncodedVendorBrandStringPart8.Text = cpuHelper.GetEAX00000017ECX2EDX0_31_UTF8EncodedVendorBrandStringPart8X();

            #endregion
        }
    }
}
