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

            textBoxEAX1DEAX.Text = cpuHelper.GetEAX1DEAXX();
            textBoxEAX1DEBX.Text = cpuHelper.GetEAX1DEBXX();
            textBoxEAX1DECX.Text = cpuHelper.GetEAX1DECXX();
            textBoxEAX1DEDX.Text = cpuHelper.GetEAX1DEDXX();

            //textBoxTotalTileBytes.Text = cpuHelper.GetEAX1DEAX0_15_TotalTileBytesX();
            //textBoxBytesPerTile.Text = cpuHelper.GetEAX1DEAX16_31_BytesPerTileX();
            //textBoxBytesPerRow.Text = cpuHelper.GetEAX1DEAX0_15_BytesPerRowX();
            //textBoxMaxNames.Text = cpuHelper.GetEAX1DEAX16_31_MaxNamesX();
            //textBoxMaxRows.Text = cpuHelper.GetEAX1DEAX0_15_MaxRowsX();

            #endregion
        }
    }
}
