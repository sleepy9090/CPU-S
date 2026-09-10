using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CPU_S
{
    public partial class Custom : Form
    {

        private CPUHelper cpuHelper;

        public Custom()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            comboBoxLeaf.Items.Clear();
            string[] standardLeaves = {
                "0x00000000", "0x00000001", "0x00000002", "0x00000003", "0x00000004", "0x00000005", "0x00000006", "0x00000007", "0x00000008", "0x00000009", "0x0000000A", "0x0000000B", "0x0000000C", "0x0000000D", "0x0000000E", "0x0000000F",
                "0x00000010", "0x00000011", "0x00000012", "0x00000013", "0x00000014", "0x00000015", "0x00000016", "0x00000017", "0x00000018", "0x00000019", "0x0000001A", "0x0000001B", "0x0000001C", "0x0000001D", "0x0000001E", "0x0000001F",
                "0x00000020", "0x00000021", "0x00000022", "0x00000023", "0x00000024", "0x00000025", "0x00000026", "0x00000027", "0x00000028", "0x00000029", "0x0000002A", "0x0000002B", "0x0000002C", "0x0000002D", "0x0000002E", "0x0000002F",
                "0x00000030", "0x00000031", "0x00000032", "0x00000033", "0x00000034", "0x00000035", "0x00000036", "0x00000037"
            };

            string[] optionalLeaves = {
                "0x20000000", "0x20000001", "0x20000002", "0x20000003", "0x20000004", "0x20000005", "0x20000006", "0x20000007"
            };

            string[] hypervisorLeavesMS = {
                "0x40000000", "0x40000001", "0x40000002", "0x40000003", "0x40000004", "0x40000005", "0x40000006", "0x40000007", "0x40000008", "0x40000009", "0x4000000A", "0x4000000B", "0x4000000C", "0x4000000D", "0x4000000E", "0x4000000F",
                "0x40000080", "0x40000081", "0x40000082", "0x40000083", "0x40000084", "0x40000085", "0x40000086", "0x40000087"
            };

            string[] hypervisorLeavesVM = {
                "0x40000010", "0x40000011", "0x40000012", "0x40000013", "0x40000014", "0x40000015", "0x40000016", "0x40000017"
            };

            comboBoxLeaf.Items.AddRange(standardLeaves);

        }
    }
}
