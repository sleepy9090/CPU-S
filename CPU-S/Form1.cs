using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPU_S
{
    public partial class FormCPUS : Form
    {
        public FormCPUS()
        {
            InitializeComponent();
            GetCPUInfo();
            PopulateCPUInfo();
        }

        private void GetCPUInfo()
        {
            ManagementObject cpu = new ManagementObjectSearcher("SELECT * FROM Win32_Processor")
                                   .Get()
                                   .Cast<ManagementObject>()
                                   .First();

            CPU.ProcessorId = (string)cpu["ProcessorId"];
            CPU.SocketDesignation = (string)cpu["SocketDesignation"];
            CPU.Name = (string)cpu["Name"];
            CPU.Description = (string)cpu["Description"];
            CPU.AddressWidth = (ushort)cpu["AddressWidth"];
            CPU.DataWidth = (ushort)cpu["DataWidth"];
            CPU.Architecture = (ushort)cpu["Architecture"];
            CPU.MaxClockSpeed = (uint)cpu["MaxClockSpeed"];
            CPU.ExtClock = (uint)cpu["ExtClock"];
            CPU.L2CacheSize = (uint)cpu["L2CacheSize"] * (ulong)1024;
            CPU.L3CacheSize = (uint)cpu["L3CacheSize"] * (ulong)1024;
            CPU.NumberOfCores = (uint)cpu["NumberOfCores"];
            CPU.NumberOfLogicalProcessors = (uint)cpu["NumberOfLogicalProcessors"];
        }

        private void PopulateCPUInfo()
        {
            textBoxCPUProcessorId.Text = CPU.ProcessorId;
            textBoxCPUSocketDesignation.Text = CPU.SocketDesignation;
            textBoxCPUName.Text = CPU.Name;
            textBoxCPUDescription.Text = CPU.Description;
            textBoxCPUAddressWidth.Text = CPU.AddressWidth.ToString();
            textBoxCPUDataWidth.Text = CPU.DataWidth.ToString();
            textBoxCPUArchitecture.Text = CPU.Architecture.ToString();
            textBoxCPUMaxClockSpeed.Text = CPU.MaxClockSpeed.ToString();
            textBoxCPUExtClock.Text = CPU.ExtClock.ToString();
            textBoxCPUL2CacheSize.Text = CPU.L2CacheSize.ToString();
            textBoxCPUL3CacheSize.Text = CPU.L3CacheSize.ToString();
            textBoxCPUNumberOfCores.Text = CPU.NumberOfCores.ToString();
            textBoxCPUNumberOfLogicalProcessors.Text = CPU.NumberOfLogicalProcessors.ToString();
        }
    }
}
