using System;
class IndexException
{
    public static void Main()
    {
        try //try block
        {
            string str = "Woody";
            Console.WriteLine(str[15]);
        }
        catch (IndexOutOfRangeException)
        { //catch block

            Console.WriteLine("The index accessed is out of range");
        }
    }
}