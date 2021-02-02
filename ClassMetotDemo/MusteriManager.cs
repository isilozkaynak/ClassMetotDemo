using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Ekleme işlemi basladi.");

            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + "sisteme eklendi.");

            Console.WriteLine("Ekleme işlemi bitti.");
 }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Silme işlemi basladi.");

            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + "isimli musteri silindi.");

            Console.WriteLine("Silme işlemi bitti.");
        }

        public void Guncelle(Musteri musteri)
        {
            Console.WriteLine("Guncelleme işlemi basladi.");

            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + "bilgileri guncellendi.");

            Console.WriteLine("Guncelleme işlemi bitti.");
        }

        public void Goruntule(Musteri[] musteriler)
        {
            for (int i = 0; i < musteriler.Length; i++)
            {
                Console.WriteLine(musteriler[i].Ad + " " + musteriler[i].Soyad);
            }
        }
    }
}
