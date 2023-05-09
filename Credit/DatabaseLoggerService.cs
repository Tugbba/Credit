using System;
using System.Collections.Generic;
using System.Text;


namespace Credit
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı.");
        }
    }

}
