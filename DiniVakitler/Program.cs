using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiniVakitler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aksiyon aksiyon = new Aksiyon();
            //aksiyon.AksiyonGonder(0, GunlukAksiyonlar.gunes); // gunesin dogusu ile ilgili aksiyonlar
            //aksiyon.AksiyonGonder(0, HaftalikAksiyonlar.cuma, GunlukAksiyonlar.aksam); // cuma gecesi aksiyonlari
            //aksiyon.AksiyonGonder(0, HaftalikAksiyonlar.cuma, GunlukAksiyonlar.sabah); // cuma gunu aksiyonlari
            //aksiyon.AksiyonGonder(0, AylikAksiyonlar.ayOrtasi, GunlukAksiyonlar.sabah); // ayin 13, 14, 15 inde sabah yapilacaklar
            //aksiyon.AksiyonGonder(0, SenelikAksiyonlar.ramazan, 4, GunlukAksiyonlar.aksam); // ramazanin 4 unde gece yapilacak aksiyonlar
            //aksiyon.AksiyonGonder(0, SenelikAksiyonlar.recep, HaftaGunu.persembe, Sira.ilk, GunlukAksiyonlar.aksam); // Recep ayinin ilk persembe gecesi


            var result = Common.HaftaGunleri.GunIleHaftaGunBul(Enums.HaftaGunu.pazar, -(2*7 + 5));

            var tarih = HicriTarih.GunIleTarihBul(170);

            var fark = MiladiTarih.gecenGunSayisi
                (new MiladiTarih.Tarih(17, Enums.AyMiladi.mart, 2024));


            var miladi = new MiladiTarih.Tarih(25, Enums.AyMiladi.subat, 2025);
            var hicri = MiladiTarih.MiladiDenHicriye(miladi);

            Console.WriteLine(result);

            Console.ReadLine(); 
        }
    }
}
