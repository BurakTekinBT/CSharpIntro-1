using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //Method injection
        public void BasvuruYap(IKrediManager  krediManager, List<ILoggerService> loggerService) //kredi manager hepsinin refini tuttuğut için ->                                                            
        {                                                   //tüm implement ettiği sınıfların refini çalıştırabilir
                                                            //Başvuran bilgilerini değerlendirme
            krediManager.Hesapla();
            
            foreach(var item in loggerService)
            {
                item.Log();
            }

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach(var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
