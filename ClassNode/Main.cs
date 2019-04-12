using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ClassNode
{
    public partial class MainForm : Form
    {
        private SensorNetwork network = new SensorNetwork();

        public MainForm()
        {
            InitializeComponent();
        }

        //кнопка для відображення коротких даних про мережу
        private void button1_Click(object sender, EventArgs e)
        {
            Form networkData = new NetworkData(network);
            networkData.ShowDialog();
        }

        private void інформаціяПроВузлиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form nodeView = new NodeView(network);
            nodeView.ShowDialog();
        }
























        private void button_Create_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            int x = 0, y = 0, z = 0;

            int height = Convert.ToInt32(comboBox_Height.Text),
                width = Convert.ToInt32(comboBox_Width.Text),
                depth = 0;

            network.set_height(height);
            network.set_width(width);

            if (radioButton_3D.Checked == true)
            {
                depth = Convert.ToInt32(comboBox_Depth.Text);
                network.set_depth(depth);
                network.set_3D(true);
            }
            //////////////////////////////////////////////////////////////
            //головний вузол

            Node node = new Node();

            node.setBatteryCharge(Convert.ToInt32(comboBox_BatteryCharge.Text));
            node.setRandeOfAction(Convert.ToInt32(comboBox_Range.Text));

            if (comboBox_Head_X.Text == "Rand") node.set_X(rand.Next(width));
            else node.set_X(Convert.ToInt32(comboBox_Head_X.Text));

            if (comboBox_Head_Y.Text == "Rand") node.set_Y(rand.Next(height));
            else node.set_Y(Convert.ToInt32(comboBox_Head_Y.Text));

            if (radioButton_3D.Checked == true)
            {
                if (comboBox_Head_Z.Text == "Rand") node.set_Z(rand.Next(depth));
                else node.set_Z(Convert.ToInt32(comboBox_Head_Z.Text));
            }

            node.setType(3);

            network.addNode(node);

            //////////////////////////////////////////////////////////////
            ///створення та побудова інших вузлів
            ///
            int num;
            if (comboBox_Num.Text == "Rand") num = rand.Next(500);
            else num = Convert.ToInt32(comboBox_Num.Text);

            for (int i = 1; i < num; i++)
            {
                //Створення вузла
                node = new Node();

                node.setBatteryCharge(Convert.ToInt32(comboBox_BatteryCharge.Text));
                node.setRandeOfAction(Convert.ToInt32(comboBox_Range.Text));

                x = rand.Next(width);
                y = rand.Next(height);
                z = rand.Next(depth);

                node.set_X(x);
                node.set_Y(y);

                if (radioButton_3D.Checked == true)
                {
                    node.set_Z(z);
                }

                node.setType(1);

                network.addNode(node);
            }


            //Малювання вузла
            draw();            
        }

        private void draw()
        {
            Node node;
            int num = network.get_numNodes();

            if (radioButton_2D.Checked == true)
            {
                        int x = 0, y = 0;
                        int width = network.get_width(), height = network.get_height();
                        for (int i = 0; i < num; i++)
                        {
                            node = network.get_Node(i);
                            SolidBrush brush;
                            Graphics g = Graphics.FromHwnd(pictureBox_scene.Handle);
                            if (node.getType() == 1)
                            {
                                brush = new SolidBrush(Color.Black);
                            }
                            else if (node.getType() == 2)
                            {
                                brush = new SolidBrush(Color.Green);
                            }
                            else brush = new SolidBrush(Color.Red);

                            x = node.get_X() * 1000 / width;
                            y = node.get_Y() * 800 / height;

                            Point dPoint = new Point(x, (pictureBox_scene.Height - y));
                            dPoint.X -= 5;
                            dPoint.Y -= 5;

                            RectangleF rect = new RectangleF(dPoint, new Size(10, 10));
                            // g.FillRectangle(brush, rect);

                            g.FillEllipse(brush, rect);
                            g.Dispose();
                        }
            }
        }

        //очистити мережу та pictureBox
        private void button_Clear_Click(object sender, EventArgs e)
        {
            network = new SensorNetwork();
            pictureBox_scene.Image = null;
        }


        //при виборі 3д
        private void radioButton_3D_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            label12.Visible = true;
            comboBox_Head_Z.Visible = true;
            comboBox_Depth.Visible = true;
        }

        //при виборі 2д
        private void radioButton_2D_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            label12.Visible = false;
            comboBox_Head_Z.Visible = false;
            comboBox_Depth.Visible = false;
        }

        //запис у файл
        private void зберегтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл

            string fileName = saveFileDialog.FileName;

            StreamWriter f = new StreamWriter(fileName, true);

            f.WriteLine("Наявність 3D:");
            f.WriteLine(Convert.ToString(network.get_3D()));
            f.WriteLine("");

            f.WriteLine("Кількість вузлів:");
            f.WriteLine(Convert.ToString(network.get_numNodes()));
            f.WriteLine("");

            f.WriteLine("Розміри (Висота, Ширина, Глубина):");
            f.WriteLine(Convert.ToString(network.get_height()));
            f.WriteLine(Convert.ToString(network.get_width()));
            if (network.get_3D()) f.WriteLine(Convert.ToString(network.get_depth()));
            f.WriteLine("");

            int num = network.get_numNodes();
            for (int i = 0; i < num; i++)
            {
                f.WriteLine("Вузол " + i + 1 + ": (X, Y, Z, Тип, Заряд):");
                f.WriteLine(Convert.ToString(network.get_Node(i).get_X()));
                f.WriteLine(Convert.ToString(network.get_Node(i).get_Y()));
                if (network.get_3D()) f.WriteLine(Convert.ToString(network.get_Node(i).get_Z()));
                f.WriteLine(Convert.ToString(network.get_Node(i).getType()));
                f.WriteLine(Convert.ToString(network.get_Node(i).getBatteryCharge()));
                f.WriteLine("");
            }

            f.Close();
        }

        //читання з файлу
        private void згенеруватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            //// получаем выбранный файл
            ///
            network = new SensorNetwork();
            string filename = openFileDialog.FileName;

            StreamReader f = new StreamReader(filename);

            string text;

            f.ReadLine();
            network.set_3D(Convert.ToBoolean(f.ReadLine()));
            f.ReadLine();

            f.ReadLine();
            int num = (Convert.ToInt32(f.ReadLine()));
            f.ReadLine();

            f.ReadLine();
            network.set_height(Convert.ToInt32(f.ReadLine()));
            network.set_width(Convert.ToInt32(f.ReadLine()));
            if(network.get_3D()) network.set_depth(Convert.ToInt32(f.ReadLine()));
            f.ReadLine();

            for(int i = 0; i < num; i++)
            {
                f.ReadLine();
                Node node = new Node();
                node.set_X(Convert.ToInt32(f.ReadLine()));
                node.set_Y(Convert.ToInt32(f.ReadLine()));
                if(network.get_3D()) node.set_Z(Convert.ToInt32(f.ReadLine()));
                node.setType(Convert.ToInt32(f.ReadLine()));
                node.setBatteryCharge(Convert.ToInt32(f.ReadLine()));
                f.ReadLine();

                network.addNode(node);
            }

            f.Close();

            draw();
        }

        private void lEACHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Leach leach = new Leach(network, pictureBox_scene.Handle);
            
            leach.simulation();
        }
    }
}
