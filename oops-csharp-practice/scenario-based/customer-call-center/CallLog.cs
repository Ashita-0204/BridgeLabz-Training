using System;
public class CallLog
{
    public string PhoneNum { get; set; }
    public string Message { get; set; }
    public DateTime TimeStamp { get; set; }

    public void Display()
    {
        Console.WriteLine("Phone: " + PhoneNum);
        Console.WriteLine("Message: " + Message);
        Console.WriteLine("Time: " + TimeStamp);
    }
}
