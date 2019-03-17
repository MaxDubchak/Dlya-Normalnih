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
    public partial class MainForm : Form
    {
        //для відображення індекатора чи система обраховує, чи чекає дій
        private bool loading = false;

        private SensorNetwork network = new SensorNetwork();

        public MainForm()
        {
            InitializeComponent();
            Indecator_green.Visible = !loading;     //відображаємо спочатку зелений індикатор
            Indecator_red.Visible = loading;
        }

        private void generateButton_Click(object sender, EventArgs e)       //кнопка згенеруватиМережу
        {
            //відкриття форми для вибору варіанту генерування (передаємо у форму нашу мережу)
            Form generationChoise = new GenerationChoice(network);
            generationChoise.ShowDialog();
            
        }

        //кнопка для відображення списку вузлів
        private void viewNodeButton_Click(object sender, EventArgs e)
        {
            if(network.get_numNodes() == 0)
            {
                MessageBox.Show("Спочатку згенеруйте мережу");
                return;
            }

            Form nodeView = new NodeView(network);
            nodeView.ShowDialog();
        }

        //кнопка для відображення коротких даних про мережу
        private void button1_Click(object sender, EventArgs e)
        {
            Form networkData = new NetworkData(network);
            networkData.ShowDialog();
        }

        //індивідуальні завдання
        #region individualTasks

        private void _17_Click(object sender, EventArgs e)
        {
            Number_17 number_17 = new Number_17(network);
        }

        private void _18_Click(object sender, EventArgs e)
        {
            Number_18 number_18 = new Number_18(network);
        }


        #endregion

        //loading = !loading;
        //Indecator_green.Visible = !loading;
        //Indecator_red.Visible = loading;


        //RangeOfRandomNode range = new RangeOfRandomNode();

        //Form generateRange = new SetRangeOfRandomNode(range);
        //generateRange.ShowDialog();





        //SensorNetwork network = new SensorNetwork();
        //network.generateNetwork();
    }
}
