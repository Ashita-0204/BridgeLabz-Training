using System;
class Smallest
{
    public static void Main()
    { //Input
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        if (num1 < num2 && num1 < num3) //Condition
        {
            Console.WriteLine("Is the first number the smallest? No");
        }
        else if (num1 < num2 && num1 < num3) { }
        else
        {
            Console.WriteLine("Is the first number the smallest? Yes");
        }
    }
}