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
    public partial class GenerationChoice : Form        //вибір варіанту генерування мережі
    {
        //збереження мережі
        private SensorNetwork network;

        public GenerationChoice(SensorNetwork network)      //конструктор
        {
            this.network = network;
            InitializeComponent();
        }

        private void randomGeneration_Click(object sender, EventArgs e)     //рандомне генерування
        {
            //приховування форми вибору варіанту генерування (процеси продовжують виконуватись до кінця)
            this.Hide();

            //для рандомного генерування
            Random rand = new Random();

            //генерування наявності 3D (генеруємо число до 100, якщо менше 50 - має 3D, якщо більше - не має
            network.set_3D((rand.Next(100) < 50) ? true : false);
            
            //створення модульного класу для збереження меж генерування
            RangeOfRandomNode range = new RangeOfRandomNode();

            //відкриття форми для заповнення меж
            Form generationRange = new SetRangeOfRandomNode(range);
            generationRange.ShowDialog();

            //кількість майбутніх вузлів
            int num = rand.Next(range.get_minNumNodes(), range.get_maxNumNodes());
            
            //цикл генерування вузлів
            for(int counter = 0; counter < num; counter++)
            {
                //створення нового вузла
                Node newNode = new Node();

                //встановлення рандомно-згенерованих параметрів вузла
                {
                //встановлення координат
                newNode.set_X(rand.Next(range.get_minX(), range.get_maxX()));
                    newNode.set_Y(rand.Next(range.get_minY(), range.get_maxY()));
                    if (network.get_3D())
                    {
                        newNode.set_Z(rand.Next(range.get_minZ(), range.get_maxZ()));
                    }

                    //встановлення наявності GPS у вузлі
                    newNode.setGPS((rand.Next(100) < 50) ? true : false);

                    //встановлення розмірів вузла
                    newNode.setHeight(rand.Next(range.get_minHeight(), range.get_maxHeight()));
                    newNode.setLength(rand.Next(range.get_minLength(), range.get_maxLength()));
                    newNode.setWidth(rand.Next(range.get_minWidth(), range.get_maxWidth()));

                    //встановлення списку сенсорів, радіусу дії та часу заряду акумулятора
                    for (int numCurrentSensor = 0; numCurrentSensor < 0; numCurrentSensor++)
                    {
                        ;
                    }

                    newNode.setRandeOfAction(rand.Next(range.get_minRange(), range.get_maxRange()));
                    newNode.setBatteryCharge(rand.Next(range.get_minBatteryCharge(), range.get_maxBatteryCharge()));
                }

                //додавання сформованого вузла в мережу
                network.addNode(newNode);
            }

            network.calculateSize();

            //закриття форми
            this.Close();
        }

        private void handGeneration_Click(object sender, EventArgs e)
        {
            Form manualGeneration = new ManualGeneration(network);
            manualGeneration.ShowDialog();
        }
    }
}