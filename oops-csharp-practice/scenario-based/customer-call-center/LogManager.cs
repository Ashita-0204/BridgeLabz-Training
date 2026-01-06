using System;
public class LogManager
{
    private CallLog[] logs = new CallLog[10];
    private int count = 0;

    // Add a new call log
    public void AddCallLog(CallLog log)
    {
        if (count < logs.Length)
        {
            logs[count] = log;
            count++;
        }
    }

    // Search logs by keyword
    public void SearchByKey(string keyword)
    {
        for (int i = 0; i < count; i++)
        {
            if (logs[i].Message.Contains(keyword))
            {
                logs[i].Display();
            }
        }
    }

    // Filter logs 
    public void Filter(DateTime start, DateTime end)
    {
        Console.WriteLine("Filtering logs by time range");

        for (int i = 0; i < count; i++)
        {
            if (logs[i].TimeStamp >= start && logs[i].TimeStamp <= end)
            {
                logs[i].Display();
            }
        }
    }
}
