using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new  MyList<string>(); //buradan hangi değişkeni verirsen MyListteki T ona dönüşür
            isimler.Add("Burak");

            Console.ReadLine();
        }
    }
}
