using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Bir bankada müşteri takibi yapmak istiyorsunuz.
            Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz. (Id,Ad,Soyad....)
            MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme, listeleme,silme gibi metotları simule ediniz.*/

            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "zeliha";
            musteri1.Soyad = "arduçlu";

            Musteri[] musteris = new Musteri[] { musteri1 };
            foreach (var musteri2 in musteris)
            {
                Console.WriteLine(musteri2.Ad+" "+musteri2.Soyad);
            }
            //metodları burada kullanmadım ama belkı daha kapsamlı uygulamalarda kullanırım ama su an program.cs de kullanmıycam 

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
        }
    }
}
