using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsFormAdamAsmacaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] hayvanlar = { "akrep", "aslan", "balık", "böcek", "domuz", "geyik", "goril", "horoz", "karga", "koyun", "köpek", "kumru", "sığır", "sinek", "tavuk", "tilki", "yılan", "yunus", "zebra" };
        Random hayvan = new Random();
        string secilenHayvan;
        int index;
        int kalanCan = 5;
        private void Form1_Load(object sender, EventArgs e)
        {
            index = hayvan.Next(0,hayvanlar.Length);
            secilenHayvan = hayvanlar[index];
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adamAsmacaOynaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
            label7.Text = kalanCan.ToString();
            progressBar1.Value = 0;
            timer1.Stop();
            pictureBox1.Image = null;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            timer1.Start();

            Label[] labelList = new Label[] { label2, label3, label4, label5, label6 };

            char girilenHarf = textBox2.Text.ToCharArray()[0];

            bool harfEslendiMi = false;

            for (int i = 0; i < secilenHayvan.Length; i++)
            {
                if (secilenHayvan[i] == girilenHarf)
                {
                    harfEslendiMi= true;
                    labelList[i].Text = girilenHarf.ToString();
                }
            }

            if (!harfEslendiMi) {
                kalanCan--;
                label7.Text=kalanCan.ToString();

                if (kalanCan == 0)
                {
                    MessageBox.Show("Can hakkınız bitti, oyunu kaybettiniz!");
                    pictureBox1.Image = ımageList1.Images[index];
                }

                textBox2.Clear();
                
                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value >= progressBar1.Maximum)
            {
               timer1.Stop();
                textBox2.Enabled = false;
                textBox1.Visible = true;
                MessageBox.Show("Süreniz doldu. Lütfen tahmin ediniz");
            }
            else
            {
                progressBar1.Value++;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Enter)
            {
                string tahmin = textBox1.Text.ToLower();

                if(tahmin == secilenHayvan.ToLower())
                {
                    MessageBox.Show("Tebrikler, doğru tahmin ettiniz! Kelime : " + secilenHayvan.ToUpper());
                    pictureBox1.Image = ımageList1.Images[index];

                }
                else
                {
                    MessageBox.Show("Tahmininiz yanlış! Doğru kelime : " + secilenHayvan.ToUpper());
                    pictureBox1.Image = ımageList1.Images[index];

                }
            }
        }
    }
}
