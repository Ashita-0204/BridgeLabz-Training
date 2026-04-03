using System;
class PositiveNegative
{
    public static int valid(int num) //conditioning check
    {
        if (num < 0)
        {
            return -1;
        }
        if (num > 0)
        {
            return 1;
        }
        return 0;
    }
    public static void Main()
    {
        //the input
        Console.Write("Number");
        int num = int.Parse(Console.ReadLine());
        //calling the method
        int res = valid(num);
        //printing 
        Console.WriteLine("The result of the outcome is" + res);
    }
}