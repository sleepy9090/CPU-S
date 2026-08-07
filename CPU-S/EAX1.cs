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
    public partial class EAX1 : Form
    {

        private CPUHelper cpuHelper;

        public EAX1()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region

            string cpuIdEAX1EAX = cpuHelper.GetEAX1EAXX();
            textBoxEAX1EAX.Text = cpuIdEAX1EAX;

            string cpuIdEAX1EBX = cpuHelper.GetEAX1EBXX();
            textBoxEAX1EBX.Text = cpuIdEAX1EBX;

            string cpuIdEAX1ECX = cpuHelper.GetEAX1ECXX();
            textBoxEAX1ECX.Text = cpuIdEAX1ECX;

            string cpuIdEAX1EDX = cpuHelper.GetEAX1EDXX();
            textBoxEAX1EDX.Text = cpuIdEAX1EDX;

            string cpuIdEAX1EAX0_3_SteppingId = cpuHelper.GetEAX1EAX0_3_SteppingIdX();
            textBoxEAX1EAX0_3_SteppingId.Text = cpuIdEAX1EAX0_3_SteppingId;

            string cpuIdEAX1EAX4_7_ModelId = cpuHelper.GetEAX1EAX4_7_ModelIdX();
            textBoxEAX1EAX4_7_ModelId.Text = cpuIdEAX1EAX4_7_ModelId;

            string cpuIdEAX1EAX8_11_FamilyId = cpuHelper.GetEAX1EAX8_11_FamilyIdX();
            textBoxEAX1EAX8_11_FamilyId.Text = cpuIdEAX1EAX8_11_FamilyId;

            string cpuIdEAX1EAX12_13_ProcessorType = cpuHelper.GetEAX1EAX12_13_ProcessorTypeX();
            textBoxEAX1EAX12_13_ProcessorType.Text = cpuIdEAX1EAX12_13_ProcessorType;

            string cpuIdEAX1EAX14_15_Reserved = cpuHelper.GetEAX1EAX14_15_ReservedX();
            textBoxEAX1EAX14_15_Reserved.Text = cpuIdEAX1EAX14_15_Reserved;

            string cpuIdEAX1EAX16_19_ExtendedModelId = cpuHelper.GetEAX1EAX16_19_ExtendedModelIdX();
            textBoxEAX1EAX16_19_ExtendedModelId.Text = cpuIdEAX1EAX16_19_ExtendedModelId;

            string cpuIdEAX1EAX16_19_ExtendedModelIdLeftShifted = cpuHelper.GetEAX1EAX16_19_ExtendedModelIdLeftShiftedX();
            textBoxEAX1EAX16_19_ExtendedModelIdLeftShifted.Text = cpuIdEAX1EAX16_19_ExtendedModelIdLeftShifted;

            string cpuIdEAX1EAX_CalculatedProcessorModel = (int.Parse(cpuIdEAX1EAX4_7_ModelId) + int.Parse(cpuIdEAX1EAX16_19_ExtendedModelIdLeftShifted)).ToString();
            textBoxEAX1EAX_CalculatedProcessorModel.Text = cpuIdEAX1EAX_CalculatedProcessorModel;

            string cpuIdEAX1EAX20_27_ExtendedFamilyId = cpuHelper.GetEAX1EAX20_27_ExtendedFamilyIdX();
            textBoxEAX1EAX20_27_ExtendedFamilyId.Text = cpuIdEAX1EAX20_27_ExtendedFamilyId;

            string cpuIdEAX1EAX28_31_Reserved = cpuHelper.GetEAX1EAX28_31_ReservedX();
            textBoxEAX1EAX28_31_Reserved.Text = cpuIdEAX1EAX28_31_Reserved;

            string cpuIdEAX1EBX0_7_BrandIndex = cpuHelper.GetEAX1EBX0_7_BrandIndexX();
            textBoxEAX1EBX0_7_BrandIndex.Text = cpuIdEAX1EBX0_7_BrandIndex;

            #endregion
        }
    }
}
