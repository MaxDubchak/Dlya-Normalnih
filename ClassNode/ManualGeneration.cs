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
    public partial class ManualGeneration : Form
    {
        SensorNetwork network;

        public ManualGeneration(SensorNetwork network)
        {
            InitializeComponent();
            this.network = network;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            Form addNode = new AddNewNode(network);
            addNode.ShowDialog();
        }

        private void button_View_Click(object sender, EventArgs e)
        {
            Form viewForm = new NodeView(network);
            viewForm.ShowDialog();
        }
    }
}
