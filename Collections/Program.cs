using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Engin", "Murat", "Halil", "Burak" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            Console.WriteLine("******Diziler Bitti************\n");
            //isimler[4] = "ilker"; // dizileri genişletemiyoruz ilk başta kaç elemanlı tanımlandıysa o kadar eleman alır.
            //Console.WriteLine(isimler[4]);
            //Array pek tercih edilmez bunun yerine koleksiyon kullanılır.

            // Yöntem 1 
            //List<string> isimler2 = new List<string>();
            //isimler2.Add("Burak"); // Yöntem 1 

            // Yöntem 2 
            List<string> isimler2 = new List<string>() { "Engin", "Murat", "Halil", "Burak"  };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlyas");
            Console.WriteLine(isimler2[4]);
            //Bir kere atandıktan sonra istediğimiz gibi genişletebiliyoruz.




            Console.ReadLine();


        }
    }
}
