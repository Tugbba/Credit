using System;
using System.Collections.Generic;
using System.Text;


namespace Credit
{
    class HousingCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı.");
        }
    }
}
