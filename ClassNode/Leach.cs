using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClassNode
{
    class Leach
    {
        private SensorNetwork network;
        private IntPtr handle;
        private List<Contact> leachNetwork = new List<Contact>();

        private class Contact
        {
            public Node header;
            public List<Node> nodes = new List<Node>();

            public Contact(Node node)
            {
                header = node;
            }
        }

        public Leach(SensorNetwork network, IntPtr handle)
        {
            this.network = network;
            this.handle = handle;
        }

        public void simulation()
        {
            int numClasters = firstClasters();
            findContact(numClasters);

            numClasters = leachNetwork.Count;

            for(int i = 0; i < numClasters; i++)
            {
                int numNodes = leachNetwork[i].nodes.Count;

                for(int j = 0; j < numNodes; j++)
                {
                    drawContact(leachNetwork[i].header.get_X(), leachNetwork[i].header.get_Y(), leachNetwork[i].nodes[j].get_X(), leachNetwork[i].nodes[j].get_Y());
                }
            }

        }

        //малювання точки за координатами заданого кольору
        private void drawPoint(int X, int Y, SolidBrush brush)
        {
            Graphics g = Graphics.FromHwnd(handle);

            int width = network.get_width(), height = network.get_height();
            int x, y;

                x = X * 1000 / width;
                y = Y * 800 / height;

                Point dPoint = new Point(x, (800 - y));
                dPoint.X -= 5;
                dPoint.Y -= 0;

                RectangleF rect = new RectangleF(dPoint, new Size(10, 10));
                // g.FillRectangle(brush, rect);

                g.FillEllipse(brush, rect);
                g.Dispose();
        }

        private void drawContact(int f_X, int f_Y, int s_X, int s_Y)
        {
            int width = network.get_width(), height = network.get_height();
            int f_x, f_y, s_x, s_y;

            f_x = f_X * 1000 / width;
            f_y = f_Y * 800 / height;

            s_x = s_X * 1000 / width;
            s_y = s_Y * 800 / height;

            Point fPoint = new Point(f_x, (800 - f_y));
            fPoint.Y += 5;

            Point sPoint = new Point(s_x, (800 - s_y));
            sPoint.Y += 5;

            Graphics g = Graphics.FromHwnd(handle);
            Pen p = new Pen(Color.Red);
            g.DrawLine(p, fPoint, sPoint);
            g.Dispose();
        }

        //обрання початкових кластерХедів
        private int firstClasters()
        {
            Random rand = new Random();
            int numClaster = network.get_numNodes() / 5 + 1;

            for (int counter = 0; counter < numClaster;)
            {
                int i = rand.Next(network.get_numNodes() - 1);

                if (network.get_Node(i).getType() != 1) continue;
                else
                {
                    SolidBrush brush = new SolidBrush(Color.GreenYellow);
                    drawPoint(network.get_Node(i).get_X(), network.get_Node(i).get_Y(), brush);
                    counter++;
                    network.get_Node(i).setType(2);
                }
            }
            return numClaster;
        }

        //формування списку leachNetwork (всі вузли поєднано з хедерами)
        private void findContact(int n)
        {
            if(leachNetwork != null) leachNetwork.Clear();
            int num = network.get_numNodes();

            for (int i = 0; i < num; i++)
            {
                if(network.get_Node(i).getType() == 2)
                {
                    Contact item = new Contact(network.get_Node(i));
                    leachNetwork.Add(item);
                }
            }

            double minLength;
            int minJ;
            for(int i = 0; i < num; i++)
            {
                Node node = network.get_Node(i);
                if (node.getType() != 1) continue;

                minJ = 0;
                minLength = calculateLength(node, leachNetwork[0].header);
                for(int j = 1; j < n; j++)
                {
                    double length = calculateLength(node, leachNetwork[j].header);

                    if(length < minLength)
                    {
                        minJ = j;
                        minLength = length;
                    }
                }

                leachNetwork[minJ].nodes.Add(node);
            }
        }

        //пошук довжини відрізку
        private double calculateLength(Node first, Node second)
        {            
            return Math.Sqrt(Math.Abs(first.get_X() - second.get_X()) * Math.Abs(first.get_X() - second.get_X()) + 
                   Math.Abs(first.get_Y() - second.get_Y()) * Math.Abs(first.get_Y() - second.get_Y()));
        }
    }
}
