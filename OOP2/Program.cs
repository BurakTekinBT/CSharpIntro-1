using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;      //MusteriNo ve Id, gerçek müşteri değil müşteri sınıfından gelme 
            musteri1.MusteriNo = " 12345"; 
            musteri1.Adi = "Burak";
            musteri1.Soyadi = "Tekin";
            musteri1.TcNo = "123214123";

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;      //MusteriNo ve Id, gerçek müşteri değil müşteri sınıfından gelme 
            musteri2.MusteriNo = " 12345";
            musteri2.SirketAdi = "Valve";
            musteri2.VergiNo= "123214123";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri(); //Üst sınıfları alt sınıfları tutabilir.
                                                   //Musteri  hem gercek hem tüzel müşteri referansını tutabiliyor.
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);  // Ekle içerisine Musteri sınıfından veri alıyordu 
            musteriManager.Ekle(musteri2);  // Tuzel ve gerçek inhterit edildiği böyle atabildi.

            //eger bir base sınıf varsa o yer tutucudur.

            //Gerçek - Tüzel Müşteri tipleri ikisi de farklı class ama ikisi de müşteri
            // SOLID - 



        }
    }
}
