using ClassMetotDemo;
using System;

namespace classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1= new Musteri();
            musteri1.MusteriAdi = "Makbule";
            musteri1.MusteriSoyadi = "Sarı";
            musteri1.MusteriId = 85;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Mustafa";
            musteri2.MusteriSoyadi = "Yılmaz";
            musteri2.MusteriId = 86;

            MusteriManager musteriManager1 = new MusteriManager();
            musteriManager1.Ekleme(musteri1);
            musteriManager1.Silme(musteri1);    
            musteriManager1.Listeleme(musteri1);

           
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2};

            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAdi + musteri.MusteriSoyadi + musteri.MusteriId);

            }

        }
    }
}