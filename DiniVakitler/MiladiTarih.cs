using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiniVakitler.Enums;
namespace DiniVakitler
{
    public static class MiladiTarih
    {
        public static readonly Tarih referansTarih = new Tarih
            (19, AyMiladi.temmuz, 2023, HaftaGunu.carsamba);

        public static int gecenGunSayisi(Tarih tarih)
        {
            var ilkTarih = new DateTime(referansTarih.sene, (int)referansTarih.ay + 1, referansTarih.ayGun);
            var sonTarih = new DateTime(tarih.sene, (int)tarih.ay + 1, tarih.ayGun);
            TimeSpan fark = sonTarih - ilkTarih;
            return fark.Days;
        }

        public static HicriTarih.Tarih MiladiDenHicriye(Tarih tarih)
        {
            return HicriTarih.GunIleTarihBul(gecenGunSayisi(tarih));
        }

        public class Tarih
        {
            public int ayGun;
            public int sene;
            public HaftaGunu haftaGunu;
            public AyMiladi ay;

            public Tarih(int ag, AyMiladi a, int s)
            {
                ayGun = ag;
                sene = s;
                ay = a;
                haftaGunu = Common.HaftaGunleri.GunIleHaftaGunBul(referansTarih.haftaGunu, gecenGunSayisi(this));
            }

            public Tarih(int ag, AyMiladi a, int s, HaftaGunu hg)
            {
                ayGun = ag;
                sene = s;
                ay = a;
                haftaGunu = hg;
            }

        }
    }
}
