using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();    
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(tasitKrediManager, new List<ILoggerService>() { databaseLoggerService, smsLoggerService});
            Console.WriteLine("-----------------------------------------------");
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), new List<ILoggerService>() { fileLoggerService});


            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, konutKrediManager, tasitKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            

        }
    }
}
