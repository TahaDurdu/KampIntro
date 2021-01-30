using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veri Tabanına Loglandı");
        }
    }
}
