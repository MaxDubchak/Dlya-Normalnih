using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassNode
{
    public class SensorNetwork
    {
        //список вузлів мережі
        private List<Node> network = new List<Node>();

        //чи мережа в 3D просторі
        bool has3D;

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
    }
}