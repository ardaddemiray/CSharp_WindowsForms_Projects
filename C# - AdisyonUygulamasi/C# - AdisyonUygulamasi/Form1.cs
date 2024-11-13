using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C____AdisyonUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] yemekFiyatlari = { 50, 60, 75, 85, 90, 80, 80, 100 };
            double[] icecekFiyatlari = { 20, 50, 40, 80, 50, 25, 50, 20, 70, 70, 70 };

            double toplamYemek = 0;
            double toplamIcecek = 0;

            foreach (int index in checkedListBox1.CheckedIndices)
            {
                int icecekIndeks = index;
                toplamIcecek += icecekFiyatlari[icecekIndeks];
            }

            foreach (int index in checkedListBox2.CheckedIndices)
            {
                int yiyecekIndeks = index;
                toplamYemek += yemekFiyatlari[yiyecekIndeks];
            }

            double toplamUcret = toplamYemek + toplamIcecek;
            textBox1.Text = toplamUcret.ToString() + " TL";
            listBox1.Items.Clear();

            foreach (var seciliIcecek in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(seciliIcecek.ToString());
            }

            foreach (var seciliYemek in checkedListBox2.CheckedItems)
            {
                listBox1.Items.Add(seciliYemek.ToString());
            }
        }
    }
}
