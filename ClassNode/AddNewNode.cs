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
    public partial class AddNewNode : Form
    {
        SensorNetwork network;

        public AddNewNode(SensorNetwork network)
        {
            InitializeComponent();
            this.network = network;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label_X.Text == "" || label_Y.Text == "" ||
                label_length.Text == "" || label_height.Text == "" || label_width.Text == "" ||
                label_range.Text == "" || label_batteryCharge.Text == "" /*|| label_numSensors.Text == ""*/)
            {
                MessageBox.Show("Заповніть усі дані");
                return;
            }

            //створення нового вузла і додавання його в існуючу мережу
            Node node = new Node();

            node.set_X(Convert.ToInt32(label_X.Text));
            node.set_Y(Convert.ToInt32(label_Y.Text));

            if (network.get_3D())
                node.set_Z(Convert.ToInt32(label_Z.Text));

            node.setLength(Convert.ToInt32(label_length.Text));
            node.setWidth(Convert.ToInt32(label_width.Text));
            node.setHeight(Convert.ToInt32(label_height.Text));

            node.setRandeOfAction(Convert.ToInt32(label_range.Text));
            node.setBatteryCharge(Convert.ToInt32(label_batteryCharge.Text));

            network.addNode(node);

            this.Close();
        }

        private void AddNewNode_Load(object sender, EventArgs e)
        {
            //приховування 3д лейблів, якщо мережа не підтримує 3д
            if(!network.get_3D())
            {
                label_Z.Visible = false;
                label_firstZ.Visible = false;
            }
        }
    }
}
