using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            ////interfacelerde o interfacei implement ettiği classın referansını tutar

            //IKrediManager ihtiyacKrediManager2 = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            //IKrediManager konutKrediManager2 = new KonutKrediManager();
            //konutKrediManager.Hesapla();

            //IKrediManager tasitKrediManager2 = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            Console.WriteLine("Dependency Sornası\n ");
            IKrediManager ihtiyacKrediManager2 = new IhtiyacKrediManager();
            IKrediManager konutKrediManager2 = new KonutKrediManager();
            IKrediManager tasitKrediManager2 = new TasitKrediManager();

            ILoggerService FileLoggerService = new FileLoggerService();

            List<ILoggerService> servisler = new List<ILoggerService>() { FileLoggerService};

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager2, servisler); //Yöntem1
            basvuruManager.BasvuruYap(konutKrediManager2, new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService() });                 //Yöntem2 
            basvuruManager.BasvuruYap(tasitKrediManager2, servisler);

            Console.WriteLine("\nListe Sornası\n ");
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager2, tasitKrediManager2, konutKrediManager2} ;



            basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
