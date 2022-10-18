using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wh_2
{
    public partial class FormMonitor : Form
    {
        public static Int32 sumaM = 0;
        public FormMonitor()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int c = 0;
            int current = comboBox2.SelectedIndex;
            while (c < 2){
                sumaM = 0;
                if (current == 0)
                {
                    sumaM += 550;
                    c++;
                }

                if (current == 1)
                {
                    sumaM += 650;
                    c++;
                }
                if (current == 2)
                {
                    sumaM += 800;
                    c++;
                }
                if (current == 3)
                {
                    sumaM += 1000;
                    c++;
                }
                if (current == 4)
                {
                    sumaM += 1500;
                    c++;
                }
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_cenaM.Text = sumaM.ToString();
            label_cenaM.Update();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
