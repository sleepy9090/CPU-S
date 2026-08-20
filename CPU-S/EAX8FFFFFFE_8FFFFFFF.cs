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
    public partial class EAX8FFFFFFE_8FFFFFFF : Form
    {

        private CPUHelper cpuHelper;

        public EAX8FFFFFFE_8FFFFFFF()
        {
            InitializeComponent();

            cpuHelper = new CPUHelper();

            #region EAX=0x8FFFFFFE-0x8FFFFFFF: AMD Easter Eggs

            string cpuIdEAX8FFFFFFEEAX = cpuHelper.GetEAX8FFFFFFEEAXX();
            textBoxEAX8FFFFFFEEAX.Text = cpuIdEAX8FFFFFFEEAX;

            string cpuIdEAX8FFFFFFEEBX = cpuHelper.GetEAX8FFFFFFEEBXX();
            textBoxEAX8FFFFFFEEBX.Text = cpuIdEAX8FFFFFFEEBX;

            string cpuIdEAX8FFFFFFEECX = cpuHelper.GetEAX8FFFFFFEECXX();
            textBoxEAX8FFFFFFEECX.Text = cpuIdEAX8FFFFFFEECX;

            string cpuIdEAX8FFFFFFEEDX = cpuHelper.GetEAX8FFFFFFEEDXX();
            textBoxEAX8FFFFFFEEDX.Text = cpuIdEAX8FFFFFFEEDX;

            string cpuIdEAX8FFFFFFFEAX = cpuHelper.GetEAX8FFFFFFFEAXX();
            textBoxEAX8FFFFFFFEAX.Text = cpuIdEAX8FFFFFFFEAX;

            string cpuIdEAX8FFFFFFFEBX = cpuHelper.GetEAX8FFFFFFFEBXX();
            textBoxEAX8FFFFFFFEBX.Text = cpuIdEAX8FFFFFFFEBX;

            string cpuIdEAX8FFFFFFFECX = cpuHelper.GetEAX8FFFFFFFECXX();
            textBoxEAX8FFFFFFFECX.Text = cpuIdEAX8FFFFFFFECX;

            string cpuIdEAX8FFFFFFFEDX = cpuHelper.GetEAX8FFFFFFFEDXX();
            textBoxEAX8FFFFFFFEDX.Text = cpuIdEAX8FFFFFFFEDX;

            #endregion
        }
    }
}
