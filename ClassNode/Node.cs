using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassNode
{
    public class Node
    {
        //##############################################################################

        //координати вузла
        private int x, y, z;

        //перелік сенсорів
        private List<string> sensors;
      
        //чи має GPS
        private bool hasGPS;

        //розміри (висота, довжина і ширина в сантиметрах) 
        private int height, length, width;

        //радіус дії вузла (в метрах)
        private int rangeOfAction;

        //заряд акумулятора (ємність, міліАмпери)
        private int batteryCharge;

        //тип вузла (1 - звичайний, 2 - хедер, 3 - центральний)
        private int type = 1;

        //##############################################################################

        //встановлює координати вузла
        public void set_X(int x)
        {
            this.x = x;
        }

        public void set_Y(int y)
        {
            this.y = y;
        }

        public void set_Z(int z)
        {
            this.z = z;
        }

        //додає новий сенсор
        public void addNewSensor(string newSensor)
        {
            this.sensors.Add(newSensor);
        }

        //встановлює наявність GPS
        public void setGPS(bool gps)
        {
            this.hasGPS = gps;
        }

        //встановлює розміри вузла
        public void setHeight(int height)
        {
            this.height = height;
        }

        public void setLength(int length)
        {
            this.length = length;
        }

        public void setWidth(int width)
        {
            this.width = width;
        }

        //встановлює радіус дії вузла
        public void setRandeOfAction(int range)
        {
            this.rangeOfAction = range;
        }

        //встановлює заряд акумулятора
        public void setBatteryCharge(int charge)
        {
            this.batteryCharge = charge;
        }

        //встановлює тип вузла
        public void setType(int type)
        {
            this.type = type;
        }

        //##############################################################################
        
        //повертає координати вузла
        public int get_X()
        {
            return this.x;
        }

        public int get_Y()
        {
            return this.y;
        }

        public int get_Z()
        {
            return this.z;
        }

        //повертає список сенсорів
        public List<string> getSensors()
        {
            return this.sensors;
        }

        //повертає наявність GPS
        public bool get_GPS()
        {
            return this.hasGPS;
        }

        //повертає розміри вузла
        public int getHeight()
        {
            return this.height;
        }

        public int getLength()
        {
            return this.length;
        }

        public int getWidth()
        {
            return this.width;
        }

        //повертає радіус дії вузла
        public int getRange()
        {
            return this.rangeOfAction;
        }

        //повертає час заряду акумулятора
        public int getBatteryCharge()
        {
            return this.batteryCharge;
        }

        //повертає тип вузла
        public int getType()
        {
            return this.type;
        }
    };
}