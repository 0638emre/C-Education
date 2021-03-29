using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    //burada generic yapının içersiinde T harfi vermemizin sebebi ' ben sana ne verirsem ' sen de bana onu ver. stringse string int se int.
    class MyList<T>
    {
        //constructor oluşturuyoruz.
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        //otomatikman yukarıda MyList adında bir items listesi oluşturduk. Kendimize ait MyList classı içerisinde.
        public void Add(T item)
        {
            //şimdi Add fonksiyonumuzu yazalım. items listemize bir item ekleme fonksiyonu.
            T[] tempArray = items;
            //burası önemli. temp array adında bir arraylist oluşturuyoruz ki önceden girdiğimiz verileri heap bölümünde tutsun. yoksa newleyeceğiz, silinir.
            items = new T[items.Length+1];
            //burada items listemize 1 adet add işlevi uyguluyoruz fakat new lediğimiz için önceki heap bölümümüzü sildi. fakat biz onu tempArray ile güvence altına aldık.

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            //burada ise tempArraydaki her itemimizi al ve items adlı listemizin içerisine koy diyoyruz. yani önceki koruduğumuz verileri aldık ve items listemizdeki yerine koyduk.

            items[items.Length - 1] = item;
            //ve son olarak items on son elemanını item adlı yerine koymuş oluyoruz ve add fonksiyonumuz tamamlanmış oluyor.
        }
    }
}
