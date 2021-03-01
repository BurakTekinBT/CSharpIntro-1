using System;

namespace ClasssIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Burak";
            int yas = 27;

            Kurs kurs = new Kurs(); //class'a değer atama
            kurs.KursAdi = " C# ";
            kurs.Egitmen = "Engin Demirog";
            kurs.IzlenmeOrani = 68000;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = " Unity ";
            kurs2.Egitmen = "Burak Tekin";
            kurs2.IzlenmeOrani = 1000;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = " Unreal ";
            kurs3.Egitmen = "Buraticus";
            kurs3.IzlenmeOrani = 12000;

            Console.WriteLine(kurs.KursAdi + " " + kurs.Egitmen + " " + kurs.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] { kurs, kurs2, kurs3 };

            foreach(Kurs course in kurslar)
            {
                Console.WriteLine(course.KursAdi + " "  + course.Egitmen + " " + course.IzlenmeOrani);
            }

            Console.ReadLine();
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
