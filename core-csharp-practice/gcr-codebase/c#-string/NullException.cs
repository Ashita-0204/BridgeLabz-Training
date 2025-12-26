using System;
class NullException
{
    public static void Main()
    {
        try
        { //try block
            string str = null;
            Console.WriteLine(str.Length);
        }
        catch (NullReferenceException)
        { //catch block
            Console.WriteLine("The Null exception is there");
        }
    }
}