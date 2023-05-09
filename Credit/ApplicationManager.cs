using System;
using System.Collections.Generic;
using System.Text;


namespace Credit
{
    class ApplicationManager
    {
        public void MakeAnApplication(ICreditManager creditManager, List<ILoggerService> loggerServices) //Bu tek bir tane kredi türü için hesap yapar.
        {
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void MakeALoanPreInformation(List<ICreditManager> credits)   //Bu birden fazla kredi türü için hesaplama yapar.
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }

        }
    }
}
