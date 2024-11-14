using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fibonacciDizisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /*
       Fibonacci sayıları, her sayının kendisinden önceki iki sayının toplamı olduğu bir sayı dizisidir.
       Dizinin her bir sonraki elemanı, kendisinden önceki iki elemanın toplamı olarak bulunur.
        */

        int[] fibonacciSayiDizisi;
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int sayi1=0, sayi2=0;

            if(radioButton1.Checked )
            {
                sayi1 = Convert.ToInt32(textBox1.Text);
                sayi2 = Convert.ToInt32(textBox2.Text);
            }
            else if(radioButton2.Checked )
            {
                sayi1 = 2;
                sayi2 = 1000;
            }

            fibonacciSayiDizisi = fibonacciHesapla(sayi1, sayi2);
        }

        private int[] fibonacciHesapla(int sayi1, int sayi2)
        {
            int[] fibonacciDizi = new int[sayi2 + 1];
            fibonacciDizi[0] = 0;
            fibonacciDizi[1] = 1;

            int baslangicIndeksi = 2;
            while (true)
            {
                fibonacciDizi[baslangicIndeksi] = fibonacciDizi[baslangicIndeksi - 1] + fibonacciDizi[baslangicIndeksi - 2];
                if (fibonacciDizi[baslangicIndeksi] > sayi2)
                {
                    break;
                }
                baslangicIndeksi++;
            }

            int sayac = 0;
            for (int i = 0; i < baslangicIndeksi; i++)
            {
                if (fibonacciDizi[i] >= sayi1)
                {
                    sayac++;
                }
            }

            int[] fibonacciSonuc = new int[sayac];
            int sonucIndeks = 0;
            for (int i = 0; i < baslangicIndeksi; i++)
            {
                if (fibonacciDizi[i] >= sayi1)
                {
                    fibonacciSonuc[sonucIndeks] = fibonacciDizi[i];
                    sonucIndeks++;
                }
            }

            return fibonacciSonuc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(fibonacciSayiDizisi != null)
            {
                for(int i = 0; i < fibonacciSayiDizisi.Length; i++)
                {
                    listBox1.Items.Add("dizi[" + i + "]=" + fibonacciSayiDizisi[i]);
                }
            }
        }
    }
}
