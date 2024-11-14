using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C____CokIslevliUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KategorileriBaslat();
            YayinEvleriBaslat();
            DataGridViewBaslat();
            yontemBox.Items.AddRange(Enum.GetNames(typeof(SifrelemeTuru)));
        }

        // MATEMATIKSEL ISLEMLER
        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(math1.Text);
            double y = Convert.ToDouble(math2.Text);
            double z = Convert.ToDouble(math3.Text);

            double islemSonucu = Math.Sqrt(x) + (y / (x * x * x)) + (x * y * z);

            mathList.Items.Add(islemSonucu.ToString());

            math1.Clear();
            math2.Clear();
            math3.Clear();
        }

        // SMITH SAYISI BULMA

        Random random = new Random();
        int[] sayilar = new int[10];

        int mevcutIndex = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = random.Next(1, 101);

            if (mevcutIndex > 0 && mevcutIndex < 10)
            {
                uretilenTxt.AppendText(" ");
            }
            uretilenTxt.AppendText(sayi.ToString());

            if (SmithSayisiMi(sayi))
            {
                MessageBox.Show(sayi + " bir smith sayısıdır");
            }
            else
            {
                MessageBox.Show(sayi + " bir smith sayısı değildir");
            }

            sayilar[mevcutIndex] = sayi;
            mevcutIndex++;

            string smithDurumu;
            if (mevcutIndex == 10)
            {
                uretilenList.Items.Clear();
                foreach (var item in sayilar)
                {
                    if (SmithSayisiMi(item))
                    {
                        smithDurumu = " (Smith)";
                    }
                    else
                    {
                        smithDurumu = " (Smith değil)";
                    }
                    uretilenList.Items.Add(item.ToString() + smithDurumu);
                }
            }
        }

        private int BasamakToplami(int sayi)
        {
            int toplam = 0;
            while (sayi > 0)
            {
                toplam += sayi % 10;
                sayi /= 10;
            }
            return toplam;
        }

        private int AsalCarpanlarToplami(int sayi)
        {
            int toplam = 0;
            int carpan = 2;

            while (sayi > 1)
            {
                while (sayi % carpan == 0)
                {
                    toplam += BasamakToplami(carpan);
                    sayi /= carpan;
                }
                carpan++;
            }
            return toplam;

        }

        private bool AsalMi(int sayi)
        {
            if (sayi <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private bool SmithSayisiMi(int sayi)
        {
            if (AsalMi(sayi))

                return false;

            int basamakToplami = BasamakToplami(sayi);

            int asalCarpanlarinBasamakToplami = AsalCarpanlarToplami(sayi);


            return basamakToplami == asalCarpanlarinBasamakToplami;

        }

        // STRUCT YAPISI ILE KUTUPHANE UYGULAMASI
        public struct Kitap
        {
            public string KitapAdi;
            public string KitapKodu;
            public string YazarAdi;
            public string Kategori;
            public string YayinEvi;
            public DateTime BasimTarihi;
        }

        private List<Kitap> kitaplar = new List<Kitap>();

        private void KategorileriBaslat()
        {
            string[] kategoriler =
            {
                "Askeri Bilimler", "Astronomi ve Uzay", "Bilgisayar", "Çevre Bilimleri", "Dil ve Edebiyat",
                "Eğitim", "Ekonomi ve Finans", "Enerji", "Felsefe, Psikoloji ve Din", "Fizik", "Genel Çalışmalar",
                "Güzel Sanatlar", "Hukuk", "İşletme ve Yönetim", "Kimya", "Kütüphanecilik", "Matematik ve İstatistik",
                "Medya ve İletişim", "Mimarlık ve Tasarım", "Mühendislik ve Teknoloji", "Müze ve Kültürel Çalışmalar",
                "Müzik", "Politika ve Uluslararası İlişkiler", "Sosyoloji", "Spor, Seyahat ve Turizm", "Tarih",
                "Tarım ve Biyoloji", "Tıp"
            };
            kategoriBox.Items.AddRange(kategoriler);
        }

        private void YayinEvleriBaslat()
        {
            string[] yayinEvleri =
            {
                "PEGASUS YAYINLARI", "YEDİ KALEM YAYINLARI", "PROFİL KİTAP", "MAVİ AĞAÇ YAYINLARI",
                "MEYDAN YAYINLARI", "TİMAŞ YAYINLARI", "EKOL YAYINLARI", "SAVAŞ YAYINLARI",
                "HAYAT YAYINLARI", "NG YAYINCILIK", "NASİHAT YAYINLARI", "YEDİ TEPE YAYINLARI",
                 "ATAÇ YAYINLARI", "DEDELUS YAYINLARI", "DOĞU BATI YAYINLARI", "SERVER YAYINLARI","İNSAN YAYINLARI"
            };
            yayineviBox.Items.AddRange(yayinEvleri);
        }

        private void DataGridViewBaslat()
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "Kitap Adı";
            dataGridView1.Columns[1].Name = "Kitap Kodu";
            dataGridView1.Columns[2].Name = "Yazar Adı";
            dataGridView1.Columns[3].Name = "Kategori";
            dataGridView1.Columns[4].Name = "Yayın Evi";
            dataGridView1.Columns[5].Name = "Basım Tarihi";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kitap yeniKitap = new Kitap()
            {
                KitapAdi = kitapAd.Text,
                KitapKodu = kitapKod.Text,
                YazarAdi = yazarAd.Text,
                Kategori = kategoriBox.SelectedItem.ToString(),
                YayinEvi = yayineviBox.SelectedItem.ToString(),
                BasimTarihi = dateTimePicker1.Value

            };

            kitaplar.Add(yeniKitap);
            KitapGrideEkle(yeniKitap);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                row.Cells[0].Value = kitapAd.Text;
                row.Cells[1].Value = kitapKod.Text;
                row.Cells[2].Value = yazarAd.Text;
                row.Cells[3].Value = kategoriBox.SelectedItem.ToString();
                row.Cells[4].Value = yayineviBox.SelectedItem.ToString();
                row.Cells[5].Value = dateTimePicker1.Value.ToShortDateString();
            }
        }

        private void KitapGrideEkle(Kitap kitap)
        {
            string[] satir =
            {
                kitap.KitapAdi, kitap.KitapKodu, kitap.YazarAdi, kitap.Kategori,
                kitap.YayinEvi, kitap.BasimTarihi.ToShortDateString()
            };
            dataGridView1.Rows.Add(satir);
        }

        // SIFRELEME VE DESIFRELEME UYGULAMASI

        public enum SifrelemeTuru
        {
            Sezar,
            AnahtarliSezar,
            Vigenere,
            Dogrusal
        }

        private string SezarSifrele(string metin)
        {
            int kaydirmaMiktari = 3;
            char[] karakterler = metin.ToCharArray();

            for (int i = 0; i < karakterler.Length; i++)
            {
                karakterler[i] = (char)(karakterler[i] + kaydirmaMiktari);
            }
            return new string(karakterler);
        }

        private string SezarDesifre(string sifreliMetin)
        {
            int kaydirmaMiktari = 3;
            char[] karakterler = sifreliMetin.ToCharArray();

            for (int i = 0; i < karakterler.Length; i++)
            {
                karakterler[i] = (char)(karakterler[i] - kaydirmaMiktari);
            }
            return new string(karakterler);
        }

        private string AnahtarliSezarSifrele(string metin, string anahtar)
        {
            int kaydirmaMiktari = Convert.ToInt32(anahtar);
            char[] karakterler = metin.ToCharArray();

            for (int i = 0; i < karakterler.Length; i++)
            {
                karakterler[i] = (char)(karakterler[i] + kaydirmaMiktari);
            }
            return new string(karakterler);
        }

        private string AnahtarliSezarDesifre(string sifreliMetin, string anahtar)
        {
            int kaydirmaMiktari = Convert.ToInt32(anahtar);
            char[] karakterler = sifreliMetin.ToCharArray();

            for (int i = 0; i < karakterler.Length; i++)
            {
                karakterler[i] = (char)(karakterler[i] - kaydirmaMiktari);
            }
            return new string(karakterler);
        }

        private string VigenereSifrele(string metin, string anahtar)
        {
            string sifreliMetin = "";
            int anahtarUzunlugu = anahtar.Length;
            int metinUzunlugu = metin.Length;

            for (int i = 0; i < metinUzunlugu; i++)
            {
                char metinKarakteri = metin[i];
                char anahtarKarakteri = anahtar[i % anahtarUzunlugu];

                char sifrelenmisKarakter = (char)(((metinKarakteri + anahtarKarakteri) % 26) + 'A');

                sifreliMetin += sifrelenmisKarakter;
            }
            return sifreliMetin;
        }

        private string VigenereDesifre(string sifreliMetin, string anahtar)
        {
            string cozulmusMetin = "";
            int anahtarUzunlugu = anahtar.Length;
            int sifreliMetinUzunlugu = sifreliMetin.Length;

            for (int i = 0; i < sifreliMetinUzunlugu; i++)
            {
                char sifreliKarakter = sifreliMetin[i];
                char anahtarKarakteri = anahtar[i % anahtarUzunlugu];

                char cozulmusKarakter = (char)(((sifreliKarakter - anahtarKarakteri + 26) % 26) + 'A');

                sifreliMetin += cozulmusKarakter;
            }
            return cozulmusMetin;

        }

        private string DogrusalSifrele(string metin)
        {
            char[] karakterler = metin.ToCharArray();

            for (int i = 0; i < karakterler.Length; i++)
            {
                karakterler[i] = (char)((karakterler[i] - 'A' + 3 + 26) % 26 + 'A');
            }

            return new string(karakterler);
        }

        private string DogrusalDesifre(string sifreliMetin)
        {
            char[] karakterler = sifreliMetin.ToCharArray();

            for (int i = 0; i < karakterler.Length; i++)
            {
                karakterler[i] = (char)((karakterler[i] - 'A' - 3 + 26) % 26 + 'A');
            }

            return new string(karakterler);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string metin = metinTxtBox.Text;
            string anahtar = anahtarTxtBox.Text;

            SifrelemeTuru tur;
            if (!Enum.TryParse(yontemBox.SelectedItem.ToString(), out tur))
            {
                MessageBox.Show("Geçersiz şifreleme türü seçildi!");
                return;
            }

            string sifrelenmisMetin = "";

            switch (tur)
            {
                case SifrelemeTuru.Sezar:
                    sifrelenmisMetin = SezarSifrele(metin);
                    break;
                case SifrelemeTuru.AnahtarliSezar:
                    sifrelenmisMetin = AnahtarliSezarSifrele(metin, anahtar);
                    break;
                case SifrelemeTuru.Vigenere:
                    sifrelenmisMetin = VigenereSifrele(metin, anahtar);
                    break;
                case SifrelemeTuru.Dogrusal:
                    sifrelenmisMetin = DogrusalSifrele(metin);
                    break;
                default:
                    MessageBox.Show("Geçersiz şifreleme türü");
                    return;
            }
            sifreliTxtBox.Text = sifrelenmisMetin;

            string sifreGoster = tur.ToString() + " - " + sifrelenmisMetin;
            sifregosterList.Items.Add(sifreGoster);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string secilenSifre = sifregosterList.SelectedItem.ToString();
            if (secilenSifre == null)
            {
                MessageBox.Show("Lütfen çözülecek şifreyi seçin!");
                return;
            }

            string[] parcalar = secilenSifre.Split(new string[] { " - " }, StringSplitOptions.None);
            if (parcalar.Length != 2)
            {
                MessageBox.Show("Geçersiz İşlem");
                return;
            }

            string turSatiri = parcalar[0];
            string sifreliMetin = parcalar[1];

            SifrelemeTuru tur;
            if (!Enum.TryParse(turSatiri, out tur))
            {
                MessageBox.Show("Geçersiz şifreleme türü seçildi");
                return;
            }

            string cozulmusMetin = "";

            switch (tur)
            {
                case SifrelemeTuru.Sezar:
                    cozulmusMetin = SezarDesifre(sifreliMetin);
                    break;
                case SifrelemeTuru.AnahtarliSezar:
                    cozulmusMetin = AnahtarliSezarDesifre(sifreliMetin, anahtarTxtBox.Text);
                    break;
                case SifrelemeTuru.Vigenere:
                    cozulmusMetin = VigenereDesifre(sifreliMetin, anahtarTxtBox.Text);
                    break;
                case SifrelemeTuru.Dogrusal:
                    cozulmusMetin = DogrusalDesifre(sifreliMetin);
                    break;
                default:
                    MessageBox.Show("Geçersiz şifreleme türü seçildi!");
                    return;
            }
            metinTxtBox.Text = cozulmusMetin;
        }
    }

    


}
