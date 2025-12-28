using System;
class TimeZone
{
    public static void Main()
    {
        DateTimeOffset utcTime = DateTimeOffset.UtcNow;
        Console.WriteLine("Current UTC Time: " + utcTime);

        // GMT (Greenwich Mean Time)
        TimeZoneInfo gmtZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");
        DateTimeOffset gmtTime = TimeZoneInfo.ConvertTime(utcTime, gmtZone);
        Console.WriteLine("GMT Time: " + gmtTime);

        // PST (Pacific Standard Time)
        TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
        DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcTime, pstZone);
        Console.WriteLine("PST Time: " + pstTime);

        // IST (Indian Standard Time)
        TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
        DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcTime, istZone);
        Console.WriteLine("IST Time: " + istTime);
    }
}