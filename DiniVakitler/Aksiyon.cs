using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiniVakitler.Enums;

namespace DiniVakitler
{
    public class Aksiyon
    {
        public void AksiyonGonder(int faz, GunlukAksiyonlar aksiyon)
        {
            
        }

        public void AksiyonGonder(int faz, HaftalikAksiyonlar aksiyon, GunlukAksiyonlar vakit)
        {

        }

        public void AksiyonGonder(int faz, SenelikAksiyonlar aksiyon, int gun, GunlukAksiyonlar vakit)
        {

        }

        public void AksiyonGonder(int faz, AylikAksiyonlar aylik, GunlukAksiyonlar vakit)
        {

        }

        public void AksiyonGonder(int faz, SenelikAksiyonlar aksiyon, HaftaGunu gun, Sira sira, GunlukAksiyonlar vakit) 
        {
            switch(aksiyon)
            {
                case SenelikAksiyonlar.cemaziyelahir:

                    break;
            }
        }

        private void AksiyonRamazan(int faz, int gun)
        {

        }

        private void AksiyonRamazan(int faz, HaftaGunu gun, Sira sira)
        {

        }
    }
}
