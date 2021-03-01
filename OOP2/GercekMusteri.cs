using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class GercekMusteri : Musteri  //varlık - entity bunlar içerisinde operasyonlar olmaz
    {                               //Tüzel ve Gerçek müşteri böylelikle bir Musteri classı sayılır
                                    //Musteride olanlar gercek ve tüzel müşteride de var 


        public string Adi { get; set; }

        public string Soyadi { get; set; }
        public string TcNo { get; set; }
    }
}
