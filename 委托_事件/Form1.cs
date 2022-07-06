using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 委托_事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class MyEvent
        {
            public event MakeHotMachineHandler temperatureChangeEvent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyEvent eve = new MyEvent();
            eve.temperatureChangeEvent += MakeHotMachine;
            if (string.IsNullOrEmpty(textBox1.Text.Trim()))
            {
                MessageBox.Show("请输入水温");
                return;
            }
            MakeHotMachine(Convert.ToInt32(textBox1.Text.Trim()));
            TvSHOW(Convert.ToInt32(textBox1.Text.Trim()));


        }

        public delegate string MakeHotMachineHandler(int temprature);

        public string  MakeHotMachine(int temprature)
        {
            if (temprature>=95)
            {
                label4.Text = "110";
            }
            else
            {
                label4.Text = temprature.ToString();
            }
            return label3.Text;
        }

        public string TvSHOW(int temprature)
        {
            if (temprature >= 95)
            {
                label5.Text = "110";
            }
            else
            {
                label5.Text = temprature.ToString();
            }
            return label5.Text;
        }


    }
}
