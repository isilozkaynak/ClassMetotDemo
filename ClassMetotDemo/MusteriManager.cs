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

        public void Goruntule(Musteri musteri)
        {
            Console.WriteLine("Musteri Id= " + musteri.Id 
                + ", Musteri adi= " + musteri.Ad 
                + ", Musteri soyadi= " + musteri.Soyad
                + ", Musteri telefon= " + musteri.Telefon
                + ", Musteri para miktari=  " + musteri.ParaMiktari
                );
        }
    }
}
