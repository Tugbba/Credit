using System;
using System.Collections.Generic;
using System.Text;


namespace Credit
{
    class NeedCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı.");
        }
    }
}

