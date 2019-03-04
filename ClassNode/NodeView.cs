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
    public partial class NodeView : Form
    {
        private int currentNodeNum;
        SensorNetwork network = new SensorNetwork();

        public NodeView(SensorNetwork network)
        {
            InitializeComponent();
            this.network = network;
        }

        //змінити, щоб викликалась подія зміни текст-боксу
        private void NodeView_Load(object sender, EventArgs e)
        {
            //початкове заповнення
            currentNode.Text = "1";
            fillForm(network.get_Node(0));
            maxNumNodeLabel.Text = Convert.ToString(network.get_numNodes());

            //ховає 3Д лейбли, якщо мережа не підтримує
            if(!network.get_3D())
            {
                zLabel.Visible = false;
                has3D_first.Visible = false;
            }
        }

        //заповнює форму
        private void fillForm(Node node)
        {
            xLabel.Text = Convert.ToString(node.get_X());
            yLabel.Text = Convert.ToString(node.get_Y());
            zLabel.Text = Convert.ToString(node.get_Z());

            heightLabel.Text = Convert.ToString(node.getHeight());
            lengthLabel.Text = Convert.ToString(node.getLength());
            widthLabel.Text = Convert.ToString(node.getWidth());

            rangeLabel.Text = Convert.ToString(node.getRange());
            batteryLabel.Text = Convert.ToString(node.getBatteryCharge());
            gpsLabel.Text = Convert.ToString(node.get_GPS());
        }

        //видаляє вузол
        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Ви впевнені?", "", MessageBoxButtons.OKCancel); 

            //якщо підтвердити
            if(dialogResult == DialogResult.OK)
            {
                //видаляє вузол з мережі
                int currentNodeIndex = Convert.ToInt32(currentNode.Text);
                network.deleteNode(currentNodeIndex - 1);
                maxNumNodeLabel.Text = Convert.ToString(network.get_numNodes());

                //відображає попередній вузол
                if(currentNodeIndex == 1)
                {
                    fillForm(network.get_Node(0));
                }
                else
                {
                    currentNode.Text = Convert.ToString(currentNodeIndex - 1);
                }
            }
        }

        //якщо змінити текст
        private void currentNode_TextChanged(object sender, EventArgs e)
        {
            //якщо стерти бекспейсом всі цифри
            if(currentNode.Text == "")
            {
                currentNode.Text = "1";
            }

            Node node;
            currentNodeNum = Convert.ToInt32(currentNode.Text);

            //не дозволяє вийти за межі списку
            if(currentNodeNum > network.get_numNodes())
            {
                currentNode.Text = Convert.ToString(network.get_numNodes());
                //node = network.get_Node(currentNodeNum);
                return;
            }

            if (currentNodeNum < 1)
            {
                currentNode.Text = "1";
                //node = network.get_Node(currentNodeNum);
                return;
            }

            //блокує кнопку при першому вузлі
            if (currentNodeNum == 1)
            {
                previous.Enabled = false;
            }
            else
            {
                previous.Enabled = true;
            }

            //заповнює форму
            fillForm(network.get_Node(currentNodeNum - 1));
        }

        //вводить лише цифри в текстбокс
        private void currentNode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }


        //кнопки попереднього та наступного вузла
        private void previous_Click(object sender, EventArgs e)
        {
            currentNodeNum = Convert.ToInt32(currentNode.Text);
            currentNode.Text = Convert.ToString(currentNodeNum - 1);
        }

        private void next_Click(object sender, EventArgs e)
        {
            currentNodeNum = Convert.ToInt32(currentNode.Text);
            currentNode.Text = Convert.ToString(currentNodeNum + 1);
        }
    }
}
