using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DataBesaLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veri Tabanına Loglandı");
        }
    }
}
