using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        public void Ekleme(Musteri musteri) 
        {
            Console.WriteLine(musteri.MusteriAdi  +  musteri.MusteriSoyadi  +  musteri.MusteriId  +  "Müşteri Eklendi!");
        } 
        public void Silme (Musteri musteri) 
        {
            Console.WriteLine(musteri.MusteriAdi  +  musteri.MusteriSoyadi  +  musteri.MusteriId  +  "Müşteri silindi!");
        }
        public void Listeleme(Musteri musteri) 
        {
            Console.WriteLine("Id:"  +  musteri.MusteriId  +  "\nAdı:" + musteri.MusteriAdi  +  "\nSoyadi:" + musteri.MusteriSoyadi);
        }
    }
}
