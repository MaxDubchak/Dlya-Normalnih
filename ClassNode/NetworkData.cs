using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassNode
{
    public partial class NetworkData : Form
    {
        SensorNetwork network;
        public NetworkData(SensorNetwork network)
        {
            InitializeComponent();
            this.network = network;
        }

        private void NetworkData_Load(object sender, EventArgs e)
        {
          
        }
    }
}
