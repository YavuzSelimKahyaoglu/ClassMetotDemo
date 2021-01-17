using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public ArrayList musteriler = new ArrayList();
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("-----EKLEME----");
            musteriler.Add(musteri);
            string isim = musteri.Adi + " " + musteri.Soyad;
            Console.WriteLine("Müşteri Başarıyla Eklendi! ("+musteri.Id+":"+isim+")");
            
        }

        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine("-----SİLME-----");
            musteriler.Remove(musteri);
            string isim = musteri.Adi + " "+musteri.Soyad;
            Console.WriteLine("Müşteri Başarıyla Silindi! ("+musteri.Id+":"+isim+")");
            
        }

        public void MusteriListele()
        {
            
            Console.WriteLine("---LİSTELEME---");
            if (musteriler.Count==0)
            {
                Console.WriteLine("Henüz Bir Müşteri Bulunmamaktadır!");
            }
            else
            {
                foreach (Musteri musteri1 in musteriler)
                {
                    string tamlama = musteri1.Id+":"+musteri1.Adi+" "+musteri1.Soyad;
                    Console.WriteLine(tamlama);
                }
            }           
            
        }
    }
}
