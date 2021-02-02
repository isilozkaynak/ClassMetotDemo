using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 111;
            musteri1.Ad = "Isil";
            musteri1.Soyad = "Ozkaynak";
            musteri1.Telefon = "123456789";
            musteri1.ParaMiktari = 100.000;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 112;
            musteri2.Ad = "Ayse";
            musteri2.Soyad = "Yilmaz";
            musteri2.Telefon = "987654321";
            musteri2.ParaMiktari = 50.000;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 113;
            musteri3.Ad = "Mehmet";
            musteri3.Soyad = "Kara";
            musteri3.Telefon = "543219876";
            musteri3.ParaMiktari = 75.500;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
         

            MusteriManager musterimanager = new MusteriManager();
            Console.WriteLine("Ekle fonksiyonu:");
            musterimanager.Ekle(musteri1);
            musterimanager.Ekle(musteri2);
            musterimanager.Ekle(musteri3);
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine("Guncelle fonksiyonu(musteri1 guncellendi):");
            musterimanager.Guncelle(musteri1);
            Console.WriteLine("-------------------------------------------");


            Console.WriteLine("Sil fonksiyonu(musteri3 silindi):");
            musterimanager.Sil(musteri3);
            Console.WriteLine("-------------------------------------------");


            Console.WriteLine("Goruntule fonksiyonu:");
            musterimanager.Goruntule(musteriler);
        }
    }
}
