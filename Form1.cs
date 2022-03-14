using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace currencyExchange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const double k = 0.02;
        Random rnd = new Random();
        double price_bitcoin, price_etherium;

        private void startStopBtn_Click(object sender, EventArgs e)
        {
            
            if (!timer1.Enabled)
            {
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                price_bitcoin = (double)Currency_1.Value;
                price_etherium = (double)Currency_2.Value;
                chart1.Series[0].Points.AddXY(0, price_bitcoin);
                chart1.Series[1].Points.AddXY(0, price_etherium);
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            price_bitcoin = price_bitcoin * (1 + k * (rnd.NextDouble() - 0.5));
            price_etherium= price_etherium * (1 + k * (rnd.NextDouble() - 0.5));
            var curTime = DateTime.Now.ToString("HH:mm:ss");
            chart1.Series[0].Points.AddXY(curTime, price_bitcoin);
            chart1.Series[1].Points.AddXY(curTime, price_etherium);
        }
    }
}
