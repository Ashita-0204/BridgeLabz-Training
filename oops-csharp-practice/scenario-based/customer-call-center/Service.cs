using System;
class Service
{
    public static void Main()
    {
        LogManager manager = new LogManager();
        manager.AddCallLog(new CallLog
        {
            PhoneNumber = "9874563210",
            Message = "Billing ",
            TimeStamp = DateTime.Now
        });

        manager.SearchByKey("Billing");

        // Filter by time
        manager.Filter(DateTime.Now.AddHours(-3), DateTime.Now);
    }
}
