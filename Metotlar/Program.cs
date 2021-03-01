using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 125;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 15;



            Urun[] urunler = new Urun[] {urun1, urun2 };

            foreach(Urun item in urunler)
            {
                Console.WriteLine(item.Adi+"\n" + item.Fiyati + "\n" + item.Aciklama);
                Console.WriteLine("----------------");
            }
            Console.WriteLine("-----------Metotlar-----");

            SepetManager sepetManager = new SepetManager(); //Instance - nesne oluşturma

            //Encapsilation
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            //sepetManager.Ekle2("Armut","Kastamonu Armutu",12 , 15);
            //sepetManager.Ekle2("Elma", "Yeşil Elma", 18, 15);
            //sepetManager.Ekle2("Sarımsak", "Kastamonu Sarımsağı", 15, 15);
            //2. kullanım da kod tekrarı olacaktır 
            Console.ReadLine();
        }
    }
}
