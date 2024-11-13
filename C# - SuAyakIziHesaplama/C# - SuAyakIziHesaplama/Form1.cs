using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C____SuAyakIziHesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double litreMiktar = 0;
        double galonMiktar = 0;

        double toplaLitre = 0;
        double toplaGalon = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            void toplaMiktariGoster()
            {
                if (radioButton1.Checked == true)
                {
                    listBox1.Items.Add("Toplam litre miktarı : " + toplaLitre);
                }
                else
                {
                    listBox1.Items.Add("Toplam galon miktarı : " + toplaGalon);
                }
            }
            if (comboBox1.SelectedIndex == 0)
            {
                if (radioButton1.Checked == true)
                {
                    litreMiktar = 52000;
                    toplaLitre += litreMiktar;
                    listBox1.Items.Add(litreMiktar + " lt");
                }
                else
                {
                    galonMiktar = 13737;
                    toplaGalon += galonMiktar;
                    listBox1.Items.Add(galonMiktar + " galon");
                }
                toplaMiktariGoster();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                if (radioButton1.Checked == true)
                {
                    litreMiktar = 8000;
                    toplaLitre += litreMiktar;
                    listBox1.Items.Add(litreMiktar + " lt");
                }
                else
                {
                    galonMiktar = 2133;
                    toplaGalon += galonMiktar;
                    listBox1.Items.Add(galonMiktar + " galon");
                }
                toplaMiktariGoster();

            }
            if (comboBox1.SelectedIndex == 2)
            {
                if (radioButton1.Checked == true)
                {
                    litreMiktar = 12760;
                    toplaLitre += litreMiktar;
                    listBox1.Items.Add(litreMiktar + " lt");
                }
                else
                {
                    galonMiktar = 3190;
                    toplaGalon += galonMiktar;
                    listBox1.Items.Add(galonMiktar + " galon");
                }
                toplaMiktariGoster();

            }
            if (comboBox1.SelectedIndex == 3)
            {
                if (radioButton1.Checked == true)
                {
                    litreMiktar = 10850;
                    toplaLitre += litreMiktar;
                    listBox1.Items.Add(litreMiktar + " lt");
                }
                else
                {
                    galonMiktar = 2866;
                    toplaGalon += galonMiktar;
                    listBox1.Items.Add(galonMiktar + " galon");
                }
                toplaMiktariGoster();

            }
            if (comboBox1.SelectedIndex == 4)
            {
                if (radioButton1.Checked == true)
                {
                    litreMiktar = 9750;
                    toplaLitre += litreMiktar;
                    listBox1.Items.Add(litreMiktar + " lt");
                }
                else
                {
                    galonMiktar = 2576;
                    toplaGalon += galonMiktar;
                    listBox1.Items.Add(galonMiktar + " galon");
                }
                toplaMiktariGoster();

            }
            if (comboBox1.SelectedIndex == 5)
            {
                if (radioButton1.Checked == true)
                {
                    litreMiktar = 2720;
                    toplaLitre += litreMiktar;
                    listBox1.Items.Add(litreMiktar + " lt");
                }
                else
                {
                    galonMiktar = 659;
                    toplaGalon += galonMiktar;
                    listBox1.Items.Add(galonMiktar + " galon");
                }
                toplaMiktariGoster();

            }
            if (comboBox1.SelectedIndex == 6)
            {
                if (radioButton1.Checked == true)
                {
                    litreMiktar = 5.1;
                    toplaLitre += litreMiktar;
                    listBox1.Items.Add(litreMiktar + " lt");
                }
                else
                {
                    galonMiktar = 1.3;
                    toplaGalon += galonMiktar;
                    listBox1.Items.Add(galonMiktar + " galon");
                }
                toplaMiktariGoster();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Toplam Su Ayak İzi : " + (toplaLitre + toplaGalon).ToString());
        }
    }
}
