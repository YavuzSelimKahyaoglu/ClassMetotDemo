using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri1 = new Musteri();
            musteri1.Id = 0;
            musteri1.Adi = "Yavuz";
            musteri1.Soyad = "Kahyaoğlu";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1;
            musteri2.Adi = "Selim";
            musteri2.Soyad = "Kahyaoğlu";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 2;
            musteri3.Adi = "Yavuz Selim";
            musteri3.Soyad = "Kahyaoğlu";

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);

            musteriManager.MusteriSil(musteri2);

            musteriManager.MusteriListele();
        }
    }
}
