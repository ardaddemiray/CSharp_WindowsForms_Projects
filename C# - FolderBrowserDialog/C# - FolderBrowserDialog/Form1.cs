using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C____FolderBrowserDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string dosyaAdi, dosyaYolu, dosyaFormati;

        private void olustur_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                dosyaAdi = textBox2.Text;

                if (radioButton1.Checked)
                {
                    dosyaFormati = ".docx";
                }
                else if (radioButton2.Checked)
                {
                    dosyaFormati = ".xlsx";
                }
                else if (radioButton3.Checked)
                {
                    dosyaFormati = ".pptx";
                }

                if (!string.IsNullOrEmpty(dosyaFormati))
                {
                    StreamWriter sw = File.CreateText(dosyaYolu + "\\" + dosyaAdi + dosyaFormati);
                    sw.Close();
                    MessageBox.Show("Oluşturuldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Bir yolu seçiniz.");
                }

            }
        }

        private void yol_btn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                dosyaYolu = folderBrowserDialog1.SelectedPath;
                textBox1.Text = dosyaYolu;
            }
        }

        private void klasorSec_btn_Click_1(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Bir klasör seçiniz.";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string secilenKlasor = folderBrowserDialog1.SelectedPath;
                DirectoryInfo dizinBilgisi = new DirectoryInfo(secilenKlasor);
                FileSystemInfo[] dosyaBilgisi = dizinBilgisi.GetFileSystemInfos();

                foreach (FileSystemInfo dosya in dosyaBilgisi)
                {
                    if (dosya is DirectoryInfo)
                    {
                        listBox1.Items.Add("Klasör: " + dosya.Name);
                    }
                    else if (dosya is FileInfo)
                    {
                        listBox1.Items.Add("Dosya: " + dosya.Name);
                    }
                }

                label3.Text = secilenKlasor;
                dosyaYolu = secilenKlasor;

            }
        }

        private void resmi_goster_Click(object sender, EventArgs e)
        {
            string[] resimDosyalari = Directory.GetFiles(dosyaYolu, "*.jpg");

            foreach (string dosya in resimDosyalari)
            {
                Image resim = Image.FromFile(dosya);
                ımageList1.Images.Add(resim);
            }

            if (ımageList1.Images.Count > 0)
            {
                pictureBox1.Image = ımageList1.Images[0];
            }
        }

        int resimGecisleri = 0;



        private void onceki_resim_Click(object sender, EventArgs e)
        {
            resimGecisleri--;
            if (resimGecisleri < 0)
            {
                resimGecisleri = ımageList1.Images.Count - 1;
            }
            pictureBox1.Image = ımageList1.Images[resimGecisleri];
        }

        private void sonraki_resim_Click(object sender, EventArgs e)
        {
            resimGecisleri++;
            if (resimGecisleri == ımageList1.Images.Count)
            {
                resimGecisleri = 0;
            }
            pictureBox1.Image = ımageList1.Images[resimGecisleri];
        }


    }
}
