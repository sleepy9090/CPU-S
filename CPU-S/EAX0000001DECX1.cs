/*
    File           EAX0000001DECX1.cs
    Brief          Form for displaying EAX=0x0000001D ECX=0x00000001 CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           11/19/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX0000001DECX1 : Form
    {

        private CPUHelper cpuHelper;

        public EAX0000001DECX1()
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

            #region EAX=0x1D: Intel AMX Tile Information

            textBoxEAX1DEAX.Text = cpuHelper.GetEAX0000001DECX1EAXX();
            textBoxEAX1DEBX.Text = cpuHelper.GetEAX0000001DECX1EBXX();
            textBoxEAX1DECX.Text = cpuHelper.GetEAX0000001DECX1ECXX();
            textBoxEAX1DEDX.Text = cpuHelper.GetEAX0000001DECX1EDXX();

            textBoxTotalTileBytes.Text = cpuHelper.GetEAX0000001DECX1EAX0_15_TotalTileBytesX();
            textBoxBytesPerTile.Text = cpuHelper.GetEAX0000001DECX1EAX16_31_BytesPerTileX();
            textBoxBytesPerRow.Text = cpuHelper.GetEAX0000001DECX1EBX0_15_BytesPerRowX();
            textBoxMaxNames.Text = cpuHelper.GetEAX0000001DECX1EBX16_31_MaxNamesX();
            textBoxMaxRows.Text = cpuHelper.GetEAX0000001DECX1ECX0_15_MaxRowsX();
            textBoxECX16_31_Reserved.Text = cpuHelper.GetEAX0000001DECX1ECX16_31_ReservedX();
            textBoxEDXReserved.Text = cpuHelper.GetEAX0000001DECX1EDX0_31_ReservedX();

            #endregion
        }
    }
}
