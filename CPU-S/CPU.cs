using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_S
{
    internal class CPU
    {
        internal static ulong L3Cache;

        public CPU() 
        { 
        
        }

        public static string ID { get; internal set; }
        public static string Socket { get; internal set; }
        public static string Name { get; internal set; }
        public static string Description { get; internal set; }
        public static ushort AddressWidth { get; internal set; }
        public static ushort DataWidth { get; internal set; }
        public static ushort Architecture { get; internal set; }
        public static uint SpeedMHz { get; internal set; }
        public static uint BusSpeedMHz { get; internal set; }
        public static ulong L2Cache { get; internal set; }
        public static uint Cores { get; internal set; }
        public static uint Threads { get; internal set; }
    }
}
