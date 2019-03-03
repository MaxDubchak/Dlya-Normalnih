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
    public partial class SetRangeOfRandomNode : Form      //форма для внесення даних меж рандомного генерування вузла
    {
        private RangeOfRandomNode range;        //клас для зберігання меж рандомного вузла

        public SetRangeOfRandomNode(RangeOfRandomNode range)      //конструктор (приймаємо об'єкт для зберігання меж)
        {
            InitializeComponent();
            this.range = range;
        }

        private void button1_Click(object sender, EventArgs e)      //зчитує всі параметри і генерує вузол
        {
            if(min_numNodes.Text == "" || max_numNodes.Text == "" || 
                min_X.Text == "" || min_Y.Text == "" || min_Z.Text == "" ||
                min_length.Text == "" || min_height.Text == "" || min_width.Text == "" ||
                min_range.Text == "" || min_batteryCharge.Text == "" || min_numSensors.Text == "" ||
                max_X.Text == "" || max_Y.Text == "" || max_Z.Text == "" ||
                max_length.Text == "" || max_height.Text == "" || max_width.Text == "" ||
                max_range.Text == "" || max_batteryCharge.Text == "" || max_numSensors.Text == "")
            {
                MessageBox.Show("Заповніть усі дані або скористайтесь кнопкою автозаповнення!!!");
                return;
            }

            range.setRange(Convert.ToInt32(min_numNodes.Text), Convert.ToInt32(max_numNodes.Text),
                            Convert.ToInt32(min_X.Text), Convert.ToInt32(min_Y.Text), Convert.ToInt32(min_Z.Text), 
                            Convert.ToInt32(min_height.Text), Convert.ToInt32(min_length.Text), Convert.ToInt32(min_width.Text), 
                            Convert.ToInt32(min_range.Text), Convert.ToInt32(min_batteryCharge.Text), Convert.ToInt32(min_numSensors.Text),
                            Convert.ToInt32(max_X.Text), Convert.ToInt32(max_Y.Text), Convert.ToInt32(max_Z.Text),
                            Convert.ToInt32(max_height.Text), Convert.ToInt32(max_length.Text), Convert.ToInt32(max_width.Text),
                            Convert.ToInt32(max_range.Text), Convert.ToInt32(max_batteryCharge.Text), Convert.ToInt32(max_numSensors.Text));

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)      //задає початкові параметри
        {
            min_numNodes.Text = "5";
            min_X.Text = "0";
            min_Y.Text = "0";
            min_Z.Text = "0";
            min_length.Text = "0";
            min_height.Text = "0";
            min_width.Text = "0";
            min_range.Text = "0";
            min_batteryCharge.Text = "0";
            min_numSensors.Text = "0";

            max_numNodes.Text = "100";
            max_X.Text = "100";
            max_Y.Text = "100";
            max_Z.Text = "100";
            max_length.Text = "100";
            max_height.Text = "100";
            max_width.Text = "100";
            max_range.Text = "1000";
            max_batteryCharge.Text = "604800";
            max_numSensors.Text = "50";
        }
    }
}