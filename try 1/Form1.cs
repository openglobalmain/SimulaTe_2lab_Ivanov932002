using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace try_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double k = 0.1;
        Random random = new Random();
        int clickCount = 0, day = 0;

        double us, eur;

        private void startButton_Click(object sender, EventArgs e)
        {
            if (clickCount == 0)
            {
                us = (double)ustart.Value;
                eur = (double)rubstart.Value;
                timer1.Start();
            }
            else if (clickCount % 2 == 0)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
            clickCount++;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void unow_ValueChanged(object sender, EventArgs e)
        {

        }

        private void rubnow_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            chart1.Series[0].Points.AddXY(day, Math.Round(us, 2));
            chart1.Series[1].Points.AddXY(day, Math.Round(eur, 2));
            us = us * (1 + k * (random.NextDouble() - 0.5));
            eur = eur * (1 + k * (random.NextDouble() - 0.5));
            if (us < 0) us = 0;
            if (eur < 0) eur = 0;
            textBox1.Text = Convert.ToDecimal(us).ToString("0.0000");
            textBox2.Text = Convert.ToDecimal(eur).ToString("0.0000");
            day++;


        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
