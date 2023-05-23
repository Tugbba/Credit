namespace Credit
{

    class Program
    {

        static void Main(string[] args)
        {
            ICreditManager needCreditManager = new NeedCreditManager();           //Bu kısım
            ICreditManager vehicleCreditManager = new VehicleCreditManager();    //ekranda
            ICreditManager housingCreditManager = new HousingCreditManager();   // gözüken yer.
            ICreditManager artisanCreditManager = new ArtisanCreditManager();

            ILoggerService dataLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            // Şimdi ise başvuru yapacağız.

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeAnApplication(new ArtisanCreditManager(), new List<ILoggerService>() { new DatabaseLoggerService(), new SmsLoggerService() });
            //Bir üst satırda kredi çeken kişiye hangi tür kredi çektiğini sms yolu ile ilettik.


            List<ICreditManager> credits = new List<ICreditManager>() { needCreditManager, vehicleCreditManager };
            //applicationManager.MakeALoanPreInformation(credits);


        }
    }
}

