using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Emre";
            int age = 25;
            Kurs kurs1 = new Kurs();
            //aslında string de int de birer class tır. biz kendi classlarımızı yazabiliriz.

            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 50;


            Kurs kurs2 = new Kurs();

            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Emre";
            kurs2.IzlenmeOrani = 10;

            Kurs kurs3 = new Kurs();

            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "birisi";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.Egitmen + " hoca öğrencilerinie " + kurs1.KursAdi + " eğitimi veriyor. İzlenme oranı : " + kurs1.IzlenmeOrani + " şeklidedir");

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
