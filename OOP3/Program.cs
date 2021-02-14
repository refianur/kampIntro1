using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //IKrediManager
            IhtiyacKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            TasıtKrediManager tasıtKrediManager = new TasıtKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ıhtiyacKrediManager, new DatabaseLoggerService());

            List<IKrediManager> krediler = new List<IKrediManager>() { ıhtiyacKrediManager, tasıtKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);









        }
    }
}
