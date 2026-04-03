using System;
public class Prime
{
    public static Boolean isValid(int num) //function
    {
        if (num <= 1)
        {
            return false; //vase case for neg
        }
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0) //factors
            {
                return false;
            }
        }
        return true;
    }
    public static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(isValid(n)); //calling funct
    }
}