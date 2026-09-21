/*
    File           EAX1D.cs
    Brief          Form for displaying EAX=0x1D CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           08/XX/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System.Windows.Forms;

namespace CPU_S
{
    public partial class EAX1D : Form
    {

        private CPUHelper cpuHelper;

        public EAX1D()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x1D: Intel AMX Tile Information

            string cpuIdEAX1DEAX = cpuHelper.GetEAX1DEAXX();
            textBoxEAX1DEAX.Text = cpuIdEAX1DEAX;

            string cpuIdEAX1DEBX = cpuHelper.GetEAX1DEBXX();
            textBoxEAX1DEBX.Text = cpuIdEAX1DEBX;

            string cpuIdEAX1DECX = cpuHelper.GetEAX1DECXX();
            textBoxEAX1DECX.Text = cpuIdEAX1DECX;

            string cpuIdEAX1DEDX = cpuHelper.GetEAX1DEDXX();
            textBoxEAX1DEDX.Text = cpuIdEAX1DEDX;

            string cpuIdEAX1DEAX0_15_TotalTileBytes = cpuHelper.GetEAX1DEAX0_15_TotalTileBytesX();
            textBoxTotalTileBytes.Text = cpuIdEAX1DEAX0_15_TotalTileBytes;

            string cpuIdEAX1DEAX16_31_BytesPerTile = cpuHelper.GetEAX1DEAX16_31_BytesPerTileX();
            textBoxBytesPerTile.Text = cpuIdEAX1DEAX16_31_BytesPerTile;

            string cpuIdEAX1DEAX0_15_BytesPerRow = cpuHelper.GetEAX1DEAX0_15_BytesPerRowX();
            textBoxBytesPerRow.Text = cpuIdEAX1DEAX0_15_BytesPerRow;

            string cpuIdEAX1DEAX16_31_MaxNames = cpuHelper.GetEAX1DEAX16_31_MaxNamesX();
            textBoxMaxNames.Text = cpuIdEAX1DEAX16_31_MaxNames;

            string cpuIdEAX1DEAX16_31_MaxRows = cpuHelper.GetEAX1DEAX0_15_MaxRowsX();
            textBoxMaxRows.Text = cpuIdEAX1DEAX16_31_MaxRows;

            #endregion
        }
    }
}
