using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace wh_2
{
    public partial class FormKomputer : Form
    {
        public static Int32 suma = 0;

        public const Int32 dysk1 = 300;
        public const Int32 dysk2 = 500;
        public const Int32 dysk3 = 1000;

        public const Int32 kamerka = 30;
        public const Int32 myszka = 50;
        public const Int32 klawiatura = 100;
        public const Int32 chlodzenie = 450;


        public FormKomputer()
        {
            InitializeComponent();
        }

        private void checkBox_chłodzenie_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_chłodzenie.Checked)
                suma += chlodzenie;
            if (!(checkBox_chłodzenie.Checked))
                suma -= chlodzenie;
        }

        private void checkBox_klawiatura_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_klawiatura.Checked)
                suma += klawiatura;
            if (!(checkBox_klawiatura.Checked))
                suma -= klawiatura;
        }

        private void checkBox_myszka_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_myszka.Checked)
                suma += myszka;
            if (!(checkBox_myszka.Checked))
                suma -= myszka;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label_cena.Text = suma.ToString();
            label_cena.Update();
           
        }

        private void checkBox_kamerka_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_kamerka.Checked)
                suma += kamerka;
            if (!(checkBox_kamerka.Checked))
                suma -= kamerka;
        }

        private void radioButton_50GB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_50GB.Checked)
                suma += dysk1;
            if (!(radioButton_50GB.Checked))
                suma -= dysk1;
        }

        private void radioButton_500GB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_500GB.Checked)
                suma += dysk2;
            if (!(radioButton_500GB.Checked))
                suma -= dysk2;
        }

        private void radioButton_2TB_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_2TB.Checked)
                suma += dysk3;
            if (!(radioButton_2TB.Checked))
                suma -= dysk3;
        }

        private void comboBox_SystemO_SelectedIndexChanged(object sender, EventArgs e)
        {
            int current = comboBox_SystemO.SelectedIndex;
            if (current == 0)
                suma += 400;
            if (current == 1)
                suma += 300;
            if (current == 2)
                suma += 200;
        }
    }

}
