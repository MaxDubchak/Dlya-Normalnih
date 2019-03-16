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
            if(network.get_3D())
            {
                label_3D.Text = "Так";
                label_Size.Text = Convert.ToString(network.get_Capacity()) + "m^3";
            }
            else
            {
                label_3D.Text = "Ні";
                label_Size.Text = Convert.ToString(network.get_Square()) + "m^2";
            }

            label_Number.Text = Convert.ToString(network.get_numNodes());

        }
    }
}
