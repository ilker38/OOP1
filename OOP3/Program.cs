using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kredi New'lemeleri
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            EsnafKredisiManager esnafKredisiManager = new EsnafKredisiManager();
            // Logları New lediğim yer
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new DatabaseLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            /*üstteki gibi değilde alttaki gibi de yazılabilirdi.*/
            IKrediManager ihtiyacKrediManager2 = new IhtiyacKrediManager();
            
            IKrediManager tasitKrediManager2 = new TasitKrediManager();            
            IKrediManager konutKrediManager2 = new KonutKrediManager();

           

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKredisiManager,smsLoggerService);
            
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager};
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
