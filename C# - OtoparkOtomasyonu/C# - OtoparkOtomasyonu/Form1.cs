using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C____OtoparkOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        otopark park;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                park = new otopark(textBox1.Text, Convert.ToInt32(textBox2.Text));
                label3.Text = "Park Alanı oluşturuldu. Park yeri sayısı : " + park.bosparkOgren();
            }
            catch
            {
                label3.Text = "Park Alanı oluşturulamadı. Bilgileri kontrol ediniz!";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = radioButton2.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kisaTarife = 1;

            if (radioButton1.Checked)
            {
                park.parkRezerve(true, kisaTarife);
                label3.Text = "1. saatlik park yeri rezerve edildi. Kalan park yeri sayısı : " + park.bosparkOgren();
            }
            else if (radioButton2.Checked)
            {
                int uzunTarife = Convert.ToInt32(textBox3.Text);
                park.parkRezerve(false, uzunTarife);
                label3.Text = uzunTarife + " saatlik park yeri rezerve edildi. Kalan park yeri sayısı : " + park.bosparkOgren();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int kisaTarife = 1;
            if (radioButton1.Checked)
            {
                park.rezerveIptal(true, kisaTarife);
                label3.Text = "1 saatlik park yeri rezervesi iptal edildi. Kalan park yeri sayısı : " + park.bosparkOgren();
            }
            else if (radioButton2.Checked)
            {
                int uzunTarife = Convert.ToInt32(textBox3.Text);
                park.rezerveIptal(false, uzunTarife);
                label3.Text = uzunTarife + " saatlik park yeri rezervesi iptal edildi. Kalan park yeri sayısı : " + park.bosparkOgren();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Text = "Boş park yeri sayısı : " + park.bosparkOgren();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Text = "Geliriniz : " + park.bakiyeOgren();
        }

       
    }
}
