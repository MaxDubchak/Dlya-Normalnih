using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassNode
{
    public class SensorNetwork
    {
        //##############################################################################
        //список вузлів мережі
        private List<Node> network = new List<Node>();

        //чи мережа в 3D просторі
        bool has3D;

        //площа та об'єм мережі
        int square, capacity;

        //##############################################################################
        //додавання вузла в мережу
        public void addNode(Node node)
        {
            network.Add(node);
        }

        public void set_3D(bool _3D)
        {
            this.has3D = _3D;
        }

        public bool get_3D()
        {
            return this.has3D;
        }

        //отримує поточну кількість вузлів в мережі
        public int get_numNodes()
        {
            return this.network.Count();
        }

        //видаляє вузол
        public void deleteNode(int index)
        {
            network.RemoveAt(index);
        }

        //отримує вузол за його індексом
        public Node get_Node(int index)
        {
            return network[index];
        }

        //обраховує значення площі і об'єму мережі
        public void calculateSize()
        {
            int num = this.get_numNodes();
            int min_X = this.network[0].get_X(),
                min_Y = this.network[0].get_Y(), 
                min_Z = this.network[0].get_Z(), 
                max_X = this.network[0].get_X(), 
                max_Y = this.network[0].get_Y(), 
                max_Z = this.network[0].get_Z();

            //шукає максимальні та мінімальні координати
            for(int counter = 1; counter < num; counter++)
            {
                int X = this.network[counter].get_X(),
                    Y = this.network[counter].get_Y(),
                    Z = this.network[counter].get_Z();

                if (X > max_X)
                    max_X = X;

                if (X < min_X)
                    min_X = X;

                if (Y > max_Y)
                    max_Y = Y;

                if (Y < min_Y)
                    min_Y = Y;

                if (Z > max_Z)
                    max_Z = Z;

                if (Z < min_Z)
                    min_Z = Z;
            }


            //обраховує площу та об'єм
            this.square = (max_X - min_X) * (max_Y - min_Y);
            this.capacity = this.square * (max_Z - min_Z);
        }

        //повертає площу мережі
        public int get_Square()
        {
            return this.square;
        }

        //повертає об'єм мережі
        public int get_Capacity()
        {
            return this.capacity;
        }
    }
}