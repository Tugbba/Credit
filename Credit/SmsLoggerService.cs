using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Credit
{
    class SmsLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Sms yollandı.");
        }
    }
}
