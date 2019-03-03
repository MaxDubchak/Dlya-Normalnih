using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassNode
{
    public class RangeOfRandomNode      //для зберігання меж рандомного генерування вузла
    {
        //верхні і нижні межі
        private int min_numNodes, max_numNodes;
        private int min_X, min_Y, min_Z, min_height, min_length, min_width, min_range, min_batteryCharge, min_numSensors;        
        private int max_X, max_Y, max_Z, max_height, max_length, max_width, max_range, max_batteryCharge, max_numSensors;

        //метод встановлення меж
        public void setRange(int min_numNodes, int max_numNodes,
                             int min_X, int min_Y, int min_Z, int min_height, int min_length, int min_width, int min_range, int min_batteryCharge, int min_numSensors,
                             int max_X, int max_Y, int max_Z, int max_height, int max_length, int max_width, int max_range, int max_batteryCharge, int max_numSensors)
        {
            this.min_numNodes = min_numNodes;
            this.max_numNodes = max_numNodes;

            this.min_X = min_X;
            this.min_Y = min_Y;
            this.min_Z = min_Z;

            this.max_X = max_X;
            this.max_Y = max_Y;
            this.max_Z = max_Z;

            this.min_height = min_height;
            this.min_length = min_length;
            this.min_width = min_width;

            this.max_height = max_height;
            this.max_length = max_length;
            this.max_width = max_width;

            this.min_range = min_range;
            this.min_batteryCharge = min_batteryCharge;
            this.min_numSensors = min_numSensors;

            this.max_range = max_range;
            this.max_batteryCharge = max_batteryCharge;
            this.max_numSensors = max_numSensors;
        }

        //методи для отримання меж
        public int get_minNumNodes()
        {
            return this.min_numNodes;
        }

        public int get_minX()
        {
            return this.min_X;
        }

        public int get_minY()
        {
            return this.min_Y;
        }

        public int get_minZ()
        {
            return this.min_Z;
        }

        public int get_minHeight()
        {
            return this.min_height;
        }

        public int get_minLength()
        {
            return this.min_length;
        }

        public int get_minWidth()
        {
            return this.min_width;
        }

        public int get_minRange()
        {
            return this.min_range;
        }

        public int get_minBatteryCharge()
        {
            return this.min_batteryCharge;
        }

        public int get_minNumSensors()
        {
            return this.min_numSensors;
        }


        public int get_maxNumNodes()
        {
            return this.max_numNodes;
        }

        public int get_maxX()
        {
            return this.max_X;
        }

        public int get_maxY()
        {
            return this.max_Y;
        }

        public int get_maxZ()
        {
            return this.max_Z;
        }

        public int get_maxHeight()
        {
            return this.max_height;
        }

        public int get_maxLength()
        {
            return this.max_length;
        }

        public int get_maxWidth()
        {
            return this.max_width;
        }

        public int get_maxRange()
        {
            return this.max_range;
        }

        public int get_maxBatteryCharge()
        {
            return this.max_batteryCharge;
        }

        public int get_maxNumSensors()
        {
            return this.max_numSensors;
        }
    }
}