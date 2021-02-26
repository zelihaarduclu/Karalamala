using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        /* MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme, listeleme,silme gibi metotları simule ediniz.*/

        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + musteri.Soyad +" "+ "eklendı");
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+musteri.Soyad+"silindi");
        }
        public void List(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + musteri.Soyad+"listelendi");
        }
        
    }
}
