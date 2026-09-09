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
    public partial class EAX80000006_AMD : Form
    {

        private CPUHelper cpuHelper;

        public EAX80000006_AMD()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x80000006: Extended L2 Cache Features (AMD)

            string cpuIdEAX80000006EAX = cpuHelper.GetEAX80000006EAXX();
            textBoxEAX80000006EAX.Text = cpuIdEAX80000006EAX;

            string cpuIdEAX80000006EBX = cpuHelper.GetEAX80000006EBXX();
            textBoxEAX80000006EBX.Text = cpuIdEAX80000006EBX;

            string cpuIdEAX80000006ECX = cpuHelper.GetEAX80000006ECXX();
            textBoxEAX80000006ECX.Text = cpuIdEAX80000006ECX;

            string cpuIdEAX80000006EDX = cpuHelper.GetEAX80000006EDXX();
            textBoxEAX80000006EDX.Text = cpuIdEAX80000006EDX;



            /*
            int cpuIdEAX80000006ECX_AssociativityValue = int.TryParse(cpuIdEAX80000006ECX_Associativity, out int associativityValue) ? associativityValue : -1;

            switch (cpuIdEAX80000006ECX_AssociativityValue)
            {
                case 0x0:
                    textBoxAssociativityTypeHuman.Text = "Disabled";
                    break;
                case 0x1:
                    textBoxAssociativityTypeHuman.Text = "Direct mapped";
                    break;
                case 0x2:
                    textBoxAssociativityTypeHuman.Text = "2-way associative";
                    break;
                case 0x4:
                    textBoxAssociativityTypeHuman.Text = "4-way associative";
                    break;
                case 0x6:
                    textBoxAssociativityTypeHuman.Text = "8-way associative";
                    break;
                case 0x8:
                    textBoxAssociativityTypeHuman.Text = "16-way associative";
                    break;
                case 0xF:
                    textBoxAssociativityTypeHuman.Text = "Fully associative";
                    break;
                default:
                    textBoxAssociativityTypeHuman.Text = "Reserved/Unknown";
                    break;
            }
            */

            #endregion
        }
    }
}
