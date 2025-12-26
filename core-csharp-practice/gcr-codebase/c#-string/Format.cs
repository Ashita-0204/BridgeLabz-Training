using System;

class Format
{
    public static void Main()
    {
        try
        { //try block
            int num = int.Parse("str");
        }
        catch (FormatException)
        { //catch block
            Console.WriteLine("Format Exception is there");
        }
    }
}
