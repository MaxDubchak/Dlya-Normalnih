using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassNode
{
    class RandomGeneration
    {
        private SensorNetwork network;

        public RandomGeneration(SensorNetwork network)
        {
            this.network = network;
        }

        public void generate()
        {
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
            for (int counter = 0; counter < num; counter++)
            {
                //створення нового вузла
                Node newNode = new Node();

                //встановлення рандомно-згенерованих параметрів вузла
                {
                    //встановлення координат
                    newNode.set_X(rand.Next(range.get_minX(), range.get_maxX()));
                    newNode.set_Y(rand.Next(range.get_minY(), range.get_maxY()));
                    newNode.set_Z(rand.Next(range.get_minZ(), range.get_maxZ()));

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

                    int rangeOfAction = rand.Next(range.get_minRange(), range.get_maxRange());
                    newNode.setRandeOfAction(rangeOfAction - rangeOfAction % 100);
                    
                    newNode.setBatteryCharge(rand.Next(range.get_minBatteryCharge(), range.get_maxBatteryCharge()));
                }

                //додавання сформованого вузла в мережу
                network.addNode(newNode);
            }

            network.calculateSize();
        }
    }
}
