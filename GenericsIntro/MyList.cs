using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items = new T[0];
                
        }
        public void add(T item)
        {
            T[] tempArray = items;         //geçiçidizi
            items = new T[items.Length + 1];//eleman sayısı 1 arttı
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
