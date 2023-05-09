using System;
using System.Collections.Generic;
using System.Text;


namespace Credit
{
    class VehicleCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı.");
        }
    }
}
