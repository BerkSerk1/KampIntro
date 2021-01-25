using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager kredimanager,ILoggerService loggerService)//Ikredimanager dediğimizde dışardan hangi kredi istediği olursa o krediyi hesaplayacaktır
        {
            //Başvuran bilgilerini değerlendirme
            //
            kredimanager.Hesapla();
            loggerService.Log();

        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
