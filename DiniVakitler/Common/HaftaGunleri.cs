using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiniVakitler.Enums;

namespace DiniVakitler.Common
{
    public static class HaftaGunleri
    {
        public static HaftaGunu GunIleHaftaGunBul(HaftaGunu baslangic, int gun)
        {
            int suan = (int)baslangic;
            int kalan = Math.Abs(gun) % 7;

            if (gun < 0) // gecmis
            {
                kalan = 7 - kalan;
            }

            return (HaftaGunu)((suan + kalan) % 7);
        }
    }
}
