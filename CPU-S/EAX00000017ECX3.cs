/*
    File           EAX00000017ECX3.cs
    Brief          Form for displaying EAX=0x00000017, ECX=0x00000003 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           11/23/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX00000017ECX3 : Form
    {
        private CPUHelper cpuHelper;

        public EAX00000017ECX3()
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

            #region EAX=0x00000017, ECX=0x00000003: SoC Vendor Attribute Enumeration - (output 3 of 3)

            textBoxEAX00000017EAX.Text = cpuHelper.GetEAX00000017ECX3EAXX();
            textBoxEAX00000017EBX.Text = cpuHelper.GetEAX00000017ECX3EBXX();
            textBoxEAX00000017ECX.Text = cpuHelper.GetEAX00000017ECX3ECXX();
            textBoxEAX00000017EDX.Text = cpuHelper.GetEAX00000017ECX3EDXX();

            textBoxEAXUTF8EncodedVendorBrandStringPart9.Text = cpuHelper.GetEAX00000017ECX3EAX0_31_UTF8EncodedVendorBrandStringPart9X();
            textBoxEBXUTF8EncodedVendorBrandStringPart10.Text = cpuHelper.GetEAX00000017ECX3EBX0_31_UTF8EncodedVendorBrandStringPart10X();
            textBoxECXUTF8EncodedVendorBrandStringPart11.Text = cpuHelper.GetEAX00000017ECX3ECX0_31_UTF8EncodedVendorBrandStringPart11X();
            textBoxEDXUTF8EncodedVendorBrandStringPart12.Text = cpuHelper.GetEAX00000017ECX3EDX0_31_UTF8EncodedVendorBrandStringPart12X();

            #endregion
        }
    }
}
