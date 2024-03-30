using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiniVakitler.Enums;

namespace DiniVakitler
{
    public static class HicriTarih
    {
        public static readonly Tarih referansTarih = new Tarih
        {
            sene = 1445,
            ay = Ay.muharrem,
            ayGun = 1,
            haftaGunu = HaftaGunu.carsamba
        };

        public static Tarih GunIleTarihBul(int gun)
        {
            if (gun < 0) // TODO: referans tarihten geriye gidildiginde donulecek tarihi belirle
            {
                return new Tarih();
            }
            else if(gun == 0)
            {
                return referansTarih;
            }
            else if(gun < 29)
            {
                return new Tarih
                {
                    sene = referansTarih.sene,
                    ay = referansTarih.ay,
                    ayGun = referansTarih.ayGun + gun,
                    haftaGunu = Common.HaftaGunleri.GunIleHaftaGunBul(referansTarih.haftaGunu, gun)

                };
            }
            else if(gun == 29)
            {
                return new Tarih
                {
                    sene = referansTarih.sene,
                    ay = (Ay)((int)referansTarih.ay + 1),
                    ayGun = 1,
                    haftaGunu = Common.HaftaGunleri.GunIleHaftaGunBul(referansTarih.haftaGunu, gun)
                };
            }
            else // gun > 29 ise
            {

                int ayIndis = 0;
                int _gun = gun;
                foreach(int ayUzunluk in HicriayUzunluklari.aylar)
                {
                    gun -= ayUzunluk;

                    if(gun < 0)
                    {
                        gun += ayUzunluk;
                        break;
                    }

                    ayIndis++;

                    if(gun == 0)
                    {
                        break;
                    }
                }

                gun++;

                return new Tarih
                {
                    sene = referansTarih.sene + (int)(ayIndis / 12),
                    ay   = (Ay)((int)ayIndis % 12),
                    ayGun = gun,
                    haftaGunu = Common.HaftaGunleri.GunIleHaftaGunBul(referansTarih.haftaGunu, _gun)
                };

            }

        }

        public struct Tarih
        {
            public int ayGun;
            public int sene;
            public HaftaGunu haftaGunu;
            public Ay ay;

            public Tarih(int ag, Ay a, int s, HaftaGunu hg)
            {
                ayGun = ag;
                sene = s;
                haftaGunu = hg;
                ay = a;
            }

        }

    }



}
