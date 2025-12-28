using System;

class Factorial
{
    public static int Factorial(int num)
    {
        if (num == 0)
        { //base case
            return 1;
        }
        return num * Factorial(num - 1); //recursive call
    }

    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Factorials are " + Factorial(num));
    }
}
