using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LogoRemoteControl
{
    public partial class LogoSimpleControl : Form
    {
        private Logo _LogoInstance = null;
        public LogoSimpleControl()
        {
            _LogoInstance = Logo.Instance("192.168.85.200");
            InitializeComponent();
        }

        private void _toggleAdress_Click(object sender, EventArgs e)
        {
            int byteAdr = Decimal.ToInt32( _byteAdress.Value );
            int bitAdr = Decimal.ToInt32( _bitAdress.Value );
            _LogoInstance.WriteBit(byteAdr, bitAdr, true);
            System.Threading.Thread.Sleep(50);
            _LogoInstance.WriteBit(byteAdr, bitAdr, false);
        }
    }
}
