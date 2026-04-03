using System;
class Divisibility
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());//input
        //condition
        if (num % 5 == 0)
        {
            Console.WriteLine("Is the number " + num + " divisible by 5? Yes");
        }
        else
        {
            Console.WriteLine("Is the number " + num + " divisible by 5? No");
        }
    }
}