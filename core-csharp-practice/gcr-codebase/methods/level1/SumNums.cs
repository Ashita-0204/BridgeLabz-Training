using System;
class SumNum
{
    public static int sum(int num)
    {
        int sum = 0;
        for (int i = 0; i < num; i++) //loop to calc sum
        {
            sum += i;
        }
        return sum;
    }
    public static void Main()
    {
        //The input
        int num = int.Parse(Console.ReadLine());
        int ans = sum(num); //calling method
        Console.WriteLine("The Sum of n Natural nums is" + ans);
    }
}