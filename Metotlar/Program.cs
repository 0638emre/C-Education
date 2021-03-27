using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyati = 5;
            urun1.Aciklama = "amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "armut";
            urun2.Fiyati = 7;
            urun2.Aciklama = "anadolu armudu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun x in urunler)
            {
                Console.WriteLine(x.Adi);
                Console.WriteLine(x.Fiyati);
                Console.WriteLine(x.Aciklama);
                Console.WriteLine("----------------------");
            }

            Console.WriteLine("--------------------Metotlar------------------------");

            //instance - örnekleme
            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun1);


        }
    }
}
