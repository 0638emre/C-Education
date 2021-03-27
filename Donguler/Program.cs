using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //array-dizi

            string[] kurslar = new string[] { "c# eğitimi", "python eğitimi", "java eğitimi", "c++ eğitimi", "javascript eğitimi"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);           
            }

            Console.WriteLine("/////////////////////////////////////////////////////");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
