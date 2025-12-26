using System;

class ArgumentException
{
    public static void Main()
    {
        try //try block
        {
            string str = "Woody";
            Console.WriteLine(str.Substring(3, 13));
        }
        catch (ArgumentOutOfRangeException)
        { //catch block
            Console.WriteLine("The Argument is out of range");
        }
    }
}
