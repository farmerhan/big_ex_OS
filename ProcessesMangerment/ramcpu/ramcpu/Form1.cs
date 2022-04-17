using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ramcpu
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
            progressBarcpu.Value = (int)fcpu;
            progressBarram.Value = (int)fram;
            lbcpu.Text = string.Format("{0:0.00}%", fcpu);
            lbram.Text = string.Format("{0:0.00}%", fram);
            chart1.Series["CPU"].Points.AddY(fcpu);
            chart1.Series["RAM"].Points.AddY(fram);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
