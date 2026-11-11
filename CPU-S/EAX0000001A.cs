/*
    File           EAX0000001A.cs
    Brief          Form for displaying EAX=0x0000001A CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           11/09/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System;
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX0000001A : Form
    {
        private CPUHelper cpuHelper;

        public EAX0000001A()
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

            #region EAX=0x0000001A: Core Model Information

            textBoxEAX.Text = cpuHelper.GetEAX0000001AEAXX();
            textBoxEBX.Text = cpuHelper.GetEAX0000001AEBXX();
            textBoxECX.Text = cpuHelper.GetEAX0000001AECXX();
            textBoxEDX.Text = cpuHelper.GetEAX0000001AEDXX();

            string coreNativeModelId = cpuHelper.GetEAX0000001AEAX0_23_CoreNativeModelIdX();
            textBoxCoreNativeModelId.Text = coreNativeModelId;

            string coreType = cpuHelper.GetEAX0000001AEAX24_31_CoreTypeX();
            textBoxCoreType.Text = coreType;
            _ = int.TryParse(coreType, out int coreTypeInt) ? coreTypeInt : -1;
            _ = int.TryParse(coreNativeModelId, out int coreNativeModelIdInt) ? coreNativeModelIdInt : -1;
            // 10h=reserved, 20h=Atom, 30h=reserved, 40h=Core
            switch (coreTypeInt)
            {
                case 0x10:
                    textBoxCoreTypeDesc.Text = "Reserved";
                    textBoxCoreNativeModelIdDesc.Text = "Unknown";
                    break;
                case 0x20:
                    textBoxCoreTypeDesc.Text = "Atom";
                    // Atom 0=TNT, 1=GRM, 2=CRM, 3=SKM, 4=DKM, 5=ARW
                    switch (coreNativeModelIdInt)
                    {
                        case 0:
                            textBoxCoreNativeModelIdDesc.Text = "TNT";
                            break;
                        case 1:
                            textBoxCoreNativeModelIdDesc.Text = "GRM";
                            break;
                        case 2:
                            textBoxCoreNativeModelIdDesc.Text = "CRM";
                            break;
                        case 3:
                            textBoxCoreNativeModelIdDesc.Text = "SKM";
                            break;
                        case 4:
                            textBoxCoreNativeModelIdDesc.Text = "DKM";
                            break;
                        case 5:
                            textBoxCoreNativeModelIdDesc.Text = "ARW";
                            break;
                        default:
                            textBoxCoreNativeModelIdDesc.Text = "Unknown";
                            break;
                    }
                    break;
                case 0x30:
                    textBoxCoreTypeDesc.Text = "Reserved";
                    textBoxCoreNativeModelIdDesc.Text = "Unknown";
                    break;
                case 0x40:
                    textBoxCoreTypeDesc.Text = "Core";
                    // Core 0 = SNC, 1 = GLC, 2 = RWC, 3 = LNC, 4 = CGC, 5 = CYC
                    switch (coreNativeModelIdInt)
                    {
                        case 0:
                            textBoxCoreNativeModelIdDesc.Text = "SNC";
                            break;
                        case 1:
                            textBoxCoreNativeModelIdDesc.Text = "GLC";
                            break;
                        case 2:
                            textBoxCoreNativeModelIdDesc.Text = "RWC";
                            break;
                        case 3:
                            textBoxCoreNativeModelIdDesc.Text = "LNC";
                            break;
                        case 4:
                            textBoxCoreNativeModelIdDesc.Text = "CGC";
                            break;
                        case 5:
                            textBoxCoreNativeModelIdDesc.Text = "CYC";
                            break;
                        default:
                            textBoxCoreNativeModelIdDesc.Text = "Unknown";
                            break;
                    }
                    break;
                default:
                    textBoxCoreTypeDesc.Text = "Unknown";
                    textBoxCoreNativeModelIdDesc.Text = "Unknown";
                    break;
            }

            textBoxEBXReserved.Text = cpuHelper.GetEAX0000001AEBX0_31_ReservedX();

            textBoxECXReserved.Text = cpuHelper.GetEAX0000001AECX0_31_ReservedX();

            textBoxEDXReserved.Text = cpuHelper.GetEAX0000001AEDX0_31_ReservedX();

            #endregion
        }
    }
}
