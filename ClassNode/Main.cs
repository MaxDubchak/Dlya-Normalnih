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
