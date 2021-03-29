using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Emre", "Merve", "Ahmet Eren", "Dilek", "Hakan" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[4]);
            //fakat buraya
            //isimler[5] = "abcdef";
            //diye bir şey koyup ardından
            //Console.WriteLine(isimler[5]);
            //yaparsak out of range hatası alırız çünkü array ler sadece ilk oluştuduğumuz yapıda sınırlarda takılı kalır. 
            //arraylar de başta yaptığımız kadar veriye ulaşırız. daha fazla yapmak için new leriz ama bu seferde önceki verilerimiz kaybolur.Bu yüzden;
            //java ve c# da array çok kullanılmaz. koleksiyonlar kullanılır. YANİ ====>

            //burada List yazıp mouse ile beklediğimizde System.Collections.Generic i kullanma butonuna tıklarız. Çünkü bunun içerisindeki sınıfı kullanıyoruz.

            List<string> isimler2 = new List<string>() { "Emre", "Merve", "Ahmet Eren", "Dilek", "Hakan" };
            //küçüktür büyüktür işaretlerine generic yapıda denir.
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            Console.WriteLine(isimler2[4]);
            isimler2.Add("abcdef");
            //buradaki add collections.generic kütüphanesinden geldi. 
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);


        }
    }
}
