using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor-bir metotdur bu clası bir yerde new lersek bu metot otomatik çalışır ctor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            //her newlemede referans değiştiği için eski değerler kaybolur birine tutturmamız lazım -geçicidizi
            T[] tempArray = items;
            items = new T[items.Length + 1];
            //temparray den referans ı yani tuttuğu değerleri geri alma
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            //en sona da ekledğimizi yazdırıcaz asıl eklenmek istenen elemanı şimdi ekledik
            items[items.Length - 1] = item;
        }
    }
}
