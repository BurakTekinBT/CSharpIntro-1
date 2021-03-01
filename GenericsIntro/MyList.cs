using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //Generic class - çalışabilelceğimiz özel bir tip olabileceğini belirtiyoruz.
    {
        T[] items;
        //constructor // class bir  yerde newlendiği gibi çalışır 
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item) //ben sana ne verirsem istediğim elemanın türü de o dur 
        {
            T[] tempArray = items;
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}
