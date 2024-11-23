using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C____OtoparkOtomasyonu
{
    class otopark
    {
        int toplamParkYeriSayisi;
        int bosParkYeriSayisi;
        double gelir;
        string parkAlanNo;

        const double kisaTarife = 20.00;
        const double uzunTarife = 18.00;

        public otopark(string alanAdi, int parkYeriSayisi)
        {
            toplamParkYeriSayisi = parkYeriSayisi;
            parkAlanNo = alanAdi;
            bosParkYeriSayisi = toplamParkYeriSayisi;
            gelir = 0;
        }

        public void parkRezerve(bool tarife, int saat)
        {
            bosParkYeriSayisi--;
            if (tarife)
            {
                gelir += kisaTarife * saat;
            }
            else
            {
                gelir += saat * uzunTarife;
            }
        }

        public void rezerveIptal(bool tarife, int saat)
        {
            bosParkYeriSayisi++;
            if (tarife)
            {
                gelir -= kisaTarife * saat;
            }
            else
            {
                gelir -= saat * uzunTarife;
            }
        }

        public int bosparkOgren()
        {
            return bosParkYeriSayisi;
        }

        public double bakiyeOgren()
        {
            return gelir;
        }
    }
}
