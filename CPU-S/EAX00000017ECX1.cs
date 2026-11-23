/*
    File           EAX00000017ECX1.cs
    Brief          Form for displaying EAX=0x00000017, ECX=0x00000001 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           11/23/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX00000017ECX1 : Form
    {
        private CPUHelper cpuHelper;

        public EAX00000017ECX1()
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

            #region EAX=0x00000017, ECX=0x00000001: SoC Vendor Attribute Enumeration - (output 1 of 3)

            textBoxEAX00000017EAX.Text = cpuHelper.GetEAX00000017ECX1EAXX();
            textBoxEAX00000017EBX.Text = cpuHelper.GetEAX00000017ECX1EBXX();
            textBoxEAX00000017ECX.Text = cpuHelper.GetEAX00000017ECX1ECXX();
            textBoxEAX00000017EDX.Text = cpuHelper.GetEAX00000017ECX1EDXX();

            textBoxEAXUTF8EncodedVendorBrandStringPart1.Text = cpuHelper.GetEAX00000017ECX1EAX0_31_UTF8EncodedVendorBrandStringPart1X();
            textBoxEBXUTF8EncodedVendorBrandStringPart2.Text = cpuHelper.GetEAX00000017ECX1EBX0_31_UTF8EncodedVendorBrandStringPart2X();
            textBoxECXUTF8EncodedVendorBrandStringPart3.Text = cpuHelper.GetEAX00000017ECX1ECX0_31_UTF8EncodedVendorBrandStringPart3X();
            textBoxEDXUTF8EncodedVendorBrandStringPart4.Text = cpuHelper.GetEAX00000017ECX1EDX0_31_UTF8EncodedVendorBrandStringPart4X();

            #endregion
        }
    }
}
