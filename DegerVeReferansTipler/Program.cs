using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 = 30, sayi2 =65;

            //int, decimal, bool, double, float = değer tip, value type
            // string, array, class, interface = referrence type, referans tip

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] =999

            //değer tipler bellliğin stack kısmında  gerçekleşir.
            //referans tiplerde değişken adı stackte tutulur fakat new dediğimiz anda heap'te değer oluşturup değeri orada oluşturur
            //stackteki referans tip heapteki adresi işaret eder.
            //new demek heap yeni yer oluştur demek
            //verillen örnektede sayilar1, sayilar2 nin işaret ettiği yeri gösterir.
            //heapte boşta kalan değer garbage colllector tarafındna temizlenir.



        }
    }
}
