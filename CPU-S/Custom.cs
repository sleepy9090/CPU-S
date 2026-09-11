/*
    File           Custom.cs
    Brief          Form for displaying custom CPU information.
    Copyright      2026 Shawn M. Crawford [sleepy]
    Date           09/10/2026
    Author         Shawn M. Crawford [sleepy]
*/
using System;
using System.Windows.Forms;

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

            string[] supervisorLeavesLinux = {
                "0x4C780010", "0x4C780011", "0x4C780012", "0x4C780013", "0x4C780014", "0x4C780015", "0x4C780016", "0x4C780017"
            };

            string[] extendedLeaves = {
                "0x80000000", "0x80000001", "0x80000002", "0x80000003", "0x80000004", "0x80000005", "0x80000006", "0x80000007", "0x80000008", "0x80000009", "0x8000000A", "0x8000000B", "0x8000000C", "0x8000000D", "0x8000000E", "0x8000000F",
                "0x80000010", "0x80000011", "0x80000012", "0x80000013", "0x80000014", "0x80000015", "0x80000016", "0x80000017", "0x80000018", "0x80000019", "0x8000001A", "0x8000001B", "0x8000001C", "0x8000001D", "0x8000001E", "0x8000001F",
                "0x80000020", "0x80000021", "0x80000022", "0x80000023", "0x80000024", "0x80000025", "0x80000026", "0x80000027", "0x80000028", "0x80000029", "0x8000002A", "0x8000002B", "0x8000002C", "0x8000002D", "0x8000002E", "0x8000002F"
            };

            string[] vendorLeavesTransmeta = {
                "0x80860000", "0x80860001", "0x80860002", "0x80860003", "0x80860004", "0x80860005", "0x80860006", "0x80860007", "0x80860008", "0x80860009", "0x8086000A", "0x8086000B", "0x8086000C", "0x8086000D", "0x8086000E", "0x8086000F",
                "0x80860010", "0x80860011", "0x80860012", "0x80860013", "0x80860014", "0x80860015", "0x80860016", "0x80860017", "0x80860018", "0x80860019", "0x8086001A", "0x8086001B", "0x8086001C", "0x8086001D", "0x8086001E", "0x8086001F"
            };

            string[] vendorLeavesHygon = {
                "0x8C860000", "0x8C860001", "0x8C860002", "0x8C860003", "0x8C860004", "0x8C860005", "0x8C860006", "0x8C860007"
            };

            string[] vendorLeavesCentaurAndZhaoxin = {
                "0xC0000000", "0xC0000001", "0xC0000002", "0xC0000003", "0xC0000004", "0xC0000005", "0xC0000006", "0xC0000007"
            };

            string[] vendorLeavesOther = {
                "0xE0000000", "0xE0000001", "0xE0000002", "0xE0000003", "0xE0000004", "0xE0000005", "0xE0000006", "0xE0000007"
            };

            string[] prankLeavesAMD = {
                "0x8FFFFFF8", "0x8FFFFFF9", "0x8FFFFFFA", "0x8FFFFFFB", "0x8FFFFFFC", "0x8FFFFFFD", "0x8FFFFFFE", "0x8FFFFFFF"
            };

            string[] prankLeavesRiseMp6 = {
                "0x00005A48", "0x00005A49", "0x00005A4A", "0x00005A4B", "0x00005A4C", "0x00005A4D", "0x00005A4E", "0x00005A4F"
            };

            // TODO: Break out.
            comboBoxLeaf.Items.AddRange(standardLeaves);
            comboBoxLeaf.Items.AddRange(optionalLeaves);
            comboBoxLeaf.Items.AddRange(extendedLeaves);
            comboBoxLeaf.Items.AddRange(vendorLeavesTransmeta);
            comboBoxLeaf.Items.AddRange(vendorLeavesHygon);
            comboBoxLeaf.Items.AddRange(vendorLeavesCentaurAndZhaoxin);
            comboBoxLeaf.Items.AddRange(vendorLeavesOther);
            comboBoxLeaf.Items.AddRange(prankLeavesAMD);
            comboBoxLeaf.Items.AddRange(prankLeavesRiseMp6);
            comboBoxLeaf.SelectedIndex = 0;

            comboBoxSubleaf.Items.Clear();

            // 23h as of April 2024
            string[] subleaf = {
                "0x0", "0x1", "0x2", "0x3", "0x4", "0x5", "0x6", "0x7", "0x8", "0x9", "0xA", "0xB", "0xC", "0xD", "0xE", "0xF",
                "0x10", "0x11", "0x12", "0x13", "0x14", "0x15", "0x16", "0x17", "0x18", "0x19", "0x1A", "0x1B", "0x1C", "0x1D", "0x1E", "0x1F",
                "0x20", "0x21", "0x22", "0x23"
            };

            comboBoxSubleaf.Items.AddRange(subleaf);
            comboBoxSubleaf.SelectedIndex = 0;
            
            comboBoxRegisterIndex.Items.Clear();
            comboBoxRegisterIndex.Items.Insert(0, "EAX");
            comboBoxRegisterIndex.Items.Insert(1, "EBX");
            comboBoxRegisterIndex.Items.Insert(2, "ECX");
            comboBoxRegisterIndex.Items.Insert(3, "EDX");
            comboBoxRegisterIndex.SelectedIndex = 0;

        }

        private void buttonQuery_Click(object sender, System.EventArgs e)
        {
            textBoxResult.Clear();
            cpuHelper = new CPUHelper();
            uint leaf = 0;
            uint subleaf = 0;
            uint registerIndex = 0;
            bool isInvalidInput = false;

            if (checkBoxOverrideLeaf.Checked)
            {
                try
                {
                    leaf = Convert.ToUInt32(textBoxOverrideLeaf.Text, 16);
                }
                catch
                {
                    MessageBox.Show("Invalid leaf value. Please enter a valid hexadecimal number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isInvalidInput = true;
                }
            }
            else
            {
                leaf = Convert.ToUInt32(comboBoxLeaf.SelectedItem.ToString(), 16);
            }

            if (!isInvalidInput)
            {
                if (checkBoxOverrideSubleaf.Checked)
                {
                    try
                    {
                        subleaf = Convert.ToUInt32(textBoxOverrideSubleaf.Text, 16);
                    }
                    catch
                    {
                        MessageBox.Show("Invalid subleaf value. Please enter a valid hexadecimal number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isInvalidInput = true;
                    }
                }
                else
                {
                    subleaf = Convert.ToUInt32(comboBoxSubleaf.SelectedItem.ToString(), 16);
                }
            }

            if (!isInvalidInput)
            {
                if (checkBoxOverrideRegisterIndex.Checked)
                {
                    try
                    {
                        registerIndex = Convert.ToUInt32(textBoxOverrideRegisterIndex.Text, 16);
                    }
                    catch
                    {
                        MessageBox.Show("Invalid register index value. Please enter a valid hexadecimal number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        isInvalidInput = true;
                    }
                }
                else
                {
                    registerIndex = (uint)comboBoxRegisterIndex.SelectedIndex;
                }
            }

            if (!isInvalidInput)
            {
                string registerValue = cpuHelper.GetCustomX(leaf, subleaf, registerIndex);
                textBoxResult.Text = registerValue;
            }
            
        }
    }
}
