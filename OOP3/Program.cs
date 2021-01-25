using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasıtKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKredisiManager = new EsnafKredisiManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKredisiManager,new FileLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() {esnafKredisiManager,tasitKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);



        }//interfacelerde diğer class ın referans numarasını tutabiliyor
    }
}
