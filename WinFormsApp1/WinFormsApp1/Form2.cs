using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        Stopwatch stopwatch = new Stopwatch();
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
        }

        private void START_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = string.Format("{0:hh\\mm\\:ss\\.ff}", stopwatch.Elapsed);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
