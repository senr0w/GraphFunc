using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphFunc
{
    public partial class Graph : Form
    {
        private double a, b, h;
        private double x,y;

        public Graph()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void построитьГрафикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(checkBox_cos.Checked == false && checkBox_sin.Checked == false)
            {
                MessageBox.Show("График бы выбрать");
                return;
            }
            if(textBox_a.Text=="" || textBox_b.Text=="" || textBox_h.Text == "")
            {
                MessageBox.Show("График по умолчаию");
                Default();
            }
            else
            {
                a=Convert.ToDouble(textBox_a.Text);
                b=Convert.ToDouble(textBox_b.Text);
                h=Convert.ToDouble(textBox_h.Text);
            }
            if (checkBox_cos.Checked)
            {
                x = a;
                this.chart.Series[0].Points.Clear();
                while(x<=b)
                {
                    y = Math.Cos(x);
                    this.chart.Series[0].Points.AddXY(x,y);
                    x += h;
                }
            }
            if (checkBox_sin.Checked)
            {
                x = a;
                this.chart.Series[1].Points.Clear();
                while (x <= b)
                {
                    y = Math.Sin(x);
                    this.chart.Series[1].Points.AddXY(x, y);
                    x += h;
                }
            }

        }

        private void очиститьГрафикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkBox_cos.Checked == false && checkBox_sin.Checked == false)
            {
                MessageBox.Show("График бы выбрать");
                return;
            }
            if (checkBox_cos.Checked)
            {
                this.chart.Series[0].Points.Clear();
            }
            if (checkBox_sin.Checked)
            {
                this.chart.Series[1].Points.Clear();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Выйти?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Default()
        {
            a = -10;
            b = 10;
            h = 0.1;
        }
    }
}
