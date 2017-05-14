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
            //_Elements.Items.Add("WZ", WZ());
        }

        private void _toggleAdress_Click(object sender, EventArgs e)
        {
            int byteAdr = Decimal.ToInt32( _byteAdress.Value );
            int bitAdr = Decimal.ToInt32( _bitAdress.Value );
            _LogoInstance.WriteBit(byteAdr, _BitNumber.BIT0, _BitState.HIGH);
            _LogoInstance.WriteBit(byteAdr, _BitNumber.BIT0, _BitState.LOW);
        }

        private bool WZ()
        {
            return _LogoInstance.ReadBit(28, _BitNumber.BIT0, _BitState.LOW);
        }
    }
}
