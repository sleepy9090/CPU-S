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
    public partial class Form1 : Form
    {
        public Form1()
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

            CPU.ID = (string)cpu["ProcessorId"];
            CPU.Socket = (string)cpu["SocketDesignation"];
            CPU.Name = (string)cpu["Name"];
            CPU.Description = (string)cpu["Caption"];
            CPU.AddressWidth = (ushort)cpu["AddressWidth"];
            CPU.DataWidth = (ushort)cpu["DataWidth"];
            CPU.Architecture = (ushort)cpu["Architecture"];
            CPU.SpeedMHz = (uint)cpu["MaxClockSpeed"];
            CPU.BusSpeedMHz = (uint)cpu["ExtClock"];
            CPU.L2Cache = (uint)cpu["L2CacheSize"] * (ulong)1024;
            CPU.L3Cache = (uint)cpu["L3CacheSize"] * (ulong)1024;
            CPU.Cores = (uint)cpu["NumberOfCores"];
            CPU.Threads = (uint)cpu["NumberOfLogicalProcessors"];
        }

        private void PopulateCPUInfo()
        {
            textBoxCPUId.Text = CPU.ID;
            textBoxCPUSocket.Text = CPU.Socket;
            textBoxCPUName.Text = CPU.Name;
            textBoxCPUDescription.Text = CPU.Description;
            textBoxCPUAddressWidth.Text = CPU.AddressWidth.ToString();
            textBoxCPUDataWidth.Text = CPU.DataWidth.ToString();
            textBoxCPUArchitecture.Text = CPU.Architecture.ToString();
            textBoxCPUSpeedMHz.Text = CPU.SpeedMHz.ToString();
            textBoxCPUBusSpeedMHz.Text = CPU.BusSpeedMHz.ToString();
            textBoxCPUL2Cache.Text = CPU.L2Cache.ToString();
            textBoxCPUL3Cache.Text = CPU.L3Cache.ToString();
            textBoxCPUCores.Text = CPU.Cores.ToString();
            textBoxCPUThreads.Text = CPU.Threads.ToString();
        }
    }
}
