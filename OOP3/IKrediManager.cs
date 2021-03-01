using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager //Interfaceleri birbirinin alternatifi olan fakat kod içerikleri farklı olan durumlarda 
    {                       //kullanırız. 

        public void Hesapla(); //imzanın aynı gövdenin farklı olduğu durumlarda biz interface kullanılırz.


        public void BiSeyYap();

    }
}
