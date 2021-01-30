using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            IKrediBaseManager  ıhtiyacKrediManager = new IhtiyacKrediManager();
            IKrediBaseManager taşıtKrediManager = new TaşıtKrediManager();
            IKrediBaseManager konutKrediManager = new KonutKrediManager();
                
            ILoggerService databaseLoggerService = new DataBesaLoggerService();
            ILoggerService filelogerservice = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(taşıtKrediManager, databaseLoggerService);

            List<IKrediBaseManager> krediler = new List<IKrediBaseManager>() {ıhtiyacKrediManager,taşıtKrediManager};

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
           
        }
    }
}
