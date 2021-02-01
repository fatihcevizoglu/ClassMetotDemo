using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        Musteri musteri = new Musteri();

        public void MusteriEkle()
        {
            musteri.Id = 15;
            musteri.Adı = "Ali";
            musteri.Soyadı = "Yıldız";
            Console.WriteLine("-------------- Müşteriler Eklendi --------------");

        }

        public void MusteriList()
        {
            Console.WriteLine("-------------- Müşteri Listesi --------------");
            Console.WriteLine(musteri.Id);
            Console.WriteLine(musteri.Adı);
            Console.WriteLine(musteri.Soyadı);
        }
        
        public void MusteriSil()
        {
            musteri.Id = 0;
            musteri.Adı = " ";
            musteri.Soyadı = " ";
            Console.WriteLine("-------------- Müşteriler Silindi --------------");
            MusteriList();

        }

    }
}
